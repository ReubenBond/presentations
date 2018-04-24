using System;
using System.Reflection.Emit;

namespace EmitIL
{
    class Program
    {
        static void Main(string[] args)
        {
            var method = new DynamicMethod(
                name: "add",
                returnType: typeof(int),
                parameterTypes: new[] {typeof(int), typeof(int)});
            var il = method.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Add);
            il.Emit(OpCodes.Ret);

            var add = (Func<int, int, int>)method.CreateDelegate(typeof(Func<int, int, int>));

            var sum = add(1, 2);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
