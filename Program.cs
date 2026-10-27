using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using StudentManagement;
namespace StudentManagement
{
    public class Example
    {
        public static async Task Main(string[] args)
    {
            LearnAsyncProgramming obj = new LearnAsyncProgramming();
            await obj.Run();
    }
    }
}