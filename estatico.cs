using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estatico : MonoBehaviour
{
    
    void Start()
    {
        int returno = metodo.soma(2,20);
        print(returno);
    }

    
    void Update()
    {
        
    }
}
class metodo
{
    //não precisa criar objeto
    public static int soma(int valor1, int valor2)
    {
        int result = valor1 + valor2;

        return result;
    }

}
