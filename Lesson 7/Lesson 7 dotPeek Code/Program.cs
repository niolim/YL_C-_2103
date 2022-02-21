// Decompiled with JetBrains decompiler
// Type: Lesson_7_Original_Code.Program
// Assembly: Lesson 7 Original Code, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 54E0E674-4909-47B3-B9CD-6DFB9F24C672
// Assembly location: E:\Repos\torment\Homework\YL_C-_2103\Lesson 7\Lesson 7 Original Code\bin\Release\Lesson 7 Original Code.exe

using System;

namespace Lesson_7_Original_Code
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.Write("Введите 1е число :");
      int int32_1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите 2е число :");
      int int32_2 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите 3е число :");
      int int32_3 = Convert.ToInt32(Console.ReadLine());
      int num = int32_2;
      Console.Write("Среднее значение из трех чисел {0}", (object) ((int32_1 + num + int32_3) / 3));
      Console.ReadKey();
    }
  }
}
