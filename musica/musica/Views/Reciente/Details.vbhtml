@ModelType musica.recientes

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>recientes</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.id_recientes)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.id_recientes)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.reciente)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.reciente)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
