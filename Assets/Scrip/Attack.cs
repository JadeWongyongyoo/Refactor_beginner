using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{ 
    int Damage = 1 ;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Sliam slime = collision.GetComponent<Sliam>(); 
        if(slime != null)
        {
            slime.TakeDamage(Damage);
        }
    }
    // Update is called once per frame

    void Update()
    {
        
    }
}
