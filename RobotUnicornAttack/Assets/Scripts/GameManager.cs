using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onGameStart;
    [SerializeField]
    private UnityEvent _OnrespawnGame;
    [SerializeField]
    private UnityEvent _onLoseGame;
    [SerializeField]
    
    private UnityEvent _OnFinishGame;
    [SerializeField]
    private UnityEvent _onShowgameOverScree;
    [SerializeField]
    private UnityEvent<int> onShowerTime;

    [SerializeField]
    private float _secondsToRestart=3f;
    [SerializeField]
    private float _finishSecondsToRestart=5f;
    private float _secondsToShowGameOver=3f;

    void Awake()
    {
         _secondsToRestart+=_secondsToShowGameOver;
        _finishSecondsToRestart+=_secondsToShowGameOver;
    }

    void Start()
    {
        _onGameStart?.Invoke();
         
    }
    public void LoseGame()
    {
        _onLoseGame?.Invoke();
        Invoke("ShowGameOverScreen",_secondsToShowGameOver);
    }
    private void ShowGameOverScreen()
    {
        _onShowgameOverScree?.Invoke();
        onShowerTime?.Invoke(3);
        
    }
   
   
    public void RespawmGame()
    {
        Invoke("RestartGame",_secondsToRestart);
    }
    public void FinishGame()
    {
        _OnFinishGame?.Invoke();
        Invoke("Start",_secondsToRestart);
        Invoke("RestartGame",_finishSecondsToRestart);
    }
    private void RestartGame()
    {
        _OnrespawnGame?.Invoke();
    }

}
