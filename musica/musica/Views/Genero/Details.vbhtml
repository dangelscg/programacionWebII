@ModelType musica.genero

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>genero</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.id_genero)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.id_genero)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.tipo)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.tipo)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.tema)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.tema)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
