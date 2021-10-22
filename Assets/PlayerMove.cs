using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Vector2 moveVec;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMove(InputValue input)
    {
        moveVec = input.Get<Vector2>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveVec.x, 0, moveVec.y);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.fixedDeltaTime);

    }
}
