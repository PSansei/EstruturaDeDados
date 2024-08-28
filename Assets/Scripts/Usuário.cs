using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuário : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stack pilha = new Stack();
        pilha.Push("AAAAAAA");
        Debug.Log(pilha.Top());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
