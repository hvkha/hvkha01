using AnPhuocShop.Models;
using AnPhuocShop.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Web.Pages
{
    public class AnPhuocDetailsBase: ComponentBase
    {
        public AnPhuoc AnPhuoc { get; set; } = new AnPhuoc();

        [Inject]
        IAnPhuocService AnPhuocService { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            AnPhuoc = await AnPhuocService.GetAnPhuoc(int.Parse(Id));
        }

    }
}
