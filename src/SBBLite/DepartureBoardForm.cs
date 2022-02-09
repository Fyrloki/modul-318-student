using Common;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBLite;

public partial class DepartureBoardForm : Form
{
    private readonly ITransport _transport;

    private bool _valueChangedByUser = true;

    public DepartureBoardForm(ITransport transport)
    {
        InitializeComponent();

        _transport = transport;
    }

    private void HomeIcon_Clicked(object sender, EventArgs e)
    {
        Close();
    }

    private void SearchButton_Clicked(object sender, EventArgs e)
    {
        statusStrip.Visible = false;

        if (cbSearchValue.Text == string.Empty)
        {
            statusStrip.Text = Constants.INPUT_NOT_VALID;
            statusStrip.Visible = true;
            return;
        }

        var stations = _transport.GetStations(cbSearchValue.Text);

        if (stations.StationList.Count == 0)
        {
            statusStrip.Text = Constants.NO_CONNECTION_FOUND;
            statusStrip.Visible = true;
            return;
        }

        var station = stations.StationList
            .Where(x => x.Name.Equals(cbSearchValue.Text, StringComparison.OrdinalIgnoreCase)).ToList()
            .FirstOrDefault();

        var stationBoard = _transport.GetStationBoard(station.Name, station.Id);

        ShowConnections(stationBoard);
    }

    private void ShowConnections(StationBoardRoot? stationBoard)
    {
        if (stationBoard == null)
        {
            statusStrip.Text = Constants.NO_CONNECTION_FOUND;
            statusStrip.Visible = true;
            return;
        }

        FillStationInView(stationBoard.Entries);
    }

    private void FillStationInView(List<StationBoard> entries)
    {
        var i = 0;

        foreach (var entry in entries)
        {
            dgvConnectionList.Rows.Add();
            dgvConnectionList.Rows[i].Cells[0].Value = entry.Category;
            dgvConnectionList.Rows[i].Cells[1].Value = entry.Number;
            dgvConnectionList.Rows[i].Cells[2].Value = entry.Operator;
            dgvConnectionList.Rows[i].Cells[3].Value = entry.Stop.Departure;
            dgvConnectionList.Rows[i].Cells[4].Value = entry.To;
            i++;
        }
    }

    private void SearchValue_Changed(object sender, EventArgs e)
    {
        var comboBox = (ComboBox) sender;

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
}