Imports ClasesJuego

Module JuegoGlobal
    Public sonido, tiempo As Boolean
    Public Function Conectar() As Boolean
        My.Computer.Audio.Play(My.Resources.MainMenu, AudioPlayMode.BackgroundLoop)
        Return True
    End Function
    Public Function Desconectar() As Boolean
        My.Computer.Audio.Stop()
        Return True
    End Function













    Dim palabra1 As New Palabra("camote")
    Dim palabra2 As New Palabra("cometa")
    Dim palabra3 As New Palabra("acote")
    Dim palabra4 As New Palabra("cateo")
    Dim palabra5 As New Palabra("mateo")
    Dim palabra6 As New Palabra("meato")
    Dim palabra7 As New Palabra("acto")
    Dim palabra8 As New Palabra("ateo")
    Dim palabra9 As New Palabra("atoe")
    Dim palabra10 As New Palabra("cate")
    Dim palabra11 As New Palabra("cato")
    Dim palabra12 As New Palabra("coma")
    Dim palabra13 As New Palabra("come")
    Dim palabra14 As New Palabra("cota")
    Dim palabra15 As New Palabra("cote")
    Dim palabra16 As New Palabra("mate")
    Dim palabra17 As New Palabra("meca")
    Dim palabra18 As New Palabra("meco")
    Dim palabra19 As New Palabra("meta")
    Dim palabra20 As New Palabra("mota")
    Dim palabra21 As New Palabra("mote")
    Dim palabra22 As New Palabra("taco")
    Dim palabra23 As New Palabra("tame")
    Dim palabra24 As New Palabra("tamo")
    Dim palabra25 As New Palabra("teca")
    Dim palabra26 As New Palabra("tema")
    Dim palabra27 As New Palabra("toca")
    Dim palabra28 As New Palabra("toma")
    Dim palabra29 As New Palabra("ame")
    Dim palabra30 As New Palabra("amo")
    Dim palabra31 As New Palabra("ate")
    Dim palabra32 As New Palabra("ato")
    Dim palabra33 As New Palabra("cae")
    Dim palabra34 As New Palabra("cao")
    Dim palabra35 As New Palabra("cea")
    Dim palabra36 As New Palabra("coa")
    Dim palabra37 As New Palabra("eco")
    Dim palabra38 As New Palabra("eta")
    Dim palabra39 As New Palabra("etc")
    Dim palabra40 As New Palabra("mea")
    Dim palabra41 As New Palabra("moa")
    Dim palabra42 As New Palabra("oca")
    Dim palabra43 As New Palabra("tac")
    Dim palabra44 As New Palabra("tao")
    Dim palabra45 As New Palabra("tea")

    Public Nivel1 As New ArrayList From {palabra1, palabra2, palabra3, palabra4, palabra5, palabra6, palabra7, palabra8, palabra9, palabra10, palabra11, palabra12, palabra13, palabra14, palabra15, palabra16, palabra17, palabra18, palabra19, palabra20, palabra21, palabra22, palabra23, palabra24, palabra25, palabra26, palabra27, palabra28, palabra29, palabra30, palabra31, palabra32, palabra33, palabra34, palabra35, palabra36, palabra37, palabra38, palabra39, palabra40, palabra41, palabra42, palabra43, palabra44, palabra45}




End Module
