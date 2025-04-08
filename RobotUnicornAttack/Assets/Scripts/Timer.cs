using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text timertext;
    [SerializeField]
    private UnityEvent onSecondPassed;
    private int currentSeconds;

    public void StartTimer(int StarSceonds)
    {
        currentSeconds=StarSceonds;
        SetTimer();
    }
    private void SetTimer()
    {
        onSecondPassed?.Invoke();
        currentSeconds--;
        timertext.text=currentSeconds.ToString();
        if(currentSeconds>0)
        {
            Invoke("SetTimer",1f);
        }
    }
}
