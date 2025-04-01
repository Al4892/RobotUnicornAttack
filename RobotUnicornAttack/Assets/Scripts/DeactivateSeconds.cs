using UnityEngine;
using UnityEngine.Events;

public class DeactivateSeconds : MonoBehaviour
{
    [SerializeField]
    private float _secondsDeactivate=5f;

   
    private void OnEnable()
    {
        Invoke("DeactivateObject",_secondsDeactivate);
    }

    private void DeactivateObject()
    {
        gameObject.SetActive(false);


    }
   
}
