using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Numero
    {

        #region Atributo

        private double numero;

        #endregion

        #region Propiedades
        /// <summary>
        /// Asigna un valor al atributo numero,con previa validacion
        /// </summary>
        public string SetNumero
        {
            set
            {
                numero = this.ValidarNumero(value);
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor por defecto,asigna 0 al atributo numero
        /// </summary>
        public Numero() : this(0)
        {            
        }
        /// <summary>
        /// Constructor con 1 parametro double,asigna este al atributo numero
        /// </summary>
        /// <param name="numero"> Numero que se busca asingar en el atributo</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor con 1 parametro string, valida y asigna este al atributo numero
        /// </summary>
        /// <param name="strNumero"> String que se busca asignar en el atributo</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Comprueba que el valor recibido sea numerico y lo retorna en formato double,
        /// caso contrario retornara 0.
        /// </summary>
        /// <param name="strNumero">Numero que se busca validar</param>
        /// <returns> Retorna el numero en formato double,caso contrario retorna 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            double.TryParse(strNumero, out retorno);         

            return retorno;
        }
        /// <summary>
        /// Valida que la cadena de caracteres este compuesta solamente por caracteres '0' o '1'
        /// </summary>
        /// <param name="binario"> Cadena que se busca validar </param>
        /// <returns> Retorna True si es una cadena de '0' y '1' o False si no lo es</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            for(int i = 0;i < binario.Length;i++)
            {
                if(binario.Substring(i,1) != "0" && binario.Substring(i, 1) != "1")
                {
                    retorno = false;
                    break;

                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida que se trate de un binario,luego convertira ese numero binario a decimal
        /// en caso de ser posible. Caso contrario retornara "Valor Invalido"
        /// </summary>
        /// <param name="binario"> Cadena que se quiere convertir a decimal</param>
        /// <returns>Retorna el numero convertido a decimal,caso contrario retorna "Valor Invalido"</returns>
        public string BinarioDecimal(string binario)
        {
            int num;
            string retorno;

            if(this.EsBinario(binario) == true)
            {
                num = Convert.ToInt32(binario,2);                
                retorno = Convert.ToString(num);
            }
            else
            {
                retorno = "Valor invalido";
            }


            return retorno;

        }
        /// <summary>
        /// Valida que se trate de un decimal positivo,luego convertira ese numero decimal a binario
        /// en caso de ser posible. Caso contrario retornara "Valor Invalido"
        /// </summary>
        /// <param name="numero">Cadena que se busca converetir a Binario</param>
        /// <returns>Retorna el numero convertido a decimal,caso contrario retorna "Valor Invalido"</returns>
        public string DecimalBinario(double numero)
        {           
            string retorno;

            if (numero >= 0)
            {
                retorno = Convert.ToString((int)numero, 2);

                if(this.EsBinario(retorno) == false)
                {
                    retorno = "Valor Invalido";
                }

            }
            else
            {
                retorno = "Valor Invalido";
            }

            return retorno;
        }

        /// <summary>
        /// Valida que se trate de un decimal positivo,luego convertira ese numero decimal a binario
        /// en caso de ser posible. Caso contrario retornara "Valor Invalido"
        /// </summary>
        /// <param name="numero">numero que se busca converetir a Binario</param>
        /// <returns>Retorna el numero convertido a decimal,caso contrario retorna "Valor Invalido"</returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "";
            int auxNumero;

            if(int.TryParse(numero, out auxNumero) == true)
            {
                retorno = this.DecimalBinario(auxNumero);
            }
            else
            {
                retorno = "Valor Invalido";
            }

            return retorno;

        }

        #endregion      

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga de operador +,suma los atributos numero de cada Clase.
        /// </summary>
        /// <param name="n1">Primer Numero que se busca sumar</param>
        /// <param name="n2">Segundo Numero que se busca sumar</param>
        /// <returns>Retorna el resultado de la suma de los atributos numero de cada Clase</returns>
        public static double operator +(Numero n1, Numero n2)
        {

            return n1.numero + n2.numero;

        }
        /// <summary>
        /// Sobrecarga de operador -,resta los atributos numero de cada Clase.
        /// </summary>
        /// <param name="n1">Primer Numero que se busca restar</param>
        /// <param name="n2">Segundo Numero que se busca restar</param>
        /// <returns>Retorna el resultado de la resta de los atributos numero de cada Clase</returns>
        public static double operator -(Numero n1, Numero n2)
        {

            return n1.numero - n2.numero;

        }
        /// <summary>
        /// Sobrecarga de operador /,divide los atributos numero de cada Clase.
        /// </summary>
        /// <param name="n1">Primer Numero que se busca dividir</param>
        /// <param name="n2">Segundo Numero que se busca dividir</param>
        /// <returns>Retorna el resultado de la division de los atributos numero de cada Clase,en caso de que el segundo numero
        /// sea 0,devuelve "Double.MinValue"</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double aux;

            if(n2.numero == 0)
            {
                aux = double.MinValue;
            }
            else
            {
                aux = n1.numero / n2.numero;
            }

            return aux; 
        }
        /// <summary>
        /// Sobrecarga de operador *,multiplica los atributos numero de cada Clase.
        /// </summary>
        /// <param name="n1">Primer Numero que se busca multiplicar</param>
        /// <param name="n2">Segundo Numero que se busca multiplicar</param>
        /// <returns>Retorna el resultado de la multiplicacion de los atributos numero de cada Clase</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        #endregion

    }
}
