﻿//******************************************************************************************************
//  PreScanner_FunctionDecl.cs - Gbtc
//
//  Copyright © 2018, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  06/21/2018 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using go2cs.Metadata;
using System;
using System.Collections.Generic;

namespace go2cs
{
    public partial class PreScanner
    {
        private readonly Dictionary<string, VariableInfo> m_variables = new Dictionary<string, VariableInfo>(StringComparer.Ordinal);
        private bool m_hasDefer;
        private bool m_hasPanic;
        private bool m_hasRecover;

        private void EnterMethod()
        {
            m_variables.Clear();
            m_hasDefer = false;
            m_hasPanic = false;
            m_hasRecover = false;
        }

        private FunctionInfo ExitMethod(GolangParser.IFunctionContext context)
        {
            string identifer = context.IDENTIFIER().GetText();

            if (!Signatures.TryGetValue(context.signature(), out Signature signature))
                Signatures.TryGetValue(context.function().signature(), out signature);

            return new FunctionInfo
            {
                Signature = new FunctionSignature
                {
                    Name = identifer,
                    Signature = signature,
                    IsPromoted = false
                },
                Variables = new Dictionary<string, VariableInfo>(m_variables),
                HasDefer = m_hasDefer,
                HasPanic = m_hasPanic,
                HasRecover = m_hasRecover
            };
        }

        public override void EnterFunctionDecl(GolangParser.FunctionDeclContext context)
        {
            EnterMethod();
        }

        public override void EnterMethodDecl(GolangParser.MethodDeclContext context)
        {
            EnterMethod();
        }

        public override void ExitFunctionDecl(GolangParser.FunctionDeclContext context)
        {
            FunctionInfo functionInfo = ExitMethod(context);

            m_functions.Add(GetUniqueIdentifier(m_functions, functionInfo.Signature.Generate()), functionInfo);
        }

        public override void ExitMethodDecl(GolangParser.MethodDeclContext context)
        {
            FunctionInfo functionInfo = ExitMethod(context);

            if (Parameters.TryGetValue(context.receiver().parameters(), out List<ParameterInfo> parameters))
            {
                functionInfo.Signature = new MethodSignature(functionInfo.Signature)
                {
                    ReceiverParameters = parameters.ToArray()
                };
            }

            m_functions.Add(GetUniqueIdentifier(m_functions, functionInfo.Signature.Generate()), functionInfo);
        }

        public override void ExitVarSpec(GolangParser.VarSpecContext context)
        {
            if (Identifiers.TryGetValue(context.identifierList(), out string[] identifiers))
            {
                if (!Types.TryGetValue(context.type(), out TypeInfo typeInfo))
                    typeInfo = TypeInfo.VarType;

                if (ExpressionLists.TryGetValue(context.expressionList(), out string[] expressions))
                {
                    for (int i = 0; i < identifiers.Length; i++)
                    {
                        string identifier = identifiers[i];

                        if (expressions.Length > i)
                        {
                            m_variables.Add(GetUniqueIdentifier(m_variables, identifiers[i]), new VariableInfo
                            {
                                Name = identifier,
                                Type = typeInfo,
                                HeapAllocated = expressions[i]?.StartsWith("&") ?? false
                            });
                        }
                    }
                }
            }
        }

        public override void ExitShortVarDecl(GolangParser.ShortVarDeclContext context)
        {
            if (Identifiers.TryGetValue(context.identifierList(), out string[] identifiers))
            {
                if (ExpressionLists.TryGetValue(context.expressionList(), out string[] expressions))
                {
                    for (int i = 0; i < identifiers.Length; i++)
                    {
                        string identifier = identifiers[i];

                        if (expressions.Length > i)
                        {
                            m_variables.Add(GetUniqueIdentifier(m_variables, identifiers[i]), new VariableInfo
                            {
                                Name = identifier,
                                Type = TypeInfo.VarType,
                                HeapAllocated = expressions[i]?.StartsWith("&") ?? false
                            });
                        }
                    }
                }
            }
        }

        // TODO: Look for cases where a pointer is assigned to an address of a variable,
        //       in these cases the variable should be marked as HeapAllocated

        public override void ExitAssignment(GolangParser.AssignmentContext context)
        {
            if (context.assign_op().GetText() == "=")
            {
                // Check for pointer reference
            }
        }

        public override void ExitDeferStmt(GolangParser.DeferStmtContext context)
        {
            m_hasDefer = true;
        }

        public override void ExitExpressionStmt(GolangParser.ExpressionStmtContext context)
        {
            string expression = context.expression().GetText();

            if (expression.StartsWith("panic("))
                m_hasPanic = true;

            if (expression.StartsWith("recover("))
                m_hasRecover = true;
        }
    }
}