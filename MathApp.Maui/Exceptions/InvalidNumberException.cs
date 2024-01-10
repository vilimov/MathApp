using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Maui.Exceptions;

class InvalidNumberException(string message) : Exception(message)
{
}
