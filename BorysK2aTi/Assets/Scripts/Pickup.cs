using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pickup : MonoBehaviour
{
    float score = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            score++;
            Debug.Log("Twoj wynik to" + score);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
