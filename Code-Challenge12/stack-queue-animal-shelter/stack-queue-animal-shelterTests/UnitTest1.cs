using stack_queue_animal_shelter;

namespace stack_queue_animal_shelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueValidAnimalAddedToFrontAndBack()
        {
            // Arrange
            MyQueue queue = new();
            Animals cat = new() { Species = "cat" };

            // Act
            queue.Enqueue(cat);

            // Assert
            Assert.Same(cat, queue.front.Data);
            Assert.Same(cat, queue.back.Data);
        }

        [Fact]
        public void EnqueueInvalidAnimalNotAdded()
        {
            // Arrange
            MyQueue queue = new();
            Animals bird = new() { Species = "bird" };

            // Act
            queue.Enqueue(bird);

            // Assert
            Assert.Null(queue.front);
            Assert.Null(queue.back);
        }



        [Fact]
        public void DequeueNonExistingAnimalReturnsNull()
        {
            // Arrange
            MyQueue queue = new();
            Animals cat = new() { Species = "cat" };
            queue.Enqueue(cat);

            // Act
            Animals DequeuedDog = queue.Dequeue("dog");

            // Assert
            Assert.Null(DequeuedDog);
            Assert.Same(cat, queue.front.Data);
            Assert.Same(cat, queue.back.Data);
        }


        [Fact]
        public void DequeueExistingAnimalReturnsCorrectAnimal()
        {
            MyQueue queue = new();
            Animals cat = new() { Species = "cat" };
            Animals dog = new() { Species = "dog" };
            queue.Enqueue(cat);
            queue.Enqueue(dog);

            // Act
            string DequeuedSpecies = queue.Dequeue("dog").Species;

            // Assert
            Assert.Equal("dog", DequeuedSpecies);
        }
    }
}