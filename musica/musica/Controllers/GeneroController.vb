Imports System.Data.Entity

Public Class GeneroController
    Inherits System.Web.Mvc.Controller

    Private db As New musicaEntities

    '
    ' GET: /Genero/

    Function Index() As ActionResult
        Return View(db.genero.ToList())
    End Function

    '
    ' GET: /Genero/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim genero As genero = db.genero.Find(id)
        If IsNothing(genero) Then
            Return HttpNotFound()
        End If
        Return View(genero)
    End Function

    '
    ' GET: /Genero/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Genero/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal genero As genero) As ActionResult
        If ModelState.IsValid Then
            db.genero.Add(genero)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(genero)
    End Function

    '
    ' GET: /Genero/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim genero As genero = db.genero.Find(id)
        If IsNothing(genero) Then
            Return HttpNotFound()
        End If
        Return View(genero)
    End Function

    '
    ' POST: /Genero/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal genero As genero) As ActionResult
        If ModelState.IsValid Then
            db.Entry(genero).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(genero)
    End Function

    '
    ' GET: /Genero/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim genero As genero = db.genero.Find(id)
        If IsNothing(genero) Then
            Return HttpNotFound()
        End If
        Return View(genero)
    End Function

    '
    ' POST: /Genero/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim genero As genero = db.genero.Find(id)
        db.genero.Remove(genero)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class