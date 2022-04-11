using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapsingPlat : MonoBehaviour
{
    private float elapsed = 0f;
    private float reappear = 0f;

    public bool disapear = false;
    public bool PlayerOn = false;

    // Update is called once per frame
    void Update()
    {
        DisapearOn();
    }
    void DisapearOn(){
if(PlayerOn){
    disapear = true;
        elapsed += Time.deltaTime;
        if (elapsed >= 4f)
        {
            elapsed = elapsed % 1f;
            gameObject.SetActive(false);
            PlayerOn = false;
            elapsed = 0f;
        }
}
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerOn = true;
        }
    }
}
