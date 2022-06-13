<#
    .SYNOPSIS
        The script to find examples in ".md" and analyze the examples by custom rules.
    .NOTES
        File Name: Measure-MarkdownOrScript.ps1
#>

#Requires -Modules PSScriptAnalyzer

[CmdletBinding(DefaultParameterSetName = "Markdown")]
param (
    [Parameter(Mandatory, HelpMessage = "Markdown searching paths. Empty for current path. Supports wildcard.", ParameterSetName = "Markdown")]
    [AllowEmptyString()]
    [string[]]$MarkdownPaths,
    [Parameter(Mandatory, HelpMessage = "PowerShell scripts searching paths. Empty for current path. Supports wildcard.", ParameterSetName = "Script")]
    [AllowEmptyString()]
    [string[]]$ScriptPaths,
    [Parameter(HelpMessage = "PSScriptAnalyzer custom rules paths. Empty for current path. Supports wildcard.")]
    [string[]]$RulePaths,
    [switch]$Recurse,
    [switch]$IncludeDefaultRules,
    [string]$OutputFolder = ".\artifacts\StaticAnalysisResults\ExampleAnalysis",
    [Parameter(ParameterSetName = "Markdown")]
    [switch]$AnalyzeScriptsInFile,
    [Parameter(ParameterSetName = "Markdown")]
    [switch]$OutputScriptsInFile,
    [switch]$OutputResultsByModule,
    [switch]$CleanScripts
)

. $PSScriptRoot\utils.ps1

if ($PSCmdlet.ParameterSetName -eq "Markdown") {
    $ScriptsByExampleFolder = "ScriptsByExample"
    $scaleTable = @()
    $missingTable = @()
    $deletePromptAndSeparateOutputTable = @()
}
$analysisResultsTable = @()

# Clean caches, remove files in "output" folder
if ($OutputScriptsInFile.IsPresent) {
    Remove-Item $OutputFolder\TempScript.ps1 -ErrorAction SilentlyContinue
    Remove-Item $OutputFolder\*.csv -Recurse -ErrorAction SilentlyContinue
    Remove-Item .\artifacts\StaticAnalysisResults\ExampleIssues.csv -ErrorAction SilentlyContinue
    Remove-Item $OutputFolder -ErrorAction SilentlyContinue
}


# find examples in "help\*.md", output ".ps1"
if ($PSCmdlet.ParameterSetName -eq "Markdown") {
    $null = New-Item -ItemType Directory -Path $OutputFolder -ErrorAction SilentlyContinue
    $null = New-Item -ItemType File  $OutputFolder\TempScript.ps1
    $MarkdownPath = Get-Content $MarkdownPaths
    (Get-ChildItem $MarkdownPath) | foreach{
        # Filter the .md of overview in \help\
        if ((Get-Item -Path $_.FullName).Directory.Name -eq "help" -and $_.FullName -cmatch ".*\.md" -and $_.BaseName -cmatch "^([A-Z][a-z]+)+-([A-Z][a-z0-9]*)+$") {
            Write-Output "Searching in file $($_.FullName) ..."
            $module = (Get-Item -Path $_.FullName).Directory.Parent.Name
            $cmdlet = $_.BaseName
            $result = Measure-SectionMissingAndOutputScript $module $cmdlet $_.FullName `
                -OutputScriptsInFile:$OutputScriptsInFile.IsPresent `
                -OutputFolder $OutputFolder
            $scaleTable += $result.Scale
            $missingTable += $result.Missing
            $deletePromptAndSeparateOutputTable += $result.DeletePromptAndSeparateOutput
            $analysisResultsTable += $result.Errors
        }
    }
    if ($AnalyzeScriptsInFile.IsPresent) {
        $ScriptPaths = "$OutputFolder\TempScript.ps1"
    }
    # Summarize searching results
    if($scaleTable){
         $scaleTable | where {$_ -ne $null} | Export-Csv "$OutputFolder\Scale.csv" -NoTypeInformation
    }
    if($missingTable){
        $missingTable | where {$_ -ne $null} | Export-Csv "$OutputFolder\Missing.csv" -NoTypeInformation
    }
    if($deletePromptAndSeparateOutputTable){
        $deletePromptAndSeparateOutputTable | where {$_ -ne $null} | Export-Csv "$OutputFolder\DeletingSeparating.csv" -NoTypeInformation
    }
}


# Analyze scripts
if ($PSCmdlet.ParameterSetName -eq "Script" -or $AnalyzeScriptsInFile.IsPresent) {
    # read and analyze ".ps1" in \ScriptsByExample
    Write-Output "Analyzing file ..."
    $analysisResultsTable += Get-ScriptAnalyzerResult (Get-Item -Path $ScriptPaths) $RulePaths -IncludeDefaultRules:$IncludeDefaultRules.IsPresent -ErrorAction SilentlyContinue
    
    # Summarize analysis results, output in Result.csv
    if($analysisResultsTable){
        $analysisResultsTable| where {$_ -ne $null} | Export-Csv ".\artifacts\StaticAnalysisResults\ExampleIssues.csv" -NoTypeInformation
    }
}

# Clean caches
if ($CleanScripts.IsPresent) {
    Remove-Item $ScriptPaths -Exclude *.csv -Recurse -ErrorAction Continue
}
