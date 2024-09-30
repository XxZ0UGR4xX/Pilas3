namespace TareaPilas3

{
   
public class BalanceParentesis
        {
            public static bool IsBalanced(string expresion)
            {
                Stack<char> stack = new Stack<char>();

                foreach (char c in expresion)
                {
                    if (c == '(' || c == '[' || c == '{')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')' || c == ']' || c == '}')
                    {
                        if (stack.Count == 0) return false; 

                        char openingParenthesis = stack.Pop();

                        if ((c == ')' && openingParenthesis != '(') ||
                            (c == ']' && openingParenthesis != '[') ||
                            (c == '}' && openingParenthesis != '{'))
                        {
                            return false; 
                        }
                    }
                }

                return stack.Count == 0; 
            }

            public static void Main(string[] args)
            {
                Console.WriteLine(IsBalanced("((()))")); 
                Console.WriteLine(IsBalanced("([{}])")); 
                Console.WriteLine(IsBalanced("((())")); 
                Console.WriteLine(IsBalanced("([)]")); 
            }
        }
    }

