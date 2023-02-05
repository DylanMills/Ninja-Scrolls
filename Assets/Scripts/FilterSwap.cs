using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterSwap : MonoBehaviour

{
    [SerializeField] GameObject[] filters;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SwapTo(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SwapTo(2);
        }
        else if (Input.GetKey(KeyCode.Alpha7))
        {
            SwapTo(3);
        }


    }

    void SwapTo(int index)
    {
        foreach (GameObject f in filters)
        {
            f.SetActive(false);
        }
        filters[index - 1].SetActive(true);
    }


}
