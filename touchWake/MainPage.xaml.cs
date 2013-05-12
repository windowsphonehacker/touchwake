using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace touchWake
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CSharp___DllImport.DllImportCaller.lib.StringIntIntCall("coredll", "SetDevicePower", "KPD1:", 1, (int)CSharp___DllImport.Phone.Network.WiFi.PowerState.D0);
            CSharp___DllImport.DllImportCaller.lib.StringIntIntCall("coredll", "SetDevicePower", "KBD1:", 1, (int)CSharp___DllImport.Phone.Network.WiFi.PowerState.D0);

        }

    }
}