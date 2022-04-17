using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpClass : MonoBehaviour
{
    public AudioSource explosionEffect;
    public AudioSource takeDamage;
    public float hp;

    // Start is called before the first frame update
    void Start()
    {
        explosionEffect = GetComponent<AudioSource>();
        takeDamage = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void GetDamage(){
        takeDamage.Play(0);
        if (--hp <= 0)
        {
            explosionEffect.Play(0);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "PlayerBullet"){
            GetDamage();
        }
    }
}
