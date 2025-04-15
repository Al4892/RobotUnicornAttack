using UnityEngine;

public class Slowmotion : MonoBehaviour
{
    [SerializeField]
    private float SlowmotionFAcotr=0.1f;
   public void StartSlowMotion()
   {
    Time.timeScale=SlowmotionFAcotr;
   }
   public void StopSlowMotion()
   {
    Time.timeScale=1f;
   }
}
