Imports System.Data.Entity

Public Class CancionController
    Inherits System.Web.Mvc.Controller

    Private db As New musicaEntities

    '
    ' GET: /Cancion/

    Function Index() As ActionResult
        Return View(db.cancion.ToList())
    End Function

    '
    ' GET: /Cancion/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim cancion As cancion = db.cancion.Find(id)
        If IsNothing(cancion) Then
            Return HttpNotFound()
        End If
        Return View(cancion)
    End Function

    '
    ' GET: /Cancion/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Cancion/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal cancion As cancion) As ActionResult
        If ModelState.IsValid Then
            db.cancion.Add(cancion)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(cancion)
    End Function

    '
    ' GET: /Cancion/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim cancion As cancion = db.cancion.Find(id)
        If IsNothing(cancion) Then
            Return HttpNotFound()
        End If
        Return View(cancion)
    End Function

    '
    ' POST: /Cancion/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal cancion As cancion) As ActionResult
        If ModelState.IsValid Then
            db.Entry(cancion).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(cancion)
    End Function

    '
    ' GET: /Cancion/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim cancion As cancion = db.cancion.Find(id)
        If IsNothing(cancion) Then
            Return HttpNotFound()
        End If
        Return View(cancion)
    End Function

    '
    ' POST: /Cancion/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim cancion As cancion = db.cancion.Find(id)
        db.cancion.Remove(cancion)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class