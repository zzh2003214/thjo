﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -1, 0) * 5.0f * Time.deltaTime;
        if (transform.position.y < -8)
        Destroy(gameObject);
    }
}
