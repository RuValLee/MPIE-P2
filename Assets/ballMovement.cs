using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    public float rotationSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Vertical") * rotationSpeed;
        float rotationZ = Input.GetAxis("Horizontal") * rotationSpeed;

        transform.rotation = Quaternion.Euler(rotationX, 0, -rotationZ);

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
