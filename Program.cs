using System;
using inter;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConexionFabrica fabrica = new ConexionFabrica();

            IConexion conexion1 = fabrica.getConexion("POSTGRE");
            conexion1.conectar();
            conexion1.desconectar();
            Console.WriteLine();

            IConexion conexion2 = fabrica.getConexion("ORACLE");
            conexion2.conectar();
            conexion2.desconectar();
            Console.WriteLine();

            IConexion conexion3 = fabrica.getConexion("MYSQL");
            conexion3.conectar();
            conexion3.desconectar();
            Console.WriteLine();

            IConexion conexion4 = fabrica.getConexion("cualquier cosa");
            conexion4.conectar();
            conexion4.desconectar();
        }
    }
}
