using AutoGeneratedSystem.ClientServices;
using AutoGeneratedSystem.Common;
using AutoGeneratedSystem.Models.ApplicationUserOrderDetail;
using Microsoft.AspNetCore.Components;
using Blazored.Toast.Services;
namespace AutoGeneratedSystem.Client.Pages.ApplicationUserOrderDetail
{
[Route(Constants.PageRoutes.ApplicationUserOrderDetailRoutes.List)]
public partial class List
{
[Inject]
ApplicationUserOrderDetailClientService ApplicationUserOrderDetailClientService { get; set; }
[Inject]
private IToastService ToastService { get;set; }
[Inject] private NavigationManager NavigationManager { get; set; }
private ApplicationUserOrderDetailModel[] AllApplicationUserOrderDetail { get; set; }
private bool IsLoading {get; set;}
protected override async Task OnInitializedAsync()
{
try
{
this.IsLoading = true;
this.AllApplicationUserOrderDetail = await ApplicationUserOrderDetailClientService.GetAllApplicationUserOrderDetailAsync();
}
catch (Exception ex)
{
ToastService.ShowError(ex.Message);
}
finally
{
this.IsLoading=false;
}
}
private async Task DeleteApplicationUserOrderDetailAsync(ApplicationUserOrderDetailModel model)
{
try
{
this.IsLoading = true;
await this.ApplicationUserOrderDetailClientService.DeleteApplicationUserOrderDetailAsync(model);
this.AllApplicationUserOrderDetail = await ApplicationUserOrderDetailClientService.GetAllApplicationUserOrderDetailAsync();
ToastService.ShowSuccess($"ApplicationUserOrderDetail with id {model.ApplicationUserOrderDetailId} has been deleted");
}
catch (Exception ex)
{
ToastService.ShowError(ex.Message);
}
finally
{
this.IsLoading = false;
}
}
}
}