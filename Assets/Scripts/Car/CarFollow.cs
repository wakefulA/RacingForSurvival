
using UnityEngine;

namespace Car
{
    public class CarFollow : MonoBehaviour
    {

        public float speed;

        [SerializeField] private Transform _target;
        
        
        
       

        private void Start()
        {

        
                _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
           
                 
               
                 
        }

        private void FixedUpdate()
        {
           
             transform.position = Vector2.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
        }
    }
}