using AdminBanda.Entidades;
using PCLStorage;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminBanda.Datos
{
    public class SqlHelper
    {
        static object locker = new object();
        SQLiteConnection database;
        public SqlHelper()
        {
            database = GetConnection();
            // create the tables
            database.CreateTable<Instrumento>();
            database.CreateTable<Integrante>();
        }
        public SQLite.SQLiteConnection GetConnection()
        {
            SQLiteConnection sqlitConnection;
            var sqliteFilename = "AdminBandaSQL.db3";
            IFolder folder = FileSystem.Current.LocalStorage;
            string path = PortablePath.Combine(folder.Path.ToString(), sqliteFilename);
            sqlitConnection = new SQLite.SQLiteConnection(path);
            return sqlitConnection;
        }

        #region CRUD Intrumento

        public IEnumerable<Instrumento> GetInstrumentos()
        {
            lock (locker)
            {
                var lista = (from i in database.Table<Instrumento>() select i).ToList();

                if (lista.Count < 1)
                {
                    foreach (var item in GetData.obtenerInstrumentos())
                    {
                        GuardarInstrumento(item);
                    }
                }

                lista = (from i in database.Table<Instrumento>() select i).ToList();
                return lista;
            }
        }

        public Instrumento GetInstrumento(int codInstrumento)
        {
            lock (locker)
            {
                return database.Table<Instrumento>().FirstOrDefault(x => x.Codigo == codInstrumento);
            }
        }

        public int GuardarInstrumento(Instrumento item)
        {
            lock (locker)
            {
                if (GetInstrumento(item.Codigo) != null)
                {
                    //Update Item
                    database.Update(item);
                    return 1;                    
                }
                else
                {
                    //Insert item
                    return database.Insert(item);
                }
            }
        }

        public int DeleteInstrumento(int id)
        {
            lock (locker)
            {
                return database.Delete<Instrumento>(id);
            }
        }
        #endregion

        #region CRUD Integrante

        public IEnumerable<Integrante> GetIntegrantes()
        {
            lock (locker)
            {
                var lista = (from i in database.Table<Integrante>() select i).ToList();

                if (lista.Count < 1)
                {
                    foreach (var item in GetData.obtenerIntegrantes())
                    {
                        GuardarIntegrante(item);
                    }
                }

                lista = (from i in database.Table<Integrante>() select i).ToList();
                return lista;
            }
        }

        public Integrante GetIntegrante(int codIntegrante)
        {
            lock (locker)
            {
                return database.Table<Integrante>().FirstOrDefault(x => x.CodigoIntegrante == codIntegrante);
            }
        }

        public int GuardarIntegrante(Integrante item)
        {
            lock (locker)
            {
                if (GetIntegrante(item.CodigoIntegrante) != null)
                {
                    //Update Item
                    database.Update(item);
                    return 1;                    
                }
                else
                {
                    //Insert item
                    return database.Insert(item);
                }
            }
        }

        public int DeleteIntegrante(int id)
        {
            lock (locker)
            {
                return database.Delete<Integrante>(id);
            }
        }
        #endregion



    }
}
