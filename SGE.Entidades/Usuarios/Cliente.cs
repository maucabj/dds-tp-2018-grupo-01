﻿using SGE.Entidades.Categorias;
using SGE.Entidades.Dispositivos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SGE.Entidades.Usuarios
{
    [Table(name: "Cliente")]
    public class Cliente : Usuario
    {
        #region Propiedades
        public string NumeroDocumento { get; set; }
        public List<Inteligente> Inteligentes { get; set; } //many to many con Dispositivo
        public List<Estandar> Estandars { get; set; } //many to many con Dispositivo

        /*los atributos latitud y longitud , no deben ir aca. El cliente posee una direccion(tabla)
         * buscar una funcion que transforme una direccion en coordenadas(latitud, longitud),
         */
        public double Latitud { get; set; }  
        public double Longitud { get; set; }
        //
        public int TransformadorId { get; set; } // fk con tabla transformador
        public Transformador Transformador { get; set; } // one to many con  Transformador
        public virtual TipoDocumento TipoDocumento { get; set; } //one to one
        public List<Telefono> Telefonos { get; set; } // one to many con Cliente
        public int CategoriaId { get; set; } //fk con tabla cliente
        public Categoria Categoria { get; set; } // one to many con  Categoria


        public Cliente()
        {
            this.Inteligentes = new List<Inteligente>();
            this.Estandars = new List<Estandar>();
        }

        public bool TieneDispositivosEncendidos()
        {
            return this.Inteligentes.Any(d => d.EstaPrendido);
        }

        public int CantidadDispositivosEncendidos()
        {
            return this.Inteligentes.FindAll(d => d.EstaPrendido).Count;
        }

        public int CantidadDispositivosApagados()
        {
            return this.Inteligentes.FindAll(d => !d.EstaPrendido).Count;
        }

        public int CantidadTotalDispositivos()
        {
            return this.Estandars.Count;
        }

        #endregion
    }
}
