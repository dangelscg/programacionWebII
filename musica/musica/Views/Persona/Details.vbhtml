@ModelType musica.persona

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>persona</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.id_perosna)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.id_perosna)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.nombre)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.nombre)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.usuario)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.usuario)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
