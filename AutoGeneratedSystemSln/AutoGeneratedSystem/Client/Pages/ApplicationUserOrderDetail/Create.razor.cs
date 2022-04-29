using AutoGeneratedSystem.Models.ApplicationUserOrderDetail;
using Microsoft.AspNetCore.Components;
using Blazored.Toast.Services;
using AutoGeneratedSystem.ClientServices;
using AutoGeneratedSystem.Common;
namespace AutoGeneratedSystem.Client.Pages.ApplicationUserOrderDetail
{
[Route(Constants.PageRoutes.ApplicationUserOrderDetailRoutes.Create)]
public partial class Create
{
[Inject]
ApplicationUserOrderDetailClientService ApplicationUserOrderDetailClientService { get; set; }
[Inject]
private IToastService ToastService { get;set; }
[Inject] private NavigationManager NavigationManager { get; set; }
private CreateApplicationUserOrderDetailModel Model {get;set;} = new();
private bool IsLoading {get;set;} = false;
private long ApplicationUserOrderId { get; set; }
private AutoGeneratedSystem.Models.ApplicationUserOrder.ApplicationUserOrderModel[] ApplicationUserOrderModelItems{ get; set; }
[Inject] private ApplicationUserOrderClientService ApplicationUserOrderClientService { get; set; }
private long ProductId { get; set; }
private AutoGeneratedSystem.Models.Product.ProductModel[] ProductModelItems{ get; set; }
[Inject] private ProductClientService ProductClientService { get; set; }
protected override async Task OnInitializedAsync()
{
try
{
IsLoading = true;
this.ApplicationUserOrderModelItems = await ApplicationUserOrderClientService.GetAllApplicationUserOrderAsync();
this.ProductModelItems = await ProductClientService.GetAllProductAsync();
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
var result = await this.ApplicationUserOrderDetailClientService.CreateApplicationUserOrderDetailAsync(this.Model);
this.NavigationManager.NavigateTo("/ApplicationUserOrderDetail/List");
ToastService.ShowSuccess("New ApplicationUserOrderDetail has been created");
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