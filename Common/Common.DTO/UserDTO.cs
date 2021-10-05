/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

namespace Common.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public int? States { get; set; }
        public long? Licens_id { get; set; }
        //public string Role { get; set; }
        public RoleDTO role { get; set; }

        public AddressDTO Address { get; set; }

        public SettingsDTO Settings { get; set; }

        //public UserRoles userRoles { get; set; }
       

    }

    public class UserRoles
    {
        public class Role
        {
            public int Id;
            public string Name;
        }
        public int RoleId;
        //public string User;
        public int UserId;
    }
}
