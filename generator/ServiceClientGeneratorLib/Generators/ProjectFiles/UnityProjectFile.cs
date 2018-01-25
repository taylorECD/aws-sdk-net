﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class UnityProjectFile : UnityProjectFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""4.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>");
            
            #line 12 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ProjectGuid"]));
            
            #line default
            #line hidden
            this.Write(@"</ProjectGuid>
    <ProjectTypeGuids>{E097FAD1-6243-4DAD-9C02-E9B9EFC3FFC1};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
	<FileAlignment>512</FileAlignment>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <TargetFrameworkProfile></TargetFrameworkProfile>
    <AssemblyName>");
            
            #line 18 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write("</AssemblyName>\r\n    <RootNamespace>");
            
            #line 19 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["RootNamespace"]));
            
            #line default
            #line hidden
            this.Write("</RootNamespace>\r\n\t<BaseIntermediateOutputPath>obj\\");
            
            #line 20 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write(@"</BaseIntermediateOutputPath>
	<SolutionDir Condition=""$(SolutionDir) == '' Or $(SolutionDir) == '*Undefined*'"">..\..\</SolutionDir>
	<ProductVersion>10.0.0</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
	<RestorePackages>true</RestorePackages>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\");
            
            #line 30 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>DEBUG;TRACE;AWS_APM_API;UNITY;");
            
            #line 31 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DefineConstants"]));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</W" +
                    "arningLevel>\r\n");
            
            #line 34 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    if(this.Session.ContainsKey("SupressWarnings"))
    {

            
            #line default
            #line hidden
            this.Write("\t<NoWarn>3001,3002,3003,3008,3009,");
            
            #line 38 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["SupressWarnings"]));
            
            #line default
            #line hidden
            this.Write("</NoWarn>\r\n");
            
            #line 39 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("\t<CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSup" +
                    "pressionsFile>\r\n\t<DocumentationFile>bin\\Debug\\");
            
            #line 43 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 43 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(@".XML</DocumentationFile>
	<AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\");
            
            #line 49 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>TRACE;AWS_APM_API;UNITY;");
            
            #line 50 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DefineConstants"]));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</W" +
                    "arningLevel>\r\n");
            
            #line 53 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    if(this.Session.ContainsKey("SupressWarnings"))
    {

            
            #line default
            #line hidden
            this.Write("\t<NoWarn>");
            
            #line 57 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["SupressWarnings"]));
            
            #line default
            #line hidden
            this.Write("</NoWarn>\r\n");
            
            #line 58 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModule" +
                    "SuppressionsFile>\r\n\t<DocumentationFile>bin\\Release\\");
            
            #line 62 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 62 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(@".XML</DocumentationFile>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
  <!--
  <PropertyGroup>
    <CheckForOverflowUnderflow>True</CheckForOverflowUnderflow>
    <SignAssembly>true</SignAssembly>
  </PropertyGroup>
  <Choose>
    <When Condition="" '$(AWSKeyFile)' == '' "">
      <PropertyGroup>
");
            
            #line 73 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    if(this.Session.ContainsKey("KeyFilePath"))
    {

            
            #line default
            #line hidden
            this.Write("\t\t<AssemblyOriginatorKeyFile>");
            
            #line 77 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["KeyFilePath"]));
            
            #line default
            #line hidden
            this.Write("</AssemblyOriginatorKeyFile>\r\n");
            
            #line 78 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    }
	else
    {

            
            #line default
            #line hidden
            this.Write("        <AssemblyOriginatorKeyFile>..\\..\\..\\awssdk.dll.snk</AssemblyOriginatorKey" +
                    "File>\r\n");
            
            #line 84 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"      </PropertyGroup>
    </When>
    <Otherwise>
      <PropertyGroup>
        <AssemblyOriginatorKeyFile>$(AWSKeyFile)</AssemblyOriginatorKeyFile>
      </PropertyGroup>
    </Otherwise>
  </Choose>
  -->
  <ItemGroup>
    <Reference Include=""System"" />
    <Reference Include=""System.XML"" />
    <Reference Include=""System.Core"" />
    <Reference Include=""UnityEngine, Version=0.0.0.0, Culture=neutral, processorArchitecture=MSIL"">
      <HintPath>");
            
            #line 101 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine((string)this.Session["UnityPath"], "Editor", "Data", "PlaybackEngines", "windowsstandalonesupport", "Managed", "UnityEngine.dll")));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"UnityEngine.CoreModule, Ve" +
                    "rsion=0.0.0.0, Culture=neutral, processorArchitecture=MSIL\">\r\n      <HintPath>");
            
            #line 104 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine((string)this.Session["UnityPath"], "Editor", "Data", "PlaybackEngines", "windowsstandalonesupport", "Managed", "UnityEngine.CoreModule.dll")));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"UnityEngine.WebModule, Ver" +
                    "sion=0.0.0.0, Culture=neutral, processorArchitecture=MSIL\">\r\n      <HintPath>");
            
            #line 107 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine((string)this.Session["UnityPath"], "Editor", "Data", "PlaybackEngines", "windowsstandalonesupport", "Managed", "UnityEngine.WebModule.dll")));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"UnityEngine.UnityWebReques" +
                    "tWWWModule, Version=0.0.0.0, Culture=neutral, processorArchitecture=MSIL\">\r\n    " +
                    "  <HintPath>");
            
            #line 110 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine((string)this.Session["UnityPath"], "Editor", "Data", "PlaybackEngines", "windowsstandalonesupport", "Managed", "UnityEngine.UnityWebRequestWWWModule.dll")));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"System.Runtime.Serializati" +
                    "on\" />\r\n    <Reference Include=\"System.Xml.Linq\" />\r\n");
            
            #line 114 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

	if(this.Session.ContainsKey("ReferenceDependencies"))
    {
		foreach(var dependency in (List<Dependency>)this.Session["ReferenceDependencies"])
		{

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 120 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <HintPath>");
            
            #line 121 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.Combine((string)this.Session["UnityPath"], dependency.HintPath)));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n      <Private>True</Private>\r\n    </Reference>\r\n");
            
            #line 124 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
   
		}
	}

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n");
            
            #line 130 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    foreach(string subDirectory in ((IList<string>)this.Session["SourceDirectories"]))
    {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 134 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subDirectory));
            
            #line default
            #line hidden
            this.Write("\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 137 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n");
            
            #line 142 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    if(this.Session.ContainsKey("IndividualFileIncludes"))
    {
        foreach(string file in ((IList<string>)this.Session["IndividualFileIncludes"]))
        {
            if(file.EndsWith(".cs"))
            {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 150 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 153 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("    <EmbeddedResource Include=\"");
            
            #line 158 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Designer</SubType>\r\n    </EmbeddedResource>\r\n");
            
            #line 161 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

            }
        }
    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 167 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

    if(this.Session.ContainsKey("ProjectReferences"))
    {
        foreach(var projectReferences in (List<ProjectFileCreator.ProjectReference>)this.Session["ProjectReferences"])
        {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n    <ProjectReference Include=\"");
            
            #line 174 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.IncludePath));
            
            #line default
            #line hidden
            this.Write("\">\r\n        <Project>");
            
            #line 175 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n        <Name>");
            
            #line 176 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.Name));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n  </ItemGroup>\r\n");
            
            #line 179 "C:\git\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnityProjectFile.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write(@"  <ItemGroup>
    <Compile Include=""Properties\AssemblyInfo.cs"" />
	<None Include=""packages.config"" />
  </ItemGroup>
  <Import Project=""$(MSBuildToolsPath)\Microsoft.CSharp.targets"" />
  <Import Project=""$(SolutionDir)\.nuget\NuGet.targets"" Condition=""Exists('$(SolutionDir)\.nuget\NuGet.targets')"" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name=""BeforeBuild"">
  </Target>
  <Target Name=""AfterBuild"">
  </Target>
  -->
</Project>
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class UnityProjectFileBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
