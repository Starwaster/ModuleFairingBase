using System;
using KSP;
using UnityEngine;

namespace ModuleFairingBase
{
	public class ModuleFairingBase : PartModule, IScalarModule
	{
		public ModuleFairingBase ()
		{
		}
		//
		// Properties
		//

		[KSPField]
		string fairingName = "";

		[KSPField]
		int fairingCount = 2;

		private EventData <float, float> onMoving;
		private EventData <float> onStop;


		public bool CanMove
		{
			get
			{
				return false;
			}
		}
		
		public float GetScalar
		{
			get
			{
				return 0f;
			}
		}
		
		public EventData<float, float> OnMoving
		{
			get
			{
				return onMoving;
			}
		}
		
		public EventData<float> OnStop
		{
			get
			{
				return onStop;
			}
		}
		
		//
		// Methods
		//
		public bool IsMoving ()
		{
			return false;
		}
		
		public void SetScalar (float t)
		{
		}
		
		public void SetUIRead (bool state)
		{
		}
		
		public void SetUIWrite (bool state)
		{
		}
	}
}

