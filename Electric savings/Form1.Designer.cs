namespace Electric_savings
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            results = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            months = new ComboBox();
            display = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(499, 68);
            Title.Name = "Title";
            Title.Size = new Size(236, 82);
            Title.TabIndex = 0;
            Title.Text = "Smart Home \r\nElectric Savings";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // results
            // 
            results.AutoSize = true;
            results.Location = new Point(258, 387);
            results.Name = "results";
            results.Size = new Size(50, 20);
            results.TabIndex = 1;
            results.Text = "label2";
            results.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 500);
            label1.Name = "label1";
            label1.Size = new Size(506, 84);
            label1.TabIndex = 2;
            label1.Text = "The average monthly savings is $26.15\r\n\r\nDecember had the most significant monthly savings";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.smarthome;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // months
            // 
            months.FormattingEnabled = true;
            months.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            months.Location = new Point(532, 235);
            months.Name = "months";
            months.Size = new Size(151, 28);
            months.TabIndex = 4;
            months.SelectedIndexChanged += months_SelectedIndexChanged;
            // 
            // display
            // 
            display.BackColor = Color.Blue;
            display.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display.ForeColor = SystemColors.ButtonFace;
            display.Location = new Point(329, 433);
            display.Name = "display";
            display.Size = new Size(202, 40);
            display.TabIndex = 5;
            display.Text = "Display Statistics";
            display.UseVisualStyleBackColor = false;
            display.Visible = false;
            display.Click += display_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(864, 628);
            Controls.Add(display);
            Controls.Add(months);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(results);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label results;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox months;
        private Button display;
    }
}
