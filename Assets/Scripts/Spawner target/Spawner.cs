using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spherePrefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(spherePrefab, transform.position, transform.rotation);
        StartCoroutine(Erase());
        if (stopSpawning)
        {
            
            CancelInvoke("SpawnObject");
            
        }
    }

    public IEnumerator Erase()
    {
        yield return new WaitForSeconds(3);
        Destroy(GameObject.FindWithTag("TargetUnique"));
        Destroy(GameObject.FindWithTag("TargetUnique2"));
        Destroy(GameObject.FindWithTag("TargetUnique3"));
        Destroy(GameObject.FindWithTag("TargetUnique4"));
        Destroy(GameObject.FindWithTag("TargetUnique5"));
        Destroy(GameObject.FindWithTag("TargetUnique6"));
        Destroy(GameObject.FindWithTag("TargetUnique7"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
