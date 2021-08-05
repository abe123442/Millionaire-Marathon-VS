Module AudioModule
    ' An array of all the paths of music files used
    Public ReadOnly MusicFilePaths As String() = {
        "assets\audio\intro.wav",
        "assets\audio\main.wav",
        "assets\audio\outro.wav"
    }

    ' An enumeration of all the game audio states 
    Public Enum AudioState
        Intro
        Main
        Outro
    End Enum

    Public CurrentAudioState As New AudioState

    REM: Sub PlayMusic(Optional Update)
    'Summary:
    '   The PlayMusic subroutine plays the appropriate music for the current form in MainForm's PanelMain
    '
    'Parameters:
    '   [Boolean] "Update" -> the previous music stops and the new music plays IF TRUE.
    '
    'Local Variables:
    '   [Integer] "enumlength" -> the length of the "AudioState" enum; used to assign a new value to "CurrentAudioState"

    'Description:
    '   This subroutine uses the local variables above, and the CurrentAudioState enum to play the correct music
    '   for the current displaying form
    REM

    Sub PlayMusic(Optional Update As Boolean = False)
        If Update Then
            My.Computer.Audio.Stop()
            Dim enumlength As Integer = [Enum].GetNames(GetType(AudioState)).Length
            CurrentAudioState = If(
                CurrentAudioState <> enumlength - 1, ' If condition
                CurrentAudioState + 1, ' Runs if condition true
                AudioState.Intro ' Runs if condition false
            )
        End If
        My.Computer.Audio.Play(MusicFilePaths(CurrentAudioState), AudioPlayMode.BackgroundLoop)
    End Sub
End Module
