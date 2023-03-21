using System; //converter em pastas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversoes : MonoBehaviour
{
    //Variaveis
    int carteira;
    int carteira1;
    float carteira2 = 10.5f;
    bool teste = true;
    string texto;
 

    // Start is called before the first frame update
    void Start()
    {
        carteira = (int)carteira2; //converto o float em numero int
        print(carteira);

        carteira1 = Convert.ToInt32(teste); 
        print(carteira1);

        texto = carteira.ToString(); //não trabalha com numero inteiro, é um nome convertido.
        print(texto);

        print(carteira + carteira1 + texto + "Olá meu Popoco!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
