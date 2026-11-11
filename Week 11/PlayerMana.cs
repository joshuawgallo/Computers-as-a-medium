using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMana : MonoBehaviour
{
    public int mana = 50;
    public TMP_Text manaText;
    public Animator animator;

    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    void Update()
    {
        UseMana();
        manaText.text = "Mana: " + mana;
    }

    void UseMana()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            if (mana >= 10)
            {
                mana = mana - 10;
                animator.SetTrigger("manaUse");
            }
        }
    }
}
