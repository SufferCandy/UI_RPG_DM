using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float minDamage, maxDamage;
    public Sprite enemyImage;

   public override void Attack(Character toHit)
   {
       float damage = Random.Range(minDamage, maxDamage);
       toHit.GetHit(damage);
       Debug.Log("Attacking");
   }

   public void Reset()
   {
       Health = maxHealth;
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
