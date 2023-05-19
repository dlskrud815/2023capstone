﻿using EUV.Utility;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.ObjectModel;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EUV.Views
{
    public partial class RouteDraw : MaterialForm
    {
        public List<List<PointLatLng>> markersList = new List<List<PointLatLng>>();

        Theme theme;    // 테마

        RouteSave routeSave;
        AlgorithmsForm algorithmsForm;

        // 스레드
        Thread thread;
        bool isThread = false;

        PointLatLng Point;

        Double RouteMapCenterLat;
        Double RouteMapCenterLng;

        private GMapOverlay gridOverlay;
        double grid_height;
        double grid_width;

        private bool draw_marker;
        private int marker_num;
        GMarkerGoogle marker;
        // 리스트 생성
        private List<PointLatLng> markerLocations = new List<PointLatLng>();

        private int forCheck = 0;
        // 그리기
        #region Field

        /// 다각형 리스트
        private List<Point[]> polygonList = new List<Point[]>();

        /// 다각형 선택자
        private PolygonSelector polygonSelector;

        // 마커 그리기
        private GMapOverlay markersOverlay;
        private int markerCount;
        private int maxMarkerCount;
        private bool enableMarkerCreation;

        #endregion

        public RouteDraw()
        {
            InitializeComponent();
            RouteMapInitializing();
            //LoadConfiguration();

            cboRoute.SelectedIndexChanged += cboRoute_SelectedIndexChanged;

            // Register the OnMapZoomChanged event handler
            RouteMap.OnMapZoomChanged += RouteMap_OnMapZoomChanged;

            // Create a new overlay for the grid
            gridOverlay = new GMapOverlay("Grid");
            DrawGrid();
            RouteMap.Overlays.Add(gridOverlay);

            drawPolygonCheckBox.Checked = false;

            this.drawPolygonCheckBox.CheckedChanged += drawPolygonCheckBox_CheckedChanged;
            this.RouteMap.Paint += RouteMap_Paint;

            this.polygonSelector = new PolygonSelector(this.RouteMap, new Pen(Color.Red, 2));
            this.polygonSelector.PolygonSelected += polygonSelector_PolygonSelected;

            if (MainForm.selectDroneNum >= 1)
            {
                droneNum.Text = MainForm.selectDroneNum.ToString();
            }
            else
            {
                droneNum.Text = 0.ToString();
            }

            draw_marker = false;

            marker_num = int.Parse(numTest.Text);
            Console.WriteLine("선택 드론 갯수: " + marker_num.ToString());
            //선택 드론 갯수

        }

        private void RouteMapInitializing()
        {
            RouteMap.MapProvider = GMapProviders.GoogleMap;
            RouteMap.Position = new PointLatLng(35.609816038724, 129.375128746033);

            RouteMap.Manager.Mode = AccessMode.ServerAndCache;
            RouteMap.ShowCenter = false;
            RouteMap.GrayScaleMode = false;
            RouteMap.CanDragMap = true;
            RouteMap.DragButton = MouseButtons.Left;

            RouteMap.MinZoom = 1;
            RouteMap.MaxZoom = 30;
            RouteMap.Zoom = 18; //기본값

            markerCount = 0;
            maxMarkerCount = 0;
            enableMarkerCreation = false;
        }

        #region 폼 로드시 처리하기 - Form_Load(sender, e)

        /// <summary>
        /// 폼 로드시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void RouteDraw_Load(object sender, EventArgs e)
        {
            LoadConfiguration();

            theme = new Theme(this, Container);
            theme.ThemeMode = ((MainForm)(Owner)).theme.ThemeMode;
            Point = ((MainForm)(Owner)).point;

            RouteMapCenterLat = ((MainForm)(Owner)).MainMap.Position.Lat;
            RouteMapCenterLng = ((MainForm)(Owner)).MainMap.Position.Lng;

            RouteMap.Position = new PointLatLng(RouteMapCenterLat, RouteMapCenterLng);
            RouteMap.Zoom = ((MainForm)(Owner)).MainMap.Zoom;


            // 마커를 표시할 Overlay 생성 및 MainMap에 추가
            markersOverlay = new GMapOverlay("markers");
            RouteMap.Overlays.Add(markersOverlay);

            drawPolygonCheckBox.Checked = false;

            // 그리드 그리기
            DrawGrid();
            RouteMap.Refresh();

            //
            // drawPolygonCheckBox의 초기 상태 확인
            if (drawPolygonCheckBox.Checked)
            {
                polygonSelector.Enabled = true;
                this.polygonSelector.PolygonSelected += polygonSelector_PolygonSelected;
            }
            else
            {
                polygonSelector.Enabled = false;
                this.polygonSelector.PolygonSelected -= polygonSelector_PolygonSelected;
            }

            // 처음에 시작할 때만 지도 클릭 이벤트를 처리합니다.
            if (!drawPolygonCheckBox.Checked)
            {
                RouteMap.MouseUp -= RouteMap_MouseUp;
                //btnNodeSelect.Enabled = false;
                //enableMarkerCreation = false;
            }
            else
            {
                RouteMap.MouseUp += RouteMap_MouseUp;
                //btnNodeSelect.Enabled = true;
                //enableMarkerCreation = true;
            }
        }
        #endregion

        private void RouteMap_OnMapZoomChanged()
        {
            grid_height = RouteMap.Height;
            grid_width = RouteMap.Width;

            gridOverlay.Polygons.Clear();
            DrawGrid();
            RouteMap.Refresh();

        }

        private void DrawGrid()
        {
            double latDelta = 0.0000898318; // 1도당 약 111.32km, 1m당 약 0.00000898318도
            double lngDelta = 0.0001139370; // 1도당 약 111.32km, 1m당 약 0.00001139370도

            double latMin = RouteMap.FromLocalToLatLng(-3 * RouteMap.Width, 3 * RouteMap.Height).Lat;
            double latMax = RouteMap.FromLocalToLatLng(3 * RouteMap.Width, -3 * RouteMap.Height).Lat;
            double lngMin = RouteMap.FromLocalToLatLng(-3 * RouteMap.Width, -3 * RouteMap.Height).Lng;
            double lngMax = RouteMap.FromLocalToLatLng(3 * RouteMap.Width, 3 * RouteMap.Height).Lng;

            // 그리드 그리는 조건 추가
            if (RouteMap.Zoom >= 18)
            {
                // Create a new polygon for each row and column of the grid
                for (double lat = latMin; lat <= latMax; lat += latDelta)
                {
                    List<PointLatLng> points = new List<PointLatLng>();

                    for (double lng = lngMin; lng <= lngMax; lng += lngDelta)
                    {
                        points.Add(new PointLatLng(lat, lng));
                    }

                    GMapPolygon rowPolygon = new GMapPolygon(points, "Grid");
                    rowPolygon.Stroke = new Pen(Color.FromArgb(150, Color.DarkGreen), 2);
                    rowPolygon.Fill = Brushes.Transparent;

                    gridOverlay.Polygons.Add(rowPolygon);
                }

                for (double lng = lngMin; lng <= lngMax; lng += lngDelta)
                {
                    List<PointLatLng> points = new List<PointLatLng>();

                    for (double lat = latMin; lat <= latMax; lat += latDelta)
                    {
                        points.Add(new PointLatLng(lat, lng));
                    }

                    GMapPolygon colPolygon = new GMapPolygon(points, "Grid");
                    colPolygon.Stroke = new Pen(Color.FromArgb(150, Color.DarkGreen), 2);
                    colPolygon.Fill = Brushes.Transparent;

                    gridOverlay.Polygons.Add(colPolygon);
                }
            }
        }

        #region 다각형 선택자 다각형 선택시 처리하기 - polygonSelector_PolygonSelected(sender, e)

        /// <summary>
        /// 다각형 선택자 다각형 선택시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void polygonSelector_PolygonSelected(object sender, PolygonEventArgs e)
        {
            this.polygonList.Add(e.PointList.ToArray());

            this.RouteMap.Refresh();
        }

        #endregion

        #region 다각형 그리기 체크 박스 체크 변경시 처리하기 - drawPolygonCheckBox_CheckedChanged(sender, e)

        /// <summary>
        /// 다각형 그리기 체크 박스 체크 변경시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void drawPolygonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (drawPolygonCheckBox.Checked)
            {
                polygonSelector.Enabled = true;
                this.polygonSelector.PolygonSelected += polygonSelector_PolygonSelected;
            }
            else
            {
                polygonSelector.Enabled = false;
                this.polygonSelector.PolygonSelected -= polygonSelector_PolygonSelected;
            }
            /*
            if (drawPolygonCheckBox.Checked)
            {
                RouteMap.CanDragMap = false;
            }
            else
            {
                RouteMap.CanDragMap = true;
                RouteMap.DragButton = MouseButtons.Left;
            }
            */
        }

        #endregion

        #region 픽처 박스 페인트시 처리하기 - pictureBox_Paint(sender, e)

        /// <summary>
        /// 픽처 박스 페인트시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void RouteMap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Green, 2))
            {
                foreach (Point[] pointArray in this.polygonList)
                {
                    e.Graphics.DrawPolygon(pen, pointArray);
                }
            }
        }
        #endregion

        private void btnRemoveDraw_Click(object sender, EventArgs e)
        {
            // Clear all drawings
            this.polygonList.Clear();
            this.RouteMap.Invalidate(); // 지운 후, 지도를 다시 그려줍니다.
        }


        private void btnNodeSelect_Click(object sender, EventArgs e)
        {
            maxMarkerCount = int.Parse(numTest.Text);

            // 지도 클릭 이벤트 등록
            RouteMap.MouseUp -= RouteMap_MouseUp; // 두 번씩 클릭 이벤트 발생하는 거 해결
            RouteMap.MouseUp += RouteMap_MouseUp;

            // 마커 생성 버튼 비활성화
            btnNodeSelect.Enabled = false;

            // 마커 생성 활성
            enableMarkerCreation = true;
        }

        private void RouteMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PointLatLng point = RouteMap.FromLocalToLatLng(e.X, e.Y);

                ContextMenu menu = new ContextMenu();
                MenuItem deleteItem = new MenuItem("Delete Marker");
                deleteItem.Click += new EventHandler(deleteItem_Click);
                menu.MenuItems.Add(deleteItem);

                RouteMap.ContextMenu = menu;
                RouteMap.ContextMenu.Show(RouteMap, new Point(e.X, e.Y));
            }
        }
        private void deleteItem_Click(object sender, EventArgs e)
        {
            GMapOverlay markersOverlay = RouteMap.Overlays.FirstOrDefault(x => x.Id == "markers");
            if (markersOverlay != null)
            {
                GMapMarker clickedMarker = markersOverlay.Markers.FirstOrDefault(x => x.IsMouseOver);
                if (clickedMarker != null)
                {
                    markersOverlay.Markers.Remove(clickedMarker);
                    RouteMap.Update();
                    markerCount = markersOverlay.Markers.Count;

                    // 마커 생성 버튼과 지도 클릭 이벤트 상태 조정
                    if (markerCount < maxMarkerCount)
                    {
                        RouteMap.MouseUp += RouteMap_MouseUp;
                        btnNodeSelect.Enabled = true;
                        enableMarkerCreation = true;
                    }
                }
            }
        }


        private void RouteMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (enableMarkerCreation && e.Button == MouseButtons.Left)
            {
                // 클릭한 위치를 위도, 경도로 변환
                PointLatLng markerLocation = RouteMap.FromLocalToLatLng(e.X, e.Y);

                // 해당 위치에 이미 마커가 있는지 확인
                bool isMarkerExist = CheckIfMarkerExists(markerLocation);
                if (isMarkerExist)
                {
                    // 이미 마커가 있는 경우 처리 로직 추가
                    return;
                }

                // 마커 생성
                GMarkerGoogle marker = new GMarkerGoogle(markerLocation, GMarkerGoogleType.red);

                // 마커를 표시할 Overlay에 마커 추가
                markersOverlay.Markers.Add(marker);
                // 리스트에 클릭한 위치 추가
                markerLocations.Add(markerLocation);

                // 마커 개수 증가
                markerCount = markersOverlay.Markers.Count;

                // 사용자가 지정한 마커 개수를 초과하면 지도 클릭 이벤트를 해제하고 마커 생성 버튼 비활성화
                if (markerCount >= maxMarkerCount)
                {
                    RouteMap.MouseUp -= RouteMap_MouseUp;
                    btnNodeSelect.Enabled = false;
                    enableMarkerCreation = false;
                }
            }
        }

        private bool CheckIfMarkerExists(PointLatLng location)
        {
            foreach (GMapMarker existingMarker in markersOverlay.Markers)
            {
                if (existingMarker.Position == location)
                {
                    return true;
                }
            }
            return false;
        }

        public List<PointLatLng> GetMarkerLocations()
        {
            return markerLocations;
        }

        private void grpDraw_Enter(object sender, EventArgs e)
        {

        }

        private void drawSaveBtn_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in System.Windows.Forms.Application.OpenForms)
            {
                if (openForm.Name == "RouteSave") // 열린 폼의 이름 검사
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {
                        // 폼을 최소화시켜 하단에 내려놓았는지 검사
                        openForm.WindowState = FormWindowState.Normal;
                    }
                    openForm.Activate();
                    return;
                }
            }

            routeSave = new RouteSave
            {
                Owner = this
            };

            routeSave.SetNumTestValue(numTest.Text);
            routeSave.SetMarkerLocations(markerLocations);
            routeSave.Show();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in System.Windows.Forms.Application.OpenForms)
            {
                if (openForm.Name == "AlgorithmsForm") // 열린 폼의 이름 검사
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {
                        // 폼을 최소화시켜 하단에 내려놓았는지 검사
                        openForm.WindowState = FormWindowState.Normal;
                    }
                    openForm.Activate();
                    return;
                }
            }

            algorithmsForm = new AlgorithmsForm
            {
                Owner = this
            };

            algorithmsForm.SetLocationsValue(markersList);
            algorithmsForm.Show();
        }

        public void LoadConfiguration()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (cboRoute.InvokeRequired)
                {
                    cboRoute.Invoke(new Action(() =>
                    {
                        foreach (var key in appSettings.AllKeys)
                        {
                            if (key.StartsWith("MarkerList-"))
                            {
                                string routeName = key.Substring("MarkerList-".Length);
                                cboRoute.Items.Add(routeName);
                            }
                        }
                    }));
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        if (key.StartsWith("MarkerList-"))
                        {
                            string routeName = key.Substring("MarkerList-".Length);
                            cboRoute.Items.Add(routeName);
                        }
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Configration error exception occur!");
            }
            catch { }
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoute = cboRoute.SelectedItem.ToString(); //선택 경로명
            Console.WriteLine("콤보박스 내 선택항목: " + selectedRoute);


            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = configFile.AppSettings.Settings;

            string key2 = "MarkerList-" + selectedRoute; // ex) MarkerList-경로확인1
            string configValue = ConfigurationManager.AppSettings[key2];
            string[] locationStrings = configValue.Split(';');
            List<string> checks = new List<string>(new string[locationStrings.Length]);

            foreach (string locationString in locationStrings)
            {
                string[] coordinates = locationString.Split(',');

                string routeName = coordinates[0];
                string routeIndex = coordinates[1];

                checks[int.Parse(routeIndex)] = routeName;
            }

            int index1 = 0;

            markersList.Clear();

            foreach (string check in checks)
            {
                string selectedKey = "MarkerLocations-" + check; // 리스트뷰 경로명

                // 설정 파일에서 문자열로 변환된 경로리스트
                string configValue2 = ConfigurationManager.AppSettings[selectedKey];

                string[] locationStrings2 = configValue2.Split(';');

                List<PointLatLng> tempLocations = new List<PointLatLng>();
                tempLocations.Clear();

                foreach (string locationString2 in locationStrings2)
                {
                    string[] coordinates = locationString2.Split(',');
                    double latitude = double.Parse(coordinates[0]);
                    double longitude = double.Parse(coordinates[1]);

                    PointLatLng point = new PointLatLng(latitude, longitude);
                    // 분할된 문자열로부터 PointLatLng 인스턴스를 생성하여 리스트에 추가합니다.

                    tempLocations.Add(point);
                }

                markersList.Add(tempLocations);

                Console.WriteLine();
                Console.WriteLine("경로명: " + check + ", 인덱스:" + index1);

                foreach (var location in tempLocations)
                {
                    Console.WriteLine("위도: {0}, 경도: {1}", location.Lat, location.Lng);
                }

                index1++;
            }

            /*
            Console.WriteLine();
            foreach (var locations in markersList) ** 지훈님쓰 이렇게 markerList에서 일반리스트에 double로 넣든 해서 알고리즘 돌리면 될 듯쓰?
            {
                Console.WriteLine();
                foreach (var location in locations)
                {
                    Console.WriteLine("위도: {0}, 경도: {1}", location.Lat, location.Lng);
                }
            }
            */
        }
    }
}