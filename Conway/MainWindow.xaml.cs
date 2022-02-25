using System;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Conway_Life
{
    public partial class MainWindow : Window
    {
        public int rows;
        public int columns;
        public int cellRow;
        public int cellColumn;
        public Random rand;
        public Rectangle[,] cellDisplay;
        public CellsBoard[,] cell;
        public Timer timer;

        public MainWindow() //change isenabled property to false for some buttons
        {
            timer = new Timer();
            InitializeComponent();
            startGame.IsEnabled = false;
            nextGeneration.IsEnabled = false;
            randomizeCells.IsEnabled = false;
            RestartButton.IsEnabled = false;
            timer.Elapsed += new ElapsedEventHandler(Time_Loop);
        }

        private void Grid_Slider(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rows = (int)gridSlider.Value;
            columns = (int)gridSlider.Value;
            resizeGrid.DataContext = gridSlider;
        }

        private void BuildGrid_Button(object sender, RoutedEventArgs e)
        {
            randomizeCells.IsEnabled = true;
            startGame.IsEnabled = false;
            nextGeneration.IsEnabled = false;
            timer.Stop();
            if (sender == BuildButton || RestartButton.Content.ToString() == "Clear")
            {
                RestartButton.IsEnabled = false;
                gameUniformGrid.Children.Clear();
                gameUniformGrid.Rows = rows;
                gameUniformGrid.Columns = columns;
                cell = new CellsBoard[rows, columns];
                cellDisplay = new Rectangle[rows, columns];
                rand = new Random();
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < columns; y++)
                    {
                        cell[x, y] = new CellsBoard { IsAlive = false };
                        cellDisplay[x, y] = new Rectangle { Stroke = Brushes.Black, StrokeThickness = 0.25 };

                        Binding b = new Binding("IsAlive") //binding path
                        {
                            Source = cell[x, y], //tbspecified
                            Converter = cell[x, y] //changes cell color based on IsAlive condition
                        };

                        cellDisplay[x, y].SetBinding(Rectangle.FillProperty, b);
                        cellDisplay[x, y].SetValue(Grid.RowProperty, x);
                        cellDisplay[x, y].SetValue(Grid.ColumnProperty, y);
                        gameUniformGrid.Children.Add(cellDisplay[x, y]);
                    }
                }
            }
            else if (sender == RestartButton)
            {
                RestartButton.Content = "Clear";
            }
        }

        private void ToggleGrid(object sender, MouseButtonEventArgs e)
        {
            RestartButton.IsEnabled = true;
            startGame.IsEnabled = true;
            if (e.OriginalSource is Shape s)
            {
                cellRow = (int)s.GetValue(Grid.RowProperty);
                cellColumn = (int)s.GetValue(Grid.ColumnProperty);

                cell[cellRow, cellColumn].IsAlive = !cell[cellRow, cellColumn].IsAlive;
            }
        }

        private void RandomizeCells_Button(object sender, RoutedEventArgs e)
        {
            RestartButton.IsEnabled = true;
            startGame.IsEnabled = true;
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int binaryToggle = rand.Next(2);
                    if (binaryToggle == 0)
                    {
                        cell[x, y].IsAlive = true;
                    }
                    else
                    {
                        cell[x, y].IsAlive = false;
                    }
                }
            }
        }

        private void StartGame_Button(object sender, RoutedEventArgs e)
        {
            RestartButton.Content = "Stop";
            if (startGame.Content.ToString() == "Start")
            {
                timer.Start();
                nextGeneration.IsEnabled = false;
                startGame.Content = "Pause";
                randomizeCells.IsEnabled = false;
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < columns; y++)
                    {
                        //compares to GetLength when (+) and 0 when (-)
                        //using GetLength as opposed to length for multi-d arrays (0 = x, 1 = y)
                        //checks neighbor's up
                        if (x - 1 >= 0)
                        {
                            cell[x, y].Neighbors.Add(cell[x - 1, y]);
                        }
                        //checks neighbor's down
                        if (x + 1 < cell.GetLength(0))
                        {
                            cell[x, y].Neighbors.Add(cell[x + 1, y]);
                        }
                        //checks neighbor's left
                        if (y - 1 >= 0)
                        {
                            cell[x, y].Neighbors.Add(cell[x, y - 1]);
                        }
                        //checks neighbor's right
                        if (y + 1 < cell.GetLength(1))
                        {
                            cell[x, y].Neighbors.Add(cell[x, y + 1]);
                        }
                        //checks neighbor's across up left
                        if ((x - 1 >= 0) && (y - 1 >= 0))
                        {
                            cell[x, y].Neighbors.Add(cell[x - 1, y - 1]);
                        }
                        //checks neighbor's across up right
                        if ((x - 1 >= 0) && (y + 1 < cell.GetLength(1)))
                        {
                            cell[x, y].Neighbors.Add(cell[x - 1, y + 1]);
                        }
                        //checks neighbor's across down left
                        if ((x + 1 < cell.GetLength(0)) && (y - 1 >= 0))
                        {
                            cell[x, y].Neighbors.Add(cell[x + 1, y - 1]);
                        }
                        //checks neighbor's across down right
                        if ((x + 1 < cell.GetLength(0)) && (y + 1 < cell.GetLength(1)))
                        {
                            cell[x, y].Neighbors.Add(cell[x + 1, y + 1]);
                        }
                    }
                }
            }
            else if (startGame.Content.ToString() == "Pause")
            {
                timer.Stop();
                nextGeneration.IsEnabled = true;
                startGame.Content = "Start";
            }
        }

        private void CheckCellStatus()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    {
                        int liveNeighborCount = cell[x, y].LiveNeighborCount;
                        if (cell[x, y].IsAlive)
                        {
                            if (liveNeighborCount < 2)
                            {
                                cell[x, y].CheckIfAlive = false;
                            }
                            else if (liveNeighborCount > 3)
                            {
                                cell[x, y].CheckIfAlive = false;
                            }
                            else if (liveNeighborCount == 2 || liveNeighborCount == 3)
                            {
                                cell[x, y].CheckIfAlive = true;
                            }
                        }
                        else
                        {
                            if (liveNeighborCount == 3)
                            {
                                cell[x, y].CheckIfAlive = true;
                            }
                        }
                    }
                }
            }
        }

        private void UpdateCells()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    if (cell[x, y].CheckIfAlive)
                    {
                        cell[x, y].IsAlive = true;
                    }
                    else
                    {
                        cell[x, y].IsAlive = false;
                    }
                }
            }
        }

        private void NextGeneration_Button(object sender, RoutedEventArgs e)
        {
            CheckCellStatus();
            UpdateCells();
        }

        private void Time_Loop(object sender, EventArgs e)
        {
            CheckCellStatus();
            UpdateCells();
        }

        private void Speed_Slider(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            timer.Interval = 1000 / speedSlider.Value;
            generationSpeed.DataContext = speedSlider;
        }

        private static string _brushColour;
        private void ColourCells(object sender, RoutedEventArgs e)
        {
            if (sender == BlackCells)
            {
                _brushColour = "Black";
            }
            if (sender == RedCells)
            {
                _brushColour = "Red";
            }
            if (sender == YellowCells)
            {
                _brushColour = "Yellow";
            }
            if (sender == GreenCells)
            {
                _brushColour = "Green";
            }
        }
        public static string BrushColour
        {
            get { return _brushColour; }
        }
    }
}