﻿/*
 Copyright (C) 2011 by Sherif Elmetainy (Grendizer@Doomhammer-EU)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WOWSharp.Community.ObjectModel
{
    /// <summary>
    /// Represents information about a glyph being used by a character
    /// </summary>
    [Serializable]
    [DataContract]
    public class CharacterGlyph : BaseExtensibleDataObject
    {
        /// <summary>
        /// gets or sets glyph id
        /// </summary>
        [DataMember(Name="glyph", IsRequired = true)]
        public int GlyphId
        {
            get;
            set;
        }

        /// <summary>
        /// gets or sets item id (of the glyph)
        /// </summary>
        [DataMember(Name = "item", IsRequired = true)]
        public int ItemId
        {
            get;
            set;
        }

        /// <summary>
        /// gets or sets glyph name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets glyph's icon
        /// </summary>
        [DataMember(Name = "icon", IsRequired = true)]
        public string Icon
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the name of the glyph (for debugging purposes)
        /// </summary>
        /// <returns>Returns the name of the glyph (for debugging purposes)</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}