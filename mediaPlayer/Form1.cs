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
    public partial class Form1 : Form
    {
        bool musicform = false;
        bool musiclist = false;
        //Fields
        private int borderSize = 2;
        //private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Padding = new Padding(borderSize);//Border size
            //this.BackColor = Color.FromArgb(98, 102, 244);//Border color
            customizeDesing();
        }

        
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }*/
        private void customizeDesing()
        {
            panelMidiaMinu.Visible = false;
            panelPlaylistMinu.Visible = false;
            panelToolsMinu.Visible = false;
        }
        private void hideMinuPanel()
        {
            if (panelMidiaMinu.Visible == true)
                panelMidiaMinu.Visible = false;
            if (panelPlaylistMinu.Visible == true)
                panelPlaylistMinu.Visible = false;
            if (panelToolsMinu.Visible == true)
                panelToolsMinu.Visible = false;
        }
        private void MinubtnClicked(Panel MinuPanel)
        {
            if (MinuPanel.Visible == false)
            {
                hideMinuPanel();
                MinuPanel.Visible = true;
            }
            else
                MinuPanel.Visible = false;
        }

        private void btnMidiaMinu_Click(object sender, EventArgs e)
        {
            MinubtnClicked(panelMidiaMinu);

        }

        private void btnPlaylistMinu_Click(object sender, EventArgs e)
        {
            MinubtnClicked(panelPlaylistMinu);
        }

        private void btnToolsMinu_Click(object sender, EventArgs e)
        {
            MinubtnClicked(panelToolsMinu);
        }

        private void ButtonHiding(object sender, EventArgs e)
        {
            hideMinuPanel();
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Form activeForm = null;
        internal string url;

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0X112, 0Xf012, 0);
        }

        private void MiniSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaxSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideMinuPanel();
            openChildFormInPanel(new MusicPlayerForm());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideMinuPanel();
            openChildFormInPanel(new MusicList());
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (musiclist == true)
                openChildFormInPanel(new MusicList()); musiclist = false;
            if (musicform == true)
                openChildFormInPanel(new MusicPlayerForm()); musicform = false;
            
        }

        private void MusicPlayer_Click(object sender, EventArgs e)
        {
            hideMinuPanel();
            musicform = true;
        }

        private void btnmusiclist_Click(object sender, EventArgs e)
        {
            hideMinuPanel();
            musiclist = true;
        }
    }
}
