using System.Runtime.InteropServices;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private Transform _transformInventory;
    [SerializeField] private ShieldItem _shieldPrefab;
    [SerializeField] private SwordItem _swordPrefab;

    public static InventoryManager Instance;
    private InventoryManager() { }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void InstantiateNewItem(ScriptableItem scriptableItem)
    {
        if (scriptableItem != null)
        {
            AbstractItemSpawner newItem = null;

            switch (scriptableItem.ItemType)
            {
                case ItemType.Sword:
                    newItem = Instantiate(_swordPrefab, _transformInventory);
                    break;
                case ItemType.Shield:
                    newItem = Instantiate(_shieldPrefab, _transformInventory);
                    break;
            }

            newItem.InitializeItem(scriptableItem);
        }
    }

    public void AsignItemToSlot(ScriptableItem item)
    {
        SlotManager slot = SlotManager.Instance;
        ItemType type = item.ItemType;
        
        switch (type)
        {
            case ItemType.Sword:
                slot.SlotSword.SetItemInSlot((ScriptableSword)item);
                break;

            case ItemType.Shield:
                slot.SlotShield.SetItemInSlot((ScriptableShield)item);
                break;
        }
    }
}

