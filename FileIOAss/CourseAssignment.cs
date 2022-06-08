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
    public partial class CourseAssignment : Form
    {
        public CourseAssignment()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"G:\suraj\abc1.txt", FileMode.Create, FileAccess.Write);
            try
            {
                BinaryWriter bw = new BinaryWriter(fs);
                int id = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                int fees = Convert.ToInt32(txtFees.Text);
                bw.Write(id);
                bw.Write(name);
                bw.Write(fees);
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

        private void btnRead_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"G:\suraj\abc1.txt", FileMode.Open, FileAccess.Read);
            try
            {


                // fs = new FileStream(@"G:\suraj\abc.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int id = br.ReadInt32();
                string name = br.ReadString();
                int fees = br.ReadInt32();
                txtId.Text = id.ToString();
                txtName.Text = name;
                txtFees.Text = fees.ToString();
                br.Close();

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
    }
    
}
