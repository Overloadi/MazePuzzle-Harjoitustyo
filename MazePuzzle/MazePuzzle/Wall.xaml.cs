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
    /// <summary>
    /// Class for the maze's walls, which cannot be crossed
    /// </summary>
    public sealed partial class Wall : UserControl
    {
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        /// <summary>
        /// Initialize the wall
        /// </summary>
        public Wall()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Set the wall's location
        /// </summary>
        public void Setlocation()
        {
            SetValue(Canvas.LeftProperty, LocationX);
            SetValue(Canvas.TopProperty, LocationY);
        }
    }
}
