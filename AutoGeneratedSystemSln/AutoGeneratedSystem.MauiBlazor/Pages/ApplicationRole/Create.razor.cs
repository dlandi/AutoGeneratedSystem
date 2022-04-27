using AutoGeneratedSystem.Models.ApplicationRole;
using Microsoft.AspNetCore.Components;
using Blazored.Toast.Services;
using AutoGeneratedSystem.ClientServices;
using AutoGeneratedSystem.Common;
namespace AutoGeneratedSystem.MauiBlazor.Pages.ApplicationRole
{
[Route(Constants.PageRoutes.ApplicationRoleRoutes.Create)]
public partial class Create
{
[Inject]
ApplicationRoleClientService ApplicationRoleClientService { get; set; }
[Inject]
private IToastService ToastService { get;set; }
[Inject] private NavigationManager NavigationManager { get; set; }
private CreateApplicationRoleModel Model {get;set;} = new();
private bool IsLoading {get;set;} = false;
protected override async Task OnInitializedAsync()
{
try
{
IsLoading = true;
}
catch (Exception ex)
{
ToastService.ShowError(ex.Message);
}
finally
{
IsLoading = false;
}
}
private async Task OnValidSubmitAsync()
{
try
{
IsLoading = true;
var result = await this.ApplicationRoleClientService.CreateApplicationRoleAsync(this.Model);
this.NavigationManager.NavigateTo("/ApplicationRole/List");
ToastService.ShowSuccess("New ApplicationRole has been created");
}
catch (Exception ex)
{
ToastService.ShowError(ex.Message);
}
finally
{
IsLoading = false;
}
}
}
}