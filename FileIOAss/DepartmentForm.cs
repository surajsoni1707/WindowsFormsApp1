using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FileIOAss
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"G:\suraj\abc.txt", FileMode.Create, FileAccess.Write);
            try
            {
                BinaryWriter bw = new BinaryWriter(fs);
                int id = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                string loc = txtLocation.Text;
                bw.Write(id);
                bw.Write(name);
                bw.Write(loc);
                bw.Close();
                
                MessageBox.Show("Done");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"G:\suraj";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Folder Already Exist");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Folder Create");
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"G:\suraj\abc.txt";
            if(File.Exists(path))
            {
                MessageBox.Show("File Already Exist");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File Create");
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"G:\suraj\abc.txt", FileMode.Open, FileAccess.Read);
            try
            {


                // fs = new FileStream(@"G:\suraj\abc.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int id = br.ReadInt32();
                string name = br.ReadString();
                string loc = br.ReadString();
                txtID.Text = id.ToString();
                txtName.Text = name;
                txtLocation.Text = loc;
                br.Close();
                
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
