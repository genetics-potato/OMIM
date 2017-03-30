Public Module Program

    Sub Main()



        Call SMRUCC.Clinic.Data.Cosmic.DumpFromDirectory("G:\2017-3-7-KEGG\cosmic\", "x:\")
        Pause()
        Dim db = SMRUCC.Clinic.Data.DrugBank.XML.Database.Load("G:\2017-3-7-KEGG\full database.xml")

        Pause()
    End Sub
End Module
