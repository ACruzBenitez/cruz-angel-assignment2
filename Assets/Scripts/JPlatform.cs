using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JPlatform : MonoBehaviour
{
    public Transform PlayerCheck;
    public float PlayerRadius;
    public LayerMask PlayerLayerMask;
    public bool PlayerOn;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }   
     // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move(){
        PlayerOn = Physics2D.OverlapCircle(PlayerCheck.position, PlayerRadius, PlayerLayerMask);
        
        if(PlayerOn){
            animator.SetTrigger("PJump");
        }
        else{
            animator.ResetTrigger("PJump");           
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(PlayerCheck.position, PlayerRadius);
    }
}
