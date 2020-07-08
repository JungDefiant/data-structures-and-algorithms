# Code Challenges

# Array Shift
# Challenge Summary
This challenge entails creating a function that returns a new array with a given value put into the middle of the array.

## Challenge Description
When an array of integers and an integer are input into the function, the function needs to return a new array of integers that looks like the input, except it contains the input integer in the middle of the array.

## Approach & Efficiency
When designing a solution, the approach I took was to visualize the output and then work backwards. I had to figure out how I was first going to insert the number into a new array and then I had to figure out how to populate the array with numbers from the input array in the proper order. I did this by using two iterators in a for loop; one for iterating through the new array and one for iterating through the old array. When the for loop reached the middle index, it populates that index with the input integer and increments the iterator for the old array down. At the end of each loop, the new array is populated with the value of the old array from the index of the first and second iterator respectively. IE, newArray[i] = oldArray[j]. Since there's only one loop, the time and space complexity are approximately O(n) for time and O(1) for space.

## Solution
![Whiteboard used for planning code challenge]()
