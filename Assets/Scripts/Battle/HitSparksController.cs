using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSparksController : MonoBehaviour {
	public Animator myAnim;

	public void PlayHitSpark(int sparkType)
	{
		if(myAnim.isActiveAndEnabled)
		{
			if(sparkType == ((int)SpecialEffectsEnums.HitSparkType.Small))
			{
				
				myAnim.SetTrigger("hitspark_Small");
			}
			else if(sparkType == ((int)SpecialEffectsEnums.HitSparkType.Mid))
			{

				myAnim.SetTrigger("hitspark_Mid");
			}
			else if(sparkType == ((int)SpecialEffectsEnums.HitSparkType.Big))
			{

				myAnim.SetTrigger("hitspark_Big");
			}

		}


	}

}
