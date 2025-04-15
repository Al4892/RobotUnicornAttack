using UnityEngine;

public class RunSpeed : MonoBehaviour
{
   [SerializeField]
   private float increaseValue=0.1f;
   [SerializeField]
   private float InitialSpeedValue=1f;
   [SerializeField]
   private Animator characterAnimator;
   [SerializeField]
   private string animatorValueName="RunSpeed";
   private float speedValue=1f;
   private bool isRunning=false;

   public void startRunSpeed()
   {
    speedValue=InitialSpeedValue;
    isRunning=true;

   }
   public void StopRunSpeed()
   {
    isRunning=false;
   }

    void Update()
    {
        if(isRunning)
        {
            speedValue+=increaseValue*Time.deltaTime;
            characterAnimator.SetFloat(animatorValueName,speedValue);
        }
    }
}
