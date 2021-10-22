
namespace Fractals_5_1
{
    partial class Fractals
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonDraw = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buttonThickness = new System.Windows.Forms.Button();
            this.checkBoxThickness = new System.Windows.Forms.CheckBox();
            this.checkBoxColor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(35, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 780);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(1031, 34);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(348, 323);
            this.textBoxDescription.TabIndex = 1;
            // 
            // ButtonDraw
            // 
            this.ButtonDraw.AutoSize = true;
            this.ButtonDraw.Location = new System.Drawing.Point(1232, 401);
            this.ButtonDraw.Name = "ButtonDraw";
            this.ButtonDraw.Size = new System.Drawing.Size(147, 35);
            this.ButtonDraw.TabIndex = 2;
            this.ButtonDraw.Text = "Draw";
            this.ButtonDraw.UseVisualStyleBackColor = true;
            this.ButtonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(1062, 503);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(86, 31);
            this.textBoxN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1026, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "n:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1232, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1031, 407);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(196, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Random Angles";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1031, 465);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(145, 29);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Auto Clear";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // buttonThickness
            // 
            this.buttonThickness.Location = new System.Drawing.Point(1026, 553);
            this.buttonThickness.Name = "buttonThickness";
            this.buttonThickness.Size = new System.Drawing.Size(201, 43);
            this.buttonThickness.TabIndex = 8;
            this.buttonThickness.Text = "Tree thickness";
            this.buttonThickness.UseVisualStyleBackColor = true;
            this.buttonThickness.Click += new System.EventHandler(this.buttonThickness_Click);
            // 
            // checkBoxThickness
            // 
            this.checkBoxThickness.AutoSize = true;
            this.checkBoxThickness.Location = new System.Drawing.Point(1026, 623);
            this.checkBoxThickness.Name = "checkBoxThickness";
            this.checkBoxThickness.Size = new System.Drawing.Size(214, 29);
            this.checkBoxThickness.TabIndex = 9;
            this.checkBoxThickness.Text = "Thickness reduce";
            this.checkBoxThickness.UseVisualStyleBackColor = true;
            // 
            // checkBoxColor
            // 
            this.checkBoxColor.AutoSize = true;
            this.checkBoxColor.Location = new System.Drawing.Point(1026, 677);
            this.checkBoxColor.Name = "checkBoxColor";
            this.checkBoxColor.Size = new System.Drawing.Size(193, 29);
            this.checkBoxColor.TabIndex = 10;
            this.checkBoxColor.Text = "Color Changing";
            this.checkBoxColor.UseVisualStyleBackColor = true;
            // 
            // Fractals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 854);
            this.Controls.Add(this.checkBoxColor);
            this.Controls.Add(this.checkBoxThickness);
            this.Controls.Add(this.buttonThickness);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.ButtonDraw);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fractals";
            this.Text = "Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button ButtonDraw;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button buttonThickness;
        private System.Windows.Forms.CheckBox checkBoxThickness;
        private System.Windows.Forms.CheckBox checkBoxColor;
    }
}

