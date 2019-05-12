using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    public int speed;

    private Vector2 direction;


    void Update()
    {
        GetInput();
        Move();
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // set in hreyfingar
    void GetInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
    }
}
