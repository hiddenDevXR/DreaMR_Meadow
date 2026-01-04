// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class DreamEscape_fullVREditorTarget : TargetRules
{
	public DreamEscape_fullVREditorTarget(TargetInfo Target) : base(Target)
	{
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        CppStandard = CppStandardVersion.Cpp20;

        bOverrideBuildEnvironment = true;
        ExtraModuleNames.AddRange(new string[] { "DreamEscape_fullVR" });
    }
}
