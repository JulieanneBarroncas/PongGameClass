using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed; //velocidade da bola
    public Vector2[] startDirection; //lista de posições
    public AudioSource ballSound; //referencial do som da bola


    // Start is called before the first frame update
    void Start()
    {
        //direção aleatoria da bola com lista pronta na unity
        int selectedStartDirection = Random.Range(0, 3); //int = valor inteiro, posição de algo
        rb.velocity = startDirection[selectedStartDirection] * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //som da bola e pontos de regras
        if (!collision.gameObject.CompareTag("LeftBorder") && !collision.gameObject.CompareTag("RightBorder")) 
        {
        ballSound.Play();
        }


    
        if (collision.gameObject.CompareTag("LeftBorder"))
        {
            GameObject.FindAnyObjectByType<GameControler>().AddScore(true);

        }

        if (collision.gameObject.CompareTag("RightBorder"))
        {
            GameObject.FindAnyObjectByType<GameControler>().AddScore(false);
        }

    }

}
