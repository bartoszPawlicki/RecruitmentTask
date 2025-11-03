using UnityEngine;
using UnityEngine.EventSystems;

public class CanvasController : MonoBehaviour
{
    [SerializeField]private GameObject firstSelected;

    void Update()
    {
        var es = EventSystem.current;

        if (es.currentSelectedGameObject == null && firstSelected != null)
        {
            es.SetSelectedGameObject(firstSelected);
        }
    }

    public void SetEventSystemFirstSelected(GameObject go)
    {
        firstSelected = go;
    }
}
