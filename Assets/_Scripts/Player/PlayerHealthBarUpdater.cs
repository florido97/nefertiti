using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBarUpdater : MonoBehaviour
{
    public Image Bar;
    [SerializeField]
    private float maxHealth = 100f;

    void Update()
    {
        SetHealth(GlobalVars.playerHealth);
    }

    private void SetHealth(float myHealth)
    {
        myHealth = myHealth / maxHealth;
        Bar.fillAmount = myHealth;
    }
}
