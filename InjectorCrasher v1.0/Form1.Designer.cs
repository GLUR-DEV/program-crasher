namespace InjectorCrasher_v2._1
{
    partial class InjectorCrasher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InjectorCrasher));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SupportButton = new System.Windows.Forms.Button();
            this.InjectorButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.support1 = new InjectorCrasher_v2._1.Support();
            this.injector1 = new InjectorCrasher_v2._1.Injector();
            this.NotifyIcon01 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.SupportButton);
            this.MenuPanel.Controls.Add(this.InjectorButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(467, 25);
            this.MenuPanel.TabIndex = 0;
            // 
            // SupportButton
            // 
            this.SupportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SupportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupportButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SupportButton.Location = new System.Drawing.Point(81, 2);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(75, 23);
            this.SupportButton.TabIndex = 1;
            this.SupportButton.Text = "Support";
            this.SupportButton.UseVisualStyleBackColor = false;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // InjectorButton
            // 
            this.InjectorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InjectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectorButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InjectorButton.Location = new System.Drawing.Point(3, 2);
            this.InjectorButton.Name = "InjectorButton";
            this.InjectorButton.Size = new System.Drawing.Size(75, 23);
            this.InjectorButton.TabIndex = 0;
            this.InjectorButton.Text = "Injector";
            this.InjectorButton.UseVisualStyleBackColor = false;
            this.InjectorButton.Click += new System.EventHandler(this.InjectorButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(0, 4);
            this.listBox1.TabIndex = 1;
            // 
            // support1
            // 
            this.support1.Location = new System.Drawing.Point(0, 31);
            this.support1.Name = "support1";
            this.support1.Size = new System.Drawing.Size(467, 484);
            this.support1.TabIndex = 2;
            // 
            // injector1
            // 
            this.injector1.Location = new System.Drawing.Point(0, 31);
            this.injector1.Name = "injector1";
            this.injector1.Size = new System.Drawing.Size(467, 484);
            this.injector1.TabIndex = 3;
            this.injector1.Load += new System.EventHandler(this.injector1_Load);
            // 
            // NotifyIcon01
            // 
            this.NotifyIcon01.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon01.BalloonTipText = "Make sure to check out my github";
            this.NotifyIcon01.BalloonTipTitle = "InjectorCrasher v2.1";
            this.NotifyIcon01.Text = "InjectorCrasher v2.1";
            this.NotifyIcon01.Visible = true;
            // 
            // InjectorCrasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 531);
            this.Controls.Add(this.injector1);
            this.Controls.Add(this.support1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InjectorCrasher";
            this.Text = "InjectorCrasher v1.0";
            this.Load += new System.EventHandler(this.InjectorCrasher_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Button SupportButton;
        private Button InjectorButton;
        private ListBox listBox1;
        private Support support1;
        private Injector injector1;
        private NotifyIcon NotifyIcon01;
    }
}