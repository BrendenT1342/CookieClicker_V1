using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform parentObject;

    void Start()
    {
        //while
        //do while
        //for
        //foreach

        //< is less than
        //< = is less than or equal to
        //> is greater than
        //>= is greater than or equal to
        //== is equal
        //!= is not equal to

        int count = 0;
        while (count < 10)
        {
            count += 1;
            
            SpawnObject();
        }
        
        //any code that's here
    }

    public void SpawnObject()
    {
        Instantiate(spawnPrefab, parentObject.position, Quaternion.identity, parentObject);
    }



}
