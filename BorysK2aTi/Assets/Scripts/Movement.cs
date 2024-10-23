using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float VectorX ;
    [SerializeField] float VectorY = 0;
    [SerializeField] float VectorZ ;
    [SerializeField] float BaseSpeed = 3;
    [SerializeField] float CurrentSpeed;
    [SerializeField] float Sprint = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        VectorX = Input.GetAxis("Horizontal");
        VectorZ = Input.GetAxis("Vertical");
        transform.Translate(VectorX * Time.deltaTime*CurrentSpeed, VectorY * Time.deltaTime*CurrentSpeed, VectorZ * Time.deltaTime * CurrentSpeed);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            CurrentSpeed = BaseSpeed + Sprint;
        }
        else
        {
            CurrentSpeed = BaseSpeed;
        }
    }
}
