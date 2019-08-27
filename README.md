# htputSDK
htput.com SDK for .NET
<ul>
	<li>.NET 4.5.2</li>
	<li>One dependency library [Newtonsoft.Json]</li>
</ul>
====
<ul>
	<li>AppendPage</li>
	<li>DeletePage</li>
	<li>GetPageAs</li>
	<li>ReplacePage</li>
	<li>CreateNewPage</li>
</ul>

# Code simple:
```vb.net
Dim clnt As htputSDK.IClient = New htputSDK.HClient()
Dim RSLT = Await clnt.CreateNewPage(RichTextBox1.Text, htputSDK.utilitiez.SentType.String, TextBox1.Text, nothing, nothing, nothing)
Dim RSLT = Await clnt.DeletePage(TextBox3.Text, TextBox2.Text, nothing, nothing)
Dim RSLT = Await clnt.ReplacePage(TextBox4.Text, RichTextBox2.Text, htputSDK.utilitiez.SentType.String, TextBox5.Text, nothing, nothing, nothing)
Dim RSLT = Await clnt.AppendPage(TextBox7.Text, (Environment.NewLine & RichTextBox3.Text), htputSDK.utilitiez.SentType.String, TextBox6.Text, nothing, nothing, nothing)
Await clnt.Download(TextBox8.Text, "C:\FileName.html", nothing, nothing, nothing)
```
