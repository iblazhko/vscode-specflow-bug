# VSCode C# Extension SpecFlow Problem

## Description

This repository demonstrates problem with VisualStudio C# extension
when opening a project that has SpecFlow reference.

## Prerequisites

- Linux
- .NET Core 2.2
- VisualStudio Code 1.35.1

## Steps to reproduce

- Open the solution
- Open VisualStudio Code Output window
- Observe the logs (VSCode will also display a warning saying that projects had troubles loading)

Error:

```txt
[warn]: OmniSharp.MSBuild.ProjectManager
        Failed to load project file '/home/iblazhko/Projects/vscode-specflow-bug/src/Product.Library.Acceptance.Tests/Product.Library.Acceptance.Tests.csproj'.
/home/iblazhko/Projects/vscode-specflow-bug/src/Product.Library.Acceptance.Tests/Product.Library.Acceptance.Tests.csproj(1,1)
Microsoft.Build.Exceptions.InvalidProjectFileException: The imported project "/home/iblazhko/.nuget/packages/specflow.tools.msbuild.generation/3.0.220/build/CPS/BuildSystem/CpsExtension.DesignTime.targets" was not found. Confirm that the path in the <Import> declaration is correct, and that the file exists on disk.  /home/iblazhko/.nuget/packages/specflow.tools.msbuild.generation/3.0.220/build/SpecFlow.Tools.MsBuild.Generation.props
  at Microsoft.Build.Shared.ProjectErrorUtilities.ThrowInvalidProject (System.String errorSubCategoryResourceName, Microsoft.Build.Shared.IElementLocation elementLocation, System.String resourceName, System.Object[] args) [0x00040] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Shared.ProjectErrorUtilities.VerifyThrowInvalidProject[T1] (System.Boolean condition, System.String errorSubCategoryResourceName, Microsoft.Build.Shared.IElementLocation elementLocation, System.String resourceName, T1 arg0) [0x00003] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Shared.ProjectErrorUtilities.ThrowInvalidProject[T1] (Microsoft.Build.Shared.IElementLocation elementLocation, System.String resourceName, T1 arg0) [0x00000] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].ExpandAndLoadImportsFromUnescapedImportExpression (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportElement importElement, System.String unescapedExpression, System.Boolean throwOnFileNotExistsError, System.Collections.Generic.List`1[Microsoft.Build.Construction.ProjectRootElement]& imports) [0x005fb] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].ExpandAndLoadImportsFromUnescapedImportExpressionConditioned (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportElement importElement, System.Collections.Generic.List`1[Microsoft.Build.Construction.ProjectRootElement]& projects, Microsoft.Build.BackEnd.SdkResolution.SdkResult& sdkResult, System.Boolean throwOnFileNotExistsError) [0x00262] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].ExpandAndLoadImports (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportElement importElement, Microsoft.Build.BackEnd.SdkResolution.SdkResult& sdkResult) [0x00027] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].EvaluateImportElement (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportElement importElement) [0x0000d] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].PerformDepthFirstPass (Microsoft.Build.Construction.ProjectRootElement currentProjectOrImport) [0x00209] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].EvaluateImportElement (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportElement importElement) [0x00040] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].EvaluateImportGroupElement (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportGroupElement importGroupElement) [0x00033] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].PerformDepthFirstPass (Microsoft.Build.Construction.ProjectRootElement currentProjectOrImport) [0x00226] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].EvaluateImportElement (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportElement importElement) [0x00040] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].PerformDepthFirstPass (Microsoft.Build.Construction.ProjectRootElement currentProjectOrImport) [0x00209] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].EvaluateImportElement (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportElement importElement) [0x00040] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].PerformDepthFirstPass (Microsoft.Build.Construction.ProjectRootElement currentProjectOrImport) [0x00209] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].EvaluateImportElement (System.String directoryOfImportingFile, Microsoft.Build.Construction.ProjectImportElement importElement) [0x00040] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].PerformDepthFirstPass (Microsoft.Build.Construction.ProjectRootElement currentProjectOrImport) [0x000e6] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].Evaluate (Microsoft.Build.BackEnd.Logging.ILoggingService loggingService, Microsoft.Build.Framework.BuildEventContext buildEventContext) [0x00103] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Evaluator`4[P,I,M,D].Evaluate (Microsoft.Build.Evaluation.IEvaluatorData`4[P,I,M,D] data, Microsoft.Build.Construction.ProjectRootElement root, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings, System.Int32 maxNodeCount, Microsoft.Build.Collections.PropertyDictionary`1[T] environmentProperties, Microsoft.Build.BackEnd.Logging.ILoggingService loggingService, Microsoft.Build.Evaluation.IItemFactory`2[S,T] itemFactory, Microsoft.Build.Evaluation.IToolsetProvider toolsetProvider, Microsoft.Build.Evaluation.ProjectRootElementCache projectRootElementCache, Microsoft.Build.Framework.BuildEventContext buildEventContext, Microsoft.Build.BackEnd.SdkResolution.ISdkResolverService sdkResolverService, System.Int32 submissionId, Microsoft.Build.Evaluation.Context.EvaluationContext evaluationContext) [0x0002d] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project.Reevaluate (Microsoft.Build.BackEnd.Logging.ILoggingService loggingServiceForEvaluation, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings, Microsoft.Build.Evaluation.Context.EvaluationContext evaluationContext) [0x0005e] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project.ReevaluateIfNecessary (Microsoft.Build.BackEnd.Logging.ILoggingService loggingServiceForEvaluation, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings, Microsoft.Build.Evaluation.Context.EvaluationContext evaluationContext) [0x00035] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project.ReevaluateIfNecessary (Microsoft.Build.BackEnd.Logging.ILoggingService loggingServiceForEvaluation, Microsoft.Build.Evaluation.Context.EvaluationContext evaluationContext) [0x00000] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project.ReevaluateIfNecessary (Microsoft.Build.Evaluation.Context.EvaluationContext evaluationContext) [0x00007] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project.Initialize (System.Collections.Generic.IDictionary`2[TKey,TValue] globalProperties, System.String toolsVersion, System.String subToolsetVersion, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings, Microsoft.Build.Evaluation.Context.EvaluationContext evaluationContext) [0x00126] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project..ctor (System.String projectFile, System.Collections.Generic.IDictionary`2[TKey,TValue] globalProperties, System.String toolsVersion, System.String subToolsetVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings, Microsoft.Build.Evaluation.Context.EvaluationContext evaluationContext) [0x00093] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project..ctor (System.String projectFile, System.Collections.Generic.IDictionary`2[TKey,TValue] globalProperties, System.String toolsVersion, System.String subToolsetVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) [0x00000] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project..ctor (System.String projectFile, System.Collections.Generic.IDictionary`2[TKey,TValue] globalProperties, System.String toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) [0x00000] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.Project..ctor (System.String projectFile, System.Collections.Generic.IDictionary`2[TKey,TValue] globalProperties, System.String toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) [0x00000] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.ProjectCollection.LoadProject (System.String fileName, System.Collections.Generic.IDictionary`2[TKey,TValue] globalProperties, System.String toolsVersion) [0x000f7] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at Microsoft.Build.Evaluation.ProjectCollection.LoadProject (System.String fileName, System.String toolsVersion) [0x00000] in <4e0a1f1d78cf4c1ebd6f9a3dbcebf3bb>:0 
  at OmniSharp.MSBuild.ProjectLoader.EvaluateProjectFileCore (System.String filePath) [0x0003f] in <598756bbad7c4a61bb212e3681e5d1da>:0 
  at OmniSharp.MSBuild.ProjectLoader.BuildProject (System.String filePath) [0x0000d] in <598756bbad7c4a61bb212e3681e5d1da>:0 
  at OmniSharp.MSBuild.ProjectFile.ProjectFileInfo.Load (System.String filePath, OmniSharp.MSBuild.ProjectIdInfo projectIdInfo, OmniSharp.MSBuild.ProjectLoader loader) [0x00015] in <598756bbad7c4a61bb212e3681e5d1da>:0 
  at OmniSharp.MSBuild.ProjectManager+<>c__DisplayClass30_0.<LoadProject>b__0 () [0x00000] in <598756bbad7c4a61bb212e3681e5d1da>:0 
  at (wrapper delegate-invoke) System.Func`1[System.ValueTuple`3[OmniSharp.MSBuild.ProjectFile.ProjectFileInfo,System.Collections.Immutable.ImmutableArray`1[OmniSharp.MSBuild.Logging.MSBuildDiagnostic],OmniSharp.MSBuild.Notification.ProjectLoadedEventArgs]].invoke_TResult()
  at OmniSharp.MSBuild.ProjectManager.LoadOrReloadProject (System.String projectFilePath, System.Func`1[TResult] loader) [0x0001b] in <598756bbad7c4a61bb212e3681e5d1da>:0
  ```