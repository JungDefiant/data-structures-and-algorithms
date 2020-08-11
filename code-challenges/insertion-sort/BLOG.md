# Insertion Sort
Insertion Sort is a sorting algorithm that separates a collection into sorted and unsorted sections. The next element is compared to the elements before it. If it is less than a earlier element, it will be 'inserted' into the sorted section of the collection and the other elements will be moved up in their index to make room for the insertion.

## Example
One way you can imagine this algorithm working is through sorting books alphabetically by title. You place the first book onto a shelf. You would then begin a process of picking the next book from the 'unsorted' stack in the proper place on the shelf. The algorithm would start from right-to-left, comparing the title of the book you're sorting with the next book on the shelf. Once you find the book that the unsorted book would come after, you place the book on the shelf in front of that one and shift the rest to the right. If you sort your books this way, you should end up with your shelf being order A to Z from left to right.

## Algorithm
```
  InsertionSort(int[] arr)
  
    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp
```

## Trace
Let's take the following array.

``[8,4,23,42,16,15]``

### Iteration 1
In the first iteration, I will start at the second index, which is **4**. I would check if 4 is less than the indices before it, which is only **8**. Since 4 is less than 8, I would swap their places.

``[4,8,23,42,16,15]``

### Iterations 2-3
In the second and third iterations, they are in the correct order and don't need to be sorted.

### Iterations 4-5
In the last two iterations, both **16** and **15** are less than the elements before it. I would iterate backwards through the array until the element before the element to be sorted doesn't have a lower value. If the prior element is higher, then it is pushed forward.

Since **16** is less than **23**, both 23 and 42 will be put into the elements ahead of them and **16** will be placed in the third index.

``[4,8,16,23,42,15]``

The same process occurs for **15**.

``[4,8,15,16,23,42]``

## Efficiency
**Time:** O(N^2). The worst case scenario is the unsorted array is reversed and it will iterate through the array once for each element in the array.
**Space:** O(1). New objects aren't being created since the array is being sorted in place.
