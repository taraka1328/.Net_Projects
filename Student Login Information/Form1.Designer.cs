namespace Lab2
{
    partial class form_stu_info
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            g_box_ac_info = new GroupBox();
            combo_c_sem = new ComboBox();
            lab_c_sem = new Label();
            combo_c_year = new ComboBox();
            lab_c_year = new Label();
            lab_stu_name = new Label();
            txt_stu_name = new TextBox();
            txt_stu_roll = new TextBox();
            lab_stu_roll = new Label();
            g_box_stu_act = new GroupBox();
            txt_backlogs = new TextBox();
            l_box_sac_clubs = new ListBox();
            lab_sac_clubs = new Label();
            lab_backlogs = new Label();
            txt_cgpa = new TextBox();
            lab_cgpa = new Label();
            g_box_per_act = new GroupBox();
            combo_gender = new ComboBox();
            txt_stu_phno = new TextBox();
            txt_f_phno = new TextBox();
            txt_fname = new TextBox();
            txt_mname = new TextBox();
            lab_stu_phno = new Label();
            lab_f_phno = new Label();
            lab_fname = new Label();
            lab_mname = new Label();
            lab_gender = new Label();
            btn_submit = new Button();
            g_box_ac_info.SuspendLayout();
            g_box_stu_act.SuspendLayout();
            g_box_per_act.SuspendLayout();
            SuspendLayout();
            // 
            // g_box_ac_info
            // 
            g_box_ac_info.Controls.Add(combo_c_sem);
            g_box_ac_info.Controls.Add(lab_c_sem);
            g_box_ac_info.Controls.Add(combo_c_year);
            g_box_ac_info.Controls.Add(lab_c_year);
            g_box_ac_info.Controls.Add(lab_stu_name);
            g_box_ac_info.Controls.Add(txt_stu_name);
            g_box_ac_info.Controls.Add(txt_stu_roll);
            g_box_ac_info.Controls.Add(lab_stu_roll);
            g_box_ac_info.Location = new Point(38, 41);
            g_box_ac_info.Name = "g_box_ac_info";
            g_box_ac_info.Size = new Size(381, 201);
            g_box_ac_info.TabIndex = 0;
            g_box_ac_info.TabStop = false;
            g_box_ac_info.Text = "Account Information";
            // 
            // combo_c_sem
            // 
            combo_c_sem.FormattingEnabled = true;
            combo_c_sem.Items.AddRange(new object[] { "1", "2" });
            combo_c_sem.Location = new Point(179, 156);
            combo_c_sem.Name = "combo_c_sem";
            combo_c_sem.Size = new Size(125, 28);
            combo_c_sem.TabIndex = 7;
            // 
            // lab_c_sem
            // 
            lab_c_sem.AutoSize = true;
            lab_c_sem.Location = new Point(19, 156);
            lab_c_sem.Name = "lab_c_sem";
            lab_c_sem.Size = new Size(145, 20);
            lab_c_sem.TabIndex = 6;
            lab_c_sem.Text = "CURRENT SEM         :";
            // 
            // combo_c_year
            // 
            combo_c_year.FormattingEnabled = true;
            combo_c_year.Items.AddRange(new object[] { "1", "2", "3", "4" });
            combo_c_year.Location = new Point(179, 119);
            combo_c_year.Name = "combo_c_year";
            combo_c_year.Size = new Size(125, 28);
            combo_c_year.TabIndex = 5;
            // 
            // lab_c_year
            // 
            lab_c_year.AutoSize = true;
            lab_c_year.Location = new Point(19, 116);
            lab_c_year.Name = "lab_c_year";
            lab_c_year.Size = new Size(143, 20);
            lab_c_year.TabIndex = 4;
            lab_c_year.Text = "CURRENT YEAR       :";
            // 
            // lab_stu_name
            // 
            lab_stu_name.AutoSize = true;
            lab_stu_name.Location = new Point(19, 77);
            lab_stu_name.Name = "lab_stu_name";
            lab_stu_name.Size = new Size(142, 20);
            lab_stu_name.TabIndex = 3;
            lab_stu_name.Text = "STUDENT NAME     :";
            // 
            // txt_stu_name
            // 
            txt_stu_name.Location = new Point(179, 77);
            txt_stu_name.Name = "txt_stu_name";
            txt_stu_name.Size = new Size(125, 27);
            txt_stu_name.TabIndex = 2;
            // 
            // txt_stu_roll
            // 
            txt_stu_roll.Location = new Point(179, 35);
            txt_stu_roll.Name = "txt_stu_roll";
            txt_stu_roll.Size = new Size(125, 27);
            txt_stu_roll.TabIndex = 1;
            // 
            // lab_stu_roll
            // 
            lab_stu_roll.AutoSize = true;
            lab_stu_roll.Location = new Point(19, 38);
            lab_stu_roll.Name = "lab_stu_roll";
            lab_stu_roll.Size = new Size(144, 20);
            lab_stu_roll.TabIndex = 0;
            lab_stu_roll.Text = "STUDENT ROLLNO  :";
            // 
            // g_box_stu_act
            // 
            g_box_stu_act.Controls.Add(txt_backlogs);
            g_box_stu_act.Controls.Add(l_box_sac_clubs);
            g_box_stu_act.Controls.Add(lab_sac_clubs);
            g_box_stu_act.Controls.Add(lab_backlogs);
            g_box_stu_act.Controls.Add(txt_cgpa);
            g_box_stu_act.Controls.Add(lab_cgpa);
            g_box_stu_act.Location = new Point(38, 292);
            g_box_stu_act.Name = "g_box_stu_act";
            g_box_stu_act.Size = new Size(420, 230);
            g_box_stu_act.TabIndex = 1;
            g_box_stu_act.TabStop = false;
            g_box_stu_act.Text = "STUDENT ACTIVITIES";
            // 
            // txt_backlogs
            // 
            txt_backlogs.Location = new Point(202, 67);
            txt_backlogs.Name = "txt_backlogs";
            txt_backlogs.Size = new Size(125, 27);
            txt_backlogs.TabIndex = 7;
            // 
            // l_box_sac_clubs
            // 
            l_box_sac_clubs.FormattingEnabled = true;
            l_box_sac_clubs.Items.AddRange(new object[] { "Dance Club", "Singing Club", "Movie Appretiation Club", "Culinary Club", "NOT INTRESTED" });
            l_box_sac_clubs.Location = new Point(202, 104);
            l_box_sac_clubs.Name = "l_box_sac_clubs";
            l_box_sac_clubs.Size = new Size(179, 104);
            l_box_sac_clubs.TabIndex = 6;
            // 
            // lab_sac_clubs
            // 
            lab_sac_clubs.AutoSize = true;
            lab_sac_clubs.Location = new Point(21, 104);
            lab_sac_clubs.Name = "lab_sac_clubs";
            lab_sac_clubs.Size = new Size(166, 20);
            lab_sac_clubs.TabIndex = 5;
            lab_sac_clubs.Text = "SAC CLUBS                    :";
            // 
            // lab_backlogs
            // 
            lab_backlogs.AutoSize = true;
            lab_backlogs.Location = new Point(19, 70);
            lab_backlogs.Name = "lab_backlogs";
            lab_backlogs.Size = new Size(168, 20);
            lab_backlogs.TabIndex = 4;
            lab_backlogs.Text = "STUDENT BACKLOGS    :";
            // 
            // txt_cgpa
            // 
            txt_cgpa.Location = new Point(202, 32);
            txt_cgpa.Name = "txt_cgpa";
            txt_cgpa.Size = new Size(125, 27);
            txt_cgpa.TabIndex = 2;
            // 
            // lab_cgpa
            // 
            lab_cgpa.AutoSize = true;
            lab_cgpa.Location = new Point(21, 39);
            lab_cgpa.Name = "lab_cgpa";
            lab_cgpa.Size = new Size(168, 20);
            lab_cgpa.TabIndex = 1;
            lab_cgpa.Text = "STUDENT CGPA             :";
            // 
            // g_box_per_act
            // 
            g_box_per_act.Controls.Add(combo_gender);
            g_box_per_act.Controls.Add(txt_stu_phno);
            g_box_per_act.Controls.Add(txt_f_phno);
            g_box_per_act.Controls.Add(txt_fname);
            g_box_per_act.Controls.Add(txt_mname);
            g_box_per_act.Controls.Add(lab_stu_phno);
            g_box_per_act.Controls.Add(lab_f_phno);
            g_box_per_act.Controls.Add(lab_fname);
            g_box_per_act.Controls.Add(lab_mname);
            g_box_per_act.Controls.Add(lab_gender);
            g_box_per_act.Location = new Point(487, 41);
            g_box_per_act.Name = "g_box_per_act";
            g_box_per_act.Size = new Size(363, 241);
            g_box_per_act.TabIndex = 2;
            g_box_per_act.TabStop = false;
            g_box_per_act.Text = "PERSONAL INFORMATION";
            // 
            // combo_gender
            // 
            combo_gender.FormattingEnabled = true;
            combo_gender.Items.AddRange(new object[] { "MALE", "FEMALE", "OTHERS" });
            combo_gender.Location = new Point(197, 31);
            combo_gender.Name = "combo_gender";
            combo_gender.Size = new Size(125, 28);
            combo_gender.TabIndex = 20;
            // 
            // txt_stu_phno
            // 
            txt_stu_phno.Location = new Point(195, 196);
            txt_stu_phno.Name = "txt_stu_phno";
            txt_stu_phno.Size = new Size(125, 27);
            txt_stu_phno.TabIndex = 19;
            // 
            // txt_f_phno
            // 
            txt_f_phno.Location = new Point(195, 154);
            txt_f_phno.Name = "txt_f_phno";
            txt_f_phno.Size = new Size(125, 27);
            txt_f_phno.TabIndex = 18;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(195, 116);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(125, 27);
            txt_fname.TabIndex = 17;
            // 
            // txt_mname
            // 
            txt_mname.Location = new Point(197, 77);
            txt_mname.Name = "txt_mname";
            txt_mname.Size = new Size(125, 27);
            txt_mname.TabIndex = 16;
            // 
            // lab_stu_phno
            // 
            lab_stu_phno.AutoSize = true;
            lab_stu_phno.Location = new Point(13, 196);
            lab_stu_phno.Name = "lab_stu_phno";
            lab_stu_phno.Size = new Size(164, 20);
            lab_stu_phno.TabIndex = 15;
            lab_stu_phno.Text = "STUDENT PH.NO          :";
            // 
            // lab_f_phno
            // 
            lab_f_phno.AutoSize = true;
            lab_f_phno.Location = new Point(13, 157);
            lab_f_phno.Name = "lab_f_phno";
            lab_f_phno.Size = new Size(163, 20);
            lab_f_phno.TabIndex = 14;
            lab_f_phno.Text = "FATHER PH.NO             :";
            // 
            // lab_fname
            // 
            lab_fname.AutoSize = true;
            lab_fname.Location = new Point(13, 119);
            lab_fname.Name = "lab_fname";
            lab_fname.Size = new Size(165, 20);
            lab_fname.TabIndex = 13;
            lab_fname.Text = "FATHER NAME              :";
            // 
            // lab_mname
            // 
            lab_mname.AutoSize = true;
            lab_mname.Location = new Point(13, 77);
            lab_mname.Name = "lab_mname";
            lab_mname.Size = new Size(165, 20);
            lab_mname.TabIndex = 12;
            lab_mname.Text = "MOTHER NAME            :";
            // 
            // lab_gender
            // 
            lab_gender.AutoSize = true;
            lab_gender.Location = new Point(15, 31);
            lab_gender.Name = "lab_gender";
            lab_gender.Size = new Size(169, 20);
            lab_gender.TabIndex = 9;
            lab_gender.Text = "STUDENT GENDER        :";
            // 
            // btn_submit
            // 
            btn_submit.BackColor = SystemColors.ActiveCaption;
            btn_submit.Location = new Point(409, 576);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(94, 29);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "SUBMIT";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // form_stu_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(976, 783);
            Controls.Add(btn_submit);
            Controls.Add(g_box_per_act);
            Controls.Add(g_box_stu_act);
            Controls.Add(g_box_ac_info);
            Name = "form_stu_info";
            Text = "STUDENT INFORMATION";
            g_box_ac_info.ResumeLayout(false);
            g_box_ac_info.PerformLayout();
            g_box_stu_act.ResumeLayout(false);
            g_box_stu_act.PerformLayout();
            g_box_per_act.ResumeLayout(false);
            g_box_per_act.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox g_box_ac_info;
        private Label lab_stu_roll;
        private TextBox txt_stu_roll;
        private Label lab_stu_name;
        private TextBox txt_stu_name;
        private Label lab_c_year;
        private ComboBox combo_c_year;
        private Label lab_c_sem;
        private ComboBox combo_c_sem;
        private GroupBox g_box_stu_act;
        private Label lab_cgpa;
        private TextBox txt_cgpa;
        private Label lab_sac_clubs;
        private Label lab_backlogs;
        private ListBox l_box_sac_clubs;
        private TextBox txt_backlogs;
        private GroupBox g_box_per_act;
        private Label lab_f_phno;
        private Label lab_fname;
        private Label lab_mname;
        private Label lab_gender;
        private Label lab_stu_phno;
        private TextBox txt_stu_phno;
        private TextBox txt_f_phno;
        private TextBox txt_fname;
        private TextBox txt_mname;
        private Button btn_submit;
        private ComboBox combo_gender;
    }
}
