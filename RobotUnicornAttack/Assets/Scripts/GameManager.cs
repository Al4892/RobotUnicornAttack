using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onGameStart;
    
    void Start()
    {
        _onGameStart?.Invoke();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
