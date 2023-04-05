using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisebase : MonoBehaviour
{
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
class pai : MonoBehaviour
{
    public int idade = 30;
}
class filho : pai
{
    public void pegaIdade()
    {
        print(base.idade); //pega a idade base do pai
    }
}