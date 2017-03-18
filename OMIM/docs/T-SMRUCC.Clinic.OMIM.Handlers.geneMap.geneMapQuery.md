---
title: geneMapQuery
---

# geneMapQuery
_namespace: [SMRUCC.Clinic.OMIM.Handlers.geneMap](N-SMRUCC.Clinic.OMIM.Handlers.geneMap.html)_






### Properties

#### chromosome
The chromosome, 1-22, 23 (X), 24 (Y), 25 (M), X, Y, M (mitochondria), A (autosomal group), S (XY group)
#### chromosomeSort
The chromosome sort In the chromosome (these are sequential Integer values With no breaks And are Not stable beyond the scope Of a day).
#### limit
The number Of entries To Return, Default Is 10
#### phenotypeExists
'true' will only return entries with phenotypes, 'false' will only return entries without phenotypes
#### sequenceID
The sequence ID In the gene map (these are sequential Integer values With no breaks And are Not stable beyond the scope Of a day).
#### start
The start offset into the gene map, Default Is 0 (can be negative When getting a list from a sequence ID
