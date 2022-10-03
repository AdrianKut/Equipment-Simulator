using UnityEngine;
using UnityEngine.EventSystems;

public class ItemInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] AbstractSlot _slot;
    [SerializeField] private ItemPanelManager _itemPanelManager;
    [SerializeField] private Vector2 _vector2AnchoredPosition = Vector2.zero;

    [SerializeField] private Vector2 _anchorMin = new Vector2(0, 1);
    [SerializeField] private Vector2 _anchorMax = new Vector2(0, 1);

    public void OnPointerExit(PointerEventData eventData)
    {
        HideDescription();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowDescription();
    }

    private void ShowDescription()
    {
        if (_slot.IsEmptySlot() == false)
        {
            var content = $"{_slot.ScriptableItem.GetDescription()}";
            _itemPanelManager.SetConentItemPanel(_slot.Name, content);
            _itemPanelManager.gameObject.SetActive(true);
            _itemPanelManager.gameObject.transform.SetParent(this.gameObject.transform);

            var itemPanelRectTransform = _itemPanelManager.GetComponent<RectTransform>();
            itemPanelRectTransform.anchoredPosition = _vector2AnchoredPosition;
            itemPanelRectTransform.anchorMin = _anchorMin;
            itemPanelRectTransform.anchorMax = _anchorMax;
        }
    }

    private void HideDescription()
    {
        _itemPanelManager.gameObject.SetActive(false);
    }

}
