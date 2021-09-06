﻿using DefaceCompiler.Compiler.ASTGen.AST.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaceCompiler.Compiler.ASTGen.AST.Statements
{
    /// <summary>
    /// C# return statement (E.g 'return 3;')
    /// </summary>
    class ReturnStatement : Statement
    {
        public Expression Value { get; set; }
    }
}
