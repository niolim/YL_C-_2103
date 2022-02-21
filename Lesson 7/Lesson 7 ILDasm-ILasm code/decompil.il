
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly 'Lesson 7 Original Code'
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 16 4C 65 73 73 6F 6E 20 37 20 4F 72 69 67   // ...Lesson 7 Orig
                                                                                              69 6E 61 6C 20 43 6F 64 65 00 00 )                // inal Code..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 16 4C 65 73 73 6F 6E 20 37 20 4F 72 69 67   // ...Lesson 7 Orig
                                                                                                69 6E 61 6C 20 43 6F 64 65 00 00 )                // inal Code..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 39 31 61 61 32 36 61 38 2D 33 39 36 31   // ..$91aa26a8-3961
                                                                                                  2D 34 39 32 36 2D 62 33 36 37 2D 35 32 64 66 61   // -4926-b367-52dfa
                                                                                                  65 30 36 65 62 63 30 00 00 )                      // e06ebc0..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1A 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 38 01 00 54   // ,Version=v4.8..T
                                                                                                        0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C   // ..FrameworkDispl
                                                                                                        61 79 4E 61 6D 65 12 2E 4E 45 54 20 46 72 61 6D   // ayName..NET Fram
                                                                                                        65 77 6F 72 6B 20 34 2E 38 )                      // ework 4.8
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module 'Lesson 7 Original Code.exe'
// MVID: {54E0E674-4909-47B3-B9CD-6DFB9F24C672}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x09210000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Lesson_7_Original_Code.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       92 (0x5c)
    .maxstack  2
    .locals init ([0] int32 number2,
             [1] int32 number3,
             [2] int32 avarage)
    IL_0000:  ldstr      "1st number to enter:"
    IL_0005:  call       void [mscorlib]System.Console::Write(string)
    IL_000a:  call       string [mscorlib]System.Console::ReadLine()
    IL_000f:  call       int32 [mscorlib]System.Convert::ToInt32(string)
    IL_0014:  ldstr      "2nd number to enter:"
    IL_0019:  call       void [mscorlib]System.Console::Write(string)
    IL_001e:  call       string [mscorlib]System.Console::ReadLine()
    IL_0023:  call       int32 [mscorlib]System.Convert::ToInt32(string)
    IL_0028:  stloc.0
    IL_0029:  ldstr      "3rd number to enter:"
    IL_002e:  call       void [mscorlib]System.Console::Write(string)
    IL_0033:  call       string [mscorlib]System.Console::ReadLine()
    IL_0038:  call       int32 [mscorlib]System.Convert::ToInt32(string)
    IL_003d:  stloc.1
    IL_003e:  ldloc.0
    IL_003f:  add
    IL_0040:  ldloc.1
    IL_0041:  add
    IL_0042:  ldc.i4.3
    IL_0043:  div
    IL_0044:  stloc.2
    IL_0045:  ldstr      "Average is {0}"
    IL_004a:  ldloc.2
    IL_004b:  box        [mscorlib]System.Int32
    IL_0050:  call       void [mscorlib]System.Console::Write(string,
                                                              object)
    IL_0055:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_005a:  pop
    IL_005b:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class Lesson_7_Original_Code.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file E:\Repos\torment\Homework\YL_C-_2103\Lesson 7\Lesson 7 ILDasm-ILasm code\decompil.res
