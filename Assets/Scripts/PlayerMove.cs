using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3f;
    
    private void Update()
    {
        
        
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

        float hor = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(hor, 0, 0);
        transform.Translate(dir.normalized * (Time.deltaTime * speed));
            
    }
    
    
 
    
    
    
}
