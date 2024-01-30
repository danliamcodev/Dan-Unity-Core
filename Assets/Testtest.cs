using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YourProject.Core.Events;

public class Testtest : MonoBehaviour
{
    [SerializeField] FloatEvent _testEvent;
    // Start is called before the first frame update
    void Start()
    {
        _testEvent.Raise(1);
    }
}
