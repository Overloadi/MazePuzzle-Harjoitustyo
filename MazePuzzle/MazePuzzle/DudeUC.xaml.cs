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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MazePuzzle
{
    public sealed partial class DudeUC : UserControl
    {
        public double DudeLocationX { get; set; }
        public double DudeLocationY { get; set; }
        /// <summary>
        /// Create the player charater
        /// </summary>
        /// <param name="locationx">Player's starting location x-coordinate</param>
        /// <param name="locationy">Player's starting location y-coordinate</param>
        public DudeUC(double locationx, double locationy)
        {
            this.InitializeComponent();
            this.DudeLocationX = locationx;
            this.DudeLocationY = locationy;
        }

        /// <summary>
        /// Set the location of the player on the maze canvas
        /// </summary>
        public void SetLocation()
        {
            SetValue(Canvas.LeftProperty, DudeLocationX);
            SetValue(Canvas.TopProperty, DudeLocationY);
        }

        /// <summary>
        /// Move the player up
        /// </summary>
        public void MoveUp()
        {
            // DudeLocationY =+ 26;
            DudeLocationY = DudeLocationY - 18;
            SetLocation();
        }

        /// <summary>
        /// Move the player right
        /// </summary>
        public void MoveRight()
        {
            // DudeLocationX =+ 18;
            DudeLocationX = DudeLocationX + 26;
            SetLocation();
        }

        /// <summary>
        /// Move the player down
        /// </summary>
        public void MoveDown()
        {
            // DudeLocationY =- 26;
            DudeLocationY = DudeLocationY + 18;
            SetLocation();
        }

        /// <summary>
        /// Move the player left
        /// </summary>
        public void MoveLeft()
        {
            // DudeLocationX =- 18;
            DudeLocationX = DudeLocationX - 26;
            SetLocation();
        }


    }
}
