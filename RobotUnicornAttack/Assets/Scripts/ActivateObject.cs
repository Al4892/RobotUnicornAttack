using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objectsToActivate;

    private void OnEnable()
    {
        ActivateAllObject();
    }

    private void ActivateAllObject()
    {
        foreach(GameObject obj in objectsToActivate)
        {
            if(obj!=null)
            {
                obj.SetActive(true);
            }
        }
    }
}
