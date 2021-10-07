using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Parentesis
{
   public static class BalancedParentheses
{
    // Arrays should contain paired parentheses in the same order:
    private static readonly char[] AbrirParentesis= { '(', '[', '{' };
    private static readonly char[] CerrarParentesis = { ')', ']', '}' };

    public static bool Check(string input)
    {
        // Indices of the currently open parentheses:
        Stack<int> parentesis = new Stack<int>();

        foreach (char chr in input)
        {
            int index;

            // Check if the 'chr' is an open parenthesis, and get its index:
            if ((index = Array.IndexOf(AbrirParentesis, chr)) != -1)
            {
                    parentesis.Push(index);  // Add index to stach
            }
            // Check if the 'chr' is a close parenthesis, and get its index:
            else if ((index = Array.IndexOf(CerrarParentesis, chr)) != -1)
            {
                // Return 'false' if the stack is empty or if the currently
                // open parenthesis is not paired with the 'chr':
                if (parentesis.Count == 0 || parentesis.Pop() != index)
                    return false;
            }
        }
        // Return 'true' if there is no open parentheses, and 'false' - otherwise:
        return parentesis.Count == 0;
    }
}


}
