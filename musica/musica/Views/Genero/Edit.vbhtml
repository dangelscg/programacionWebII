@ModelType musica.genero

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>genero</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.id_genero)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.id_genero)
            @Html.ValidationMessageFor(Function(model) model.id_genero)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.tipo)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.tipo)
            @Html.ValidationMessageFor(Function(model) model.tipo)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.tema)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.tema)
            @Html.ValidationMessageFor(Function(model) model.tema)
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
