using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Coursework_C_sharp_Bubble_sort
{
    public struct Data
    {
        public string name;
        public string subname;

        public int group;
    }
    public partial class MainForm : Form
    {
        private string data;

        public MainForm()
        {
            InitializeComponent();
        }

        // open database
        private void openDataBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // open file
            string filename = openFileDialog1.FileName;

            // read data from file
            data = System.IO.File.ReadAllText(filename, Encoding.UTF8);

            restoreDatabase();
            // write data in database
            fillDatabase(data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentsData.ColumnCount = 3;
            studentsData.RowCount = 1;

            studentsData.Columns[0].HeaderCell.Value = "Name";
            studentsData.Columns[1].HeaderCell.Value = "Surname";
            studentsData.Columns[2].HeaderCell.Value = "Group";

            studentsData.Rows[0].HeaderCell.Value = "";
        }

        private void addDataBtn_Click(object sender, EventArgs e)
        {
            // save data
            string name = nameBox.Text;
            string subname = subnameBox.Text;
            int group = Convert.ToInt32(groupBox.Value);

            // check data
            if (name == "" || subname == "")
            {
                MessageBox.Show("Error: empty data;", "ERROR");
                return;
            }

            if(name.Contains(' ') || subname.Contains(' '))
            {
                MessageBox.Show("Error: spaces in data;", "ERROR");
                return;
            }

            // check number in name and subname
            bool checkNumbers = false;
            string tmp = name + subname;
            for (int j = 0; j < 10; ++j)
                if (tmp.Contains(j.ToString()))
                    checkNumbers = true;

            if (checkNumbers)
            {
                MessageBox.Show( "Error: illegal  symbol;", "ERROR");
                return;
            }

            // set first letter as Upper others as Lower
            normalStyle(ref name);
            normalStyle(ref subname);

            // search in database similar
            if (searchDataInBase(name, subname, group))
            {
                MessageBox.Show("Error: already exist;", "ERROR");
                return;
            }

            addData(name, subname, group);
        }

        // set first letter as Upper case others as Lower case
        private void normalStyle(ref string str)
        {
            string tmp_1 = "";
            string tmp_2 = "";

            tmp_1 += str[0];
            tmp_1 = tmp_1.ToUpper();

            for (int i = 1; i < str.Length; ++i)
                tmp_2 += str[i];

            tmp_2 = tmp_2.ToLower();

            str = tmp_1 + tmp_2;
        }

        // add data to database
        private void addData(string name, string subname, int group, bool refresh = true)
        {
            // add data
            // save row number and increment that
            int rowNum = studentsData.RowCount++;

            //write header number
            studentsData.Rows[rowNum - 1].HeaderCell.Value = rowNum.ToString();
            // write info
            studentsData.Rows[rowNum - 1].Cells[0].Value = name;
            studentsData.Rows[rowNum - 1].Cells[1].Value = subname;
            studentsData.Rows[rowNum - 1].Cells[2].Value = group.ToString();

            // refresh database
            if (refresh)
                studentsData.Refresh();
        }
        private void addData(Data dt, bool refresh = true)
        {
            // add data
            // save row number and increment that
            int rowNum = studentsData.RowCount++;

            //write header number
            studentsData.Rows[rowNum - 1].HeaderCell.Value = rowNum.ToString();
            // write info
            studentsData.Rows[rowNum - 1].Cells[0].Value = dt.name;
            studentsData.Rows[rowNum - 1].Cells[1].Value = dt.subname;
            studentsData.Rows[rowNum - 1].Cells[2].Value = dt.group.ToString();

            // refresh database
            if(refresh)
                studentsData.Refresh();
        }

        private bool searchDataInBase(string name, string subname, int group)
        {
            bool result = false;

            for(int i = 0; i < studentsData.RowCount - 1; ++i)
            {
                string nameTmp = studentsData.Rows[i].Cells[0].Value.ToString();
                string subnameTmp = studentsData.Rows[i].Cells[1].Value.ToString();
                int groupTmp = Convert.ToInt32(studentsData.Rows[i].Cells[2].Value);

                if (name == nameTmp && subname == subnameTmp && group == groupTmp)
                    result = true;
            }

            return result;
        }

        // button for save data in file
        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            string fileName = "";

            SaveFileInfo SFI = new SaveFileInfo();

            // add event
            SFI.FormClosing += (sender1, e1) =>
            {
                fileName = SFI.fileName;
            };

            SFI.FormClosed += (sender1, e1) =>
            {
                if(SFI.choosenFileName)
                    saveData(fileName);
            };

            SFI.Show();
        }

        // save data in file
        private void saveData(string fileName)
        {
            Data tmpDt;
            // check file
            // if not exist
            if (!File.Exists(fileName))
            {
                // Create a file
                StreamWriter sw = File.CreateText(fileName);

                for (int i = 0; i < studentsData.RowCount - 1; ++i)
                {
                    tmpDt = readData(i);
                    sw.WriteLine(tmpDt.name + "\t" + tmpDt.subname + "\t" + tmpDt.group.ToString());
                }

                sw.WriteLine();
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write), System.Text.Encoding.UTF8);

                for(int i = 0; i < studentsData.RowCount - 1; ++i)
                {
                    tmpDt = readData(i);
                    sw.WriteLine(tmpDt.name + "\t" + tmpDt.subname + "\t" + tmpDt.group.ToString());
                }

                sw.Close();
            }
        }

        // read data form row
        private Data readData(int row)
        {
            Data dt;

            dt.name = studentsData.Rows[row].Cells[0].Value.ToString();
            dt.subname = studentsData.Rows[row].Cells[1].Value.ToString();
            dt.group = Convert.ToInt32(studentsData.Rows[row].Cells[2].Value);

            return dt;
        }
        // fill database with data
        private void fillDatabase(string data)
        {
            // split on frazes
            string[] frazes = data.Split('\n');

            // save data
            for (int i = 0; i < frazes.Length; ++i)
            {
                if (frazes[i] == "" || frazes[i] == "\r")
                    continue;

                string[] dataRow = frazes[i].Split('\t');

                addData(dataRow[0], dataRow[1], Convert.ToInt32(dataRow[2]), false);
            }

            studentsData.Refresh();
        }

        // restore database
        private void restoreDatabase()
        {
            studentsData.ColumnCount = 3;
            studentsData.RowCount = 1;

            studentsData.Columns[0].HeaderCell.Value = "Name";
            studentsData.Columns[1].HeaderCell.Value = "Surname";
            studentsData.Columns[2].HeaderCell.Value = "Group";

            studentsData.Rows[0].HeaderCell.Value = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restoreDatabase();
        }


        // sort functions
        void bubbleSortInBase()
        {
            eventsInfo.Text += "[+] info: Start sort using: Bubble sort;\n";

            bool swapFlag = true;

            while (swapFlag)
            {
                swapFlag = false;

                for(int i = 0; i < studentsData.RowCount - 2; ++i)
                {
                    Data dt_1, dt_2;

                    dt_1.name = studentsData.Rows[i].Cells[0].Value.ToString();
                    dt_1.subname = studentsData.Rows[i].Cells[1].Value.ToString();
                    dt_1.group = Convert.ToInt32(studentsData.Rows[i].Cells[2].Value);

                    dt_2.name = studentsData.Rows[i + 1].Cells[0].Value.ToString();
                    dt_2.subname = studentsData.Rows[i + 1].Cells[1].Value.ToString();
                    dt_2.group = Convert.ToInt32(studentsData.Rows[i + 1].Cells[2].Value);

                    if (dt_1.subname[0] > dt_2.subname[0])
                    {
                        swapData(dt_1, dt_2, i);
                        swapFlag = true;
                    }
                }
            }

            eventsInfo.Text += "[+] info: End sort using: Bubble sort;\n";
            eventsInfo.Refresh();

            studentsData.Refresh();
        }

        void swapData(Data dt_1, Data dt_2, int row)
        {
            eventsInfo.Text += "[++]:> SWAP row: " + (row + 1) + " and row: " + (row + 2) + "\n";
            eventsInfo.Text += "\t [data]:> row: " + (row + 1) + " name: " + dt_1.name + " surname: " + dt_1.subname + " group: " + dt_1.group + "\n";
            eventsInfo.Text += "\t [data]:> row: " + (row + 2) + " name: " + dt_2.name + " surname: " + dt_2.subname + " group: " + dt_2.group + "\n";

            if (slowUpdateBox.Checked == true)
            {
                studentsData.Rows[row].DefaultCellStyle.BackColor = Color.LightGreen;
                studentsData.Rows[row + 1].DefaultCellStyle.BackColor = Color.LightBlue;
                studentsData.Refresh();
                Thread.Sleep(700);
            }

            eventsInfo.Refresh();

            studentsData.Rows[row].Cells[0].Value = dt_2.name;
            studentsData.Rows[row].Cells[1].Value = dt_2.subname;
            studentsData.Rows[row].Cells[2].Value = dt_2.group.ToString();

            studentsData.Rows[row + 1].Cells[0].Value = dt_1.name;
            studentsData.Rows[row + 1].Cells[1].Value = dt_1.subname;
            studentsData.Rows[row + 1].Cells[2].Value = dt_1.group.ToString();

            if(slowUpdateBox.Checked == true)
            {
                Thread.Sleep(1300);

                studentsData.Rows[row].DefaultCellStyle.BackColor = Color.White;
                studentsData.Rows[row + 1].DefaultCellStyle.BackColor = Color.White;

                studentsData.Refresh();
            }
        }

        private void sortDataBtn_Click(object sender, EventArgs e)
        {
            bubbleSortInBase();
        }
    }
}