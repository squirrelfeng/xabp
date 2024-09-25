﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

namespace X.Abp.Forms.Forms;

public class FormSettingsDto
{
    public bool CanEditResponse { get; set; }

    public bool IsCollectingEmail { get; set; }

    public bool HasLimitOneResponsePerUser { get; set; }

    public bool IsAcceptingResponses { get; set; }

    public bool IsQuiz { get; set; }

    public bool RequiresLogin { get; set; }
}