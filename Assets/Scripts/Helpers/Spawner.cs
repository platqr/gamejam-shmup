using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> objectsToSpawn = new List<GameObject>();

    public float timeToSpawn;
    private float currentTimeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        currentTimeToSpawn = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer() {
        if(currentTimeToSpawn > 0) {
            currentTimeToSpawn -= Time.deltaTime;
        } else {
            SpawnObject();
            currentTimeToSpawn = Random.Range(1,5);
            // currentTimeToSpawn = timeToSpawn;
        }
    }
    void SpawnObject() {
        int index = Random.Range(0, objectsToSpawn.Count);
        int range = Random.Range(-10, 10);

        for(int i = 0; i < Random.Range(1, 1); i++) {
            Instantiate(objectsToSpawn[index], transform.position + new Vector3(0, range + (i * 2), 0), Quaternion.identity);
        }
    }
}
