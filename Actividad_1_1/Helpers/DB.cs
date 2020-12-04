using Actividad_1_1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_1_1.Helpers
{
    public class DB
    {
        public static List<Cliente> ClientesDB = new List<Cliente>();
        public static List<Producto> ProductoDB = new List<Producto>();
        public static List<Iva> IvaDB = new List<Iva>();
        static DB()
        {
            var Tel1 = new Telefono { Numero = "1111" };
            var Tel2 = new Telefono { Numero = "2222" };
            var Tel3 = new Telefono { Numero = "3333" };
            var ListaTel = new List<Telefono>
            {
                Tel1,
                Tel2,
                Tel3
            };
            ClientesDB.Add(new Cliente { DNI = "111", Nombre = "Pepe", Apellido1= "Pe", Apellido2="PA", Telefonos = ListaTel });
            ClientesDB.Add(new Cliente 
                { 
                    DNI = "111", 
                    Nombre = "Toni", 
                    Apellido1 = "Pi",
                    Apellido2 = "PO",
                    Telefonos = new List<Telefono> { new Telefono { Numero= "4444"} } 
                });

            IvaDB.Add(new Iva { valor = 0.04});
            IvaDB.Add(new Iva { valor = 0.1 });
            IvaDB.Add(new Iva { valor = 0.21 });

            ProductoDB.Add(new Producto { IVA = IvaDB[0], Nombre = "Agua", PVP = 1.50, Stock = 2 });
            ProductoDB.Add(new Producto { IVA = IvaDB[2], Nombre = "Cola", PVP = 2.50, Stock = 4 });
            ProductoDB.Add(new Producto { IVA = IvaDB[1], Nombre = "Fanta", PVP = 2, Stock = 8 });
        }
    }
}
