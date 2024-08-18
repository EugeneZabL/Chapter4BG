using UnityEngine;
using UnityEngine.EventSystems;
public class ScriptTrigg : EventTrigger
{
    public override void OnScroll(PointerEventData data)
    {
        Debug.Log(data.scrollDelta);
        float y = this.transform.localScale.y + data.scrollDelta.y*0.1f;

        if (y <= 0)
            y = 1f;
        this.transform.localScale = new Vector2(y,y);
    }
}
