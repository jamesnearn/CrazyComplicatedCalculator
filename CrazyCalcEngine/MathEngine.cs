using System;
using NearnCSharpExtensions;

namespace CrazyCalcEngine
{
    public class MathEngine
    {
        public bool TryParse(string given, out int result)
        {
            given = given.RemoveSpaces();

            given = SubtractionIsAdditionOfNegativeNumbers(given);

            var addendums = given.Split('+');
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

        public string SubtractionIsAdditionOfNegativeNumbers(string given)
        {
            if (given.Length >= 3) {
                given = given[0] + given.Substring(1).Replace("-", "+-").Replace("++-", "+-");
            }
            return given;
        }
    }
}
