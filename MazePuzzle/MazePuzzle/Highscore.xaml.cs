using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    /// Highscore page, where the user can see all saved highscores.
    /// </summary>
    public sealed partial class Highscore : Page
    {
        private Windows.Storage.StorageFile highscoresFile;

        /// <summary>
        /// Initialize the page
        /// </summary>
        public Highscore()
        {
            this.InitializeComponent();
            
        }

        /// <summary>
        /// Go back to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null) return;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        /// <summary>
        /// Open the folder where the highscores.txt is and open the text file for reading
        /// </summary>
        private async void OpenFile()
        {
            Windows.Storage.StorageFolder highscoresfolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            highscoresFile = await highscoresfolder.CreateFileAsync("highscores.txt", Windows.Storage.CreationCollisionOption.OpenIfExists);
        }

        /// <summary>
        /// Read the highscores from highscores.txt and display them on the textblock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ShowHighscores_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
            string temp;
            IList<String> lines = await Windows.Storage.FileIO.ReadLinesAsync(highscoresFile);
            for (int i = 0; i < lines.Count; i++)
            {
                temp = lines.ElementAt(i);
                temp = temp.Replace("|", " ");
                highScoresTextBlock.Text += temp;
                highScoresTextBlock.Text += "\r";
            }
        }
    }
}
