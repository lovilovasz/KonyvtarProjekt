using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Pult_Client.Models
{
    public class CheckName
    {

        public bool CheckNameTest(string name)
        {
            bool helyes = false;

            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsLetter(name[i]) || name[i] == ' ')
                {
                    helyes =  true;
                }
                else
                {
                    helyes = false;
                    break;
                }
            }
            return helyes;
            
        }
    }
}
