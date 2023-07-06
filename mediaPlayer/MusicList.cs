using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaPlayer
{
    public partial class MusicList : Form
    {
        public MusicList()
        {
            InitializeComponent();
        }

        Form1 form1 = new Form1();
        string[] paths, Files;
        public string url;

        public string url1
        {
            get { return this.url; }
            set { this.url = value;  }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hideControls();
            openChildFormInPanel(new MusicPlayerForm());
        }
        Form1 form = new Form1();
        private Form activeForm = null;

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

        private void OpenFille_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.Multiselect = true;
            if(ofl.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                Files = ofl.FileNames;
                paths = ofl.FileNames;
                for(int x = 0; x < Files.Length; x++)
                {
                    Music_Lest.Items.Add(Files[x]);
                }
            }
        }


        private void hideControls()
        {
            Music_Lest.Visible = false;
            pictureBox1.Visible = false;
            button1.Visible = false;
            OpenFille.Visible = false;
        }

        private void Music_Lest_SelectedIndexChanged(object sender, EventArgs e)
        {
            url = paths[Music_Lest.SelectedIndex];
            hideControls();
            openChildFormInPanel(new MusicPlayerForm());
        }
    }
}
