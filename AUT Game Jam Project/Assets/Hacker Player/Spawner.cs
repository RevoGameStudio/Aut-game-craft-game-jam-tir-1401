using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public Transform spawnPoint;
    public void Spawn()
    {
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}
