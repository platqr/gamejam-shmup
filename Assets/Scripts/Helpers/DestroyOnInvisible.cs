using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnInvisible : MonoBehaviour
{
    private bool enteredScene;
    // Start is called before the first frame update
    void Start()
    {
        enteredScene = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnBecameVisible() {
        enteredScene = true;
        
    }
    private void OnBecameInvisible() {
        if(enteredScene) {
            Destroy(gameObject);
        }
        
    }

}
