using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
     private Rigidbody2D rb;
     private PlayerStats st;
    void Start()
    {
              rb = gameObject.GetComponent<Rigidbody2D>();
              st = gameObject.GetComponent<PlayerStats>(); 
    }
 private float SpeedX = 0, SpeedY = 0;
    // Update is called once per frame
     public void Up()
    {
        SpeedX = 0;
        SpeedY = st.Speed;;
    }
     public void Down()
    {

        SpeedX = 0;
        SpeedY = -st.Speed;;
    }
    public void Left()
    {
       ;
        SpeedX = -st.Speed;;
        SpeedY = 0;
    }
    public void Right()
    {
        SpeedX = st.Speed;;
        SpeedY = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Up();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           Down();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Left();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Right();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Up();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           Down();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Left();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Right();
        }
               rb = GetComponent<Rigidbody2D> ();
               rb.gravityScale = st.gravityscales;
        rb.velocity = new Vector2(SpeedX, SpeedY);
    }
}
