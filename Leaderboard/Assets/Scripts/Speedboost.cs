using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedboost : MonoBehaviour
{
    public float BoostMultiplier = 2.0f;
    public float BoostSeconds = 5.0f;

    private void OnCollisionEnter(Collision player)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Speed Boost!");

            PlayerController Player = collision.gameObject.GetComponent<PlayerController>();
            Player.BoostSpeed(BoostMultiplier, BoostSeconds);
        }
    }
}
