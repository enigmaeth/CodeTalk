﻿//------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.CodeTalk.LanguageService
{
	public class IfBlock : Block
	{
		public IfBlock(string typeName, FileSpan fileLocation, ISyntaxEntity parent, CodeFile currentCodeFile) 
			: base(typeName, fileLocation, parent, currentCodeFile)
		{

		}

		public override SyntaxEntityKind Kind
		{
			get
			{
				return SyntaxEntityKind.If;
			}
		}

		public override void AcceptVisitor(ICodeVisitor visitor)
		{
			visitor?.VisitIf(this);
		}

		public override string SpokenText()
		{
			//todo: change the ILanguage interface.
			return this.Kind.ToString() + " at line " + this.Location.StartLineNumber;
		}

		public override string DisplayText()
		{
			return this.Kind.ToString() + " at line " + this.Location.StartLineNumber;
		}
	}
}