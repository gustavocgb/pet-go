using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class catController : MonoBehaviour
{
    public Animator anim;
    public float distanceLimit = 1f;
    public GameObject cat;
    public GameObject player;
    private bool flag = false;
    private float maxHealth = 600f;
    public HealthBar healthBar;
    public GameObject text;
    public CatHealth CatHealth;
    public PegarObjeto objeto;
    public float pocao;

    void Start()
    {
        pocao = 0;
        objeto = GameObject.Find("Character").GetComponent<PegarObjeto>();
        anim = GetComponent<Animator>();
        CatHealth = GetComponent<CatHealth>();
        cat = GameObject.Find("Cat");
        player = GameObject.Find("Character");
        text.SetActive(false);
    }

    void Update()
    {
        if (Vector3.Distance(cat.transform.position, player.transform.position) < distanceLimit) {
            text.SetActive(true);
            anim.Play("sit");
            flag = true;
        }
        else if (flag) {
            text.SetActive(false);
            anim.Play("idle");
            flag = false;
        }
        if (flag && Input.GetKey("r") && objeto.getPocao() >= 100){
            objeto.setPocao();
            objeto.contador_seg = objeto.contador_seg -0.001;
            healthBar.setHealth(maxHealth);
        }
        if (CatHealth.returnHealth() <= 0){
            anim.Play("sit");
        }
    }
}
