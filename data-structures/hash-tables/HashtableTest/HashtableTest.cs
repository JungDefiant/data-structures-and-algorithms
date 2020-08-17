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

            Assert.True(table.Get("number") == 3);
        }

        [Fact]
        public void CheckRetrieveValue()
        {
            Hashtable<int> table = new Hashtable<int>(3);

            table.Add("number", 3);

            Assert.True(table.Get("number") == 3);
        }

        [Fact]
        public void CheckNullKey()
        {
            Hashtable<int> table = new Hashtable<int>(3);

            Assert.Null(table.Get("number"));
        }

        [Fact]
        public void CheckHandleCollision()
        {
            Hashtable<int> table = new Hashtable<int>(3);

            table.Add("number", 3);
            table.Add("number", 5);
            table.Add("number", 7);

            Assert.NotNull(table.Get("number"));
        }

        [Fact]
        public void CheckRetrieveValueWithCollision()
        {
            Hashtable<int> table = new Hashtable<int>(3);

            table.Add("number", 3);
            table.Add("number", 5);
            table.Add("number", 7);

            Assert.True(table.Get("number") == 3);
        }

        [Fact]
        public void CheckSuccessfulKeyHash()
        {
            Hashtable<int> table = new Hashtable<int>(3);

            Assert.True(table.Hash("number") == 3);
        }
    }
}
