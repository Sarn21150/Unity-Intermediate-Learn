using System.Collections;
using UnityEngine;

public class InterFade : MonoBehaviour
{
    [SerializeField] private CanvasGroup _camvasGroup;
    [SerializeField] private float _fadeSpeed = 1f;
    private bool _isShown;
    
    

    [ContextMenu("ToggleUI")]
    public void ToggleUI()
    {
        _isShown = !_isShown;
        _camvasGroup.Fade(_isShown);
    }
}
