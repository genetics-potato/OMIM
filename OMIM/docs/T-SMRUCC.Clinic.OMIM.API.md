---
title: API
---

# API
_namespace: [SMRUCC.Clinic.OMIM](N-SMRUCC.Clinic.OMIM.html)_

Online Mendelian Inheritance in Man (OMIM), a know ledgebase of human genes and genetic disorders
 
 ##### OMIM API
 
 The OMIM API URLs are organized In a very simple fashion:

 + ``/api/[handler]?[parameters]``
 + ``/api/[handler]/[component]?[parameters]``
 + ``/api/[handler]/[action]?[parameters]``

 The handler refers To the data Object, such As an entry Or a clinical synopsis.
 The component Is Optional And refers To a specific data component within a data Object 
 For example references within an entry.
 The action Is Optional And refers To an action To be performed On a data Object, such 
 As a search For entries.
 For basic 'GET's, the component or action are usually optional.
 The parameters would include things such As MIM numbers, data retrieval options And data 
 formatting options.
 Since this Is a read-only database, ``GET`` is the only HTTP method for public access, all 
 other HTTP methods will return an error (except for the apiKey handle which supports 
 ``POST`` and ``DELETE``).



### Methods

#### #ctor
```csharp
SMRUCC.Clinic.OMIM.API.#ctor(System.String)
```


|Parameter Name|Remarks|
|--------------|-------|
|key|
 The API key is a key (SHA1 hash) that is unique to every developer wanting to access the API. 
 It is allocated by OMIM and should not be shared. This has to be included with every request 
 and is validated before the request is processed.
 |

> 
>  ##### API Key
> 
>  The API key Is a key (SHA1 hash) that Is unique To every developer wanting To access the API. 
>  It Is allocated by OMIM And should Not be Shared. This has To be included With every request 
>  And Is validated before the request Is processed. There are three ways In which it can be 
>  included With a request.
> 
>  + Added as an HTTP Header as follows
>     ```
>  ApiKey: 039583F9182AE1F7C343746B9B54C1F1BF1678A9
>     ```
>     
>  + Added as a cookie as follows
>     ```
>  Cookie: ApiKey=039583F9182AE1F7C343746B9B54C1F1BF1678A9
>     ```
>     
>  + Added as a parameter to the url request as follows
>     ```
>  http://api.omim.org/....?...&apiKey=039583F9182AE1F7C343746B9B54C1F1BF1678A9
>     ```
>     
>  Note that the API key parameter name Is Case-sensitive.
>  

#### APIQuery
```csharp
SMRUCC.Clinic.OMIM.API.APIQuery(SMRUCC.Clinic.OMIM.IQuery)
```
API query of the OMIM database

|Parameter Name|Remarks|
|--------------|-------|
|args|-|


#### clinicalSynopsis
```csharp
SMRUCC.Clinic.OMIM.API.clinicalSynopsis(SMRUCC.Clinic.OMIM.Handlers.clinicalSynopsis.clinicalSynopsisQuery)
```
The clinical synopsis handler supports the following actions/components:

 [none]
 
 This Is the default case And requires one parameter 'mimNumber' specifying the MIM entry to be retrieved, for example:
 
 http://api.omim.org/api/clinicalSynopsis?mimNumber=100100
 
 Multiple MIM numbers can be specified As follows
 
 http://api.omim.org/api/clinicalSynopsis?mimNumber=100100&mimNumber=100200
 
 Or as follows
 
 http://api.omim.org/api/clinicalSynopsis?mimNumber=100100,100200
 
 This will Return the mim number, the prefix, the status And the titles.


### Properties

#### __key
API Key
#### OMIM_API
The API host name is:
 
 > api.omim.org
