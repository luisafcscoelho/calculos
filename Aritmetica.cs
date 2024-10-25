﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa Operações ariméticas
    /// </summary>
    internal class Aritmetica
    {        
        /// <summary>
        /// Operação Soma
        /// </summary>
        /// <returns>Retorna a soma de dois números</returns>
        public int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação subtração
        /// </summary>
        /// <returns>Retorna a diferença de dois números</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}
