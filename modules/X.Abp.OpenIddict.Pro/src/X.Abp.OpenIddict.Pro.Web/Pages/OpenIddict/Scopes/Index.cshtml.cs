﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace X.Abp.OpenIddict.Web.Pages.OpenIddict.Scopes;

public class IndexModel : OpenIddictProPageModel
{
    public virtual Task<IActionResult> OnGetAsync()
    {
        return Task.FromResult((IActionResult)Page());
    }

    public virtual Task<IActionResult> OnPostAsync()
    {
        return Task.FromResult((IActionResult)Page());
    }
}
