﻿using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define AddPosfix
     * */
    public class AddPosfix : IBinaryOperatorPosfix, IAdd, IAddPosfix
    {
        IExpressionPosfix exp_izquierda;
        IExpressionPosfix exp_derecha;
        /**
         * Constructor
         * */
        public AddPosfix(IExpressionPosfix izq, IExpressionPosfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que imprime en formato posfijo
         * */
        public void print()
        {
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            Console.Write(" ");
            Console.Write("+ ");
            
        }
    }
}