using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbitController : MonoBehaviour
{
    public Animator anim;
    public float distanceLimit = 1f;
    public GameObject rabbit;
    public GameObject player;
    private bool flag = false;
    private float maxHealth = 600f;
    public HealthBar healthBar;
    public GameObject text;
    public RabbitHealth RabbitHealth;
    public PegarObjeto objeto;

    void Start()
    {
        objeto = GameObject.Find("Character").GetComponent<PegarObjeto>();
        anim = GetComponent<Animator>();
        RabbitHealth = GetComponent<RabbitHealth>();
        rabbit = GameObject.Find("Demo White Rabbit");
        player = GameObject.Find("Character");
        text.SetActive(false);
    }

    void Update()
    {
        if (Vector3.Distance(rabbit.transform.position, player.transform.position) < distanceLimit) {
            text.SetActive(true);
            GetComponent<Animator>().enabled = false;
            GetComponent<animalMovement>().enabled = false;
            flag = true;
        }
        else if (flag) {
            text.SetActive(false);
            GetComponent<Animator>().enabled = true;
            GetComponent<animalMovement>().enabled = true;
            flag = false;
        }
        if (flag && Input.GetKey("r")&& objeto.getPocao() >= 100) {
            objeto.setPocao();
            objeto.contador_seg = objeto.contador_seg -0.001;
            healthBar.setHealth(maxHealth);
        }

        if (RabbitHealth.returnHealth() <= 0){
            GetComponent<Animator>().enabled = false;
            GetComponent<animalMovement>().enabled = false;
        }
    }
}
