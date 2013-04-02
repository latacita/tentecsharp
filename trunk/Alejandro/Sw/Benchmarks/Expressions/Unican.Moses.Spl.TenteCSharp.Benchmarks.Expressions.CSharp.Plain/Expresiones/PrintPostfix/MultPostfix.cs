﻿using System;
using Expresiones;


namespace Expresiones
{
    public class MultPostfix : IBinaryOperatorPostfix, IMult,IMultPostfix
    {
        IExpressionPostfix exp_izquierda;
        IExpressionPostfix exp_derecha;
        /**
         * Constructor
         * */
        public MultPostfix(IExpressionPostfix izq, IExpressionPostfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }//Constructor
        /**
         * Method to print an expression in Postfix format
         * */
        void IExpressionPostfix.print()
        {
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            Console.Write("* ");
        }//IExpressionPostfix.print
    }//MultPostfix
}//Expresiones