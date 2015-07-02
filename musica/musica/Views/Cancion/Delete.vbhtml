@ModelType musica.cancion

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
