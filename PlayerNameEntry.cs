using System;
using System.Windows.Forms;

namespace PairsAssignment;

public partial class PlayerNameEntry : Form
{
    private static bool _exitGameCreation;
    private PlayerNameEntry()
    {
        InitializeComponent();
    }

    private void Close(object sender, EventArgs e)
    {
        if (sender == CancelButton) _exitGameCreation = true;
        Close();
    }

    public static string GetName(Form parent, string playerNumber)
    {
        _exitGameCreation = false;  // assume not exit
        string name = "";
        while (name == "" && !_exitGameCreation)  // continue asking for input unless they want to exit or have submitted a name
        {
            PlayerNameEntry playerNameEntry = new();
            playerNameEntry.NameEntryLabel.Text = "Please enter a name for player " + playerNumber + ":";
            playerNameEntry.StartPosition = FormStartPosition.CenterParent;
            playerNameEntry.ShowDialog(parent);
            name = playerNameEntry.NameEntry.Text;
        }

        return _exitGameCreation ? null : name;  // if they want to exit return null if not return the name
    }

    /// <summary>Allow the user to press enter or escape to close the entry box.</summary>
    /// <param name="msg">A Message, passed by reference, that represents the Win32 message to process.</param>
    /// <param name="keyData">One of the Keys values that represents the key to process.</param>
    /// <returns>The base ProcessCmdKey</returns>
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData is not (Keys.Enter or Keys.Escape)) return base.ProcessCmdKey(ref msg, keyData);
        if (keyData == Keys.Escape) _exitGameCreation = true;  // exit new game if escape is pressed
        Close();  // close the tab if either enter or escape has been pressed
        return base.ProcessCmdKey(ref msg, keyData);
    }
}