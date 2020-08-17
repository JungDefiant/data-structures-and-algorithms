using System;
using Xunit;
using HashTable;

namespace HashtableTest
{
    public class HashtableTest
    {
        [Fact]
        public void CheckAddKeyValue()
        {
            Hashtable<int> table = new Hashtable<int>(3);

            table.Add("number", 3);

            Assert.True(table.GetValue("number") == 3);
        }

        [Fact]
        public void CheckRetrieveValue()
        {
            Hashtable<int> table = new Hashtable<int>(3);

            table.Add("number", 3);

            Assert.True(table.GetValue("number") == 3);
        }

        [Fact]
        public void CheckNullKey()
        {
            Hashtable<string> table = new Hashtable<string>(3);

            Assert.Null(table.GetValue("number"));
        }

        [Fact]
        public void CheckHandleCollision()
        {
            Hashtable<string> table = new Hashtable<string>(20);

            table.Add("number", "3");
            table.Add("opqrdc", "5");

            Assert.NotNull(table.GetValue("number"));
        }

        [Fact]
        public void CheckRetrieveValueWithCollision()
        {
            Hashtable<int> table = new Hashtable<int>(20);

            table.Add("number", 3);
            table.Add("opqrdc", 5);

            Assert.True(table.GetValue("opqrdc") == 5);
        }

        [Fact]
        public void CheckSuccessfulKeyHash()
        {
            Hashtable<int> table = new Hashtable<int>(20);

            Assert.True(table.GetHash("number") == 17);
        }
    }
}
