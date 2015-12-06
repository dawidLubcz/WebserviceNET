#define PARALLEL

using System;

#if PARALLEL
using System.Threading.Tasks;
#endif

using serviceCommon;

namespace Zadanie_3
{
    public class Service1 : IMatrixService
    {
        MatrixGen.MatrixGenClient m_oMatrixGen = new MatrixGen.MatrixGenClient();

        public sServiceRespExt generateMatrixID(int x, int y)
        {
            sServiceRespExt sReturnValue = m_oMatrixGen.generateMatrixID(x, y);
            return sReturnValue;
        }

        public sServiceResp generateMatrixM(ref CMatrix a_out_Matrix)
        {
            sServiceResp sReturnValue = m_oMatrixGen.generateMatrixM(ref a_out_Matrix);
            return sReturnValue;
        }

        public sServiceRespExt multipleMatrixID(int a_iID1, int a_iID2, eParallel a_fFlag)
        {
            CMatrix oMatrix1 = m_oMatrixGen.getMatrixFromID(a_iID1);
            CMatrix oMatrix2 = m_oMatrixGen.getMatrixFromID(a_iID2);
            CMatrix oMatrixOut = new CMatrix(oMatrix1.X, oMatrix2.Y);

            sServiceResp sTmp = multipleMatrixM(oMatrix1, oMatrix2, ref oMatrixOut, a_fFlag);

            sServiceRespExt sReturnValue = new sServiceRespExt();
            sReturnValue.m_sServiceResp = sTmp;
            sReturnValue.m_oMatrixRes = oMatrixOut;

            return sReturnValue;
        }

        public sServiceResp multipleMatrixM(CMatrix a_oMatrix1, CMatrix a_oMatrix2, ref CMatrix a_outMatrixRes, eParallel a_fFlag)
        {
            sServiceResp sReturnValue = new sServiceResp();
            sReturnValue.m_iErrCode = 1;

            if (eParallel.EP_NO == a_fFlag)
            {
                sReturnValue = multipleMatrixM_NP(a_oMatrix1, a_oMatrix2, ref a_outMatrixRes);
            }
            else
            {
                sReturnValue = multipleMatrixM_P(a_oMatrix1, a_oMatrix2, ref a_outMatrixRes);
            }

            return sReturnValue;
        }

        private sServiceResp multipleMatrixM_P(CMatrix a_oMatrix1, CMatrix a_oMatrix2, ref CMatrix a_outMatrixRes)
        {
            sServiceResp sReturnValue = new sServiceResp();
            sReturnValue.m_iErrCode = 1;

#if PARALLEL
            if (a_oMatrix1.X == a_oMatrix2.Y && a_oMatrix1.X != 0 && a_oMatrix1.Y != 0 && a_oMatrix2.X != 0 && a_oMatrix2.Y != 0)
            {
                long startTick = DateTime.Now.Ticks;

                int[,] _oMatrix1 = fromOneToTwo(a_oMatrix1.m_aMatrix, a_oMatrix1.X, a_oMatrix1.Y);
                int[,] _oMatrix2 = fromOneToTwo(a_oMatrix2.m_aMatrix, a_oMatrix2.X, a_oMatrix2.Y);
                int[,] _oProduct = new int[a_oMatrix1.X, a_oMatrix2.Y];

                Parallel.For(0, a_oMatrix1.X, row =>
                    {
                        for (int col = 0; col < a_oMatrix2.Y; col++)
                        {
                            for (int inner = 0; inner < a_oMatrix1.Y; inner++)
                            {
                                _oProduct[row, col] += _oMatrix1[row, inner] * _oMatrix2[inner, col];
                            }
                        }
                    }
                );
                
                a_outMatrixRes.m_aMatrix = fromTwoToOne(_oProduct, a_oMatrix1.X, a_oMatrix2.Y);

                a_outMatrixRes.X = a_oMatrix1.X;
                a_outMatrixRes.Y = a_oMatrix2.Y;

                long tick = DateTime.Now.Ticks - startTick;

                sReturnValue.m_dElapsedTime = tick;
                sReturnValue.m_strMessage = "OK";
                sReturnValue.m_iErrCode = 0;
            }
            else
            {
                sReturnValue.m_iErrCode = 1;
                sReturnValue.m_strMessage = "I cant multiple these matrixes";
            }
#else
            sReturnValue.m_strMessage = "Parallel disabled";
#endif

            return sReturnValue;
        }

        private sServiceResp multipleMatrixM_NP(CMatrix a_oMatrix1, CMatrix a_oMatrix2, ref CMatrix a_outMatrixRes)
        {
            sServiceResp sReturnValue = new sServiceResp();
            sReturnValue.m_iErrCode = 1;

            if (a_oMatrix1.X == a_oMatrix2.Y && a_oMatrix1.X != 0 && a_oMatrix1.Y != 0 && a_oMatrix2.X != 0 && a_oMatrix2.Y != 0)
            {
                long startTick = DateTime.Now.Ticks;

                int[,] _oMatrix1 = fromOneToTwo(a_oMatrix1.m_aMatrix, a_oMatrix1.X, a_oMatrix1.Y);
                int[,] _oMatrix2 = fromOneToTwo(a_oMatrix2.m_aMatrix, a_oMatrix2.X, a_oMatrix2.Y);
                int[,] _oProduct = new int[a_oMatrix1.X, a_oMatrix2.Y];

                for (int row = 0; row < a_oMatrix1.X; row++)
                {
                    for (int col = 0; col < a_oMatrix2.Y; col++)
                    {
                        for (int inner = 0; inner < a_oMatrix1.Y; inner++)
                        {
                            _oProduct[row, col] += _oMatrix1[row, inner] * _oMatrix2[inner, col];
                        }
                    }
                }

                a_outMatrixRes.m_aMatrix = fromTwoToOne(_oProduct, a_oMatrix1.X, a_oMatrix2.Y);

                a_outMatrixRes.X = a_oMatrix1.X;
                a_outMatrixRes.Y = a_oMatrix2.Y;

                long tick = DateTime.Now.Ticks - startTick;

                sReturnValue.m_dElapsedTime = tick;
                sReturnValue.m_strMessage = "OK";
                sReturnValue.m_iErrCode = 0;
            }
            else
            {
                sReturnValue.m_iErrCode = 1;
                sReturnValue.m_strMessage = "I cant multiple these matrixes";
            }

            return sReturnValue;
        }

        private int[,] fromOneToTwo(int[] a_aMatrix, int X, int Y)
        {
            int[,] _aResultMatrix = new int[X, Y];

            if (0 < X && 0 < Y)
            {
                int index = 0;
                int _X = a_aMatrix.Length / Y;
                int _Y = a_aMatrix.Length / X;

                for (int i = 0; i < _X; i++)
                {
                    for (int j = 0; j < _Y; j++)
                    {
                        _aResultMatrix[i, j] = a_aMatrix[index];
                        index++;
                    }
                }
            }
            return _aResultMatrix;
        }

        private int[] fromTwoToOne(int[,] a_aMatrix, int X, int Y)
        {
            int[] _aResultMatrix = new int[X * Y];

            if (0 < X && 0 < Y)
            {
                int index = 0;
                for (int i = 0; i < X; i++)
                {
                    for (int j = 0; j < Y; j++)
                    {
                        _aResultMatrix[index] = a_aMatrix[i, j];
                        index++;
                    }
                }
            }
            return _aResultMatrix;
        }
    }
}
