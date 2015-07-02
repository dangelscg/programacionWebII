@ModelType musica.artista

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
        <legend>artista</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.id_artista)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.id_artista)
            @Html.ValidationMessageFor(Function(model) model.id_artista)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.artista1)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.artista1)
            @Html.ValidationMessageFor(Function(model) model.artista1)
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
