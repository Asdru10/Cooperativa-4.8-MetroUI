using DOM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;

namespace DAO
{
    public class DAOCooperativa
    {

        //private SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=CoopeBarZam; Integrated Security=true");
        private SqlConnection conexion = new SqlConnection("Data Source=ASDRU-PC\\SQLDEVELOPER22; Initial Catalog=CoopeBarZam; Integrated Security=true");



        public DAOCooperativa()
        {
        }

        public void agregarAsociado(Asociado asociado)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();

            command.CommandText = "insert into Asociado (Cedula, Nombre, Primer_Apellido, Segundo_Apellido, Fecha_Nacimiento) values(@Cedula, @Nombre, @Primer_Apellido, @Segundo_Apellido, @Fecha_Nacimiento)";
            command.Parameters.AddWithValue("@Cedula", asociado.Cedula);
            command.Parameters.AddWithValue("@Nombre", asociado.Nombre);
            command.Parameters.AddWithValue("@Primer_Apellido", asociado.Primer_Apellido);
            command.Parameters.AddWithValue("@Segundo_Apellido", asociado.Segundo_Apellido);
            command.Parameters.AddWithValue("@Fecha_Nacimiento", asociado.Fecha_Nacimiento);
            command.ExecuteNonQuery();

            closeConnection();
        }

        public List<Asociado> getAsociados()
        {
            List<Asociado> asociados = new List<Asociado>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);

            openConnection();
            command.CommandText = "select Cedula, Nombre, Primer_Apellido, Segundo_Apellido, Fecha_Nacimiento from Asociado";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Asociado asociado = new Asociado();
                asociado.Cedula = reader.GetInt32(0);
                asociado.Nombre = reader.GetString(1);
                asociado.Primer_Apellido = reader.GetString(2);
                asociado.Segundo_Apellido = reader.GetString(3);
                asociado.Fecha_Nacimiento = reader.GetDateTime(4);
                asociados.Add(asociado);
            }

            closeConnection();
            return asociados;
        }

        public void actualizarAsociado (Asociado asociado)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "update Asociado set Nombre = @Nombre, Primer_Apellido = @Primer_Apellido, Segundo_Apellido = @Segundo_Apellido, Fecha_Nacimiento = @Fecha_Nacimiento where Cedula = @Cedula";
            command.Parameters.AddWithValue("@Nombre", asociado.Nombre);
            command.Parameters.AddWithValue("@Primer_Apellido", asociado.Primer_Apellido);
            command.Parameters.AddWithValue("@Segundo_Apellido", asociado.Segundo_Apellido);
            command.Parameters.AddWithValue("@Fecha_Nacimiento", asociado.Fecha_Nacimiento);
            command.Parameters.AddWithValue("@Cedula", asociado.Cedula);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void eliminarAsociado(int cedula)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "delete from Asociado where Cedula = @Cedula";
            command.Parameters.AddWithValue("@Cedula", cedula);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void agregarEstadoFinancieroMensual(EstadoFinancieroMensual estadoFinancieroMensual)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "insert into Estado_Financiero_Mensual (Periodo, Fecha, Concepto, Monto, Identificador) values(@Periodo, @Fecha, @Concepto, @Monto, @Identificador)";
            command.Parameters.AddWithValue("@Periodo", estadoFinancieroMensual.Periodo);
            command.Parameters.AddWithValue("@Fecha", estadoFinancieroMensual.Fecha);
            command.Parameters.AddWithValue("@Concepto", estadoFinancieroMensual.Concepto);
            command.Parameters.AddWithValue("@Monto", estadoFinancieroMensual.Monto);
            command.Parameters.AddWithValue("@Identificador", estadoFinancieroMensual.Identificador);
            command.ExecuteNonQuery();
            closeConnection();

        }

        public EstadoFinancieroMensual getUltimoEstadoFinancieroMensual ()
        {
            EstadoFinancieroMensual estadoFinancieroMensual = new EstadoFinancieroMensual();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select top 1 ID, Periodo, Fecha, Concepto, Monto, Identificador from Estado_Financiero_Mensual order by ID desc";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                estadoFinancieroMensual.ID = reader.GetInt32(0);
                estadoFinancieroMensual.Periodo = reader.GetInt32(1);
                estadoFinancieroMensual.Fecha = reader.GetDateTime(2);
                estadoFinancieroMensual.Concepto = reader.GetString(3);
                estadoFinancieroMensual.Monto = reader.GetDecimal(4);
                estadoFinancieroMensual.Identificador = reader.GetString(5);
            }
            closeConnection();
            return estadoFinancieroMensual;
        }

        public List<EstadoFinancieroMensual> getEstadosFinancieros()
        {
            List<EstadoFinancieroMensual> estadosFinancieros = new List<EstadoFinancieroMensual>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Periodo, Fecha, Concepto, Monto, Identificador from Estado_Financiero_Mensual";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                EstadoFinancieroMensual estadoFinancieroMensual = new EstadoFinancieroMensual();
                estadoFinancieroMensual.ID = reader.GetInt32(0);
                estadoFinancieroMensual.Periodo = reader.GetInt32(1);
                estadoFinancieroMensual.Fecha = reader.GetDateTime(2);
                estadoFinancieroMensual.Concepto = reader.GetString(3);
                estadoFinancieroMensual.Monto = reader.GetDecimal(4);
                estadoFinancieroMensual.Identificador = reader.GetString(5);
                estadosFinancieros.Add(estadoFinancieroMensual);
            }
            closeConnection();
            return estadosFinancieros;
        }

        public List<EstadoFinancieroMensual> getEstadosFinancierosPorPeriodo(int periodo)
        {
            List<EstadoFinancieroMensual> estadosFinancieros = new List<EstadoFinancieroMensual>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Periodo, Fecha, Concepto, Monto, Identificador from Estado_Financiero_Mensual where Periodo = @Periodo";
            command.Parameters.AddWithValue("@Periodo", periodo);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                EstadoFinancieroMensual estadoFinancieroMensual = new EstadoFinancieroMensual();
                estadoFinancieroMensual.ID = reader.GetInt32(0);
                estadoFinancieroMensual.Periodo = reader.GetInt32(1);
                estadoFinancieroMensual.Fecha = reader.GetDateTime(2);
                estadoFinancieroMensual.Concepto = reader.GetString(3);
                estadoFinancieroMensual.Monto = reader.GetDecimal(4);
                estadoFinancieroMensual.Identificador = reader.GetString(5);
                estadosFinancieros.Add(estadoFinancieroMensual);
            }
            closeConnection();
            return estadosFinancieros;
        }

        public void actualizarEstadoFinancieroMensual(EstadoFinancieroMensual estadoFinancieroMensual)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "update Estado_Financiero_Mensual set Periodo = @Periodo, Fecha = @Fecha, Concepto = @Concepto, Monto = @Monto, Identificador = @Identificador where ID = @ID";
            command.Parameters.AddWithValue("@Periodo", estadoFinancieroMensual.Periodo);
            command.Parameters.AddWithValue("@Fecha", estadoFinancieroMensual.Fecha);
            command.Parameters.AddWithValue("@Concepto", estadoFinancieroMensual.Concepto);
            command.Parameters.AddWithValue("@Monto", estadoFinancieroMensual.Monto);
            command.Parameters.AddWithValue("@Identificador", estadoFinancieroMensual.Identificador);
            command.Parameters.AddWithValue("@ID", estadoFinancieroMensual.ID);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void eliminarEstadoFinancieroMensual(int id)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "delete from Estado_Financiero_Mensual where ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void agregarAporte (Aporte aporte)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "insert into Aporte (Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Detalle, Monto, Fecha, Tipo) values(@Cedula_Asociado, @ID_Estado_Financiero_Mensual, @Periodo_Estado_Financiero_Mensual, @Detalle, @Monto, @Fecha, @Tipo)";
            command.Parameters.AddWithValue("@Cedula_Asociado", aporte.Cedula_Asociado);
            command.Parameters.AddWithValue("@ID_Estado_Financiero_Mensual", aporte.ID_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Periodo_Estado_Financiero_Mensual", aporte.Periodo_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Detalle", aporte.Detalle);
            command.Parameters.AddWithValue("@Monto", aporte.Monto);
            command.Parameters.AddWithValue("@Fecha", aporte.Fecha);
            command.Parameters.AddWithValue("@Tipo", aporte.Tipo);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public List<Aporte> getAportes()
        {
            List<Aporte> aportes = new List<Aporte>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Detalle, Monto, Fecha, Tipo from Aporte";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Aporte aporte = new Aporte();
                aporte.ID = reader.GetInt32(0);
                aporte.Cedula_Asociado = reader.GetInt32(1);
                aporte.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                aporte.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                aporte.Detalle = reader.GetString(4);
                aporte.Monto = reader.GetDecimal(5);
                aporte.Fecha = reader.GetDateTime(6);
                aporte.Tipo = reader.GetString(7);
                aportes.Add(aporte);
            }
            closeConnection();
            return aportes;
        }

        public List<Aporte> getAportesAsociado(int cedula)
        {
            List<Aporte> aportes = new List<Aporte>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Detalle, Monto, Fecha, Tipo from Aporte where Cedula_Asociado = @Cedula";
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Aporte aporte = new Aporte();
                aporte.ID = reader.GetInt32(0);
                aporte.Cedula_Asociado = reader.GetInt32(1);
                aporte.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                aporte.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                aporte.Detalle = reader.GetString(4);
                aporte.Monto = reader.GetDecimal(5);
                aporte.Fecha = reader.GetDateTime(6);
                aporte.Tipo = reader.GetString(7);
                aportes.Add(aporte);
            }
            closeConnection();
            return aportes;
        }

        public List<Aporte> getAportesPorPeriodo(int periodo)
        {
            List<Aporte> aportes = new List<Aporte>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Detalle, Monto, Fecha, Tipo from Aporte where Periodo_Estado_Financiero_Mensual = @Periodo";
            command.Parameters.AddWithValue("@Periodo", periodo);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Aporte aporte = new Aporte();
                aporte.ID = reader.GetInt32(0);
                aporte.Cedula_Asociado = reader.GetInt32(1);
                aporte.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                aporte.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                aporte.Detalle = reader.GetString(4);
                aporte.Monto = reader.GetDecimal(5);
                aporte.Fecha = reader.GetDateTime(6);
                aporte.Tipo = reader.GetString(7);
                aportes.Add(aporte);
            }
            closeConnection();
            return aportes;
        }

        public List<Aporte> getAportesPorAnno(int anno)
        {
            List<Aporte> aportes = new List<Aporte>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Detalle, Monto, Fecha, Tipo from Aporte where year(Fecha) = @Anno";
            command.Parameters.AddWithValue("@Anno", anno);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Aporte aporte = new Aporte();
                aporte.ID = reader.GetInt32(0);
                aporte.Cedula_Asociado = reader.GetInt32(1);
                aporte.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                aporte.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                aporte.Detalle = reader.GetString(4);
                aporte.Monto = reader.GetDecimal(5);
                aporte.Fecha = reader.GetDateTime(6);
                aporte.Tipo = reader.GetString(7);
                aportes.Add(aporte);
            }
            closeConnection();
            return aportes;
        }

        public List<Aporte> getAportesPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Aporte> aportes = new List<Aporte>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Detalle, Monto, Fecha, Tipo from Aporte where Fecha between @FechaInicio and @FechaFin";
            command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@FechaFin", fechaFin);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Aporte aporte = new Aporte();
                aporte.ID = reader.GetInt32(0);
                aporte.Cedula_Asociado = reader.GetInt32(1);
                aporte.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                aporte.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                aporte.Detalle = reader.GetString(4);
                aporte.Monto = reader.GetDecimal(5);
                aporte.Fecha = reader.GetDateTime(6);
                aporte.Tipo = reader.GetString(7);
                aportes.Add(aporte);
            }
            closeConnection();
            return aportes;
        }

        public void actualizarAporte(Aporte aporte)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "update Aporte set Cedula_Asociado = @Cedula_Asociado, ID_Estado_Financiero_Mensual = @ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual = @Periodo_Estado_Financiero_Mensual, Detalle = @Detalle, Monto = @Monto, Fecha = @Fecha, Tipo = @Tipo where ID = @ID";
            command.Parameters.AddWithValue("@Cedula_Asociado", aporte.Cedula_Asociado);
            command.Parameters.AddWithValue("@ID_Estado_Financiero_Mensual", aporte.ID_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Periodo_Estado_Financiero_Mensual", aporte.Periodo_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Detalle", aporte.Detalle);
            command.Parameters.AddWithValue("@Monto", aporte.Monto);
            command.Parameters.AddWithValue("@Fecha", aporte.Fecha);
            command.Parameters.AddWithValue("@Tipo", aporte.Tipo);
            command.Parameters.AddWithValue("@ID", aporte.ID);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void eliminarAporte(int id)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "delete from Aporte where ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void agregarAhorro (Ahorro ahorro)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "insert into Ahorro (Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Monto, Fecha) values(@Cedula_Asociado, @ID_Estado_Financiero_Mensual, @Periodo_Estado_Financiero_Mensual, @Monto, @Fecha)";
            command.Parameters.AddWithValue("@Cedula_Asociado", ahorro.Cedula_Asociado);
            command.Parameters.AddWithValue("@ID_Estado_Financiero_Mensual", ahorro.ID_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Periodo_Estado_Financiero_Mensual", ahorro.Periodo_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Monto", ahorro.Monto);
            command.Parameters.AddWithValue("@Fecha", ahorro.Fecha);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public List<Ahorro> getAhorros()
        {
            List<Ahorro> ahorros = new List<Ahorro>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Monto, Fecha from Ahorro";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ahorro ahorro = new Ahorro();
                ahorro.ID = reader.GetInt32(0);
                ahorro.Cedula_Asociado = reader.GetInt32(1);
                ahorro.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                ahorro.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                ahorro.Monto = reader.GetDecimal(4);
                ahorro.Fecha = reader.GetDateTime(5);
                ahorros.Add(ahorro);
            }
            closeConnection();
            return ahorros;
        }

        public List <Ahorro> getAhorrosAsociado (int cedula)
        {
            List<Ahorro> ahorros = new List<Ahorro>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Monto, Fecha from Ahorro where Cedula_Asociado = @Cedula";
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ahorro ahorro = new Ahorro();
                ahorro.ID = reader.GetInt32(0);
                ahorro.Cedula_Asociado = reader.GetInt32(1);
                ahorro.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                ahorro.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                ahorro.Monto = reader.GetDecimal(4);
                ahorro.Fecha = reader.GetDateTime(5);
                ahorros.Add(ahorro);
            }
            closeConnection();
            return ahorros;
        }

        public List<Ahorro> getAhorrosPorPeriodo(int periodo)
        {
            List<Ahorro> ahorros = new List<Ahorro>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Monto, Fecha from Ahorro where Periodo_Estado_Financiero_Mensual = @Periodo";
            command.Parameters.AddWithValue("@Periodo", periodo);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ahorro ahorro = new Ahorro();
                ahorro.ID = reader.GetInt32(0);
                ahorro.Cedula_Asociado = reader.GetInt32(1);
                ahorro.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                ahorro.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                ahorro.Monto = reader.GetDecimal(4);
                ahorro.Fecha = reader.GetDateTime(5);
                ahorros.Add(ahorro);
            }
            closeConnection();
            return ahorros;
        }

        public List<Ahorro> getAhorrosPorAnno(int anno)
        {
            List<Ahorro> ahorros = new List<Ahorro>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Monto, Fecha from Ahorro where year(Fecha) = @Anno";
            command.Parameters.AddWithValue("@Anno", anno);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ahorro ahorro = new Ahorro();
                ahorro.ID = reader.GetInt32(0);
                ahorro.Cedula_Asociado = reader.GetInt32(1);
                ahorro.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                ahorro.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                ahorro.Monto = reader.GetDecimal(4);
                ahorro.Fecha = reader.GetDateTime(5);
                ahorros.Add(ahorro);
            }
            closeConnection();
            return ahorros;
        }

        public List<Ahorro> getAhorrosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Ahorro> ahorros = new List<Ahorro>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Monto, Fecha from Ahorro where Fecha between @FechaInicio and @FechaFin";
            command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@FechaFin", fechaFin);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ahorro ahorro = new Ahorro();
                ahorro.ID = reader.GetInt32(0);
                ahorro.Cedula_Asociado = reader.GetInt32(1);
                ahorro.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                ahorro.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                ahorro.Monto = reader.GetDecimal(4);
                ahorro.Fecha = reader.GetDateTime(5);
                ahorros.Add(ahorro);
            }
            closeConnection();
            return ahorros;
        }

        public void actualizarAhorro(Ahorro ahorro)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "update Ahorro set Cedula_Asociado = @Cedula_Asociado, ID_Estado_Financiero_Mensual = @ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual = @Periodo_Estado_Financiero_Mensual, Monto = @Monto, Fecha = @Fecha where ID = @ID";
            command.Parameters.AddWithValue("@Cedula_Asociado", ahorro.Cedula_Asociado);
            command.Parameters.AddWithValue("@ID_Estado_Financiero_Mensual", ahorro.ID_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Periodo_Estado_Financiero_Mensual", ahorro.Periodo_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Monto", ahorro.Monto);
            command.Parameters.AddWithValue("@Fecha", ahorro.Fecha);
            command.Parameters.AddWithValue("@ID", ahorro.ID);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void eliminarAhorro(int id)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "delete from Ahorro where ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void agregarCredito (Credito credito)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "insert into Credito (Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado) values(@Cedula_Asociado, @ID_Estado_Financiero_Mensual,@Periodo_Estado_Financiero_Mensual, @Fecha_Desembolso, @Fecha_Final, @Capital_Desembolsado, @Capital_Cancelado, @Saldo_Capital, @Intereses, @Intereses_Cancelados, @Saldo_Intereses, @Saldo_Total, @Cuota_Mensual, @Cuota_Intereses, @Total_Cuota, @Total_Credito, @Estado)";
            command.Parameters.AddWithValue("@Cedula_Asociado", credito.Cedula_Asociado);
            command.Parameters.AddWithValue("@ID_Estado_Financiero_Mensual", credito.ID_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Periodo_Estado_Financiero_Mensual", credito.Periodo_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Fecha_Desembolso", credito.Fecha_Desembolso);
            command.Parameters.AddWithValue("@Fecha_Final", credito.Fecha_Final);
            command.Parameters.AddWithValue("@Capital_Desembolsado", credito.Capital_Desembolsado);
            command.Parameters.AddWithValue("@Capital_Cancelado", credito.Capital_Cancelado);
            command.Parameters.AddWithValue("@Saldo_Capital", credito.Saldo_Capital);
            command.Parameters.AddWithValue("@Intereses", credito.Intereses);
            command.Parameters.AddWithValue("@Intereses_Cancelados", credito.Intereses_Cancelados);
            command.Parameters.AddWithValue("@Saldo_Intereses", credito.Saldo_Intereses);
            command.Parameters.AddWithValue("@Saldo_Total", credito.Saldo_Total);
            command.Parameters.AddWithValue("@Cuota_Mensual", credito.Cuota_Mensual);
            command.Parameters.AddWithValue("@Cuota_Intereses", credito.Cuota_Intereses);
            command.Parameters.AddWithValue("@Total_Cuota", credito.Total_Cuota);
            command.Parameters.AddWithValue("@Total_Credito", credito.Total_Credito);
            command.Parameters.AddWithValue("@Estado", credito.Estado);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public List<Credito> getCreditos()
        {
            List<Credito> creditos = new List<Credito>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Credito credito = new Credito();
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
                creditos.Add(credito);
            }
            closeConnection();
            return creditos;
        }

        public Credito getUltimoCredito()
        {
            Credito credito = new Credito();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select top 1 ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito order by ID desc";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
            }
            closeConnection();
            return credito;
        }

        public List<Credito> getCreditosAsociado(int cedula)
        {
            List<Credito> creditos = new List<Credito>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito where Cedula_Asociado = @Cedula";
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Credito credito = new Credito();
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
                creditos.Add(credito);
            }
            closeConnection();
            return creditos;
        }

        public Credito getCreditoPorID(int id)
        {
            Credito credito = new Credito();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito where ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
            }
            closeConnection();
            return credito;
        }

        public List<Credito> getCreditosPorEstado (string estado)
        {
            List<Credito> creditos = new List<Credito>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito where Estado = @Estado";
            command.Parameters.AddWithValue("@Estado", estado);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Credito credito = new Credito();
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
                creditos.Add(credito);
            }
            closeConnection();
            return creditos;
        }

        public List<Credito> getCreditosActivos()
        {
            List<Credito> creditos = new List<Credito>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito where Estado != 'Cancelado'";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Credito credito = new Credito();
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
                creditos.Add(credito);
            }
            closeConnection();
            return creditos;
        }

        public List<Credito> getCreditoPorPeriodo(int periodo)
        {
            List<Credito> creditos = new List<Credito>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito where Periodo_Estado_Financiero_Mensual = @Periodo";
            command.Parameters.AddWithValue("@Periodo", periodo);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Credito credito = new Credito();
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
                creditos.Add(credito);
            }
            closeConnection();
            return creditos;
        }

        public List<Credito> getCreditosPorAnno(int anno)
        {
            List<Credito> creditos = new List<Credito>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito where year(Fecha_Desembolso) = @Anno";
            command.Parameters.AddWithValue("@Anno", anno);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Credito credito = new Credito();
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
                creditos.Add(credito);
            }
            closeConnection();
            return creditos;
        }

        public List<Credito> getCreditosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Credito> creditos = new List<Credito>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, Cedula_Asociado, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha_Desembolso, Fecha_Final, Capital_Desembolsado, Capital_Cancelado, Saldo_Capital, Intereses, Intereses_Cancelados, Saldo_Intereses, Saldo_Total, Cuota_Mensual, Cuota_Intereses, Total_Cuota, Total_Credito, Estado from Credito where Fecha_Desembolso between @FechaInicio and @FechaFin";
            command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@FechaFin", fechaFin);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Credito credito = new Credito();
                credito.ID = reader.GetInt32(0);
                credito.Cedula_Asociado = reader.GetInt32(1);
                credito.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                credito.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                credito.Fecha_Desembolso = reader.GetDateTime(4);
                credito.Fecha_Final = reader.GetDateTime(5);
                credito.Capital_Desembolsado = reader.GetDecimal(6);
                credito.Capital_Cancelado = reader.GetDecimal(7);
                credito.Saldo_Capital = reader.GetDecimal(8);
                credito.Intereses = reader.GetDecimal(9);
                credito.Intereses_Cancelados = reader.GetDecimal(10);
                credito.Saldo_Intereses = reader.GetDecimal(11);
                credito.Saldo_Total = reader.GetDecimal(12);
                credito.Cuota_Mensual = reader.GetDecimal(13);
                credito.Cuota_Intereses = reader.GetDecimal(14);
                credito.Total_Cuota = reader.GetDecimal(15);
                credito.Total_Credito = reader.GetDecimal(16);
                credito.Estado = reader.GetString(17);
                creditos.Add(credito);
            }
            closeConnection();
            return creditos;
        }

        public void actualizarCredito(Credito credito)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "update Credito set Cedula_Asociado = @Cedula_Asociado, ID_Estado_Financiero_Mensual = @ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual = @Periodo_Estado_Financiero_Mensual, Fecha_Desembolso = @Fecha_Desembolso, Fecha_Final = @Fecha_Final, Capital_Desembolsado = @Capital_Desembolsado, Capital_Cancelado = @Capital_Cancelado, Saldo_Capital = @Saldo_Capital, Intereses = @Intereses, Intereses_Cancelados = @Intereses_Cancelados, Saldo_Intereses = @Saldo_Intereses, Saldo_Total = @Saldo_Total, Cuota_Mensual = @Cuota_Mensual, Cuota_Intereses = @Cuota_Intereses, Total_Cuota = @Total_Cuota, Total_Credito = @Total_Credito, Estado = @Estado where ID = @ID";
            command.Parameters.AddWithValue("@Cedula_Asociado", credito.Cedula_Asociado);
            command.Parameters.AddWithValue("@ID_Estado_Financiero_Mensual", credito.ID_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Periodo_Estado_Financiero_Mensual", credito.Periodo_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Fecha_Desembolso", credito.Fecha_Desembolso);
            command.Parameters.AddWithValue("@Fecha_Final", credito.Fecha_Final);
            command.Parameters.AddWithValue("@Capital_Desembolsado", credito.Capital_Desembolsado);
            command.Parameters.AddWithValue("@Capital_Cancelado", credito.Capital_Cancelado);
            command.Parameters.AddWithValue("@Saldo_Capital", credito.Saldo_Capital);
            command.Parameters.AddWithValue("@Intereses", credito.Intereses);
            command.Parameters.AddWithValue("@Intereses_Cancelados", credito.Intereses_Cancelados);
            command.Parameters.AddWithValue("@Saldo_Intereses", credito.Saldo_Intereses);
            command.Parameters.AddWithValue("@Saldo_Total", credito.Saldo_Total);
            command.Parameters.AddWithValue("@Cuota_Mensual", credito.Cuota_Mensual);
            command.Parameters.AddWithValue("@Cuota_Intereses", credito.Cuota_Intereses);
            command.Parameters.AddWithValue("@Total_Cuota", credito.Total_Cuota);
            command.Parameters.AddWithValue("@Total_Credito", credito.Total_Credito);
            command.Parameters.AddWithValue("@Estado", credito.Estado);
            command.Parameters.AddWithValue("@ID", credito.ID);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void eliminarCredito(int id)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "delete from Credito where ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void actualizarCreditoPorAbono (Credito credito)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "update Credito set Capital_Cancelado = @Capital_Cancelado, Saldo_Capital = @Saldo_Capital, Intereses_Cancelados = @Intereses_Cancelados, Saldo_Intereses = @Saldo_Intereses, Saldo_Total = @Saldo_Total, Cuota_Mensual = @Cuota_Mensual, Cuota_Intereses = @Cuota_Intereses, Total_Cuota = @Total_Cuota, Estado = @Estado where ID = @ID";
            command.Parameters.AddWithValue("@Capital_Cancelado", credito.Capital_Cancelado);
            command.Parameters.AddWithValue("@Saldo_Capital", credito.Saldo_Capital);
            command.Parameters.AddWithValue("@Intereses_Cancelados", credito.Intereses_Cancelados);
            command.Parameters.AddWithValue("@Saldo_Intereses", credito.Saldo_Intereses);
            command.Parameters.AddWithValue("@Saldo_Total", credito.Saldo_Total);
            command.Parameters.AddWithValue("@Cuota_Mensual", credito.Cuota_Mensual);
            command.Parameters.AddWithValue("@Cuota_Intereses", credito.Cuota_Intereses);
            command.Parameters.AddWithValue("@Total_Cuota", credito.Total_Cuota);
            command.Parameters.AddWithValue("@Estado", credito.Estado);
            command.Parameters.AddWithValue("@ID", credito.ID);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void agregarAbono (Abono abono)
        {
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "insert into Abono (ID_Credito, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha, Abono_Capital, Abono_Intereses, Abono_Total) values(@ID_Credito, @ID_Estado_Financiero_Mensual, @Periodo_Estado_Financiero_Mensual, @Fecha, @Abono_Capital, @Abono_Intereses, @Abono_Total)";
            command.Parameters.AddWithValue("@ID_Credito", abono.ID_Credito);
            command.Parameters.AddWithValue("@ID_Estado_Financiero_Mensual", abono.ID_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Periodo_Estado_Financiero_Mensual", abono.Periodo_Estado_Financiero_Mensual);
            command.Parameters.AddWithValue("@Fecha", abono.Fecha);
            command.Parameters.AddWithValue("@Abono_Capital", abono.Abono_Capital);
            command.Parameters.AddWithValue("@Abono_Intereses", abono.Abono_Interes);
            command.Parameters.AddWithValue("@Abono_Total", abono.Abono_Total);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public List<Abono> getAbonos()
        {
            List<Abono> abonos = new List<Abono>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, ID_Credito, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha, Abono_Capital, Abono_Intereses, Abono_Total from Abono";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Abono abono = new Abono();
                abono.ID = reader.GetInt32(0);
                abono.ID_Credito = reader.GetInt32(1);
                abono.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                abono.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                abono.Fecha = reader.GetDateTime(4);
                abono.Abono_Capital = reader.GetDecimal(5);
                abono.Abono_Interes = reader.GetDecimal(6);
                abono.Abono_Total = reader.GetDecimal(7);
                abonos.Add(abono);
            }
            closeConnection();
            return abonos;
        }

        public List<Abono> getAbonosAsociado(int cedula)
        {
            List<Abono> abonos = new List<Abono>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, ID_Credito, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha, Abono_Capital, Abono_Intereses, Abono_Total from Abono where ID_Credito in (select ID from Credito where Cedula_Asociado = @Cedula)";
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Abono abono = new Abono();
                abono.ID = reader.GetInt32(0);
                abono.ID_Credito = reader.GetInt32(1);
                abono.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                abono.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                abono.Fecha = reader.GetDateTime(4);
                abono.Abono_Capital = reader.GetDecimal(5);
                abono.Abono_Interes = reader.GetDecimal(6);
                abono.Abono_Total = reader.GetDecimal(7);
                abonos.Add(abono);
            }
            closeConnection();
            return abonos;
        }

        public List<Abono> getAbonosCredito(int id)
        {
            List<Abono> abonos = new List<Abono>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();

            command.CommandText = "select ID, ID_Credito, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha, Abono_Capital, Abono_Intereses, Abono_Total from Abono where ID_Credito = @ID";
            command.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Abono abono = new Abono();
                abono.ID = reader.GetInt32(0);
                abono.ID_Credito = reader.GetInt32(1);
                abono.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                abono.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                abono.Fecha = reader.GetDateTime(4);
                abono.Abono_Capital = reader.GetDecimal(5);
                abono.Abono_Interes = reader.GetDecimal(6);
                abono.Abono_Total = reader.GetDecimal(7);
                abonos.Add(abono);
            }

            closeConnection();
            return abonos;
        }

        public List<Abono> getAbonosPorPeriodo(int periodo)
        {
            List<Abono> abonos = new List<Abono>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, ID_Credito, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha, Abono_Capital, Abono_Intereses, Abono_Total from Abono where Periodo_Estado_Financiero_Mensual = @Periodo";
            command.Parameters.AddWithValue("@Periodo", periodo);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Abono abono = new Abono();
                abono.ID = reader.GetInt32(0);
                abono.ID_Credito = reader.GetInt32(1);
                abono.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                abono.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                abono.Fecha = reader.GetDateTime(4);
                abono.Abono_Capital = reader.GetDecimal(5);
                abono.Abono_Interes = reader.GetDecimal(6);
                abono.Abono_Total = reader.GetDecimal(7);
                abonos.Add(abono);
            }
            closeConnection();
            return abonos;
        }

        public List<Abono> getAbonosPorAnno(int anno)
        {
            List<Abono> abonos = new List<Abono>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, ID_Credito, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha, Abono_Capital, Abono_Intereses, Abono_Total from Abono where year(Fecha) = @Anno";
            command.Parameters.AddWithValue("@Anno", anno);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Abono abono = new Abono();
                abono.ID = reader.GetInt32(0);
                abono.ID_Credito = reader.GetInt32(1);
                abono.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                abono.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                abono.Fecha = reader.GetDateTime(4);
                abono.Abono_Capital = reader.GetDecimal(5);
                abono.Abono_Interes = reader.GetDecimal(6);
                abono.Abono_Total = reader.GetDecimal(7);
                abonos.Add(abono);
            }
            closeConnection();
            return abonos;
        }

        public List<Abono> getAbonosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Abono> abonos = new List<Abono>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID, ID_Credito, ID_Estado_Financiero_Mensual, Periodo_Estado_Financiero_Mensual, Fecha, Abono_Capital, Abono_Intereses, Abono_Total from Abono where Fecha between @FechaInicio and @FechaFin";
            command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@FechaFin", fechaFin);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Abono abono = new Abono();
                abono.ID = reader.GetInt32(0);
                abono.ID_Credito = reader.GetInt32(1);
                abono.ID_Estado_Financiero_Mensual = reader.GetInt32(2);
                abono.Periodo_Estado_Financiero_Mensual = reader.GetInt32(3);
                abono.Fecha = reader.GetDateTime(4);
                abono.Abono_Capital = reader.GetDecimal(5);
                abono.Abono_Interes = reader.GetDecimal(6);
                abono.Abono_Total = reader.GetDecimal(7);
                abonos.Add(abono);
            }
            closeConnection();
            return abonos;
        }

        public void crearProyeccion(List<ProyeccionPagoCredito> proyeccion)
        {
            string sentence = "INSERT INTO Proyeccion_Pago_Credito (ID_Credito, Fecha, Monto_Abono, Saldo_Total) VALUES (@ID_Credito, @Fecha, @Monto_Abono, @Saldo_Total)";
            SqlCommand command = new SqlCommand(sentence, conexion);
            command.Parameters.Add("@ID_Credito", System.Data.SqlDbType.Int);
            command.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@Monto_Abono", System.Data.SqlDbType.Decimal);
            command.Parameters.Add("@Saldo_Total", System.Data.SqlDbType.Decimal);

            openConnection();

            foreach (ProyeccionPagoCredito proyeccionPagoCredito in proyeccion)
            {
                command.Parameters["@ID_Credito"].Value = proyeccionPagoCredito.ID_Credito;
                command.Parameters["@Fecha"].Value = proyeccionPagoCredito.Fecha;
                command.Parameters["@Monto_Abono"].Value = proyeccionPagoCredito.Monto_Abono;
                command.Parameters["@Saldo_Total"].Value = proyeccionPagoCredito.Saldo_Total;
                command.ExecuteNonQuery();
            }
            closeConnection();
        }

        public void eliminarProyeccion(int id)
        {
            string sentence = "delete from Proyeccion_Pago_Credito where ID_Credito = @ID_Credito";
            SqlCommand command = new SqlCommand(sentence, conexion);
            command.Parameters.AddWithValue("@ID_Credito", id);
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();
        }

        public List<ProyeccionPagoCredito> getProyeccionesCredito(int id)
        {
            List<ProyeccionPagoCredito> proyecciones = new List<ProyeccionPagoCredito>();
            string sentence = "";
            SqlCommand command = new SqlCommand(sentence, conexion);
            openConnection();
            command.CommandText = "select ID_Credito, Fecha, Monto_Abono, Saldo_Total from Proyeccion_Pago_Credito where ID_Credito = @ID_Credito";
            command.Parameters.AddWithValue("@ID_Credito", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ProyeccionPagoCredito proyeccion = new ProyeccionPagoCredito();
                proyeccion.ID_Credito = reader.GetInt32(0);
                proyeccion.Fecha = reader.GetDateTime(1);
                proyeccion.Monto_Abono = reader.GetDecimal(2);
                proyeccion.Saldo_Total = reader.GetDecimal(3);
                proyecciones.Add(proyeccion);
            }
            closeConnection();
            return proyecciones;
        }

        public void actualizarEstadoCreditos(List<Credito> creditos)
        {
            string sentence = "update Credito set Estado = @Estado where ID = @ID";
            SqlCommand command = new SqlCommand(sentence, conexion);
            command.Parameters.Add("@Estado", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@ID", System.Data.SqlDbType.Int);

            openConnection();
            foreach (Credito credito in creditos)
            {
                command.Parameters["@Estado"].Value = credito.Estado;
                command.Parameters["@ID"].Value = credito.ID;
                command.ExecuteNonQuery();
            }
            closeConnection();
        }

        private void openConnection()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        private void closeConnection()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
