using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemyy : MonoBehaviour
{
    public GameObject Player;

    public int enemyhealth = 100;
    public float knockbackForce;
    [SerializeField] AudioSource gethurt;

    private void Update()
    {
        if (enemyhealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<Health>().currenthealth -= 10f;
            gethurt.Play();


            Rigidbody playerRigidbody = Player.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                Vector3 knockbackDirection = (transform.position - other.transform.position).normalized;
                playerRigidbody.AddForce(-knockbackDirection * knockbackForce, ForceMode.Impulse);
            }
        }
    }

}
