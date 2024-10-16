using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 900f;
    public Rigidbody2D rb;
    float move;
    public bool Nave;
    Vector3 starPos;

    // Start is called before the first frame update
    void Start()
    {
        starPos = transform.position;
    }

    // Update is called once per frame
    public void Update()
    {

        if (Nave)
        {
            move = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
        }

    }
    public void Reset()
    {
        transform.position = starPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("meteorito"))
        {
            Reset();

        }
    }
}
