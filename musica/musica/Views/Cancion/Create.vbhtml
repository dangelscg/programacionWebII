@ModelType musica.cancion

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
        <legend>cancion</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.id_cancion)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.id_cancion)
            @Html.ValidationMessageFor(Function(model) model.id_cancion)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.nombre)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.nombre)
            @Html.ValidationMessageFor(Function(model) model.nombre)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.interprete)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.interprete)
            @Html.ValidationMessageFor(Function(model) model.interprete)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.album)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.album)
            @Html.ValidationMessageFor(Function(model) model.album)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.duracion)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.duracion)
            @Html.ValidationMessageFor(Function(model) model.duracion)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.tamaño)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.tamaño)
            @Html.ValidationMessageFor(Function(model) model.tamaño)
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
