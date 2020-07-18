namespace Algorithms.Recursions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class CollectionRecursion
    {
        public static List<int> Execute(int[] items)
        {
            var result = new List<int>();
            void helper(Stack<int> stack)
            {
                // Define a base condition
                if (stack.Count() == 0)
                {
                    return;
                }

                var item = stack.Pop();
                if (item % 2 == 0)
                {
                    result.Add(item);
                }

                // Define a recursion condition
                helper(stack);
            }

            helper(new Stack<int>(items));
            return result;
        }
    }
}