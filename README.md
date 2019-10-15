## htputSDK

`Download:`[https://github.com/loudKode/htputSDK/releases](https://github.com/loudKode/htputSDK/releases)<br>
`NuGet:`
[![NuGet](https://img.shields.io/nuget/v/DeQmaTech.htputSDK.svg?style=flat-square&logo=nuget)](https://www.nuget.org/packages/DeQmaTech.htputSDK)<br>

**Features**
* Assemblies for .NET 4.5.2 and .NET Standard 2.0 and .NET Core 2.1
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
```vb.net
    Sub SetClient()
        Dim MyClient As htputSDK.IClient = New htputSDK.HClient()
    End Sub
```
```vb.net
    Sub SetClientWithOptions()
        Dim Optians As New htputSDK.ConnectionSettings With {.CloseConnection = True, .TimeOut = TimeSpan.FromMinutes(30), .Proxy = New htputSDK.ProxyConfig With {.ProxyIP = "172.0.0.0", .ProxyPort = 80, .ProxyUsername = "myname", .ProxyPassword = "myPass", .SetProxy = True}}
        Dim MyClient As htputSDK.IClient = New htputSDK.HClient(Optians)
    End Sub
```
```vb.net
    Async Sub CreateNewPage()
        Dim UploadCancellationToken As New Threading.CancellationTokenSource()
        Dim _ReportCls As New Progress(Of htputSDK.ReportStatus)(Sub(ReportClass As htputSDK.ReportStatus)
                                                                     Label1.Text = String.Format("{0}/{1}", (ReportClass.BytesTransferred), (ReportClass.TotalBytes))
                                                                     ProgressBar1.Value = CInt(ReportClass.ProgressPercentage)
                                                                     Label2.Text = CStr(ReportClass.TextStatus)
                                                                 End Sub)
        Dim RSLT = Await MyClient.CreateNewPage("html code", htputSDK.utilitiez.SentType.String, "address", _ReportCls, UploadCancellationToken.Token)
        DataGridView1.Rows.Add(RSLT.pageurl, RSLT.status.ToString, RSLT.pass, RSLT.JSON.ToString, If(RSLT._ErrorMessage IsNot Nothing, RSLT._ErrorMessage, Nothing))
    End Sub
```
```vb.net
    Async Sub DeletePage()
        Dim RSLT = Await MyClient.DeletePage("https://htput.com/xxxxx", "delete pass")
    End Sub
```
```vb.net
    Async Sub ReplacePage()
        Dim UploadCancellationToken As New Threading.CancellationTokenSource()
        Dim _ReportCls As New Progress(Of htputSDK.ReportStatus)(Sub(ReportClass As htputSDK.ReportStatus)
                                                                     Label1.Text = String.Format("{0}/{1}", (ReportClass.BytesTransferred), (ReportClass.TotalBytes))
                                                                     ProgressBar1.Value = CInt(ReportClass.ProgressPercentage)
                                                                     Label2.Text = CStr(ReportClass.TextStatus)
                                                                 End Sub)
        Dim RSLT = Await MyClient.ReplacePage("https://htput.com/xxxxx", "html code", htputSDK.utilitiez.SentType.String, "pass", _ReportCls, UploadCancellationToken.Token)
        DataGridView1.Rows.Add(RSLT.status, RSLT.JSON.ToString, If(RSLT._ErrorMessage IsNot Nothing, RSLT._ErrorMessage, Nothing))
    End Sub
```
```vb.net
    Async Sub AppendPage()
        Dim UploadCancellationToken As New Threading.CancellationTokenSource()
        Dim _ReportCls As New Progress(Of htputSDK.ReportStatus)(Sub(ReportClass As htputSDK.ReportStatus)
                                                                     Label1.Text = String.Format("{0}/{1}", (ReportClass.BytesTransferred), (ReportClass.TotalBytes))
                                                                     ProgressBar1.Value = CInt(ReportClass.ProgressPercentage)
                                                                     Label2.Text = CStr(ReportClass.TextStatus)
                                                                 End Sub)
        Dim RSLT = Await MyClient.AppendPage("https://htput.com/xxxxx", "html code", htputSDK.utilitiez.SentType.String, "pass", _ReportCls, UploadCancellationToken.Token)
        DataGridView1.Rows.Add(RSLT.status, RSLT.JSON.ToString, If(RSLT._ErrorMessage IsNot Nothing, RSLT._ErrorMessage, Nothing))
    End Sub
```
```vb.net
    Async Sub Download_Page_WithProgressTracking()
        Dim DownloadCancellationToken As New Threading.CancellationTokenSource()
        Dim _ReportCls As New Progress(Of htputSDK.ReportStatus)(Sub(ReportClass As htputSDK.ReportStatus)
                                                                     Label1.Text = String.Format("{0}/{1}", (ReportClass.BytesTransferred), (ReportClass.TotalBytes))
                                                                     ProgressBar1.Value = CInt(ReportClass.ProgressPercentage)
                                                                     Label2.Text = CStr(ReportClass.TextStatus)
                                                                 End Sub)
        Await MyClient.Download("https://htput.com/xxxxx", "J:\DB\index.html", _ReportCls, DownloadCancellationToken.Token)
    End Sub
```
