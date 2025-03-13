namespace CinemaApp.Common.Constants
  
{
    public static class EntityConstants
    {
            public const string MoneyType = "money(18, 2)";

        public static class Cinema 
        {
			// It's good to omit having magic string and numbers in the code.
			// You can also cite the software specification based on which u decided to take this value
			// Example - SWS_Cinema_EntityValidation_700152878: Cinema name should be able to store text with length up to 256 symbols.
			public const int NameMaxLength = 256;
            public const int LocationMaxLength = 256;
        }

        public static class CinemaMovie
        {
			public const int ShowtimesMaxLength = 5;
            public const string ShowtimesDefaultValue = "00000";
		}

		public static class Movie
		{
			public const int TitleMaxLength = 150;
			public const int GenreMaxLength = 30;
			public const int DirectorMaxLength = 150;
			public const int DescriptionMaxLength = 1024;
			public const int ImageUrlMaxLength = 2048;
		}
	}
}
