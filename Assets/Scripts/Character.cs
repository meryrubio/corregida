using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Enemies { GOBLIN, SUKAMON}
public abstract class Character
{
    public string name;
    protected float damage; // damage es privada pero queremos que sea publica a las clases hija, por lo que es PROTECTED
    public float health;
    private Sprite _sprite; 
    public Color color;
   

    public Character() //constructor por defecto
    {
        name = "DEAFULT";
    }
    public Character(string name, float damage, Sprite sprite) //constructor por argumento
    {
        this.name = name;
        this.damage = damage;
        _sprite = sprite;

    }


    //EL SETTER LO ESTABLECE
    //getter TE DEVUELVE
    public Sprite GetSprite() { return _sprite; }
    public float GetDamage()
    {
        return damage;
    }
    public string GetName() { return name; }

    public abstract float Attack(); //-> METODO ABSTRACTO, es un comportamiento que se especifica en mago, cowboy

    public virtual float Heal() // VIRTUAL permite a los hijos sobreescribir el metodo sin que el metodo sea abstracto, si se implementa
    {
        Debug.Log("Character se cura");

        //if(health > 100)
        //{
        //    return 100;
        //}
        //else if(health < 0)
        //{                               -> esto es equivalente a la linea siguiente solo que con ifs
        //    return 0;
        //}
        //else
        //{
        //    return health;
        //}

        health = Mathf.Clamp(health, 0, 100); // clamp devuelve el valor entre en minimo y maximo, si lo sobrepasa por el lado izq te devuelve el minimo y si lo sobrepasa por el dech te duvuelve el maximo.
        return health;
    }
}
