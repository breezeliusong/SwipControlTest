using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SwipControlTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ListSource = new ObservableCollection<Model>();
            ListSource.Add(new Model { Content = "first" });
            ListSource.Add(new Model { });
            ListSource.Add(new Model { Content = "Second" });
            ListSource.Add(new Model { Content = "Third" });

        }

        public ObservableCollection<Model> ListSource;
    }

    public class Model
    {
        public string Content { get; set; }
        public SwipeItems Swips
        {
            get
            {
                if (string.IsNullOrEmpty(Content))
                {
                    return (SwipeItems)Application.Current.Resources["OneItem"];
                }
                else
                {
                    return (SwipeItems)Application.Current.Resources["ThreeItems"];
                }
            }
        }

    }
}
