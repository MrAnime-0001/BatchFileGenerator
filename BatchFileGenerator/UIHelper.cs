using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFileGenerator
{
    public static class UIHelper
    {
        public static void ShowToast(
            string message,
            int duration = 2000,
            bool playSound = true
        )
        {
            // CONFIG
            Size size = new Size(250, 60);
            Color backColor = Color.Black;
            Color textColor = Color.White;
            double opacity = 0.9;
            int margin = 10;

            // CREATE FORM
            Form toast = new Form
            {
                FormBorderStyle = FormBorderStyle.None, // Better for toasts and ensures no Alt-Tab entry
                StartPosition = FormStartPosition.Manual,
                ShowInTaskbar = false,
                TopMost = true,
                ControlBox = false,
                Text = string.Empty,
                BackColor = backColor,
                Size = size,
                Opacity = opacity
            };

            // LABEL
            toast.Controls.Add(new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = textColor,
                BackColor = Color.Transparent
            });

            // POSITION (SCREEN)
            var screen = Screen.PrimaryScreen?.WorkingArea ?? Screen.AllScreens[0].WorkingArea;
            toast.Location = new Point(
                screen.Right - toast.Width - margin,
                screen.Bottom - toast.Height - margin
            );

            // BEHAVIOUR
            toast.Shown += async (s, e) =>
            {
                if (playSound)
                    SystemSounds.Exclamation.Play();

                await Task.Delay(duration);

                for (double i = toast.Opacity; i >= 0; i -= 0.05)
                {
                    if (toast.IsDisposed) break;

                    toast.Invoke((Action)(() => toast.Opacity = i));
                    await Task.Delay(20);
                }

                if (!toast.IsDisposed)
                    toast.Invoke((Action)(() => toast.Close()));
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

        public enum ExportChoice
        {
            AppLocation,
            PickLocation,
            Cancel
        }

        public static ExportChoice ShowExportChoiceDialog()
        {
            ExportChoice choice = ExportChoice.Cancel;

            Form dialog = new Form
            {
                Text = "Select Export Location",
                Size = new Size(400, 200),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(28, 28, 28),
                ForeColor = Color.White,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowIcon = false,
                ControlBox = true
            };

            Label lbl = new Label
            {
                Text = "Where would you like to save the file?",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 60,
                Font = new Font("Segoe UI Semibold", 11)
            };

            Button btnAppLoc = new Button
            {
                Text = "Application Location",
                Size = new Size(160, 40),
                Location = new Point(30, 80),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnAppLoc.FlatAppearance.BorderSize = 0;

            Button btnPickLoc = new Button
            {
                Text = "Pick Location...",
                Size = new Size(160, 40),
                Location = new Point(200, 80),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(63, 63, 70),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnPickLoc.FlatAppearance.BorderSize = 0;

            btnAppLoc.Click += (s, e) => { choice = ExportChoice.AppLocation; dialog.Close(); };
            btnPickLoc.Click += (s, e) => { choice = ExportChoice.PickLocation; dialog.Close(); };

            dialog.Controls.Add(btnAppLoc);
            dialog.Controls.Add(btnPickLoc);
            dialog.Controls.Add(lbl);

            dialog.ShowDialog();
            return choice;
        }
    }
}
