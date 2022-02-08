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
            txtStartStation.Focus();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;

            textBox.BeginInvoke(new Action(textBox.SelectAll));
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
                    (txtStartStation.Text, txtDestinationStation.Text) = (txtDestinationStation.Text, txtStartStation.Text);

                    break;
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            statusStriplableOne.Visible = false;

            ProveUserInput(out bool isValid);

            if (!isValid)
            {
                return;
            }

            string start = Constants.WILDCARD + txtStartStation.Text + Constants.WILDCARD;
            string arrive = Constants.WILDCARD + txtDestinationStation.Text + Constants.WILDCARD;

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

        private void ProveUserInput(out bool isValid)
        {
            isValid = !string.IsNullOrEmpty(txtStartStation.Text)
                      && !string.IsNullOrEmpty(txtDestinationStation.Text)
                      && !txtStartStation.Text.Any(char.IsDigit)
                      && !txtDestinationStation.Text.Any(char.IsDigit);

            if (isValid) return;

            statusStriplableOne.Visible = true;
            statusStriplableOne.Text = Constants.INPUT_NOT_VALID;
        }
    }
}