using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_Meneceri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtYol.ReadOnly = true;
            lblStatus.Text = "Ready | File count: 0";
        }
        int n = 0;
        private void btnQovluq_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Create file . | .";
            sv.FileName = "document" + n;

            if (sv.ShowDialog() == DialogResult.OK)
            {
                File.Create(sv.FileName).Close();
                n++;

                txtYol.Text = sv.FileName;
                lstFayllar.Items.Add(Path.GetFileName(sv.FileName));
                statusStrip1.Text = "Fayl count: " + lstFayllar.Items.Count;
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "write file *.txt | *.txt";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sv.FileName))
                {
                    MessageBox.Show("No document selected", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    File.AppendAllText(sv.FileName, txtMetn.Text);

                    FileInfo fi = new FileInfo(sv.FileName);
                    double olcuKB = Math.Round((double)fi.Length / 1024, 1);
                    lblMelumat.Text = "Name: " + fi.Name + " | Size: " + olcuKB + " KB";
                }
            }
        }

        private void btnSaxla_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "write file *.txt | *.txt";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sv.FileName))
                {
                    MessageBox.Show("No document selected", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtMetn.Text = File.ReadAllText(sv.FileName);
                    txtYol.Text = sv.FileName;

                    FileInfo fi = new FileInfo(sv.FileName);
                    double olcuKB = Math.Round((double)fi.Length / 1024, 1);
                    lblMelumat.Text = "Name: " + fi.Name + " | Size: " + olcuKB + " KB | Date: " + fi.CreationTime.ToString("dd.MM.yyyy");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "write file *.txt | *.txt";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sv.FileName))
                {
                    MessageBox.Show("No document selected", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DialogResult d = MessageBox.Show("Do you want to delete the file?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        File.Delete(sv.FileName);
                        txtMetn.Text = sv.FileName + " - file deleted";
                        lblMelumat.Text = "İnformation";
                        txtYol.Clear();

                        string faylAdi = Path.GetFileName(sv.FileName);
                        if (lstFayllar.Items.Contains(faylAdi))
                        {
                            lstFayllar.Items.Remove(faylAdi);
                        }
                        statusStrip1.Text = "Fayl count " + lstFayllar.Items.Count;
                    }
                }
            }
        }
    }
}



