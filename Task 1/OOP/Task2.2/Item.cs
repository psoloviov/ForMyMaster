﻿using System;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;

namespace Task2._2
{
    public class Item<T>
    {
        private T data = default(T);

        public T Data
        {
            get => data;
            set
            {
                if (value == null) data = value; else throw new ArgumentNullException(nameof(value));
            }
            
        }

        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
        
    }
}