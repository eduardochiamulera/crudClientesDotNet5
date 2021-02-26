using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace CrudClientes.Domain
{
    public class Error
    {
        public string DataField { get; set; }
        public string Message { get; set; }
        public string ReferenceId { get; set; }

        [JsonIgnore]
        public NotificationType Type { get; set; }

        [JsonProperty("type")]
        public string TypeRest
        {
            get { return (Type.ToString().ToLower()); }
            set { Type = (NotificationType)Enum.Parse(typeof(NotificationType), value); }
        }

        public Error(string pMessage, string dataFieldId = "", string id = "", NotificationType type = NotificationType.Error)
        {
            DataField = dataFieldId;
            Message = pMessage;
            ReferenceId = id;
            Type = type;
        }

        public override string ToString() => Message;
    }
}