using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Manager : MonoBehaviour
{
    public float gravitySpeed = 1;
    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += gravitySpeed * Time.timeSinceLevelLoad / 20;
    }
    void Update()
    {
        if (transform.position.y <-2f)
        {
            Destroy(gameObject);
        }
    }
}
