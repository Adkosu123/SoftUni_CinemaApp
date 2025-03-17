﻿namespace CinemaApp.Common.OutputMessages
{
   public static class ErrorMessages
    {
        public const string EntityImportError = "There were errors while importing {0} entity! The following errors were observed:";
        
        public const string RefferencedEntityMissing = "One or more of the referenced entities by the DTO is not present in the DB!";

        public const string EntityInstanceAlreadyExist = "One or more of the imported entities were skipped due to existing record with the same data!";
	}
}
