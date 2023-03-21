using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increm_Decremento : MonoBehaviour
{
    //Variáveis
    int carteira = 100;
    
    void Start()
    {
        //Incremento
        print(carteira++); //posincremento e mostra resultado sem incremento, pq é pós
        print(carteira); //mostra o resultado do pós incremento
        print(++carteira); //preincremento e mostra resultado com decremento, pq é pré
        //Decremento
        print(carteira--); //posdecremento e mostra resultado sem decremento, pq é pós
        print(carteira); //mostra o resultado do pós decremento
        print(--carteira); //predecremento e mostra resultado com decremento, pq é pré
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
