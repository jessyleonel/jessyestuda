using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapsul : MonoBehaviour
{
    pai p;

    void Start()
    {
        p = new pai();
        print(p.Idade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class pai : MonoBehaviour
{
    private int idade = 10;//propriedade não tem parenteses 
    public int Idade
    {
        get { return idade; }
        set { if (value > 10) { idade = value; }
            else
            {
                print("Erro!");
            }
        }
    }
    
}