using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionController : MonoBehaviour
{
    ParticleSystem explosion;

    void Update()
    {
        explosion = GetComponent<ParticleSystem>();
        if(!explosion.isPlaying){
            Destroy(gameObject);
        }
        
    }
}
