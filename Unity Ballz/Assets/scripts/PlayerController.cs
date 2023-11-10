using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10;

    private float xInput;
    private float yInput;
    // Start is called before the first frame update
    // Awake gets called when the game loads not when the game starts
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // good for movement processing   
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        //good for movement
        Move();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        // rename this z input so it makes more sense
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, yInput) * moveSpeed);
    }
}
