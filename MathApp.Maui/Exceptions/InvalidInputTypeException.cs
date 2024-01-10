using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Maui.Exceptions;

class InvalidInputTypeException(string message) : Exception(message)
{
}
