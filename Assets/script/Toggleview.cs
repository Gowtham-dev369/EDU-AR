using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggleview : MonoBehaviour
{

    public GameObject GameObject1;
    public GameObject GameObject2;

    private int activeView = 0;

    public void Toggle(int viewIndex)
    {
        activeView = viewIndex;
        if (activeView == 0)
            {
                GameObject1.SetActive(true);
                GameObject2.SetActive(false);
            }
        else if(activeView == 1 ){
            GameObject1.SetActive(false);
            GameObject2.SetActive(true);        }

        }
}
