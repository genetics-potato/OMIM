Public Module Program

    Sub Main()



        Call SMRUCC.Clinic.Data.Cosmic.Dump(Of SMRUCC.Clinic.Data.Cosmic.mysql.gene_expression)("G:\2017-3-7-KEGG\cosmic\CosmicCompleteGeneExpression.out.txt")
        Pause()
        Dim db = SMRUCC.Clinic.Data.DrugBank.XML.Database.Load("G:\2017-3-7-KEGG\full database.xml")

        Pause()
    End Sub
End Module
