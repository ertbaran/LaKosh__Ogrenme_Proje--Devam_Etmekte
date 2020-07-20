using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float sagMiktar=2;
    public float solMiktar=2;
    public AudioSource ses_kaynak;
    public AudioClip move;

    public void GoRight() { 
        rb.position = rb.position + new Vector2(sagMiktar,0);
        ses_kaynak.PlayOneShot(move);
    }
    public void GoLeft()
    {
        rb.position = rb.position + new Vector2(-solMiktar, 0);
        ses_kaynak.PlayOneShot(move);
    }
}
