using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumbers
{
    public static class SymbolTriWrapper
    {
        public static bool GetResultFrom(List<string> list)
        {
            if (list.Count == 0) return true;

            var result = false;
            var index = 0;
            var symbolTriCore = new SymbolTri();

            do
            {
                result = symbolTriCore.InsertSymbols(list[index]);
                index++;
            } while (result && index < list.Count);

            return result;
        }
    }
}
