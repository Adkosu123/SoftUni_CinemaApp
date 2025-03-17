namespace CinemaApp.Common.Constants
  
{
    public static class EntityConstants
    {
		// Decimal(18,2) is suitable SQL Server Type for money
            public const string MoneyType = "decimal(18,2)";

        public static class Cinema 
        {
			public const int NameMinLength = 3;
			// It's good to omit having magic string and numbers in the code.
			// You can also cite the software specification based on which u decided to take this value
			// Example - SWS_Cinema_EntityValidation_700152878: Cinema name should be able to store text with length up to 256 symbols.
			public const int NameMaxLength = 256;
            public const int LocationMaxLength = 256;
        }

        public static class CinemaMovie
        {
			public const int AvailableTicketsMinValue = 0;
			public const int AvailableTicketsMaxValue = 100_000;
			public const int ShowtimesMaxLength = 5;
            public const string ShowtimesDefaultValue = "00000";
		}

		public static class Movie
		{
			public const int TitleMinLength = 1;
			public const int TitleMaxLength = 150;
			public const int GenreMaxLength = 30;
			public const int DirectorMaxLength = 150;
			public const int DescriptionMaxLength = 1024;
			public const int ImageUrlMaxLength = 2048;
		}
	}
}
