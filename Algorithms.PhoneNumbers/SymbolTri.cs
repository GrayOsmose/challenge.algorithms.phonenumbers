using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumbers
{
    public sealed class SymbolTri
    {
        // path path
        private Dictionary<char, SymbolTri> _paths = new Dictionary<char, SymbolTri>();

        public bool InsertSymbols(string symbols)
        {
            // path has end
            if (_paths == null) return false;

            var pathCore = symbols[0];

            if (!_paths.ContainsKey(pathCore)) _paths.Add(pathCore, new SymbolTri());

            // last symbol should end path, as there's no path anymore
            if (symbols.Length == 1) return _paths[pathCore].EndPath();
            // continue building path
            else return _paths[pathCore].InsertSymbols(symbols.Substring(1, symbols.Length - 1));
        }

        public bool EndPath()
        {
            // you can't end path when one was build already
            if (_paths.Keys.Count > 0) return false;

            _paths = null;
            return true;
        }
    }
}
