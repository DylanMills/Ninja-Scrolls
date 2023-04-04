using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterSwap : MonoBehaviour

{
    [SerializeField] GameObject[] filters;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwapTo(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwapTo(2);
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            SwapTo(3);
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            SwapTo(4);
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            SwapTo(5);
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
