using System.Runtime.Serialization;

namespace GeoLib.Contracts
{

    [DataContract]                                  // Opt-in serializer :  explicit it
    public class ZipCodeData                        // Data postfix :       WCF standard
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string ZipCode { get; set; }
    }
}
