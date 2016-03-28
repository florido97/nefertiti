using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBarUpdater : MonoBehaviour
{
    public Image Bar;
    [SerializeField]
    private float maxHealth = 100f;
    [SerializeField]
    private float currentHealth = GlobalVars.playerHealth;

    void Update()
    {
        currentHealth--;
        SetHealth(currentHealth);
    }

    private void SetHealth(float myHealth)
    {
        myHealth = myHealth / maxHealth;
        Bar.fillAmount = myHealth;
    }
}
