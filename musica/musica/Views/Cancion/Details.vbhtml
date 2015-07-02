@ModelType musica.cancion

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>cancion</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.id_cancion)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.id_cancion)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.nombre)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.nombre)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.interprete)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.interprete)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.album)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.album)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.duracion)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.duracion)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.tamaño)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.tamaño)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
