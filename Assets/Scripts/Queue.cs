using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue
{
    private int[] _memory;
    private int _size;
    private int _count;
    private int _front;
    private int _rear;



    public Queue(int size = 10)
    {
        _size = size;
        _memory = new int[size];
        _count = 0;
        _front = 0;
        _rear = 0;
    }



    public bool EnQueue(int value)
    {
        if (IsFull())
            return false;

        _memory[_rear++] = value;
        ++_count;
        return true;
    }

    public bool IsFull() { return _count == _size; }



}

 public class QueueLoop
{
    private int[] _memory;
    private int _size;
    private int _count;
    private int _front;
    private int _rear;
}
