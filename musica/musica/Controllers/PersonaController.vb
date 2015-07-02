Imports System.Data.Entity

Public Class PersonaController
    Inherits System.Web.Mvc.Controller

    Private db As New musicaEntities

    '
    ' GET: /Persona/

    Function Index() As ActionResult
        Return View(db.persona.ToList())
    End Function

    '
    ' GET: /Persona/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim persona As persona = db.persona.Find(id)
        If IsNothing(persona) Then
            Return HttpNotFound()
        End If
        Return View(persona)
    End Function

    '
    ' GET: /Persona/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Persona/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal persona As persona) As ActionResult
        If ModelState.IsValid Then
            db.persona.Add(persona)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(persona)
    End Function

    '
    ' GET: /Persona/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim persona As persona = db.persona.Find(id)
        If IsNothing(persona) Then
            Return HttpNotFound()
        End If
        Return View(persona)
    End Function

    '
    ' POST: /Persona/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal persona As persona) As ActionResult
        If ModelState.IsValid Then
            db.Entry(persona).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(persona)
    End Function

    '
    ' GET: /Persona/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim persona As persona = db.persona.Find(id)
        If IsNothing(persona) Then
            Return HttpNotFound()
        End If
        Return View(persona)
    End Function

    '
    ' POST: /Persona/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim persona As persona = db.persona.Find(id)
        db.persona.Remove(persona)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class