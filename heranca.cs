using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heranca : MonoBehaviour
{
    // pela heranca a classe herda tudo da outra classe
    pai p;
    filho f;

    void Start()
    {
        p = new pai();
        f = new filho();
        f.pegaIdade();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class pai
{
    public int idade = 30;
}
class filho : pai
{
    public void pegaIdade()
    {
       base.idade;
    }
}