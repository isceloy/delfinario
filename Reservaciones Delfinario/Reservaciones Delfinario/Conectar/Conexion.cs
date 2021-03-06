﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Reservaciones_Delfinario.Conectar
{
    public class Conexion
    {

        private MySqlConnection conn;
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlDataReader dr;
        private String ms_servidor, ms_BD, ms_usuario, ms_clave;
        private String Query = "";
        private DataTable dt = new DataTable();

        public String servidor
        {
            get
            {
                return ms_servidor;
            }
            set
            {
                this.ms_servidor = value;
            }
        }

        public String BD
        {
            get
            {
                return ms_BD;
            }
            set
            {
                this.ms_BD = value;
            }
        }

        public String usuario
        {
            get
            {
                return ms_usuario;
            }
            set
            {
                this.ms_usuario = value;
            }
        }

        public String clave
        {
            get
            {
                return ms_clave;
            }
            set
            {
                this.ms_clave = value;
            }
        }

        /// <summary>
        /// Método que conecta con la base de datos
        /// </summary>
        /// <returns>True/False</returns>
        public void Conectar()
        {
            conn = new MySqlConnection("Server=" + servidor + ";Database=" + BD + ";Uid=" + usuario + ";Pwd=" + clave + ";");
            try
            {
                conn.Open();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.ToString());
            }
        }

        /// <summary>
        /// Cerrar la conexion con la base de datos
        /// </summary>
        public void Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.ToString());
            }
        }

        /// <summary>
        /// Ejecuta un Query
        /// </summary>
        /// <param name="Query">Cadena que contiene la consulta</param>
        /// <returns>DataTable</returns>
        public DataTable Ejecuta_Query(String Query)
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Query;
            try
            {
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (MySqlException me)
            {
                dr.Close();
                return dt;
            }
        }

    }
}
