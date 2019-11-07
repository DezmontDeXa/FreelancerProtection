using Microsoft.VisualStudio.TestTools.UnitTesting;
using FreelancerProtectionLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerProtectionLib.Tests
{
	[TestClass()]
	public class FreelancerProtectionTests
	{
		[TestMethod()]
		public void CheckActivationTest_TimeExist()
		{
			FreelancerProtection.ActivationDate = DateTime.Now;
			FreelancerProtection.Duration = new TimeSpan(0, 10, 0);

			bool result = FreelancerProtection.CheckActivation();

			if (result == false)
				Assert.Fail("Ожидалось что время активации не истекло.");
		}

		[TestMethod()]
		public void CheckActivationTest_TimeNotExist()
		{
			FreelancerProtection.ActivationDate = DateTime.Now - new TimeSpan(0, 20, 0);
			FreelancerProtection.Duration = new TimeSpan(0, 10, 0);

			bool result = FreelancerProtection.CheckActivation();

			if (result == true)
				Assert.Fail("Ожидалось что время активации истекло.");
		}
	}
}