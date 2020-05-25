# Parallel Prefix Sum

Given an array arr[] of size n, its prefix sum array is another array prefixSum[] of same size such that the value of prefixSum[i] is arr[0] + arr[1] + arr[2] … arr[i].

Examples :

Input  : arr[] = {10, 20, 10, 5, 15}
Output : prefixSum[] = {10, 30, 40, 45, 60}

Explanation : While traversing the array, update 
the element by adding it with its previous element.
prefixSum[0] = 10, 
prefixSum[1] = prefixSum[0] + arr[1] = 30, 
prefixSum[2] = prefixSum[1] + arr[2] = 40 and so on.

## About Programm
This repository contains a simple C# console application (a parallel algorithm) for computing prefix sum of a given array.

I wrote this simeple app as a homework when i was taking "Parallel Computing" course in Tabriz university (about 2011).

## Screenshot
![parallel-prefix-sum-example](https://github.com/mehrta/parallel-prefix-sum/blob/master/example.png)
