using System;
using Xunit;

namespace HashTable.Tests
{
    public class MyHashTableTests
    {
        [Fact]
        public void SettingKeyValueShouldRetrieveStoredValue()
        {
            // Arrange
            MyHashTable hashTable = new MyHashTable(1024);

            // Act
            hashTable.Set("1", "Cat");
            hashTable.Set("2", "Dog");

            // Assert
            Assert.Equal("Cat", hashTable.Get("1").Value);
        }

        [Fact]
        public void RetrievingValueBasedOnKeyShouldSucceed()
        {
            // Arrange
            MyHashTable hashTable = new MyHashTable(1024);
            hashTable.Set("1", "Cat");
            hashTable.Set("2", "Dog");

            // Act & Assert
            Assert.True(hashTable.Contains("2"));
        }

        [Fact]
        public void RetrievingValueForNonExistentKeyShouldReturnNull()
        {
            // Arrange
            MyHashTable hashTable = new MyHashTable(1024);

            // Act & Assert
            Assert.Null(hashTable.Get("3"));
        }

     

        [Fact]
        public void HandlingCollisionWithinHashTableShouldSucceed()
        {
            // Arrange
            MyHashTable hashTable = new MyHashTable(1024);

            // Set two keys that hash to the same index
            hashTable.Set("1", "Cat");
            hashTable.Set("129", "Dog");

            // Act & Assert
            Assert.Equal("Cat", hashTable.Get("1").Value);
            Assert.Equal("Dog", hashTable.Get("129").Value);
        }

        [Fact]
        public void HashingKeyToInRangeValueShouldSucceed()
        {
            // Arrange
            MyHashTable hashTable = new MyHashTable(1024);
            string key = "TestKey";

            // Act
            int hashValue = hashTable.Hash(key);

            // Assert
            Assert.InRange(hashValue, 0, 1023);
        }
    }
}
