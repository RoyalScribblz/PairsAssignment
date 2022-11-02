using System;
using System.Windows.Forms;

namespace PairsAssignment;

public partial class AboutPage : Form
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private void AboutOkay_Click(object sender, EventArgs e)
    {
        Close();
    }
}