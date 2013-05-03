using NUnit.Framework;
using System;
using Newtonsoft.Json;
using MonoDevelop.FirefoxOS;

namespace MonoDevelop.FirefoxOS.Tests
{

	/// <summary>
	/// App manifest test from https://developer.mozilla.org/en-US/docs/Apps/Manifest
	/// </summary>
	[TestFixture()]
	public class AppManifestTest
	{
		[Test()]
		public void UnManifiestoEsUnArchivoJSON ()
		{
			var appManifest = new AppManifest();

			Assert.IsTrue (false);
		}

 		
		[Test()]
		public void EsUnArchivoAppManifestValido()
		{
			var appManifest = new AppManifest();
			// string appManifestJson =
			
			// appManifest.
		}

		/// <summary>
		///  The url is https://marketplace.firefox.com/developers/validator
		/// </summary>
		[Test()]
		public void UnManifiestoParaSerValidadoNecesitaAccederAInternetYComprobarloEnUnaDeterminadaUrl()
		{
			Assert.IsFalse(true);
		}

		[Test()]
		public void TieneQueCumplirConElDTDdelWebAppManifest()
		{
			Assert.IsTrue (false);
		}
	}
}

