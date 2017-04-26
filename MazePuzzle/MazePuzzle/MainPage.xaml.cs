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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MazePuzzle
{
    /// <summary>
    /// Main page, where user can choose to go to the game page, view the tutorial page or view the highscore page
    /// </summary>
    public sealed partial class MainPage : Page
    {

        
        /// <summary>
        /// Initialize the page
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

        }

        /// <summary>
        /// Go to the highscores page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighscoresButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Highscore));
        }

        /// <summary>
        /// Go to the tutorial page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TutorialButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tutorial));
        }
        
        /// <summary>
        /// Go to the game page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GamePage));
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
