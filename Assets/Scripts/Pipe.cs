using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pipe : Sounds
{

    [SerializeField] private float Speed;


    void FixedUpdate()
    {
        transform.Translate(Vector2.left * Speed * Time.fixedDeltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out _))
        {
            ScoreManager.Instance.UpdateScore();
            PlaySound(0, random: true);
        }
    }

}
