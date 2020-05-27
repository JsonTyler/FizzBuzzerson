#pragma checksum "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a854dc5f516de0b1cdb8db9d571f45b07e0da37"
// <auto-generated/>
#pragma warning disable 1591
namespace FizzBuzzerson.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using FizzBuzzerson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\_Imports.razor"
using FizzBuzzerson.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FizzBuzzerson")]
    public partial class Fizzbuzzerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Fizzbuzzerson</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<p>
    Project Background: Below is a project inspired by Coder Foundry's youtube <a href=""https://www.youtube.com/watch?v=zOY5a-J0t6E"">video</a>.
    In the world of software engineering ""fizz buzz"" is known to most as an interview challenge problem given to test if a
    programmer has any basic software skills. All that is required is the knowledge of basic concepts like variables, conditionals,
    and the modulus operator. I was inspired by Coder Foundry's video as well as my preparation for my first interview experience
    back in 2017 with Lockheed Martin where I first became aware of what Fizz Buzz even was.
</p>
");
            __builder.AddMarkupContent(2, @"<ul>
    Instructions:
    <li>- Enter two numbers (3 and 5 are there by default)</li>
    <li>- Click ""FizzBuzz It""</li>
    <li>- Look at your results</li>
    <li>- Click ""Smash It""</li>
    <li>- Notice that anything that had ""FizzBuzz"" is now not there</li>
</ul>
");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<div class=\"col-3\">Fizz Value:</div>\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "class", "form-control-plaintext");
            __builder.AddAttribute(11, "type", "number");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                                 FizzValue

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FizzValue = __value, FizzValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, "<div class=\"col-3\">Buzz Value:</div>\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "class", "form-control-plaintext");
            __builder.AddAttribute(24, "type", "number");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                                 BuzzValue

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => BuzzValue = __value, BuzzValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                 FizzBuzzIt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "FizzBuzz It");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn-danger");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                 SmashIt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Smash It");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n");
#nullable restore
#line 34 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
 if (buzzItems.Count() > 0)  
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row pt-5");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "table-responsive");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "class", "table table-striped table-bordered table-hover table-sm");
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.AddMarkupContent(57, "<thead>\r\n                    <tr><th class=\"bg-dark text-white\" colspan=\"10\">FizzBuzz Results</th></tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(58, "tbody");
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 43 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                     for (var i = 0; i < 100; i += 10)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                        ");
            __builder.OpenElement(61, "tr");
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "class", 
#nullable restore
#line 46 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, 
#nullable restore
#line 46 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                 buzzItems[i].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "td");
            __builder.AddAttribute(68, "class", 
#nullable restore
#line 47 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+1].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, 
#nullable restore
#line 47 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 1].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "class", 
#nullable restore
#line 48 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+2].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, 
#nullable restore
#line 48 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 2].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "class", 
#nullable restore
#line 49 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+3].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, 
#nullable restore
#line 49 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 3].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "class", 
#nullable restore
#line 50 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+4].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(81, 
#nullable restore
#line 50 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 4].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "class", 
#nullable restore
#line 51 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+5].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(85, 
#nullable restore
#line 51 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 5].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "class", 
#nullable restore
#line 52 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+6].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(89, 
#nullable restore
#line 52 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 6].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "class", 
#nullable restore
#line 53 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+7].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(93, 
#nullable restore
#line 53 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 7].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                            ");
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "class", 
#nullable restore
#line 54 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+8].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(97, 
#nullable restore
#line 54 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 8].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.OpenElement(99, "td");
            __builder.AddAttribute(100, "class", 
#nullable restore
#line 55 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                        buzzItems[i+9].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(101, 
#nullable restore
#line 55 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                                                                   buzzItems[i + 9].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 57 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 62 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\15094\source\repos\FizzBuzzerson\FizzBuzzerson\Pages\Fizzbuzzerson.razor"
       
    List<BuzzItem> buzzItems = new List<BuzzItem>();

    private int FizzValue = 3;
    private int BuzzValue = 5;
    private int Milliseconds = 2000;

    bool Fizz = false;
    bool Buzz = false;

    void FizzBuzzIt()
    {
        if (buzzItems.Count > 0)
        {
            buzzItems.Clear();
        }

        for (var i = 1; i <= 100; i++)
        {
            Fizz = (i % FizzValue == 0);
            Buzz = (i % BuzzValue == 0);

            if (Fizz && Buzz)
            {
                buzzItems.Add(new BuzzItem { Value = "FizzBuzz", ClassName = "fizzBuzz"});
            }
            else if (Fizz)
            {
                buzzItems.Add(new BuzzItem { Value = "Fizz", ClassName = "fizz" });
            }
            else if (Buzz)
            {
                buzzItems.Add(new BuzzItem { Value = "Buzz", ClassName = "buzz" });
            }
            else
            {
                buzzItems.Add(new BuzzItem { Value = i.ToString(), ClassName = "noBuzz" });
            }

        }



    }

    void SmashIt()
    {
        for (var i = 1; i <= 100; i++)
        {
            Fizz = (i % FizzValue == 0);
            Buzz = (i % BuzzValue == 0);

            if (Fizz && Buzz)
            {
                buzzItems[i - 1].Value = "HERE";
                buzzItems[i - 1].ClassName = "invisible";
            }
        }
    }


    class BuzzItem
    {
        public string Value { get; set; }
        public string ClassName { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
