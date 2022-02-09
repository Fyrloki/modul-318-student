using Common;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBLite
{
    public partial class SearchConnectionForm : Form
    {
        private readonly ITransport _transport;

        public SearchConnectionForm(ITransport transport)
        {
            InitializeComponent();
            _transport = transport;

            HomePicture.Tag = Constants.HOMEICON_TAG;
            SwitchPicture.Tag = Constants.SWITCHICON_TAG;
            MailPicture.Tag = Constants.MAILICON_TAG;
        }

        private void SearchConnectionForm_Shown(object sender, EventArgs e)
        {
            dgvConnectionList.RowHeadersVisible = false;
            cBDepartionStation.Focus();
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;

            switch (pictureBox.Tag)
            {
                case Constants.HOMEICON_TAG:
                {
                    Close();

                    break;
                }

                case Constants.MAILICON_TAG:
                {
                    MessageBox.Show(Constants.NOT_IMPLEMENTED_FEATURE, Constants.INFO_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                }

                case Constants.SWITCHICON_TAG:
                {
                    (cBDepartionStation.Text, cbArrivalStation.Text) = (cbArrivalStation.Text, cBDepartionStation.Text);

                    break;
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            statusStriplableOne.Visible = false;
            cBDepartionStation.Text = cBDepartionStation.Text.Trim();
            cbArrivalStation.Text = cbArrivalStation.Text.Trim();

            ProveUserInput(out bool isValid);

            if (!isValid)
            {
                return;
            }

            string start = Constants.WILDCARD + cBDepartionStation.Text + Constants.WILDCARD;
            string arrive = Constants.WILDCARD + cbArrivalStation.Text + Constants.WILDCARD;

            var connections = _transport.GetConnections(start, arrive, dtPDate.Value, dtpTime.Value, radioArrive.Checked);

            dgvConnectionList.Rows.Clear();

            if (connections.ConnectionList.Count == 0)
            {
                statusStriplableOne.Text = Constants.NO_CONNECTION_FOUND;
                statusStriplableOne.Visible = true;
                return;
            }

            if (radioArrive.Checked)
            {
                connections.ConnectionList.Reverse();
            }

            FillConnectionsInView(connections.ConnectionList);
        }

        private void FillConnectionsInView(List<Connection> connections)
        {
            int i = 0;

            foreach (var connection in connections)
            {
                dgvConnectionList.Rows.Add();
                dgvConnectionList.Rows[i].Cells[0].Value = connection.From.Platform;
                dgvConnectionList.Rows[i].Cells[1].Value = connection.From.Station.Name;
                dgvConnectionList.Rows[i].Cells[2].Value = connection.To.Station.Name;
                dgvConnectionList.Rows[i].Cells[3].Value = GetConnectionTimeString(connection.From.Departure);
                dgvConnectionList.Rows[i].Cells[4].Value = GetConnectionTimeString(connection.To.Arrival);
                i++;
            }
        }

        private string GetConnectionTimeString(DateTime? departure)
        {
            if (departure is null)
            {
                throw new ArgumentNullException(nameof(departure));
            }

            DateTime date = (DateTime)departure;

            return date.ToString(Constants.TIME_FORMAT);
        }

        private void SearchValue_Changed(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;

            if (!_valueChangedByUser || string.IsNullOrEmpty(comboBox.Text)) return;

            comboBox.Text = comboBox.Text.Trim();
            string text = comboBox.Text;
            comboBox.Items.Clear();

            var stations = _transport.GetStations(Constants.WILDCARD + comboBox.Text + Constants.WILDCARD);

            if (stations.StationList.Count == 0 || stations.StationList[0].Id == null) return;

            comboBox.Items.AddRange(GetStationNames(stations.StationList));
            _valueChangedByUser = false;
            comboBox.Text = text;
            _valueChangedByUser = true;
            comboBox.SelectionStart = comboBox.Text.Length;
        }

        private bool _valueChangedByUser = true;

        private object[] GetStationNames(List<Station> stationList)
        {
            var names = new string[stationList.Count];
            var i = 0;

            foreach (var station in stationList)
            {
                names[i] = station.Name;
                i++;
            }

            return names;
        }

        private void ProveUserInput(out bool isValid)
        {
            isValid = !string.IsNullOrEmpty(cBDepartionStation.Text)
                      && !string.IsNullOrEmpty(cbArrivalStation.Text)
                      && !cBDepartionStation.Text.Any(char.IsDigit)
                      && !cbArrivalStation.Text.Any(char.IsDigit);

            if (isValid) return;

            statusStriplableOne.Visible = true;
            statusStriplableOne.Text = Constants.INPUT_NOT_VALID;
        }
    }
}