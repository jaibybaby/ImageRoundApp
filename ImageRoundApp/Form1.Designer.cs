
namespace ImageRoundApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBlueFish = new System.Windows.Forms.PictureBox();
            this.picWhiteFish = new System.Windows.Forms.PictureBox();
            this.picPurpleFish = new System.Windows.Forms.PictureBox();
            this.picOrangeFish = new System.Windows.Forms.PictureBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurpleFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrangeFish)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.picBlueFish);
            this.panel1.Controls.Add(this.picWhiteFish);
            this.panel1.Controls.Add(this.picPurpleFish);
            this.panel1.Controls.Add(this.picOrangeFish);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 494);
            this.panel1.TabIndex = 0;
            // 
            // picBlueFish
            // 
            this.picBlueFish.Image = global::ImageRoundApp.Properties.Resources.bluefish;
            this.picBlueFish.Location = new System.Drawing.Point(373, 182);
            this.picBlueFish.Name = "picBlueFish";
            this.picBlueFish.Size = new System.Drawing.Size(113, 98);
            this.picBlueFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlueFish.TabIndex = 3;
            this.picBlueFish.TabStop = false;
            // 
            // picWhiteFish
            // 
            this.picWhiteFish.Image = global::ImageRoundApp.Properties.Resources.whitefish;
            this.picWhiteFish.Location = new System.Drawing.Point(225, 325);
            this.picWhiteFish.Name = "picWhiteFish";
            this.picWhiteFish.Size = new System.Drawing.Size(113, 98);
            this.picWhiteFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWhiteFish.TabIndex = 2;
            this.picWhiteFish.TabStop = false;
            // 
            // picPurpleFish
            // 
            this.picPurpleFish.Image = global::ImageRoundApp.Properties.Resources.purplefish;
            this.picPurpleFish.Location = new System.Drawing.Point(77, 182);
            this.picPurpleFish.Name = "picPurpleFish";
            this.picPurpleFish.Size = new System.Drawing.Size(113, 98);
            this.picPurpleFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPurpleFish.TabIndex = 1;
            this.picPurpleFish.TabStop = false;
            // 
            // picOrangeFish
            // 
            this.picOrangeFish.Image = global::ImageRoundApp.Properties.Resources.orangefish;
            this.picOrangeFish.Location = new System.Drawing.Point(225, 53);
            this.picOrangeFish.Name = "picOrangeFish";
            this.picOrangeFish.Size = new System.Drawing.Size(113, 98);
            this.picOrangeFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrangeFish.TabIndex = 0;
            this.picOrangeFish.TabStop = false;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(242, 222);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(242, 182);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(242, 257);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 499);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBlueFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurpleFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrangeFish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBlueFish;
        private System.Windows.Forms.PictureBox picWhiteFish;
        private System.Windows.Forms.PictureBox picPurpleFish;
        private System.Windows.Forms.PictureBox picOrangeFish;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}

