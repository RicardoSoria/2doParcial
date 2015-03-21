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

    class dao_usuarios

    {
        //PROPIEDADES         
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsUsuarios = null;
        string instruccionSQL;
        MySqlCommand comandoMySQL;
        MySqlDataAdapter datAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS  

        public int agregarNuevoRegistro(object elNuevoRegistro)

        {

            //convertimos nuestro objeto generico a uno de la clase             
            sys_usuarios objetoTablaUsuario = (sys_usuarios)elNuevoRegistro;

            //preparamos el commando de MySQL    
            comandoMySQL = new MySqlCommand();

            //preparar el dataset     
            dsUsuarios = new DataSet();

            //preparar el dataAdapter...       
            datAdapterMySQL = new MySqlDataAdapter();

            //Establecer la conexion            
            comandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            //ARMAR la instruccion MYSQL: insert           
            instruccionSQL = "INSERT INTO sys_usuarios (" +
            "usuario, contrasenia, nombre_completo, tipo_usuario" + ") VALUES ( " +
            pcs(objetoTablaUsuario.Usuario) + "," +
            pcs(objetoTablaUsuario.Contrasenia) + "," +
            pcs(objetoTablaUsuario.Nombre_completo) + "," +
            objetoTablaUsuario.Tipo_usuario.ToString() + "," +
            objetoTablaUsuario.Tipo_usuario.ToString() + " ) ";
            
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