Welcome to the htputSDK wiki!

`Download:`[https://github.com/loudKode/htputSDK/releases](https://github.com/loudKode/htputSDK/releases)<br>
`NuGet:`
[![NuGet](https://img.shields.io/nuget/v/DeQmaTech.htputSDK.svg?style=flat-square&logo=nuget)](https://www.nuget.org/packages/DeQmaTech.htputSDK)<br>

**Features**
* Assemblies for .NET 4.5.2 and .NET Standard 2.0
* Just one external reference (Newtonsoft.Json)
* Easy installation using NuGet
* Upload/Download tracking support
* Proxy Support
* Upload/Download cancellation support

# Functions:
* AppendPage
* DeletePage
* GetPageAs
* ReplacePage
* CreateNewPage

# Code simple:

**set client**
```vb.net
Dim clnt As htputSDK.IClient = New htputSDK.HClient()
```
**publish new page**
```vb
Dim RSLT = Await clnt.CreateNewPage("html code", SentType.String, "domain address e.g. google", nothing, nothing, nothing)
```
**delete published page**
```vb.net
Dim RSLT = Await clnt.DeletePage("domain address e.g. google", "deleteID", nothing, nothing)
```
