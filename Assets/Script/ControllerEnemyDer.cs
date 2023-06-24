using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerEnemyDer : MonoBehaviour
{
    public GameObject MoveA; // Punto A (derecha)
    public GameObject MoveB; // Punto B (izquierda)
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = MoveA.transform; // Comenzar en el punto A (izquierda)
    }

    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;

        if (point.x > 0)
        {
            // Mover hacia la derecha
            rb.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector3(1, 1, 1); // Mirar a la izquierda
        }
        else
        {
            // Mover hacia la izquierda
            rb.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector3(-1, 1, 1); // Mirar a la derecha
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == MoveA.transform)
        {
            currentPoint = MoveB.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == MoveB.transform)
        {
            currentPoint = MoveA.transform;
        }
    }
}
