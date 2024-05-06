using System.Linq;
using System.Collections.Generic;

namespace Leetcode
{
    public static class AmzFreshPromo
    {
        public static int IsCustomerWinner(IEnumerable<IEnumerable<string>> codeList, IEnumerable<string> shoppingCart)
        {
            if (codeList == null || !codeList.Any())
            {
                return 1;
            }
            else if (shoppingCart == null || !shoppingCart.Any())
            {
                return 0;
            }
            else
            {
                var i = 0;
                foreach (var code in codeList)
                {
                    while (i <= shoppingCart.Count() - 1 && code.ElementAt(0) != shoppingCart.ElementAt(i))
                    {
                        i++;
                    }

                    foreach (var fruitInCode in code)
                    {
                        if (i <= shoppingCart.Count() - 1 && (fruitInCode == "anything" || fruitInCode == shoppingCart.ElementAt(i)))
                        {
                            i++;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return 1;
            }
        }
    }
}
