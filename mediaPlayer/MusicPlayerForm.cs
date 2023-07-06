using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaPlayer
{
    public partial class MusicPlayerForm : Form
    {

        MusicList form = new MusicList();
        string url1;
        public MusicPlayerForm()
        {
            InitializeComponent();
            url1 = form.url;
        }
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void startbtn_Click(object sender, EventArgs e)
        {
            startbtn.Visible = false;
            stopbtn.Visible = true;
            player.URL = @url1;
            player.Ctlcontrols.play();
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            stopbtn.Visible = false;
            startbtn.Visible = true;
        }

        private void timer_location_Tick(object sender, EventArgs e)
        {
            btnPlass.Left = startbtn.Left + 91;
            btnA.Left = startbtn.Left - 57;
        }
    }
}
