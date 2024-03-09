public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue

        //var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: add 5 items to the queue with the following priorities:Jeff 5, Alli 3, Lydia 2, Peter 1, Grace 4, Dave 6
        // they should be added to the back of the queue when Enqueue is called.
        // Expected Result: [Jeff (Pri:5), Alli (Pri:3), Lydia (Pri:2), Peter (Pri:1), Grace (Pri:4), Dave (Pri:6)]
        Console.WriteLine("Test 1");
        //create queue and add items print to verify items are added correctly
        var test1Queue = new PriorityQueue();
        test1Queue.Enqueue("Jeff",5);
        test1Queue.Enqueue("Alli",3);
        test1Queue.Enqueue("Lydia",2);
        test1Queue.Enqueue("Peter",1);
        test1Queue.Enqueue("Grace",4);
        test1Queue.Enqueue("Dave",6);

        Console.WriteLine(test1Queue.ToString());

        //add pass fail logic to verify items are added correctly
        if (test1Queue.ToString() == "[Jeff (Pri:5), Alli (Pri:3), Lydia (Pri:2), Peter (Pri:1), Grace (Pri:4), Dave (Pri:6)]")
        {
            Console.WriteLine("Test 1 Passed");
        }
        else
        {
            Console.WriteLine("Test 1 Failed");
        }

        // Defect(s) Found: None Enqueue is working as expected

        Console.WriteLine("---------");

        // Test 2
        // Scenario: When removing items from the queue and there are no duplicates, 
        // the item with the highest priority should be removed first.
        // Expected Result: Peter should be removed from the middle of the list
            // removedItem should be Peter
            // New Queue [Jeff (Pri:5), Alli (Pri:3), Lydia (Pri:2), Grace (Pri:4), Dave (Pri:6)]
        Console.WriteLine("Test 2");

        //create queue and add items
        var test2Queue = new PriorityQueue();
        test2Queue.Enqueue("Jeff",5);
        test2Queue.Enqueue("Alli",3);
        test2Queue.Enqueue("Lydia",2);
        test2Queue.Enqueue("Peter",6);
        test2Queue.Enqueue("Grace",4);
        test2Queue.Enqueue("Dave",1);

        //remove 1 item and print to verify the item with the highest priority is removed

        var removedItemT2 = test2Queue.Dequeue();

        //print results to verify the item with the highest priority is removed
        Console.WriteLine("Person Removed was " + removedItemT2); //Peter
        Console.WriteLine(test2Queue.ToString());

        //add pass fail logic to verify the item with the highest priority is removed
        if (removedItemT2 == "Peter")
        {
            Console.WriteLine("Test 2 Passed");
        }
        else
        {
            Console.WriteLine("Test 2 Failed");
        }


        // Defect(s) Found: 
            //the loop was stopping at line 1 so it wasnt looking at each item in my list Removed the -1 from the for loop.
            // The loop was also not removing the item with the highest priority. I added _queue.RemoveAt(highPriorityIndex); to remove the item with the highest priority
        
        Console.WriteLine("---------");

        // Test 3
        // Scenario: When removing items from the queue and there are duplicate priorities,
        // the item that was added first should be removed first.
        // Expected Result: Alli should be removed from index 1 of the list
            // removedItem should be Alli
            // New Queue [Jeff (Pri:5), Lydia (Pri:2), Peter (Pri:6), Grace (Pri:4), Dave (Pri:1)]

        Console.WriteLine("Test 3");

        //create queue and add items
        var test3Queue = new PriorityQueue();
        test3Queue.Enqueue("Jeff",5);
        test3Queue.Enqueue("Alli",6);
        test3Queue.Enqueue("Lydia",5);
        test3Queue.Enqueue("Peter",6);
        test3Queue.Enqueue("Grace",4);
        test3Queue.Enqueue("Dave",6);

        //remove 1 item and print to verify the item with the highest priority is removed

        var removedItem = test3Queue.Dequeue();

        //print results to verify the first item with the highest priority is removed
        Console.WriteLine("Person Removed was " + removedItem); //Alli
        Console.WriteLine(test3Queue.ToString());

        //add pass fail logic to verify the item with the highest priority is removed
        if (removedItem == "Alli")
        {
            Console.WriteLine("Test 3 Passed");
        }
        else
        {
            Console.WriteLine("Test 3 Failed");
        }

        // Defects Found:
            //I only wanted to remove the first item with the highest priority so I removed the = from the if statement

        Console.WriteLine("---------");

        // Test 4

        // Scenario: When removing items from the queue and there are no items in the queue,
        // a message should be printed to the console and null should be returned.
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 4");
        
        //create queue and dont add items

        var test4Queue = new PriorityQueue();

        //remove 1 item and print to verify the item with the highest priority is removed

        var test4ItemRemoved = test4Queue.Dequeue();

        //write pass fail logic to verify a blank queue returns an error and null
        if (test4ItemRemoved == null)
        {
            Console.WriteLine("Test 4 Passed");
        }
        else
        {
            Console.WriteLine("Test 4 Failed");
        }

        // Defect(s) Found: None, the queue is empty message is printed and null is returned as expected
    }
}
