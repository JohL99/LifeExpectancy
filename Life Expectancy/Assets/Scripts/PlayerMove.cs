using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public float speed;

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
       float move = Input.GetAxis("Horizontal");

       rb.velocity = new Vector2(speed * move, rb.velocity.y);
       //anim.Play("PlayerMove");


       if (Input.GetKeyDown ("space")){
               transform.Translate(Vector3.up * 100 * Time.deltaTime, Space.World);
               //anim.Play("PlayerJump");
      }
    }
}
