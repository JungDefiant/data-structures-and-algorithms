# Merge Sort
Merge Sort is a sorting algorithm that splits an array into two smaller arrays and then merges them together. Each of the smaller arrays are recursively split in half and merged as well before being merged together in the larger array.

## Example
If you took a deck of cards, you could split the deck in half. You would then split those smaller decks in half again. You would continue splitting them until you had decks of two cards. You would then order each of those stacks with the highest value on top. 

When merging, you would start putting together the smaller decks into a bigger deck in the order of highest on top and lowest on bottom. You would continue to do this with decks on either side until you have two larger decks merged into one.

## Algorithm
```
  ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```

## Trace
Let's take the following array.

``[8,4,23,42,16,15]``

<WIP>

## Efficiency
**Time:** O(N^3)
**Space:** O(N). Since the algorithm is creating a new array for each element, 
