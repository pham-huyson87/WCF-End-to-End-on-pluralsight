using System.Collections.Generic;
using System.ServiceModel;

namespace GeoLib.Contracts
{
    [ServiceContract]
    public  interface IGeoService
    {
        [OperationContract]                                         // ServiceContract is opt-in
        ZipCodeData GetZipInfo(string zip);

        [OperationContract]                                         // The name of operation
        IEnumerable<string> GetStates(bool primaryOnly);            // by defaut is the name of the method.

        [OperationContract(Name = "GetZipsByState")]
        IEnumerable<ZipCodeData> GetZips(string state);             // We have conflicted names, 
                                                                    // if we don't explicit the operation names
        [OperationContract(Name = "GetZipsForRange")]
        IEnumerable<ZipCodeData> GetZips(string zip, int range);
    }
}
