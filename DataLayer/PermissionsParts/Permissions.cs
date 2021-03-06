﻿// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System;
using System.ComponentModel.DataAnnotations;

namespace PermissionParts
{
    public enum Permissions : short //I set this to short because the PermissionsPacker stores them as Unicode chars 
    {
        NotSet = 0, //error condition

        //See the Permissions.cs in the PermissionAccessControl2 repo for an example of how to define permissions 
        //see https://www.thereformedprogrammer.net/a-better-way-to-handle-authorization-in-asp-net-core/

        [Display(GroupName = "Demo", Name = "Demo", Description = "Demo of using a Permission")]
        DemoPermission = 10,

        //This is a special Permission used by the SuperAdmin user. 
        //A user has this permission can access any other permission.
        [Display(GroupName = "SuperAdmin", Name = "AccessAll", Description = "This allows the user to access every feature")]
        AccessAll = Int16.MaxValue, 
    }
}