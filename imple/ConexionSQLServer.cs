using System;
using inter;

namespace imple{
    public class ConexionSQLServer : IConexion{
        private String Host { get; set; }
        private String Puerto { get; set; }
        private String Usuario { get; set; }
        private String Contraseña { get; set; }

        public ConexionSQLServer()
        {
            this.Host = "Localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Contraseña = "toor";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a SQLServer");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó a SQLServer");
        }
    }
}