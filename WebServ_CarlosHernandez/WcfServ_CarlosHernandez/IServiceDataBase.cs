using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServ_CarlosHernandez
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServ_Cmmoneycash
    {


        [OperationContract]
        Correspon ObtenerCorrespon(string Cor_Nombre, int Cor_ID);
        [OperationContract]
        Oficinas ObtenerOficinas(string Ofi_nombre, int Ofi_ID);

        // TODO: agregue aquí sus operaciones de servicio
    }


    [DataContract]
    public class Correspon : CorresponRespuesta

    {
        [DataMember]
        public string Cor_nombre { get; set; }
        [DataMember]
        public int Cor_ID { get; set; }

    }

    [DataContract]
    public class CorresponRespuesta
    {
        public string RespuestaCorrespon { get; set; }
        public string ErrorCorrespon { get; set; }
    }


    [DataContract]

    public class Oficinas : OficinaRespuesta
    {
        [DataMember]
        public string Ofi_nombre { get; set; }
        [DataMember]
        public int Ofi_ID { get; set; }

    }

    [DataContract]

    public class OficinaRespuesta
    {
        public string RespuestaOficina { get; set; }
        public string ErrorOficina { get; set; }
    }

}
