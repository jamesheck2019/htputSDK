using System;
using System.Threading;
using System.Threading.Tasks;
using htputSDK.JSON;

namespace htputSDK
{
	public interface IClient
	{
		Task<JSON_CreateNewPage> CreateNewPage(object TheWebPageContent, utilitiez.SentType UploadType, string PageAddressName, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, CancellationToken token = default(CancellationToken));

		Task<JSON_CreateNewPage> AppendPage(string TheWebPageUrl, object TheNewContent, utilitiez.SentType UploadType, string TheAuthorityPassword, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, CancellationToken token = default(CancellationToken));

		Task<bool> DeletePage(string TheWebPageUrl, string TheAuthorityPassword, ProxyConfig _proxi = null, CancellationToken token = default(CancellationToken));

		Task<JSON_CreateNewPage> ReplacePage(string TheWebPageUrl, object TheNewContent, utilitiez.SentType UploadType, string TheAuthorityPassword, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, CancellationToken token = default(CancellationToken));

		Task Download(string ContentAddressURL, string FileSavePath, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, CancellationToken token = default(CancellationToken));
	}
}
