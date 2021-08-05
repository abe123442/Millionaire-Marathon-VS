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

    ' A subroutine that plays music and optionally updates "CurrentAudioState"
    Sub PlayMusic(Optional Update As Boolean = False)
        If Update Then
            My.Computer.Audio.Stop()
            Dim enumlength = [Enum].GetNames(GetType(AudioState)).Length
            CurrentAudioState = If(
                CurrentAudioState <> enumlength - 1, ' If condition
                CurrentAudioState + 1, ' Runs if condition true
                AudioState.Intro ' Runs if condition false
            )
        End If
        My.Computer.Audio.Play(MusicFilePaths(CurrentAudioState), AudioPlayMode.BackgroundLoop)
    End Sub
End Module
