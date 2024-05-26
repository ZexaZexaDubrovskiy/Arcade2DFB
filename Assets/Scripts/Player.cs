using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Barrier"))
        {
            GameManager.instance.Lose();
        }
    }


}
