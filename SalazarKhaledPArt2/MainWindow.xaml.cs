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

namespace WpfApp2
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
                var response = client.GetAsync(@"https://pokeapi.co/api/v2/pokemon?limit=964").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var results = JsonConvert.DeserializeObject<Results>(content);

                    foreach (var result in results.results)
                    {
                        lstPokemons.Items.Add(result);
                    }
                }
            }
        }

        private void GetPokemonInfo()
        {
            var x = ((Result)lstPokemons.SelectedItem);
            //"https://pokeapi.co/api/v2/pokemon/" + x.name;
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(x.url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    Pokemon poke = JsonConvert.DeserializeObject<Pokemon>(content);

                    txtPokemonInfo.Document.Blocks.Add(new Paragraph(new Run(poke.ToString())));

                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.UriSource = new Uri(poke.sprites.front_default);
                    image.EndInit();

                    pokeImageB.Source = image;

                    //make method for selected index
                }
            }
        }

            private void pokeButton_Click(object sender, RoutedEventArgs e)
            {
                GetPokemonInfo();
            }
        }
    }
