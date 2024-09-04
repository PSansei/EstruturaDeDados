using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaDoVini<T>
{
    private T[] memory;
    private int size;
    private int count;
    private int front;
    private int rear;

    public FilaDoVini(int uSize = 5)
    {
        size = uSize;
        count = 0;
        front = 0;
        rear = 0;
        memory = new T[uSize];
    }

    public bool Enqueue(T valor)
    {
        if (count == size)
            return false;

        memory[rear] = valor;
        count++;
        rear++;
        if (rear == size)
            rear = 0;
        return true;
    }

    public T Dequeue()
    {
        if (count == 0)
            Debug.Assert(false, "Seu jogo foi de base porque a fila estava vazia, burro");

        T valor = memory[front];
        count--;
        front++;
        if (front == size)
            front = 0;
        return valor; 
    }
}
