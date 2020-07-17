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
                if (stack.Count() == 0)
                {
                    return;
                }

                var item = stack.Pop();
                if (item % 2 == 0)
                {
                    result.Add(item);
                }

                helper(stack);
            }

            helper(new Stack<int>(items));
            return result;
        }
    }
}