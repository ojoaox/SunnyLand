using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nomePersonagem = "Raposo";
    private int vidaInicial = 10;
    private float velocidadeMovimento = 2.5f;
    private bool estaVivo = true;
    private Rigidbody2D rb;
    public float novaGravidade = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nome: \n" + nomePersonagem + "\n Vida: " + vidaInicial);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
