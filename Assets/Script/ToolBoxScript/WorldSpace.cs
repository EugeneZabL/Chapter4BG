using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WorldSpace : MonoBehaviour
{

    public UIDocument Document;

    void OnEnable() //???? Start ÍÅ ÂÎÐÊÀÅÒ
    {
        Document.panelSettings.SetScreenToPanelSpaceFunction((Vector2 screenPosition) =>
        {

            var individualPosition = new Vector2(float.NaN, float.NaN);

            var cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(cameraRay.origin, cameraRay.direction * 100, Color.red);

            RaycastHit hit;

            if (!Physics.Raycast(cameraRay, out hit, 100f, LayerMask.GetMask("UI")))
            {
                Debug.Log($"Invalid Position");
                return individualPosition;
            }

            Vector2 pixelUV = hit.textureCoord;

            pixelUV.y = 1 - pixelUV.y;
            pixelUV.x *= this.Document.panelSettings.targetTexture.width;
            pixelUV.y *= this.Document.panelSettings.targetTexture.height;

            var cursor = this.Document.rootVisualElement.Q<VisualElement>("cursor");

            if(cursor !=null)
            {
                cursor.style.left = pixelUV.x;
                cursor.style.top = pixelUV.y;
            }

            return pixelUV;
        });
    }
}
