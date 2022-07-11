﻿
// Extensification  Copyright (C) 2020-2021  EoflaOE
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

using System;

namespace Extensification.ArrayExts
{
    /// <summary>
    /// Provides the array extensions related to addition
    /// </summary>
    public static class Addition
    {

        /// <summary>
        /// Adds an entry to array
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="TargetArray">Target array</param>
        /// <param name="Item">Any item</param>
        public static void Add<T>(ref T[] TargetArray, T Item)
        {
            if (TargetArray is null)
                throw new ArgumentNullException(nameof(TargetArray));
            Array.Resize(ref TargetArray, TargetArray.Length + 1);
            TargetArray[TargetArray.Length - 1] = Item;
        }

        /// <summary>
        /// Adds a range of entries to array
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="TargetArray">Target array</param>
        /// <param name="ToBeAdded">Range of entries in an array</param>
        public static void AddRange<T>(ref T[] TargetArray, T[] ToBeAdded)
        {
            if (TargetArray is null)
                throw new ArgumentNullException(nameof(TargetArray));
            int OldIndex = TargetArray.Length - 1;
            Array.Resize(ref TargetArray, TargetArray.Length + ToBeAdded.Length);
            int NewIndex = TargetArray.Length - 1;
            int AddedIndex = 0;
            for (int CurrIndex = OldIndex + 1, loopTo = NewIndex; CurrIndex <= loopTo; CurrIndex++)
            {
                TargetArray[CurrIndex] = ToBeAdded[AddedIndex];
                AddedIndex += 1;
            }
        }

    }
}