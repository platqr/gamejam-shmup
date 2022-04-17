using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColibriBullet : MonoBehaviour
{
    private float speed = -20;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move(){
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0), Space.World);
    }
}
