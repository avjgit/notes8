Source: http://www.microsoftvirtualacademy.com/training-courses/introduction-to-asp-net-mvc

01 Basics of MVC and the Moving Parts

    Sites ************************** Services **************
    WebForms *** WebPages *** SinglePageApps *** SignalR ***
                              MVC *** WebApi *** 
    ASP.NET ************************************************


    Request comes to a controller - or, concrete - METHOD ON A CLASS. Not a file.

    Controller retrieves a model and "does stuff" - 
    in end, creates a view and provides data for it.

    View is send as response.

    Model has data.
    Controller has logic and does not know about HTML.
    View has HTML and has no logic.

    WebForms downsides: 
        * page lifecycle (master, page, control)
        * viewstate

    MVC
        structure from the start
        testability (safety for future code changes)


    Name of pages in Views matches method names in Controller.

    Dynamic resizing via Bootstrap built-in.

02 Creating and Configuring Models

    Model is, again, a class.

    Attributes - DataType, Display, Validation (Required, StringLength, RegExs)

    DataTypes: CreditCard, Currency, Email, Password, Url

    Attribute on Model is propageted and enforced everywhere.

    Alt F12 - cool in-window Show definition

    Alt V C - view source

    Validation: ModelState.IsValid

03 The Power of Visual Studio

    Scaffolding - generates controllers and views based on models

    The difference with WebForm - generation happens at design, not compile time

04 Customizing Controllers
05 Customizing Views
06 Introduction to Bootstrap
07 ​Introduction to Authentication
08 Resources and Next Steps