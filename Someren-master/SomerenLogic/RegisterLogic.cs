using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class RegisterLogic
    {
        private RegisterDAO registerdb;

        public RegisterLogic()
        {
            registerdb = new RegisterDAO();
        }

        public List<Register> RegisterList() 
        {
            List<Register> registers = registerdb.GetAllRegisters();
            return registers;
        }
    }
}
