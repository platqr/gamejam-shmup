using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    private float _speed = 50;//120;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0), Space.World);
        if(transform.position.x >= 35){
            Destroy(gameObject);
        }
    }
}
