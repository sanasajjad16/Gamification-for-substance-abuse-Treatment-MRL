using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    /* TODO:
     * - Implement interaction with 3D Objects
     * - Implement walking (optional)
     * - Count points and switch levels
     */
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.points >= 100)
		{
            GameManager.instance.onFinishLevel();
		}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.tag == "Cube")
        {
            GameManager.points += 10;
            Debug.Log("POINTS: " + GameManager.points);
        }
        else if (collision.gameObject.transform.tag == "Sphere")
		{
            GameManager.points += 20;
            Debug.Log("POINTS: " + GameManager.points);
		}
    }
}
