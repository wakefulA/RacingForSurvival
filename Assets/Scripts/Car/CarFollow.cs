using UnityEngine;

namespace Car
{
    public class CarFollow : MonoBehaviour
    {
        public float speed;

        [SerializeField] private Transform _target;

        private void FixedUpdate()
        {
            try // попытаться сделать 
            {
                Follow();
            }

            catch //сделать что-то если не получилось
            {
            }
        }

        private void Follow()
        {
            _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

            transform.position = Vector2.MoveTowards(transform.position,
                _target.position,
                speed * Time.deltaTime);
        }
    }
}