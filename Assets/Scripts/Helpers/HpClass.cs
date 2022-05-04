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
        takeDamage.Play();
        if (--hp <= 0)
        {
            explosionEffect.Play();
            // Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other);
        if(other.tag == "PlayerBullet"){
            GetDamage();
            // Destroy(other.gameObject);
        }
    }
}
