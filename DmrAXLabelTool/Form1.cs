using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DmrAXLabelTool
{
    public partial class Form1 : Form
    {
        string text;
        string file;
        string txtName;
        string[] txtArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileManager_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "TXT files|*.txt";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
                try
                {
                    text = File.ReadAllText(file);
                    fileName.Text = file;
                    txtArray = file.Split('\\');
                    txtName = txtArray[txtArray.Length - 1];    
                    labelEditor.Text = text;

                    removeDuplicate.Enabled = true;
                    sort.Enabled = true;
                    sortAndRemove.Enabled = true;
                    save.Enabled = true;
                    SaveAndOverWrite.Enabled = true;

                }
                catch (IOException)
                {
                }
            }
        }

        private void removeDuplicate_Click(object sender, EventArgs e)
        {
            string newText;
            LabelProcess process = new LabelProcess(labelEditor.Text);
            newText = process.removeDuplicate();
            labelEditor.Text = newText;
            string message = "Removed " + (process.changeLabelCount) + " labels!";
            MessageBox.Show(message, "",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sort_Click(object sender, EventArgs e)
        {
            string newText;
            LabelProcess process = new LabelProcess(labelEditor.Text);
            newText = process.sortString();
            labelEditor.Text = newText;
            
        }

        private void sortAndRemove_Click(object sender, EventArgs e)
        {
            string newText;
            LabelProcess process = new LabelProcess(labelEditor.Text);
            newText = process.sortAndRemoveDuplicate();
            labelEditor.Text = newText;
            string message = "Removed and sorted " + (process.changeLabelCount) + " labels!";
            MessageBox.Show(message, "",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                string folder = openFileDialog1.SelectedPath;
                file = openFileDialog1.SelectedPath;
                file = file + "\\" + txtName;
                if (file == fileName.Text)
                {
                    DialogResult resultYesNo =  MessageBox.Show("It will be overwritten, do you agree?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(resultYesNo == DialogResult.No)
                    {
                        
                    }
                    else
                    {
                        try
                        {

                            StreamWriter sw = new StreamWriter(file);
                            sw.WriteLine(labelEditor.Text);

                            sw.Close();
                            Process.Start(folder);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Exception" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            DialogResult resultOk = MessageBox.Show("Save is sucessful !", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (resultOk == DialogResult.OK)
                            {
                                Process.Start(folder);
                            }
                        }

                    }


                }
                else
                {
                    try
                    {

                        StreamWriter sw = new StreamWriter(file);
                        sw.WriteLine(labelEditor.Text);

                        sw.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        DialogResult resultOk = MessageBox.Show("Save is sucessful !", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (resultOk == DialogResult.OK)
                        {
                            Process.Start(folder);
                        }

                    }
                }
               

            }
        }

        private void SaveAndOverWrite_Click(object sender, EventArgs e)
        {
            DialogResult resultYesNo = MessageBox.Show("It will be overwritten, do you agree?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultYesNo == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    file = fileName.Text;
                    StreamWriter sw = new StreamWriter(file);
                    sw.WriteLine(labelEditor.Text);

                    sw.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    DialogResult resultOk = MessageBox.Show("Save is sucessful !", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (resultOk == DialogResult.OK)
                    {
                        Process.Start(file);
                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
