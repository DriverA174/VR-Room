using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complete : MonoBehaviour
{
    public GameObject door;
    public GameObject look;
    public GameObject Reward;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            Destroy(door);
            Destroy(look);
            Instantiate(Reward, new Vector3(0, -3, -27), Quaternion.identity);
        }
    }
}
