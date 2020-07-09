# Challenge Summary
This challenge entails creating a function that finds a key in a sorted array using binary search.

## Challenge Description
When a sorted array of integers and a key are passed into the method as inputs, the array needs to output the key that it finds or -1 if it doesn't find it. This is done through binary search, where the method will find the middle of the array and check if it matches the key. If the key is higher or lower than the middle, a new middle will be found on the higher or lower end of the array and the process will repeat until the middle value is the same as the key. If the middle never equals the key, then it doesn't exist in the array.

## Approach & Efficiency
When designing a solution, the approach I took was to simply research how binary search works and then implement the logic. I broke down the process into logical steps. First, I needed to get the middle index of the array. Then, I needed to check whether the middle element of the array was lower or higher than the input key. The method would continue searching until the middle index was at the last or first element of the array or the middle element equaled the key, so I used a while loop to iterate through the array. Outside of the array, I simply needed to check whether the key equaled the middle element found, since it had already searched for all possibilities in the while loop. If it does, I return the middle element. If it doesn't, I return -1. Due to the efficiency of binary search, the time and space complexity are approximately O(log n) for time and O(1) for space.

## Solution
![Whiteboard used for planning code challenge](https://github.com/JungDefiant/data-structures-and-algorithms/blob/master/code-challenges/array-binary-search/assets/array-binary-search.png)
