﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloRRHH;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorRRHH
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        //9959-18-5201 Angel Chacón
        //Muestra todos los empleados disponibles para asignarle al concepto
        public DataTable llenarTblDatosEmpleados(string IdConcepto)
        {
            OdbcDataAdapter dt = sn.llenarTblDatosEmpleados(IdConcepto);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //9959-18-5201 Angel Chacón
        ///Muestra todos los saldos asignados a los empleados
        public DataTable tblSaldoEmpleados()
        {
            OdbcDataAdapter dt = sn.tblSaldoEmpleados();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //9959-18-5201 Angel Chacón
        //Muestra todos los empleados asignados al concepto
        public DataTable llenarTblEmpleadosAsignadosConcepto(string tablaempleados, string IdConcepto)
        {
            OdbcDataAdapter dt = sn.llenarTblEmpleadosAsignadosConcepto(tablaempleados, IdConcepto);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //9959-18-5201 Angel Chacón
        public DataTable DatosConcepto(string IdConcepto)
        {
            //Obtiene todos los datos del concepto al que se le van a asignar empleados
            OdbcDataAdapter dt = sn.DatosConcepto(IdConcepto);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //9959-18-5201 Angel Chacón
        //Asinar un empleado al concepto
        public void AsignarEmpleados(string tabla3, string valor1, string valor2)
        {
            sn.AsignarEmpleados(tabla3, valor1, valor2);
        }

        //9959-18-5201 Angel Chacón
        //Asigna todos los empleados al concepto
        public void AsignarATodosLosEmpleados(string tabla3, string valor1)
        {
            sn.AsignarATodosLosEmpleados(tabla3, valor1);
        }

        //9959-18-5201 Angel Chacón
        //Se elima a un empleado asignado al concepto
        public void EliminarUnEmpleadoAsignado(string tabla3, string valor1, string valor2)
        {
            sn.EliminarUnEmpleadoAsignado(tabla3, valor1, valor2);
        }

        //9959-18-5201 Angel Chacón
        //Se eliminan todos los empleados asignados al concepto
        public void EliminarTodasLasAsignacionesEmpleados(string tabla3, string valor1)
        {
            sn.EliminarTodasLasAsignacionesEmpleados(tabla3, valor1);
        }

        //Angel Chacón 9959-18-5201 
        //Funcion para mostrar id en el combobox de los conceptos existentes
        public OdbcDataReader IdConcepto(string nombreA)
        {
            return sn.IdConcepto(nombreA);
        }

        //Angel Chacón 9959-18-5201 
        //funcion para mostrar id en el combobox de los empleados existentes
        public OdbcDataReader IdEmpleado(string nombreE)
        {
            return sn.IdEmpleado(nombreE);
        }

        //Angel Chacón 9959-18-5201 
        //Funcion para obtener el nombre de los conceptos creados en el combobox
        public OdbcDataReader llenarcbxConcepto()
        {
            return sn.llenarcbxConcepto();
        }

        //Angel Chacón 9959-18-5201 
        //Muestra todos los empleados que no tengan asignado un monto o saldo
        public OdbcDataReader llenarcbxEmpleados(string idConcepto)
        {
            return sn.llenarcbxEmpleados(idConcepto);
        }

        //Danny Saldaña 0901-18-18686
        public void UnicamenteUnicamenteagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            sn.Unicamenteagregartodo(tabla3, valor1, valor2, tabla2);
        }

        //Primer consulta de todos los registros del historial ISR
        public DataTable llenarDGVTodosReg()//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = sn.llenarDGVTodosReg();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Segunda consulta de todos los registros del historial ISR por año
        public DataTable llenarDGVRegMes(string anio)//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = sn.llenarDGVRegMes(anio);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Tercer consulta de todos los registros del historial ISR por mes
        public DataTable llenarDGVTodosRegAnio(string anio)//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = sn.llenarDGVTodosRegAnio(anio);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Cuarta consulta de todos los registros detalles del historial ISR por ID Registrado
        public DataTable llenarDGVRegDetalle(string Id)//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = sn.llenarDGVRegDetalle(Id);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }








        public DataTable FormulasLlenarComboTablas()
        {
            OdbcDataAdapter dt = sn.FormulasLlenarComboTablas();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable FormulasLlenarComboCampos(String tabla)
        {
            OdbcDataAdapter dt = sn.FormulasLlenarComboCampos(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable FormulasTodosLosConceptos()
        {
            OdbcDataAdapter dt = sn.FormulasTodosLosConceptos();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void FormulasAsignarConcepto(string formula, string pkIdConcepto)
        {
            sn.FormulasAsignarConcepto(formula, pkIdConcepto);
        }







        public void GuradarSentenciaSql(string valor1, string valor2)
        {
            sn.GuradarSentenciaSql(valor1, valor2);
        }

        public void GuradarFormula(string valor1, string valor2)
        {
            sn.GuradarFormula(valor1, valor2);
        }

        //Heydi Quemé 9959-18-5335
        public void generarNomina(string fechaInicio, string fechaFin)
        {
            //sn.generarNomina(fechaInicio, fechaFin);
        }
        public DataTable EncabezadoNominaControlador(string tabla, string sentencia)
        {
            DataTable encabazado = new DataTable();
            try
            {
                encabazado = sn.EncabezadoNominaSetencias(tabla, sentencia);
            }
            catch (Exception ex) { MessageBox.Show("Error en obtener encabezado Nomina capa Controlador " + ex); }
            return (encabazado);
        }
        public int idSiguienteDeNuevoIngreso(string tabla, string campo)
        {

            int entero = sn.idSiguienteDeNuevoIngreso(tabla, campo);

            return entero;
        }
        public DataTable calculoConcepto(int idConcepto, int IdEmpleado, string IdPeriodo)
        {
            DataTable table = new DataTable();
            try
            {
                table = sn.calculoConceptoSentencias(idConcepto, IdEmpleado, IdPeriodo);
            }
            catch (Exception ex) { MessageBox.Show("Error en obtener calculo Nomina Capa Controlador " + ex); }
            return (table);
        }
        public int cantidadTabla(string tabla)
        {
            int CT = sn.cantidadTB(tabla);
            return (CT);
        }

        public Boolean validarRelacion(int idEmpleado, int idConcepto, string tabla)
        {
            Boolean respuesta = sn.validarRelacion(idEmpleado, idConcepto, tabla);
            return respuesta;
        }
        public Boolean validarEfecto(int idConcepto)
        {
            Boolean respuesta = sn.validarEfecto(idConcepto);
            return respuesta;
        }

        public void guardarNominaEncabezado(string id, string fechai, string fechaf, string totalp, string totald, string total, string estado)
        {
            sn.guardarNominaEncabezado(id, fechai, fechaf, totalp, totald, total, estado);
        }
        public void guardarNominaDetalleBD(string nomina_e, string empleado, string concepto, string sueldob, string calculo, string liquido, string estado)
        {
            sn.guardarNominaDetalleBD(nomina_e, empleado, concepto, sueldob, calculo, liquido, estado);
        }
        public OdbcDataReader llenarCombo(string tabla)
        {
            return sn.llenarCombo(tabla);
        }
        public string optnerIDEmpleado(string nombre)
        {
            string respuesta = sn.optnerIDEmpleado(nombre);
            return respuesta;
        }

        public DataTable consultarPeriodo(string fechainicio, string fechafin)
        {
            DataTable table = new DataTable();
            try
            {
                OdbcDataAdapter dt = sn.consultarPeriodo(fechainicio, fechafin);
                dt.Fill(table);
            }
            catch (Exception ex) { MessageBox.Show("Error en obtener información del periodo Capa Controlador " + ex); }
            return (table);
        }
        public DataTable consultarDetalles(string idnomina)
        {
            DataTable table = new DataTable();
            try
            {
                table = sn.consultarDetalles(idnomina);
            }
            catch (Exception ex) { MessageBox.Show("Error en obtener información del periodo Capa Controlador " + ex); }
            return (table);
        }
        //Foto Empleado Heydi Quemé 9959-18-5335 Kevin Flores 9959-18-17632
        public void insertaNuevaFoto(string id, byte[] foto)
        {
            sn.insertaNuevaFoto(id, foto);
        }
        public void insertaFoto(string id, byte[] foto)
        {
            sn.insertaFoto(id, foto);
        }
        public byte[] obtenerByte(string id)
        {
            byte[] imagen = sn.obtenerByte(id);
            return imagen;
        }

        public DataTable calculoConceptoSentenciasFinal(int idConcepto, int idEmpleado, string IdPeriodo)
        {
            DataTable table = new DataTable();
            table = sn.calculoConceptoSentenciasFinal(idConcepto, idEmpleado, IdPeriodo);

            return table;
        }

        //HEYDI QUEME FRMVACACIONES
        public DataTable llenarDGVDisponibles(string IdPeriodo)
        {
            OdbcDataAdapter dt = sn.llenarDGVDisponibles(IdPeriodo);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void AsignarVacaciones(string tabla, string id, string valor2, string diasd, string diasg, string Estado)
        {
            sn.AsignarVacaciones(tabla, id, valor2, diasd, diasg, Estado);
        }

        public void guardarVacacionesEncabezado(string tabla, string id, string periodo, string estado)
        {
            sn.guardarVacacionesEncabezado(tabla, id, periodo, estado);
        }
        public DataTable llenarDGVAsignados(string IdPeriodo)
        {
            OdbcDataAdapter dt = sn.llenarDGVAsignados(IdPeriodo);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void limpiarRegistros(string tabla, string encabezado)
        {
            sn.limpiarRegistros(tabla, encabezado);
        }

        public Boolean ComprobarEncabezado(string tabla, string encabezado, string periodo)
        {
            Boolean existente = sn.ComprobarEncabezado(tabla, encabezado, periodo);
            return existente;
        }

        public void eliminarRegistroVacaciones(string tabla, string id, string empleado)
        {
            sn.eliminarRegistroVacaciones(tabla, id, empleado);
        }
        public Boolean ComprobarDetalles(string tabla, string encabezado)
        {
            Boolean existente = sn.ComprobarDetalles(tabla, encabezado);
            return existente;
        }

        public void eliminarEncabezado(string tabla, string id, string periodo)
        {
            sn.eliminarEncabezado(tabla, id, periodo);
        }
        public DataTable llenarDGVRegistrados()
        {
            OdbcDataAdapter dt = sn.llenarDGVRegistrados();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public OdbcDataReader llenarcbxPeriodo()
        {
            return sn.llenarcbxPeriodo();
        }
        public OdbcDataReader IdPeriodo(string nombreA)
        {
            return sn.IdPeriodo(nombreA);
        }
        public DataTable llenarDGVSeleccion(string IdPeriodo)
        {
            OdbcDataAdapter dt = sn.llenarDGVSeleccion(IdPeriodo);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public OdbcDataReader IdEncabezado(string nombreA)
        {
            return sn.IdEncabezado(nombreA);
        }
        public void ModificarVacaciones(string encabezado, string celdas, string dias)
        {
            {
                sn.ModificarVacaciones(encabezado, celdas, dias);
            }
        }

        public DataTable ConsultaTablasPoliza1(string id, string fecha)
        {
            OdbcDataAdapter dt = sn.ConsultaTablasPoliza1(id, fecha);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable ConsultaTablasPoliza2(string id, string fecha)
        {
            OdbcDataAdapter dt = sn.ConsultaTablasPoliza2(id, fecha);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable ConsultaTablasPoliza3(string id, string fecha)
        {
            OdbcDataAdapter dt = sn.ConsultaTablasPoliza3(id, fecha);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void Guradarpoliza(string valor1, string valor2, string valor3)
        {
            sn.Guradarpoliza(valor1, valor2, valor3);
        }

        public void Borrarpoliza(string valor3)
        {
            sn.Borrarpoliza(valor3);
        }

        public DataTable CantidadConceptosPlanilla(string id)
        {
            OdbcDataAdapter dt = sn.CantidadConceptosPlanilla(id);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable MostarPoliza(string id, string fecha)
        {
            OdbcDataAdapter dt = sn.MostarPoliza(id, fecha);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable ObtenerSalarioPoliza(string id, string fecha)
        {
            OdbcDataAdapter dt = sn.ObtenerSalarioPoliza(id, fecha);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable obtenerCuentaPagoPlanilla()
        {
            OdbcDataAdapter dt = sn.obtenerCuentaPagoPlanilla();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable obtenerGastoPlanilla()
        {
            OdbcDataAdapter dt = sn.obtenerGastoPlanilla();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable obtenerCuentaPasivoPlanilla()
        {
            OdbcDataAdapter dt = sn.obtenerCuentaPasivoPlanilla();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable obtenerSalarioPlanilla()
        {
            OdbcDataAdapter dt = sn.obtenerSalarioPlanilla();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void ActualizarCodigosCuentas(string valor1, string valor2, string valor3, string valor4)
        {
            sn.ActualizarCodigosCuentas(valor1, valor2, valor3, valor4);
        }

        public DataTable ConsultaSentenciaSql(string valor1)
        {
            OdbcDataAdapter dt = sn.ConsultaSentenciaSql(valor1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Liquidacion Empleado

        public void formatoMoneda(TextBox txt)
        {
            sn.formatoMoneda(txt);
        }
        public DataTable consultarDetallesEmpleado(string idEmpleado)
        {
            DataTable table = new DataTable();
            table = sn.consultarDetallesEmpleado(idEmpleado);
            return table;
        }
        public string BuscaDato(string tabla, string campo, string id, string buscarid)
        {
            string dato = sn.BuscaDato(tabla, campo, id, buscarid);
            return dato;
        }

        // Cálculo Indemnización

        public int calculoDiasLaborados(string contratacion, string despido)
        {
            int valor = sn.calculoDiasLaborados(contratacion, despido);
            return valor;
        }
        public int calculoDiasLaboradosAñoCursado(string despido)
        {
            int valor = sn.calculoDiasLaboradosAñoCursado(despido);
            return valor;
        }
        public int calculoDiasLaboradosaguinaldo(string despido)
        {
            int valor = sn.calculoDiasLaboradosaguinaldo(despido);
            return valor;
        }
        public int calculoDiasLaboradosBono14(string despido)
        {
            int valor = sn.calculoDiasLaboradosBono14(despido);
            return valor;
        }
        public int calculoDiasBonoIncentivo(string despido)
        {
            int valor = sn.calculoDiasBonoIncentivo(despido);
            return valor;
        }
        public void GuardarEncabezadoLiquidacion(string tabla, string id, string fecha, string estado)
        {
            sn.GuardarEncabezadoLiquidacion(tabla, id, fecha, estado);
        }
        public void guardarLiquidacionDetalleBD(string tabla, string liquidacion_e, string empleado, double sueldo, string UltimasVacaciones, double salarioPromedio, double bonificacionIncentivo, double horaextra, string observaciones, double indemnizaciones,double aguinaldoT, double bono14T, double bonificacionT, double vacacionesT, double comisionesT, double horasExtraT, double totalPercibido)
        {
            sn.guardarLiquidacionDetalleBD(tabla, liquidacion_e, empleado, sueldo, UltimasVacaciones, salarioPromedio, bonificacionIncentivo, horaextra, observaciones, indemnizaciones,aguinaldoT, bono14T, bonificacionT, vacacionesT, comisionesT, horasExtraT, totalPercibido);
        }
        public DataTable llenalistaliquidacion()
        {
            DataTable table = new DataTable();
            table = sn.llenalistaliquidacion();
            return table;
        }
        public DataTable consultarDetallesliquidacion(string idliquidacion)
        {
            DataTable table = new DataTable();
            table = sn.consultarDetallesliquidacion(idliquidacion);
            return table;
        }

    }
}
