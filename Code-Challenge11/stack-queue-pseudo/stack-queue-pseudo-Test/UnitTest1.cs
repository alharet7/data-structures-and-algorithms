using stack_queue_pseudo;

namespace stack_queue_pseudo_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyEnqueue()    //Can successfully Enqueue onto a Queue-Pseudo
        {
            Queue_pseudo QueuePseudo = new Queue_pseudo();
            QueuePseudo.Enqueue(1);
            QueuePseudo.Enqueue(2);
            QueuePseudo.Enqueue(3);
            QueuePseudo.Enqueue(4);

            Assert.Equal(1, QueuePseudo.Dequeue());
        }
    }
}