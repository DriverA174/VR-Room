using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbody : MonoBehaviour
{
    public Transform XRrig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = XRrig.transform.position;
    }
}
