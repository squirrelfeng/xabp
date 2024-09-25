﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using AutoMapper;

using Volo.Abp.AutoMapper;
using Volo.Abp.UI.Navigation;

using X.Abp.AspNetCore.Mvc.UI.Theme.Lepton.Themes.Lepton.Components.MainMenu;

namespace X.Abp.AspNetCore.Mvc.UI.Theme.Lepton.ObjectMapping
{
    public class LeptonThemeAutoMapperProfile : Profile
    {
        public LeptonThemeAutoMapperProfile()
        {
            CreateMap<ApplicationMenu, MenuViewModel>()
                .ForMember(vm => vm.Menu, cnf => cnf.MapFrom(x => x));

            CreateMap<ApplicationMenuItem, MenuItemViewModel>()
                .ForMember(vm => vm.MenuItem, cnf => cnf.MapFrom(x => x))
                .Ignore(vm => vm.IsActive);
        }
    }
}