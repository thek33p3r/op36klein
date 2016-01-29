Public Class DBZugriff


    Public Class DBZugriff
        Private conn As New sqlConnection
        Private da As OleDbDataAdapter
        Private dt As DataTable
        Private _VerbOk As String
        Private _Fehler As String

        ''' Connection String 
        Public Sub New(ByVal DBName As String)
            If UCase(IO.Path.GetExtension(DBName)) = ".mdb" Then
                conn.ConnectionString = "provider=Microsoft.jet.oledb.4.0;" &
                "Data Source=" & DBName
            Else
                conn.ConnectionString = "provider=Microsoft.ACE.oledb.12.0;" &
                "Data Source=" & DBName
            End If
            DBÖffnen()
        End Sub
        ''' DB Verbindung schließen
        Public Sub DBConnClose()
            If conn.State = ConnectionState.Open Then conn.Close()
            _VerbOk = False
        End Sub

        ''' DB Verbindung öffnen
        Public Sub DBConnOpen()

            DBÖffnen()

        End Sub

        ''' Datenbank öffnen !!!!!! bitte beachten das die Verbindung wenn nicht durch DBConClosed geschlossen wird geöffnet bleibt

        Private Sub DBÖffnen()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                _VerbOk = True
                _Fehler = ""
            Catch ex As Exception
                _VerbOk = False
                _Fehler = "DB nicht geöffnet" & vbCrLf & ex.Message
            End Try
        End Sub


        ''' Fehler kann abgerufen werden
        Public ReadOnly Property Fehler() As String
            Get
                Return _Fehler
            End Get
        End Property


        ''' Boolean Wert für Verbindungszustand
        Public ReadOnly Property VerbindungOK() As Boolean
            Get
                Return _VerbOk
            End Get
        End Property

        ''' Datatable füllen
        Public Function FillTable(ByVal s As String) As DataTable

            Try
                _Fehler = ""
                da = New sqlDataAdapter(s, conn)
                dt = New DataTable
                da.Fill(dt)
                Return dt
            Catch ex As Exception
                _Fehler = ex.Message
                Return Nothing
            End Try
        End Function


        ''' Datatable in Datenbank schreiben und speichern
        Public Sub SaveTable(ByVal dt As DataTable)

            Dim cb As New sqlCommandBuilder(da)
            Try
                _Fehler = ""
                da.Update(dt)

            Catch ex As Exception
                _Fehler = ex.Message

            End Try

        End Sub


        ''' gibt einen Zahlenwert als Double zurück
        Public Function EinzelWertDouble(ByVal s As String) As Double
            Dim cmd As New sqlCommand(s, conn)
            Try
                _Fehler = ""
                Return cmd.ExecuteScalar

            Catch ex As Exception
                _Fehler = ex.Message
                Return 0
            End Try
        End Function

        ''' Zur Bearbeitung ohne Datatable von entweder einzelnen Werten oder Tabellen
        Public Function SaveExecut(ByVal s As String) As Long
            Dim cmd As New sqlCommand(s, conn)
            Try
                _Fehler = ""
                Return cmd.ExecuteNonQuery
            Catch ex As Exception
                _Fehler = ex.Message
                Return 0
            End Try

        End Function
        ''' Lesen von Datatable 
        Public Function TableReader(ByVal s As String) As sqlDataReader
            Dim cmd As New sqlCommand(s, conn)
            Try
                _Fehler = ""
                Return cmd.ExecuteReader
            Catch ex As Exception
                _Fehler = ex.Message
                Return Nothing
            End Try


        End Function




    End Class

End Class
