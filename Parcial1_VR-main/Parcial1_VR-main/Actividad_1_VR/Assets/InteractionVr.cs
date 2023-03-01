using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia.Interactions.Controllables;
using Tilia.Interactions.Controllables.AngularDriver;
using Unity.VisualScripting;

public class InteractionVr : MonoBehaviour
{
   [SerializeField] AngularDriveFacade angularDrive;
   [SerializeField] float targetValue;
   [SerializeField] ParticleSystem particleSystem;
   public bool isInteracting;
   private void Update()
   {
      if (angularDrive.TargetValue >= targetValue && !isInteracting)
      {
         isInteracting = true;
         ActiveParticleSystemInteraction();
         Debug.Log("soy una interaccion");
      }
   }
   
   public void ActiveParticleSystemInteraction()
   {
      particleSystem.Play();
   }
}
