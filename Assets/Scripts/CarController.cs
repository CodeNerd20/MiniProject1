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

    public GameObject bulletPrefab;
    public GameObject bulletSpawn;
    public GameObject bulletSpawn1;

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
            Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            Instantiate(bulletPrefab, bulletSpawn1.transform.position, bulletSpawn1.transform.rotation);
        }
    }
}
