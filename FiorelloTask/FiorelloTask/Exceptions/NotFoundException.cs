using System;
using System.Collections.Generic;
using System.Text;

namespace FiorelloTask.Exceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
