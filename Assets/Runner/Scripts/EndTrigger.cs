
using UnityEngine;


public class EndTrigger : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManager>().GG();
        Debug.Log("On Trigger Blyat");
    }
}
