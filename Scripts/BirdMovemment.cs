using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovemment : MonoBehaviour
{
    [SerializeField] float velocity = 4;
    [SerializeField] float rotSpeed = 10;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotSpeed);
    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        FindObjectOfType<GameManager>().EndGameMenu.SetActive(true);
    }
}
