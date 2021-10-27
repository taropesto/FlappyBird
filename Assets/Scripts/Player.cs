using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeedY_Up;
    public float maxSpeedY_Down;
    public Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {

        Rigidbody2D _rigid = GetComponent<Rigidbody2D>(); 

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 30f, ForceMode2D.Force); // Vector vers le haut = 0,1 - vers le bas = 1,0
        }

        if (_rigid.velocity.y > maxSpeedY_Up)
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedY_Up);
        }

        if (_rigid.velocity.y < maxSpeedY_Down)
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedY_Down);
        }

    }

    public void relaunchObject()
    {
        transform.position = initialPosition;
    }
}
