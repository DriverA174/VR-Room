using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public Transform player;
    public GameObject key;
    public TMP_Text counterText;
    public bool spawned = false;
    int kills;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();
        if(kills == 10 && spawned == false)
        {
            Instantiate(key, player.transform.position, Quaternion.identity);
            spawned = true;
        }
    }

    private void ShowKills()
    {
        counterText.text = kills.ToString();
    }

    public void AddKill()
    {
        kills++;
    }

}
