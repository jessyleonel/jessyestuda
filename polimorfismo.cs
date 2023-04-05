using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polimorfismo : MonoBehaviour
{
    //varias formass de fazer a mesma coisa
    leao leo;
    gato cat;

    void Start()
    {
        leo = new leao();
        cat = new gato();

        leo.comer();
        cat.comer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class animal : MonoBehaviour
{
    public virtual void comer()
    { print("Animal está comento."); }

}

class leao : animal
{
    public override void comer()
    {
        print("Leão está comendo.");
    }
}

class gato : animal
{
    public override void comer()
    {
        print("Gato está comendo.");
    }
}