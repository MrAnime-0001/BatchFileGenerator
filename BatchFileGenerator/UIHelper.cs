using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFileGenerator
{
    public static class UIHelper
    {
        public static void ShowToast(string message, int duration = 2000, bool playSound = true)
        {
            Form toast = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow, // Hidden from Alt-Tab
                StartPosition = FormStartPosition.Manual,
                ShowInTaskbar = false,
                TopMost = true,
                BackColor = Color.Black,
                Size = new Size(250, 60),
                Opacity = 0.9,
                ControlBox = false, // Hides the title bar buttons
                Text = string.Empty // Hides the title bar text
            };

            toast.Controls.Add(new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            });

            var screen = Screen.PrimaryScreen?.WorkingArea ?? Screen.AllScreens[0].WorkingArea;
            toast.Location = new Point(screen.Right - toast.Width - 10, screen.Bottom - toast.Height - 10);

            toast.Shown += async (s, e) =>
            {
                if (playSound)
                {
                    SystemSounds.Exclamation.Play();
                }

                await Task.Delay(duration);

                // Fade out
                for (double i = toast.Opacity; i >= 0; i -= 0.05)
                {
                    if (toast.IsDisposed) break;
                    toast.Invoke((Action)(() => toast.Opacity = i));
                    await Task.Delay(20);
                }

                if (!toast.IsDisposed)
                {
                    toast.Invoke((Action)(() => toast.Close()));
                }
            };

            toast.Show();
        }

        public static string? PromptForFile(string title)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = title;
                ofd.Filter = "All Files (*.*)|*.*";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
            }
            return null;
        }

        public static string? PromptForPath(string title)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = title;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    return fbd.SelectedPath;
                }
            }
            return null;
        }
    }
}
