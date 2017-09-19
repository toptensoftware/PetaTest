# PetaTest - Getting Started

1. In Visual Studio, create a new console project.  (PetaTest projects are executables - not assemblies)

2. Install PetaTest using [Nuget](http://nuget.org/List/Packages/PetaTest).  You'll need to agree to 
	[the license](license) after which Nuget will add PetaTest.cs to your project.

        PM> Install-Package PetaTest

3. In `program.cs` add a `using` clause for `PetaTest`

		using PetaTest;

4. In `Main()` call PetaTest's Runner:

		static int Main(string[] args)
		{
			PetaTest.Runner.RunMain(args);
			return 0;
		}

5. Create a test fixture and test case:

		[TestFixture]
		public class MyTests
		{
			[Test]
			public void Test1()
			{
				Assert.AreNotEqual("PetaTest", "NUnit");
			}
		}

6. Run the project and PetaTest will execute all your tests.

