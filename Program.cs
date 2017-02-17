using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  Random Key 16 long:
 *  
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

            register = "HamRadio";
            sub_register = "AppKey";
            value = "PU2MKY";

            Register_RW.Write_Register(register, sub_register, value);


            string op = Register_RW.Read_Register(register, sub_register);

            Debug.Print(op);
        }
    }
}
