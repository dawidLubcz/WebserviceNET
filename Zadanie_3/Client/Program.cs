using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const int taskNum = 10;

            MatrixServiceClient oService = new MatrixServiceClient();
            
            Task<sServiceRespExt>[] tasksArray = new Task<sServiceRespExt>[taskNum];
            for (int i=0; i < taskNum; i++)
            {              
                tasksArray[i] = oService.generateMatrixIDAsync(30, 30);
                Console.WriteLine("Start {0} task", i);                
            }
            Console.WriteLine("Generation in progress...");
            Task<sServiceRespExt>.WaitAll(tasksArray);
            Console.WriteLine("Generation is finished");

            List<Task> tasks = new List<Task>();
            for (int matrix = 0; matrix < taskNum - 1; matrix++)
            {
                int matrixA = tasksArray[matrix].Result.m_oMatrixRes.m_iID;
                int matrixB = tasksArray[matrix + 1].Result.m_oMatrixRes.m_iID;

                Console.WriteLine("Stating multiplication of {0} and  {1}", matrixA, matrixB);

                var multiplicationTask = oService.multipleMatrixIDAsync(matrixA, matrixB, eParallel.EP_YES);
                multiplicationTask.ContinueWith((taskResult) =>
                {
                    sServiceRespExt response = taskResult.Result;
                    Console.WriteLine("{0} with elapsed tics: {1}", response.m_sServiceResp.m_strMessage, response.m_sServiceResp.m_dElapsedTime);

                });

                tasks.Add(multiplicationTask);
            }

            Console.WriteLine("Waiting to complete all multiplications");
            var taskArray = tasks.ToArray();
            Task.WaitAll(taskArray);

            CMatrix oMatrix = createCMatrix(30, 30);
            CMatrix oMatrix2 = createCMatrix(30, 30);
            sServiceResp result = oService.generateMatrixM(ref oMatrix);
            sServiceResp result2 = oService.generateMatrixM(ref oMatrix2);
            CMatrix oMatrix3 = createCMatrix(30, 30);
            sServiceResp result3 = oService.multipleMatrixM(oMatrix, oMatrix2, ref oMatrix3, eParallel.EP_YES);
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Elapsed time tics: " + result3.m_dElapsedTime.ToString());
            printCMatrix(oMatrix3);

            Console.Read();
        }

        private static CMatrix createCMatrix(int X, int Y)
        {
            CMatrix oMatrix = new ServiceReference1.CMatrix();
            oMatrix.X = X;
            oMatrix.Y = Y;
            oMatrix.m_aMatrix = new int[X * Y];

            return oMatrix;
        }

        private static void printCMatrix(CMatrix a_oMatrix)
        {
            int index = 0;
            for (int i = 0; i < a_oMatrix.X; i++)
            {
                for (int j = 0; j < a_oMatrix.Y; j++)
                {
                    Console.Write(a_oMatrix.m_aMatrix[index]);
                    index++;
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
        }
    }
}
