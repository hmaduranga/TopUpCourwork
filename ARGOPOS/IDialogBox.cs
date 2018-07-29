using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS
{
    public interface IDialogBox
    {
         void ShowMessageSucsess(string message);
         void ShowMessageError(string message);
    }
}
