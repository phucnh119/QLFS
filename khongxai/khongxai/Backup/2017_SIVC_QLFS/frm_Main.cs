using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2017_SIVC_QLFS
{
    public partial class frm_Main : Form
    {
        private int childFormNumber = 0;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.MdiParent = this;
            frm.Show();
            Loadmenu();
        }

        private void ts_Branch_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_Branch"))
            {
                frm_Branch frm = new frm_Branch();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_Branch");
            }



        }

        public void Loadmenu()
        {
            ts_HeTHong.Enabled = false;
            ts_Manage.Enabled = false;
            ts_Search.Enabled = false;
        }

        public void MenuAdmin()
        {
            ts_HeTHong.Enabled = true;
            ts_Manage.Enabled = true;
            ts_Search.Enabled = true;
        }

        public void MenuUpload()
        {
            ts_HeTHong.Enabled = false;
            ts_Manage.Enabled = true;
            ts_Search.Enabled = true;

        }
        public void MenuUser()
        {
            ts_HeTHong.Enabled = false;
            ts_Manage.Enabled = false;
            ts_Search.Enabled = true;
        }

        private void ts_Staff_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_Staff"))
            {
                frm_Staff frm = new frm_Staff();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_Staff");
            }




        }

        private void ts_User_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_AccountStaff"))
            {
                frm_AccountStaff frm = new frm_AccountStaff();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_AccountStaff");
            }


        }

        private void ts_Role_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_Role"))
            {
                frm_Role frm = new frm_Role();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_Role");
            }

        }

        private void ts_Property_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_PropertyType"))
            {
                frm_PropertyType frm = new frm_PropertyType();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_PropertyType");
            }




        }

        private void ts__ValuationCertificate_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_ValuationCertificate"))
            {
                frm_ValuationCertificate frm = new frm_ValuationCertificate();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_ValuationCertificate");
            }

        }

        private void ts_Upload_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_Upload"))
            {
                frm_Upload frm = new frm_Upload();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_Upload");
            }


        }

        private void ts_Search_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_Detal"))
            {
                frm_Detal frm = new frm_Detal();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_Detal");
            }




        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
