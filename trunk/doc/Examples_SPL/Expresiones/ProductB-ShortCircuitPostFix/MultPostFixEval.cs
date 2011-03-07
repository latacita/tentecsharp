﻿using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    public class MultPostFixEval : BinaryOperator, IMultShortEval, IMultPostfix,IExpressionShortCircuitPostFix
    {
        public MultPostFixEval(IExpressionShortCircuitPostFix op1, IExpressionShortCircuitPostFix op2)
        {
            this.mixinBinaryOperatorPosfix = new MultPostfix(op1, op2);
            this.mixinBinaryOperatorShortEval = new MultShortEval(op1, op2);
        } //Constructor AddPostFixEval        
    }
}
