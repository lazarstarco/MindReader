namespace MindReader
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFinal;

        private void InitializeComponent()
        {
            lblMain = new Label();
            txtInput = new TextBox();
            btnStart = new Button();
            lblFinal = new Label();
            SuspendLayout();
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Location = new Point(46, 27);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(254, 20);
            lblMain.TabIndex = 0;
            lblMain.Text = "Think of a number between 1 and 10;";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(83, 59);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(186, 27);
            txtInput.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(116, 104);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(119, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Read my mind";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(46, 70);
            lblFinal.Name = "label1";
            lblFinal.Size = new Size(254, 20);
            lblFinal.TabIndex = 3;
            lblFinal.Visible = false;
            // 
            // MainForm
            // 
            ClientSize = new Size(346, 161);
            Controls.Add(lblFinal);
            Controls.Add(btnStart);
            Controls.Add(txtInput);
            Controls.Add(lblMain);
            Name = "MainForm";
            Text = "Mind Reader";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
