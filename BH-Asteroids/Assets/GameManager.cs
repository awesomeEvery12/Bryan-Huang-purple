using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //start at 0 and stops when it reaches 4, so 4 total loops
        for(int i = 0; i < 4; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), 8f);
            Instantiate(rockPrefab, randomPosition, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
