Imports System.Data.Entity

Public Class ArtistaController
    Inherits System.Web.Mvc.Controller

    Private db As New musicaEntities

    '
    ' GET: /Artista/

    Function Index() As ActionResult
        Return View(db.artista.ToList())
    End Function

    '
    ' GET: /Artista/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim artista As artista = db.artista.Find(id)
        If IsNothing(artista) Then
            Return HttpNotFound()
        End If
        Return View(artista)
    End Function

    '
    ' GET: /Artista/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Artista/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal artista As artista) As ActionResult
        If ModelState.IsValid Then
            db.artista.Add(artista)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(artista)
    End Function

    '
    ' GET: /Artista/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim artista As artista = db.artista.Find(id)
        If IsNothing(artista) Then
            Return HttpNotFound()
        End If
        Return View(artista)
    End Function

    '
    ' POST: /Artista/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal artista As artista) As ActionResult
        If ModelState.IsValid Then
            db.Entry(artista).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(artista)
    End Function

    '
    ' GET: /Artista/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim artista As artista = db.artista.Find(id)
        If IsNothing(artista) Then
            Return HttpNotFound()
        End If
        Return View(artista)
    End Function

    '
    ' POST: /Artista/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim artista As artista = db.artista.Find(id)
        db.artista.Remove(artista)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class