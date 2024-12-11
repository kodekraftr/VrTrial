using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercieController : MonoBehaviour
{
    public GameObject[] spheres; // Array to hold the original spheres
    public GameObject[] replicas; // Array to hold the replica spheres
    private int currentReplicaIndex = 0; // Index of the currently active replica

    void Start()
    {
        // Ensure only the first replica is active at the start
            replicas[0].SetActive(true);
            replicas[1].SetActive(false);
            replicas[2].SetActive(false);
            replicas[3].SetActive(false);
            replicas[4].SetActive(false);

            Debug.Log("Firts Activated------------------------------------------------------");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Registered----------------------------------------------------------");
        // Check if the colliding object is one of the spheres
       if(other.CompareTag("BlueSphere"))
       {
        replicas[0].SetActive(true);
        replicas[1].SetActive(false);
       }
    }
}
