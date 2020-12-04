using Actividad_1_1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_1_1.DAO
{
    public class ClienteDAO
    {
        public static void AddTlfNew(Cliente cli, Telefono tlf)
        {
            cli.Telefonos.Add(tlf);
        }

        public static void DelTlf(Cliente cli, Telefono tlf)
        {
            cli.Telefonos.Remove(tlf);
        }
    }
}
