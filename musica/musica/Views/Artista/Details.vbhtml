@ModelType musica.artista

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>artista</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.id_artista)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.id_artista)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.artista1)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.artista1)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
