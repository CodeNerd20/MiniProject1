using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 90f;

    public Rigidbody rb;

    public float horizontalInput;
    public float forwardInput;

    public GameObject bullet;
    public Rigidbody bulletRb;
    public float spawnRate;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
            bulletRb.AddForce(Vector3.forward * bulletSpeed * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
