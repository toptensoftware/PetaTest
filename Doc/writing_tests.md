# PetaTest - Writing Tests

### The Asserts

PetaTest includes a fairly comprehensive set of asserts.  They're not described in detail here since they're very similar to other unit testing frameworks and the source code is right there at the top of `PetaTest.cs` if you need clarification on anything.

### Parameterized Tests

PetaTest can run test cases and test fixtures multiple times with different inputs.

To run an entire test fixture multiple times, specify the parameters to be passed to the class' constructor with the `TestFixture` attribute:

	[TestFixture("input1")]
	[TestFixture("inputs")]
	public class MyTests
	{
		public MyTests(string input)
		{
			// Store parameter
		}
	}

Running individual test cases multiple times is similar:

	[Test(1, 2, 3)]
	[Test(10, 20, 30)]
	public void TestAdd(int a, int b, int c)
	{
		Assert.AreEqual(a+b, c);
	}

You can also programatically supply input data by writing a method on the test fixture class and using the
`Test` or `TestFixture` attribute's `Source` property to specify the name of that method.  

For the `Test` attribute, the source data method can be a static or instance method, but for `TestFixture` it must be a static method.  In either case, the method must return an IEnumerable<object[]>.

	[Test(Source = "GenerateFileList")]
	public void TestParseFile(string filename)
	{
		// Run test on 'filename'
	}

	// This method will be called to get input data for TestParseFile test case.
	public IEnumerable<object[]> GenerateFileList()
	{
		yield return new[] { "file1.txt" };
		yield return new[] { "file2.txt" };

		// or, perhap enumerate a directory
	}

### Setup and TearDown

PetaTest supports Setup and TearDown methods at both the test and test fixture level by decorating methods with the following attributes:

* `[SetUp]` - run before each test case
* `[TearDown]` - run after each test case
* `[TestFixtureSetUp]` - run before all the test cases in a test fixture 
* `[TestFixtureTearDown]` - run after all the test cases in a test fixture

eg:

	[Setup]
	void PrepareForTest()
	{
		// Do common initialization for all tests here
	}

### Generating Output

Sometimes it useful to generate text from within a test case.  PetaTest supports this by capturing any output written to `Console`. Written text is captured and included in the generated report - alongside the test that generated it.

eg:

	[Test]
	void SomeTestCase()
	{
		Console.WriteLine("This should appear in the test report");
	}

Note that by default PetaTest suppresses this output in the console window to keep the results clean.  To view this output as the tests run, use the `/verbose` command line option.