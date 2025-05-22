using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // 1. The first dequeued item should be "B" (highest priority).
    // 2. The second dequeued item should be "C".
    // 3. The third dequeued item should be "A".
    // Defect(s) Found: 
    // - I just see the feedback I don't remember clearly what was the defect in this part of the code

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
         priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

         Assert.AreEqual("B", priorityQueue.Dequeue()); 
        Assert.AreEqual("C", priorityQueue.Dequeue());  
        Assert.AreEqual("A", priorityQueue.Dequeue()); 
    }

    [TestMethod]
    // Scenario: 
   // Expected Result: 
    // 1. The first dequeued item should be "A" (since it was enqueued first).
    // 2. The second dequeued item should be "B".
    // 3. The third dequeued item should be "C".
    // Defect(s) Found: 
    // - If the elements are not dequeued in the order they were enqueued (A, B, C), it suggests that the priority queue is not 
        // - I just see the feedback I don't remember clearly what was the defect in this part of the code
    public void TestPriorityQueue_2()
    {
             var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}