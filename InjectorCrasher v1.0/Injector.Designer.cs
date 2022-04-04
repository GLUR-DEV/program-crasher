namespace InjectorCrasher_v2._1
{
    partial class Injector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox01 = new System.Windows.Forms.ListBox();
            this.SelectionComboBox01 = new System.Windows.Forms.ComboBox();
            this.AddButton01 = new System.Windows.Forms.Button();
            this.KillButton01 = new System.Windows.Forms.Button();
            this.StartButton01 = new System.Windows.Forms.Button();
            this.StartButton02 = new System.Windows.Forms.Button();
            this.StopButton01 = new System.Windows.Forms.Button();
            this.CheckBox04 = new System.Windows.Forms.CheckBox();
            this.CheckBox03 = new System.Windows.Forms.CheckBox();
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.SubHeaderLabel01 = new System.Windows.Forms.Label();
            this.HeaderLabel01 = new System.Windows.Forms.Label();
            this.HeaderLabel02 = new System.Windows.Forms.Label();
            this.SubHeaderLabel02 = new System.Windows.Forms.Label();
            this.TopicLabel01 = new System.Windows.Forms.Label();
            this.TopicLabel03 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox01
            // 
            this.ListBox01.FormattingEnabled = true;
            this.ListBox01.ItemHeight = 15;
            this.ListBox01.Location = new System.Drawing.Point(19, 120);
            this.ListBox01.Name = "ListBox01";
            this.ListBox01.Size = new System.Drawing.Size(225, 349);
            this.ListBox01.TabIndex = 0;
            // 
            // SelectionComboBox01
            // 
            this.SelectionComboBox01.FormattingEnabled = true;
            this.SelectionComboBox01.Location = new System.Drawing.Point(22, 31);
            this.SelectionComboBox01.Name = "SelectionComboBox01";
            this.SelectionComboBox01.Size = new System.Drawing.Size(225, 23);
            this.SelectionComboBox01.TabIndex = 1;
            // 
            // AddButton01
            // 
            this.AddButton01.Location = new System.Drawing.Point(266, 31);
            this.AddButton01.Name = "AddButton01";
            this.AddButton01.Size = new System.Drawing.Size(75, 23);
            this.AddButton01.TabIndex = 3;
            this.AddButton01.Text = "Add";
            this.AddButton01.UseVisualStyleBackColor = true;
            this.AddButton01.Click += new System.EventHandler(this.AddButton01_Click);
            // 
            // KillButton01
            // 
            this.KillButton01.Location = new System.Drawing.Point(318, 211);
            this.KillButton01.Name = "KillButton01";
            this.KillButton01.Size = new System.Drawing.Size(75, 23);
            this.KillButton01.TabIndex = 5;
            this.KillButton01.Text = "Kill";
            this.KillButton01.UseVisualStyleBackColor = true;
            this.KillButton01.Click += new System.EventHandler(this.KillButton01_Click);
            // 
            // StartButton01
            // 
            this.StartButton01.Location = new System.Drawing.Point(318, 240);
            this.StartButton01.Name = "StartButton01";
            this.StartButton01.Size = new System.Drawing.Size(75, 23);
            this.StartButton01.TabIndex = 7;
            this.StartButton01.Text = "Start";
            this.StartButton01.UseVisualStyleBackColor = true;
            this.StartButton01.Click += new System.EventHandler(this.StartButton01_Click);
            // 
            // StartButton02
            // 
            this.StartButton02.Location = new System.Drawing.Point(316, 328);
            this.StartButton02.Name = "StartButton02";
            this.StartButton02.Size = new System.Drawing.Size(75, 23);
            this.StartButton02.TabIndex = 10;
            this.StartButton02.Text = "Start";
            this.StartButton02.UseVisualStyleBackColor = true;
            this.StartButton02.Click += new System.EventHandler(this.StartButton02_Click);
            // 
            // StopButton01
            // 
            this.StopButton01.Location = new System.Drawing.Point(316, 328);
            this.StopButton01.Name = "StopButton01";
            this.StopButton01.Size = new System.Drawing.Size(75, 23);
            this.StopButton01.TabIndex = 11;
            this.StopButton01.Text = "Stop";
            this.StopButton01.UseVisualStyleBackColor = true;
            this.StopButton01.Click += new System.EventHandler(this.StopButton01_Click);
            // 
            // CheckBox04
            // 
            this.CheckBox04.AutoSize = true;
            this.CheckBox04.Location = new System.Drawing.Point(311, 403);
            this.CheckBox04.Name = "CheckBox04";
            this.CheckBox04.Size = new System.Drawing.Size(151, 19);
            this.CheckBox04.TabIndex = 15;
            this.CheckBox04.Text = "Start Injector on Startup";
            this.CheckBox04.UseVisualStyleBackColor = true;
            // 
            // CheckBox03
            // 
            this.CheckBox03.AutoSize = true;
            this.CheckBox03.Location = new System.Drawing.Point(250, 403);
            this.CheckBox03.Name = "CheckBox03";
            this.CheckBox03.Size = new System.Drawing.Size(55, 19);
            this.CheckBox03.TabIndex = 16;
            this.CheckBox03.Text = "Panic";
            this.CheckBox03.UseVisualStyleBackColor = true;
            this.CheckBox03.CheckedChanged += new System.EventHandler(this.CheckBox03_CheckedChanged);
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.Location = new System.Drawing.Point(352, 31);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshListButton.TabIndex = 18;
            this.RefreshListButton.Text = "Refresh List";
            this.RefreshListButton.UseVisualStyleBackColor = true;
            this.RefreshListButton.Click += new System.EventHandler(this.RefreshListButton_Click);
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(266, 120);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveSelectedButton.TabIndex = 19;
            this.RemoveSelectedButton.Text = "Remove Selected";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // SubHeaderLabel01
            // 
            this.SubHeaderLabel01.AutoSize = true;
            this.SubHeaderLabel01.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubHeaderLabel01.Location = new System.Drawing.Point(300, 188);
            this.SubHeaderLabel01.Name = "SubHeaderLabel01";
            this.SubHeaderLabel01.Size = new System.Drawing.Size(108, 20);
            this.SubHeaderLabel01.TabIndex = 20;
            this.SubHeaderLabel01.Text = "Basic Controls";
            // 
            // HeaderLabel01
            // 
            this.HeaderLabel01.AutoSize = true;
            this.HeaderLabel01.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel01.Location = new System.Drawing.Point(22, 5);
            this.HeaderLabel01.Name = "HeaderLabel01";
            this.HeaderLabel01.Size = new System.Drawing.Size(101, 21);
            this.HeaderLabel01.TabIndex = 21;
            this.HeaderLabel01.Text = "Choose App";
            // 
            // HeaderLabel02
            // 
            this.HeaderLabel02.AutoSize = true;
            this.HeaderLabel02.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel02.Location = new System.Drawing.Point(19, 90);
            this.HeaderLabel02.Name = "HeaderLabel02";
            this.HeaderLabel02.Size = new System.Drawing.Size(124, 21);
            this.HeaderLabel02.TabIndex = 22;
            this.HeaderLabel02.Text = "Managed Apps";
            // 
            // SubHeaderLabel02
            // 
            this.SubHeaderLabel02.AutoSize = true;
            this.SubHeaderLabel02.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubHeaderLabel02.Location = new System.Drawing.Point(291, 280);
            this.SubHeaderLabel02.Name = "SubHeaderLabel02";
            this.SubHeaderLabel02.Size = new System.Drawing.Size(141, 20);
            this.SubHeaderLabel02.TabIndex = 23;
            this.SubHeaderLabel02.Text = "Advanced Controls";
            // 
            // TopicLabel01
            // 
            this.TopicLabel01.AutoSize = true;
            this.TopicLabel01.Location = new System.Drawing.Point(291, 306);
            this.TopicLabel01.Name = "TopicLabel01";
            this.TopicLabel01.Size = new System.Drawing.Size(62, 15);
            this.TopicLabel01.TabIndex = 24;
            this.TopicLabel01.Text = "Repeat Kill";
            // 
            // TopicLabel03
            // 
            this.TopicLabel03.AutoSize = true;
            this.TopicLabel03.Location = new System.Drawing.Point(292, 376);
            this.TopicLabel03.Name = "TopicLabel03";
            this.TopicLabel03.Size = new System.Drawing.Size(49, 15);
            this.TopicLabel03.TabIndex = 26;
            this.TopicLabel03.Text = "Settings";
            // 
            // Injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopicLabel03);
            this.Controls.Add(this.TopicLabel01);
            this.Controls.Add(this.SubHeaderLabel02);
            this.Controls.Add(this.HeaderLabel02);
            this.Controls.Add(this.HeaderLabel01);
            this.Controls.Add(this.SubHeaderLabel01);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.RefreshListButton);
            this.Controls.Add(this.CheckBox03);
            this.Controls.Add(this.CheckBox04);
            this.Controls.Add(this.StopButton01);
            this.Controls.Add(this.StartButton02);
            this.Controls.Add(this.StartButton01);
            this.Controls.Add(this.KillButton01);
            this.Controls.Add(this.AddButton01);
            this.Controls.Add(this.SelectionComboBox01);
            this.Controls.Add(this.ListBox01);
            this.Name = "Injector";
            this.Size = new System.Drawing.Size(467, 484);
            this.Load += new System.EventHandler(this.Injector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListBox01;
        private ComboBox SelectionComboBox01;
        private Button AddButton01;
        private Button KillButton01;
        private Button StartButton01;
        private Button StartButton02;
        private Button StopButton01;
        private CheckBox CheckBox04;
        private CheckBox CheckBox03;
        private Button RefreshListButton;
        private Button RemoveSelectedButton;
        private Label SubHeaderLabel01;
        private Label HeaderLabel01;
        private Label HeaderLabel02;
        private Label SubHeaderLabel02;
        private Label TopicLabel01;
        private Label TopicLabel03;
    }
}
