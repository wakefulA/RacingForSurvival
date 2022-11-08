using Objects;
using UnityEngine;

namespace Player
{
    public class PlayerDeath : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Tag.Car))
            {
                Destroy(gameObject);
            }
        }
    }
}