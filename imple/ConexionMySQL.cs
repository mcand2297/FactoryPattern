using System;
using inter;

namespace imple{
    public class ConexionMySQL : IConexion{
        private String Host { get; set; }
        private String Puerto { get; set; }
        private String Usuario { get; set; }
        private String Contraseña { get; set; }

        public ConexionMySQL()
        {
            this.Host = "Localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Contraseña = "toor";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a MySQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó a MySQL");
        }
    }
}