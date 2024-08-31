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

        if(_front != 0 && _rear == _size)
        {
            for (int i = 0; i < _count; i++)
                _memory[i] = _memory[_front + i];

            _front = 0;
            _rear = _count;
        }   
            

        _memory[_rear++] = value;
        ++_count;
        return true;
    }

    public int DeQueue()
    {
        if (IsEmpty())
        {
            Debug.Assert(true, "Out of bounds!");
        }

        --_count;
       return _memory[_front++];
    }

    public bool IsFull() { return _count == _size; }
    public bool IsEmpty() { return _front == _rear; }



}

 public class QueueLoop
{
    private int[] _memory;
    private int _size;
    private int _count;
    private int _front;
    private int _rear;



    public QueueLoop(int size = 10)
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

        _rear = ++_rear % _size;
        _memory[_rear] = value;
        ++_count;
        return true;
    }

    public int DeQueue()
    {
        if (IsEmpty())
        {
            Debug.Assert(true, "Out of bounds!");
        }

        --_count;
        int result = _memory[_front];
        _front = ++_front % _size;
        return result; 
    }

    public bool IsFull() { return _count == _size; }
    public bool IsEmpty() { return _front == _rear; }
}
