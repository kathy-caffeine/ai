using Genetic_algorithm.Abstractions;
using Genetic_algorithm.Algorithm;
using org.mariuszgromada.math.mxparser;

namespace Genetic_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (!IsCorrectInput()) return;

            Utils.ReInitializeFunction(textBox_inputFunction.Text);

            IGeneticAlgorithm? geneticAlgorithm;

            if (!radioButton_isBinaryEncodingMode.Checked)
                geneticAlgorithm = new DecimalGenetic(
                double.Parse(xMin.Text),
                double.Parse(xMax.Text),
                double.Parse(yMin.Text),
                double.Parse(yMax.Text),
                int.Parse(textBox_populationSize.Text),
                int.Parse(textBox_mutationP.Text),
                int.Parse(textBox_iterationAmount.Text));
            else geneticAlgorithm = new BinaryGenetic(
                double.Parse(xMin.Text),
                double.Parse(xMax.Text),
                double.Parse(yMin.Text),
                double.Parse(yMax.Text),
                int.Parse(textBox_populationSize.Text),
                int.Parse(textBox_mutationP.Text),
                int.Parse(textBox_iterationAmount.Text));

            var bestIndividual = geneticAlgorithm.FindFunctionMinimum();

            if(bestIndividual.Gens.Value.x< double.Parse(xMin.Text))
            {
                textBox_bestX.Text = xMin.Text;
            }
            else if(bestIndividual.Gens.Value.x> double.Parse(xMax.Text)){
                textBox_bestX.Text = xMax.Text;
            }
            else
            {
                textBox_bestX.Text = bestIndividual.Gens.Value.x.ToString();
            }

            if(bestIndividual.Gens.Value.y < double.Parse(yMin.Text))
            {
                textBox_bestY.Text = yMin.Text;
            }
            else if(bestIndividual.Gens.Value.y > double.Parse(yMax.Text))
            {
                textBox_bestY.Text = yMax.Text;
            }
            else
            {
                textBox_bestY.Text = bestIndividual.Gens.Value.y.ToString();
            }
            textBox_bestFunc.Text = Utils.CalcFunc(
                        bestIndividual.Gens.Value.x,
                        bestIndividual.Gens.Value.y).ToString();
        }

        private bool IsCorrectInput()
        {
            if (string.IsNullOrEmpty(textBox_inputFunction.Text))
            {
                MessageBox.Show("���� � �������� �� ����� ���� ������");
                return false;
            }
            if (!double.TryParse(xMin.Text, out _))
            {
                MessageBox.Show("����������� ������� ������ ������� ������ �� X (��������� �����)");
                return false;
            }
            if (!double.TryParse(xMax.Text, out _))
            {
                MessageBox.Show("����������� ������� ������� ������� ������ �� X (��������� �����)");
                return false;
            }

            if (!double.TryParse(yMin.Text, out _))
            {
                MessageBox.Show("����������� ������� ������ ������� ������ �� Y (��������� �����)");
                return false;
            }
            if (!double.TryParse(yMax.Text, out _))
            {
                MessageBox.Show("����������� ������� ������� ������� ������ �� Y (��������� �����)");
                return false;
            }

            if (!int.TryParse(textBox_populationSize.Text, out _))
            {
                MessageBox.Show("����������� ������� ����������� ��������� (��������� ����� �����)");
                return false;
            }
            if (int.TryParse(textBox_populationSize.Text, out int res))
            {
                if (res < 3)
                {
                    MessageBox.Show("����������� ��������� ��������� ������ 3");
                    return false;
                }
            }
            if (!int.TryParse(textBox_mutationP.Text, out int mutationChance))
            {
                MessageBox.Show("����������� ������� ����������� ������� (��������� ����� �����)");
                return false;

            }

            if (mutationChance < 0)
            {
                MessageBox.Show("����������� ������� ������ ���� ������������� ������");
                return false;

            }
            if (mutationChance > 101)
            {
                MessageBox.Show("����������� ������� ������ ���� ������, ���� ����� 100");
                return false;

            }

            if (!int.TryParse(textBox_iterationAmount.Text, out _))
            {
                MessageBox.Show("����������� ������� ����� ��������� (��������� ����� �����)");
                return false;
            }

            return true;
        }
    }
}