using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using PrimeTween;

public class PageGameRefactoring : MonoBehaviour
{

    [SerializeField]
    private List<Image> _imageList;

    [SerializeField]
    private Image _ico;

    [SerializeField]
    private TextMeshProUGUI _name, _Description;

    [SerializeField]
    private RectTransform _content;

    private void Start()
    {
        _content.localPosition = new Vector2(0,-Screen.height);
    }

    public void SetData(GameType _gType)
    {   
        if(_gType!=null)
        {
            _ico.sprite = _gType.Ico;
            _name.text = _gType.Name;
            _Description.text = _gType.Description;

            for(int i =0;i<_gType.ScrenShot.Count;i++)
                _imageList[i].sprite = _gType.ScrenShot[i];

            Tween.UIAnchoredPositionY(_content, 0, 0.6f, Ease.OutQuart);
        }
    }

    public void ClosePage()
    {
        Tween.UIAnchoredPositionY(_content, -Screen.height, 0.6f, Ease.OutCirc).OnComplete(() => { Destroy(this.gameObject); });
    }

    public void SummonDownloadCanvas()
    {
        GameObject.Instantiate(Resources.Load("DownloadCanvas"));
    }
}
