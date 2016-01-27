<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mm_strip = New System.Windows.Forms.MenuStrip()
        Me.s_strip = New System.Windows.Forms.StatusStrip()
        Me.SuspendLayout()
        '
        'mm_strip
        '
        Me.mm_strip.Location = New System.Drawing.Point(0, 0)
        Me.mm_strip.Name = "mm_strip"
        Me.mm_strip.Size = New System.Drawing.Size(1029, 24)
        Me.mm_strip.TabIndex = 1
        Me.mm_strip.Text = "MenuStrip1"
        '
        's_strip
        '
        Me.s_strip.Location = New System.Drawing.Point(0, 572)
        Me.s_strip.Name = "s_strip"
        Me.s_strip.Size = New System.Drawing.Size(1029, 22)
        Me.s_strip.TabIndex = 2
        Me.s_strip.Text = "StatusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1029, 594)
        Me.Controls.Add(Me.s_strip)
        Me.Controls.Add(Me.mm_strip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mm_strip
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mm_strip As MenuStrip
    Friend WithEvents s_strip As StatusStrip
End Class
