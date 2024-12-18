using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pickup : MonoBehaviour
{
    float score = 0;
    [SerializeField] float speed = 1.0f;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            audioSource.PlayOneShot(clip);
            StartCoroutine(MoveToPlayer(other.transform, transform, speed));
            score++;
            Debug.Log("Twoj wynik to " + score);

        }
    }

    IEnumerator MoveToPlayer(Transform coin, Transform player, float speed)
    {
        float duration = 1.5f;

        float time = 0;

        while (time < speed)
        {
            coin.position = UnityEngine.Vector3.MoveTowards(coin.position, player.position, speed * Time.deltaTime);
            time += Time.deltaTime;
            yield return null;
        }
        Destroy(coin.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
