---
title: searchQuery
---

# searchQuery
_namespace: [SMRUCC.Clinic.OMIM.Handlers.search](N-SMRUCC.Clinic.OMIM.Handlers.search.html)_

Model for builds the search url parameters



### Methods

#### #ctor
```csharp
SMRUCC.Clinic.OMIM.Handlers.search.searchQuery.#ctor(SMRUCC.Clinic.OMIM.API.Handlers)
```


|Parameter Name|Remarks|
|--------------|-------|
|handler|
 Only allowed ``@"F:SMRUCC.Clinic.OMIM.API.Handlers.entry"``, 
 ``@"F:SMRUCC.Clinic.OMIM.API.Handlers.geneMap"``, and 
 ``@"F:SMRUCC.Clinic.OMIM.API.Handlers.clinicalSynopsis"``
 |


#### ToString
```csharp
SMRUCC.Clinic.OMIM.Handlers.search.searchQuery.ToString
```
Generates the url parameter


### Properties

#### fields
The fields, defaults To 'number^5 title^3 default'
#### filter
The filter (Optional)
#### handler
Only allowed ``@"F:SMRUCC.Clinic.OMIM.API.Handlers.entry"``, ``@"F:SMRUCC.Clinic.OMIM.API.Handlers.geneMap"``, and ``@"F:SMRUCC.Clinic.OMIM.API.Handlers.clinicalSynopsis"``
#### limit
The number Of results To Return, Default Is 10
#### retrieve
To retrieve the gene map Or clinical synopses corresponding to the entries instead of the entries themselves
#### search
The search (required)
#### sort
The sort order To use, defaults To 'score desc'
#### start
The start offset into the results, Default Is 0
