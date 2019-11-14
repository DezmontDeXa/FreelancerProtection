# FreelancerProtection
Простая утилита для ограничения времени использования софта

			FreelancerProtectionLib.FreelancerProtection.ActivationDate = new DateTime(2019, 11, 14);
			FreelancerProtectionLib.FreelancerProtection.Duration = new TimeSpan(7, 0, 0, 0);
			if (!FreelancerProtectionLib.FreelancerProtection.CheckActivation())
			{
				MessageBox.Show("End of DEMO.");
				Application.Current.Shutdown();
			}
