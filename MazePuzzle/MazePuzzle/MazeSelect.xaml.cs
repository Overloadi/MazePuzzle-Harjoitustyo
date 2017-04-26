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
    /// Window for the maze selection.
    /// </summary>
    public sealed partial class MazeSelect : ContentDialog
    {
        public int index = 0;
        /// <summary>
        /// Initialize the window
        /// </summary>
        public MazeSelect()
        {
            this.InitializeComponent();

        }


        /// <summary>
        /// Save the selected maze's index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            index = mazeSelectListView.SelectedIndex;
        }

        /// <summary>
        /// Cancel the selection, reset the selection to the default maze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            index = 0;
        }

        /// <summary>
        /// Return the selected maze's index.
        /// </summary>
        /// <returns></returns>
        public int getMazeIndex()
        {
            return this.index;
        }
    }
}
