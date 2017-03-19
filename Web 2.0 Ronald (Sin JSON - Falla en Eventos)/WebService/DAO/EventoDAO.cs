
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.BO;
using WebService.DAO;
using System.Data;

namespace WebService.DAO
{
    public class EventoDAO
    {
        ConexionDAO BD = new ConexionDAO();
        string sql;


        public DataTable Recuperar(object obj)
        {
            sql = "EXEC DevolverTablaEventos";
            return BD.Tabla(sql);
        }
        public int AgregarEvento(object obj)
        {
            EventoBO Evento = (EventoBO)obj;
            sql = "EXEC AgregarEvento   '" + Evento.Descripcion + "','" + Evento.Nombre + "' ," + Evento.Concurrente + ", '" + Evento.Direccion + "', '" + Evento.Longitud + "', '" + Evento.Latitud + "', '" + Evento.FechaInicio + "', '" + Evento.FechaFin + "', " + Evento.IdUsuario + ", '" + Evento.FotoEV + "'";
            return BD.Ejecutar(sql);
        }
        public int EliminarEvento(object obj)
        {
            EventoBO Evento = (EventoBO)obj;
            sql = "EXEC EliminarEvento " + Evento.IdEventos + "";
            return BD.Ejecutar(sql);
        }
        public int ModificarEvento(object obj)
        {
            EventoBO Evento = (EventoBO)obj;
            sql = "EXEC ModifcarEvento  " + Evento.IdEventos + " ,  '" + Evento.Descripcion + "','" + Evento.Nombre + "' , '" + Evento.Concurrente + "', '" + Evento.Direccion + "', '" + Evento.Longitud + "', '" + Evento.Latitud + "', " + Evento.FechaInicio + ", " + Evento.FechaFin + "";
            return BD.Ejecutar(sql);
        }
        public DataTable BuscarEvento(object obj)
        {
            EventoBO Evento = (EventoBO)obj;
            //sql = "EXEC FiltrarEvento  " + Evento.IdEventos + " ,  '" + Evento.Descripcion + "','" + Evento.Nombre + "' , '" + Evento.Concurrente + "', '" + Evento.Direccion + "', '" + Evento.Longitud + "', '" + Evento.Latitud + "', '" + Evento.FechaInicio.ToShortDateString() + "', '" + Evento.FechaFin.ToShortDateString() + "'";
            sql = "EXEC FiltrarEventoS  " + Evento.IdEventos + " ,  '" + Evento.Descripcion + "','" + Evento.Nombre + "' ," + Evento.Concurrente + ", '" + Evento.Direccion + "', '" + Evento.Longitud + "', '" + Evento.Latitud + "', " + Evento.FechaInicio.ToShortDateString() + ", " + Evento.FechaFin.ToShortDateString() + "";
            return BD.Tabla(sql);
        }
    }
}