using System;
using System.Windows.Forms;

namespace PairsAssignment;

public partial class AboutForm : Form
{
    public AboutForm()
    {
        InitializeComponent();
    }

    private void AboutOkay_Click(object sender, EventArgs e)
    {
        Close();
    }
}