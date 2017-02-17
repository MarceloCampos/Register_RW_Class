using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


/* by Marcelo Campos
 * 
 * Classe para ler e gravar no registro do windows
 * 
 * Usa HKEY_CURRENT_USER pois tem acesso direto sem necessidade privilégios administrador
 * 
 * REV 0 - Fev17
 * 
 */


namespace ConsoleApplication1
{
    class Register_RW_Class
    {
        public string Read_Register(string register, string sub_register)
        {
            string rs = string.Empty;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(register + "\\" + sub_register);

            rs = (string)registryKey.GetValue(sub_register);

            return rs;
        }

        public void Write_Register(string register, string sub_register, string value)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(register);

            key.CreateSubKey(sub_register);
            key = key.OpenSubKey(sub_register, true);

            key.SetValue(sub_register, value);

            key.Close();

        }

    }





}
