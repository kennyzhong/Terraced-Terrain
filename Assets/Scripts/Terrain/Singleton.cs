﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class Singleton<T> where T : new()
{
    static T _instance;
    static object _lock = new object();

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                }
            }
            return _instance;
        }
    }
}

