using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetaTest
{
	[TestFixture]
	public class AssertionTests
	{
		[Test]
		public void AreEqual_sbyte()
		{
			Assert.AreEqual<sbyte>(10, 10);
			Assert.AreNotEqual<sbyte>(10, 11);
			Assert.Throws<AssertionException>(() => Assert.AreEqual<sbyte>(10, 11));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual<sbyte>(10, 10));
		}

		[Test]
		public void AreEqual_byte()
		{
			Assert.AreEqual<byte>(10, 10);
			Assert.AreNotEqual<byte>(10, 11);
			Assert.Throws<AssertionException>(() => Assert.AreEqual<byte>(10, 11));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual<byte>(10, 10));
		}

		[Test]
		public void AreEqual_short()
		{
			Assert.AreEqual<short>(10, 10);
			Assert.AreNotEqual<short>(10, 11);
			Assert.Throws<AssertionException>(() => Assert.AreEqual<short>(10, 11));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual<short>(10, 10));
		}

		[Test]
		public void AreEqual_ushort()
		{
			Assert.AreEqual<ushort>(10, 10);
			Assert.AreNotEqual<ushort>(10, 11);
			Assert.Throws<AssertionException>(() => Assert.AreEqual<ushort>(10, 11));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual<ushort>(10, 10));
		}

		[Test]
		public void AreEqual_int()
		{
			Assert.AreEqual(10, 10);
			Assert.AreNotEqual(10, 11);
			Assert.Throws<AssertionException>(() => Assert.AreEqual(10, 11));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(10, 10));
		}

		[Test]
		public void AreEqual_uint()
		{
			Assert.AreEqual(10u, 10u);
			Assert.AreNotEqual(10u, 11u);
			Assert.Throws<AssertionException>(() => Assert.AreEqual(10u, 11u));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(10u, 10u));
		}

		[Test]
		public void AreEqual_long()
		{
			Assert.AreEqual(10L, 10L);
			Assert.AreNotEqual(10L, 11L);
			Assert.Throws<AssertionException>(() => Assert.AreEqual(10L, 11L));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(10L, 10L));
		}

		[Test]
		public void AreEqual_ulong()
		{
			Assert.AreEqual(10UL, 10UL);
			Assert.AreNotEqual(10UL, 11UL);
			Assert.Throws<AssertionException>(() => Assert.AreEqual(10UL, 11UL));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(10UL, 10UL));
		}

		[Test]
		public void AreEqual_float()
		{
			Assert.AreEqual(10.0f, 10.0f);
			Assert.AreNotEqual(10.0f, 11.0f);
			Assert.Throws<AssertionException>(() => Assert.AreEqual(10.0f, 11.0f));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(10.0f, 10.0f));
		}

		[Test]
		public void AreEqual_double()
		{
			Assert.AreEqual(10.0, 10.0);
			Assert.AreNotEqual(10.0, 11.0);
			Assert.Throws<AssertionException>(() => Assert.AreEqual(10.0, 11.0));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(10.0, 10.0));
		}

		[Test]
		public void AreEqual_double_within()
		{
			Assert.AreEqual(10.5, 10.0, 1.0);
			Assert.AreEqual(9.5, 10.0, 1.0);
			Assert.AreNotEqual(10.5, 10.0, 0.2);
			Assert.AreNotEqual(9.5, 10.0, 0.2);

			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(10.5, 10.0, 1.0));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(9.5, 10.0, 1.0));
			Assert.Throws<AssertionException>(() => Assert.AreEqual(10.5, 10.0, 0.2));
			Assert.Throws<AssertionException>(() => Assert.AreEqual(9.5, 10.0, 0.2));
		}

		[Test]
		public void AreEqual_decimal()
		{
			Assert.AreEqual((decimal)10.0, (decimal)10.0);
			Assert.AreNotEqual((decimal)10.0, (decimal)11.0);
			Assert.Throws<AssertionException>(() => Assert.AreEqual((decimal)10.0, (decimal)11.0));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual((decimal)10.0, (decimal)10.0));
		}

		[Test]
		public void AreEqual_string()
		{
			Assert.AreEqual("apples", "apples", false);
			Assert.AreNotEqual("apples", "oranges");
			Assert.Throws<AssertionException>(() => Assert.AreEqual("apples", "oranges", false));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual("apples", "apples", false));

			Assert.AreEqual("apples", "APPLES", true);
			Assert.AreNotEqual("apples", "ORANGES", true);
			Assert.Throws<AssertionException>(() => Assert.AreEqual("apples", "ORANGES", true));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual("apples", "APPLES", true));
		}

		[Test]
		public void AreEqual_dates()
		{
			var d1 = new DateTime(2011, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			var d2 = new DateTime(2011, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			var d3 = new DateTime(2011, 1, 2, 0, 0, 0, DateTimeKind.Utc);

			Assert.AreEqual(d1, d2);
			Assert.AreNotEqual(d1, d3);
			Assert.Throws<AssertionException>(() => Assert.AreEqual(d1, d3));
			Assert.Throws<AssertionException>(() => Assert.AreNotEqual(d1, d2));
		}

		[Test]
		public void IsTrue()
		{
			Assert.IsTrue(true);
			Assert.IsFalse(false);
			Assert.Throws<AssertionException>(() => Assert.IsTrue(false));
			Assert.Throws<AssertionException>(() => Assert.IsFalse(true));
		}

		[Test]
		public void IsNull()
		{
			Assert.IsNull(null);
			Assert.IsNotNull(new object());
			Assert.Throws<AssertionException>(() => Assert.IsNull(new object()));
			Assert.Throws<AssertionException>(() => Assert.IsNotNull(null));
		}

		[Test]
		public void AreSame()
		{
			var o1 = new object();
			var o2 = new object();
			Assert.AreSame(o1, o1);
			Assert.AreNotSame(o1, o2);
			Assert.Throws<AssertionException>(() => Assert.AreSame(o1, o2));
			Assert.Throws<AssertionException>(() => Assert.AreNotSame(o1, o1));
		}


		[Test]
		public void IsEmpty_String()
		{
			Assert.IsEmpty("");
			Assert.IsNotEmpty("apples");
			Assert.Throws<AssertionException>(() => Assert.IsEmpty("apples"));
			Assert.Throws<AssertionException>(() => Assert.IsNotEmpty(""));
			Assert.Throws<AssertionException>(() => Assert.IsNotEmpty((string)null));
		}


		[Test]
		public void IsNullOrEmpty_String()
		{
			Assert.IsNullOrEmpty((string)null);
			Assert.IsNullOrEmpty("");
			Assert.IsNotNullOrEmpty("apples");
			Assert.Throws<AssertionException>(() => Assert.IsNullOrEmpty("apples"));
			Assert.Throws<AssertionException>(() => Assert.IsNotNullOrEmpty(""));
			Assert.Throws<AssertionException>(() => Assert.IsNotNullOrEmpty((string)null));
		}

		[Test]
		public void IsEmpty_Collection()
		{
			Assert.IsEmpty(new int[] { });
			Assert.IsNotEmpty(new int[] { 1 });
			Assert.Throws<AssertionException>(() => Assert.IsEmpty(new int[] { 1 }));
			Assert.Throws<AssertionException>(() => Assert.IsNotEmpty(new int[] { }));
			Assert.Throws<AssertionException>(() => Assert.IsEmpty((object[])null));
			Assert.Throws<AssertionException>(() => Assert.IsNotEmpty((object[])null));
		}

		[Test]
		public void Contains_Collection()
		{
			Assert.Contains(new int[] { 1, 2, 3 }, 2);
			Assert.DoesNotContain(new int[] { 1, 2, 3 }, 4);
			Assert.Throws<AssertionException>(() => Assert.Contains(new int[] { 1, 2, 3 }, 4));
			Assert.Throws<AssertionException>(() => Assert.DoesNotContain(new int[] { 1, 2, 3 }, 2));
		}

		[Test]
		public void Contains_String()
		{
			Assert.Contains("Hello World", "lo", false);
			Assert.DoesNotContain("Hello World", "hi", false);
			Assert.Throws<AssertionException>(() => Assert.Contains("Hello World", "hi", false));
			Assert.Throws<AssertionException>(() => Assert.DoesNotContain("Hello World", "lo", false));

			Assert.Contains("Hello World", "LO", true);
			Assert.DoesNotContain("Hello World", "HI", true);
			Assert.Throws<AssertionException>(() => Assert.Contains("Hello World", "HI", true));
			Assert.Throws<AssertionException>(() => Assert.DoesNotContain("Hello World", "LO", true));
		}

		[Test]
		public void Greater()
		{
			Assert.Greater(20, 10);
			Assert.Throws<AssertionException>(() => Assert.Greater(10, 20));
			Assert.Throws<AssertionException>(() => Assert.Greater(10, 10));
		}

		[Test]
		public void GreaterOrEqual()
		{
			Assert.GreaterOrEqual(20, 10);
			Assert.GreaterOrEqual(20, 20);
			Assert.Throws<AssertionException>(() => Assert.Greater(10, 20));
		}

		[Test]
		public void Less()
		{
			Assert.Less(10, 20);
			Assert.Throws<AssertionException>(() => Assert.Less(20, 10));
			Assert.Throws<AssertionException>(() => Assert.Less(10, 10));
		}

		[Test]
		public void LessOrEqual()
		{
			Assert.LessOrEqual(10, 20);
			Assert.LessOrEqual(20, 20);
			Assert.Throws<AssertionException>(() => Assert.Less(20, 10));
		}

		[Test]
		public void IsInstanceOf()
		{
			Assert.IsInstanceOf<A>(new A());
			Assert.IsNotInstanceOf<A>(new B());
			Assert.IsNotInstanceOf<A>(DateTime.Now);
			Assert.Throws<AssertionException>(() => Assert.IsInstanceOf<A>(new B()));
			Assert.Throws<AssertionException>(() => Assert.IsNotInstanceOf<A>(new A()));
			Assert.Throws<AssertionException>(() => Assert.IsInstanceOf<A>(DateTime.Now));
		}

		[Test]
		public void IsAssignableFrom()
		{
			Assert.IsAssignableFrom<A>(new A());
			Assert.IsAssignableFrom<B>(new A());
			Assert.IsNotAssignableFrom<A>(new B());
			Assert.Throws<AssertionException>(() => Assert.IsNotAssignableFrom<A>(new A()));
			Assert.Throws<AssertionException>(() => Assert.IsNotAssignableFrom<B>(new A()));
			Assert.Throws<AssertionException>(() => Assert.IsAssignableFrom<A>(new B()));
		}

		[Test]
		public void IsAssignableTo()
		{
			Assert.IsAssignableTo<A>(new A());
			Assert.IsNotAssignableTo<B>(new A());
			Assert.IsAssignableTo<A>(new B());
			Assert.Throws<AssertionException>(() => Assert.IsNotAssignableTo<A>(new A()));
			Assert.Throws<AssertionException>(() => Assert.IsAssignableTo<B>(new A()));
			Assert.Throws<AssertionException>(() => Assert.IsNotAssignableTo<A>(new B()));
		}

		[Test]
		public void AllItemsAreUnique()
		{
			Assert.AllItemsAreUnique(new int[] { 1, 2, 3 });
			Assert.Throws<AssertionException>(() => Assert.AllItemsAreUnique(new int[] { 1, 2, 2 }));
		}

		[Test]
		public void AllItemsAreNotNull()
		{
			Assert.AllItemsAreNotNull(new object[] { new object(), new object(), new object() });
			Assert.Throws<AssertionException>(() => Assert.AllItemsAreNotNull(new object[] { new object(), null, new object() }));
		}

		[Test]
		public void AllItemsAreEqual()
		{
			Assert.AllItemsAreEqual(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			Assert.Throws<AssertionException>(() => Assert.AllItemsAreEqual(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 }));
		}

		[Test]
		public void AllItemsAreInstancesOf()
		{
			Assert.AllItemsAreInstancesOf<DateTime>(new object[] { DateTime.Now, DateTime.Now });
			Assert.Throws<AssertionException>(() => Assert.AllItemsAreInstancesOf<DateTime>(new object[] { DateTime.Now, null }));
			Assert.Throws<AssertionException>(() => Assert.AllItemsAreInstancesOf<DateTime>(new object[] { DateTime.Now, new object() }));
		}

		[Test]
		public void IsSubsetOf()
		{
			Assert.IsSubsetOf(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			Assert.IsSubsetOf(new int[] { 1 }, new int[] { 1, 2, 3 });
			Assert.Throws<AssertionException>(() => Assert.IsSubsetOf(new int[] { 1, 1 }, new int[] { 1, 2, 3 }));
			Assert.Throws<AssertionException>(() => Assert.IsSubsetOf(new int[] { 0 }, new int[] { 1, 2, 3 }));

			Assert.IsNotSubsetOf(new int[] { 0 }, new int[] { 1, 2, 3 });
			Assert.IsNotSubsetOf(new int[] { 1, 1 }, new int[] { 1, 2, 3 });
			Assert.Throws<AssertionException>(() => Assert.IsNotSubsetOf(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }));
			Assert.Throws<AssertionException>(() => Assert.IsNotSubsetOf(new int[] { 1 }, new int[] { 1, 2, 3 }));
		}

		[Test]
		public void AreEquivalent()
		{
			Assert.AreEquivalent(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			Assert.AreEquivalent(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 });
			Assert.AreEquivalent(new int[] { }, new int[] { });
			Assert.Throws<AssertionException>(() => Assert.AreEquivalent(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 }));
			Assert.Throws<AssertionException>(() => Assert.AreEquivalent(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 }));
			Assert.Throws<AssertionException>(() => Assert.AreEquivalent(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1, 4 }));
			Assert.Throws<AssertionException>(() => Assert.AreEquivalent(new int[] { 1, 2, 3, 4 }, new int[] { 3, 2, 1 }));
			Assert.Throws<AssertionException>(() => Assert.AreEquivalent(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 }));
		}


		class A { }
		class B : A { }
	}

}
