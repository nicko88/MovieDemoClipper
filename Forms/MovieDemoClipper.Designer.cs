
namespace MovieDemoClipper.Forms
{
    partial class MovieDemoClipper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClipStart = new System.Windows.Forms.Button();
            this.btnClipEnd = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSaveClip = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tbClipStart = new System.Windows.Forms.MaskedTextBox();
            this.tbClipEnd = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Video:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clip Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clip End:";
            // 
            // btnClipStart
            // 
            this.btnClipStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClipStart.Location = new System.Drawing.Point(240, 62);
            this.btnClipStart.Name = "btnClipStart";
            this.btnClipStart.Size = new System.Drawing.Size(150, 30);
            this.btnClipStart.TabIndex = 10;
            this.btnClipStart.Text = "Select Clip Start";
            this.btnClipStart.UseVisualStyleBackColor = true;
            this.btnClipStart.Click += new System.EventHandler(this.btnClipStart_Click);
            // 
            // btnClipEnd
            // 
            this.btnClipEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClipEnd.Location = new System.Drawing.Point(240, 98);
            this.btnClipEnd.Name = "btnClipEnd";
            this.btnClipEnd.Size = new System.Drawing.Size(150, 30);
            this.btnClipEnd.TabIndex = 11;
            this.btnClipEnd.Text = "Select Clip End";
            this.btnClipEnd.UseVisualStyleBackColor = true;
            this.btnClipEnd.Click += new System.EventHandler(this.btnClipEnd_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(68, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(467, 20);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.Text = "(Drag a video file here or open with MPC-BE/HC to begin)";
            // 
            // btnSaveClip
            // 
            this.btnSaveClip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClip.Location = new System.Drawing.Point(435, 98);
            this.btnSaveClip.Name = "btnSaveClip";
            this.btnSaveClip.Size = new System.Drawing.Size(100, 30);
            this.btnSaveClip.TabIndex = 13;
            this.btnSaveClip.Text = "Save Clip";
            this.btnSaveClip.UseVisualStyleBackColor = true;
            this.btnSaveClip.Click += new System.EventHandler(this.btnSaveClip_Click);
            // 
            // tbClipStart
            // 
            this.tbClipStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClipStart.Location = new System.Drawing.Point(106, 64);
            this.tbClipStart.Mask = "00:00:00.000";
            this.tbClipStart.Name = "tbClipStart";
            this.tbClipStart.Size = new System.Drawing.Size(112, 26);
            this.tbClipStart.TabIndex = 15;
            // 
            // tbClipEnd
            // 
            this.tbClipEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClipEnd.Location = new System.Drawing.Point(106, 100);
            this.tbClipEnd.Mask = "00:00:00.000";
            this.tbClipEnd.Name = "tbClipEnd";
            this.tbClipEnd.Size = new System.Drawing.Size(112, 26);
            this.tbClipEnd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "HH:MM:SS.MIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "(From Media Player)";
            // 
            // MovieDemoClipper
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 140);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbClipEnd);
            this.Controls.Add(this.tbClipStart);
            this.Controls.Add(this.btnSaveClip);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnClipEnd);
            this.Controls.Add(this.btnClipStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MovieDemoClipper";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Movie Demo Clipper";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MovieDemoClipper_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MovieDemoClipper_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClipStart;
        private System.Windows.Forms.Button btnClipEnd;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSaveClip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MaskedTextBox tbClipStart;
        private System.Windows.Forms.MaskedTextBox tbClipEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

