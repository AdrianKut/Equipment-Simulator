using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbstractSlot : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectPopupMessage;

    [Header("Item")]
    public ScriptableItem ScriptableItem;
    public RawImage RawImageIcon;
    public TextMeshProUGUI TextMeshName;
    public string Name;
    public string Description;
    public Sprite DefaultIcon;

    public void SetItemInSlot(ScriptableItem item)
    {
        if (IsEmptySlot())
        {
            ScriptableItem = item;
        }
        else
        {
            RemoveItem();
            ScriptableItem = item;
        }

        Name = ScriptableItem.Name;
        RawImageIcon.texture = ScriptableItem.Icon.texture;
        TextMeshName.text = ScriptableItem.Name;

        AudioManager.Instance.PlayRandomAudioClip();
        
        var newPopupMessage = Instantiate(_gameObjectPopupMessage);
        string text = $"Now you have {Name} - {item.ItemType}";
        newPopupMessage.GetComponent<PopupMessageManager>().SetText(text);
    }

    public void RemoveItem()
    {
        InventoryManager.Instance.InstantiateNewItem(ScriptableItem);

        ScriptableItem = null;
        Name = "";
        RawImageIcon.texture = DefaultIcon.texture;
        TextMeshName.text = "";
        Description = "";
    }

    public bool IsEmptySlot()
    {
        return (ScriptableItem == null) ? true : false;
    }

    public ScriptableItem GetItem()
    {
        return ScriptableItem;
    }
}
