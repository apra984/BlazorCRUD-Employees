// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employees.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employees.razor"
       
    private List<EmployeeModel> employees;

    protected override void OnInitialized()
    {
        employees = EmployeeService.GetEmployees();
    }

    private void OnDelete(Guid employeeId)
    {
        EmployeeService.DeleteEmployee(employeeId);
    }

    private void OnEdit(Guid employeeId)
    {
        NavigationManager.NavigateTo($"employee/{employeeId}");
    }

    private void OnAdd()
    {
        NavigationManager.NavigateTo("employee/0");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591
