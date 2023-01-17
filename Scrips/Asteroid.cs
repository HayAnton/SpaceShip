using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    
    private void Start()
    {
        //ExplosionSound = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(180, 180, 0) * Time.deltaTime);
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }
    }
    private void OnDestroy()
    {
        GameManager.instance.score += 1;
        Destroy(gameObject);
        
    }
}
