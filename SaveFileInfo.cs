using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_C_sharp_Bubble_sort
{
    public partial class SaveFileInfo : Form
    {
        public string fileName;
        public bool choosenFileName;
        public SaveFileInfo()
        {
            InitializeComponent();
            choosenFileName = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // check data in box
            if(fileNameBox.Text == "")
            {
                MessageBox.Show("Error: empty string;", "ERROR");
                return;
            }

            choosenFileName = true;

            // process and save file name
            fileName = fileNameBox.Text;
            fileName = fileName.Replace(' ', '_');
            fileName += ".txt";

            // close form
            this.Close();
        }
    }
}
