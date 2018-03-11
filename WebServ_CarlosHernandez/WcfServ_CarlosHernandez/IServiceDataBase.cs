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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServ_Cmmoneycash
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Correponsales> GetCorresponsales();

        [OperationContract]
        List<Oficinas> GetOficinas();

        // TODO: agregue aquí sus operaciones de servicio
    }

   
    [DataContract]
    public class CorresponRespuesta
    {
        public string RespuestaCorrespon { get; set; }
        public string ErrorCorrespon { get; set; }
    }


    [DataContract]

    public class OficinaRespuesta
    {
        public string RespuestaOficina { get; set; }
        public string ErrorOficina { get; set; }
    }

}
