using UnityEngine;

namespace Road
{
    public class RoadDirection : MonoBehaviour
    {
        public float speed = 1.5f;
        public GameObject road;

        private void Update()
        {
            transform.Translate(Vector3.down * (speed * Time.deltaTime));

            if (transform.position.y < -8f)

            {
                Instantiate(road, new Vector3(0.546f, 10.04f, 0), Quaternion.identity);
                // EditorApplication.isPaused = true;
                Destroy(gameObject);

            }
        }
    }
}
