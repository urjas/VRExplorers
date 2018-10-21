using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2 : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(30.0f);
        SceneManager.LoadScene("Trail");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
