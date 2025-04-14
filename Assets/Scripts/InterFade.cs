using System.Collections;
using UnityEngine;

public class InterFade : MonoBehaviour
{
    [SerializeField] private CanvasGroup _camvasGroup;
    [SerializeField] private float _fadeSpeed = 1f;
    private bool _isShown;
    
    IEnumerator Fade()
    {
        float alpha = _isShown ? 0f : 1f;
        if(_isShown)
        {
            while(alpha < 1f)
            {
                alpha += _fadeSpeed * Time.deltaTime;
                _camvasGroup.alpha = alpha;
                yield return null;
            }
        }
        else
        {
           while(alpha > 0f)
            {
                alpha -= _fadeSpeed * Time.deltaTime;
                _camvasGroup.alpha = alpha;
                yield return null;
            }
        }
        yield return new WaitForSeconds(0.5f);
        Debug.Log("FADED!");
    }

    [ContextMenu("ToggleUI")]
    public void ToggleUI()
    {
        _isShown = !_isShown;
        StartCoroutine(Fade());
    }

}
