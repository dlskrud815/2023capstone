using EUV.Utility;
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
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DrawingPoint = System.Drawing.Point;
using WindowsPoint = System.Windows.Point;


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
        //private List<Point[]> polygonList = new List<Point[]>();
        private List<DrawingPoint[]> polygonList = new List<DrawingPoint[]>();


        /// 다각형 선택자
        private PolygonSelector polygonSelector;

        // 마커 그리기
        private GMapOverlay markersOverlay;
        private int markerCount;
        private int maxMarkerCount;
        private bool enableMarkerCreation;

        #endregion

        private MainForm mainForm;

        public List<string> algo_ids { get; set; } = new List<string>();
        public List<string> algo_gpsValues { get; set; } = new List<string>();

        public void SetDroneValue1(List<string> ids, List<string> gpsValues)
        {
            algo_ids.Clear(); // Clear the existing items before populating
            algo_gpsValues.Clear(); // Clear the existing items before populating

            algo_ids.AddRange(ids); // Add all items from the 'ids' list
            algo_gpsValues.AddRange(gpsValues); // Add all items from the 'gpsValues' list
        }

        public RouteDraw(MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
            RouteMapInitializing();
            //LoadConfiguration();

            cboRoute.SelectedIndexChanged += cboRoute_SelectedIndexChanged;
            cboPoly.SelectedIndexChanged += cboPoly_SelectedIndexChanged;

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

            using (Pen pen = new Pen(Color.Blue, 2))
            {
                foreach (DrawingPoint[] pointArray in this.polygonList)
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
            cboPoly.Text = "- 저장 다각형 -";
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
                RouteMap.ContextMenu.Show(RouteMap, new System.Drawing.Point(e.X, e.Y));
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

            algorithmsForm = new AlgorithmsForm(this.mainForm)
            {
                Owner = this
            };

            algorithmsForm.SetLocationsValue(markersList);
            algorithmsForm.SetDroneValue2(algo_ids, algo_gpsValues);
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

                if (cboPoly.InvokeRequired)
                {
                    cboPoly.Invoke(new Action(() =>
                    {
                        foreach (var key in appSettings.AllKeys)
                        {
                            if (key.StartsWith("PolygonCheck-"))
                            {
                                string polyName = key.Substring("PolygonCheck-".Length);
                                cboPoly.Items.Add(polyName);
                            }
                        }
                    }));
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        if (key.StartsWith("PolygonCheck-"))
                        {
                            string polyName = key.Substring("PolygonCheck-".Length);
                            cboPoly.Items.Add(polyName);
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
        }

        private void btnSavePoly_Click(object sender, EventArgs e)
        {
            List<string> pointStrings = new List<string>();
            List<string> pointNumStrings = new List<string>();

            int pointIndexCheck = 0;
            int numCheck = 0;

            foreach (var pointArray in this.polygonList)
            {
                pointIndexCheck++;

                if(pointIndexCheck%2 == 1)
                {
                    numCheck++;

                    foreach (var point in pointArray)
                    {
                        string xyString = $"{point.X},{point.Y}";
                        pointStrings.Add(xyString);

                        //Console.WriteLine("포인트리스트: " + point.ToString());
                    }
                }
            }

            //다각형 갯수, 다각형 꼭짓점 갯수
            pointNumStrings.Add(numCheck.ToString());

            pointIndexCheck = 0;

            foreach (var pointArray in this.polygonList)
            {
                pointIndexCheck++;

                if (pointIndexCheck % 2 == 0)
                {
                    int pointNumCheck = 0;

                    foreach (var point in pointArray)
                    {
                        pointNumCheck++;
                    }
                    pointNumStrings.Add(pointNumCheck.ToString());
                }
            }

            string savePoints = string.Join(";", pointStrings);
            string numPoints = string.Join(";", pointNumStrings); 
            //ex) 삼각형1 사각형1을 그렸을 경우, [도형 갯수, 도형1 꼭짓점 갯수, 도형2 꼭짓점 갯수] -> [2,3,4]로 표시

            Console.WriteLine("포인트리스트: " + savePoints + "다각형 갯수: " + numPoints);

            ///*
            if (cboPoly.Text != "" && cboPoly.Text != "- 저장 다각형 -")
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = configFile.AppSettings.Settings;

                // 설정 파일에 다각형의 pointList를 저장
                string polygonKey1 = "PolygonPoint-" + cboPoly.Text;
                string polygonValue1 = savePoints;

                string polygonKey2 = "PolygonCheck-" + cboPoly.Text;
                string polygonValue2 = numPoints;

                appSettings.Add(polygonKey1, polygonValue1);
                appSettings.Add(polygonKey2, polygonValue2);

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                // cboPoly 콤보박스에 항목 추가
                cboPoly.Items.Add(cboPoly.Text);

                // txtRouteSaveName 텍스트 초기화
                cboPoly.Text = "- 저장 다각형 -";
            }
            else
            {
                MessageBox.Show("다각형 저장명을 확인해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                cboPoly.SelectAll();
            }
            //*/
        }

        private void cboPoly_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.polygonList.Clear();
            this.RouteMap.Invalidate(); // 지운 후, 지도를 다시 그려줍니다.

            string selectedPointArray = cboPoly.SelectedItem.ToString(); //선택 경로명

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = configFile.AppSettings.Settings;

            string key1 = "PolygonPoint-" + selectedPointArray;
            string key2 = "PolygonCheck-" + selectedPointArray;

            string configValue1 = ConfigurationManager.AppSettings[key1];
            string configValue2 = ConfigurationManager.AppSettings[key2];

            string[] polyPointStrings = configValue1.Split(';');
            string[] polyCheckStrings = configValue2.Split(';');

            List<System.Drawing.Point> pointList = new List<System.Drawing.Point>();
            List<int> polyCheck = new List<int>();

            foreach (string checkString in polyCheckStrings)
            {
                polyCheck.Add(int.Parse(checkString));
            }

            foreach (string pointString in polyPointStrings)
            {
                string[] coordinates = pointString.Split(',');

                int X = int.Parse(coordinates[0]);
                int Y = int.Parse(coordinates[1]);

                System.Drawing.Point point = new System.Drawing.Point(X, Y);
                pointList.Add(point);
            }

            int drawPolyNum = polyCheck[0];
            int indexCheck = 0;

            this.polygonList.Clear();

            for (int i=1; i<polyCheck.Count(); i++)
            { 
                int drawPointNum = polyCheck[i];
                //this.polygonList.Add(e.PointList.ToArray());
                this.polygonList.Add(pointList.GetRange(indexCheck, drawPointNum).ToArray());
                indexCheck += drawPointNum;
            }
            
            this.RouteMap.Paint += RouteMap_Paint;
        }

        private void btnDeletePoly_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = configFile.AppSettings.Settings;

            string name1 = "PolygonPoint-" + cboPoly.SelectedItem.ToString(); // ex) MarkerLocations-경로1
            string name2 = "PolygonCheck-" + cboPoly.SelectedItem.ToString();

            string key1 = appSettings.AllKeys.FirstOrDefault(k => k.EndsWith(name1));
            string key2 = appSettings.AllKeys.FirstOrDefault(k => k.EndsWith(name2));

            // 해당 name을 가진 항목 제거
            if (key1 != null || key2 != null)
            {
                appSettings.Remove(key1);
                appSettings.Remove(key2);
            }

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

            cboPoly.Text = "- 저장 다각형 -";
        }
    }
}