using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region "Constructores"

        /// <summary>
        /// Constructor con 3 parametros,reutiliza constructor base
        /// </summary>
        /// <param name="marca">Marca del vehiculo SUV</param>
        /// <param name="chasis">Chasis del vehiculo SUV</param>
        /// <param name="color">Color del vehiculo SUV</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Metodo Override que muestra caracteristicas de Vehiculo SUV
        /// </summary>
        /// <returns> Datos en formato String </returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion


    }
}
