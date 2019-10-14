using System;
using inter;

namespace imple{
    public class ConexionPostgreSQL : IConexion{
        private String Host { get; set; }
        private String Puerto { get; set; }
        private String Usuario { get; set; }
        private String Contraseña { get; set; }

        public ConexionPostgreSQL()
        {
            this.Host = "Localhost";
            this.Puerto = "5433";
            this.Usuario = "root";
            this.Contraseña = "0000";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a PostgreSQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó a PostgreSQL");
        }
    }
}