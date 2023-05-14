using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Alien;

    public float xSpace;
    public float xOffset;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            Instantiate(Alien, new Vector2(x * xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(Alien, new Vector2(x * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(Alien, new Vector2(x * xSpace + xOffset, 4.5f), Quaternion.identity);
        }
    }


}
