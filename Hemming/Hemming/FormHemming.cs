using System.Reflection;

namespace Hemming
{
    public partial class HemmingAlg : Form
    {
        Painter painterInput;
        Painter painterOutput;
        Painter known1;
        Painter known2;
        Painter known3;
        Painter known4;
        Painter known5;
        Painter known6;

        const int pictureBoxHeightInNeurons = 5;
        const int pictureBoxWidthInNeurons = 5;

        const int samplesAmount = 6;

        double epsilon = 0.16;

        public HemmingAlg()
        {
            InitializeComponent();
            labelMessage.Text = "";
            painterInput = new Painter(pictureBoxInput, pictureBoxHeightInNeurons, pictureBoxWidthInNeurons);
            painterOutput = new Painter(pictureBoxOutput, pictureBoxHeightInNeurons, pictureBoxWidthInNeurons);
            pictureBox1.Image = new Bitmap("../../../1.png");
            pictureBox2.Image = new Bitmap("../../../2.png");
            pictureBox3.Image = new Bitmap("../../../3.png");
            pictureBox4.Image = new Bitmap("../../../4.png");
            pictureBox5.Image = new Bitmap("../../../5.png");
            pictureBox6.Image = new Bitmap("../../../6.png");
            int[,] n1 = { { 1, 1, 1, 1, 1 }, { 1, -1, -1, -1, 1 }, { 1, -1, -1, -1, 1 }, { 1, -1, -1, -1, 1 }, { 1, -1, -1, -1, 1 } };
            known1 = new Painter(n1, pictureBox1);
            int[,] n2 = { { -1, -1, 1, -1, -1 }, { -1, 1, -1, 1, -1 }, { -1, 1, 1, 1, -1 }, { 1, -1, -1, -1, 1 }, { 1, -1, -1, -1, 1 } };
            known2 = new Painter(n2, pictureBox2);
            int[,] n3 = { { 1, 1, 1, 1, 1 }, { -1, -1, 1, -1, -1 }, { -1, -1, 1, -1, -1 }, { -1, -1, 1, -1, -1 }, { -1, -1, 1, -1, -1 } };
            known3 = new Painter(n3, pictureBox3);
            int[,] n4 = { { 1, 1, 1, -1, -1 }, { 1, -1, 1, -1, -1 }, { 1, 1, 1, -1, -1 }, { 1, -1, -1, -1, -1 }, { 1, -1, -1, -1, -1 } };
            known4 = new Painter(n4, pictureBox4);
            int[,] n5 = { { 1, -1, -1, -1, 1 }, { 1, -1, -1, 1, 1 }, { 1, -1, 1, -1, 1 }, { 1, 1, -1, -1, 1 }, { 1, -1, -1, -1, 1 } };
            known5 = new Painter(n5, pictureBox5);
            int[,] n6 = { { -1, 1, -1, -1, 1 }, { -1, 1, -1, 1, -1 }, { -1, 1, 1, -1, -1 }, { -1, 1, -1, 1, -1 }, { -1, 1, -1, -1, 1 } };
            known6 = new Painter(n6, pictureBox6);
        }

        private void buttonRecognize_Click(object sender, EventArgs e)
        {
            labelMessage.Text = "";
            painterOutput.clear();

            List<int[,]> samples = formSamplesList();

            Hemming hemmingNet = new Hemming(samplesAmount,
                pictureBoxHeightInNeurons * pictureBoxWidthInNeurons, samples, epsilon);

            List<int> results = hemmingNet.mainHemming(painterInput.grid);

            if (results.Count == 0)
                throw new Exception("Algorithm didn't find any decision");

            if (results.Count > 1)
            {
                labelMessage.Text = "there are several \n samples that match: \n" + (results[0] + 1);
                for (int i = 1; i < results.Count; i++)
                    labelMessage.Text += ", " + (results[i] + 1);
            }

            // demostrate first (and maybe the only one) of the found samples
            painterOutput.copy(samples[results[0]]);
        }

        private List<int[,]> formSamplesList()
        {
            List<int[,]> samples = new List<int[,]>() { known1.grid,
            known2.grid, known3.grid,
                known4.grid, known5.grid, known6.grid };

            return samples;
        }

        private void mouseChange(MouseEventArgs e, Painter painter)
        {
            int cellHeight = painter._PictureBox.Height / painter.grid.GetLength(0);
            int cellWidth = painter._PictureBox.Width / painter.grid.GetLength(1);

            var x = e.Location.X / cellWidth;
            var y = e.Location.Y / cellHeight;

            if (e.Button == MouseButtons.Left)
            {
                if (painter.CheckPoint(e.Location))
                    painter.changeCell(y, x, 1);
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (painter.CheckPoint(e.Location))
                    painter.changeCell(y, x, -1);
            }
        }

        private void buttonClearInput_Click(object sender, EventArgs e)
        {
            painterInput.clear();
        }

        private void pictureBoxInput_Click(object sender, EventArgs e)
        {
            mouseChange((MouseEventArgs)e, painterInput);
        }
    }
}