using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LicznikMonet : MonoBehaviour
{
   
    
        [SerializeField] private Text scoreText;
        private int score = 0;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Coin"))
            {
                Destroy(other.gameObject);
                score++;
                scoreText.text = "Wynik: " + score;
            }
        }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
