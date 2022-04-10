using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHazard : MonoBehaviour
{
    public float speed = 30; 
    public Transform groundCheck;
    public float groundRadius;
    public LayerMask groundLayerMask;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move(){
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayerMask);
        
        if(isGrounded){
        transform.Translate(Vector3.up*speed*Time.deltaTime); 
        }
        else if (!isGrounded){
        transform.Rotate(0.0f, 0.0f, 180.0f); 
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(groundCheck.position, groundRadius);
    }
    //void OnTriggerEnter2D(Collider2D col)
    //{
      //  if (col.gameObject.tag == "Ground")
       // {
       //     Debug.Log("onGround");
        //transform.Translate(Vector3.left*speed*Time.deltaTime); 
       // }
        //if (col.gameObject.tag != "Ground")
        //{
        //    Debug.Log("offGround");
        //transform.Rotate(0.0f, 0.0f, 180.0f); 
        //}
    //}
}
