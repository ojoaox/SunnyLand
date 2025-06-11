using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    private int pontos = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Jogo Começou! Você tem: " + pontos + " pontos");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Jogo Rodando");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("yes");
        }
    }
}
