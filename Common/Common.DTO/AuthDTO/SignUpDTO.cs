﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

namespace Common.DTO
{
    public class SignUpDTO : LoginDTO
    {
        public string FullName { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
    }
}