using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelect : MonoBehaviour {
    private RaycastHit raycast;
    private bool menuGaze,homeGaze,cancelGaze,TYGaze,LNGaze,GSGaze,CPGaze;
    private float startTime;
    public GameObject Menu, Home, Cancel, TY, LN, GS, CP;
    public GameObject MenuBtn, ExploreCanvas;
    public GameObject FPSTransform, CamTransform, MenuTransform;
    private Transform FPSTransformorigin, CamTransformorigin, MenuTransformorigin;
    public GameObject TYMain, LNMain, GSMain, CPMain;
    // Use this for initialization
    void Start () {
        menuGaze = false;
        homeGaze = false;
        cancelGaze = false;
        TYGaze = false;
        LNGaze = false;
        GSGaze = false;
        CPGaze = false;
        FPSTransformorigin = FPSTransform.transform;
        CamTransformorigin = CamTransform.transform;
        MenuTransformorigin = MenuTransform.transform;

    }
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(Camera.main.transform.position,Camera.main.transform.forward*50.0f,Color.red,0.5f);
       if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out raycast,50.0f)) {
            if (raycast.collider.tag == "Menu")
            {
                if(menuGaze==false)
                {
                    menuGaze = true;
                    startTime = Time.time;
                   Menu.SetActive(true);
                   Menu.GetComponent<Animator>().Play("GazeFill");
                }
                else
                {
                    if (Time.time - startTime >= 3.0f) {
                        Menu.SetActive(false);
                        MenuBtn.SetActive(false);
                        ExploreCanvas.SetActive(true);
                    }
                }
               
            }
            else if (raycast.collider.tag == "Home")
            {
                if (homeGaze == false)
                {
                    print("home");
                    homeGaze = true;
                    startTime = Time.time;
                    Home.SetActive(true);
                    Home.GetComponent<Animator>().Play("GazeFill");
                    TYMain.SetActive(false);
                    LNMain.SetActive(false);
                    GSMain.SetActive(false);
                    CPMain.SetActive(false);
                }
                else
                {
                    if (Time.time - startTime >= 3.0f)
                    {
                        FPSTransform.transform.position = FPSTransformorigin.position;
                        CamTransform.transform.position = CamTransformorigin.position;
                        MenuTransform.transform.position = MenuTransformorigin.position;
                    }
                }

            }
            else if (raycast.collider.tag == "Cancel")
            {
                if (cancelGaze == false)
                {
                    cancelGaze = true;
                    startTime = Time.time;
                    Cancel.SetActive(true);
                    Cancel.GetComponent<Animator>().Play("GazeFill");
                }
                else
                {
                    if (Time.time - startTime >= 3.0f)
                    {
                        MenuBtn.SetActive(true);
                        ExploreCanvas.SetActive(false);
                    }
                }

            }
            else if (raycast.collider.tag == "TY")
            {
                if (TYGaze == false)
                {
                    TYGaze = true;
                    startTime = Time.time;
                    TY.SetActive(true);
                    TY.GetComponent<Animator>().Play("GazeFill");
                }
                else
                {
                    if (Time.time - startTime >= 3.0f)
                    {
                        FPSTransform.transform.position = new Vector3(FPSTransformorigin.position.x +30, FPSTransformorigin.position.y, FPSTransformorigin.position.z+30);
                        CamTransform.transform.position = new Vector3(CamTransformorigin.position.x + 30, CamTransformorigin.position.y, CamTransformorigin.position.z + 30);
                        MenuTransform.transform.position = new Vector3(MenuTransformorigin.position.x + 30, MenuTransformorigin.position.y, MenuTransformorigin.position.z + 30);
                        TYMain.SetActive(true);
                        LNMain.SetActive(false);
                        GSMain.SetActive(false);
                        CPMain.SetActive(false);
                    }
                }

            }
            else if (raycast.collider.tag == "LT")
            {
                if (LNGaze == false)
                {
                    LNGaze = true;
                    startTime = Time.time;
                    LN.SetActive(true);
                    LN.GetComponent<Animator>().Play("GazeFill");
                }
                else
                {
                    if (Time.time - startTime >= 3.0f)
                    {
                        FPSTransform.transform.position = new Vector3(FPSTransformorigin.position.x + 30, FPSTransformorigin.position.y, FPSTransformorigin.position.z);
                        CamTransform.transform.position = new Vector3(CamTransformorigin.position.x + 30, CamTransformorigin.position.y, CamTransformorigin.position.z);
                        MenuTransform.transform.position = new Vector3(MenuTransformorigin.position.x + 30, MenuTransformorigin.position.y, MenuTransformorigin.position.z );

                        TYMain.SetActive(false);
                        LNMain.SetActive(true);
                        GSMain.SetActive(false);
                        CPMain.SetActive(false);
                    }
                }

            }


            else {
                menuGaze = false;
                homeGaze = false;
                cancelGaze = false;
                TYGaze = false;
                LNGaze = false;
                GSGaze = false;
                CPGaze = false;
                Menu.SetActive(false);
                Home.SetActive(false);
                Cancel.SetActive(false);
                TY.SetActive(false);
                GS.SetActive(false);
                CP.SetActive(false);
                LN.SetActive(false);

            }
        }
	}
}
