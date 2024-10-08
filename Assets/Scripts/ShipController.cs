using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ShipController : MonoBehaviour
{
  // Start is called before the first frame update
  [SerializeField]
  float speed = 6f;

  [SerializeField]
  GameObject SkibidiSigma;

  [SerializeField]
  int maxHealth = 10;
  int currentHealth;

  [SerializeField]
  Slider hpBar;

  [SerializeField]
  TMP_Text pointsText;

  int points = 0;



  void Start()
  {
    currentHealth = maxHealth;
    hpBar.maxValue = maxHealth;
    hpBar.value = currentHealth;

    pointsText.text = points.ToString();
  }

  // Update is called once per frame
  void Update()
  {




    float xInput = Input.GetAxisRaw("Horizontal");
    float yInput = Input.GetAxisRaw("Vertical");




    Vector2 movement = new Vector2(xInput, yInput) * speed;
    // Vector2 movementY = new Vector2(0, 1) * 0.010f * yInput;

    transform.Translate(movement);

    if (Input.GetKeyDown(KeyCode.Space))
    {
      Instantiate(SkibidiSigma, transform.position, Quaternion.identity);
    }




  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "enemy")
    {
      currentHealth--;
      hpBar.value = currentHealth;
      if (currentHealth == 0)
      {
      SceneManager.LoadScene(2);
      }
    }

  }

}



