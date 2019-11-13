﻿using System.Diagnostics.Contracts;
using System.Windows.Forms;
using Sdl.Community.CleanUpTasks.Contracts;

namespace Sdl.Community.CleanUpTasks
{
	[ContractClass(typeof(ICleanUpTargetSettingsControlContract))]
    public interface ICleanUpTargetSettingsControl
    {
        Button BackupButton { get; }
        TextBox BackupFolder { get; }
        CheckBox GenerateTarget { get; }
        CheckBox MakeBackups { get; }
        CheckBox OverwriteSdlXliff { get; }
        Button SaveButton { get; }
        TextBox SaveFolder { get; }
        CleanUpTargetSettings Settings { get; set; }
    }
}