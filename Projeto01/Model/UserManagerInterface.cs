using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal interface InterUserManagerInterface
    {
        UserManager Get(string email, string senha);

        UserManager RecuperaEmail(string email);

        void acoes(UserManager Usuario);
    }
}
