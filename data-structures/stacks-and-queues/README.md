# Stacks and Queues
This project shows the stack and queue data structures. 

## Challenge
The challenge was to create Stack and Queue data structures, then test whether they work properly.

## Approach & Efficiency
Stack: All of the methods are O(1) for both time and space, because at no point did I need to iterate through the stack. The approach that I took was minimize creating new objects as much as possible and keeping operations 'in-place'.

Queue: All of the methods are O(1) for at least time. Most of the operations were straightforward, but Enqueue was more complicated since it needed O(1) efficiency and it needed to add it to the end of the Queue. I felt like I had no choice except to create a 'rear node' property that could track the end of the queue. This created other complications, since a new Queue has a null front and rear node. I resolved this by checking whether the queue was empty, then setting both the front and rear to the same node if true.

## API
Stack
--> Push(): Pushes a new node with the given value to the Top of the Stack.
--> Pop(): Removes the Top node from the Stack and returns it.
--> Peek(): Peeks into and returns the Top of the Stack.
--> IsEmpty(): Checks if Stack is Empty.

Queue
--> Enqueue(): Adds node with given value to the Rear of the Queue. If Queue is empty, both the Front and Rear are assigned to the new node.
--> Dequeue(): Removes and returns node from the Front of the Queue.
--> Peek(): Peeks into and returns the Front of the Queue.
--> IsEmpty(): Checks if Queue is Empty.