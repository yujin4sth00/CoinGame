using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tireController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col) {
        GameObject score = GameObject.Find("SCOREControl");

        if (col.gameObject.tag == "Girl")
        {
            score.GetComponent<scoreController>().AddScore();
        }
        Destroy(gameObject);
    }
}
