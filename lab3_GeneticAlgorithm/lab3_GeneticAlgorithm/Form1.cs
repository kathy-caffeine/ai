using System;
using System.IO;
using System.Windows.Forms;

namespace lab3_GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        Params parameters;
        GeneticAlg genAlg;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            bool flag = true;
            double popCh=0;
            double mutCh=0;
            try
            {
                popCh = Convert.ToDouble(textBoxPopChance.Text);
                mutCh = Convert.ToDouble(textBoxMutChance.Text);
                if (popCh <= 0 || popCh >= 1 || mutCh <= 0 || mutCh >= 1)
                    throw new IndexOutOfRangeException();
            }
            catch (Exception)
            {
                flag = false;
                MessageBox.Show("Не корректные данные шансов.");
            }
            if (flag) {
                parameters = new Params(popCh, mutCh, 
                    Convert.ToInt32(numericUpDownPopSize.Value), 
                    Convert.ToInt32(numericUpDownIterCount.Value), 
                    TextFunc.Lines[0], radioButton1.Checked);
                
                listViewRes.Items.Clear();
                string[] row;
                ListViewItem liv;

                genAlg = new GeneticAlg(parameters);
                genAlg.Run();
                String res = "";
                for (int i = 0; i < genAlg.bestIterations.Count; i++)
                {
                    row = new string[] { 
                        i.ToString(), 
                        genAlg.bestIterations[i].genes[0].ToString("0.##"), 
                        genAlg.bestIterations[i].genes[1].ToString("0.##"),
                        genAlg.bestIterations[i].functionAnswer.ToString("0.##")
                    };
                    liv = new ListViewItem(row);
                    listViewRes.Items.Insert(listViewRes.Items.Count,liv);
                    res += i.ToString() + " "
                                + genAlg.bestIterations[i].genes[0].ToString("0.##") + " "
                                + genAlg.bestIterations[i].genes[1].ToString("0.##") + " "
                                + genAlg.bestIterations[i].functionAnswer.ToString("0.##") + "\n";
                }
                System.IO.File.WriteAllText("C:/Users/User/source/repos/lab3_GeneticAlgorithm/1.txt", res);
                labelRes.Text = $"({genAlg.GetAnswer().genes[0].ToString("0.##")}; " +
                    $"{genAlg.GetAnswer().genes[1].ToString("0.##")})";
            }
        }
    }
}
