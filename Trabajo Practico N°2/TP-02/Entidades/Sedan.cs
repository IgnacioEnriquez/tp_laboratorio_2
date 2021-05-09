using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region "Enumerados"

        /// <summary>
        /// Enumerado de tipos de Sedan
        /// </summary>
        public enum ETipo
        {
            CuatroPuertas, CincoPuertas
        }

        #endregion

        #region "Atributos"

        private ETipo tipo;

        #endregion

        #region "Constructores"

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {

        }
        /// <summary>
        /// Constructor de 4 parametros
        /// </summary>
        /// <param name="marca">Marca del vehiculo Sedan</param>
        /// <param name="chasis">Chasis del vehiculo Sedan</param>
        /// <param name="color">Color del vehiculo Sedan</param>
        /// <param name="tipo">Tipo del vehiculo Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Metodo Override que muestra caracteristicas de Vehiculo Sedan
        /// </summary>
        /// <returns> Retorna los datos en formato String </returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion


    }
}
