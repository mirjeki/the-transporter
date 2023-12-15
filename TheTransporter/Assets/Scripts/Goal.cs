using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var player = collision.GetComponent<Player>();

            if (player.hasPackage == true)
            {
                Debug.Log("Package delivered!");
                Debug.Log("You can now transform into a faster car by hitting '2'.");
                player.hasPackage = false;
                player.canTransform = true;
            }
            else
            {
                Debug.Log("Where's my package? You don't have one!");
            }
        }
    }
}
