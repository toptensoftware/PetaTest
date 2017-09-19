# PetaTest - Running PetaTest Projects

With PetaTest there is no external "runner" program - it's all built in to your unit test project.  To run your tests, simply run your project's output `.exe` file.

By default PetaTest will generate reports to the console - so you can view the progress of the tests as they run.  On completion, you'll be prompted to view a full report in your browser. Press 'Y' to show the report.

You can control this behaviour with the command line options shown below.

### Command Line Options

* `/showreport[:yes|no]` - automatically show the HTML report instead of prompting (default = prompt)
* `/htmlreport[:yes|no]` - generate the HTML report (default = yes)
* `/dirtyexit[:yes|no]` - terminate the process on completion rather than cleanly shutting down (faster in some cases)
* `/runall[:yes|no]` - run all tests even if one or more are marked as active
* `/verbose` - show Console.WriteLine output in the console while the test runs
* `/out:<filename>` - name of the HTML file to generate - defaults to `report.html` in the current directory.

### Active Tests

Often during debugging and development you'll want to run just a single test.  You can mark such a test with the `Active` property. For example:

	[Test(Active=true)]
	public void Test1()
	{
		// This will run
	}

	[Test]
	public void Test2()
	{
		// This won't
	}

It also works for paremeterized inputs:

	[Test("Hello", Active=true)]
	[Test("World")]
	public void Test(string input)
	{
		// This will only run once with "Hello" input
	}

and it works on test fixtures too.

	[TestFixture(Active=true)]
	public class MyTests
	{
		...
	}

You can apply the `Active` flag to multiple tests and test fixtures and all those marked will be run.  If nothing is marked as active then all tests are run.

