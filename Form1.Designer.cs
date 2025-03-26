namespace Paint_Project
{
    partial class Paint
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
            panel1 = new Panel();
            SizeLabel = new Label();
            ColorLabel = new Label();
            ShapeLabel = new Label();
            sizeComboBox = new ComboBox();
            colorComboBox = new ComboBox();
            shapeComboBox = new ComboBox();
            panel2 = new Panel();
            Clear = new Button();
            pic = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(SizeLabel);
            panel1.Controls.Add(ColorLabel);
            panel1.Controls.Add(ShapeLabel);
            panel1.Controls.Add(sizeComboBox);
            panel1.Controls.Add(colorComboBox);
            panel1.Controls.Add(shapeComboBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1591, 211);
            panel1.TabIndex = 0;
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.BackColor = Color.Cyan;
            SizeLabel.Location = new Point(1278, 49);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(83, 48);
            SizeLabel.TabIndex = 5;
            SizeLabel.Text = "Size";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.BackColor = Color.Cyan;
            ColorLabel.Location = new Point(745, 49);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(106, 48);
            ColorLabel.TabIndex = 4;
            ColorLabel.Text = "Color";
            // 
            // ShapeLabel
            // 
            ShapeLabel.AutoSize = true;
            ShapeLabel.BackColor = Color.Cyan;
            ShapeLabel.Location = new Point(160, 49);
            ShapeLabel.Name = "ShapeLabel";
            ShapeLabel.Size = new Size(117, 48);
            ShapeLabel.TabIndex = 3;
            ShapeLabel.Text = "Shape";
            // 
            // sizeComboBox
            // 
            sizeComboBox.FormattingEnabled = true;
            sizeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            sizeComboBox.Location = new Point(1197, 109);
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(241, 56);
            sizeComboBox.TabIndex = 2;
            sizeComboBox.SelectedIndexChanged += sizeComboBox_SelectedIndexChanged;
            // 
            // colorComboBox
            // 
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Items.AddRange(new object[] { "Red", "Yellow", "Green", "Blue", "White", "Black" });
            colorComboBox.Location = new Point(675, 109);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(241, 56);
            colorComboBox.TabIndex = 1;
            colorComboBox.SelectedIndexChanged += colorComboBox_SelectedIndexChanged_1;
            // 
            // shapeComboBox
            // 
            shapeComboBox.FormattingEnabled = true;
            shapeComboBox.Items.AddRange(new object[] { "Pencil", "Ellipse", "Rectangle", "Line" });
            shapeComboBox.Location = new Point(98, 117);
            shapeComboBox.Name = "shapeComboBox";
            shapeComboBox.Size = new Size(241, 56);
            shapeComboBox.TabIndex = 0;
            shapeComboBox.SelectedIndexChanged += shapeComboBox_SelectedIndexChanged_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(Clear);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 926);
            panel2.Name = "panel2";
            panel2.Size = new Size(1591, 179);
            panel2.TabIndex = 1;
            // 
            // Clear
            // 
            Clear.Location = new Point(12, 34);
            Clear.Name = "Clear";
            Clear.Size = new Size(193, 111);
            Clear.TabIndex = 0;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 211);
            pic.Name = "pic";
            pic.Size = new Size(1591, 715);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Paint
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 1105);
            Controls.Add(pic);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Paint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label SizeLabel;
        private Label ColorLabel;
        private Label ShapeLabel;
        private ComboBox sizeComboBox;
        private ComboBox colorComboBox;
        private ComboBox shapeComboBox;
        private Panel panel2;
        private Button Clear;
        private PictureBox pic;
    }
}
