using System.Collections;
using UnityEngine;

public class StarLevel : MonoBehaviour
{

    [SerializeField] private GameObject levelMark;

    private bool isPlayerInRange;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            isPlayerInRange = true;
            levelMark.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            isPlayerInRange = false;
            levelMark.SetActive(false);
        }
    }
    
}
