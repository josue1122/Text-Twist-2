Imports ClasesJuego

Module JuegoGlobal
    Dim textTwist2 As Juego
    Public sonido, tiempo As Boolean
    Public Function Conectar() As Boolean
        My.Computer.Audio.Play(My.Resources.MainMenu, AudioPlayMode.BackgroundLoop)
        Return True
    End Function
    Public Function Desconectar() As Boolean
        My.Computer.Audio.Stop()
        Return True
    End Function


    Dim palabra1 As New pal("camote", "Tubérculo comestible de América Central y México.")
    Dim palabra2 As New pal("cometa", "Cuerpo celeste compuesto de hielo y polvo que describe una órbita elíptica alrededor del Sol.")
    Dim palabra3 As New pal("acote", "Conjunto de ramas de la vid, después de cortar los racimos.")
    Dim palabra4 As New pal("cateo", "Examen o inspección minuciosa que se hace para buscar algo.")
    Dim palabra5 As New pal("mateo", "Nombre propio de varón.")
    Dim palabra6 As New pal("meato", "Cada una de las aberturas u orificios naturales de algunos animales.")
    Dim palabra7 As New pal("acto", "Acción que realiza una persona.")
    Dim palabra8 As New pal("ateo", "Que niega la existencia de Dios o deidades.")
    Dim palabra9 As New pal("atoe", "No se encontró significado para esta palabra.")
    Dim palabra10 As New pal("cate", "Verbo que significa poner atención o cuidado en algo.")
    Dim palabra11 As New pal("cato", "Miembro de una secta filosófica que floreció en la antigua Grecia.")
    Dim palabra12 As New pal("coma", "Estado de pérdida de conciencia o falta de respuesta a estímulos externos.")
    Dim palabra13 As New pal("come", "Verbo que significa ingerir alimentos.")
    Dim palabra14 As New pal("cota", "Línea que delimita una región geográfica.")
    Dim palabra15 As New pal("cote", "Comparar o contrastar dos o más cosas.")
    Dim palabra16 As New pal("mate", "Infusión que se obtiene al verter agua caliente sobre hojas de yerba mate.")
    Dim palabra17 As New pal("meca", "Lugar de peregrinación para los musulmanes.")
    Dim palabra18 As New pal("meco", "Que es tonto o tiene poca inteligencia.")
    Dim palabra19 As New pal("meta", "Objetivo o fin que se desea alcanzar.")
    Dim palabra20 As New pal("mota", "Partícula de polvo o suciedad muy pequeña.")
    Dim palabra21 As New pal("mote", "Apodo o nombre que se le da a alguien.")
    Dim palabra22 As New pal("taco", "Comida típica mexicana que consiste en una tortilla de maíz doblada y rellena de carne, frijoles, queso, etc.")
    Dim palabra23 As New pal("tame", "Hacer dócil o manso a un animal.")
    Dim palabra24 As New pal("tamo", "Parte de la planta del tabaco que se desecha.")
    Dim palabra25 As New pal("teca", "Árbol de madera dura y resistente.")
    Dim palabra26 As New pal("tema", "Asunto o materia sobre la que se habla o escribe.")
    Dim palabra27 As New pal("toca", "Instrumento musical de percusión que consta de una caja con parches.")
    Dim palabra28 As New pal("toma", "Acción de tomar algo con la mano.")
    Dim palabra29 As New pal("ame", "Forma conjugada del verbo amar en primera persona del singular del presente de indicativo.")
    Dim palabra30 As New pal("amo", "Persona que tiene autoridad y control sobre algo o alguien.")
    Public Nivel1 As New ArrayList From {palabra1, palabra2, palabra3, palabra4, palabra5, palabra6, palabra7, palabra8, palabra9, palabra10, palabra11, palabra12, palabra13, palabra14, palabra15, palabra16, palabra17, palabra18, palabra19, palabra20, palabra21, palabra22, palabra23, palabra24, palabra25, palabra26, palabra27, palabra28, palabra29, palabra30}





End Module
