Imports System.Data.Entity

Public Class RecienteController
    Inherits System.Web.Mvc.Controller

    Private db As New musicaEntities

    '
    ' GET: /Reciente/

    Function Index() As ActionResult
        Return View(db.recientes.ToList())
    End Function

    '
    ' GET: /Reciente/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim recientes As recientes = db.recientes.Find(id)
        If IsNothing(recientes) Then
            Return HttpNotFound()
        End If
        Return View(recientes)
    End Function

    '
    ' GET: /Reciente/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Reciente/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal recientes As recientes) As ActionResult
        If ModelState.IsValid Then
            db.recientes.Add(recientes)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(recientes)
    End Function

    '
    ' GET: /Reciente/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim recientes As recientes = db.recientes.Find(id)
        If IsNothing(recientes) Then
            Return HttpNotFound()
        End If
        Return View(recientes)
    End Function

    '
    ' POST: /Reciente/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal recientes As recientes) As ActionResult
        If ModelState.IsValid Then
            db.Entry(recientes).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(recientes)
    End Function

    '
    ' GET: /Reciente/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim recientes As recientes = db.recientes.Find(id)
        If IsNothing(recientes) Then
            Return HttpNotFound()
        End If
        Return View(recientes)
    End Function

    '
    ' POST: /Reciente/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim recientes As recientes = db.recientes.Find(id)
        db.recientes.Remove(recientes)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class