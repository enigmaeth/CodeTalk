//------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//------------------------------------------------------------------------------

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.CodeTalk.LanguageService.Languages.Tests
{
    /// <summary>This class contains parameterized unit tests for Python</summary>
    [TestClass]
    [PexClass(typeof(Python))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PythonTest
    {

        [TestMethod]
        public void ClassesTest()
        {
            var targuet = new Python();
            targuet.Parse(System.IO.File.ReadAllText(@".\Programs\PythonTests\pythonClasses.py"), @".\Programs\PythonTests\pythonClasses.py");
        }

    }
}
