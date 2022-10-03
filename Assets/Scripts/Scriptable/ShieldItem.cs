using System;
using UnityEngine;

public class ShieldItem : AbstractItemSpawner
{
    private ScriptableShield _shield;

    public int Armor; 
    
    private void Start()
    {
        InitializeItem();
    }

    public void InitializeItem()
    {
        if (ScriptableItem == null)
        {
            Debug.LogWarning("Shield doesn't exist!");
            return;
        }

        _shield = (ScriptableShield)ScriptableItem;

        Armor = _shield.Armor;

        Name = _shield.Name;
        RawImageIcon.texture = _shield.Icon.texture;
        TextMeshName.text = _shield.Name;
        Description = $"{Name}\n Armor: {Armor}";
        
        this.gameObject.name = _shield.Name;
    }
}