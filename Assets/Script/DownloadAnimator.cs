using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PrimeTween;
using TMPro;

public class DownloadAnimator : MonoBehaviour
{

    [SerializeField]
    private Slider _sliderBar;

    [SerializeField]
    private GameObject _content;

    [SerializeField]
    private CanvasGroup _backgroundCG;

    [SerializeField]
    private TextMeshProUGUI _text;

    void OnEnable()
    {
        _content.GetComponent<RectTransform>().localPosition = new Vector2(Screen.width,0);

        Tween.UIAnchoredPositionX(_content.GetComponent<RectTransform>(), 0, 0.6f, Ease.InOutBack);

        Tween.Custom(0, 0.8f, 0.4f, onValueChange: newVal => _backgroundCG.alpha = newVal);

        Tween.UISliderValue(_sliderBar, 1, 4f, Ease.InOutQuart).OnComplete(()=>CompleteDownload());
    }

    void CompleteDownload()
    {
        Tween.Custom(0, 0f, 0.8f, onValueChange: newVal => _backgroundCG.alpha = newVal).OnComplete(() => Disable());
        Tween.ScaleX(_sliderBar.transform, 0f, 0.4f, Ease.InBack);

        Tween.ScaleX(_text.transform,0f,0.2f,Ease.InBack);


    }
    private void Disable()
    {
        _sliderBar.value = 0f;

        _sliderBar.GetComponent<RectTransform>().localScale = Vector3.one;
        _text.GetComponent<RectTransform>().localScale = Vector3.one;

        _content.GetComponent<RectTransform>().localPosition = new Vector2(Screen.width, 0);
        Destroy(this.gameObject);
    }
}
