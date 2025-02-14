using System;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MindReader
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private async void LoadingForm_Shown(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Enabled = false; // Disable the main form
            }

            // Ensure window handle is created by waiting for the form to be shown
            while (!this.IsHandleCreated)
            {
                await Task.Delay(10);  // Keep waiting for the handle to be created
            }

            // Simulate a 3-step loading process with updates every second
            for (int i = 1; i <= 100; i++)
            {
                // Wait for 1 second
                await Task.Delay(50);

                // Update the label and progress bar on the UI thread
                Invoke(new Action(() =>
                {
                    switch (i / 25)
                    {
                        case 0:
                            lblLoading.Text = "Analyzing brainwaves...";
                            break;
                        case 1:
                            lblLoading.Text = "Scanning memories...";
                            break;
                        case 2:
                            lblLoading.Text = "Calculating probabilities...";
                            break;
                        case 3:
                            lblLoading.Text = "Decoding thoughts...";
                            break;
                    }
                    progressBar1.Value = i;
                }));
            }

            // After the loading process, close the form
            await Task.Delay(100);
            this.Close();

            // Re-enable the main form after the loading window closes
            if (mainForm != null)
            {
                mainForm.Enabled = true;
            }
        }



    }
}
