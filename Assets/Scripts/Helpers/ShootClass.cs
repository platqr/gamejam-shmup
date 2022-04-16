using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootClass : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _bullet;
    public float timeRemaining = 1;
    public float _hp;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        } else {
            timeRemaining = 1;
            Shoot();
        }
    }
    
    void Shoot()
    {
        Instantiate(_bullet, gameObject.transform.position, Quaternion.identity);
    }

    private void GetDamage(){
        if (--_hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "PlayerBullet"){
            GetDamage();
        }
    }
}
