using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
/*Classe é molde, forma, com caracteristicas 
e ações utilizada para criar um objeto*/
{
    //Criação do Obj. Felino publico
    felino gatoFase1;
    felino gatoFase2;
    filha fi;

    void Start()
    {
        gatoFase1 = new Felino();
        gatoFase2 = new Felino();

        gatoFase1.nome == "Peludo";
        gatoFase1.corPelo == "Amarelo";
        gatoFase1.forca == 1;
        gatoFase1.defender == 1;
        

        gatoFase2.nome == "Garrinha";
        gatoFase2.corPelo == "Frajola";
        gatoFase2.forca == 2;
        gatoFase2.defender == 3;

        fi.atacar == 0;
        fi.atacar == 10;
        fi.acessa();
        

        /*fidefender.nome == "Fofinha";
        fidefender.corPelo == "Branco";
        fidefender.forca == 10;*/
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//Criação da Classe Felino (RAÇA)
class felino
{
    //características = atributos
    public string nome; //com public acesso em  
                        //todas as classes private tira acesso deixa privado
    protected string corPelo; //protected ele protege, da pra trabalhar dentro da classe e na classe filha
    public int forca;

    //ações = métodos
    public void atacar() { }
    public void defender () { }
}

class filha : felino
{
    public void acessa() //usa pra acessar o protected da classe que é filha
    {
        print(corPelo = "Vermelho1");
    }
    
}
 

