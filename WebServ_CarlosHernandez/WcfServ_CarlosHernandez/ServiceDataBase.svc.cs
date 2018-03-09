using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServ_CarlosHernandez
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Serv_Cmmomneycash : IServ_Cmmoneycash
    {


        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        public Correspon ObtenerCorrespon(string Cor_Nombre, int Cor_ID)
        {
            if (Cor_ID == 1)
            {
                return new Correspon();
            }
            else
            {
                return new Correspon() { ErrorCorrespon = "Erro al intetar Obtener la Informacion de la BD los Corresponsales" };

            }
        }


        public Oficinas ObtenerOficinas(string Ofi_nombre, int Ofi_ID)
        {
            if (Ofi_ID == 1)
            {
                return new Oficinas();
            }
            else
            {
                return new Oficinas() { ErrorOficina = "Erro al intetar Obtener la Informacion de la BD los Corresponsales" };
            }
        }

        public Oficinas ObtenerOficinas(string Ofi_nombre)
        {
            throw new NotImplementedException();
        }



    }
}



