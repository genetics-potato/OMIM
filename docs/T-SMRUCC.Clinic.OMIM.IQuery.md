---
title: IQuery
---

# IQuery
_namespace: [SMRUCC.Clinic.OMIM](N-SMRUCC.Clinic.OMIM.html)_

Handlers' query base.



### Methods

#### ToString
```csharp
SMRUCC.Clinic.OMIM.IQuery.ToString
```
请重写这个方法来构建URL参数


### Properties

#### debug
This returns debug output Of what the API received from the client (For example 'debug=true'). No data will be returned.
#### format
This specifies the format Of the data returned, these include 'html', 'xml', 'json', 'jsonp', 'python' and 'ruby' (for example 'format=xml'). 
 The html format is just the xml with a stylesheet applied to it, this application is done in the API itself. This allows a developer to 
 get responses from the API marked up in html suitable for a web browser. Note that 'text' is only useful in very specific cases.
#### handler
The handler refers to the data object, such as an entry or a clinical synopsis.
#### jsonp
This specifies the callback Function name For 'jsonp'. If omitted or invalid, the callback function defaults to 'omimWrapper'.
#### NoValidEntry
A mim number is required to get a entry!
#### style
This causes the API To include stylesheet URL For rendering by a browser (For example 'style=true'). This is only 
 useful for the 'xml' format, and allows the client to render the XML into HTML locally as opposed to having the 
 API do it for them.
