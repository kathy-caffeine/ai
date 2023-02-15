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
                MessageBox.Show("Поле с функцией не может быть пустым");
                return false;
            }
            if (!double.TryParse(textBox_xRangeFrom.Text, out _))
            {
                MessageBox.Show("Некорректно введена нижняя граница поиска по X " +
                    "(ожидается число в формате *,*)");
                return false;
            }
            if (!double.TryParse(textBox_xRangeTo.Text, out _))
            {
                MessageBox.Show("Некорректно введена верхняя граница поиска по X " +
                    "(ожидается число в формате *,*)");
                return false;
            }
            if (double.TryParse(textBox_xRangeFrom.Text, out double xMin) 
                && double.TryParse(textBox_xRangeTo.Text, out double xMax)) {
                if (xMin > xMax)
                {
                    MessageBox.Show("Нижняя граница x должна быть " +
                        "меньше верхней границы x!");
                    return false;
                }
            }

            if (!double.TryParse(textBox_yRangeFrom.Text, out _))
            {
                MessageBox.Show("Некорректно введена нижняя граница поиска по Y " +
                    "(ожидается число в формате *,*)");
                return false;
            }
            if (!double.TryParse(textBox_yRangeTo.Text, out _))
            {
                MessageBox.Show("Некорректно введена верхняя граница поиска по Y " +
                    "(ожидается число в формате *,*)");
                return false;
            }
            if (double.TryParse(textBox_yRangeFrom.Text, out double yMin) 
                && double.TryParse(textBox_yRangeTo.Text, out double yMax)) {
                if (yMin > yMax)
                {
                    MessageBox.Show("Нижняя граница y должна быть " +
                        "меньше верхней границы y!");
                    return false;
                }
            }

            if (!int.TryParse(textBox_populationSize.Text, out _))
            {
                MessageBox.Show("Некорректно введена численность популяции " +
                    "(ожидается целое число)");
                return false;
            }
            if (int.TryParse(textBox_populationSize.Text, out int res))
            {
                if (res < 3)
                {
                    MessageBox.Show("Численность популяции ожидается больше 3 " +
                        "(условие необходимое для работы алгоритма отбора " +
                        "индивидуумов в следующее поколение)");
                    return false;
                }
            }

            if (!int.TryParse(textBox_iterationCount.Text, out _))
            {
                MessageBox.Show("Некорректно введено число поколений " +
                    "(ожидается целочисленное число)");
                return false;
            }

            if (int.TryParse(textBox_populationSize.Text, out int ps) 
                && int.TryParse(textBox_pointsToCheckCount.Text, out int ptcc))
            {
                if (ptcc > ps)
                {
                    MessageBox.Show("Число точек для исследования не может быть " +
                        "больше численности популяции.");
                    return false;
                }
            }

            if (!double.TryParse(textBox_neighborhoodSize.Text, out _))
            {
                MessageBox.Show("Некорректно введен размер окрестности " +
                    "(ожидается число в формате *,*)");
                return false;
            }

            return true;
        }
    }
}