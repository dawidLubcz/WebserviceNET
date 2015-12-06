using System.ServiceModel;
using serviceCommon;

namespace matrixGen
{
    [ServiceContract]
    public interface IMatrixGen
    {
        [OperationContract]
        sServiceResp generateMatrixM(ref CMatrix a_out_Matrix);

        [OperationContract]
        sServiceRespExt generateMatrixID(int x, int y);

        [OperationContract]
        CMatrix getMatrixFromID(int ID);
    }
}
