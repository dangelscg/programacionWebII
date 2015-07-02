@ModelType musica.persona

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>persona</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.id_perosna)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.id_perosna)
            @Html.ValidationMessageFor(Function(model) model.id_perosna)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.nombre)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.nombre)
            @Html.ValidationMessageFor(Function(model) model.nombre)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.usuario)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.usuario)
            @Html.ValidationMessageFor(Function(model) model.usuario)
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
