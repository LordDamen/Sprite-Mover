using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    // setting the speed that the sprite is allowed to move
    public float speed = 1.5f;

    void Update()
    {
        //getting the Input for left arrow key
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //moving the sprite
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //getting the Input for right arrow key
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //moving the sprite
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //getting the Input for up arrow key
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //moving the sprite
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        //getting the Input for down arrow key
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //moving the sprite
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.L))
        {
            speed = -speed;
        }
    }
}