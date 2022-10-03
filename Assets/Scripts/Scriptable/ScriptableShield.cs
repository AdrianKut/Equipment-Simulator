using UnityEngine;

[CreateAssetMenu(fileName = "New Shield", menuName = "Item/Shield")]
public class ScriptableShield : ScriptableItem
{
    public int Armor;

    public override string GetDescription()
    {
        return base.GetDescription() + $"Armor: {Armor}";
    }
}
