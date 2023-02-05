using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
 public int data =0;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    [SerializeField] public GameObject[] things;
    [SerializeField] public GameObject[] completed;
    [SerializeField] public GameObject win;
    [System.Flags]
    [SerializeField] public enum Flags
    {
        Flag1 = 1 << 0,
        Flag2 = 1 << 1,
        Flag3 = 1 << 2,
        Flag4 = 1 << 3,
        Flag5 = 1 << 4,

    }

    public void ToggleAchievement(Flags f,int i)
    {
        print("ToggleAchievment"+f +":"+ HasFlag(data, f));
        if (!HasFlag(data, f))
        {
            ToggleFlag(ref data, f);
            things[i - 1].SetActive(false);
            completed[i - 1].SetActive(true);
            if (data == 31)
            {
                win.SetActive(true);
            }
            
        }
      
     }

    public static bool HasFlag(int data, Flags flag)
    {
        return (data & (int)flag)!=0;
    }
    public static void ToggleFlag(ref int data, Flags flag)
    {
        data ^= (int)flag;    //yes you can use |=, &=, and ^=
    }
   
}
