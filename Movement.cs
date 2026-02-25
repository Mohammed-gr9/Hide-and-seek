using UnityEngine;
using UnityEngine.InputSystem;


public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    private Vector2 input;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputValue value)
    {
        input = value.Get<Vector2>();
    }

     
    
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime);
    }



}

