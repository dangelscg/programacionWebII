@ModelType musica.recientes

@Code
    ViewData("Title") = "Create"
End Code
<link href="~/css/style.css" rel="stylesheet" type="text/css" />
<link href="~/css/layout.css" rel="stylesheet" type="text/css" />
<link rel="~/stylesheet" href="css/prettyPhoto.css" type="text/css">
<h2>Create</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>recientes</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.id_recientes)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.id_recientes)
            @Html.ValidationMessageFor(Function(model) model.id_recientes)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.reciente)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.reciente)
            @Html.ValidationMessageFor(Function(model) model.reciente)
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
