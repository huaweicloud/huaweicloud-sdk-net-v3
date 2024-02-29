using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dns.V2.Model;

namespace HuaweiCloud.SDK.Dns.V2
{
    public partial class DnsAsyncClient : Client
    {
        public static ClientBuilder<DnsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DnsAsyncClient>();
        }

        
        /// <summary>
        /// 创建单个自定义线路
        ///
        /// 创建单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCustomLineResponse> CreateCustomLineAsync(CreateCustomLineRequest createCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomLineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCustomLineResponse>(response);
        }

        public AsyncInvoker<CreateCustomLineResponse> CreateCustomLineAsyncInvoker(CreateCustomLineRequest createCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomLineRequest);
            return new AsyncInvoker<CreateCustomLineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCustomLineResponse>);
        }
        
        /// <summary>
        /// 创建线路分组
        ///
        /// 创建一个线路分组。 该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLineGroupResponse> CreateLineGroupAsync(CreateLineGroupRequest createLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLineGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLineGroupResponse>(response);
        }

        public AsyncInvoker<CreateLineGroupResponse> CreateLineGroupAsyncInvoker(CreateLineGroupRequest createLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLineGroupRequest);
            return new AsyncInvoker<CreateLineGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLineGroupResponse>);
        }
        
        /// <summary>
        /// 删除单个自定义线路
        ///
        /// 删除单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCustomLineResponse> DeleteCustomLineAsync(DeleteCustomLineRequest deleteCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id", deleteCustomLineRequest.LineId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomLineRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCustomLineResponse>(response);
        }

        public AsyncInvoker<DeleteCustomLineResponse> DeleteCustomLineAsyncInvoker(DeleteCustomLineRequest deleteCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id", deleteCustomLineRequest.LineId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomLineRequest);
            return new AsyncInvoker<DeleteCustomLineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCustomLineResponse>);
        }
        
        /// <summary>
        /// 删除线路分组
        ///
        /// 删除单个线路分组。该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLineGroupResponse> DeleteLineGroupAsync(DeleteLineGroupRequest deleteLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", deleteLineGroupRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLineGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteLineGroupResponse>(response);
        }

        public AsyncInvoker<DeleteLineGroupResponse> DeleteLineGroupAsyncInvoker(DeleteLineGroupRequest deleteLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", deleteLineGroupRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLineGroupRequest);
            return new AsyncInvoker<DeleteLineGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteLineGroupResponse>);
        }
        
        /// <summary>
        /// 查询所有的云解析服务API版本号
        ///
        /// 查询所有的云解析服务API版本号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public AsyncInvoker<ListApiVersionsResponse> ListApiVersionsAsyncInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new AsyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询自定义线路
        ///
        /// 查询自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomLineResponse> ListCustomLineAsync(ListCustomLineRequest listCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomLineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomLineResponse>(response);
        }

        public AsyncInvoker<ListCustomLineResponse> ListCustomLineAsyncInvoker(ListCustomLineRequest listCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomLineRequest);
            return new AsyncInvoker<ListCustomLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomLineResponse>);
        }
        
        /// <summary>
        /// 查询线路分组列表
        ///
        /// 查询线路分组列表。该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLineGroupsResponse> ListLineGroupsAsync(ListLineGroupsRequest listLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLineGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLineGroupsResponse>(response);
        }

        public AsyncInvoker<ListLineGroupsResponse> ListLineGroupsAsyncInvoker(ListLineGroupsRequest listLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLineGroupsRequest);
            return new AsyncInvoker<ListLineGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLineGroupsResponse>);
        }
        
        /// <summary>
        /// 查询名称服务器列表
        ///
        /// 查询名称服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNameServersResponse> ListNameServersAsync(ListNameServersRequest listNameServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNameServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNameServersResponse>(response);
        }

        public AsyncInvoker<ListNameServersResponse> ListNameServersAsyncInvoker(ListNameServersRequest listNameServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNameServersRequest);
            return new AsyncInvoker<ListNameServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNameServersResponse>);
        }
        
        /// <summary>
        /// 查询指定的云解析服务API版本号
        ///
        /// 查询指定的云解析服务API版本号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiInfoResponse> ShowApiInfoAsync(ShowApiInfoRequest showApiInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiInfoRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiInfoResponse>(response);
        }

        public AsyncInvoker<ShowApiInfoResponse> ShowApiInfoAsyncInvoker(ShowApiInfoRequest showApiInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiInfoRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiInfoRequest);
            return new AsyncInvoker<ShowApiInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiInfoResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询单租户在DNS服务下的资源配额，包括公网zone配额、内网zone配额、Record Set配额、PTR Record配额、入站终端节点配额、出站终端节点配额、自定义线路配额、线路分组配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainQuotaResponse> ShowDomainQuotaAsync(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/quotamg/dns/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
        }

        public AsyncInvoker<ShowDomainQuotaResponse> ShowDomainQuotaAsyncInvoker(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/quotamg/dns/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            return new AsyncInvoker<ShowDomainQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainQuotaResponse>);
        }
        
        /// <summary>
        /// 查询线路分组
        ///
        /// 查询线路分组。该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLineGroupResponse> ShowLineGroupAsync(ShowLineGroupRequest showLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", showLineGroupRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLineGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLineGroupResponse>(response);
        }

        public AsyncInvoker<ShowLineGroupResponse> ShowLineGroupAsyncInvoker(ShowLineGroupRequest showLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", showLineGroupRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLineGroupRequest);
            return new AsyncInvoker<ShowLineGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLineGroupResponse>);
        }
        
        /// <summary>
        /// 更新单个自定义线路
        ///
        /// 更新单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCustomLineResponse> UpdateCustomLineAsync(UpdateCustomLineRequest updateCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id", updateCustomLineRequest.LineId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomLineRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCustomLineResponse>(response);
        }

        public AsyncInvoker<UpdateCustomLineResponse> UpdateCustomLineAsyncInvoker(UpdateCustomLineRequest updateCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id", updateCustomLineRequest.LineId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomLineRequest);
            return new AsyncInvoker<UpdateCustomLineResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCustomLineResponse>);
        }
        
        /// <summary>
        /// 更新线路分组
        ///
        /// 更新单个线路分组。该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLineGroupsResponse> UpdateLineGroupsAsync(UpdateLineGroupsRequest updateLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", updateLineGroupsRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLineGroupsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLineGroupsResponse>(response);
        }

        public AsyncInvoker<UpdateLineGroupsResponse> UpdateLineGroupsAsyncInvoker(UpdateLineGroupsRequest updateLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", updateLineGroupsRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLineGroupsRequest);
            return new AsyncInvoker<UpdateLineGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLineGroupsResponse>);
        }
        
        /// <summary>
        /// 设置弹性IP的PTR记录
        ///
        /// 设置弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEipRecordSetResponse> CreateEipRecordSetAsync(CreateEipRecordSetRequest createEipRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", createEipRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id", createEipRecordSetRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEipRecordSetRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<CreateEipRecordSetResponse>(response);
        }

        public AsyncInvoker<CreateEipRecordSetResponse> CreateEipRecordSetAsyncInvoker(CreateEipRecordSetRequest createEipRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", createEipRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id", createEipRecordSetRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEipRecordSetRequest);
            return new AsyncInvoker<CreateEipRecordSetResponse>(this, "PATCH", request, JsonUtils.DeSerialize<CreateEipRecordSetResponse>);
        }
        
        /// <summary>
        /// 查询租户弹性IP的PTR记录列表
        ///
        /// 查询租户弹性IP的PTR记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPtrRecordsResponse> ListPtrRecordsAsync(ListPtrRecordsRequest listPtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPtrRecordsResponse>(response);
        }

        public AsyncInvoker<ListPtrRecordsResponse> ListPtrRecordsAsyncInvoker(ListPtrRecordsRequest listPtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrRecordsRequest);
            return new AsyncInvoker<ListPtrRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPtrRecordsResponse>);
        }
        
        /// <summary>
        /// 将弹性IP的PTR记录恢复为默认值
        ///
        /// 将弹性IP的PTR记录恢复为默认值
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestorePtrRecordResponse> RestorePtrRecordAsync(RestorePtrRecordRequest restorePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", restorePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id", restorePtrRecordRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restorePtrRecordRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<RestorePtrRecordResponse>(response);
        }

        public AsyncInvoker<RestorePtrRecordResponse> RestorePtrRecordAsyncInvoker(RestorePtrRecordRequest restorePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", restorePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id", restorePtrRecordRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restorePtrRecordRequest);
            return new AsyncInvoker<RestorePtrRecordResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<RestorePtrRecordResponse>);
        }
        
        /// <summary>
        /// 查询单个弹性IP的PTR记录
        ///
        /// 查询单个弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPtrRecordSetResponse> ShowPtrRecordSetAsync(ShowPtrRecordSetRequest showPtrRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", showPtrRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id", showPtrRecordSetRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRecordSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPtrRecordSetResponse>(response);
        }

        public AsyncInvoker<ShowPtrRecordSetResponse> ShowPtrRecordSetAsyncInvoker(ShowPtrRecordSetRequest showPtrRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", showPtrRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id", showPtrRecordSetRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRecordSetRequest);
            return new AsyncInvoker<ShowPtrRecordSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPtrRecordSetResponse>);
        }
        
        /// <summary>
        /// 修改弹性IP的PTR记录
        ///
        /// 修改弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePtrRecordResponse> UpdatePtrRecordAsync(UpdatePtrRecordRequest updatePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", updatePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id", updatePtrRecordRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRecordRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePtrRecordResponse>(response);
        }

        public AsyncInvoker<UpdatePtrRecordResponse> UpdatePtrRecordAsyncInvoker(UpdatePtrRecordRequest updatePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", updatePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id", updatePtrRecordRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRecordRequest);
            return new AsyncInvoker<UpdatePtrRecordResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePtrRecordResponse>);
        }
        
        /// <summary>
        /// 批量删除某个Zone下的Record Set资源
        ///
        /// 批量删除某个Zone下的Record Set资源，当删除的资源不存在时，则默认删除成功。
        /// 响应结果中只包含本次实际删除的资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteRecordSetWithLineResponse> BatchDeleteRecordSetWithLineAsync(BatchDeleteRecordSetWithLineRequest batchDeleteRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", batchDeleteRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetWithLineRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteRecordSetWithLineResponse>(response);
        }

        public AsyncInvoker<BatchDeleteRecordSetWithLineResponse> BatchDeleteRecordSetWithLineAsyncInvoker(BatchDeleteRecordSetWithLineRequest batchDeleteRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", batchDeleteRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetWithLineRequest);
            return new AsyncInvoker<BatchDeleteRecordSetWithLineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 批量修改RecordSet
        ///
        /// 批量修改RecordSet。属于原子性操作，请求Record Set将全部完成修改，或不做任何修改。
        /// 仅公网Zone支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateRecordSetWithLineResponse> BatchUpdateRecordSetWithLineAsync(BatchUpdateRecordSetWithLineRequest batchUpdateRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", batchUpdateRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRecordSetWithLineRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateRecordSetWithLineResponse>(response);
        }

        public AsyncInvoker<BatchUpdateRecordSetWithLineResponse> BatchUpdateRecordSetWithLineAsyncInvoker(BatchUpdateRecordSetWithLineRequest batchUpdateRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", batchUpdateRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRecordSetWithLineRequest);
            return new AsyncInvoker<BatchUpdateRecordSetWithLineResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 创建单个Record Set
        ///
        /// 创建单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetResponse> CreateRecordSetAsync(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetResponse>(response);
        }

        public AsyncInvoker<CreateRecordSetResponse> CreateRecordSetAsyncInvoker(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            return new AsyncInvoker<CreateRecordSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetResponse>);
        }
        
        /// <summary>
        /// 批量线路创建RecordSet
        ///
        /// 批量线路创建RecordSet。属于原子性操作，如果存在一个参数校验不通过，则创建失败。仅公网Zone支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetWithBatchLinesResponse> CreateRecordSetWithBatchLinesAsync(CreateRecordSetWithBatchLinesRequest createRecordSetWithBatchLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetWithBatchLinesRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/batch/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithBatchLinesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetWithBatchLinesResponse>(response);
        }

        public AsyncInvoker<CreateRecordSetWithBatchLinesResponse> CreateRecordSetWithBatchLinesAsyncInvoker(CreateRecordSetWithBatchLinesRequest createRecordSetWithBatchLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetWithBatchLinesRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/batch/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithBatchLinesRequest);
            return new AsyncInvoker<CreateRecordSetWithBatchLinesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetWithBatchLinesResponse>);
        }
        
        /// <summary>
        /// 创建单个Record Set
        ///
        /// 创建单个Record Set，仅适用于公网DNS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetWithLineResponse> CreateRecordSetWithLineAsync(CreateRecordSetWithLineRequest createRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithLineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetWithLineResponse>(response);
        }

        public AsyncInvoker<CreateRecordSetWithLineResponse> CreateRecordSetWithLineAsyncInvoker(CreateRecordSetWithLineRequest createRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithLineRequest);
            return new AsyncInvoker<CreateRecordSetWithLineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 删除单个Record Set
        ///
        /// 删除单个Record Set. 删除有添加智能解析的记录集时、需要用Record Set多线路管理模块中删除接口进行删除.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordSetResponse> DeleteRecordSetAsync(DeleteRecordSetRequest deleteRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deleteRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", deleteRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRecordSetResponse>(response);
        }

        public AsyncInvoker<DeleteRecordSetResponse> DeleteRecordSetAsyncInvoker(DeleteRecordSetRequest deleteRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deleteRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", deleteRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetRequest);
            return new AsyncInvoker<DeleteRecordSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRecordSetResponse>);
        }
        
        /// <summary>
        /// 删除单个Record Set
        ///
        /// 删除单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordSetsResponse> DeleteRecordSetsAsync(DeleteRecordSetsRequest deleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deleteRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", deleteRecordSetsRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRecordSetsResponse>(response);
        }

        public AsyncInvoker<DeleteRecordSetsResponse> DeleteRecordSetsAsyncInvoker(DeleteRecordSetsRequest deleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deleteRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", deleteRecordSetsRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetsRequest);
            return new AsyncInvoker<DeleteRecordSetsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRecordSetsResponse>);
        }
        
        /// <summary>
        /// 查询租户Record Set资源列表
        ///
        /// 查询租户Record Set资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsResponse> ListRecordSetsAsync(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsResponse>(response);
        }

        public AsyncInvoker<ListRecordSetsResponse> ListRecordSetsAsyncInvoker(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            return new AsyncInvoker<ListRecordSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsResponse>);
        }
        
        /// <summary>
        /// 查询单个Zone下Record Set列表
        ///
        /// 查询单个Zone下Record Set列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsByZoneResponse> ListRecordSetsByZoneAsync(ListRecordSetsByZoneRequest listRecordSetsByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", listRecordSetsByZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsByZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsByZoneResponse>(response);
        }

        public AsyncInvoker<ListRecordSetsByZoneResponse> ListRecordSetsByZoneAsyncInvoker(ListRecordSetsByZoneRequest listRecordSetsByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", listRecordSetsByZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsByZoneRequest);
            return new AsyncInvoker<ListRecordSetsByZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsByZoneResponse>);
        }
        
        /// <summary>
        /// 查询租户Record Set资源列表
        ///
        /// 查询租户Record Set资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsWithLineResponse> ListRecordSetsWithLineAsync(ListRecordSetsWithLineRequest listRecordSetsWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsWithLineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsWithLineResponse>(response);
        }

        public AsyncInvoker<ListRecordSetsWithLineResponse> ListRecordSetsWithLineAsyncInvoker(ListRecordSetsWithLineRequest listRecordSetsWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsWithLineRequest);
            return new AsyncInvoker<ListRecordSetsWithLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsWithLineResponse>);
        }
        
        /// <summary>
        /// 设置Record Set状态
        ///
        /// 设置Record Set状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRecordSetsStatusResponse> SetRecordSetsStatusAsync(SetRecordSetsStatusRequest setRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id", setRecordSetsStatusRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/statuses/set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecordSetsStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetRecordSetsStatusResponse>(response);
        }

        public AsyncInvoker<SetRecordSetsStatusResponse> SetRecordSetsStatusAsyncInvoker(SetRecordSetsStatusRequest setRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id", setRecordSetsStatusRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/statuses/set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecordSetsStatusRequest);
            return new AsyncInvoker<SetRecordSetsStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRecordSetsStatusResponse>);
        }
        
        /// <summary>
        /// 查询单个Record Set
        ///
        /// 查询单个Record Set。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetResponse> ShowRecordSetAsync(ShowRecordSetRequest showRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", showRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetResponse>(response);
        }

        public AsyncInvoker<ShowRecordSetResponse> ShowRecordSetAsyncInvoker(ShowRecordSetRequest showRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", showRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetRequest);
            return new AsyncInvoker<ShowRecordSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetResponse>);
        }
        
        /// <summary>
        /// 查询单个Zone下Record Set列表
        ///
        /// 查询单个Zone下Record Set列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetByZoneResponse> ShowRecordSetByZoneAsync(ShowRecordSetByZoneRequest showRecordSetByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetByZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetByZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetByZoneResponse>(response);
        }

        public AsyncInvoker<ShowRecordSetByZoneResponse> ShowRecordSetByZoneAsyncInvoker(ShowRecordSetByZoneRequest showRecordSetByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetByZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetByZoneRequest);
            return new AsyncInvoker<ShowRecordSetByZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetByZoneResponse>);
        }
        
        /// <summary>
        /// 查询单个Record Set
        ///
        /// 查询单个Record Set，仅适用于公网DNS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetWithLineResponse> ShowRecordSetWithLineAsync(ShowRecordSetWithLineRequest showRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetWithLineRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", showRecordSetWithLineRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetWithLineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetWithLineResponse>(response);
        }

        public AsyncInvoker<ShowRecordSetWithLineResponse> ShowRecordSetWithLineAsyncInvoker(ShowRecordSetWithLineRequest showRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetWithLineRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", showRecordSetWithLineRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetWithLineRequest);
            return new AsyncInvoker<ShowRecordSetWithLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 修改单个Record Set
        ///
        /// 修改单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordSetResponse> UpdateRecordSetAsync(UpdateRecordSetRequest updateRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updateRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", updateRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordSetResponse>(response);
        }

        public AsyncInvoker<UpdateRecordSetResponse> UpdateRecordSetAsyncInvoker(UpdateRecordSetRequest updateRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updateRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", updateRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetRequest);
            return new AsyncInvoker<UpdateRecordSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordSetResponse>);
        }
        
        /// <summary>
        /// 修改单个Record Set
        ///
        /// 修改单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordSetsResponse> UpdateRecordSetsAsync(UpdateRecordSetsRequest updateRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updateRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", updateRecordSetsRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordSetsResponse>(response);
        }

        public AsyncInvoker<UpdateRecordSetsResponse> UpdateRecordSetsAsyncInvoker(UpdateRecordSetsRequest updateRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updateRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", updateRecordSetsRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetsRequest);
            return new AsyncInvoker<UpdateRecordSetsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordSetsResponse>);
        }
        
        /// <summary>
        /// 为指定实例批量添加或删除标签
        ///
        /// 为指定实例批量添加或删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateTagResponse> BatchCreateTagAsync(BatchCreateTagRequest batchCreateTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateTagResponse>(response);
        }

        public AsyncInvoker<BatchCreateTagResponse> BatchCreateTagAsyncInvoker(BatchCreateTagRequest batchCreateTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagRequest);
            return new AsyncInvoker<BatchCreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateTagResponse>);
        }
        
        /// <summary>
        /// 为指定实例添加标签
        ///
        /// 为指定实例添加标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public AsyncInvoker<CreateTagResponse> CreateTagAsyncInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new AsyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagRequest.ResourceId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public AsyncInvoker<DeleteTagResponse> DeleteTagAsyncInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagRequest.ResourceId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new AsyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 使用标签查询资源实例
        ///
        /// 使用标签查询资源实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagResponse> ListTagAsync(ListTagRequest listTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListTagResponse>(response);
        }

        public AsyncInvoker<ListTagResponse> ListTagAsyncInvoker(ListTagRequest listTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagRequest);
            return new AsyncInvoker<ListTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTagResponse>);
        }
        
        /// <summary>
        /// 查询指定实例类型的所有标签集合
        ///
        /// 查询指定实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public AsyncInvoker<ListTagsResponse> ListTagsAsyncInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new AsyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 查询指定实例的标签信息
        ///
        /// 查询指定实例的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceTagResponse> ShowResourceTagAsync(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", showResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceTagResponse>(response);
        }

        public AsyncInvoker<ShowResourceTagResponse> ShowResourceTagAsyncInvoker(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", showResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            return new AsyncInvoker<ShowResourceTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceTagResponse>);
        }
        
        /// <summary>
        /// 在内网Zone上关联VPC
        ///
        /// 在内网Zone上关联VPC
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRouterResponse> AssociateRouterAsync(AssociateRouterRequest associateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", associateRouterRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRouterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateRouterResponse>(response);
        }

        public AsyncInvoker<AssociateRouterResponse> AssociateRouterAsyncInvoker(AssociateRouterRequest associateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", associateRouterRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRouterRequest);
            return new AsyncInvoker<AssociateRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRouterResponse>);
        }
        
        /// <summary>
        /// 创建单个内网Zone
        ///
        /// 创建单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePrivateZoneResponse> CreatePrivateZoneAsync(CreatePrivateZoneRequest createPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateZoneRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateZoneResponse>(response);
        }

        public AsyncInvoker<CreatePrivateZoneResponse> CreatePrivateZoneAsyncInvoker(CreatePrivateZoneRequest createPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateZoneRequest);
            return new AsyncInvoker<CreatePrivateZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 创建单个公网Zone
        ///
        /// 创建单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePublicZoneResponse> CreatePublicZoneAsync(CreatePublicZoneRequest createPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPublicZoneRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePublicZoneResponse>(response);
        }

        public AsyncInvoker<CreatePublicZoneResponse> CreatePublicZoneAsyncInvoker(CreatePublicZoneRequest createPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPublicZoneRequest);
            return new AsyncInvoker<CreatePublicZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePublicZoneResponse>);
        }
        
        /// <summary>
        /// 删除单个内网Zone
        ///
        /// 删除单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePrivateZoneResponse> DeletePrivateZoneAsync(DeletePrivateZoneRequest deletePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deletePrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateZoneRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePrivateZoneResponse>(response);
        }

        public AsyncInvoker<DeletePrivateZoneResponse> DeletePrivateZoneAsyncInvoker(DeletePrivateZoneRequest deletePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deletePrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateZoneRequest);
            return new AsyncInvoker<DeletePrivateZoneResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 删除单个公网Zone
        ///
        /// 删除单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePublicZoneResponse> DeletePublicZoneAsync(DeletePublicZoneRequest deletePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deletePublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicZoneRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePublicZoneResponse>(response);
        }

        public AsyncInvoker<DeletePublicZoneResponse> DeletePublicZoneAsyncInvoker(DeletePublicZoneRequest deletePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deletePublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicZoneRequest);
            return new AsyncInvoker<DeletePublicZoneResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePublicZoneResponse>);
        }
        
        /// <summary>
        /// 在内网Zone上解关联VPC
        ///
        /// 在内网Zone上解关联VPC
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateRouterResponse> DisassociateRouterAsync(DisassociateRouterRequest disassociateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", disassociateRouterRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateRouterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateRouterResponse>(response);
        }

        public AsyncInvoker<DisassociateRouterResponse> DisassociateRouterAsyncInvoker(DisassociateRouterRequest disassociateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", disassociateRouterRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateRouterRequest);
            return new AsyncInvoker<DisassociateRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateRouterResponse>);
        }
        
        /// <summary>
        /// 查询内网Zone列表
        ///
        /// 查询内网Zone列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateZonesResponse> ListPrivateZonesAsync(ListPrivateZonesRequest listPrivateZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateZonesResponse>(response);
        }

        public AsyncInvoker<ListPrivateZonesResponse> ListPrivateZonesAsyncInvoker(ListPrivateZonesRequest listPrivateZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateZonesRequest);
            return new AsyncInvoker<ListPrivateZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateZonesResponse>);
        }
        
        /// <summary>
        /// 查询公网Zone列表
        ///
        /// 查询公网Zone列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicZonesResponse> ListPublicZonesAsync(ListPublicZonesRequest listPublicZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublicZonesResponse>(response);
        }

        public AsyncInvoker<ListPublicZonesResponse> ListPublicZonesAsyncInvoker(ListPublicZonesRequest listPublicZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZonesRequest);
            return new AsyncInvoker<ListPublicZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicZonesResponse>);
        }
        
        /// <summary>
        /// 查询单个内网Zone
        ///
        /// 查询单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateZoneResponse> ShowPrivateZoneAsync(ShowPrivateZoneRequest showPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateZoneResponse>(response);
        }

        public AsyncInvoker<ShowPrivateZoneResponse> ShowPrivateZoneAsyncInvoker(ShowPrivateZoneRequest showPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneRequest);
            return new AsyncInvoker<ShowPrivateZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateZoneResponse>);
        }
        
        /// <summary>
        /// 查询单个内网Zone的名称服务器
        ///
        /// 查询单个内网Zone的名称服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateZoneNameServerResponse> ShowPrivateZoneNameServerAsync(ShowPrivateZoneNameServerRequest showPrivateZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPrivateZoneNameServerRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneNameServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateZoneNameServerResponse>(response);
        }

        public AsyncInvoker<ShowPrivateZoneNameServerResponse> ShowPrivateZoneNameServerAsyncInvoker(ShowPrivateZoneNameServerRequest showPrivateZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPrivateZoneNameServerRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneNameServerRequest);
            return new AsyncInvoker<ShowPrivateZoneNameServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateZoneNameServerResponse>);
        }
        
        /// <summary>
        /// 查询单个公网Zone
        ///
        /// 查询单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicZoneResponse> ShowPublicZoneAsync(ShowPublicZoneRequest showPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicZoneResponse>(response);
        }

        public AsyncInvoker<ShowPublicZoneResponse> ShowPublicZoneAsyncInvoker(ShowPublicZoneRequest showPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneRequest);
            return new AsyncInvoker<ShowPublicZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicZoneResponse>);
        }
        
        /// <summary>
        /// 查询单个公网Zone的名称服务器
        ///
        /// 查询单个公网Zone的名称服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicZoneNameServerResponse> ShowPublicZoneNameServerAsync(ShowPublicZoneNameServerRequest showPublicZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPublicZoneNameServerRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneNameServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicZoneNameServerResponse>(response);
        }

        public AsyncInvoker<ShowPublicZoneNameServerResponse> ShowPublicZoneNameServerAsyncInvoker(ShowPublicZoneNameServerRequest showPublicZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPublicZoneNameServerRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneNameServerRequest);
            return new AsyncInvoker<ShowPublicZoneNameServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicZoneNameServerResponse>);
        }
        
        /// <summary>
        /// 修改单个内网Zone
        ///
        /// 修改单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateZoneResponse> UpdatePrivateZoneAsync(UpdatePrivateZoneRequest updatePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePrivateZoneResponse>(response);
        }

        public AsyncInvoker<UpdatePrivateZoneResponse> UpdatePrivateZoneAsyncInvoker(UpdatePrivateZoneRequest updatePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneRequest);
            return new AsyncInvoker<UpdatePrivateZoneResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 修改单个公网Zone
        ///
        /// 修改单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicZoneResponse> UpdatePublicZoneAsync(UpdatePublicZoneRequest updatePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePublicZoneResponse>(response);
        }

        public AsyncInvoker<UpdatePublicZoneResponse> UpdatePublicZoneAsyncInvoker(UpdatePublicZoneRequest updatePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneRequest);
            return new AsyncInvoker<UpdatePublicZoneResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePublicZoneResponse>);
        }
        
        /// <summary>
        /// 设置单个公网Zone状态
        ///
        /// 设置单个公网Zone状态，支持暂停、启用Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicZoneStatusResponse> UpdatePublicZoneStatusAsync(UpdatePublicZoneStatusRequest updatePublicZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePublicZoneStatusRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePublicZoneStatusResponse>(response);
        }

        public AsyncInvoker<UpdatePublicZoneStatusResponse> UpdatePublicZoneStatusAsyncInvoker(UpdatePublicZoneStatusRequest updatePublicZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePublicZoneStatusRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneStatusRequest);
            return new AsyncInvoker<UpdatePublicZoneStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePublicZoneStatusResponse>);
        }
        
    }
}