using UnityEngine;
using UnityEngine.UI; // needed if using a UI Slider or Image

public class IguanaEnergy : MonoBehaviour
{
    public float maxEnergy = 100f;
    public float currentEnergy = 0f;
    public Slider energyBar; // Assign a UI slider in the Inspector

    void Start()
    {
        currentEnergy = 0f;
        if (energyBar != null)
        {
            energyBar.maxValue = maxEnergy;
            energyBar.value = currentEnergy;
        }
    }

    // Call this when the iguana eats
    public void AddEnergy(float amount)
    {
        currentEnergy = Mathf.Clamp(currentEnergy + amount, 0, maxEnergy);

        if (energyBar != null)
        {
            energyBar.value = currentEnergy;
        }
    }
}