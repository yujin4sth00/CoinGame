using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class hpController : MonoBehaviour
{
    GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HP");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HpControl() {
        hp.GetComponent<Image>().fillAmount -= 0.25f;
        if (hp.GetComponent<Image>().fillAmount <= 0) {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
