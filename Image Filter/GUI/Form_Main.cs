using System;
using System.IO;
using System.Windows.Forms;

namespace ImageFilter
{
    public partial class Form_Main : Form
    {
        public enum Status { Initial, Loaded, Processing, Done }
        public int AppliedFiltersCount { get; set; }

        public Form_Main()
        {
            InitializeComponent();
            SetStatus(Status.Initial);
        }

        public void SetStatus(Status status)
        {
            switch (status)
            {
                case Status.Initial:
                    PopulateFiltersList();
                    button_processing.Visible = false;
                    button_apply.Enabled = false;
                    button_save.Enabled = false;
                    button_reset.Enabled = false;
                    listBox_filters.Enabled = false;
                    break;
                case Status.Loaded:
                    IncrementAppliedFiltersCount(reset: true);
                    button_apply.Enabled = true;
                    button_save.Enabled = false;
                    button_reset.Enabled = false;
                    listBox_filters.Enabled = true;
                    break;
                case Status.Processing:
                    panel_main.Enabled = false;
                    button_processing.Visible = true;
                    break;
                case Status.Done:
                    IncrementAppliedFiltersCount();
                    panel_main.Enabled = true;
                    button_processing.Visible = false;
                    button_apply.Enabled = true;
                    button_save.Enabled = true;
                    button_reset.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        public void PopulateFiltersList()
        {
            listBox_filters.DataSource = Enum.GetNames(typeof(ImageFilter));
        }

        public void IncrementAppliedFiltersCount(bool reset = false)
        {
            if (reset)
            {
                AppliedFiltersCount = 0;
            }
            else
            {
                AppliedFiltersCount++;
            }
            button_appliedFilters.Text = string.Format("  {0}  Applied Filters", AppliedFiltersCount);
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox_photo.Load(openFileDialog.FileName);
                    textBox_filePath.Text = openFileDialog.FileName;
                    SetStatus(Status.Loaded);
                }
                catch
                {
                    MessageBox.Show(string.Format("Couldn't load the file: {0}", textBox_filePath.Text),
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            pictureBox_photo.Load(textBox_filePath.Text);
            SetStatus(Status.Loaded);
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            SetStatus(Status.Processing);
            backgroundWorker.RunWorkerAsync(listBox_filters.SelectedIndex);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                ImageFilter filter = (ImageFilter)e.Argument;
                pictureBox_photo.Image = pictureBox_photo.Image.ApplyFilter(filter);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            SetStatus(Status.Done);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
            saveFileDialog.FileName = string.Format("{0}_filtered", fileName);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_photo.Image.Save(saveFileDialog.FileName);
            }
        }

        private void pictureBox_photo_DoubleClick(object sender, EventArgs e)
        {
            button_openFile.PerformClick();
        }

        private void listBox_filters_DoubleClick(object sender, EventArgs e)
        {
            button_apply.PerformClick();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog(this);
        }
    }
}
