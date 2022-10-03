using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public abstract class AbstractItemSpawner : MonoBehaviour
{
    [SerializeField] private AnimationClip _animationClipScaleOut;
    private Animator _animator;
    
    [Space]
    public RawImage RawImageIcon;
    public TextMeshProUGUI TextMeshName;
    public ScriptableItem ScriptableItem;
    public ItemType ItemType;
    public string Name;
    public string Description;

    private void Awake()
    {
       _animator = GetComponent<Animator>();
    }

    public void InitializeItem(ScriptableItem scriptableItem)
    {
        ScriptableItem = scriptableItem;
    }

    public void EquipItemOnClick()
    {
        InventoryManager.Instance.AsignItemToSlot(ScriptableItem);
        _animator.SetTrigger("canScale");
        Destroy(this.gameObject, _animationClipScaleOut.length);
    }
}
