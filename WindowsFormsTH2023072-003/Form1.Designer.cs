namespace WindowsFormsTH2023072_003
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.thicknessTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(45, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(283, 314);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(417, 51);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(179, 23);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "loadImageButton";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click_1);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(417, 97);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(179, 23);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "colorButton";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(417, 200);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(179, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // thicknessTrackBar
            // 
            this.thicknessTrackBar.Location = new System.Drawing.Point(417, 137);
            this.thicknessTrackBar.Name = "thicknessTrackBar";
            this.thicknessTrackBar.Size = new System.Drawing.Size(179, 45);
            this.thicknessTrackBar.TabIndex = 4;
            this.thicknessTrackBar.Scroll += new System.EventHandler(this.thicknessTrackBar_Scroll_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thicknessTrackBar);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TrackBar thicknessTrackBar;
    }
}

