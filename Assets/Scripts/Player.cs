using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mapWidth = 4f;
    public float sag_miktar = 2;
    public float sol_miktar = 2;
    Rigidbody2D rb;
    public GameObject bd;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 newPosition = rb.position;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.position = rb.position + new Vector2(sag_miktar, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.position = rb.position + new Vector2(-sol_miktar, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision2d)
    {
        if (collision2d.gameObject.tag == "Enemy")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collision2d.gameObject.tag =="Patlak")
        {
            // gameobject(particule) set active true (animasyon suresı yaklasık 1 sn - no loop)
        }
    }
}
