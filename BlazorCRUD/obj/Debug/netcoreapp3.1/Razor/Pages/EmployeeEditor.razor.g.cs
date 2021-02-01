#pragma checksum "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\EmployeeEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a281cc009157bee63fa47fc8ad41ede125938e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\EmployeeEditor.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee/{Id}")]
    public partial class EmployeeEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee Editor</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\EmployeeEditor.razor"
                 employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "<label>Id</label>\r\n        ");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "id", "id");
                __builder2.AddAttribute(9, "name", "id");
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "readonly", true);
                __builder2.AddAttribute(12, "value", 
#nullable restore
#line 10 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\EmployeeEditor.razor"
                                                                       employee.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<label>Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "name");
                __builder2.AddAttribute(17, "name", "name");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\EmployeeEditor.razor"
                                                                           employee.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employee.Name = __value, employee.Name))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employee.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.AddMarkupContent(23, "<label>Age</label>\r\n        ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "id", "age");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "name", "age");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\EmployeeEditor.razor"
                                                                employee.Age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Age = __value, employee.Age));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "button");
                __builder2.AddAttribute(32, "class", "btn btn-outline-primary float-right");
                __builder2.AddAttribute(33, "type", "submit");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\EmployeeEditor.razor"
                                                                                 OnSubmitForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(35, "Submit");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Akash Prakash\source\repos\BlazorCRUD\BlazorCRUD\Pages\EmployeeEditor.razor"
       
    [Parameter]
    public String Id { get; set; }

    private EmployeeModel employee { get; set; }

    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(Id) & Id == "0")
        {
            employee = new EmployeeModel();
        }else
        {
            employee = EmployeeService.GetEmployee(Guid.Parse(Id));
        }
    }

    private void OnSubmitForm()
    {
        if (employee.Id == Guid.Empty)
        {
            EmployeeService.AddEmployee(employee);
        }else
        {
            EmployeeService.UpdateEmployee(employee);
        }

        NavigationManager.NavigateTo("employees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
