using UnityEngine;

public class SlotManager : MonoBehaviour
{
    public Slot SlotShield;
    public Slot SlotSword;

    public static SlotManager Instance;
    private SlotManager() { }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
