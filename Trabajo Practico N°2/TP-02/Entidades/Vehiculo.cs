﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region "Atributos"

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #endregion

        #region "Enumerados"

        /// <summary>
        /// Enumerados de Marcas
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Enumerado de Tamaños
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        #endregion        

        #region "Constructores"

        /// <summary>
        /// Constructor con 3 parametros
        /// </summary>
        /// <param name="chasis"> Chasis </param>
        /// <param name="marca">  Marca </param>
        /// <param name="color">  Color </param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;

        }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio { get; }


        #endregion

        #region "Metodos"

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>String con todos los datos</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        #endregion

        #region "Sobrecargas"

        /// <summary>
        /// Retorna los datos de un vehiculo
        /// </summary>
        /// <param name="p">Vehiculo cual se quiere saber los datos</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Vehiculo numero 1</param>
        /// <param name="v2">Vehiculo numero 2</param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis); 
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Vehiculo numero 1</param>
        /// <param name="v2">Vehiculo numero 2</param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }

        #endregion
    }
}
