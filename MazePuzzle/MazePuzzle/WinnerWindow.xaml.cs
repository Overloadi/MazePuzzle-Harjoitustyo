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

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MazePuzzle
{
    /// <summary>
    /// Window, that pops up when the player completes the maze. If the player types their name, the highscore is saved to the highscores file.
    /// </summary>
    public sealed partial class WinnerWindow : ContentDialog
    {
        private string name;
        /// <summary>
        /// Initialize the page
        /// </summary>
        public WinnerWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Save the written name to name variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            name = winnerTextBox.Text;
        }

        /// <summary>
        /// If cancel button is pressed, the name variable is an empty string, which will not be saved to highscores file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            name = "";
        }

        /// <summary>
        /// Show how long the player took to complete the maze in seconds.
        /// </summary>
        /// <param name="time">Player time in seconds</param>
        public void showTime(double time)
        {
            winnerTextBlock.Text = "You solved the labyrinth in " + time + " seconds" + "\r" + "Input your name below";
        }

        /// <summary>
        /// Get the name variable
        /// </summary>
        /// <returns>Return name variable</returns>
        public string getName()
        {
            return this.name;
        }
    }
}
