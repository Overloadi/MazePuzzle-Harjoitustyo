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
        public DudeUC(double locationx, double locationy)
        {
            this.InitializeComponent();
            this.DudeLocationX = locationx;
            this.DudeLocationY = locationy;
        }

        public double DudeLocationX { get; set; }
        public double DudeLocationY { get; set; }

        public void SetLocation()
        {
            SetValue(Canvas.LeftProperty, DudeLocationX);
            SetValue(Canvas.TopProperty, DudeLocationY);
        }

        public void MoveUp()
        {
            DudeLocationY =+ 26;
            SetLocation();
        }

        public void MoveRight()
        {
            DudeLocationX =+ 18;
            SetLocation();
        }

        public void MoveDown()
        {
            DudeLocationY =- 26;
            SetLocation();
        }

        public void MoveLeft()
        {
            DudeLocationX =- 18;
            SetLocation();
        }

    }
}
