using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  Random Key 16 long:
 *  
 *  IKgyux3Fa4rZo6YD
    xhoLt4AEMj92xTmC
    1j4bHnnUDE1TeCKC
    T3bAWdf7qmSVZmyd
    KNIW8KTuhmz7Jexv
    DVk42NBME9LTQr1D
    iH9uElKgBqe85iYs
    2DBcP2rZTLXoDp6B
    P4Y7jM77DPC2zqhD
    uTnwCBo5ZNWkfyBU
 * 
 */

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string register, sub_register, value = string.Empty;

            Register_RW_Class Register_RW = new Register_RW_Class();

            register = "YellowStone";
            sub_register = "AppKey";
            value = "PU2MKY";

            Register_RW.Write_Register(register, sub_register, value);


            string op = Register_RW.Read_Register(register, sub_register);

            Debug.Print(op);
        }
    }
}
