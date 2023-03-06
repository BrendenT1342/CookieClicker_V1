using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform parentObject;

    public int spawnCount = 0;
    public int spawnMultiplier = 1;

    public TMP_Text spawnCountText;

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
        //----------------------------------
        //int count = 0;
        //while (count < 10)
        //{
        //    count += 1;
        //    SpawnObject();
        //}
        //----------------------------------
        //IncreaseSpawnMultiplier(2);
    }
    public void SpawnMultipleObjects()
    {
        int count = 0;
        while (count < spawnMultiplier)
        {
            count += 1;
            SpawnObject();
        }
    }

    public void SpawnObject()
    {
        Instantiate(spawnPrefab, parentObject.position, Quaternion.identity, parentObject);
        spawnCount++; //spawnCount += 1; This line of code increases a number by 1
                     //spawnCount = beCount + 1;

        if(spawnCountText != null) // If spawnCountText is not empty
        {
            spawnCountText.text = spawnCount.ToString();
        }
    }

    public void IncreaseSpawnMultiplier(int increaseBy)
    {
        spawnMultiplier += increaseBy;
    }

}
