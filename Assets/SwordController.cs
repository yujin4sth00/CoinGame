using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject hp = GameObject.Find("HPControl");
        if (col.gameObject.tag == "Girl")
        {
            hp.GetComponent<hpController>().HpControl();
        }

        Destroy(gameObject);
    }
}
