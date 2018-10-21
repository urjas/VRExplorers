using UnityEngine;
using System.Collections;
using System;

public class Walk : MonoBehaviour {
    private float previous, current;
    private bool up, down;
    public CharacterController astro;
    int i = 0;
    WebSocket w;

  // Use this for initialization
  IEnumerator Start()
    {
       w = new WebSocket(new Uri("ws://192.168.225.110:81"));
        yield return StartCoroutine(w.Connect());
        // w.SendString("Hi there");
        while (true)
        {
            string reply = w.RecvString();
            if (reply != null)
            {
                Debug.Log("Received: " + reply);
                try
                {
                    current = (float)Convert.ToDouble(reply);
                    i++;
                    if (current >= 0.0f)
                    {
                        up = true;
                    }
                    if (current <= 0.0f)
                    {
                        down = true;
                    }
                }
                catch { }
                // w.SendString("Hi there" + i++);
            }
            if (w.error != null)
            {
                Debug.LogError("Error: " + w.error);
                break;
            }
            yield return 0;
        }
        w.Close();
    }

    void Update()
    {
       
            if (i > 60)
        {
            if (up && down)
            {
                //astro.Move(Vector3.forward * Time.deltaTime);
            }
            up = false;
            down = false;
            i = 0;
        }
    }
}
