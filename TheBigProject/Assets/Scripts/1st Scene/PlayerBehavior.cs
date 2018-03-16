using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerBehavior : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Horizontal");
        float moveHorizontal = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);
        rb.AddForce(movement * speed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Door")
        {
            if (collisionInfo.collider.name == "Door1")
            {
                SceneManager.LoadScene("Test01");
            }
            if (collisionInfo.collider.name == "Door2")
            {
                SceneManager.LoadScene("Test02");
            }
            if (collisionInfo.collider.name == "Door3")
            {
                SceneManager.LoadScene("Test03");
            }
            if (collisionInfo.collider.name == "Door4")
            {
                SceneManager.LoadScene("Test04");
            }
            if (collisionInfo.collider.name == "Door5")
            {
                SceneManager.LoadScene("Test05");
            }
            if (collisionInfo.collider.name == "Door6")
            {
                SceneManager.LoadScene("Test06");
            }
            if (collisionInfo.collider.name == "Door7")
            {
                SceneManager.LoadScene("Test07");
            }
            if (collisionInfo.collider.name == "Door8")
            {
                SceneManager.LoadScene("Test08");
            }
            if (collisionInfo.collider.name == "Door9")
            {
                SceneManager.LoadScene("Test09");
            }
            if (collisionInfo.collider.name == "Door10")
            {
                SceneManager.LoadScene("Test10");
            }



        }
        if (collisionInfo.collider.tag == "Stairs")
        {
            SceneManager.LoadScene("1");
            Debug.Log("QWE");
        }
        if (collisionInfo.collider.name == "Enter")
        {
            SceneManager.LoadScene("Packman");
            Debug.Log("QEE");
        }
    }
}