using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extentions
{
    public static class UserTypeExtensions
    {
        public static string ToDescriptionString(UserType val)
        {
            switch (val)
            {
                case UserType.Patient:
                    return "Patient";
                case UserType.Doctor:
                    return "Doctor";
                case UserType.Admin:
                    return "Admin";
                default:
                    return "Unknown";
            }
        }
    }
}
