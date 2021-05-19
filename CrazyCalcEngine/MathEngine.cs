using System;
using NearnCSharpExtensions;

namespace CrazyCalcEngine
{
    public class MathEngine
    {
        public bool TryParse(string given, out int result)
        {
            var addendums = given.RemoveSpaces().Split('+');
            result = 0;
            foreach (var addendum in addendums)
            {
                int newVal = 0;
                if (!String.IsNullOrEmpty(addendum) && int.TryParse(addendum, out newVal))
                {
                    result += newVal;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
