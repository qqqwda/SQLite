using SQLite.Config;
using SQLite.Net;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.IO;

namespace SQLite.Models
{
    class DataAccess : IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();//Obtiene la plataforma del celular (iOS o Droid)
            connection = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioDB,"Empleados.db3"));
            //Crea base de datos con el nombre "Empleados db3" en la ruta dentro del config.DirectorioDB

            connection.CreateTable<Empleado>();
        }

        public void InsertEmpleado(Empleado empleado)
        {
            connection.Insert(empleado);
        }

        public void UpdateEmpleado(Empleado empleado)
        {
            connection.Update(empleado);
        }

        public void DeleteEmpleado(Empleado empleado)
        {
            connection.Delete(empleado);
        }

        public void GetEmpleado(int id)
        {
            connection.Table<Empleado>().FirstOrDefault(e => e.IDEmpleado == id);
        }

        public void GetEmpleados()
        {
            //connection.Table<Empleado>().ToList();
            connection.Table<Empleado>().OrderBy(c => c.Apellidos).ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
