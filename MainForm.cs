using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Hide the main form controls (label, input, button)
            lblMain.Visible = false;
            txtInput.Visible = false;
            btnStart.Visible = false;

            // Create and show the loading form
            var loadingForm = new LoadingForm();
            loadingForm.ShowDialog();

            // Simulate the loading process and update the main form
            //await Task.Delay(300);
            lblFinal.Text = "You're thinking of the number " + txtInput.Text + "!";
            lblFinal.Visible = true;

            // Close the loading form
            //loadingForm.Close();
        }
    }
}
