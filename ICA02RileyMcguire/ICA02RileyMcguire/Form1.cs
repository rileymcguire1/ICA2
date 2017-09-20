using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICA02RileyMcguire
{
    public partial class Form1 : Form
    {
        bool bSave;
        
        public Form1()
        {
            InitializeComponent();
            bSave = true;
        }

        private void _btnOpenFile_Click(object sender, EventArgs e)
        {
            if (bSave)
            {
                _dialOpen.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    StreamReader srInputFile;
                    this.Text = _dialOpen.SafeFileName;
                    try
                    {
                        srInputFile = new StreamReader(this.Text);
                    }
                    catch
                    { }
                    finally
                    {
                        srInputFile.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Do you want to save the current file?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    _dialSave.ShowDialog();
                }
            }
        }

        private void _dialOpen_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void _txtbox1_TextChanged(object sender, EventArgs e)
        {
            bSave = false;
        }
    }
}
