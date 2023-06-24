using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ControllerDisparar : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bullet;

    public float fireRate = 2f; // Intervalo de tiempo entre cada disparo
    private float nextFireTime; // Tiempo para el próximo disparo

    Rigidbody2D rb;
    Animator animator;
    private int currentAnimation = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        nextFireTime = Time.time + fireRate; // Establecer el próximo tiempo de disparo
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        currentAnimation = 1;

        // Verificar si ha pasado suficiente tiempo para disparar
        if (Time.time >= nextFireTime)
        {
            
            Shoot(); // Disparar
            nextFireTime = Time.time + fireRate; // Actualizar el próximo tiempo de disparo
            currentAnimation = 2;

        }
        animator.SetInteger("Estado", currentAnimation);
    }
    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
