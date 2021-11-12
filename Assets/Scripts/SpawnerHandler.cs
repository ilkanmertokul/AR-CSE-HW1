using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHandler : MonoBehaviour
{

    [SerializeField] private GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnSingleObject", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnSingleObject()
    {
        Instantiate(objectToSpawn, this.transform);
    }

}
