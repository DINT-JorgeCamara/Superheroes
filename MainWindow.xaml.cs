using Superheroes.Clases;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int posPersonaje = 0;
        List<Superheroe> personajes = Superheroe.GetSamples();
        public MainWindow()
        {
            InitializeComponent();

            contenedor.DataContext = personajes[posPersonaje];
            Posicion.Text = (posPersonaje + 1) + "/" + personajes.Count;
        }

        private void Arrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image flecha = (Image)sender;
            try
            {
                if (flecha.Tag.ToString() == "Atras")
                {
                    if (posPersonaje > 0)
                    {
                        posPersonaje--;
                        contenedor.DataContext = personajes[posPersonaje];
                        Posicion.Text = (posPersonaje + 1) + "/" + personajes.Count;
                    }
                }
                else
                {
                    if (posPersonaje < 3)
                    {
                        posPersonaje++;
                        contenedor.DataContext = personajes[posPersonaje];
                        Posicion.Text = (posPersonaje + 1) + "/" + personajes.Count;
                    }
                }
            }
            catch (ArgumentOutOfRangeException) { }

        }
    }
}
