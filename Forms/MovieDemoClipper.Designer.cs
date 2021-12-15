
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
            this.lblClipStart = new System.Windows.Forms.Label();
            this.lblClipEnd = new System.Windows.Forms.Label();
            this.btnClipStart = new System.Windows.Forms.Button();
            this.btnClipEnd = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSaveClip = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clip Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clip End:";
            // 
            // lblClipStart
            // 
            this.lblClipStart.AutoSize = true;
            this.lblClipStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipStart.Location = new System.Drawing.Point(103, 67);
            this.lblClipStart.Name = "lblClipStart";
            this.lblClipStart.Size = new System.Drawing.Size(0, 20);
            this.lblClipStart.TabIndex = 8;
            // 
            // lblClipEnd
            // 
            this.lblClipEnd.AutoSize = true;
            this.lblClipEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipEnd.Location = new System.Drawing.Point(102, 103);
            this.lblClipEnd.Name = "lblClipEnd";
            this.lblClipEnd.Size = new System.Drawing.Size(0, 20);
            this.lblClipEnd.TabIndex = 9;
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
            this.lblFileName.Location = new System.Drawing.Point(77, 9);
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
            // MovieDemoClipper
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 140);
            this.Controls.Add(this.btnSaveClip);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnClipEnd);
            this.Controls.Add(this.btnClipStart);
            this.Controls.Add(this.lblClipEnd);
            this.Controls.Add(this.lblClipStart);
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
        private System.Windows.Forms.Label lblClipStart;
        private System.Windows.Forms.Label lblClipEnd;
        private System.Windows.Forms.Button btnClipStart;
        private System.Windows.Forms.Button btnClipEnd;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSaveClip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

