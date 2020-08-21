﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quotes.Models.ReturnedModels
{
    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
    public class Errors
    {
        List<Error> errors;
    }
}
