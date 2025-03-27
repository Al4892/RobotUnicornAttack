using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
   [SerializeField]
   private float _shakeDuration=0.5f;
   [SerializeField]
   private float _shakeMagnitudex=0.1f;
   [SerializeField]
   private float _shakeMagnitudey=0.1f;


   private Vector3 originalPosition;

    private void Start()
    {
        originalPosition=transform.localPosition;
    }
    public void Shake()
    {
        StartCoroutine(ShakeCoroutine());
    }
    private IEnumerator ShakeCoroutine()
    {
        float elapsedtime = 0f;
        while(elapsedtime < _shakeDuration)
        {
            float x = Random.Range(-1f,1f)*_shakeMagnitudex;
            float y = Random.Range(-1f,1f)*_shakeMagnitudey;
            transform.localPosition=new Vector3(x,y,originalPosition.z);
            elapsedtime += Time.deltaTime;
            yield return null;


        }
        transform.localPosition=originalPosition;
    }
}
