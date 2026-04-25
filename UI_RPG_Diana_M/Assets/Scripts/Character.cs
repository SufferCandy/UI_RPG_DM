using UnityEngine;

public abstract class Character : MonoBehaviour
{ 
    [SerializeField] private string charName;

    public string CharName
    {
        get { return charName; }   
    }

    private float health;
    [SerializeField] internal float maxHealth;
    public float Health
    {
        get { return health; }
        set { health = Mathf.Max(0, value); }
    }
 public abstract void Attack(Character toHit);

 public void GetHit(float damage)
 {
     Health = Health - damage;
     Debug.Log(charName + "got hit by" + damage + "! Health: " + health);
 }

 public void Gethit(Weapon weapon)
 {
     Health = health - weapon.GetDamage();
     Debug.Log(charName + "got hit by" + weapon.name + "! Health: " + health);
 }


 // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
