using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace AnnealingSimulation
{
    public partial class Form1 : Form
    {
        Annealing annealing = new Annealing();
        public Form1()
        {
            InitializeComponent();
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files |*.txt";
            dialog.InitialDirectory = @"C:\Users\User\source\repos\AnnealingSimulation";
            dialog.Multiselect = false;
            dialog.Title = "Please, select a text file.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                annealing.FilePath = dialog.FileName;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл.");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            listViewRes.Items.Clear();
            annealing.reset();
            annealing.Anneal();
            if (annealing.crunch)
            {
                string[] item;
                ListViewItem listViewItem;
                labelRes.Text = Convert.ToString(annealing.ShortestDistance.ToString());
                for (int i = 0; i < annealing.CitiesOrder.Count - 1; i++)
                {
                    item = new string[]
                    {
                    annealing.CitiesOrder[i].ToString(),
                    annealing.CitiesOrder[i+1].ToString()
                    };
                    listViewItem = new ListViewItem(item);
                    listViewRes.Items.Insert(listViewRes.Items.Count, listViewItem);
                }
                item = new string[]
                    {
                    annealing.CitiesOrder[annealing.CitiesOrder.Count-1].ToString(),
                    annealing.CitiesOrder[0].ToString()
                    };
                listViewItem = new ListViewItem(item);
                listViewRes.Items.Insert(listViewRes.Items.Count, listViewItem);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            annealing.temperature = Convert.ToDouble(temp.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            annealing.absoluteTemperature = Convert.ToDouble(abs_temp.Text);
        }
    }
}