using BeeSwarm.Algorithm;
using BeeSwarm.Individual;
using org.mariuszgromada.math.mxparser;

namespace BeeSwarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            Utils.ReInitializeFunction(textBox_inputFunction.Text);

            IBeeSwarm? beeSwarmAlgorithm;

            beeSwarmAlgorithm = new Algorithm.BeeSwarm(
                double.Parse(textBox_xRangeFrom.Text),
                double.Parse(textBox_xRangeTo.Text),
                double.Parse(textBox_yRangeFrom.Text),
                double.Parse(textBox_yRangeTo.Text),
                int.Parse(textBox_populationSize.Text),
                int.Parse(textBox_iterationCount.Text),
                int.Parse(textBox_pointsToCheckCount.Text),
                double.Parse(textBox_neighborhoodSize.Text)
            );

            var bestIndividual = beeSwarmAlgorithm.FindFunctionMinimum();

            textBox_bestX.Text = bestIndividual.Gens.Value.x.ToString();
            textBox_bestY.Text = bestIndividual.Gens.Value.y.ToString();
            textBox_bestFunc.Text = Utils.CalcFunc(
                        bestIndividual.Gens.Value.x,
                        bestIndividual.Gens.Value.y).ToString();
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(textBox_inputFunction.Text))
            {
                MessageBox.Show("���� � �������� �� ����� ���� ������");
                return false;
            }
            if (!double.TryParse(textBox_xRangeFrom.Text, out _))
            {
                MessageBox.Show("����������� ������� ������ ������� ������ �� X " +
                    "(��������� ����� � ������� *,*)");
                return false;
            }
            if (!double.TryParse(textBox_xRangeTo.Text, out _))
            {
                MessageBox.Show("����������� ������� ������� ������� ������ �� X " +
                    "(��������� ����� � ������� *,*)");
                return false;
            }
            if (double.TryParse(textBox_xRangeFrom.Text, out double xMin) 
                && double.TryParse(textBox_xRangeTo.Text, out double xMax)) {
                if (xMin > xMax)
                {
                    MessageBox.Show("������ ������� x ������ ���� " +
                        "������ ������� ������� x!");
                    return false;
                }
            }

            if (!double.TryParse(textBox_yRangeFrom.Text, out _))
            {
                MessageBox.Show("����������� ������� ������ ������� ������ �� Y " +
                    "(��������� ����� � ������� *,*)");
                return false;
            }
            if (!double.TryParse(textBox_yRangeTo.Text, out _))
            {
                MessageBox.Show("����������� ������� ������� ������� ������ �� Y " +
                    "(��������� ����� � ������� *,*)");
                return false;
            }
            if (double.TryParse(textBox_yRangeFrom.Text, out double yMin) 
                && double.TryParse(textBox_yRangeTo.Text, out double yMax)) {
                if (yMin > yMax)
                {
                    MessageBox.Show("������ ������� y ������ ���� " +
                        "������ ������� ������� y!");
                    return false;
                }
            }

            if (!int.TryParse(textBox_populationSize.Text, out _))
            {
                MessageBox.Show("����������� ������� ����������� ��������� " +
                    "(��������� ����� �����)");
                return false;
            }
            if (int.TryParse(textBox_populationSize.Text, out int res))
            {
                if (res < 3)
                {
                    MessageBox.Show("����������� ��������� ��������� ������ 3 " +
                        "(������� ����������� ��� ������ ��������� ������ " +
                        "������������ � ��������� ���������)");
                    return false;
                }
            }

            if (!int.TryParse(textBox_iterationCount.Text, out _))
            {
                MessageBox.Show("����������� ������� ����� ��������� " +
                    "(��������� ������������� �����)");
                return false;
            }

            if (int.TryParse(textBox_populationSize.Text, out int ps) 
                && int.TryParse(textBox_pointsToCheckCount.Text, out int ptcc))
            {
                if (ptcc > ps)
                {
                    MessageBox.Show("����� ����� ��� ������������ �� ����� ���� " +
                        "������ ����������� ���������.");
                    return false;
                }
            }

            if (!double.TryParse(textBox_neighborhoodSize.Text, out _))
            {
                MessageBox.Show("����������� ������ ������ ����������� " +
                    "(��������� ����� � ������� *,*)");
                return false;
            }

            return true;
        }
    }
}