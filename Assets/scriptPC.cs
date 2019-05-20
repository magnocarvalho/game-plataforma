using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    //Criar a variável de referência ao rigidbody
    private Rigidbody2D rbd;
    private Animator anim;
    //Criar variável que representa a velocidade
    public float velocidade;
    private bool dir = true;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 5;
        //Criar a referência de fato
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Capturar teclado
        float dirX = Input.GetAxis("Horizontal");
        //Alterar velocidade
        rbd.velocity = new Vector2(dirX * velocidade, rbd.velocity.y);


        if (dirX == 0)
            anim.SetBool("andar", false);
        else
            anim.SetBool("andar", true);


        if (dirX < 0 && dir || dirX > 0 && !dir)
        {
            transform.Rotate(new Vector2(0, 180));
            dir = !dir;
        }



        //transform.Translate(new Vector2(dirX * velocidade * Time.deltaTime,0));
    }
}
