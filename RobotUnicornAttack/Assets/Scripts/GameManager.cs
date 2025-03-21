using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onGameStart;
    [SerializeField]
    private UnityEvent _OnrespawnGame;
    [SerializeField]
    private UnityEvent _OnFinishGame;

    [SerializeField]
    private float _secondsToRestart=3f;
    [SerializeField]
    private float _finishSecondsToRestart=5f;

    void Start()
    {
        _onGameStart?.Invoke();
        SoundManager.instance.Play("Pou");

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
