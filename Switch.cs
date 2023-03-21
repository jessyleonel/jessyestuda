using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    //Declaração de Variaveis

    /*
    Estado = 1-coragem
    Estado = 2-meio termo
    Estado = 3-covardia 
    */

    int estados = 0;


    void Start()
    {
        print("IF, ELSE IF e ELSE");
        if (estados == 1) { print ("Mate o Herói");}
        else if (estados == 2) {print ("Mate se puder");}
        else if (estados == 3) {print ("Corra Agora");}
        else { print ("De Boas"); }

        print ("Switch"); //ficar compacto e bonito
        switch (estados)
        {
            case 1 : //então
                print ("Mate o Herói");
                break; //para a ação
            case 2: //então
                print ("Mate se puder");
                break; //para a ação
            case 3: //então
                print ("Corra Agora");
                break; //para a ação
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
