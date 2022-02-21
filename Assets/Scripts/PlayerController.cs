using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float speed = 20f;
  [SerializeField] float turnSpeed = 50.0f;
  [SerializeField] float horiontalInput;
  [SerializeField] float verticalInput;

  void Start()
  {

  }

  void Update()
  {
    horiontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");

    // Move the car based on vertical input
    transform.Translate(speed * Time.deltaTime * verticalInput * Vector3.forward);

    // Move the car based on vertical input
    transform.Rotate(Vector3.up, horiontalInput * Time.deltaTime * turnSpeed);
  }
}
