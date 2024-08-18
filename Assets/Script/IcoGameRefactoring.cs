using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using PrimeTween;

public class IcoGameRefactoring : MonoBehaviour
{
    public GameType GameType;

    private GameObject _gamePage;

    private Image _ico;


    private void Start()
    {
        if (GameType != null)
        {
            _ico = transform.GetChild(0).GetChild(0).GetComponent<Image>();
            _ico.sprite = GameType.Ico;
            transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = GameType.Name;
        }


    }

    public void OpenGamePage()
    {
        //_gamePage = Instantiate(Resources.Load("GamePageCanvas") as GameObject);
        Tween.Scale(transform.GetChild(0).GetComponent<RectTransform>(), 0.5f, 0.2f).OnComplete(() =>
        {
            Tween.Scale(transform.GetChild(0).GetComponent<RectTransform>(), 1f, 0.2f, Ease.OutBack);
            _gamePage = Instantiate(Resources.Load("GamePageCanvas") as GameObject);
            _gamePage.GetComponent<PageGameRefactoring>().SetData(GameType);
        });

        //_gamePage = Instantiate(Resources.Load("GamePageCanvas") as GameObject);
        

    }
}
