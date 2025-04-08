using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerText : MonoBehaviour
{
  [SerializeField]
  private Text playerText;
  [SerializeField]
  private string AnimationName="PlayerText";
  private Animator TextAnimator;

    void Start()
    {
        TextAnimator=playerText.GetComponent<Animator>();
    }

    public void ShowText(string text)
    {
        playerText.text=text;
        TextAnimator.Play(AnimationName);
    }
}
