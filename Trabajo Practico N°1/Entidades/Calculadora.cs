using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public static class Calculadora
    {
        #region Metodos

        /// <summary>/// 
        /// Este metodo se encarga de Validar si el Char ingresado,es un operador + ,- , / o *
        /// </summary>/// 
        /// <param name="operador"> Char que se analiza si es un operador </param>        /// 
        /// <returns>Devuelve el operador validado en forma de String,caso contrario retorna +</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";

            if(operador == '*' || operador == '+' || operador == '-' || operador == '/')
            {
                retorno = Convert.ToString(operador);
            }

            return retorno;
        }

        /// <summary>///
        /// Valida y realiza la operacion pedida entre ambos numeros.
        /// </summary>
        /// <param name="num1"> Primer Numero con el que se realiza la operacion</param>
        /// <param name="num2"> Segundo Numero con el que se realiza la operacion</param>
        /// <param name="operador"> Operador con el que se realiza la operacion</param>
        /// <returns> Retorna el resultado de la operacion,caso contrario retorna 0</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            string operadorAux = ValidarOperador(Convert.ToChar(operador));

            if (operadorAux == "+" ||
                operadorAux == "-" ||
                operadorAux == "/" ||
                operadorAux == "*" )
            {
                switch(operador)
                {
                    case "+":
                        retorno = num1 + num2;
                            break;
                    case "-":
                        retorno = num1 - num2;
                        break;
                    case "/":
                        retorno = num1 / num2;
                        break;
                    case "*":
                        retorno = num1 * num2;
                        break;
                }
            }

            return retorno;          

        }

        #endregion
    }
}
