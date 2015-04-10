# FontAwesome for ASP.NET

Utilities for using FontAwesome icons in ASP.NET Webforms.

## Usage

#### FontAwesome Icons In Webforms Buttons

You can use FontAwesome icons inside asp.net webforms button controls. Simply databind
to the icon of your choice from the FontAwesome.Icons class' static properties. 
Then either call DataBind() on your button or DataBind() on your parent control or page.

```asp
<asp:Button ID="Button1" runat="server" 
    Text="<%# FontAwesome.Icons.Rocket %>" CssClass="fa" />
```