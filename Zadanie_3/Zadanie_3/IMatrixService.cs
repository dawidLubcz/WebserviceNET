using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using serviceCommon;

namespace Zadanie_3
{
    [DataContract]
    public enum eParallel
    {
        [EnumMember]
        EP_NO = 0,
        [EnumMember]
        EP_YES
    }

    [ServiceContract]
    public interface IMatrixService
    {

        [OperationContract]
        sServiceResp generateMatrixM(ref CMatrix a_out_Matrix);

        [OperationContract]
        sServiceRespExt generateMatrixID(int x, int y);

        [OperationContract]
        sServiceResp multipleMatrixM(CMatrix a_oMatrix1, CMatrix a_oMatrix2, ref CMatrix a_outMatrixRes, eParallel a_fFlag);

        [OperationContract]
        sServiceRespExt multipleMatrixID(int a_iID1, int a_iID2, eParallel a_fFlag);

    }


    
}
