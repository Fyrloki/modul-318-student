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
            var connections = _transport.GetConnections(txtStartStation.Text, txtDestinationStation.Text);
            int rowindex = 0;

            foreach (var connection in connections.ConnectionList)
            {
                AddRowToConnectionView(connection, rowindex);
                rowindex++;
            }
        }

        private void AddRowToConnectionView(Connection connection, int rowindex)
        {
            var departureTime = connection.From.Departure;
            dgvConnectionList.Rows.Add();
            dgvConnectionList.Rows[rowindex].Cells[0].Value = connection.From.Platform;
            dgvConnectionList.Rows[rowindex].Cells[1].Value = connection.From.Station.Name;
            dgvConnectionList.Rows[rowindex].Cells[2].Value = connection.To.Station.Name;
            dgvConnectionList.Rows[rowindex].Cells[3].Value = connection.From.Departure.ToString();
        }
    }
}