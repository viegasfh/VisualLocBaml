﻿/*
    Copyright (c) 2013-2014 Fedir Nepyivoda <fednep@gmail.com>

    This file is part of VisualLocBaml project
    http://visuallocbaml.com

    VisualLocBaml is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    VisualLocBaml is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with VisualLocBaml. If not, see <http://www.gnu.org/licenses/>

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslationApi
{
    public class ImportResult
    {
        public List<int> SidsList;

        public List<int> NewStrings;
        public List<int> DeletedStrings;
        public List<int> StringsUpdated;

        public ImportResult(string dllFile)
        {            
            DllFile = dllFile;
        }
        public string DllFile { get; set; }

        public int StringsProcessed
        {
            get
            {
                return SidsList.Count;
            }
        }

        public int New
        {
            get
            {
                return NewStrings.Count;
            }
        }

        public int Updated
        {
            get
            {
                return StringsUpdated.Count;
            }
        }

        public int Deleted
        {
            get
            {
                return DeletedStrings.Count;
            }
        }
    }
}
