using System;

namespace SchoolAttendanceManagementSystem
{
    class InvalidOperationException : Exception
    {
        public InvalidOperationException(string message) : base(message) { }
    }
}