using System;
using System.Windows.Forms;

namespace PairsAssignment;

public partial class PlayerNameEntry : Form
{
    //TODO set image of this form to the .ico
    private PlayerNameEntry()
    {
        InitializeComponent();
    }

    private void Close(object sender, EventArgs e)
    {
        Close();
    }

    public static string GetName(Form parent, string playerNumber)
    {
        string name = "";
        while (name == "")
        {
            PlayerNameEntry playerNameEntry = new();
            playerNameEntry.NameEntryLabel.Text = "Please enter a name for player " + playerNumber + ":";
            playerNameEntry.StartPosition = FormStartPosition.CenterParent;
            playerNameEntry.ShowDialog(parent);
            name = playerNameEntry.NameEntry.Text;
        }

        return name;
    }


    private void PlayerNameEntry_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) Close();
        // TODO dont work
    }
}