using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerDeath : MonoBehaviour
    {
        private void OnCollisionStay(Collision collision)
        {
            if (collision.gameObject.CompareTag("Car"))
            {
                Destroy(gameObject);
            }
        }
    }
}