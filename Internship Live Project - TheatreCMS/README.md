# Internship Live Project - TheatreCMS
## Introduction
During my time at The Tech Academy, I worked with a team on two occasions, both with a different project. The second project entailed using MVC framework to  develop a website for a (fictional) local theater, called TheaterCMS. It was constructed using ASP.NET Framework 4.7.2, with packages including Bootstrap, Antlr, and Owin. During the two week sprint I worked as a Full Stack developer, working on both the front and back end of the website to restrict administrator privileges to users in that role alone, as well as fixing the site's ability to let users rent the venue for their production.

Since much of the site had been built already, I had to make sure that any alteration I made did not break something else, as well as learn on the job how to fix the issues I was tasked with resolving.

Below are code snippets from the two major issues that I resolved during the sprint.

## Restricting Edit Link to Admins Only
I added code that hid the edit button for the site's pages unless the user was an administrator.

details.cshtml
```
@*Shows/hides edit link depending on user role.*@
@if (ViewContext.HttpContext.User.IsInRole("Admin"))
{
    <p>
        @Html.ActionLink("Edit", "Edit", new { id = Model.ProductionId }) |
        @Html.ActionLink("Current Productions", "Current") |
        @Html.ActionLink("Back to List", "Index")
    </p>
}
else
{
<p>
    @Html.ActionLink("Current Productions", "Current") |
    @Html.ActionLink("Back to List", "Index")
</p>
}
```

## Adding RentalRequest Properties
I added Phone and Email properties to the RentalRequest class as well as validation to ensure they were entered correctly.

RentalRequest.cs
```
[DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Display(Name = "Phone Number")]
        public object Phone { get; set; }       // company phone number

        [DataType(DataType.EmailAddress)]
        [DisplayFormat(DataFormatString = "{0: }", ApplyFormatInEditMode = true)]
        [Display(Name = "Email Address")]
        public object EMail { get; set; }       // company email address
```

Create.cshtml
```
 <div class="form-group">
                    @Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-4 inputLabel" })
                    <div class="col-md-10 formBox">
                        @Html.DisplayFor(model => model.Phone)
                        @Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } })
                        @Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-white" })
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(model => model.EMail, htmlAttributes: new { @class = "control-label col-md-4 inputLabel" })
                    <div class="col-md-10 formBox">
                        @Html.EditorFor(model => model.EMail, new { htmlAttributes = new { @class = "form-control" } })
                        @Html.ValidationMessageFor(model => model.EMail, "", new { @class = "text-white" })
                    </div>
                </div>
```

Delete.cshtml
```
<dt>
            @Html.DisplayNameFor(model => model.Phone)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Phone)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.EMail)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.EMail)
        </dd>
```

Details.cshtml
```
 <dt>
            @Html.DisplayNameFor(model => model.Phone)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Phone)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.EMail)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.EMail)

        <dt>
```
Edit.cshtml
```
                <div class="form-group">
                    @Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-4 inputLabel" })
                    <div class="col-md-10 formBox">
                        @Html.DisplayFor(model => model.Phone)
                        @Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } })
                        @Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-white" })
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(model => model.EMail, htmlAttributes: new { @class = "control-label col-md-4 inputLabel" })
                    <div class="col-md-10 formBox">
                        @Html.EditorFor(model => model.EMail, new { htmlAttributes = new { @class = "form-control" } })
                        @Html.ValidationMessageFor(model => model.EMail, "", new { @class = "text-white" })
                    </div>
                </div>
```
