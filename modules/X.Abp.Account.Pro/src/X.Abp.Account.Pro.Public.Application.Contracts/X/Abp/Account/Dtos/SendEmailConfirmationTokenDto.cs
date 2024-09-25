﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;
using System.ComponentModel.DataAnnotations;

namespace X.Abp.Account.Dtos;

public class SendEmailConfirmationTokenDto
{
    [Required]
    public string AppName { get; set; }

    [Required]
    public Guid UserId { get; set; }

    public string ReturnUrl { get; set; }

    public string ReturnUrlHash { get; set; }
}