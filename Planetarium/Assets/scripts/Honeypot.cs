using UnityEngine;

public class Honeypot : MonoBehaviour
{
    public Texture2D cursor;
    Vector2 hotSpot;
    
    void Start()
    {
        if (cursor != null)
        {
            hotSpot = new Vector2(cursor.width *0.2f, cursor.height * 0.9f);  // left-top corner is hotspot
            Cursor.SetCursor(cursor, hotSpot, CursorMode.Auto);
        }
    }

    public static Vector3 Locate()
    {
        Vector3 mp = Input.mousePosition;     // screen coords
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(
            new Vector3(mp.x, mp.y, Camera.main.nearClipPlane));    // world coords
        return new Vector3(mousePos.x, mousePos.y, 0f);
    }
}
