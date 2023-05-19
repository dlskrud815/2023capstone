using EUV.Messages;
using GMap.NET;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EUV.Views
{
    public partial class AlgorithmsForm : MaterialForm
    {
        public List<List<PointLatLng>> droneLocationsList { get; private set; } = new List<List<PointLatLng>>();
        public double[][] drone_distance;

        public AlgorithmsForm()
        {
            InitializeComponent();
        }

        public void SetLocationsValue(List<List<PointLatLng>> value)
        {
            droneLocationsList = value;
        }

        private void AlgorithmsForm_Load(object sender, EventArgs e)
        {
            /*
            for(int i = 0; i < droneLocationsList.Count; i++)
            {
                drone_distance[i] = new double[droneLocationsList.Count];

                for(int j = 0; j < droneLocationsList.Count; j++)
                {
                   double tmp_marker_Lat = double.Parse(droneLocationsList[j].Lat);
                   double tmp_marker_Lng = double.Parse(droneLocationsList[j].Lng);

                }

            }
            */

        }

        private void btnAlgorithms_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            foreach (var locations in droneLocationsList)
            {
                Console.WriteLine();
                foreach (var location in locations)
                {
                    Console.WriteLine("위도: {0}, 경도: {1}", location.Lat, location.Lng);
                }
            }
        }

        private void btnDroneMove_Click(object sender, EventArgs e)
        {

        }

        public static double HaversineDistance(double lat1, double lon1, double lat2, double lon2)
        {
            var R = 6371; //지구 반지름 (km)
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c; // km 단위 거리
            return d;
        }

        private static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
