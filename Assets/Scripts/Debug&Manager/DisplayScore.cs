using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Image jaugePsy, jaugeFin, jaugeCon, jaugeHar;

	void Update ()
    {           
        jaugePsy.fillAmount = (GameManager.Instance.currPsy / GameManager.Instance.gaugePsycho) ;

        jaugeFin.fillAmount = (GameManager.Instance.currFin / GameManager.Instance.gaugeFinances);

        jaugeCon.fillAmount = (GameManager.Instance.currCon / GameManager.Instance.gaugeConsomation);

        jaugeHar.fillAmount = (GameManager.Instance.currHar / GameManager.Instance.gaugeHarassement);

		if (Input.GetKeyUp(KeyCode.A)) 
		{
			
			GameManager.Instance.currFin++;
		}
    }				
}