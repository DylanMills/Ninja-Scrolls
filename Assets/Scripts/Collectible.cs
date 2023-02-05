using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public Achievements a;
   public int id;
    [SerializeField]    public Achievements.Flags f;
    [SerializeField]
    [System.Flags]
    public enum Flags
    {
        Flag1 = 1 << 0,
        Flag2 = 1 << 1,
        Flag3 = 1 << 2,
        Flag4 = 1 << 3,
        Flag5 = 1 << 4,

    }
    // Start is called before the first frame update
    void Start()
    {
        a=FindObjectOfType<Achievements>();
             }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {

          //  a.ToggleAchievement(id);
            a.ToggleAchievement(f,id);
            this.gameObject.SetActive(false);
           // print(id);

        }
        else if(collision.gameObject.tag == "Player")
        {
            print("Player collision");
        }
    }

}
