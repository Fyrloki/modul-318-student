//using System.Device.Location;
using Common;
using SwissTransport.Core;

namespace SBBLite
{
    public partial class NearStationsForm : Form
    {
        private readonly ITransport _transport;
        //private GeoCoordinateWatcher _watcher = new GeoCoordinateWatcher();
        //private string _location1 = IpAufruf.GetUserLocationyByIp("85.1.157.112");
        //private string _coordinates1 = IpAufruf.GetUserCoordinatesByIp("85.1.157.112");

        public NearStationsForm(ITransport transport)
        {
            InitializeComponent();
            _transport = transport;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //NearbyStationdataGridView.Rows.Clear();
            //ConnectionSelectiondataGridView.Rows.Clear();
            //ITransport transport = new Transport();
            //try
            //{
            //    Station station = transport.GetStations(_location1).StationList.ElementAt(0);
            //    Console.WriteLine(station);
            //}
            //catch
            //{
            //    Exception ex = new Exception();
            //    MessageBox.Show(ex.ToString());
            //}

            MessageBox.Show(Constants.NOT_IMPLEMENTED_FEATURE, Constants.INFO_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HomePicture_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}