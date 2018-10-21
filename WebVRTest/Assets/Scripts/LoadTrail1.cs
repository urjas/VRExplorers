using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTrail1 : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForSeconds(10.0f);
        SceneManager.LoadScene("Trail1");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
