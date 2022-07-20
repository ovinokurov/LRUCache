using System;

namespace LRU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             https://leetcode.com/problems/lru-cache/
             ##Requirements 

             Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

            Implement the LRUCache class:

            LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
            int get(int key) Return the value of the key if the key exists, otherwise return -1.
            void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.
            The functions get and put must each run in O(1) average time complexity.
             */

            LRUCache lRUCache = new LRUCache(2);

            lRUCache.Put(1, 1); // cache is {1=1}
            lRUCache.Put(2, 2); // cache is {1=1, 2=2}
            lRUCache.Get(1);    // return 1
            lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
            lRUCache.Get(2);    // returns -1 (not found)
            lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
            lRUCache.Get(1);    // return -1 (not found)
            lRUCache.Get(3);    // return 3
            lRUCache.Get(4);    // return 4

        }
    }
}
