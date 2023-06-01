using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwordMaker : MonoBehaviour
{
    public GameObject swordPrefab;
    float interval = 2.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > interval)
        {
            delta = 0;
            GameObject sword = Instantiate(swordPrefab);
            int x = Random.Range(-8, 9);
            sword.transform.position = new Vector3(x, 6, 0);
        }
    }
}
