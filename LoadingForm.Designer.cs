namespace MindReader
{
    partial class LoadingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar progressBar1;

        private void InitializeComponent()
        {
            lblLoading = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.ForeColor = Color.Black;
            lblLoading.Location = new Point(90, 50);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(59, 15);
            lblLoading.TabIndex = 0;
            lblLoading.Text = "Loading...";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Green;
            progressBar1.Location = new Point(90, 80);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 1;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Dock = DockStyle.None;

            // 
            // LoadingForm
            // 
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(384, 161);
            Controls.Add(progressBar1);
            Controls.Add(lblLoading);
            Name = "LoadingForm";
            Text = "Reading your mind";
            Shown += LoadingForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
