using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo
{
    
    void Start()
    {
        Queue queue = new Queue(15);
        queue.EnQueue(15);
        queue.EnQueue(3);
        queue.EnQueue(1);
    }
}
