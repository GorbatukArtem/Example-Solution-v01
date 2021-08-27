using System;
using Database.Models.Security.Authorization;

namespace Database.Models.Logs
{
    public class HistoryError
    {
        public int Id { get; set; }

        public DateTime DateTimeUtc { get; set; }
        public string UserId { get; set; }

        public string DynamicLibraryName { get; set; }
        public string NamespacePath { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string ExceptionMessage { get; set; }

        public virtual User User { get; set; }
    }
}