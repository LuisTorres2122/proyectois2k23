using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CxPModelo
{
    public class JSentencia
    {
        Conexion con = new Conexion();


       /* public OdbcDataAdapter tablaProveedores( string tabla)
        {
            string sql = "select pk_id_proveedor as Id_Proveedor ,nombre_proveedor as Nombre ,direccion_proveedor as Dirección ,telefono_proveedor as Teléfono, correo_proveedor as Correo, rubro_proveedor as rubro," +
                "saldo_mes_anterior_balanceproveedores as Saldo_Anterior, saldo_actual_proveedor as Saldo_Actual, cargo_del_mes_proveedor as Cargo, abonos_del_mes_proveedor as Abono, cargos_acumulados_proveedor as Cargo_Acumulado, abonos_acumulados_proveedors as Abono_Acumulado, estado_proveedor as Estado  from tbl_proveedor";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;

        } */
    }
}
