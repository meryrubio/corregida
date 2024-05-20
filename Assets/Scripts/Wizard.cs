using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character // HERENCIA -> HIJO : PADRE
{
    private bool hasHat; // tiene gorro 
    private float damageMultiplier;


    public Wizard(float dmMul, string name) : base("Wizard", 20, Resources.Load<Sprite>("Sprites/wizard")) //base llama a la clase padre
    {
        
       this.damageMultiplier = dmMul;

    }

    //public bool Hashat()
    //{
    //    return hasHat;

    //}



    public override float Attack()
    {
        Debug.Log("mago ataca");
        return damage * damageMultiplier;
        
        //return hasHat ? damage * 2 : damage; // OPERACION TERNARIA -> condicional: if(hasHat)
                                             //                                    {
                                             //                                      return damage * 2;
                                             //                                    }
                                             //                                    else
                                             //                                    {
                                             //                                      return damage;
                                             //                                    }

    }

    public override float Heal() 
    {
        float valueRecovered = Random.Range(damage, damage * damageMultiplier);
        health += valueRecovered;
        base.Heal();// se invoca al heal del padre ,,recursion infita o bucle infinito si se invoca al metodo heal del wizar 
        return valueRecovered;
    }
}
