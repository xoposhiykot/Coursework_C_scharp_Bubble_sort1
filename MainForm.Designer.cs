namespace Coursework_C_sharp_Bubble_sort
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsData = new System.Windows.Forms.DataGridView();
            this.openDataBtn = new System.Windows.Forms.Button();
            this.sortDataBtn = new System.Windows.Forms.Button();
            this.addDataBtn = new System.Windows.Forms.Button();
            this.saveDataBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.subnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.eventsInfo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.slowUpdateBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentsData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsData
            // 
            this.studentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsData.Location = new System.Drawing.Point(145, 12);
            this.studentsData.Name = "studentsData";
            this.studentsData.Size = new System.Drawing.Size(398, 426);
            this.studentsData.TabIndex = 0;
            // 
            // openDataBtn
            // 
            this.openDataBtn.Location = new System.Drawing.Point(4, 4);
            this.openDataBtn.Name = "openDataBtn";
            this.openDataBtn.Size = new System.Drawing.Size(117, 35);
            this.openDataBtn.TabIndex = 0;
            this.openDataBtn.Text = "Open File";
            this.openDataBtn.UseVisualStyleBackColor = true;
            this.openDataBtn.Click += new System.EventHandler(this.openDataBtn_Click);
            // 
            // sortDataBtn
            // 
            this.sortDataBtn.Location = new System.Drawing.Point(4, 86);
            this.sortDataBtn.Name = "sortDataBtn";
            this.sortDataBtn.Size = new System.Drawing.Size(117, 35);
            this.sortDataBtn.TabIndex = 1;
            this.sortDataBtn.Text = "Sort Data ( Bubble)";
            this.sortDataBtn.UseVisualStyleBackColor = true;
            this.sortDataBtn.Click += new System.EventHandler(this.sortDataBtn_Click);
            // 
            // addDataBtn
            // 
            this.addDataBtn.Location = new System.Drawing.Point(3, 385);
            this.addDataBtn.Name = "addDataBtn";
            this.addDataBtn.Size = new System.Drawing.Size(117, 35);
            this.addDataBtn.TabIndex = 2;
            this.addDataBtn.Text = "Add Data";
            this.addDataBtn.UseVisualStyleBackColor = true;
            this.addDataBtn.Click += new System.EventHandler(this.addDataBtn_Click);
            // 
            // saveDataBtn
            // 
            this.saveDataBtn.Location = new System.Drawing.Point(4, 45);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Size = new System.Drawing.Size(117, 35);
            this.saveDataBtn.TabIndex = 3;
            this.saveDataBtn.Text = "Save Data";
            this.saveDataBtn.UseVisualStyleBackColor = true;
            this.saveDataBtn.Click += new System.EventHandler(this.saveDataBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.subnameBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 163);
            this.panel2.TabIndex = 10;
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(9, 106);
            this.groupBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.groupBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(112, 20);
            this.groupBox.TabIndex = 15;
            this.groupBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Group";
            // 
            // subnameBox
            // 
            this.subnameBox.Location = new System.Drawing.Point(7, 66);
            this.subnameBox.Name = "subnameBox";
            this.subnameBox.Size = new System.Drawing.Size(115, 20);
            this.subnameBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Subname";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(6, 27);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(115, 20);
            this.nameBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.saveDataBtn);
            this.panel1.Controls.Add(this.addDataBtn);
            this.panel1.Controls.Add(this.sortDataBtn);
            this.panel1.Controls.Add(this.openDataBtn);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 425);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sort Data (Key counting)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Restore database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eventsInfo
            // 
            this.eventsInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.eventsInfo.Location = new System.Drawing.Point(13, 461);
            this.eventsInfo.Name = "eventsInfo";
            this.eventsInfo.ReadOnly = true;
            this.eventsInfo.Size = new System.Drawing.Size(530, 102);
            this.eventsInfo.TabIndex = 2;
            this.eventsInfo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Events Info:";
            // 
            // slowUpdateBox
            // 
            this.slowUpdateBox.AutoSize = true;
            this.slowUpdateBox.Location = new System.Drawing.Point(458, 441);
            this.slowUpdateBox.Name = "slowUpdateBox";
            this.slowUpdateBox.Size = new System.Drawing.Size(87, 17);
            this.slowUpdateBox.TabIndex = 4;
            this.slowUpdateBox.Text = "Slow Update";
            this.slowUpdateBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 575);
            this.Controls.Add(this.slowUpdateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventsInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentsData);
            this.Name = "MainForm";
            this.Text = "Coursework";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsData;
        private System.Windows.Forms.Button openDataBtn;
        private System.Windows.Forms.Button sortDataBtn;
        private System.Windows.Forms.Button addDataBtn;
        private System.Windows.Forms.Button saveDataBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox eventsInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox slowUpdateBox;
    }
}

