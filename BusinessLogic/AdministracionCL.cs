﻿ using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AdministracionCL
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? CodigoPostal { get; set; }
        public string? NIF { get; set; }
        public string? NOSS { get; set; }


        public bool Add()
        {
            try
            {
                string sql;
                sql = " Insert into ADMINISTRADORES (NOMBRE, DIRECCION, TELEFONO, POBLACION, PROVINCIA, CODIGOPOSTAL, NIF, NUMSS) Values(@NOMBRE, @DIRECCION, @TELEFONO, @POBLACION, @PROVINCIA, @CODIGOPOSTAL, @NIF, @NUMSS) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Poblacion", Poblacion);
                cmd.Parameters.AddWithValue("@Provincia", Provincia);
                cmd.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                cmd.Parameters.AddWithValue("@NIF", NIF);
                cmd.Parameters.AddWithValue("@NUMSS", NOSS);

                dbAcess.Ejecutar(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Get()
        {
            try
            {
                string sql;
                sql = " Select IDADMIN,NOMBRE, DIRECCION, TELEFONO, POBLACION, PROVINCIA, CODIGOPOSTAL, NIF, NUMSS from ADMINISTRADORES ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetById()
        {
            try
            {
                string sql;
                sql = " IDADMIN, NOMBRE, DIRECCION, TELEFONO, POBLACION, PROVINCIA, CODIGOPOSTAL, NIF, NUMSS from ADMINISTRADORES Where IDADMIN=@IDADMIN";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDADMIN", Id);
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Edit()
        {
            try
            {
                string sql;
                sql = " Update ADMINISRADORES NOMBRE=@NOMBRE, DIRECCION=@DIRECCION, TELEFONO=@TELEFONO, POBLACION=@POBLACION, PROVINCIA=@PROVINCIA, CODIGOPOSTAL=@CODIGOPOSTAL, NIF=@NIF, NUMSS=@NUMSS Where IDADMIN=@IDADMIN";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDADMIN", Id);
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Poblacion", Poblacion);
                cmd.Parameters.AddWithValue("@Provincia", Provincia);
                cmd.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                cmd.Parameters.AddWithValue("@NIF", NIF);
                cmd.Parameters.AddWithValue("@NUMSS", NOSS);


                dbAcess.Ejecutar(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete()
        {
            try
            {
                string sql;
                sql = " Delete from ADMINISTRADORES Where IDADMIN=@IDADMIN ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDADMIN", Id);
                dbAcess.Ejecutar(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}