using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onGameStart;
    [SerializeField]
    private UnityEvent _OnrespawnGame;
    [SerializeField]
    private float _secondsToRestart=3f;
    void Start()
    {
        _onGameStart?.Invoke();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerLose()
    {
        Invoke(nameof(RestartGame),_secondsToRestart);


    }
    private void RestartGame()
    {
        _OnrespawnGame?.Invoke();
    }
}
