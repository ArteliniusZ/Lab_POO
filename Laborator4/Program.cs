using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;



namespace LabPOO4
{
    public static class check
    {
        public class stack
        {
            public int top = -1;
            public char[] items = new char[100];

            public void push(char x)
            {
                if (top == 99)
                {
                    Console.WriteLine("Stack full");
                }
                else
                {
                    items[++top] = x;
                }
            }

            char pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Underflow error");
                    return '\0';
                }
                else
                {
                    char element = items[top];
                    top--;
                    return element;
                }
            }

            Boolean isEmpty()
            {
                return (top == -1) ? true : false;
            }
        }

        // Returns true if character1 and character2
        // are matching left and right brackets */
        public static Boolean isMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else
                return false;
        }

        // Return true if expression has balanced
        // Brackets
        public static Boolean areBracketsBalanced(char[] exp)
        {
            // Declare an empty character stack */
            Stack<char> st = new Stack<char>();

            // Traverse the given expression to
            //   check matching brackets
            for (int i = 0; i < exp.Length; i++)
            {
                // If the exp[i] is a starting
                // bracket then push it
                if (exp[i] == '(')
                    st.Push(exp[i]);

                //  If exp[i] is an ending bracket
                //  then pop from stack and check if the
                //   popped bracket is a matching pair
                if (exp[i] == ')')
                {

                    // If we see an ending bracket without
                    //   a pair then return false
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    // Pop the top element from stack, if
                    // it is not a pair brackets of
                    // character then there is a mismatch. This
                    // happens for expressions like {(})
                    else if (!isMatchingPair(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }

            // If there is something left in expression
            // then there is a starting bracket without
            // a closing bracket

            if (st.Count == 0)
                return true; // balanced
            else
            {
                // not balanced
                return false;
            }
        }
        public class EvaluateString
        {
            public static int evaluate(string expression)
            {
                char[] tokens = expression.ToCharArray();

                // Stack for numbers: 'values'
                Stack<int> values = new Stack<int>();

                // Stack for Operators: 'ops'
                Stack<char> ops = new Stack<char>();

                for (int i = 0; i < tokens.Length; i++)
                {
                    // Current token is a whitespace, skip it
                    if (tokens[i] == ' ')
                    {
                        continue;
                    }

                    // Current token is a number,
                    // push it to stack for numbers
                    if (tokens[i] >= '0' && tokens[i] <= '9')
                    {
                        StringBuilder sbuf = new StringBuilder();

                        // There may be more than
                        // one digits in number
                        while (i < tokens.Length &&
                                tokens[i] >= '0' &&
                                    tokens[i] <= '9')
                        {
                            sbuf.Append(tokens[i++]);
                        }
                        values.Push(int.Parse(sbuf.ToString()));

                        // Right now the i points to
                        // the character next to the digit,
                        // since the for loop also increases
                        // the i, we would skip one
                        //  token position; we need to
                        // decrease the value of i by 1 to
                        // correct the offset.
                        i--;
                    }

                    // Current token is an opening
                    // brace, push it to 'ops'
                    else if (tokens[i] == '(')
                    {
                        ops.Push(tokens[i]);
                    }

                    // Closing brace encountered,
                    // solve entire brace
                    else if (tokens[i] == ')')
                    {
                        while (ops.Peek() != '(')
                        {
                            values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                        }
                        ops.Pop();
                    }

                    // Current token is an operator.
                    else if (tokens[i] == '+' ||
                             tokens[i] == '-' ||
                             tokens[i] == '*' ||
                             tokens[i] == '/')
                    {

                        // While top of 'ops' has same
                        // or greater precedence to current
                        // token, which is an operator.
                        // Apply operator on top of 'ops'
                        // to top two elements in values stack
                        while (ops.Count > 0 &&
                                 hasPrecedence(tokens[i], ops.Peek()))
                        {
                            values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                        }

                        // Push current token to 'ops'.
                        ops.Push(tokens[i]);
                    }
                }

                // Entire expression has been
                // parsed at this point, apply remaining
                // ops to remaining values
                while (ops.Count > 0)
                {
                    values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                }

                // Top of 'values' contains
                // result, return it
                return values.Pop();
            }
            public static bool hasPrecedence(char op1, char op2)
            {
                if (op2 == '(' || op2 == ')')
                {
                    return false;
                }
                if ((op1 == '*' || op1 == '/') &&
                       (op2 == '+' || op2 == '-'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            // A utility method to apply an
            // operator 'op' on operands 'a' 
            // and 'b'. Return the result.
            public static int applyOp(char op, int b, int a)
            {
                switch (op)
                {
                    case '+':
                        return a + b;
                    case '-':
                        return a - b;
                    case '*':
                        return a * b;
                    case '/':
                        if (b == 0)
                        {
                            throw new
                            NotSupportedException("Cannot divide by zero");
                        }
                        return a / b;
                }
                return 0;
            }

            // Driver code
            public static void Main(string[] args)
            {

                DataTable dt = new DataTable();
                string line1 = File.ReadAllText(@"C:/Users/Asus/Desktop/one_expression.txt");
                char[] line1_char = line1.ToCharArray();

                

                if (areBracketsBalanced(line1_char))
                {
                    Console.WriteLine("The following expression is balanced");
                    var c = dt.Compute(line1, " ");
                    Console.WriteLine("The result of the expression is: " + c);
                }
                else
                    Console.WriteLine("The following expression is not balanced");

                Console.WriteLine("--------------------------------------------");


                var list = new List<string[]>();
                using (StreamReader reader = new StreamReader("c:/users/asus/desktop/three_expressions.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line.Split(';'));
                    }
                }

                string firstExpression = list[0][0];
                string secondExpression = list[1][0];
                string thirdExpression = list[2][0];

                char[] firstexpress_char = firstExpression.ToCharArray();
                char[] secondexpress_char = secondExpression.ToCharArray();
                char[] thirdexpress_char = thirdExpression.ToCharArray();


                if (areBracketsBalanced(firstexpress_char))
                {
                    Console.WriteLine("The first expression is balanced");
                    Console.WriteLine("The result of the first expression is: " + EvaluateString.evaluate(firstExpression));
                    
                }
                else
                    Console.WriteLine("The first expression is not balanced, therefore we cannot evaluate it!");

                if (areBracketsBalanced(secondexpress_char)) {
                    Console.WriteLine("The second expression is balanced");
                    Console.WriteLine(EvaluateString.evaluate(secondExpression));

                }
                else
                    Console.WriteLine("The first expression is not balanced, therefore we cannot evaluate it!");

                if (areBracketsBalanced(thirdexpress_char))
                {
                    Console.WriteLine("The third expression is balanced");
                    Console.WriteLine(EvaluateString.evaluate(thirdExpression));

                }
                else
                    Console.WriteLine("The first expression is not balanced, therefore we cannot evaluate it!");
            }
        }
    }
}

