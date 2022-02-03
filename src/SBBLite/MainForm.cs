using Common;
using SwissTransport.Core;

namespace SBBLite
{
    public partial class MainForm : Form
    {
        private readonly ITransport _transport;

        public MainForm(ITransport transport)
        {
            InitializeComponent();

            _transport = transport;
            btnSearchConnection.Tag = Constants.SEARCH_CONNECTION_TAG;
            btnShowNearStations.Tag = Constants.NEAR_STATIONS_TAG;
            btnLeavingBoard.Tag = Constants.BOARD_TAG;
            btnMap.Tag = Constants.MAP_TAG;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;

            switch (button.Tag)
            {
                case Constants.SEARCH_CONNECTION_TAG:

                    new SearchConnectionForm(_transport).ShowDialog();
                    break;

                case Constants.BOARD_TAG:

                    break;

                case Constants.MAP_TAG:

                    break;

                case Constants.NEAR_STATIONS_TAG:

                    break;

                default:

                    if (MessageBox.Show(Constants.DO_YOU_WANT_TO_END, Constants.END_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Close();
                    }

                    break;
            }
        }
    }
}