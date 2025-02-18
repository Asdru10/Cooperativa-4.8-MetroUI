using DAO;
using DOM;
using System.Collections.Generic;

namespace BL
{
    public class CooperativaManager
    {
        private DAOCooperativa cooperativa = new DAOCooperativa();

        public CooperativaManager()
        {
        }

        public void agregarAsociado(Asociado asociado)
        {
            cooperativa.agregarAsociado(asociado);
        }

        public List<Asociado> getAsociados()
        {
            return cooperativa.getAsociados();
        }

        public void agregarEstadoFinancieroMensual(EstadoFinancieroMensual estadoFinancieroMensual)
        {
            cooperativa.agregarEstadoFinancieroMensual(estadoFinancieroMensual);
        }

        public EstadoFinancieroMensual getUltimoEstadoFinancieroMensual ()
        {
            return cooperativa.getUltimoEstadoFinancieroMensual();
        }

        public List<EstadoFinancieroMensual> getEstadosFinancieros()
        {
            return cooperativa.getEstadosFinancieros();
        }

        public List<EstadoFinancieroMensual> getEstadosFinancierosPorPeriodo(int periodo)
        {
            return cooperativa.getEstadosFinancierosPorPeriodo(periodo);
        }

        public void agregarAporte(Aporte aporte)
        {
            cooperativa.agregarAporte(aporte);
        }

        public List<Aporte> getAportes()
        {
            return cooperativa.getAportes();
        }

        public List<Aporte> getAportesAsociado(int cedula)
        {
            return cooperativa.getAportesAsociado(cedula);
        }

        public List<Aporte> getAportesPorPeriodo(int periodo)
        {
            return cooperativa.getAportesPorPeriodo(periodo);
        }

        public List<Aporte> getAportesPorAnno(int anno)
        {
            return cooperativa.getAportesPorAnno(anno);
        }

        public void agregarAhorro(Ahorro ahorro)
        {
            cooperativa.agregarAhorro(ahorro);
        }

        public List<Ahorro> getAhorros()
        {
            return cooperativa.getAhorros();
        }

        public List<Ahorro> getAhorrosAsociado(int cedula)
        {
            return cooperativa.getAhorrosAsociado(cedula);
        }

        public List<Ahorro> getAhorrosPorPeriodo(int periodo)
        {
            return cooperativa.getAhorrosPorPeriodo(periodo);
        }

        public List<Ahorro> getAhorrosPorAnno (int anno)
        {
            return cooperativa.getAhorrosPorAnno(anno);
        }

        public void agregarCredito(Credito credito)
        {
            cooperativa.agregarCredito(credito);
        }

        public List<Credito> getCreditos()
        {
            return cooperativa.getCreditos();
        }

        public Credito getUltimoCredito()
        {
            return cooperativa.getUltimoCredito();
        }

        public List<Credito> getCreditosAsociado(int cedula)
        {
            return cooperativa.getCreditosAsociado(cedula);
        }

        public Credito getCreditoPorID(int id)
        {
            return cooperativa.getCreditoPorID(id);
        }

        public List<Credito> getCreditosPorEstado(string estado)
        {
            return cooperativa.getCreditosPorEstado(estado);
        }

        public List<Credito> getCreditosActivos()
        {
            return cooperativa.getCreditosActivos();
        }

        public List<Credito> getCreditosPorPeriodo (int periodo)
        {
            return cooperativa.getCreditoPorPeriodo(periodo);
        }

        public List<Credito> getCreditosPorAnno(int anno)
        {
            return cooperativa.getCreditosPorAnno(anno);
        }

        public void actualizarCreditoPorAbono (Credito credito)
        {
            cooperativa.actualizarCreditoPorAbono(credito);
        }

        public void agregarAbono(Abono abono)
        {
            cooperativa.agregarAbono(abono);
        }

        public List<Abono> getAbonos()
        {
            return cooperativa.getAbonos();
        }

        public List<Abono> getAbonosAsociado(int cedula)
        {
            return cooperativa.getAbonosAsociado(cedula);
        }

        public List<Abono> getAbonosCredito(int id)
        {
            return cooperativa.getAbonosCredito(id);
        }

        public List<Abono> getAbonosPorPeriodo(int periodo)
        {
            return cooperativa.getAbonosPorPeriodo(periodo);
        }

        public List<Abono> getAbonosPorAnno(int anno)
        {
            return cooperativa.getAbonosPorAnno(anno);
        }

        public void crearProyeccion (List<ProyeccionPagoCredito> proyecciones)
        {
            cooperativa.crearProyeccion(proyecciones);
        }

        public void eliminarProyeccion(int id)
        {
            cooperativa.eliminarProyeccion(id);
        }

        public List<ProyeccionPagoCredito> getProyeccionesCredito(int id)
        {
            return cooperativa.getProyeccionesCredito(id);
        }

        public void actualizarEstadoCreditos(List<Credito> creditos)
        {
            cooperativa.actualizarEstadoCreditos(creditos);
        }

    }
}
