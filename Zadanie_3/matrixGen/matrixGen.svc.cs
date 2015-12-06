using System;
using System.Collections.Generic;
using System.Diagnostics;
using serviceCommon;

namespace matrixGen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CMatrixGen" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CMatrixGen.svc or CMatrixGen.svc.cs at the Solution Explorer and start debugging.
    public class CMatrixGen : IMatrixGen
    {
        private static List<CMatrix> m_oCMatrixList = new List<CMatrix>();

        public CMatrix getMatrixFromID(int ID)
        {
            CMatrix _oMatrix = new CMatrix(0,0);

            foreach (CMatrix item in m_oCMatrixList)
            {
                if (ID == item.m_iID)
                {
                    _oMatrix = item;
                }
            }
            return _oMatrix;
        }

        public sServiceRespExt generateMatrixID(int x, int y)
        {
            sServiceRespExt sReturnValue = new sServiceRespExt();

            if (x > 0 && y > 0)
            {
                CMatrix _oMatrix = new CMatrix(x,y);

                sServiceResp sTmp = generateMatrixM(ref _oMatrix);
                sReturnValue.m_sServiceResp = sTmp;
                sReturnValue.m_oMatrixRes = _oMatrix;
            }

            return sReturnValue;
        }

        public sServiceResp generateMatrixM(ref CMatrix a_out_Matrix)
        {
            sServiceResp sReturnValue;
            sReturnValue.m_iErrCode = 1;
            sReturnValue.m_strMessage = "Not implemented";
            sReturnValue.m_dElapsedTime = 0;

            if (0 < a_out_Matrix.X && 0 < a_out_Matrix.Y)
            {
                Stopwatch generateTime = Stopwatch.StartNew();
                Random _oRnd = new Random();
                for (int i = 0; i < a_out_Matrix.X * a_out_Matrix.Y; ++i)
                    a_out_Matrix.m_aMatrix[i] = _oRnd.Next(0, 100);

                a_out_Matrix.m_iID = findId();
                m_oCMatrixList.Add(a_out_Matrix);

                generateTime.Stop();
                sReturnValue.m_dElapsedTime = Math.Max(0, generateTime.ElapsedMilliseconds); ;
                sReturnValue.m_strMessage = "OK";
                sReturnValue.m_iErrCode = 0;
            }
            else
            {
                sReturnValue.m_strMessage = "Bad parameter!";
            }

            return sReturnValue;
        }

        private int findId()
        {
            int _ID = 0;

            for (int i = 0; i < 100; i++)
            {
                bool fNotExist = true;
                foreach (CMatrix item in m_oCMatrixList)
                {
                    if (i == item.m_iID)
                    {
                        fNotExist = false;
                    }
                }

                if (fNotExist == true)
                {
                    _ID = i;
                    break;
                }
            }

            return _ID;
        }
    }
}
