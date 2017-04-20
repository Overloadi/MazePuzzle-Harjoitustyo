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
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Highscore : Page
    {
        private Windows.Storage.StorageFile highscoresFile;
        public Highscore()
        {
            this.InitializeComponent();
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null) return;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void CommandInvokedHandler(IUICommand command)
        {
            Debug.WriteLine("The '" + command.Label + "' command has been selected.");
        }

        private async void OpenFile()
        {
            Windows.Storage.StorageFolder highscoresfolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            highscoresFile = await highscoresfolder.CreateFileAsync("highscores.txt", Windows.Storage.CreationCollisionOption.OpenIfExists);
        }

        private async void ShowHighscores_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
            string temp;
            // highScoresTextBox.Text = await Windows.Storage.FileIO.ReadTextAsync(highscoresFile);
            IList<String> lines = await Windows.Storage.FileIO.ReadLinesAsync(highscoresFile);
            for (int i = 0; i < lines.Count; i++)
            {
                temp = lines.ElementAt(i);
                temp = temp.Replace("|", " ");
                highScoresTextBlock.Text += temp;
                highScoresTextBlock.Text += "\r";
            }
            /*try
            {
                var TopScores = File.ReadLines(path);
                highScoresTextBox.Text = TopScores.ToString();
            } */
            /*try
            {
                text = System.IO.File.ReadAllText(path);
            }
            catch (Exception ee)
            {
                var Msg = new MessageDialog(ee.Message, "Error");
                Msg.Commands.Add(new UICommand(
                    "Shit",
                    new UICommandInvokedHandler(this.CommandInvokedHandler)));
                Msg.DefaultCommandIndex = 0;
                Msg.CancelCommandIndex = 0;
                await Msg.ShowAsync();
            } */

        }
    }
}
