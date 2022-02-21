using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerMovement : MonoBehaviour
{
  [SerializeField] float spinSpeed = 1000f;

  void Start()
  {

  }

  void Update()
  {
    transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
  }
}
