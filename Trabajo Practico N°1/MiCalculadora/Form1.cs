using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {     

        public FormCalculadora()
        {
            InitializeComponent();

            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");

            this.cmbOperador.SelectedItem = "+";
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        #region Metodos Creados

        /// <summary>
        /// Borra todos los datos de los TextBox,Combobox y Labels
        /// </summary>
        private void Limpiar()
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
        }
        /// <summary>
        /// Realiza la operacion pedida entre ambos numeros.
        /// </summary>
        /// <param name="numero1">Primer Numero con el que se realiza la operacion</param>
        /// <param name="numero2">Segundo Numero con el que se realiza la operacion</param>
        /// <param name="operador">Operador con el que se realiza la operacion</param>
        /// <returns>Retorna el resultado de la operacion en caso de haber ingresado bien los numeros,
        /// caso contrario retorna 0</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);

            return Calculadora.Operar(n1, n2, operador);
        }

        #endregion

        #region Metodos de Botones

        /// <summary>
        /// Limpia los datos de la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Realiza la operacion pedida por la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(this.txtNumero1.Text) == false &&
               string.IsNullOrEmpty(this.txtNumero2.Text) == false)
            {

            double resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, (string)this.cmbOperador.SelectedItem);
            lblResultado.Text = Convert.ToString(resultado);

            }
        }
        /// <summary>
        /// Convierte el resultado en Binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lblResultado.Text) == false)
            {
                Numero n1 = new Numero(0);

                lblResultado.Text = n1.DecimalBinario(lblResultado.Text);                 
            }
        }
        /// <summary>
        /// Convierte el resultado de Binario a Decimal si es posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblResultado.Text) == false)
            {
             Numero n1 = new Numero(0);

             lblResultado.Text = n1.BinarioDecimal(lblResultado.Text);

            }
        }

        #endregion
        
    }
}
