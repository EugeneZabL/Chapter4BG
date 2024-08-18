using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrimeTween;
using UnityEngine.UI;

public class SliderAction : MonoBehaviour
{
    public CanvasGroup BackGround;

    public GameObject SlideObj;

    public RectTransform SlideRectTransform;

    private float _screnW;

    private void OnEnable()
    {
        _screnW = -Screen.width;
        SlideRectTransform.localPosition = new Vector2(_screnW,0);
    }

    public void Open()
    {
        SlideObj.SetActive(true);
        Tween.UIAnchoredPositionX(SlideRectTransform, 0, 0.4f, Ease.InOutBack);
        Tween.Custom(0, 0.7f, 0.4f, onValueChange: newVal => BackGround.alpha = newVal);
    }

    public void Close()
    {
        Tween.UIAnchoredPositionX(SlideRectTransform, _screnW, 0.4f,Ease.InBack).OnComplete(() => { SlideObj.SetActive(false); });
        Tween.Custom(0.7f, 0, 0.4f, onValueChange: newVal => BackGround.alpha = newVal);
    }
}
