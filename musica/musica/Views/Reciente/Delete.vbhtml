@ModelType musica.recientes

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
