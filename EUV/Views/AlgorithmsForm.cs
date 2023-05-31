using EUV.Messages;
using GMap.NET;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Accord.Math.Optimization;
using EUV.Sockets;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using EUV.Commons;

namespace EUV.Views
{
   
    public partial class AlgorithmsForm : MaterialForm
    {
        public List<List<PointLatLng>> droneLocationsList { get; private set; } = new List<List<PointLatLng>>();
       
        private static AllAboutMessages _instance;
        private List<VehicleMessage> vehicleMessages = new List<VehicleMessage>();

        public double[][] drone_distance;

        public double[] drone_Lng;
        public double[] drone_Lat;

        public double[] marker_Lng;
        public double[] marker_Lat;

        public string[] drone_id;
        public string[] marker_id;

        public int numDrone;

        private MainForm mainForm;
        public List<string> algo_ids { get; set; } = new List<string>();
        public List<string> algo_gpsValues { get; set; } = new List<string>();

        public AlgorithmsForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        public void SetDroneValue2(List<string> ids, List<string> gpsValues)
        {
            algo_ids.Clear(); // Clear the existing items before populating
            algo_gpsValues.Clear(); // Clear the existing items before populating

            algo_ids.AddRange(ids); // Add all items from the 'ids' list
            algo_gpsValues.AddRange(gpsValues); // Add all items from the 'gpsValues' list
        }


        public void SetLocationsValue(List<List<PointLatLng>> value)
        {
            droneLocationsList = value;
        }

        public List<VehicleMessage> VehicleMessages
        {
            get => vehicleMessages;
            //set => vehicleMessages = value;
        }

        private static AllAboutMessages _getInstance()
        {
            if (_instance == null)
            {
                _instance = new AllAboutMessages();
            }
            return _instance;
        }

        private void AlgorithmsForm_Load(object sender, EventArgs e)
        {
        
        }

        private void btnAlgorithms_Click(object sender, EventArgs e)
        {
            foreach (var droneList in droneLocationsList)
            {
                numDrone = droneList.Count;
            }

            // MainForm의 인스턴스를 통해 값을 가져옴
            List<string> algo_ids = mainForm.ids_forCheck;
            List<string> algo_gpsValues = mainForm.gpsValues_forCheck;

            Console.WriteLine();
            Console.WriteLine("경로 개수: " + droneLocationsList.Count);

            Console.WriteLine("리스트 확인 : 개수: " + algo_ids.Count); ////******************************* 이나경 05-22 algo_ids.Count 뽑아쓰면 될 듯

            // 결과 출력
            for (int i = 0; i < algo_ids.Count && i < algo_gpsValues.Count; i++)
            {
                Console.WriteLine($"algo_ids: {algo_ids[i]}, algo_gpsValues: {algo_gpsValues[i]}");
            }


            Console.WriteLine();
            foreach (var locations in droneLocationsList)
            {
                Console.WriteLine();
                foreach (var location in locations)
                {
                    Console.WriteLine("위도: {0}, 경도: {1}", location.Lat, location.Lng);
                }
            }
            // ******* 이나경

            drone_id = new string[numDrone];
            marker_id = new string[numDrone];


            marker_Lng = new double[numDrone];
            marker_Lat = new double[numDrone];


            drone_Lng = new double[numDrone]; // ******* 이나경 
            drone_Lat = new double[numDrone]; //

            /*
            AllAboutMessages._getInstance().VehicleMessages.ToList().ForEach((vm =>
            {
                string select = vm.selected.ToString();
                string id = vm.id.ToString();
                double lat = vm.gps_c_lat;
                double lng = vm.gps_c_lng;

                for (int i = 0; i < 2; i++)
                {
                    drone_id[i] = id;
                    drone_Lat[i] = lat;
                    drone_Lng[i] = lng;
                    Console.WriteLine(drone_id[i]);
                    Console.WriteLine(drone_Lat[i]);
                    Console.WriteLine(drone_Lng[i]);
                }
            }));
            */

            /*
            AllAboutMessages._getInstance().VehicleMessages.ToList().ForEach((vm =>
            {
                int cnt1 = 0;

                string select = vm.selected.ToString();
                string id = vm.id.ToString();
                double lat = vm.gps_c_lat;
                double lng = vm.gps_c_lng;

                int i = cnt1;

                drone_id[i] = id;
                drone_Lat[i] = lat;
                drone_Lng[i] = lng;
                Console.WriteLine(drone_id[i]);
                Console.WriteLine(drone_Lat[i]);
                Console.WriteLine(drone_Lng[i]);

                cnt1++;
            }));
            */

            int droneIndex = 0; // 드론 인덱스 변수 추가

            AllAboutMessages._getInstance().VehicleMessages.ToList().ForEach((vm =>
            {
                string select = vm.selected.ToString();
                string id = vm.id.ToString();
                double lat = vm.gps_c_lat;
                double lng = vm.gps_c_lng;

                if (droneIndex < numDrone)
                {
                    drone_id[droneIndex] = id;
                    drone_Lat[droneIndex] = lat;
                    drone_Lng[droneIndex] = lng;
                    Console.WriteLine(drone_id[droneIndex]);
                    Console.WriteLine(drone_Lat[droneIndex]);
                    Console.WriteLine(drone_Lng[droneIndex]);
                    droneIndex++;
                }
            }));

            int cnt2 = 0;

            // 서지훈 0531
            foreach (var locations in droneLocationsList)
            {
                for (int i = 0; i < locations.Count; i++)
                {
                    var location = locations[i];
                    marker_id[i] = i.ToString();
                    marker_Lat[i] = location.Lat;
                    marker_Lng[i] = location.Lng;
                    cnt2++;
                }
            }

            /*
            foreach (var locations in droneLocationsList)
            {
                foreach (var location in locations)
                {
                    int j = cnt2;
                    marker_id[j] = j.ToString();
                    marker_Lat[j] = location.Lat;
                    marker_Lng[j] = location.Lng;
                    Console.WriteLine(marker_Lat[j]);

                    cnt2++;
                }
            }
            */
            /* 버려
            double[][] drone_distance = new double[2][];
            for (int i = 0; i < 2; i++)
            {
                drone_distance[i] = new double[2];
            }
            */


            // drone_distance 배열 초기화
            drone_distance = new double[numDrone][];
            for (int i = 0; i < numDrone; i++)
            {
                drone_distance[i] = new double[numDrone];
            }


            for (int k = 0; k < numDrone; k++)
            {
                for (int n = 0; n < numDrone; n++)
                {
                    drone_distance[k][n] = HaversineDistance(drone_Lat[k], drone_Lng[k], marker_Lat[n], marker_Lng[n]);
                    richTextBox1.Text += drone_distance[k][n] + "\t";
                }
                richTextBox1.Text += "\n";
            }

            // 서지훈 0531
            double[] sol = shortest_path_algorithm(drone_distance);

            for (int i = 0; i < sol.Length; i++)
            {
                richTextBox1.Text += "드론" + drone_id[i] + "번" + ">>>>>" + "마커" + marker_id[(int)sol[i]] + "번" + "\n";
            }

        }

        private System.Threading.Timer timer; //타이머 변수
        private void btnDroneMove_Click(object sender, EventArgs e)
        {
            double[] sol = shortest_path_algorithm(drone_distance);

            for (int i = 0; i < sol.Length; i++)
            {
                string paramJson = string.Format("{{'LAT':'{0}','LNG':{1},'ALT':{2}}}", marker_Lat[(int)sol[i]], marker_Lng[(int)sol[i]], "0");

                SendMessage cmdMessage = new SendMessage
                {
                    id = int.Parse(drone_id[i]),
                    cmd = "GOHERE",
                    param = paramJson
                };
                string jstr = JsonSerializer.Serialize(cmdMessage);
                int result = TcpSocket._getInstance()._sendmessage(jstr, int.Parse(drone_id[i]));

                if (result == -1)
                {
                    removeVehicle(cmdMessage.id);
                }

                timer = new System.Threading.Timer(TimerCallback, null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
            }
        }
        //서지훈 0531 드론 모드 추가
        public Parameter parameter;
        public string[] drone_mode;
        //추가
        private void TimerCallback(object state)
        {
            int droneIndex = 0; // 드론 인덱스 변수 추가

            drone_Lng = new double[numDrone];
            drone_Lat = new double[numDrone];
            drone_mode = new string[numDrone];

            AllAboutMessages._getInstance().VehicleMessages.ToList().ForEach((vm =>
            {
                string select = vm.selected.ToString();
                string id = vm.id.ToString();
                double lat = vm.gps_c_lat;
                double lng = vm.gps_c_lng;
                string mode = vm.mode.Replace("VehicleMode:", "");

                //parameter = new Parameter(vm.id, mode);
                //parameter.Mode = mode;

                if (droneIndex < numDrone)
                {
                    drone_mode[droneIndex] = mode;
                    drone_id[droneIndex] = id;
                    drone_Lat[droneIndex] = lat;
                    drone_Lng[droneIndex] = lng;
                    droneIndex++;
                }
            }));

            double[] sol = shortest_path_algorithm(drone_distance);

            for (int i = 0; i < sol.Length; i++)
            {
                int remaining_distance = (int)HaversineDistance(drone_Lat[i], drone_Lng[i], marker_Lat[(int)sol[i]], marker_Lng[(int)sol[i]]);
                Console.WriteLine($"{drone_id[i]}번 드론의 남은거리: {remaining_distance} m");

                if (drone_mode[i] == "LOITER")
                {
                    timer.Change(Timeout.Infinite, Timeout.Infinite); // 타이머 멈춤
                }
            }
        }
        //추가
        public double[] shortest_path_algorithm(double[][] drone_distance)
        {
            Munkres m = new Munkres(drone_distance);

            bool success = m.Minimize();    // solve it (should return true)
            double[] solution = m.Solution; // Solution will be 0, 1, 2
            double minimumCost = m.Value;

            return solution;
        }
        public void removeVehicle(int id)
        {
            var index = AllAboutMessages._getInstance().VehicleMessages.FindIndex(c => c.id == id);
            if (index >= 0)
                AllAboutMessages._getInstance().VehicleMessages.RemoveAt(index);
        }
        public static double HaversineDistance(double lat1, double lon1, double lat2, double lon2)
        {
            var R = 6371; //지구 반지름 (km)
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c * 1000; // m 단위 거리
            return d;
        }
        private static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
