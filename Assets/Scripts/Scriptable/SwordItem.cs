using System;
using UnityEngine;

public class SwordItem : AbstractItemSpawner
{
    private ScriptableSword _sword;

    public int Attack;
    public float AttackSpeed;

    private void Start()
    {
        InitializeItem();
    }

    public void InitializeItem()
    {
        if (ScriptableItem == null)
        {
            Debug.LogWarning("Sword doesn't exist!");
            return;
        }

        _sword = (ScriptableSword)ScriptableItem;

        Attack = _sword.Attack;
        AttackSpeed = _sword.AttackSpeed;

        Name = _sword.Name;
        RawImageIcon.texture = _sword.Icon.texture;
        TextMeshName.text = _sword.Name;
        Description = $"{Name}\nAttack: {Attack}\nAttackSpeed: {AttackSpeed}";

        this.gameObject.name = _sword.Name;
    }
}