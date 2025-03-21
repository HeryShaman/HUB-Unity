using UnityEngine;

public class TriggerSeePlayer : MonoBehaviour
{
    private Animator Guard_02Anim;
    void Start()
    {
        Guard_02Anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Guard_02Anim.SetTrigger("punch");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Guard_02Anim.SetTrigger("hello");
        }
    }
}
