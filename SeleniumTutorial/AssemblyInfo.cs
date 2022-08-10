using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NUnit.Framework;

//General information about an assembly is controlled through the following
//set of attributes. Change these attributes values to modify the information
//associate with an assembly.

[assembly: AssemblyTitle("SeleniumTutorial")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("nunit.test")]
[assembly: AssemblyCopyright("Copyright @ 2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//Setting ComVisible to false makes the types in this assembly not visible
//to COM components. If you need to access a type in this assembly from
//COM, set the ComVisible attribute to true on that type

[assembly: ComVisible(false)]
//
//Version information for an assembly consists of the following four values:
//
//
//
//  Major Values
//  Minor Values
//  Build Number
//  Revision
//
//You can specify all the values or you can default the Build and Revision Numbers
//by using the '*' as shown below:
//[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

//To define [Test] attributes
[assembly: Parallelizable(ParallelScope.Children)]

//Number of browsers
[assembly: LevelOfParallelism(4)]