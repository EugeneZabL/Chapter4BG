using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonTest : MonoBehaviour
{
    public GameObject UI;
    private void Start()
    {
        VisualElement root = UI.GetComponent<UIDocument>().rootVisualElement;
        root.Q<Button>("PlayButton").clicked += () => Debug.Log("pLAY");
        root.Q<Button>("SettingsButton").clicked += () => Debug.Log("settings");
        root.Q<Button>("ExitButton").clicked += () => Debug.Log("exit");
    }
}
