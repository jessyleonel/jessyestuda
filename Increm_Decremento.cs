using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increm_Decremento : MonoBehaviour
{
    //Vari�veis
    int carteira = 100;
    
    void Start()
    {
        //Incremento
        print(carteira++); //posincremento e mostra resultado sem incremento, pq � p�s
        print(carteira); //mostra o resultado do p�s incremento
        print(++carteira); //preincremento e mostra resultado com decremento, pq � pr�
        //Decremento
        print(carteira--); //posdecremento e mostra resultado sem decremento, pq � p�s
        print(carteira); //mostra o resultado do p�s decremento
        print(--carteira); //predecremento e mostra resultado com decremento, pq � pr�
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
