using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodFight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Root : TabbedPage
    {
        public Root()
        {
            InitializeComponent();
            var pages = Children.GetEnumerator();
            pages.MoveNext(); // First page
            pages.MoveNext(); // Second page
            pages.MoveNext(); // Third page
            CurrentPage = pages.Current;
        }
    }
}