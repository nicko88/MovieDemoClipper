using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Text;

namespace MovieDemoClipper.Forms
{
    public partial class MovieDemoClipper : Form
    {
        private readonly string _IPport = "127.0.0.1:13579";
        private readonly string _rootPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        private string _selectedFile;
        public MovieDemoClipper()
        {
            Util.ConfigHelper.EnableMPCBEChapterMarkers();
            Util.ConfigHelper.EnableMPCBEWebAPI();

            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString(3).Replace(".0", "");
            Text += " v" + version;
        }

        private void btnStartPrev_Click(object sender, EventArgs e)
        {
            SeekKeyframe("897");
            lblClipStart.Text = GetTime();
        }

        private void btnStartNext_Click(object sender, EventArgs e)
        {
            SeekKeyframe("898");
            lblClipStart.Text = GetTime();
        }

        private void btnEndPrev_Click(object sender, EventArgs e)
        {
            SeekKeyframe("897");
            lblClipEnd.Text = GetTime();
        }

        private void btnEndNext_Click(object sender, EventArgs e)
        {
            SeekKeyframe("898");
            lblClipEnd.Text = GetTime();
        }

        private void lblClipStart_Click(object sender, EventArgs e)
        {
            SeekPlayer(lblClipStart.Text);
        }

        private void lblClipEnd_Click(object sender, EventArgs e)
        {
            SeekPlayer(lblClipEnd.Text);
        }

        private void btnSaveClip_Click(object sender, EventArgs e)
        {
            ProcessStartInfo clipProcessInfo = new ProcessStartInfo();
            try
            {
                if (TimeSpan.Parse(lblClipEnd.Text).Subtract(TimeSpan.Parse(lblClipStart.Text)).TotalMilliseconds > 0)
                {
                    string ext = Path.GetExtension(_selectedFile);

                    saveFileDialog.InitialDirectory = Path.GetDirectoryName(_selectedFile);
                    saveFileDialog.FileName = Path.GetFileNameWithoutExtension(_selectedFile) + " clip";
                    saveFileDialog.DefaultExt = Path.GetExtension(_selectedFile);
                    saveFileDialog.Filter = $"Video File | *{ext}";

                    DialogResult dialogResult = saveFileDialog.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        string clipName = saveFileDialog.FileName;

                        TimeSpan tsClipStart = TimeSpan.Parse(lblClipStart.Text);
                        TimeSpan tsClipEnd = TimeSpan.Parse(lblClipEnd.Text);

                        string clipCMD = $@"-ss {tsClipStart.Add(TimeSpan.FromMilliseconds(500)).ToString("G").Substring(2, 12)} -to {tsClipEnd.ToString("G").Substring(2, 12)} -i ""{_selectedFile}"" -c copy -map 0 -disposition:s:0 0 ""{clipName}""";
                        clipProcessInfo = new ProcessStartInfo(Path.Combine(_rootPath, "ffmpeg", "ffmpeg.exe"));
                        clipProcessInfo.Arguments = clipCMD;
                        Process clipProcess = Process.Start(clipProcessInfo);
                        clipProcess.WaitForExit();

                        MessageBox.Show("Clip creation complete.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Clip end time must be after clip start time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid clip selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Win32Exception)
            {
                MessageBox.Show($"Failed to start clipping process.\n\nCould not find: {clipProcessInfo.FileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeekKeyframe(string cmd)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    StringContent postContent = new StringContent($"wm_command={cmd}", Encoding.UTF8, "application/x-www-form-urlencoded");
                    _ = httpClient.PostAsync($"http://{_IPport}/command.html", postContent).Result;
                }
                catch
                {
                    MessageBox.Show("Error seeking keyframe in MPC-BE/HC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetTime()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string html = httpClient.GetStringAsync($"http://{_IPport}/variables.html").Result;

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);

                    _selectedFile = doc.GetElementbyId("filepath").InnerText;
                    lblFileName.Text = Path.GetFileName(_selectedFile);

                    return TimeSpan.FromMilliseconds(long.Parse(doc.GetElementbyId("position").InnerText)).ToString("G").Substring(2, 12);
                }
            }
            catch
            {
                MessageBox.Show("Error reading timestamp from MPC-BE/HC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void SeekPlayer(string timeCode)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    StringContent postContent = new StringContent($"wm_command=-1&position={timeCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
                    _ = httpClient.PostAsync($"http://{_IPport}/command.html", postContent).Result;
                }
                catch
                {
                    MessageBox.Show("Error seeking MPC-BE/HC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MovieDemoClipper_DragDrop(object sender, DragEventArgs e)
        {
            ProcessStartInfo mpcProcessStartInfo = new ProcessStartInfo();
            try
            {
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                if (fileList.Length > 0)
                {
                    lblFileName.Text = Path.GetFileName(fileList[0]);
                    _selectedFile = fileList[0];

                    mpcProcessStartInfo = new ProcessStartInfo(Path.Combine(_rootPath, "mpc-be", "mpc-be64.exe"));
                    mpcProcessStartInfo.Arguments = $@"""{fileList[0]}""";
                    Process.Start(mpcProcessStartInfo);
                }
            }
            catch
            {
                MessageBox.Show($"Can't open:\n\n {mpcProcessStartInfo.FileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MovieDemoClipper_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}