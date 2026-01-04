// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class DreamEscape_fullVRTarget : TargetRules
{
	public DreamEscape_fullVRTarget(TargetInfo Target) : base(Target)
	{
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        CppStandard = CppStandardVersion.Cpp20;

        bOverrideBuildEnvironment = true;

        ExtraModuleNames.AddRange(new string[] { "DreamEscape_fullVR" });
    }
}
