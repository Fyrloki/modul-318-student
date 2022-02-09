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

            try
            {
                switch (button.Tag)
                {
                    case Constants.SEARCH_CONNECTION_TAG:
                    {
                        new SearchConnectionForm(_transport).ShowDialog();
                        break;
                    }
                    case Constants.BOARD_TAG:
                    {
                        new DepartureBoardForm(_transport).ShowDialog();
                        break;
                    }
                    case Constants.MAP_TAG:
                    {
                        MessageBox.Show(Constants.NOT_IMPLEMENTED_FEATURE, Constants.INFO_CAPTION, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        break;
                    }
                    case Constants.NEAR_STATIONS_TAG:
                    {
                        new NearStationsForm(_transport).ShowDialog();
                        break;
                    }
                    default:
                    {
                        if (MessageBox.Show(Constants.DO_YOU_WANT_TO_END, Constants.END_CAPTION,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Close();
                        }

                        break;
                    }
                }
            }
            catch (HttpRequestException _)
            {
                ChangeStatusNoConnection();
            }
        }

        private void ChangeStatusNoConnection()
        {
            StatusOfConnection.Text = Constants.NO_CONNECTION_TO_SERVER;
            StatusOfConnection.Visible = true;
            StatusOfConnection.ForeColor = Color.Red;

            btnLeavingBoard.Enabled = false;
            btnSearchConnection.Enabled = false;
            btnMap.Enabled = false;
            btnShowNearStations.Enabled = false;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                _transport.TestConnection();
            }
            catch (HttpRequestException _)
            {
                ChangeStatusNoConnection();
            }
        }
    }
}