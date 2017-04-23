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
    
    public sealed partial class MazeSelect : ContentDialog
    {
        //ListView listview = new ListView();
        public int index = 0;
        public MazeSelect()
        {
            this.InitializeComponent();

            /*List<string> items = new List<string>();
            items.Add("Maze 1");
            items.Add("Maze 2");
            items.Add("Maze 3");
            listview.ItemsSource = items; */
        }



        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // index = listview.Items.IndexOf(listview.SelectedItem);
            index = mazeSelectListView.SelectedIndex;
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            index = 0;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // index = listview.Items.IndexOf(listview.SelectedItems[0]);
        }

        public int getMazeIndex()
        {

            return this.index;
        }
    }
}
