namespace Hemming
{
    internal class Painter
    {
        Graphics _Graphics;
        public int[,] grid { get; private set; }
        public PictureBox _PictureBox { get; private set; }

        public Painter( PictureBox pictureBox,
            int pictureBoxHeightInNeurons, int pictureBoxWidthInNeurons)
        {
            grid = new int[pictureBoxHeightInNeurons, pictureBoxWidthInNeurons];
            _PictureBox = pictureBox;

            _PictureBox.Image = new Bitmap(_PictureBox.Width, _PictureBox.Height);
            _Graphics = Graphics.FromImage(_PictureBox.Image);
            grid = new int[pictureBoxHeightInNeurons, pictureBoxWidthInNeurons];

            clear();
        }

        public Painter(int[,] input, PictureBox pictureBox)
        {
            this.grid = input;
            this._PictureBox = pictureBox;
            this._Graphics = Graphics.FromImage(_PictureBox.Image);
        }

        public void changeCell(int x, int y, int value)
        {
            grid[x, y] = value;
            paint();
        }

        public void clear()
        {
            _Graphics.FillRectangle(Brushes.White, 0, 0, _PictureBox.Width, _PictureBox.Height);

            for (int i = 0; i < grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                    grid[i, j] = -1;

            _PictureBox.Refresh();
        }

        public void paint()
        {
            int cellWidth = _PictureBox.Width / grid.GetLength(0);
            int cellHeight = _PictureBox.Height / grid.GetLength(1);

            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    if (grid[y, x] == 1)
                        _Graphics.FillRectangle(Brushes.Black, x * cellWidth, y * cellHeight,
                            cellWidth, cellHeight);
                    else
                        _Graphics.FillRectangle(Brushes.White, x * cellWidth, y * cellHeight,
                            cellWidth, cellHeight);
                }
            }
            _PictureBox.Refresh();
        }

        public bool CheckPoint(Point point)
        {
            if (point.X < _PictureBox.Width && point.Y < _PictureBox.Height
                && point.X > 0 && point.Y > 0)
                return true;
            return false;
        }

        public void copy(int[,] cellMatrix)
        {
            grid = (int[,])cellMatrix.Clone();
            paint();
        }
    }
}
