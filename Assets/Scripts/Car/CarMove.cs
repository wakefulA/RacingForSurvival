using UnityEngine;

namespace Car
{
    public class CarMove : MonoBehaviour
    {
        public float speed = 2f;

        private void FixedUpdate()
        {
            
            
            transform.Translate(Vector3.back * (speed * Time.deltaTime));
        
            if(transform.position.y < -7)
                Destroy(gameObject);
        }
    }
}
