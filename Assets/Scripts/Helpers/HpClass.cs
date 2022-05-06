using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpClass : MonoBehaviour
{
    public float hp;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void GetDamage(){
        if (--hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "PlayerBullet"){
            GetDamage();
            Destroy(other.gameObject);
        }
    }
}
