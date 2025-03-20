using UnityEngine;
using UnityEngine.Events;

public class PlatformTrigger : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onPlatformTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("DeadZone"))
        {
            Destroy(other.gameObject);
            _onPlatformTrigger?.Invoke();
        }
    }
      
}
