﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaPoupaca : ContaBancaria
    {
        public ContaPoupaca(Cliente cliente): base(cliente)
        {
            PercentualRendimento = 0.003M;
        }
        public decimal PercentualRendimento { get; private set; }
    }
}
