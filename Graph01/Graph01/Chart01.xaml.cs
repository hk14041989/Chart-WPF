using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Graph01
{
    /// <summary>
    /// Interaction logic for Chart01.xaml
    /// </summary>
    public partial class Chart01 : Window
    {
        public Chart01()
        {
            InitializeComponent();
        }
    }
    public class Country
    {
        public Country(string Name, long Population)
        {
            this.Name = Name;
            this.Population = Population;
        }
        public string Name
        {
            get;
            set;
        }
        public long Population
        {
            get;
            set;
        }
    }

    public class CountryCollection : Collection<Country>
    {
        public CountryCollection()
        {
            Add(new Country("China", 1336718015));
            Add(new Country("India", 1189172906));
            Add(new Country("United States", 313232044));
            Add(new Country("Indonesia", 245613043));
            Add(new Country("Brazil", 203429773));
        }
    }
}
