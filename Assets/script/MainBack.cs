using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBack : MonoBehaviour
{
    public GameObject Main;
    public GameObject GameObject2;
    public GameObject GameObject3;
    public GameObject GameObject4;
    public GameObject GameObject5;
    public GameObject GameObject6;
    public GameObject Backbutton;

    public void Back(int viewIndex)
    {
        if (viewIndex == 1)
        {
            GameObject2.SetActive(false);
            GameObject3.SetActive(false);
            GameObject4.SetActive(false);
            GameObject5.SetActive(false);
            GameObject6.SetActive(false);
            Backbutton.SetActive(false);
            Main.SetActive(true);
        }

    }
    }
