using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecao_List : MonoBehaviour
{
    
    void Start()
    {
        print("Lista Número Inteiro");
        //Chama a list <escolhe com o que vai
        //trabalhar> NOME = cria newlist<>()
        List<int> Lista = new List<int>();

        Lista.Add(100); //ind 0
        Lista.Add(200); //ind 1
        Lista.Add(300); //ind 2
        //chama o resultado 100
        print(Lista[0]);

        Lista.Remove(100); //tira o 100
        //chama o resultado 200
        print(Lista[0]);
        
        //para mostrar o indice
        print("Qual indíce do 300?");
        print(Lista.IndexOf(300));

        print("Lista de Números Int. com Laços)");

        List<int> numeral = new List<int>();
        //preencher a lista automaticamente
        for(int i = 0; i<=9; i++) 
        {
            numeral.Add(i);
         
        }
        //faz a varredura na lista
        foreach (int valores in numeral) 
        {
            //mostra a lista
            print(valores);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
