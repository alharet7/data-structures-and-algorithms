using Stack_Queue.Stacks_Queue;
using Stack_Queue;

namespace Stack_QueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void PushIntoStack()
        {
            Stack stack = new();
            stack.Push(1);

            var res = stack.Count;

            Assert.Equal(1, res);
            Assert.NotNull(stack);
        }

        [Fact]
        public void PushMulitpleValuesIntoStack()
        {
            Stack stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            int stackLength = stack.Count;

            Assert.Equal(4, stackLength);
            Assert.NotNull(stack);
        }

        [Fact]
        public void PopAValueIntoStack()
        {
            // Arrange
            Stack stack = new();
            stack.Push(1);
            stack.Pop();

            // Act
            var res = stack.Count;

            // Assert
            Assert.Equal(0, res);

        }

        [Fact]
        public void EmptyAStackAfterMultiplePops()
        {
            //Arrange
            Stack stack = new();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // Act 

            bool result = stack.IsEmpty();

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void PeekTheTopNodeValueOfTheStack()
        {
            // Arrange
            Stack stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            // Act
            int peekNode = stack.Peek();
            // Assert
            Assert.Equal(4, peekNode);
        }

        [Fact]
        public void EmptyStack()
        {
            // Arrange
            Stack stack = new();

            // Assert
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void CallingPopOrPeekAException()
        {
            Stack stack = new();

            Action act = () => stack.Pop();
            Action act2 = () => stack.Peek();

            Assert.Throws<NullReferenceException>(act);
            Assert.Throws<NullReferenceException>(act2);

        }
        //-------------------------------Queue Tests--------------------------------------------\\
        [Fact]
        public void EnqueueIntoAQueue()
        {
            // Arrange

            Queue queue = new();
            queue.Enqueue(10);

            // Act
            var res = queue.Count;

            // Assert
            Assert.Equal(1, res);

        }
        [Fact]
        public void EnqueueMultipleValues()
        {
            Queue queue = new();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            int queueLength = queue.Count;

            if (queueLength >= 2)
            {
                Assert.Equal(3, queueLength);
            }
            else
            {
                Assert.Fail($"Excepted {queueLength}");
            }
        }

        [Fact]
        public void DequeueOutOfAQueue()
        {
            Queue queue = new();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);


            var deleted = queue.Dequeue();

            Assert.Equal(10, deleted);

        }
        [Fact]
        public void PeekInAQueue()
        {
            Queue queue = new();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            var peeking = queue.Peek();

            Assert.Equal(10, peeking);

        }
        [Fact]
        public void EmptyTheQueueAfterDequeue()
        {
            Queue queue = new();

            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            var queueLength = queue.Count;

            Assert.Equal(0, queueLength);
            Assert.True(queue.IsEmpty());
        }
        [Fact]
        public void InstantiateAnEmptyQueue()
        {
            Queue queue = new();

            Assert.True(queue.IsEmpty());
        }
        [Fact]
        public void DequeueOrPeekException()
        {
            Queue queue = new();
            Action act = () => queue.Dequeue();
            Action act2 = () => queue.Peek();

            Assert.Throws<NullReferenceException>(act);
            Assert.Throws<NullReferenceException>(act2);

        }
    }
}