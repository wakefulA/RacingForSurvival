using System.Collections;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
   public GameObject[] cars;
   private float[] positions = {1.09f, 3.47f, -3.31f, -1.15f};
   
   private void Start()
   {
      StartCoroutine(spawn());
   }

   IEnumerator spawn()
   {
      while (true)
      {
         Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(positions[Random.Range(0, 4)], 6.5f, 0),
            Quaternion.Euler(new Vector3(-90, 360, 0)));
         
         yield return new WaitForSeconds(2.5f);
      }
   }

  
}
