using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HolaMundoForms.DB;
using HolaMundoForms.BO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;   

namespace HolaMundoForms.DAO

{

    class dao_sucursales

    {
        //PROPIEDADES         

        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsSucursales = null;
        string instruccionSQL;
        MySqlCommand comandoMySQL;
        MySqlDataAdapter datAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS  

        public int agregarNuevoRegistro(object elNuevoRegistro)

        {

            //convertimos nuestro objeto generico a uno de la clase             
            cat_sucursales objetoTablaSucursal = (cat_sucursales)elNuevoRegistro;

            //preparamos el commando de MySQL    
            comandoMySQL = new MySqlCommand();

            //preparar el dataset
            dsSucursales = new DataSet();

            //preparar el dataAdapter...    
            datAdapterMySQL = new MySqlDataAdapter();

            //Establecer la conexion  
            comandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            //ARMAR la instruccion MYSQL: insert           
            instruccionSQL = "INSERT INTO cat_sucursales (" + "codigo, nombre_sucursal, direccion, responsable" + ") VALUES ( " +
            pcs(objetoTablaSucursal.Codigo) + "," +
            pcs(objetoTablaSucursal.Nombre_sucursal) + "," +
            objetoTablaSucursal.Direccion.ToString() + "," +
            objetoTablaSucursal.Responsable.ToString() +" ) ";
            comandoMySQL.CommandText = instruccionSQL;

            int resultadodelComando = comandoMySQL.ExecuteNonQuery();
            if (resultadodelComando <= 0)

            {
                return 0; //HAY UN ERROR
            }

            return 1;
            }
            public String pcs(string Valor)
         {
            return "'" + Valor + "'";
         }

    }

}