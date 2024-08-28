using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Stack
{
    private string[] memoria;
    private int size;
    private int count;

    public Stack(int inSize = 5)
    {
        size = inSize;
        memoria = new string[size];
        count = 0;
    }

    public bool Push(string meComplete)
    {
        if (count == size)
            return false;
        memoria[count] = meComplete;
        count = count + 1;
        return true;
    }

    public string Pop()
    {
        if (count == 0)
            return null;
        string meRetire = memoria[count - 1];
        count = count - 1;
        return meRetire;
    }

    public string Top()
    {
        if (count == 0)
            return null;
        return memoria[count - 1];
    }

    public int Size()
    {
        return size;
    }

    public int Count()
    {
        return count;
    }
}
