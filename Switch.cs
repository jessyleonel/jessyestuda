using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    //Declara��o de Variaveis

    /*
    Estado = 1-coragem
    Estado = 2-meio termo
    Estado = 3-covardia 
    */

    int estados = 0;


    void Start()
    {
        print("IF, ELSE IF e ELSE");
        if (estados == 1) { print ("Mate o Her�i");}
        else if (estados == 2) {print ("Mate se puder");}
        else if (estados == 3) {print ("Corra Agora");}
        else { print ("De Boas"); }

        print ("Switch"); //ficar compacto e bonito
        switch (estados)
        {
            case 1 : //ent�o
                print ("Mate o Her�i");
                break; //para a a��o
            case 2: //ent�o
                print ("Mate se puder");
                break; //para a a��o
            case 3: //ent�o
                print ("Corra Agora");
                break; //para a a��o
            default :
                print ("De Boas");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
