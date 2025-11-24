using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioClip explode;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2.5f);
        AudioSource.PlayClipAtPoint(explode, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
