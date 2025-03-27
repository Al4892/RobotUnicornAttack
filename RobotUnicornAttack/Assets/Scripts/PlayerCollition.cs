using UnityEngine;
using UnityEngine.Events;

public class PlayerCollition : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onPlayerLose;
    [SerializeField]
    private UnityEvent<Transform> _onObstacleDestroyed;
    [SerializeField]
    private UnityEvent<Transform> _onCollisionDie;
    private Dash _dash;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _dash=GetComponent<Dash>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            if(_dash.IsDashing)
            {
                _onObstacleDestroyed?.Invoke(transform);
                Destroy(collision.gameObject);
            }
            else
            {
                _onCollisionDie?.Invoke(transform);
                _onPlayerLose?.Invoke();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
             _onCollisionDie?.Invoke(transform);
            _onPlayerLose?.Invoke();
        }
    }

}
