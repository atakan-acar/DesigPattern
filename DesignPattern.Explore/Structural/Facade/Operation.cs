using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Structural.Facade
{
    public class Operation
    {
        private SubOperationA operationA;
        private SubOperationB operationB;

        public Operation()
        {
            operationA = new SubOperationA();
            operationB = new SubOperationB();
        }

        public void StartOperation()
        {
            Console.WriteLine("operation is started"); 
            Thread.Sleep(1000);

            operationA.OperationA();
            Thread.Sleep(2000);

            operationB.OperationB();
        }
    }

    
}
