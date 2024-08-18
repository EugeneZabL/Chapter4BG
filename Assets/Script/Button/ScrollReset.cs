using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PrimeTween;

public class ScrollReset : MonoBehaviour
{
    [SerializeField]
    private ScrollRect _scroll;

    public void ResetScrollPositionAnimated()
    {
        if (_scroll.verticalNormalizedPosition!=1)
        {
            Tween.Custom(_scroll.verticalNormalizedPosition, 1f, 0.9f, onValueChange: newVal => _scroll.verticalNormalizedPosition = newVal, Ease.InBack);
            Tween.Scale(this.transform, 0.5f, 0.7f, Ease.InOutBack).OnComplete(() => { Tween.Scale(this.transform, 1f, 0.5f, Ease.InOutBack); });
            Tween.LocalRotation(this.transform, new Vector3(0, 0, 180f), 0.7f, Ease.InOutBack).OnComplete(() => Tween.LocalRotation(this.transform, new Vector3(0, 0, 0f), 0.6f, Ease.InOutBack));
        }
    }
}
