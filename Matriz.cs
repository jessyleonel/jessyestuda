using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matriz : MonoBehaviour
{
    // Matriz a diferença esta na , entre [] que avisa o x e y
    void Start()
    {
        print("Matriz"); //é uma tabela linha e coluna
        int[,] matriz = new int[2, 2];

        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;

        print(matriz[0, 0]);

        print("Matriz com Laço");

        int[,] maatriz = new int[2, 2];
        int valor = 1;

        for (int linhas = 0; linhas <= 1; linhas++) //define a quantidade de linhas
        {
            for (int colunas = 0; colunas <= 1; colunas++)//define a quantidade de colunas
            {
                maatriz[linhas, colunas] = valor; //matriz tem a linha e a coluna e cada uma possui um valor
                valor++; //diferente
            }
        }
        for (int linhas = 0; linhas <= 1; linhas++) //repete o laço para poder exibir o resultado
        {
            for (int colunas = 0; colunas <= 1; colunas++)
            {
                print(linhas + ":" + colunas + "=" + maatriz[linhas, colunas]);
            }

        }
    }

        // Update is called once per frame
        void Update()
        {

        }
}
