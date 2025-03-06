using System.Runtime.InteropServices;
using UnityEngine;

public class PlatformsMovement : MonoBehaviour
{
    [SerializeField]
    private float _InitialSpeed=2f;
    [SerializeField]
    private float _speedincrease=0.1f;
    private bool _canMove=true;
    public bool CanMove{set => _canMove=value;}
    private Vector3 _StartingPosition;
    private float _speed;
       void Start()
    {
        _StartingPosition= transform.position;
        _speed=_InitialSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(_canMove)
        {
            MovePlatforms();
        }
    }
    private void MovePlatforms()
    {
        transform.position+=Vector3.left*_speed*Time.deltaTime;

    }
    public void IncreaseSpeed()
    {
        _speed+=_speedincrease;
    }
    public void StopMovement()
    {
        _canMove=false; 
    }
    public void StartMovement()
    {
        _canMove=true;
    }
    public void Restart()
    {
        transform.position=_StartingPosition;
        _speed=_InitialSpeed;
        StartMovement();
    }
}
