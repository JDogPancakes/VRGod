using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;

    private List<GameObject> clouds;
    void Start()
    {
        clouds = new List<GameObject>();

        StartCoroutine(SpawnCloud());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnCloud()
    {
        if(clouds.Count < 4)
        {
           GameObject cloud = Instantiate(cloudPrefab, transform);
            clouds.Add(cloud);
        }

        yield return new WaitForSeconds(20f);

        StartCoroutine(SpawnCloud());   
    }
}
