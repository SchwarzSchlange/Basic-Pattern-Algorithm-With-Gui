using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Doppeln
{
    public partial class mainForm : Form
    {

        public string current_directory = "";

        public mainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            statusBar.Text = $"Welcome to Doppeln 1.0";

            current_directory = Directory.GetCurrentDirectory() + @"\";

            LoadList();
          
            
        }

        public async void LoadList()
        {
            await Task.Run(() =>
            {
                DirectoryInfo d = new DirectoryInfo(current_directory);

                FileInfo[] Files = d.GetFiles("*.*", SearchOption.AllDirectories);


                foreach (FileInfo file in Files)
                {

                    if (file.Name.EndsWith(".jpg") || file.Name.EndsWith(".png"))
                    {
                        fileBox.Items.Add(file.Name+"+"+file.FullName);
                    }

                }
            });
        }

        private void selectPicButton_Click(object sender, EventArgs e)
        {
            if(fileBox.SelectedItem != null)
            {
                string[] slitped = fileBox.SelectedItem.ToString().Split('+');

         
                AddLog(slitped[1]);


                var x = Image.FromFile(slitped[1]);
                inputPicture.Image = x;

            }
            else
            {
                MessageBox.Show("Please select the file", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void AddLog(string x)
        {
            logBox.Items.Add(x);
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Image input_image = inputPicture.Image;
            
            if(input_image == null)
            {
                MessageBox.Show("Please select the file", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            int input_image_height = input_image.Height;
            int input_image_width = input_image.Width;

      

            if(malBox.Text != "")
            {
                try
                {
                    AddLog("Heigt = "+input_image_height.ToString());
                    AddLog("Width = "+input_image_width.ToString());
                    AddLog("Multipeler = "+malBox.Text);
                    AddLog("-----------------------------------------");
                    int mal = int.Parse(malBox.Text);


                    int new_h = input_image_height / mal;
                    int new_w = input_image_width / mal;

                    Graphics g = Graphics.FromImage(input_image);
                    Image resized_self = Engine.ResizeImage(input_image, new_w, new_h);





                    for (int x = 0; x <= mal; x++)
                    {
                        for (int y = 0; y <= mal; y++)
                        {
                            g.DrawImage(resized_self, new Point(x * new_w, y * new_h));
                        }

                    }

                    inputPicture.Image = input_image;
                    g.Dispose();

                }
                catch
                {
                    MessageBox.Show("An error occured please change file other settings", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
               
                
            }
            else
            {
                MessageBox.Show("Please select the multi box", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


       


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(inputPicture.Image != null)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Title = "Save To File";
               
                sf.RestoreDirectory = true;
                sf.Filter = "JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png |Jpeg Image (.jpeg)|*.jpeg";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    string path = sf.FileName;


                    inputPicture.Image.Save(path);


                    AddLog("Saved Successfully");
                }
                else
                {
                    AddLog("Can't save the picture into file!");
                }

                

            }
        }
    }
}
