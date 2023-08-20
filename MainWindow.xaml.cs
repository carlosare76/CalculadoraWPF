using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace ImplementacionCalculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Definicion de variables
        private double NumOp1 = 0, NumOp2=0;
        private string NumTxt1 = "", NumTxt2 = "", resul="", Op ="";


        private void btnReinicio(object sender, RoutedEventArgs e)
        {
            //Limpieza de pantalla
            NumOp1 = 0;
            NumOp2 = 0;
            NumTxt1 = "";
            NumTxt2 = "";
            resul = "";
            Op = "";
            pantalla.Text = "";
        }

        private void btnNumero(object sender, RoutedEventArgs e)
        {
            //Registro operador numero 1
            Button btn = sender as Button;
            NumTxt1 = NumTxt1 + (string)btn.Content;
            NumOp1 = double.Parse(NumTxt1);
            MostrarPantalla(NumTxt1);
            

        }
        private void btnSigno(object sender, RoutedEventArgs e)
        {
            //Cambio signo negativo o positivo de operador 1
            NumOp1 = NumOp1 * (-1);
            NumTxt1= Convert.ToString(NumOp1);
            MostrarPantalla(NumTxt1);
        }
        private void btnPunto(object sender, RoutedEventArgs e)
        {
            //Agregar punto decimal
            if (NumTxt1 != "")
            {
                NumTxt1 = NumTxt1 + ".";
            }
            
            MostrarPantalla(NumTxt1);
        }
        private void btnOperador(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;


        }

        private void btnResultado(object sender, RoutedEventArgs e)
        {

        }

        private void MostrarPantalla(Object numero, Object numero2 = null)
        {
            if (resul == "") 
            {
                if(Op=="")
                {
                    pantalla.Text=Convert.ToString(numero);
                }
                else
                {
                    pantalla.Text=Convert.ToString(numero)+Op+Convert.ToString(numero2);
                }
            }
            else
            {
                pantalla.Text = resul;
            }
        }
    }
}
