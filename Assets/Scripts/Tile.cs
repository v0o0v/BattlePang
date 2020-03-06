using DG.Tweening;
using UnityEngine;

public class Tile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Vector2 str = new Vector2(0.1f, 0.1f);
        transform.DOPunchScale(str, 1f);
    }
}
