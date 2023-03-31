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

namespace RaZem_Photo
{
    public partial class Form1 : Form
    {
        string[] Files = null;
        string[] back_files = null;
        public Form1()
        {
            InitializeComponent();

            SD_Card_RB.Checked = true;
            Counter_INPOUT_LB.Text = 0.ToString();
            COUNTER_OUTPUT_LB.Text = 0.ToString();

            timer1.Start();

        }

        private void SD_CARD_SEARCH_BT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                SD_CARD_TX.Clear();
                SD_CARD_TX.Text = folderBrowser.SelectedPath;
            }
        }

        private void Camera_Search_BT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                CAMERA_TX.Clear();
                CAMERA_TX.Text = folderBrowser.SelectedPath;
            }
        }

        private void Load_BTN_Click(object sender, EventArgs e)
        {

            int counter_files = 0;

            if(SD_Card_RB.Checked == true)
            {
                SD_CARD_LX.Items.Clear();
                if(SD_CARD_TX.TextLength <= 0)
                {
                    MessageBox.Show("Zadejte cestu k SD kartě");
                    return;
                }

                try
                {
                    Files = Directory.GetFiles(SD_CARD_TX.Text);
                    if (Files.Length <= 0)
                    {
                        SD_CARD_LX.Items.Clear();
                        return;
                    }

                    SD_CARD_LX.Items.Clear();
                    foreach (string File in Files)
                    {
                        SD_CARD_LX.Items.Add(Path.GetFileName(File));
                        counter_files++;
                    }

                    Counter_INPOUT_LB.Text = counter_files.ToString();
                    button2.Enabled = true;
                    button3.Enabled = true;
                } catch{
                    button2.Enabled = false;
                    button3.Enabled = false;
                    return;
                }
                

            } else if(Camera_RB.Checked == true)
            {
                if (CAMERA_TX.TextLength <= 0)
                {
                    MessageBox.Show("Zadejte cestu k foťáku kartě");
                    return;
                }

                CAMERA_LX.Items.Clear();
                try {

                    Files = Directory.GetFiles(CAMERA_TX.Text);
                    if (Files.Length <= 0)
                    {
                        CAMERA_LX.Items.Clear();
                        return;
                    }

                    foreach (string File in Files)
                    {
                        CAMERA_LX.Items.Add(Path.GetFileName(File));
                        counter_files++;
                    }

                    Counter_INPOUT_LB.Text = counter_files.ToString();
                    button2.Enabled = true;
                    button3.Enabled = true;
                } catch {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    return;
                }
                

            }

        }

        private void DESTINATION_SEARCH_BT_Click(object sender, EventArgs e)
        {
            OUTPUT_LX.Items.Clear();
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                DESTINATION_TX.Clear();
                DESTINATION_TX.Text = folderBrowser.SelectedPath;

                string[] directories = Directory.GetDirectories(DESTINATION_TX.Text);

                foreach(string directory in directories)
                {
                    OUTPUT_LX.Items.Add(Path.GetFileName(directory));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(OUTPUT_LX.SelectedItem == null)
            {
                return;
            }
            int counter_files = 0;
            if (Files == null)
            {
                return;
            }
            COUNTER_OUTPUT_LB.Text = "Kopiruji";
            
            int progress = 0;
            int step = 100 / Files.Count();
            foreach (string s in Files)
            {
                // Use static Path methods to extract only the file name from the path.
                string fileName = Path.GetFileName(s);
                string destFile = Path.Combine(DESTINATION_TX.Text + "\\" + OUTPUT_LX.SelectedItem.ToString(), fileName);
                File.Copy(s, destFile, true);
                FileInfo file = new FileInfo(s);
                file.Delete();
                counter_files++;
                progress = progress + step;
                progressBar1.Value = progress;
            }

            if(Convert.ToInt32(Counter_INPOUT_LB.Text) == counter_files)
            {
                COUNTER_OUTPUT_LB.Text = "OK";
            }

            back_files = Files;


            Files = null;

            if(SD_Card_RB.Checked == true)
            {
                SD_CARD_LX.Items.Clear();
            } else if(Camera_RB.Checked == true)
            {
                CAMERA_LX.Items.Clear();
            }

            Counter_INPOUT_LB.Text = 0.ToString();
            if(UP_CB.Checked == true)
            {
                int index = OUTPUT_LX.SelectedIndex;
                OUTPUT_LX.SetSelected(index + 1, true);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UP_CB.Checked == true)
            {
                int index = OUTPUT_LX.SelectedIndex;
                OUTPUT_LX.SetSelected(index - 1, true);
            }
            int counter_files = 0;
            Counter_INPOUT_LB.Text = "Vracím";
            foreach (string s in back_files)
            {
                string fileName = Path.GetFileName(s);
                if(SD_Card_RB.Checked == true)
                {
                    string source = Path.Combine(DESTINATION_TX.Text + "\\" + OUTPUT_LX.SelectedItem.ToString(), fileName);
                    string destination = Path.Combine(SD_CARD_TX.Text, fileName);
                    File.Copy(source, destination, true);
                    FileInfo file = new FileInfo(source);
                    file.Delete();


                } else if(Camera_RB.Checked == true)
                {
                    string source = Path.Combine(DESTINATION_TX.Text + "\\" + OUTPUT_LX.SelectedItem.ToString(), fileName);
                    string destination = Path.Combine(CAMERA_TX.Text, fileName);
                    File.Copy(source, destination, true);
                    FileInfo file = new FileInfo(source);
                    file.Delete();
                }
                counter_files++;
                Counter_INPOUT_LB.Text = counter_files.ToString();
            }
            Counter_INPOUT_LB.Text = "OK";
            COUNTER_OUTPUT_LB.Text = 0.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(Load_BTN.Enabled == true)
            {
                if (TIMES_CB.Checked == true)
                {
                    Load_BTN_Click(sender, e);
                }
            }
            
        }
    }
}
