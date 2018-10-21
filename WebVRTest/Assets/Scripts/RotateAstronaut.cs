using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAstronaut : MonoBehaviour {

    public Transform cameraMain,cameraPosition, FPS,Menu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //FPS.eulerAngles = new Vector3(cameraMain.eulerAngles.x, cameraMain.eulerAngles.y, 0);
        //Menu.position = FPS.position;
        //cameraPosition.position = FPS.position;
    }
}
