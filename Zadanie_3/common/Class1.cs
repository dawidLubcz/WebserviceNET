using System;
using System.Runtime.Serialization;


namespace serviceCommon
{
    [DataContract]
    public struct sServiceResp
    {
        [DataMember]
        public int m_iErrCode;
        [DataMember]
        public string m_strMessage;
        [DataMember]
        public double m_dElapsedTime;
    };

    [DataContract]
    public struct sServiceRespExt
    {
        [DataMember]
        public sServiceResp m_sServiceResp;
        [DataMember]
        public CMatrix m_oMatrixRes;
    };

    [DataContract]
    [Serializable]
    public class CMatrix
    {
        [DataMember]
        public int m_iID;
        [DataMember]
        public int X;
        [DataMember]
        public int Y;
        [DataMember]
        public int[] m_aMatrix;

        public CMatrix(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            
            if(X > 0 && Y > 0)
                m_aMatrix = new int[X * Y];
        }
    }
}

