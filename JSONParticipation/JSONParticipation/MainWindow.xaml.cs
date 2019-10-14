using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JSONParticipation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(@"https://pokeapi.co/api/v2/pokemon?limit=964").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var stuff = JsonConvert.DeserializeObject<Results>(content);

                    foreach (var result in stuff.results)
                    {
                        PokemonCB.Items.Add(result.name);
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //If I had more time I would take the selected pokemon and Concat the name onto the end of the URL, which would hopefully display the abilities
            //string selectedname = PokemonCB.SelectedItem;
            //using (HttpClient client = new HttpClient())
            {
                //HttpResponseMessage response = client.GetAsync(@"https://pokeapi.co/api/v2/pokemon/"+$"{selectedname}").Result;
                //if (response.IsSuccessStatusCode)
                {
                    //var content = response.Content.ReadAsStringAsync().Result;
                    //var stuff = JsonConvert.DeserializeObject<Abilities>(content);

                    //foreach (var result in stuff.abilities)
                    {
                        //DisplayLB.Items.Add(result.name);
                    }
                }
            }
        }
    }
}
