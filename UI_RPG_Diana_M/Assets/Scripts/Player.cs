using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon selectedWeapon;

    public override void Attack(Character toHit)
    {
        float damage = selectedWeapon.GetDamage();
        toHit.GetHit(damage);
        Debug.Log("Attack enemy");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
