using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float moveSpeed;
    public GameObject laserObject;
    public GameObject cannonLeft;
    public GameObject cannonRight;
    public AudioSource LaserSound;
    public AudioSource ExplosionSound;
    private Animator Animation;
    //private float bewegung;

    private void Start()
    {
        LaserSound = GetComponent<AudioSource>();
        ExplosionSound = GetComponent<AudioSource>();
       // Animation = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
        Shooting();
    }
    void Movement()
    {
        Vector3 movement = Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // eine einheit nach rechts mal die taste die gedrückt wird mal die geschwindigkeit mal 1 sec
        //bewegung = Input.GetAxis("Horizontal");
        transform.Translate(movement);
        Vector3 position = transform.position;//schreibt den Aktuellen wert rein
        position.x = Mathf.Clamp(position.x, -75, 75);// der x wird wird eingegrenzt
        transform.position = position;
        //Animation.SetBool("Bewegung", bewegung != 0);

    }
    void Shooting()
    {
        if (Input.GetButtonDown("Fire1")) //wenn taste gedrückt 
        {
            LaserSound.Play();
            Instantiate(laserObject, cannonRight.transform.position, laserObject.transform.rotation); // an der canone wird der Laser gespawnt
            Instantiate(laserObject, cannonLeft.transform.position, laserObject.transform.rotation);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            ExplosionSound.Play();
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        GameManager.instance.gameOver = true;
    }
}
