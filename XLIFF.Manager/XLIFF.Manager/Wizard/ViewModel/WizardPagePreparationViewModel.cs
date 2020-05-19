﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdl.Community.XLIFF.Manager.Wizard.ViewModel
{
	public class WizardPagePreparationViewModel : WizardPageViewModelBase
	{
		private string _displayName;
		private bool _isValid;

		public WizardPagePreparationViewModel(object view) : base(view)
		{
			_displayName = "Preparation";
			IsValid = true;
		}

		public override string DisplayName => _displayName;

		public override bool IsValid
		{
			get => _isValid;
			set => _isValid = value;
		}
	}
}