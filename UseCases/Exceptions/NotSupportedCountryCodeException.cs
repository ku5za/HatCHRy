using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.Exceptions
{
    public class NotSupportedCountryCodeException : KeyNotFoundException
    {
        public NotSupportedCountryCodeException()
            : base("Provided country code is not supported. Please check your request.")
        { }
    }
}
