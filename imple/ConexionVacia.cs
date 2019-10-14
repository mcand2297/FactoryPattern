using System;
using inter;

namespace imple
{
    public class ConexionVacia : IConexion
    {
        private void mensajeError(){
            Console.WriteLine("NO SE ESPECIFICÓ EL MOTOR");
        }
        public void conectar()
        {
            this.mensajeError();
        }

        public void desconectar()
        {
            this.mensajeError();
        }
    }
}