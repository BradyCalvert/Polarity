using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetManager : MonoBehaviour
{
  public float duration = 1;

  void Update()
  {
    if (GameObject.FindGameObjectWithTag("Positive2") != null & GameObject.FindWithTag("Negative2") != null)
      MoveObj();

  }
  void MoveObj()
  {
    GameObject.FindWithTag("Positive2").transform.position = Vector3.Lerp(GameObject.FindWithTag("Positive2").transform.position, (GameObject.FindWithTag("Negative2").transform.position), Time.deltaTime / duration);
  }
}
