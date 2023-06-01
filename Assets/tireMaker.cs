using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tireMaker : MonoBehaviour
{
    public GameObject tirePrefab;
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
            GameObject tire = Instantiate(tirePrefab);

            int x = Random.Range(-6, 6);
            int y = Random.Range(-2, 1);

            tire.transform.position = new Vector3(x, y, 0);
        }
    }
}
