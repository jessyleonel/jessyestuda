using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour { 
 
    //  nomes das variaveis compativeis com o que faz
    int moedas; // Variávei de número inteiro
    float dinheiro; // Variável de número flutuante
    bool duvida = true; // Verdadeiro ou falso
    string texto = "Olá mundo!"; //Escritas

    /*
 
    Tudo dentro disso é comentário
 
    */

    // Chama uma vez
    void Start()
    {
        dinheiro = 03.2023f;
        moedas = 17;

        print(moedas);
        print(dinheiro);
        print(duvida);
        print(texto);
    }
   
    // Chama 1v por frame
    void Update()
    {
        

    }
}
