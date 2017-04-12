using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMagnets : MonoBehaviour
{
  public Material posMaterial;
  public Material negMaterial;
  public Material neutralMaterial;
  public ParticleSystem pSystem;
  private void Awake()
  {
   // pSystem.GetComponent<ParticleSystem>();
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Positive"))
    {
      gameObject.GetComponent<Renderer>().material = posMaterial;
      gameObject.tag = "Positive2";
      Destroy(other.gameObject);   
    }
    if (other.gameObject.CompareTag("Negative"))
    {
      gameObject.GetComponent<Renderer>().material = negMaterial;
      gameObject.tag = "Negative2";
      Destroy(other.gameObject);
    }
  }
  private void OnCollisionEnter(Collision col)
  {
    if (col.gameObject.CompareTag("Positive2"))
    {
      Debug.Log("Ive been hit");
      Destroy(col.gameObject);
     // pSystem.Play();
    }
  }
}
