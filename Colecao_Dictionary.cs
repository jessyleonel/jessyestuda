using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecao_Dictionary : MonoBehaviour
{
    
    void Start()
    {
        //abre dicionario <define o que vai trabalhar>
        //da nome a variavel e = cria novo dicionario
        Dictionary<string,string> malvado = new Dictionary<string,string>();

        //adiciona lista de nomes (Nome, result)
        malvado.Add("Matador", "� o primeiro vil�o");
        malvado.Add("Atirador", "� o segundo vil�o");

        foreach(string chave in malvado.Keys)
        {
            //percorre a lista e exite a chave
            print(malvado[chave]);
            //pode criar condi��o 
            if (chave == "Atirador")
            {
                print(malvado[chave]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
