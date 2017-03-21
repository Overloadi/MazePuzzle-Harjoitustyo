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
        public GamePage()
        {
            this.InitializeComponent();

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            int[,] matrix = new int[4, 4] { { 1, 0, 0, 0 },
                                            {1, 1, 0, 1},
                                            {0, 1, 0, 0},
                                            {1, 1, 1, 1}
            };
            Maze maze = new MazePuzzle.Maze(matrix);
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
