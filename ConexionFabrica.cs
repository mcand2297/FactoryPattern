using System;
using inter;
using imple;


namespace FactoryPattern{
    public class ConexionFabrica{
        public IConexion getConexion(String motor)
        {
            if(motor == null) 
                return new ConexionVacia();
            else if(motor.Equals("MYSQL"))
                return new ConexionMySQL();
            else if(motor.Equals("ORACLE"))
                return new ConexionOracle();
            else if(motor.Equals("POSTGRE"))
                return new ConexionPostgreSQL();
            else if(motor.Equals("SQL"))
                return new ConexionSQLServer();
            else
                return new ConexionVacia();
        }
    }
}