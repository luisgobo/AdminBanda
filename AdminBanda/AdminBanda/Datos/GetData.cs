using AdminBanda.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AdminBanda.Datos
{
    public class GetData
    {
        public static ObservableCollection<Integrante> obtenerIntegrantes()
        {

            ObservableCollection<Integrante> listaDatos = new ObservableCollection<Integrante>();

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 1,
                Identificacion = "401900152",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Luis",
                Apellido1 = "Gonzalez",
                Apellido2 = "Bogantes",
                FechaNacimiento = new DateTime(1986, 01, 29),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 2,
                Identificacion = "101200998",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Rodrigo",
                Apellido1 = "Campos",
                Apellido2 = "Blanco",
                FechaNacimiento = new DateTime(1978, 10, 15),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 3,
                Identificacion = "401900760",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Maria",
                Apellido1 = "Miranda",
                Apellido2 = "Lopez",
                FechaNacimiento = new DateTime(1987, 01, 01),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 4,
                Identificacion = "401820658",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Camilo",
                Apellido1 = "Perez",
                Apellido2 = "Prado",
                FechaNacimiento = new DateTime(1982, 06, 03),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 5,
                Identificacion = "102564568",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Lorena",
                Apellido1 = "Rosales",
                Apellido2 = "Padilla",
                FechaNacimiento = new DateTime(1980, 02, 20),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 6,
                Identificacion = "412005896",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Patricia",
                Apellido1 = "Castro",
                Apellido2 = "Mora",
                FechaNacimiento = new DateTime(1996, 03, 10),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 7,
                Identificacion = "41204240",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Claudio",
                Apellido1 = "Araya",
                Apellido2 = "Lopez",
                FechaNacimiento = new DateTime(1980, 02, 21),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 8,
                Identificacion = "401920568",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Pedro",
                Apellido1 = "Peñaranda",
                Apellido2 = "Godines",
                FechaNacimiento = new DateTime(1988, 03, 11),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 9,
                Identificacion = "103650465",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Leonardo",
                Apellido1 = "Campos",
                Apellido2 = "Díaz",
                FechaNacimiento = new DateTime(1982, 02, 03),
                Activo = true
            });

            listaDatos.Add(new Integrante
            {
                CodigoIntegrante = 10,
                Identificacion = "401920565",
                TipoIdentificacion = "Cedula CR",
                Nombre = "Pablo",
                Apellido1 = "Escalante",
                Apellido2 = "Gómez",
                FechaNacimiento = new DateTime(1990, 09, 23),
                Activo = true
            });

            return listaDatos;
        }
    }
}
