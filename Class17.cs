using System;

namespace EscapeRoom
{
	public class Class17
	{
		private string geheimcode;
		private int verfuegbareHinweise;

		public Class17()
		{
			geheimcode = "1234";
			verfuegbareHinweise = 3;
		}

		public Class17(string geheimcode, int verfuegbareHinweise)
		{
			this.geheimcode = geheimcode;
			this.verfuegbareHinweise = verfuegbareHinweise;
		}

		public bool PruefeCode(string eingegebenerCode)
		{
			return eingegebenerCode == geheimcode;
		}

		public string VerwendeHinweis()
		{
			if (verfuegbareHinweise > 0)
			{
				verfuegbareHinweise--;
				return "Hinweis: Suche den Code neben der Uhr im Raum.";
			}

			return "Du hast keine Hinweise mehr.";
		}
	}
}
