using System;
using UnityEngine;

public class Listener : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ObserverPatternExamples.simpleAction += InvocarSonido;
      //  ObserverPatternExamples.simpleAction = null; ERROR
    }

    private void InvocarSonido()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
