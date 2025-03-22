using UnityEngine;

public class TriggerUriel : MonoBehaviour
{
    private Animator PeasantAnim;
    void Start()
    {
        PeasantAnim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PeasantAnim.SetTrigger("THello");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PeasantAnim.SetTrigger("TTask");
        }
    }
}
