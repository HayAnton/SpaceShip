using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oponend : MonoBehaviour
{
    public float speed;
    void Update()
    {
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
        GameManager.instance.score += 3;
    }
}
