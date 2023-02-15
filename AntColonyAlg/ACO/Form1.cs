using System;
using System.Windows.Forms;
using AntColony.GraphNamespace;
using AntColony.AntClolnyAlgorithm;
using System.Collections.Generic;

namespace AntColony
{
    public partial class Form1 : Form
    {
        Graph localGraph;
        Params locaParams;
        bool crunch = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files |*.txt";
            dialog.InitialDirectory = @"C:\Users\User\source\repos\AntColonyAlg";
            dialog.Multiselect = false;
            dialog.Title = "Please, select a text file.";
            int dem;            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = dialog.FileName;
                try
                {
                    string[] s = System.IO.File.ReadAllText(sFileName).Split(' ', '\n');
                    if(int.TryParse(s[0], out dem))
                    {
                        if (dem <= 0)
                            throw new FormatException();
                        int[,] arr = new int[dem, dem];
                        List<Edge> BufEdges = new List<Edge>();
                        for (int i = 1; i < s.Length; i++)
                        {
                            arr[(i - 1) / dem, (i - 1) % dem] = int.Parse(s[i]);
                        }
                        for (int i = 0; i < dem; i++)
                            for (int j = 0; j < dem; j++)
                                if (i != j)
                                {
                                    if (arr[i, j] > 0)
                                        BufEdges.Add(new Edge(i, j, arr[i, j]));
                                    else
                                        BufEdges.Add(new Edge(i, j, int.MaxValue));
                                }
                        if (BufEdges == null)
                            throw new FormatException();
                        localGraph = new Graph(dem, BufEdges);
                        crunch = true;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка в записи графа.");
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Проблема чтения файла.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!crunch)
            {
                MessageBox.Show("Для начала работы выберите файл с описанием графа.");
                return;
            }
            try
            {
                int _Alpha = Convert.ToInt32(numericUpDownA.Value);
                int _Beta = Convert.ToInt32(numericUpDownB.Value);
                double _EvaporationRate = Convert.ToDouble(textBoxSpeed.Text);
                double _initialPheromone = Convert.ToDouble(textBoxPherStart.Text);
                int _AntCount = Convert.ToInt32(numericUpDownACount.Value);
                int _Iterations = Convert.ToInt32(numericUpDownICount.Value);
                if (localGraph == null)
                    throw new IndexOutOfRangeException();
                locaParams = new Params(_Alpha, _Beta, _EvaporationRate, _initialPheromone, _AntCount, _Iterations);
                Traveller traveller = new Traveller(locaParams, localGraph);
                List<Edge> edges = traveller.RunACS();

                listViewRes.Items.Clear();
                string[] row;
                ListViewItem liv;
                int lastEnd;
                if (edges[0].FinishVertex == edges[edges.Count - 1].StartVertex || edges[0].FinishVertex == edges[edges.Count - 1].FinishVertex) lastEnd = edges[0].FinishVertex;
                else lastEnd = edges[0].StartVertex;
                foreach (Edge edge in edges)
                {
                    if (lastEnd != edge.StartVertex)
                    {
                        int temp = edge.StartVertex;
                        edge.StartVertex = edge.FinishVertex;
                        edge.FinishVertex = temp;
                    }
                    lastEnd = edge.FinishVertex;
                    row = new string[] { edge.StartVertex.ToString(), edge.FinishVertex.ToString(), edge.Length.ToString() };
                    liv = new ListViewItem(row);
                    listViewRes.Items.Insert(listViewRes.Items.Count, liv);
                }
                labelRes.Text = traveller.FinalResult.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Проблема чтения параметров.");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Проблема чтения графа.");
            }
        }
    }
}
