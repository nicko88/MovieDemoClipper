
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSaveClip = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblClipStart = new System.Windows.Forms.Label();
            this.btnStartPrev = new System.Windows.Forms.Button();
            this.btnStartNext = new System.Windows.Forms.Button();
            this.btnEndNext = new System.Windows.Forms.Button();
            this.btnEndPrev = new System.Windows.Forms.Button();
            this.lblClipEnd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clip Start:";
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
            this.btnSaveClip.Location = new System.Drawing.Point(471, 97);
            this.btnSaveClip.Name = "btnSaveClip";
            this.btnSaveClip.Size = new System.Drawing.Size(100, 50);
            this.btnSaveClip.TabIndex = 13;
            this.btnSaveClip.Text = "Save Clip";
            this.btnSaveClip.UseVisualStyleBackColor = true;
            this.btnSaveClip.Click += new System.EventHandler(this.btnSaveClip_Click);
            // 
            // lblClipStart
            // 
            this.lblClipStart.AutoSize = true;
            this.lblClipStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClipStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipStart.Location = new System.Drawing.Point(223, 71);
            this.lblClipStart.Name = "lblClipStart";
            this.lblClipStart.Size = new System.Drawing.Size(114, 20);
            this.lblClipStart.TabIndex = 19;
            this.lblClipStart.Text = "00:00:00.000";
            this.lblClipStart.Click += new System.EventHandler(this.lblClipStart_Click);
            // 
            // btnStartPrev
            // 
            this.btnStartPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPrev.Location = new System.Drawing.Point(107, 41);
            this.btnStartPrev.Name = "btnStartPrev";
            this.btnStartPrev.Size = new System.Drawing.Size(110, 50);
            this.btnStartPrev.TabIndex = 21;
            this.btnStartPrev.Text = "Select Prev Keyframe";
            this.btnStartPrev.UseVisualStyleBackColor = true;
            this.btnStartPrev.Click += new System.EventHandler(this.btnStartPrev_Click);
            // 
            // btnStartNext
            // 
            this.btnStartNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNext.Location = new System.Drawing.Point(343, 41);
            this.btnStartNext.Name = "btnStartNext";
            this.btnStartNext.Size = new System.Drawing.Size(110, 50);
            this.btnStartNext.TabIndex = 22;
            this.btnStartNext.Text = "Select Next Keyframe";
            this.btnStartNext.UseVisualStyleBackColor = true;
            this.btnStartNext.Click += new System.EventHandler(this.btnStartNext_Click);
            // 
            // btnEndNext
            // 
            this.btnEndNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndNext.Location = new System.Drawing.Point(343, 97);
            this.btnEndNext.Name = "btnEndNext";
            this.btnEndNext.Size = new System.Drawing.Size(110, 50);
            this.btnEndNext.TabIndex = 26;
            this.btnEndNext.Text = "Select Next Keyframe";
            this.btnEndNext.UseVisualStyleBackColor = true;
            this.btnEndNext.Click += new System.EventHandler(this.btnEndNext_Click);
            // 
            // btnEndPrev
            // 
            this.btnEndPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndPrev.Location = new System.Drawing.Point(107, 97);
            this.btnEndPrev.Name = "btnEndPrev";
            this.btnEndPrev.Size = new System.Drawing.Size(110, 50);
            this.btnEndPrev.TabIndex = 25;
            this.btnEndPrev.Text = "Select Prev Keyframe";
            this.btnEndPrev.UseVisualStyleBackColor = true;
            this.btnEndPrev.Click += new System.EventHandler(this.btnEndPrev_Click);
            // 
            // lblClipEnd
            // 
            this.lblClipEnd.AutoSize = true;
            this.lblClipEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClipEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipEnd.Location = new System.Drawing.Point(223, 125);
            this.lblClipEnd.Name = "lblClipEnd";
            this.lblClipEnd.Size = new System.Drawing.Size(114, 20);
            this.lblClipEnd.TabIndex = 24;
            this.lblClipEnd.Text = "00:00:00.000";
            this.lblClipEnd.Click += new System.EventHandler(this.lblClipEnd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Clip End:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "Click Time to Jump/Seek to it";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieDemoClipper
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 154);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEndNext);
            this.Controls.Add(this.btnEndPrev);
            this.Controls.Add(this.lblClipEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartNext);
            this.Controls.Add(this.btnStartPrev);
            this.Controls.Add(this.lblClipStart);
            this.Controls.Add(this.btnSaveClip);
            this.Controls.Add(this.lblFileName);
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
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSaveClip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblClipStart;
        private System.Windows.Forms.Button btnStartPrev;
        private System.Windows.Forms.Button btnStartNext;
        private System.Windows.Forms.Button btnEndNext;
        private System.Windows.Forms.Button btnEndPrev;
        private System.Windows.Forms.Label lblClipEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

