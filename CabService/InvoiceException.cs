using System;
using System.Collections.Generic;
using System.Text;

namespace CabService
{
    class InvoiceException : Exception
    {
        public enum InvalidServiceException
        {
            invalidUserId
        }

        private readonly InvalidServiceException invalidServiceException;

        public InvoiceException(InvoiceException exception, string message) : base(message)
        {
            this.invalidServiceException = exception;
        }
    }
}
