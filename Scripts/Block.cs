using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] float speed=2.5f;
    bool pointGiven;
    private void Update()
    {
        transform.position += Vector3.left * speed*Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!pointGiven)
        {
            pointGiven = true;
            FindObjectOfType<GameManager>().AddScore();
        }
    }
}
