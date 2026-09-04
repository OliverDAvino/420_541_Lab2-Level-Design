using UnityEngine;
 
public class FinishTrigger : MonoBehaviour
{
    public string EndText = "Level Complete!";
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(EndText);
        }
    }
}
