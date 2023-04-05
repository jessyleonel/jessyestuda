using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scopo : MonoBehaviour
    //scopo é o corpo, determinado por chaves
{
    int valor = 10; //se declarar a variavel
                    //aqui pode utilizar em todas
                    //as scopo que estão dentro da
                    //class
    void Start()
    {
        int valor = 10; //só consigo usar essa
        print(valor);   //variavel dentro desse scopo
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
