namespace CapstoneTuitionProject
{
    partial class TuitionCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuitionCalculatorForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_studentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_studentANum = new System.Windows.Forms.TextBox();
            this.gb_residentRadios = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rad_InStateTrue = new System.Windows.Forms.RadioButton();
            this.lb_courseList = new System.Windows.Forms.ListBox();
            this.bt_addClass = new System.Windows.Forms.Button();
            this.tb_courseName = new System.Windows.Forms.TextBox();
            this.tb_courseHrs = new System.Windows.Forms.TextBox();
            this.tb_courseCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_deleteClass = new System.Windows.Forms.Button();
            this.bt_editClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_costCalcutation = new System.Windows.Forms.Label();
            this.bt_saveAllPrint = new System.Windows.Forms.Button();
            this.cb_highSchool = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_residentRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 121);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 86);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tuition Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Student Name:";
            // 
            // tb_studentName
            // 
            this.tb_studentName.Location = new System.Drawing.Point(271, 143);
            this.tb_studentName.Name = "tb_studentName";
            this.tb_studentName.Size = new System.Drawing.Size(487, 49);
            this.tb_studentName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 42);
            this.label3.TabIndex = 15;
            this.label3.Text = "Student A#:";
            // 
            // tb_studentANum
            // 
            this.tb_studentANum.Location = new System.Drawing.Point(271, 189);
            this.tb_studentANum.Name = "tb_studentANum";
            this.tb_studentANum.Size = new System.Drawing.Size(487, 49);
            this.tb_studentANum.TabIndex = 1;
            // 
            // gb_residentRadios
            // 
            this.gb_residentRadios.Controls.Add(this.radioButton2);
            this.gb_residentRadios.Controls.Add(this.rad_InStateTrue);
            this.gb_residentRadios.Location = new System.Drawing.Point(56, 229);
            this.gb_residentRadios.Name = "gb_residentRadios";
            this.gb_residentRadios.Size = new System.Drawing.Size(702, 65);
            this.gb_residentRadios.TabIndex = 2;
            this.gb_residentRadios.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(393, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(405, 46);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Out of State Resident";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.onCheckedChanged);
            // 
            // rad_InStateTrue
            // 
            this.rad_InStateTrue.AutoSize = true;
            this.rad_InStateTrue.Location = new System.Drawing.Point(56, 14);
            this.rad_InStateTrue.Name = "rad_InStateTrue";
            this.rad_InStateTrue.Size = new System.Drawing.Size(394, 46);
            this.rad_InStateTrue.TabIndex = 3;
            this.rad_InStateTrue.TabStop = true;
            this.rad_InStateTrue.Text = "Tennessee Resident";
            this.rad_InStateTrue.UseVisualStyleBackColor = true;
            this.rad_InStateTrue.CheckedChanged += new System.EventHandler(this.onCheckedChanged);
            // 
            // lb_courseList
            // 
            this.lb_courseList.FormattingEnabled = true;
            this.lb_courseList.ItemHeight = 42;
            this.lb_courseList.Location = new System.Drawing.Point(56, 437);
            this.lb_courseList.Name = "lb_courseList";
            this.lb_courseList.Size = new System.Drawing.Size(573, 130);
            this.lb_courseList.TabIndex = 12;
            // 
            // bt_addClass
            // 
            this.bt_addClass.Location = new System.Drawing.Point(648, 360);
            this.bt_addClass.Name = "bt_addClass";
            this.bt_addClass.Size = new System.Drawing.Size(115, 38);
            this.bt_addClass.TabIndex = 9;
            this.bt_addClass.Text = "&Add";
            this.bt_addClass.UseVisualStyleBackColor = true;
            this.bt_addClass.Click += new System.EventHandler(this.bt_addClass_Click);
            // 
            // tb_courseName
            // 
            this.tb_courseName.Location = new System.Drawing.Point(214, 364);
            this.tb_courseName.Name = "tb_courseName";
            this.tb_courseName.Size = new System.Drawing.Size(326, 49);
            this.tb_courseName.TabIndex = 7;
            this.tb_courseName.Text = "Course Name";
            // 
            // tb_courseHrs
            // 
            this.tb_courseHrs.Location = new System.Drawing.Point(546, 364);
            this.tb_courseHrs.Name = "tb_courseHrs";
            this.tb_courseHrs.Size = new System.Drawing.Size(83, 49);
            this.tb_courseHrs.TabIndex = 8;
            this.tb_courseHrs.Text = "Hours";
            // 
            // tb_courseCode
            // 
            this.tb_courseCode.Location = new System.Drawing.Point(53, 364);
            this.tb_courseCode.Name = "tb_courseCode";
            this.tb_courseCode.Size = new System.Drawing.Size(155, 49);
            this.tb_courseCode.TabIndex = 6;
            this.tb_courseCode.Text = "Course Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 42);
            this.label4.TabIndex = 16;
            this.label4.Text = "Current Class List";
            // 
            // bt_deleteClass
            // 
            this.bt_deleteClass.Location = new System.Drawing.Point(646, 481);
            this.bt_deleteClass.Name = "bt_deleteClass";
            this.bt_deleteClass.Size = new System.Drawing.Size(115, 40);
            this.bt_deleteClass.TabIndex = 11;
            this.bt_deleteClass.Text = "&Delete";
            this.bt_deleteClass.UseVisualStyleBackColor = true;
            this.bt_deleteClass.Click += new System.EventHandler(this.bt_deleteClass_Click);
            // 
            // bt_editClass
            // 
            this.bt_editClass.Location = new System.Drawing.Point(646, 437);
            this.bt_editClass.Name = "bt_editClass";
            this.bt_editClass.Size = new System.Drawing.Size(115, 40);
            this.bt_editClass.TabIndex = 10;
            this.bt_editClass.Text = "&Edit";
            this.bt_editClass.UseVisualStyleBackColor = true;
            this.bt_editClass.Click += new System.EventHandler(this.bt_editClass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 42);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total Cost of Tuition:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 61);
            this.label6.TabIndex = 18;
            this.label6.Text = "$";
            // 
            // lbl_costCalcutation
            // 
            this.lbl_costCalcutation.AutoSize = true;
            this.lbl_costCalcutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costCalcutation.Location = new System.Drawing.Point(159, 658);
            this.lbl_costCalcutation.Name = "lbl_costCalcutation";
            this.lbl_costCalcutation.Size = new System.Drawing.Size(129, 61);
            this.lbl_costCalcutation.TabIndex = 19;
            this.lbl_costCalcutation.Text = "0.00";
            // 
            // bt_saveAllPrint
            // 
            this.bt_saveAllPrint.Location = new System.Drawing.Point(646, 648);
            this.bt_saveAllPrint.Name = "bt_saveAllPrint";
            this.bt_saveAllPrint.Size = new System.Drawing.Size(115, 40);
            this.bt_saveAllPrint.TabIndex = 13;
            this.bt_saveAllPrint.Text = "&Save";
            this.bt_saveAllPrint.UseVisualStyleBackColor = true;
            this.bt_saveAllPrint.Click += new System.EventHandler(this.bt_saveAllPrint_Click);
            // 
            // cb_highSchool
            // 
            this.cb_highSchool.AutoSize = true;
            this.cb_highSchool.Location = new System.Drawing.Point(53, 310);
            this.cb_highSchool.Name = "cb_highSchool";
            this.cb_highSchool.Size = new System.Drawing.Size(1036, 46);
            this.cb_highSchool.TabIndex = 5;
            this.cb_highSchool.Text = "Will be enrolled in High School classes during this semester";
            this.cb_highSchool.UseVisualStyleBackColor = true;
            this.cb_highSchool.CheckedChanged += new System.EventHandler(this.onCheckedChanged);
            // 
            // TuitionCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(799, 735);
            this.Controls.Add(this.cb_highSchool);
            this.Controls.Add(this.bt_saveAllPrint);
            this.Controls.Add(this.lbl_costCalcutation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_editClass);
            this.Controls.Add(this.bt_deleteClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_courseCode);
            this.Controls.Add(this.tb_courseHrs);
            this.Controls.Add(this.tb_courseName);
            this.Controls.Add(this.bt_addClass);
            this.Controls.Add(this.lb_courseList);
            this.Controls.Add(this.gb_residentRadios);
            this.Controls.Add(this.tb_studentANum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_studentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "TuitionCalculatorForm";
            this.Text = "Tuition Calculator";
            this.Load += new System.EventHandler(this.TuitionCalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_residentRadios.ResumeLayout(false);
            this.gb_residentRadios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_studentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_studentANum;
        private System.Windows.Forms.GroupBox gb_residentRadios;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rad_InStateTrue;
        private System.Windows.Forms.ListBox lb_courseList;
        private System.Windows.Forms.Button bt_addClass;
        private System.Windows.Forms.TextBox tb_courseName;
        private System.Windows.Forms.TextBox tb_courseHrs;
        private System.Windows.Forms.TextBox tb_courseCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_deleteClass;
        private System.Windows.Forms.Button bt_editClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_costCalcutation;
        private System.Windows.Forms.Button bt_saveAllPrint;
        private System.Windows.Forms.CheckBox cb_highSchool;
    }
}

