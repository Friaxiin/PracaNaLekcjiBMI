using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracaNaLekcjiBMI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultsListPage : ContentPage
    {
        public ResultsListPage()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            string path = App.DbPath;

            if(File.Exists(path))
            {
                string serializedResults = File.ReadAllText(path);

                List<BMIResult> results = JsonConvert.DeserializeObject<List<BMIResult>>(serializedResults);

                BMIList.ItemsSource = results;
            }
        }
    }
}