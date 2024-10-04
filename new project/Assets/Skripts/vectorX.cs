using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorX : MonoBehaviour
{
    [SerializeField] float vectorX;
    [SerializeField] float vectorY = 0;
    [SerializeField] float vectorZ;
    [SerializeField] float speed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vectorX = Inpur.GetAxis("Horizontal");
        vectorZ = Input.GetAxis("Vertical");
        transform.Translate
    }
}
