namespace project8_3
{
    partial class formMiniDesktopPaintApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPaintOptions = new Panel();
            button1 = new Button();
            groupBoxBrushSize = new GroupBox();
            radioButtonThickBrushSize = new RadioButton();
            radioButtonMediumBrushSize = new RadioButton();
            radioButtonThinBrushSize = new RadioButton();
            groupBox1 = new GroupBox();
            radioButtonVioletColor = new RadioButton();
            radioButtonIndigoColor = new RadioButton();
            radioButtonBlueColor = new RadioButton();
            radioButtonGreenButton = new RadioButton();
            radioButtonYellowColor = new RadioButton();
            radioButtonorangeColor = new RadioButton();
            radioButtonRedColor2 = new RadioButton();
            panelPaintOptions.SuspendLayout();
            groupBoxBrushSize.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPaintOptions
            // 
            panelPaintOptions.BackColor = Color.Thistle;
            panelPaintOptions.BorderStyle = BorderStyle.FixedSingle;
            panelPaintOptions.Controls.Add(button1);
            panelPaintOptions.Controls.Add(groupBoxBrushSize);
            panelPaintOptions.Controls.Add(groupBox1);
            panelPaintOptions.Location = new Point(12, 12);
            panelPaintOptions.Name = "panelPaintOptions";
            panelPaintOptions.Size = new Size(869, 203);
            panelPaintOptions.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(472, 17);
            button1.Name = "button1";
            button1.Size = new Size(275, 62);
            button1.TabIndex = 2;
            button1.Text = "Clear Drawing Board";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonClearDrawingBoard_Click;
            // 
            // groupBoxBrushSize
            // 
            groupBoxBrushSize.Controls.Add(radioButtonThickBrushSize);
            groupBoxBrushSize.Controls.Add(radioButtonMediumBrushSize);
            groupBoxBrushSize.Controls.Add(radioButtonThinBrushSize);
            groupBoxBrushSize.Location = new Point(276, 3);
            groupBoxBrushSize.Name = "groupBoxBrushSize";
            groupBoxBrushSize.Size = new Size(173, 187);
            groupBoxBrushSize.TabIndex = 1;
            groupBoxBrushSize.TabStop = false;
            groupBoxBrushSize.Text = "Brush Size";
            // 
            // radioButtonThickBrushSize
            // 
            radioButtonThickBrushSize.AutoSize = true;
            radioButtonThickBrushSize.Location = new Point(6, 100);
            radioButtonThickBrushSize.Name = "radioButtonThickBrushSize";
            radioButtonThickBrushSize.Size = new Size(77, 29);
            radioButtonThickBrushSize.TabIndex = 2;
            radioButtonThickBrushSize.Text = "Thick";
            radioButtonThickBrushSize.UseVisualStyleBackColor = true;
            radioButtonThickBrushSize.CheckedChanged += radioButtonThickBrushSize_CheckedChanged;
            // 
            // radioButtonMediumBrushSize
            // 
            radioButtonMediumBrushSize.AutoSize = true;
            radioButtonMediumBrushSize.Location = new Point(6, 65);
            radioButtonMediumBrushSize.Name = "radioButtonMediumBrushSize";
            radioButtonMediumBrushSize.Size = new Size(103, 29);
            radioButtonMediumBrushSize.TabIndex = 1;
            radioButtonMediumBrushSize.Text = "Medium";
            radioButtonMediumBrushSize.UseVisualStyleBackColor = true;
            radioButtonMediumBrushSize.CheckedChanged += radioButtonMediumBrushSize_CheckedChanged;
            // 
            // radioButtonThinBrushSize
            // 
            radioButtonThinBrushSize.AutoSize = true;
            radioButtonThinBrushSize.Checked = true;
            radioButtonThinBrushSize.Location = new Point(6, 30);
            radioButtonThinBrushSize.Name = "radioButtonThinBrushSize";
            radioButtonThinBrushSize.Size = new Size(70, 29);
            radioButtonThinBrushSize.TabIndex = 0;
            radioButtonThinBrushSize.TabStop = true;
            radioButtonThinBrushSize.Text = "Thin";
            radioButtonThinBrushSize.UseVisualStyleBackColor = true;
            radioButtonThinBrushSize.CheckedChanged += radioButtonThinBrushSize_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonVioletColor);
            groupBox1.Controls.Add(radioButtonIndigoColor);
            groupBox1.Controls.Add(radioButtonBlueColor);
            groupBox1.Controls.Add(radioButtonGreenButton);
            groupBox1.Controls.Add(radioButtonYellowColor);
            groupBox1.Controls.Add(radioButtonorangeColor);
            groupBox1.Controls.Add(radioButtonRedColor2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Colors";
            // 
            // radioButtonVioletColor
            // 
            radioButtonVioletColor.AutoSize = true;
            radioButtonVioletColor.ForeColor = Color.Violet;
            radioButtonVioletColor.Location = new Point(125, 100);
            radioButtonVioletColor.Name = "radioButtonVioletColor";
            radioButtonVioletColor.Size = new Size(82, 29);
            radioButtonVioletColor.TabIndex = 7;
            radioButtonVioletColor.TabStop = true;
            radioButtonVioletColor.Text = "Violet";
            radioButtonVioletColor.UseVisualStyleBackColor = true;
            radioButtonVioletColor.CheckedChanged += radioButtonVioletColor_CheckedChanged;
            // 
            // radioButtonIndigoColor
            // 
            radioButtonIndigoColor.AutoSize = true;
            radioButtonIndigoColor.ForeColor = Color.Indigo;
            radioButtonIndigoColor.Location = new Point(125, 65);
            radioButtonIndigoColor.Name = "radioButtonIndigoColor";
            radioButtonIndigoColor.Size = new Size(89, 29);
            radioButtonIndigoColor.TabIndex = 6;
            radioButtonIndigoColor.TabStop = true;
            radioButtonIndigoColor.Text = "Indigo";
            radioButtonIndigoColor.UseVisualStyleBackColor = true;
            radioButtonIndigoColor.CheckedChanged += radioButtonIndigoColor_CheckedChanged;
            // 
            // radioButtonBlueColor
            // 
            radioButtonBlueColor.AutoSize = true;
            radioButtonBlueColor.ForeColor = Color.Blue;
            radioButtonBlueColor.Location = new Point(125, 30);
            radioButtonBlueColor.Name = "radioButtonBlueColor";
            radioButtonBlueColor.Size = new Size(70, 29);
            radioButtonBlueColor.TabIndex = 5;
            radioButtonBlueColor.TabStop = true;
            radioButtonBlueColor.Text = "Blue";
            radioButtonBlueColor.UseVisualStyleBackColor = true;
            radioButtonBlueColor.CheckedChanged += radioButtonBlueColor_CheckedChanged;
            // 
            // radioButtonGreenButton
            // 
            radioButtonGreenButton.AutoSize = true;
            radioButtonGreenButton.ForeColor = Color.Green;
            radioButtonGreenButton.Location = new Point(6, 135);
            radioButtonGreenButton.Name = "radioButtonGreenButton";
            radioButtonGreenButton.Size = new Size(83, 29);
            radioButtonGreenButton.TabIndex = 4;
            radioButtonGreenButton.TabStop = true;
            radioButtonGreenButton.Text = "Green";
            radioButtonGreenButton.UseVisualStyleBackColor = true;
            radioButtonGreenButton.CheckedChanged += radioButtonGreenButton_CheckedChanged;
            // 
            // radioButtonYellowColor
            // 
            radioButtonYellowColor.AutoSize = true;
            radioButtonYellowColor.ForeColor = Color.Yellow;
            radioButtonYellowColor.Location = new Point(6, 100);
            radioButtonYellowColor.Name = "radioButtonYellowColor";
            radioButtonYellowColor.Size = new Size(86, 29);
            radioButtonYellowColor.TabIndex = 3;
            radioButtonYellowColor.TabStop = true;
            radioButtonYellowColor.Text = "Yellow";
            radioButtonYellowColor.UseVisualStyleBackColor = true;
            radioButtonYellowColor.CheckedChanged += radioButtonYellowColor_CheckedChanged;
            // 
            // radioButtonorangeColor
            // 
            radioButtonorangeColor.AutoSize = true;
            radioButtonorangeColor.ForeColor = Color.Orange;
            radioButtonorangeColor.Location = new Point(6, 65);
            radioButtonorangeColor.Name = "radioButtonorangeColor";
            radioButtonorangeColor.Size = new Size(96, 29);
            radioButtonorangeColor.TabIndex = 2;
            radioButtonorangeColor.TabStop = true;
            radioButtonorangeColor.Text = "Orange";
            radioButtonorangeColor.UseVisualStyleBackColor = true;
            radioButtonorangeColor.CheckedChanged += radioButtonorangeColor_CheckedChanged;
            // 
            // radioButtonRedColor2
            // 
            radioButtonRedColor2.AutoSize = true;
            radioButtonRedColor2.ForeColor = Color.Red;
            radioButtonRedColor2.Location = new Point(6, 30);
            radioButtonRedColor2.Name = "radioButtonRedColor2";
            radioButtonRedColor2.Size = new Size(67, 29);
            radioButtonRedColor2.TabIndex = 1;
            radioButtonRedColor2.TabStop = true;
            radioButtonRedColor2.Text = "Red";
            radioButtonRedColor2.UseVisualStyleBackColor = true;
            radioButtonRedColor2.CheckedChanged += radioButtonRedColor2_CheckedChanged;
            // 
            // formMiniDesktopPaintApplication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(897, 844);
            Controls.Add(panelPaintOptions);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formMiniDesktopPaintApplication";
            Text = "Mini Desktop Paint Application";
            Load += formMiniDesktopPaintApplication_Load;
            MouseDown += formMiniDesktopPaintApplication_MouseDown;
            MouseMove += formMiniDesktopPaintApplication_MouseMove;
            MouseUp += formMiniDesktopPaintApplication_MouseUp;
            panelPaintOptions.ResumeLayout(false);
            groupBoxBrushSize.ResumeLayout(false);
            groupBoxBrushSize.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPaintOptions;
        private GroupBox groupBox1;
        private RadioButton radioButtonorangeColor;
        private RadioButton radioButtonRedColor2;
        private RadioButton radioButtonGreenButton;
        private RadioButton radioButtonYellowColor;
        private RadioButton radioButtonIndigoColor;
        private RadioButton radioButtonBlueColor;
        private RadioButton radioButtonVioletColor;
        private GroupBox groupBoxBrushSize;
        private RadioButton radioButtonThinBrushSize;
        private RadioButton radioButtonMediumBrushSize;
        private Button button1;
        private RadioButton radioButtonThickBrushSize;
    }
}