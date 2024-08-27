﻿using Leetcode.Sort;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode.Medium
{

    public class LRUCache
    {
        private Dictionary<int, DataNode> cache = new Dictionary<int, DataNode>();
        private readonly DataNode head = new DataNode(0, 0);
        private readonly DataNode tail = new DataNode(0, 0);
        private readonly int capacity;

        private class DataNode
        {
            public DataNode Next;
            public DataNode Prev;
            public int value;
            public int key;
            public DataNode(int value, int key)
            {
                this.value = value;
                this.key = key;
            }
        }

        public LRUCache(int _capacity)
        {
            capacity = _capacity;
            head.Next = tail;
            tail.Prev = head;
        }

        public int Get(int key)
        {
            if (cache.TryGetValue(key, out var node))
            {
                Remove(node);
                Insert(node);
                return node.value;
            }
            else
            {
                return -1;
            }
        }

        private void Insert(DataNode node)
        {
            cache.Add(node.key, node);
            node.Next = head.Next;
            node.Next.Prev = node;
            head.Next = node;
            node.Prev = head;
        }

        private void Remove(DataNode node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            cache.Remove(node.key);
        }

        public void Put(int key, int value)
        {
            if (cache.TryGetValue(key, out var node))
            {
                Remove(node);
            }
            if (cache.Count == capacity)
            {
                Remove(tail.Prev);
            }
            Insert(new DataNode(key, value));
        }
    }
}
