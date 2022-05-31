using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private Text scoreText;
    [SerializeField] private float speed = 2;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Vertical");
        print(horizontal);
        rigidbody.velocity = new Vector2(horizontal * speed, rigidbody.velocity.y);
        float vertical = Input.GetAxis("Horizontal");

        
        print(vertical);
        rigidbody.velocity = new Vector2(vertical * speed, rigidbody.velocity.x);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "points")
        {
            print("hit");
            Destroy(collision.gameObject);
            score+=5;
            scoreText.text = score.ToString();
        }
        if (collision.tag == "enemy")
        {
            print("hit");
            Destroy(collision.gameObject);
            score--;
            scoreText.text = score.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
