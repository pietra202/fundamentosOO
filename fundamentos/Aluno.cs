﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos
{
    public class Aluno
    {
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }


        public DateOnly Nascimento { get; set; }
    }
}
