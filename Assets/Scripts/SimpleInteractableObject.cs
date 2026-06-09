using UnityEngine;
using UnityEngine.Events;

public class SimpleInteractableObject : MonoBehaviour
{
    public UnityEvent OnTargetInteract;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        OnTargetInteract.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
