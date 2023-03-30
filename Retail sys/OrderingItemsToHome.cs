using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GoogleMaps.LocationServices;

namespace Retail_sys
{
    public partial class OrderingItemsToHome : Form
    {
       
        public OrderingItemsToHome()
        {
            InitializeComponent();

        }
        private void OrderingItemsToHome_Load_1(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = Key.key;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton = MouseButtons.Left;
            map.SetPositionByKeywords("Preston, Great Britain");
            map.ShowCenter = false;

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(53.757487, -2.688573),
                GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);


            marker.ToolTipText = "Store Location";
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.Orange;
            marker.ToolTip.TextPadding = new Size(10, 1);

        }

        private double latituded;
        private double longituded;
        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Clears any old markers places by the user, but not store location
                if (map.Overlays.Count > 1) { map.Overlays.RemoveAt(1); map.Refresh(); }

                //Finds the lat and long of where the user clicks to place a marker
                var point = map.FromLocalToLatLng(e.X, e.Y);
                latituded = point.Lat;
                longituded = point.Lng;

                map.Position = point;

                GMapOverlay markersz = new GMapOverlay("CustMarker");
                GMapMarker markerz = new GMarkerGoogle(
                    new PointLatLng(latituded, longituded),
                    GMarkerGoogleType.red_dot);
                markersz.Markers.Add(markerz);
                map.Overlays.Add(markersz);

                markerz.ToolTipText = "Customer's House Location";
                markerz.ToolTip.Fill = Brushes.Black;
                markerz.ToolTip.Foreground = Brushes.Orange;
                markerz.ToolTip.TextPadding = new Size(10, 1);
            }
        }
        private void btnDistance_Click(object sender, EventArgs e)
        {
            if (map.Overlays.Count > 0) { map.Overlays.RemoveAt(0); map.Refresh(); }

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(53.757487, -2.688573),
                GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            marker.ToolTipText = "Store Location";
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.Orange;
            marker.ToolTip.TextPadding = new Size(10, 1);

            GMapOverlay markersz = new GMapOverlay("CustMarker");
            GMapMarker markerz = new GMarkerGoogle(
                new PointLatLng(latituded, longituded),
                GMarkerGoogleType.red_dot);
            markersz.Markers.Add(markerz);
            map.Overlays.Add(markersz);

            markerz.ToolTipText = "Customer's House Location";
            markerz.ToolTip.Fill = Brushes.Black;
            markerz.ToolTip.Foreground = Brushes.Orange;
            markerz.ToolTip.TextPadding = new Size(10, 1);

            GMapProviders.GoogleMap.ApiKey = Key.key;
            map.ReloadMap();
            MessageBox.Show("You may have to zoom in to view the route");
            PointLatLng first = new PointLatLng(53.757487, -2.688573);
            PointLatLng second = new PointLatLng(latituded,longituded );
            var route = GoogleMapProvider.Instance.GetRoute(first, second, false, false, 13);
            var r = new GMapRoute(route.Points, "My Route")
            {
                Stroke = new Pen(Color.Red, 5)
            };
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
            string dist = route.Distance.ToString();
            MessageBox.Show("The distance from the store tou you address is: " + dist + "km. Order has been placed");


        }
        private void btnMapReset_Click(object sender, EventArgs e)
        {
            if (map.Overlays.Count > 0) { map.Overlays.RemoveAt(0); map.Refresh(); }

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(53.757487, -2.688573),
                GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            marker.ToolTipText = "Store Location";
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.Orange;
            marker.ToolTip.TextPadding = new Size(10, 1);

            GMapOverlay markersz = new GMapOverlay("CustMarker");
            GMapMarker markerz = new GMarkerGoogle(
                new PointLatLng(latituded, longituded),
                GMarkerGoogleType.red_dot);
            markersz.Markers.Add(markerz);
            map.Overlays.Add(markersz);

            markerz.ToolTipText = "Customer's House Location";
            markerz.ToolTip.Fill = Brushes.Black;
            markerz.ToolTip.Foreground = Brushes.Orange;
            markerz.ToolTip.TextPadding = new Size(10, 1);
        }
        private void btnMainmenurtrn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new Checkout();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnexitsys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void map_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Do you want a receipt?", "Get A Receipt?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                var opencustform = new Receipt();
                opencustform.Closed += (s, args) => this.Close();
                opencustform.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                var opencustform = new OrderingItemsToHome();
                opencustform.Closed += (s, args) => this.Close();
                opencustform.Show();
            }
        }
    }
}
