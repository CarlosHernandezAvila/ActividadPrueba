using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace WcfServ_CarlosHernandez
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Serv_Cmmomneycash : IServ_Cmmoneycash
    {


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Correponsales> GetCorresponsales()
        {
            using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("select cor_corresponsal_id, cor_nombre from cmmoneycash.dbo.CORRESPONSALES", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Correponsales> Lista_Corresp = new List<Correponsales>();
                Correponsales corresp;

                while (dr.Read())
                {
                    corresp = new Correponsales();
                    corresp.cor_corresponsal_id = Convert.ToInt32(dr[0]);
                    corresp.cor_nombre = dr[1].ToString();
                    Lista_Corresp.Add(corresp);

                }
                cn.Close();
                return Lista_Corresp;



            }
        }


        public List<Oficinas> GetOficinas()
        {
            using (SqlConnection cn2 = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ToString()))
            {
                
                SqlCommand cmd = new SqlCommand("select OFI_CORRESPONSAL_ID, OFI_NOMBRE from oficinas", cn2);
                cn2.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Oficinas> Lista_Oficina = new List<Oficinas>();
                Oficinas oficinas;

                while (dr.Read())
                {
                    oficinas = new Oficinas();
                    oficinas.Ofi_Corresponsal_id = Convert.ToInt32(dr[0]);
                    oficinas.Ofi_Nombre = dr[1].ToString();
                    Lista_Oficina.Add(oficinas);

                }
                cn2.Close();
                return Lista_Oficina;
            }
        }


    }
}



