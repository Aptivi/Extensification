﻿
// Extensification  Copyright (C) 2020-2021  Aptivi
// 
// This file is part of Extensification
// 
// Extensification is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Extensification is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using Extensification.EnumerableExts;
using System.Collections.Generic;
using NUnit.Framework;
using System;
using System.Linq;

namespace Extensification.Tests
{

    [TestFixture]
    public class EnumerableTests
    {

        #region Addition
#if NETCOREAPP == false
            /// <summary>
            /// Tests appending a value to the end of a list
            /// </summary>
            [Test]
            public static void TestAppendList()
            {
                List<string> TargetEnum = new() { "Welcome", "to" };
                TargetEnum = TargetEnum.Append("Extensification").ToList();
                Assert.IsTrue(TargetEnum.Contains("Extensification"));
            }

            /// <summary>
            /// Tests appending a value to the end of a string
            /// </summary>
            [Test]
            public static void TestAppendString()
            {
                string TargetString = "Welcom";
                TargetString = String.Join("", TargetString.Append('e'));
                Assert.IsTrue(TargetString == "Welcome");
            }
#endif
        #endregion

        #region Manipulation
        /// <summary>
        /// Tests stringifying a char enumerable
        /// </summary>
        [Test]
        public void TestStringify()
        {
            IEnumerable<char> TargetArray = new[] { 'H', 'e', 'l', 'l', 'o' };
            Assert.AreEqual("Hello", TargetArray.Stringify());
        }
        #endregion

    }
}