using Leetcode;
using Xunit;

namespace LeetCodeUnitTest
{
    public class AmzFreshPromoTest
    {
        [Fact]
        public void EmptyCodeList_Return_1()
        {
            var result = AmzFreshPromo.IsCustomerWinner(new List<List<string>>(), null);
            Assert.Equal(1, result);
        }

        [Fact]
        public void NullCodeList_Return_1()
        {
            var result = AmzFreshPromo.IsCustomerWinner(null, null);
            Assert.Equal(1, result);
        }

        [Fact]
        public void EmptyShoppingList_Return_0()
        {
            var result = AmzFreshPromo.IsCustomerWinner(new List<List<string>> { new List<string>() { "Apple", "Orange" } }, new List<string>());
            Assert.Equal(0, result);
        }

        [Fact]
        public void NullShoppingList_Return_0()
        {
            var result = AmzFreshPromo.IsCustomerWinner(new List<List<string>> { new List<string>() { "Apple", "Orange" } }, null);
            Assert.Equal(0, result);
        }

        [Fact]
        public void WinnerShoppingList_Return_0()
        {
            var codeList = new List<List<string>> {
                new List<string>() { "Apple", "Orange" },
                new List<string>() { "Mango", "Banana" } };
            var shoppingCart = new List<string>() { "Apple", "Orange" };
            var result = AmzFreshPromo.IsCustomerWinner(codeList, shoppingCart);
            Assert.Equal(0, result);
        }

        [Fact]
        public void WinnerShoppingList_1_Return_1()
        {
            var codeList = new List<List<string>> {
                new List<string>() { "apple", "apple" },
                new List<string>() { "banana", "anything", "banana" } };
            var shoppingCart = new List<string>() { "orange", "apple", "apple", "banana", "orange", "banana" };
            var result = AmzFreshPromo.IsCustomerWinner(codeList, shoppingCart);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WinnerShoppingList_2_Return_1()
        {
            var codeList = new List<List<string>> {
                new List<string>() { "apple", "apple" },
                new List<string>() { "banana", "anything", "banana" } };
            var shoppingCart = new List<string>() { "apple", "apple", "orange", "orange", "banana", "apple", "banana", "banana" };
            var result = AmzFreshPromo.IsCustomerWinner(codeList, shoppingCart);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WinnerShoppingList_1_Return_0()
        {
            var codeList = new List<List<string>> {
                new List<string>() { "apple", "apple" },
                new List<string>() { "banana", "anything", "banana" } };
            var shoppingCart = new List<string>() { "banana", "orange", "banana", "apple", "apple" };
            var result = AmzFreshPromo.IsCustomerWinner(codeList, shoppingCart);
            Assert.Equal(0, result);
        }

        [Fact]
        public void WinnerShoppingList_2_Return_0()
        {
            var codeList = new List<List<string>> {
                new List<string>() { "apple", "apple" },
                new List<string>() { "banana", "anything", "banana" } };
            var shoppingCart = new List<string>() { "apple", "banana", "apple", "orange", "orange", "banana", "apple", "banana", "banana" };
            var result = AmzFreshPromo.IsCustomerWinner(codeList, shoppingCart);
            Assert.Equal(0, result);
        }
    }
}
