using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace InjectorCrasher_v2._1
{
    public partial class Injector : UserControl
    {
        bool isStarted = false;

        public Injector()
        {
            InitializeComponent();

            StartButton02.Show();
            StopButton01.Hide();
        }
        void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (CheckBox04.Checked)
                rk.SetValue("InjectorCrasher v2.1", Application.ExecutablePath);
            else
                rk.DeleteValue("InjectorCrasher v2.1", false);
        }
        void Panic()
        {
            Process[] proc = Process.GetProcessesByName("InjectorCrasher v1.0");

            foreach (Process myProcess in proc)
            {
                myProcess.Kill();
            }

        }
        void StopRepeatKill()
        {
            StartButton02.Show();
            StopButton01.Hide();
            isStarted = false;
        }
        void RepeatKill()
        {
            StartButton02.Hide();
            StopButton01.Show();
            isStarted = true;
            string selectedItem = (string)ListBox01.SelectedItem;
            if (selectedItem != null)
            {
                Task f = Task.Factory.StartNew(() =>
                {
                    while (isStarted == true)
                    {
                        Process[] proc = Process.GetProcessesByName(selectedItem);
                        foreach (Process myProcess in proc)
                        {
                            myProcess.Kill();
                        }
                        Thread.Sleep(100);
                    }
                });
            }
            else
            {
                MessageBox.Show("There is no managed process selected", "Error", 0);
                return;
            }
        }

        void GetAllProcesses()
        {
            SelectionComboBox01.Items.Clear();
            Process[] MyProcess = Process.GetProcesses();
            for (int i = 0; i < MyProcess.Length; i++)
            {
                SelectionComboBox01.Items.Add(MyProcess[i].ProcessName);
            }
        }
        void AddSelectedProcess()
        {
            string selectedItem = (string)SelectionComboBox01.SelectedItem;
            if (!ListBox01.Items.Contains(selectedItem))
            {
                if (selectedItem != null)
                {
                    ListBox01.Items.Add(selectedItem);
                }
                else
                {
                    MessageBox.Show("Please select a valid process", "Error", 0);
                    return;
                }
            }
            else
            {
                MessageBox.Show($"{selectedItem} is already added to your managed processes", "Error", 0);
                return;
            }
        }

        void KillSelectedProcess()
        {
            string selectedItem = (string)ListBox01.SelectedItem;
            Process[] proc = Process.GetProcessesByName(selectedItem);
            if (selectedItem != null)
            {
                foreach (Process myProcess in proc)
                {
                    myProcess.Kill();
                }
            }
            else
            {
                MessageBox.Show("There is no managed process selected", "Error", 0);
                return;
            }
        }
        void OpenProcess()
        {
            string selectedItem = (string)ListBox01.SelectedItem;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            if (selectedItem != null)
            {
                startInfo.FileName = selectedItem;
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("There is no managed process selected", "Error", 0);
                return;
            }
        }
        void RemoveProcess()
        {
            string selectedItem = (string)ListBox01.SelectedItem;
            if (selectedItem != null)
            {
                ListBox01.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("There is no managed process selected", "Error", 0);
                return;
            }
        }

        private void Injector_Load(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        private void AddButton01_Click(object sender, EventArgs e)
        {
            AddSelectedProcess();
        }

        private void KillButton01_Click(object sender, EventArgs e)
        {
            KillSelectedProcess();
        }

        private void StartButton01_Click(object sender, EventArgs e)
        {
            OpenProcess();
        }

        private void StartButton02_Click(object sender, EventArgs e)
        {
            RepeatKill();
        }

        private void StopButton01_Click(object sender, EventArgs e)
        {
            StopRepeatKill();
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            RemoveProcess();
        }

        private void CheckBox03_CheckedChanged(object sender, EventArgs e)
        {
            Panic();
        }
    }

}

