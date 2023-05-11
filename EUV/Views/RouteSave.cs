using GMap.NET;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EUV.Views
{
    public partial class RouteSave : MaterialForm
    {
        private List<PointLatLng> markerLocations = new List<PointLatLng>();

        public RouteSave()
        {
            InitializeComponent();
        }

        private void RouteSave_Load(object sender, EventArgs e)
        {

        }

        public void SetMarkerLocations(List<PointLatLng> locations)
        {
            markerLocations = locations;
        }

        private void btnRouteSet_Click(object sender, EventArgs e)
        {
            foreach (var location in markerLocations)
            {
                Console.WriteLine("위도: {0}, 경도: {1}", location.Lat, location.Lng);
            }

            //Console.WriteLine("[0]: {0}, [2]: {1}", markerLocations[0].Lat, markerLocations[2]);

            // 파일 이름 가져오기
            string fileName = txtRouteSaveName.Text;

            // 파일 쓰기
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var location in markerLocations)
                {
                    writer.WriteLine("{0},{1}", location.Lat, location.Lng);
                }
            }

            // 리스트뷰 초기화
            listView2.Items.Clear();

            // 파일 읽기
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                // 리스트뷰에 항목 추가
                ListViewItem item = new ListViewItem(fileName);

                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    double lat = double.Parse(fields[0]);
                    double lng = double.Parse(fields[1]);

                    item.SubItems.Add(lat.ToString());
                    item.SubItems.Add(lng.ToString());
                }
                listView2.Items.Add(item);
            }

            MessageBox.Show("저장 및 로드가 완료되었습니다.");
        }

        private void btnRouteAdd_Click(object sender, EventArgs e)
        {
            if (txtRouteSaveName.Text != "" && txtRouteSaveName.Text != "- 저장 경로명 - ")
            {
                SaveConfiguration(string.Format("경로명-{0}", txtRouteSaveName.Text));
                BeginInvoke((Action)delegate
                {
                    listView2.Items.Clear();
                });
                LoadConfiguration();
            }
            else
            {
                MessageBox.Show("경로명 확인", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                txtRouteSaveName.SelectAll();
            }
        }

        public void LoadConfiguration()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result;

                foreach (string key in appSettings.AllKeys)
                {
                    if (key.Contains("경로명"))
                    {
                        result = appSettings[key] ?? string.Empty;
                        if (result != string.Empty)
                        {
                            string[] lvi = new string[] { key.Substring(key.LastIndexOf("-") + 1) };
                            ListViewItem newitem = new ListViewItem(lvi);

                            BeginInvoke((Action)delegate
                            {
                                listView2.Items.Add(newitem);
                            });
                        }
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Configration error exception occur!");
            }
        }

        public void SaveConfiguration(string name)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = configFile.AppSettings.Settings;
                int i = listView2.Items.Count;

                if (appSettings[name] != null)
                    appSettings.Remove(name);
                appSettings.Add(name, string.Format("{0},{1}", markerLocations[0].Lat, markerLocations[0].Lat));

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Configration error exception occur!");
            }
        }

        private void DeleteConfiguration(string name)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = configFile.AppSettings.Settings;
                int i = listView2.Items.Count;

                if (appSettings[name] != null)
                {
                    appSettings.Remove(name);
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Configration error exception occur!");
            }
        }

        private void btnRouteDelete_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count < 1)
                return;

            foreach (ListViewItem row in listView2.SelectedItems)
            {
                BeginInvoke((Action)delegate
                {
                    listView2.Items.Remove(row);
                });

                DeleteConfiguration(string.Format("경로명-{0}", row.SubItems[0].Text));
            }
            //txtLat.Text = txtLng.Text = txtBookMarkName.Text = "";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            // 선택한 항목이 없으면 함수를 빠져나옵니다.
            if (listView2.SelectedItems.Count == 0)
                return;

            // 선택한 항목의 인덱스를 가져옵니다.
            int selectedIndex = listView2.SelectedIndices[0];

            // 리스트뷰에서 선택한 항목을 제거합니다.
            ListViewItem selectedItem = listView2.SelectedItems[0];
            listView2.Items.Remove(selectedItem);

            // 선택한 항목을 새로운 위치에 삽입합니다.
            int newIndex = selectedIndex + 1;
            if (newIndex > listView2.Items.Count)
                newIndex = listView2.Items.Count;
            listView2.Items.Insert(newIndex, selectedItem);
        }
    }
}
