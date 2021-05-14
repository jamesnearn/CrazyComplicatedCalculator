using System;

namespace CrazyCalcEngine
{
    public class MathEngine
    {
        public bool TryParse(string given, out int result)
        {
            var addendums = given.Split('+');
            result = 0;
            foreach (var addendum in addendums)
            {
                int newVal = 0;
                if (int.TryParse(addendum, out newVal))
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
