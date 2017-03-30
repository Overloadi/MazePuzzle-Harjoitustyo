using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MazePuzzle
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        private List<BlockUC> blocks;
        private List<BlockUC2> blocks2;

        public object MyCanvas { get; private set; }

        public GamePage()
        {
            this.InitializeComponent();

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            blocks = new List<BlockUC>();
            blocks2 = new List<BlockUC2>();
            int[,] matrix10 = new int[10, 10] {
                {0, 0, 0, 3, 0, 0, 0, 0, 0, 0 },
                {0, 1, 0, 1, 0, 0, 0, 1, 1, 0 },
                {0, 1, 0, 1, 1, 1, 1, 1, 0, 0 },
                {0, 1, 0, 1, 0, 1, 0, 1, 0, 0 },
                {0, 1, 1, 1, 1, 1, 0, 1, 1, 4 },
                {0, 1, 0, 0, 0, 1, 0, 0, 1, 0 },
                {0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 1, 1, 1, 0 },
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                };

            var rowCount = matrix10.GetLength(0);
            var colCount = matrix10.GetLength(1);
            int sivusuunta = 0;
            int pystysuunta = 0;


            for (int row = 0; row < rowCount; row++)
            {
                
                for (int col = 0; col < colCount; col++)
                {
                    if(matrix10[row, col] == 0)
                    {
                        BlockUC block = new BlockUC();
                        block.LocationX = sivusuunta * (MazeCanvas.Width / 10);
                        //block.LocationX = MazeCanvas.Width/10 - MazeCanvas.Width / 10;
                        //block.LocationY = MazeCanvas.Height/10 - MazeCanvas.Height / 10;
                        block.LocationY = pystysuunta * (MazeCanvas.Height / 10);
                        MazeCanvas.Children.Add(block);
                        block.Setlocation();
                        blocks.Add(block);
                        sivusuunta++;
                        //block.LocationX = paska * (MazeCanvas.Width / 10 - MazeCanvas.Width / 10);
                    }
                    else if (matrix10[row, col] == 1 || matrix10[row, col] == 3 || matrix10[row, col] == 4)
                    {
                        BlockUC2 block2 = new BlockUC2();
                        block2.LocationX = sivusuunta * (MazeCanvas.Width / 10);
                        //block2.LocationX = MazeCanvas.Width / 10 - MazeCanvas.Width / 10;
                        //block2.LocationY = MazeCanvas.Height / 10 - MazeCanvas.Height / 10;
                        block2.LocationY = pystysuunta * (MazeCanvas.Height / 10);
                        MazeCanvas.Children.Add(block2);
                        block2.Setlocation();
                        blocks2.Add(block2);
                        sivusuunta++;
                        // block2.LocationX = paska * (MazeCanvas.Width / 10 - MazeCanvas.Width / 10);
                    }



                }
                pystysuunta++;
                sivusuunta = 0;

            }
         }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void HighscoresButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Highscore));
        }

        private void TutorialButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tutorial));
        }
    }
}
