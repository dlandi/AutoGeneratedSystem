﻿using Microsoft.AspNetCore.Components;
namespace AutoGeneratedSystem.MauiBlazor.Helpers
{
    public static class NavigationHelper
    {
        public static void NavigateToCreatePageForEntity(NavigationManager navigationManager, string entityName)
        {
            navigationManager.NavigateTo($"{entityName}/Create");
        }

        public static void NavigateToListPageForEntity(NavigationManager navigationManager, string entityName)
        {
            navigationManager.NavigateTo($"{entityName}/List");
        }
    }
}
