using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLite.Models
{
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int IDEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public decimal Salario { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", IDEmpleado, Nombres, Apellidos, Fecha, Activo, Salario);
        }
    }
}
