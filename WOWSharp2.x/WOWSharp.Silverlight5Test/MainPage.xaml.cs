﻿// Copyright (C) 2011 by Sherif Elmetainy (Grendiser@Kazzak-EU)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WOWSharp.Silverlight5Test
{
    /// <summary>
    ///   Main page
    /// </summary>
    public partial class MainPage
    {
        /// <summary>
        ///   singleton reference to main page
        /// </summary>
        private static UserControl _main;

        /// <summary>
        ///   ctor
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Dispatcher for main page
        /// </summary>
        public static Dispatcher MainDispatcher
        {
            get
            {
                return _main.Dispatcher;
            }
        }

        /// <summary>
        ///   Go to a page
        /// </summary>
        /// <param name="control"> </param>
        public static void Goto(UserControl control)
        {
            if (_main != null)
            {
                _main.Content = control;
                _main = control;
            }
        }

        /// <summary>
        ///   Go To Guild test page
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void TestGuildButtonClick(object sender, RoutedEventArgs e)
        {
            Goto(new GuildTest());
        }

        /// <summary>
        ///   Load event to set the singleton reference
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void LayoutRootLoaded(object sender, RoutedEventArgs e)
        {
            if (_main == null)
                _main = this;
            //TestTabardsButton.Content = typeof (Application).AssemblyQualifiedName;
        }

        /// <summary>
        ///   Tabards test page
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void TestTabardsButtonClick(object sender, RoutedEventArgs e)
        {
            //Goto(new GuildTabardTest());
        }

        private void TestDiablo_Click(object sender, RoutedEventArgs e)
        {
            Goto(new DiabloTest());
        }
    }
}