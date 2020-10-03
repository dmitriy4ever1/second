using UnityEngine;

public class Trident : MonoBehaviour
{
    public float TriSpeed = 1f;

    bool going =false;
    private void Start()
    {
        TriSpeed = TriSpeed / 5;
    }

    void Update()
    {
        if (going == false)
        {
            float h = 2 * Input.GetAxis("Mouse X");
            transform.Rotate(0, 0, h);
        }
        if (going == true)
        {
            transform.Translate(0, TriSpeed, 0);
        }
        if (Input.GetMouseButtonDown(2) && going==false)
        {
            going = true;
            Invoke("Return",2);
        }
    }

    void Return()
    {
        transform.Rotate(0, 0, 180);
        Invoke("ComeBack", 2);

    }
    void ComeBack()
    {
        transform.Rotate(0, 0, 180);
        going = false;

    }

 

}
