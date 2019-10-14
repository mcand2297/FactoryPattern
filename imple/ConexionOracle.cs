using System;
using inter;

namespace imple{
    public class ConexionOracle : IConexion{
        private String Host { get; set; }
        private String Puerto { get; set; }
        private String Usuario { get; set; }
        private String Contraseña { get; set; }

        public ConexionOracle()
        {
            this.Host = "Localhost";
            this.Puerto = "1521";
            this.Usuario = "root";
            this.Contraseña = "1234";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a Oracle");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó a Oracle");
        }
    }
}