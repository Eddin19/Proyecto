using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBala : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * -speed;
        Destroy(gameObject, 8f);
    }
}
