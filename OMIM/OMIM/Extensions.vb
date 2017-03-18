Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Language
Imports SMRUCC.Clinic.OMIM.Handlers
Imports SMRUCC.Clinic.OMIM.Handlers.entry

Public Module Extensions

    ReadOnly __entryIncludes As entry.includes() = {
        entry.includes.all,
        entry.includes.allelicVariantList,
        entry.includes.clinicalSynopsis,
        entry.includes.contributors,
        entry.includes.creationDate,
        entry.includes.dates,
        entry.includes.editHistory,
        entry.includes.existflags,
        entry.includes.externalLinks,
        entry.includes.geneMap,
        entry.includes.referenceList,
        entry.includes.seeAlso,
        entry.includes.text
    }

    ReadOnly __clinicalSynopsisIncludes As clinicalSynopsis.includes() = {
        clinicalSynopsis.includes.all,
        clinicalSynopsis.includes.clinicalSynopsis,
        clinicalSynopsis.includes.contributors,
        clinicalSynopsis.includes.creationDate,
        clinicalSynopsis.includes.dates,
        clinicalSynopsis.includes.editHistory,
        clinicalSynopsis.includes.existflags,
        clinicalSynopsis.includes.externalLinks
    }

    <Extension>
    Public Function ToArray(value As entry.includes) As entry.includes()
        SyncLock __entryIncludes
            Return __entryIncludes.ToArray(value)
        End SyncLock
    End Function

    <Extension>
    Public Function ToArray(value As clinicalSynopsis.includes) As clinicalSynopsis.includes()
        SyncLock __clinicalSynopsisIncludes
            Return __clinicalSynopsisIncludes.ToArray(value)
        End SyncLock
    End Function

    <Extension>
    Public Function ToArray(Of T)(array As T(), value As [Enum]) As T()
        Return LinqAPI.Exec(Of T) <=
 _
            From x As T
            In array
            Let enu As [Enum] = DirectCast(CType(x, Object), [Enum])
            Where value.HasFlag(enu)
            Select x

    End Function

    ReadOnly __formats As New Dictionary(Of String, Formats) From {
        {"html", Formats.html},
        {"xml", Formats.xml},
        {"json", Formats.json},
        {"jsonp", Formats.jsonp},
        {"python", Formats.python},
        {"ruby", Formats.ruby},
        {"text", Formats.text}
    }

    <Extension>
    Public Function GetFormats(s As String) As Formats
        Return __formats.TryGetValue(s.ToLower, [default]:=Formats.json)
    End Function

    ReadOnly __textSections As Dictionary(Of String, textSections) = (
        From x As textSections
        In [Enum].GetValues(GetType(textSections)).AsQueryable
        Select x) _
            .ToDictionary(Function(x) x.ToString)

    <Extension>
    Public Function GetTextSections(text As String) As textSections
        Return __textSections.TryGetValue(text, [default]:=textSections.null)
    End Function

    ReadOnly __entryIncludesHash As Dictionary(Of String, entry.includes) = (
        From x As entry.includes
        In [Enum].GetValues(GetType(entry.includes)).AsQueryable
        Select x) _
            .ToDictionary(Function(x) x.ToString)

    <Extension>
    Public Function GetEntryIncludes(text As String) As entry.includes
        Return __entryIncludesHash.TryGetValue(text, [default]:=includes.all)
    End Function

    ReadOnly __sorts As Dictionary(Of String, search.sorts) = (
        From x As search.sorts
        In [Enum].GetValues(GetType(search.sorts)).AsQueryable
        Select x) _
            .ToDictionary(Function(x) x.ToString)

    <Extension>
    Public Function GetSearchSorts(text As String) As search.sorts
        Return __sorts.TryGetValue(text, [default]:=search.sorts.null)
    End Function

    ReadOnly __retrieves As Dictionary(Of String, search.retrieves) = (
        From x As search.retrieves
        In [Enum].GetValues(GetType(search.retrieves))
        Select x) _
            .ToDictionary(Function(x) x.ToString)

    <Extension>
    Public Function GetEntryRetrieves(text As String) As search.retrieves
        Return __retrieves.TryGetValue(text, [default]:=search.retrieves.null)
    End Function

End Module
