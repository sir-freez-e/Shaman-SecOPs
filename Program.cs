using System;
using System.Windows.Forms;

namespace Shaman_SecOPs
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Create a new NotifyIcon object
            NotifyIcon notifyIcon = new NotifyIcon();

            // Set the icon to display in the system tray
            notifyIcon.Icon = new System.Drawing.Icon("icon.ico");

            // Set the tooltip text
            notifyIcon.Text = "Shaman SecOps";

            // Create a new ContextMenuStrip object
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            // Add "Show Window" menu item to the context menu
            contextMenuStrip.Items.Add("Show Window", null, (sender, e) =>
            {
                // Handle "Show Window" menu item click event
                Form1 form = new Form1();
                form.Show();
            });

            // Add "Exit" menu item to the context menu
            contextMenuStrip.Items.Add("Exit", null, (sender, e) =>
            {
                // Handle "Exit" menu item click event
                notifyIcon.Visible = false;
                Application.Exit();
            });

            // Set the context menu for the notification icon
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            // Display the notification icon in the system tray
            notifyIcon.Visible = true;

            // Wait for the user to click on the notification icon
            notifyIcon.MouseClick += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    // Handle left-click event
                }
            };

            // Wait for the user to close the application
            Application.Run();
        }
    }
}
