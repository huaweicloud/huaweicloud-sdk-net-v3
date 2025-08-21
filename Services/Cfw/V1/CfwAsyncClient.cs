using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cfw.V1.Model;

namespace HuaweiCloud.SDK.Cfw.V1
{
    public partial class CfwAsyncClient : Client
    {
        public static ClientBuilder<CfwAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CfwAsyncClient>();
        }

        
        /// <summary>
        /// 添加地址组成员
        ///
        /// 添加地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAddressItemResponse> AddAddressItemAsync(AddAddressItemRequest addAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressItemRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAddressItemResponse>(response);
        }

        public AsyncInvoker<AddAddressItemResponse> AddAddressItemAsyncInvoker(AddAddressItemRequest addAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressItemRequest);
            return new AsyncInvoker<AddAddressItemResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAddressItemResponse>);
        }
        
        /// <summary>
        /// 添加地址组
        ///
        /// 添加地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAddressSetResponse> AddAddressSetAsync(AddAddressSetRequest addAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAddressSetResponse>(response);
        }

        public AsyncInvoker<AddAddressSetResponse> AddAddressSetAsyncInvoker(AddAddressSetRequest addAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressSetRequest);
            return new AsyncInvoker<AddAddressSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAddressSetResponse>);
        }
        
        /// <summary>
        /// 创建黑白名单规则
        ///
        /// 创建黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddBlackWhiteListResponse> AddBlackWhiteListAsync(AddBlackWhiteListRequest addBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddBlackWhiteListResponse>(response);
        }

        public AsyncInvoker<AddBlackWhiteListResponse> AddBlackWhiteListAsyncInvoker(AddBlackWhiteListRequest addBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteListRequest);
            return new AsyncInvoker<AddBlackWhiteListResponse>(this, "POST", request, JsonUtils.DeSerialize<AddBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 添加域名组
        ///
        /// 添加域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDomainSetResponse> AddDomainSetAsync(AddDomainSetRequest addDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDomainSetResponse>(response);
        }

        public AsyncInvoker<AddDomainSetResponse> AddDomainSetAsyncInvoker(AddDomainSetRequest addDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainSetRequest);
            return new AsyncInvoker<AddDomainSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDomainSetResponse>);
        }
        
        /// <summary>
        /// 添加域名列表
        ///
        /// 添加域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDomainsResponse> AddDomainsAsync(AddDomainsRequest addDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", addDomainsRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDomainsResponse>(response);
        }

        public AsyncInvoker<AddDomainsResponse> AddDomainsAsyncInvoker(AddDomainsRequest addDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", addDomainsRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainsRequest);
            return new AsyncInvoker<AddDomainsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDomainsResponse>);
        }
        
        /// <summary>
        /// 创建日志配置
        ///
        /// 创建日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddLogConfigResponse> AddLogConfigAsync(AddLogConfigRequest addLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addLogConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddLogConfigResponse>(response);
        }

        public AsyncInvoker<AddLogConfigResponse> AddLogConfigAsyncInvoker(AddLogConfigRequest addLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addLogConfigRequest);
            return new AsyncInvoker<AddLogConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<AddLogConfigResponse>);
        }
        
        /// <summary>
        /// 新建服务成员
        ///
        /// 批量添加服务组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddServiceItemsResponse> AddServiceItemsAsync(AddServiceItemsRequest addServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceItemsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddServiceItemsResponse>(response);
        }

        public AsyncInvoker<AddServiceItemsResponse> AddServiceItemsAsyncInvoker(AddServiceItemsRequest addServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceItemsRequest);
            return new AsyncInvoker<AddServiceItemsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddServiceItemsResponse>);
        }
        
        /// <summary>
        /// 新建服务组
        ///
        /// 创建服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddServiceSetResponse> AddServiceSetAsync(AddServiceSetRequest addServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddServiceSetResponse>(response);
        }

        public AsyncInvoker<AddServiceSetResponse> AddServiceSetAsyncInvoker(AddServiceSetRequest addServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceSetRequest);
            return new AsyncInvoker<AddServiceSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddServiceSetResponse>);
        }
        
        /// <summary>
        /// 批量删除地址组成员
        ///
        /// 批量删除地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAddressItemsResponse> BatchDeleteAddressItemsAsync(BatchDeleteAddressItemsRequest batchDeleteAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressItemsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteAddressItemsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAddressItemsResponse> BatchDeleteAddressItemsAsyncInvoker(BatchDeleteAddressItemsRequest batchDeleteAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressItemsRequest);
            return new AsyncInvoker<BatchDeleteAddressItemsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteAddressItemsResponse>);
        }
        
        /// <summary>
        /// 批量删除域名组
        ///
        /// 批量删除域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteDomainSetResponse> BatchDeleteDomainSetAsync(BatchDeleteDomainSetRequest batchDeleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDomainSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteDomainSetResponse>(response);
        }

        public AsyncInvoker<BatchDeleteDomainSetResponse> BatchDeleteDomainSetAsyncInvoker(BatchDeleteDomainSetRequest batchDeleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDomainSetRequest);
            return new AsyncInvoker<BatchDeleteDomainSetResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteDomainSetResponse>);
        }
        
        /// <summary>
        /// 批量删除服务组成员信息
        ///
        /// 批量删除服务组成员信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteServiceItemsResponse> BatchDeleteServiceItemsAsync(BatchDeleteServiceItemsRequest batchDeleteServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceItemsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteServiceItemsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteServiceItemsResponse> BatchDeleteServiceItemsAsyncInvoker(BatchDeleteServiceItemsRequest batchDeleteServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceItemsRequest);
            return new AsyncInvoker<BatchDeleteServiceItemsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteServiceItemsResponse>);
        }
        
        /// <summary>
        /// 取消抓包任务
        ///
        /// 取消抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelCaptureTaskResponse> CancelCaptureTaskAsync(CancelCaptureTaskRequest cancelCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelCaptureTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CancelCaptureTaskResponse>(response);
        }

        public AsyncInvoker<CancelCaptureTaskResponse> CancelCaptureTaskAsyncInvoker(CancelCaptureTaskRequest cancelCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelCaptureTaskRequest);
            return new AsyncInvoker<CancelCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 创建抓包任务
        ///
        /// 创建抓包任务，每个任务只能执行一次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCaptureTaskResponse> CreateCaptureTaskAsync(CreateCaptureTaskRequest createCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCaptureTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCaptureTaskResponse>(response);
        }

        public AsyncInvoker<CreateCaptureTaskResponse> CreateCaptureTaskAsyncInvoker(CreateCaptureTaskRequest createCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCaptureTaskRequest);
            return new AsyncInvoker<CreateCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 创建东西向防火墙
        ///
        /// 创建东西向防火墙
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEastWestFirewallResponse> CreateEastWestFirewallAsync(CreateEastWestFirewallRequest createEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEastWestFirewallRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEastWestFirewallResponse>(response);
        }

        public AsyncInvoker<CreateEastWestFirewallResponse> CreateEastWestFirewallAsyncInvoker(CreateEastWestFirewallRequest createEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEastWestFirewallRequest);
            return new AsyncInvoker<CreateEastWestFirewallResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEastWestFirewallResponse>);
        }
        
        /// <summary>
        /// 创建防火墙
        ///
        /// 创建防火墙
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFirewallResponse> CreateFirewallAsync(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFirewallResponse>(response);
        }

        public AsyncInvoker<CreateFirewallResponse> CreateFirewallAsyncInvoker(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            return new AsyncInvoker<CreateFirewallResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFirewallResponse>);
        }
        
        /// <summary>
        /// 标签创建接口
        ///
        /// 创建标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", createTagRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public AsyncInvoker<CreateTagResponse> CreateTagAsyncInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", createTagRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new AsyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除地址组成员
        ///
        /// 删除地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAddressItemResponse> DeleteAddressItemAsync(DeleteAddressItemRequest deleteAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id", deleteAddressItemRequest.ItemId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressItemRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAddressItemResponse>(response);
        }

        public AsyncInvoker<DeleteAddressItemResponse> DeleteAddressItemAsyncInvoker(DeleteAddressItemRequest deleteAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id", deleteAddressItemRequest.ItemId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressItemRequest);
            return new AsyncInvoker<DeleteAddressItemResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAddressItemResponse>);
        }
        
        /// <summary>
        /// 删除地址组
        ///
        /// 删除地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAddressSetResponse> DeleteAddressSetAsync(DeleteAddressSetRequest deleteAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteAddressSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAddressSetResponse>(response);
        }

        public AsyncInvoker<DeleteAddressSetResponse> DeleteAddressSetAsyncInvoker(DeleteAddressSetRequest deleteAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteAddressSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressSetRequest);
            return new AsyncInvoker<DeleteAddressSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAddressSetResponse>);
        }
        
        /// <summary>
        /// 删除黑白名单规则
        ///
        /// 删除黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBlackWhiteListResponse> DeleteBlackWhiteListAsync(DeleteBlackWhiteListRequest deleteBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id", deleteBlackWhiteListRequest.ListId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteListRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBlackWhiteListResponse>(response);
        }

        public AsyncInvoker<DeleteBlackWhiteListResponse> DeleteBlackWhiteListAsyncInvoker(DeleteBlackWhiteListRequest deleteBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id", deleteBlackWhiteListRequest.ListId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteListRequest);
            return new AsyncInvoker<DeleteBlackWhiteListResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 批量删除抓包任务
        ///
        /// 批量删除抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCaptureTaskResponse> DeleteCaptureTaskAsync(DeleteCaptureTaskRequest deleteCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCaptureTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteCaptureTaskResponse>(response);
        }

        public AsyncInvoker<DeleteCaptureTaskResponse> DeleteCaptureTaskAsyncInvoker(DeleteCaptureTaskRequest deleteCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCaptureTaskRequest);
            return new AsyncInvoker<DeleteCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 删除域名组
        ///
        /// 删除域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainSetResponse> DeleteDomainSetAsync(DeleteDomainSetRequest deleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteDomainSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainSetResponse>(response);
        }

        public AsyncInvoker<DeleteDomainSetResponse> DeleteDomainSetAsyncInvoker(DeleteDomainSetRequest deleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteDomainSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainSetRequest);
            return new AsyncInvoker<DeleteDomainSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainSetResponse>);
        }
        
        /// <summary>
        /// 删除域名列表
        ///
        /// 删除域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainsResponse> DeleteDomainsAsync(DeleteDomainsRequest deleteDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteDomainsRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainsResponse>(response);
        }

        public AsyncInvoker<DeleteDomainsResponse> DeleteDomainsAsyncInvoker(DeleteDomainsRequest deleteDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteDomainsRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainsRequest);
            return new AsyncInvoker<DeleteDomainsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainsResponse>);
        }
        
        /// <summary>
        /// 删除防火墙
        ///
        /// 删除防火墙，仅按需生效
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFirewallResponse> DeleteFirewallAsync(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteFirewallRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFirewallResponse>(response);
        }

        public AsyncInvoker<DeleteFirewallResponse> DeleteFirewallAsyncInvoker(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteFirewallRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            return new AsyncInvoker<DeleteFirewallResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFirewallResponse>);
        }
        
        /// <summary>
        /// 删除已经导入的IP黑名单
        ///
        /// 删除流量过滤功能下已经导入的IP黑名单，指定生效范围进行删除。 标准版的墙只会存在生效范围为EIP的IP黑名单，专业版的墙会存在生效范围为EIP和NAT的IP黑名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteIpBlacklistResponse> DeleteIpBlacklistAsync(DeleteIpBlacklistRequest deleteIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpBlacklistRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteIpBlacklistResponse>(response);
        }

        public AsyncInvoker<DeleteIpBlacklistResponse> DeleteIpBlacklistAsyncInvoker(DeleteIpBlacklistRequest deleteIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpBlacklistRequest);
            return new AsyncInvoker<DeleteIpBlacklistResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 删除服务成员
        ///
        /// 删除服务组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServiceItemResponse> DeleteServiceItemAsync(DeleteServiceItemRequest deleteServiceItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id", deleteServiceItemRequest.ItemId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceItemRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceItemResponse>(response);
        }

        public AsyncInvoker<DeleteServiceItemResponse> DeleteServiceItemAsyncInvoker(DeleteServiceItemRequest deleteServiceItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id", deleteServiceItemRequest.ItemId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceItemRequest);
            return new AsyncInvoker<DeleteServiceItemResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceItemResponse>);
        }
        
        /// <summary>
        /// 删除服务组
        ///
        /// 删除服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServiceSetResponse> DeleteServiceSetAsync(DeleteServiceSetRequest deleteServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteServiceSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceSetResponse>(response);
        }

        public AsyncInvoker<DeleteServiceSetResponse> DeleteServiceSetAsyncInvoker(DeleteServiceSetRequest deleteServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteServiceSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceSetRequest);
            return new AsyncInvoker<DeleteServiceSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceSetResponse>);
        }
        
        /// <summary>
        /// 删除标签
        ///
        /// 删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", deleteTagRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public AsyncInvoker<DeleteTagResponse> DeleteTagAsyncInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", deleteTagRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new AsyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 开启或者关闭流量过滤的IP黑名单功能
        ///
        /// 开启或者关闭流量过滤功能，当前流量过滤是通过导入IP黑名单实现的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableIpBlacklistResponse> EnableIpBlacklistAsync(EnableIpBlacklistRequest enableIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableIpBlacklistRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableIpBlacklistResponse>(response);
        }

        public AsyncInvoker<EnableIpBlacklistResponse> EnableIpBlacklistAsyncInvoker(EnableIpBlacklistRequest enableIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableIpBlacklistRequest);
            return new AsyncInvoker<EnableIpBlacklistResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 导出用于流量过滤的IP黑名单
        ///
        /// 指定IP黑名单的名字进行导出，当前只有两种文件名，在EIP生效的文件名为ip-blacklist-eip.txt，在 NAT生效的文件名为ip-blacklist-nat.txt。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportIpBlacklistResponse> ExportIpBlacklistAsync(ExportIpBlacklistRequest exportIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportIpBlacklistRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ExportIpBlacklistResponse>(response);
        }

        public AsyncInvoker<ExportIpBlacklistResponse> ExportIpBlacklistAsyncInvoker(ExportIpBlacklistRequest exportIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportIpBlacklistRequest);
            return new AsyncInvoker<ExportIpBlacklistResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExportIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 导入IP黑名单用于流量过滤
        ///
        /// 此接口用来导入IP黑名单，IP列表保存在request的body中，IP列表支持的格式如下：
        /// 单个IP地址，例如：100.1.1.10
        /// 连续的IP地址段，例如：80.1.1.3-80.1.1.30
        /// 掩码格式的网段，例如：6.6.6.0/24
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportIpBlacklistResponse> ImportIpBlacklistAsync(ImportIpBlacklistRequest importIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importIpBlacklistRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ImportIpBlacklistResponse>(response);
        }

        public AsyncInvoker<ImportIpBlacklistResponse> ImportIpBlacklistAsyncInvoker(ImportIpBlacklistRequest importIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importIpBlacklistRequest);
            return new AsyncInvoker<ImportIpBlacklistResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ImportIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 查询访问控制日志
        ///
        /// 查询访问控制日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessControlLogsResponse> ListAccessControlLogsAsync(ListAccessControlLogsRequest listAccessControlLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessControlLogsResponse>(response);
        }

        public AsyncInvoker<ListAccessControlLogsResponse> ListAccessControlLogsAsyncInvoker(ListAccessControlLogsRequest listAccessControlLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlLogsRequest);
            return new AsyncInvoker<ListAccessControlLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessControlLogsResponse>);
        }
        
        /// <summary>
        /// 查询地址组成员
        ///
        /// 查询地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddressItemsResponse> ListAddressItemsAsync(ListAddressItemsRequest listAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressItemsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAddressItemsResponse>(response);
        }

        public AsyncInvoker<ListAddressItemsResponse> ListAddressItemsAsyncInvoker(ListAddressItemsRequest listAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressItemsRequest);
            return new AsyncInvoker<ListAddressItemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressItemsResponse>);
        }
        
        /// <summary>
        /// 查询地址组详细信息
        ///
        /// 查询地址组详细
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddressSetDetailResponse> ListAddressSetDetailAsync(ListAddressSetDetailRequest listAddressSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", listAddressSetDetailRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAddressSetDetailResponse>(response);
        }

        public AsyncInvoker<ListAddressSetDetailResponse> ListAddressSetDetailAsyncInvoker(ListAddressSetDetailRequest listAddressSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", listAddressSetDetailRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetDetailRequest);
            return new AsyncInvoker<ListAddressSetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressSetDetailResponse>);
        }
        
        /// <summary>
        /// 查询地址组列表
        ///
        /// 查询地址组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddressSetsResponse> ListAddressSetsAsync(ListAddressSetsRequest listAddressSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAddressSetsResponse>(response);
        }

        public AsyncInvoker<ListAddressSetsResponse> ListAddressSetsAsyncInvoker(ListAddressSetsRequest listAddressSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetsRequest);
            return new AsyncInvoker<ListAddressSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressSetsResponse>);
        }
        
        /// <summary>
        /// 查询攻击日志
        ///
        /// 查询攻击日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAttackLogsResponse> ListAttackLogsAsync(ListAttackLogsRequest listAttackLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAttackLogsResponse>(response);
        }

        public AsyncInvoker<ListAttackLogsResponse> ListAttackLogsAsyncInvoker(ListAttackLogsRequest listAttackLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackLogsRequest);
            return new AsyncInvoker<ListAttackLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAttackLogsResponse>);
        }
        
        /// <summary>
        /// 查询黑白名单列表
        ///
        /// 查询黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBlackWhiteListsResponse> ListBlackWhiteListsAsync(ListBlackWhiteListsRequest listBlackWhiteListsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlackWhiteListsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBlackWhiteListsResponse>(response);
        }

        public AsyncInvoker<ListBlackWhiteListsResponse> ListBlackWhiteListsAsyncInvoker(ListBlackWhiteListsRequest listBlackWhiteListsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlackWhiteListsRequest);
            return new AsyncInvoker<ListBlackWhiteListsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBlackWhiteListsResponse>);
        }
        
        /// <summary>
        /// 获取抓包任务结果
        ///
        /// 获取抓包任务结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCaptureResultResponse> ListCaptureResultAsync(ListCaptureResultRequest listCaptureResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/capture-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCaptureResultResponse>(response);
        }

        public AsyncInvoker<ListCaptureResultResponse> ListCaptureResultAsyncInvoker(ListCaptureResultRequest listCaptureResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/capture-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureResultRequest);
            return new AsyncInvoker<ListCaptureResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCaptureResultResponse>);
        }
        
        /// <summary>
        /// 查询抓包任务
        ///
        /// 查询抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCaptureTaskResponse> ListCaptureTaskAsync(ListCaptureTaskRequest listCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCaptureTaskResponse>(response);
        }

        public AsyncInvoker<ListCaptureTaskResponse> ListCaptureTaskAsyncInvoker(ListCaptureTaskRequest listCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureTaskRequest);
            return new AsyncInvoker<ListCaptureTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 查询dns服务器列表
        ///
        /// 查询dns服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDnsServersResponse> ListDnsServersAsync(ListDnsServersRequest listDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDnsServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDnsServersResponse>(response);
        }

        public AsyncInvoker<ListDnsServersResponse> ListDnsServersAsyncInvoker(ListDnsServersRequest listDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDnsServersRequest);
            return new AsyncInvoker<ListDnsServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDnsServersResponse>);
        }
        
        /// <summary>
        /// 查询域名解析ip地址
        ///
        /// 测试域名有效性
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainParseDetailResponse> ListDomainParseDetailAsync(ListDomainParseDetailRequest listDomainParseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listDomainParseDetailRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainParseDetailResponse>(response);
        }

        public AsyncInvoker<ListDomainParseDetailResponse> ListDomainParseDetailAsyncInvoker(ListDomainParseDetailRequest listDomainParseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listDomainParseDetailRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseDetailRequest);
            return new AsyncInvoker<ListDomainParseDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainParseDetailResponse>);
        }
        
        /// <summary>
        /// 获取域名地址解析结果
        ///
        /// 获取域名地址解析结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainParseIpResponse> ListDomainParseIpAsync(ListDomainParseIpRequest listDomainParseIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_address_id", listDomainParseIpRequest.DomainAddressId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse-ip-list/{domain_address_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseIpRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainParseIpResponse>(response);
        }

        public AsyncInvoker<ListDomainParseIpResponse> ListDomainParseIpAsyncInvoker(ListDomainParseIpRequest listDomainParseIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_address_id", listDomainParseIpRequest.DomainAddressId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse-ip-list/{domain_address_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseIpRequest);
            return new AsyncInvoker<ListDomainParseIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainParseIpResponse>);
        }
        
        /// <summary>
        /// 查询域名组列表
        ///
        /// 查询域名组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainSetsResponse> ListDomainSetsAsync(ListDomainSetsRequest listDomainSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainSetsResponse>(response);
        }

        public AsyncInvoker<ListDomainSetsResponse> ListDomainSetsAsyncInvoker(ListDomainSetsRequest listDomainSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainSetsRequest);
            return new AsyncInvoker<ListDomainSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainSetsResponse>);
        }
        
        /// <summary>
        /// 获取域名组下域名列表
        ///
        /// 获取域名组下域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_set_id", listDomainsRequest.DomainSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }

        public AsyncInvoker<ListDomainsResponse> ListDomainsAsyncInvoker(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_set_id", listDomainsRequest.DomainSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            return new AsyncInvoker<ListDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainsResponse>);
        }
        
        /// <summary>
        /// 获取东西向防火墙信息
        ///
        /// 获取东西向防火墙信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEastWestFirewallResponse> ListEastWestFirewallAsync(ListEastWestFirewallRequest listEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEastWestFirewallRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEastWestFirewallResponse>(response);
        }

        public AsyncInvoker<ListEastWestFirewallResponse> ListEastWestFirewallAsyncInvoker(ListEastWestFirewallRequest listEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEastWestFirewallRequest);
            return new AsyncInvoker<ListEastWestFirewallResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEastWestFirewallResponse>);
        }
        
        /// <summary>
        /// 查询防火墙详细信息
        ///
        /// 查询防火墙实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFirewallDetailResponse> ListFirewallDetailAsync(ListFirewallDetailRequest listFirewallDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFirewallDetailResponse>(response);
        }

        public AsyncInvoker<ListFirewallDetailResponse> ListFirewallDetailAsyncInvoker(ListFirewallDetailRequest listFirewallDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallDetailRequest);
            return new AsyncInvoker<ListFirewallDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFirewallDetailResponse>);
        }
        
        /// <summary>
        /// 查询防火墙列表
        ///
        /// 查询防火墙列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFirewallListResponse> ListFirewallListAsync(ListFirewallListRequest listFirewallListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewalls/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListFirewallListResponse>(response);
        }

        public AsyncInvoker<ListFirewallListResponse> ListFirewallListAsyncInvoker(ListFirewallListRequest listFirewallListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewalls/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallListRequest);
            return new AsyncInvoker<ListFirewallListResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFirewallListResponse>);
        }
        
        /// <summary>
        /// 查询流日志
        ///
        /// 查询流日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlowLogsResponse> ListFlowLogsAsync(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlowLogsResponse>(response);
        }

        public AsyncInvoker<ListFlowLogsResponse> ListFlowLogsAsyncInvoker(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            return new AsyncInvoker<ListFlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取导入的IP黑名单列表信息
        ///
        /// 获取防火墙实例中已经导入的IP黑名单信息，标准版防火墙只会显示一条EIP的记录，专业版防火墙可能显示EIP、NAT或EIP和NAT的记录，根据导入的情况确定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpBlacklistResponse> ListIpBlacklistAsync(ListIpBlacklistRequest listIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpBlacklistRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpBlacklistResponse>(response);
        }

        public AsyncInvoker<ListIpBlacklistResponse> ListIpBlacklistAsyncInvoker(ListIpBlacklistRequest listIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpBlacklistRequest);
            return new AsyncInvoker<ListIpBlacklistResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 获取流量过滤功能的开关信息
        ///
        /// 流量过滤功能可以打开或者关闭，通过此接口可以获取当前的开关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpBlacklistSwitchResponse> ListIpBlacklistSwitchAsync(ListIpBlacklistSwitchRequest listIpBlacklistSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpBlacklistSwitchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpBlacklistSwitchResponse>(response);
        }

        public AsyncInvoker<ListIpBlacklistSwitchResponse> ListIpBlacklistSwitchAsyncInvoker(ListIpBlacklistSwitchRequest listIpBlacklistSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpBlacklistSwitchRequest);
            return new AsyncInvoker<ListIpBlacklistSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpBlacklistSwitchResponse>);
        }
        
        /// <summary>
        /// 获取CFW任务执行状态
        ///
        /// 获取CFW任务执行状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobResponse> ListJobAsync(ListJobRequest listJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobResponse>(response);
        }

        public AsyncInvoker<ListJobResponse> ListJobAsyncInvoker(ListJobRequest listJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobRequest);
            return new AsyncInvoker<ListJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobResponse>);
        }
        
        /// <summary>
        /// 获取日志配置
        ///
        /// 获取日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogConfigResponse> ListLogConfigAsync(ListLogConfigRequest listLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLogConfigResponse>(response);
        }

        public AsyncInvoker<ListLogConfigResponse> ListLogConfigAsyncInvoker(ListLogConfigRequest listLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogConfigRequest);
            return new AsyncInvoker<ListLogConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogConfigResponse>);
        }
        
        /// <summary>
        /// 查询标签信息
        ///
        /// 查询标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public AsyncInvoker<ListProjectTagsResponse> ListProjectTagsAsyncInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new AsyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询防护VPC数
        ///
        /// 查询防护vpc信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProtectedVpcsResponse> ListProtectedVpcsAsync(ListProtectedVpcsRequest listProtectedVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/protection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedVpcsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProtectedVpcsResponse>(response);
        }

        public AsyncInvoker<ListProtectedVpcsResponse> ListProtectedVpcsAsyncInvoker(ListProtectedVpcsRequest listProtectedVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/protection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedVpcsRequest);
            return new AsyncInvoker<ListProtectedVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProtectedVpcsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签信息
        ///
        /// 查询资源标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", listResourceTagsRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListResourceTagsResponse> ListResourceTagsAsyncInvoker(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", listResourceTagsRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            return new AsyncInvoker<ListResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询服务成员列表
        ///
        /// 查询服务组成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceItemsResponse> ListServiceItemsAsync(ListServiceItemsRequest listServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceItemsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServiceItemsResponse>(response);
        }

        public AsyncInvoker<ListServiceItemsResponse> ListServiceItemsAsyncInvoker(ListServiceItemsRequest listServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceItemsRequest);
            return new AsyncInvoker<ListServiceItemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceItemsResponse>);
        }
        
        /// <summary>
        /// 查询服务组详情
        ///
        /// 查询服务组细节
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceSetDetailResponse> ListServiceSetDetailAsync(ListServiceSetDetailRequest listServiceSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", listServiceSetDetailRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServiceSetDetailResponse>(response);
        }

        public AsyncInvoker<ListServiceSetDetailResponse> ListServiceSetDetailAsyncInvoker(ListServiceSetDetailRequest listServiceSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", listServiceSetDetailRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetDetailRequest);
            return new AsyncInvoker<ListServiceSetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceSetDetailResponse>);
        }
        
        /// <summary>
        /// 获取服务组列表
        ///
        /// 获取服务组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceSetsResponse> ListServiceSetsAsync(ListServiceSetsRequest listServiceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServiceSetsResponse>(response);
        }

        public AsyncInvoker<ListServiceSetsResponse> ListServiceSetsAsyncInvoker(ListServiceSetsRequest listServiceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetsRequest);
            return new AsyncInvoker<ListServiceSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceSetsResponse>);
        }
        
        /// <summary>
        /// 用于流量过滤的IP黑名单导入失败后进行重新导入
        ///
        /// 用于流量过滤的IP黑名单导入失败后，调用此接口进行重试。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryIpBlacklistResponse> RetryIpBlacklistAsync(RetryIpBlacklistRequest retryIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryIpBlacklistRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RetryIpBlacklistResponse>(response);
        }

        public AsyncInvoker<RetryIpBlacklistResponse> RetryIpBlacklistAsyncInvoker(RetryIpBlacklistRequest retryIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryIpBlacklistRequest);
            return new AsyncInvoker<RetryIpBlacklistResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 保存资源标签接口
        ///
        /// 保存资源标签接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SaveTagsResponse> SaveTagsAsync(SaveTagsRequest saveTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", saveTagsRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/save", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTagsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SaveTagsResponse>(response);
        }

        public AsyncInvoker<SaveTagsResponse> SaveTagsAsyncInvoker(SaveTagsRequest saveTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", saveTagsRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/save", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTagsRequest);
            return new AsyncInvoker<SaveTagsResponse>(this, "PUT", request, JsonUtils.DeSerialize<SaveTagsResponse>);
        }
        
        /// <summary>
        /// 获取告警配置信息
        ///
        /// 获取告警配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAlarmConfigResponse> ShowAlarmConfigAsync(ShowAlarmConfigRequest showAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/alarm/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmConfigResponse>(response);
        }

        public AsyncInvoker<ShowAlarmConfigResponse> ShowAlarmConfigAsyncInvoker(ShowAlarmConfigRequest showAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/alarm/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            return new AsyncInvoker<ShowAlarmConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmConfigResponse>);
        }
        
        /// <summary>
        /// 获取防火墙反病毒规则信息
        ///
        /// 获取防火墙反病毒规则信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAntiVirusRuleResponse> ShowAntiVirusRuleAsync(ShowAntiVirusRuleRequest showAntiVirusRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAntiVirusRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAntiVirusRuleResponse>(response);
        }

        public AsyncInvoker<ShowAntiVirusRuleResponse> ShowAntiVirusRuleAsyncInvoker(ShowAntiVirusRuleRequest showAntiVirusRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAntiVirusRuleRequest);
            return new AsyncInvoker<ShowAntiVirusRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAntiVirusRuleResponse>);
        }
        
        /// <summary>
        /// 查看反病毒开关
        ///
        /// 查看反病毒开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAntiVirusSwitchResponse> ShowAntiVirusSwitchAsync(ShowAntiVirusSwitchRequest showAntiVirusSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAntiVirusSwitchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAntiVirusSwitchResponse>(response);
        }

        public AsyncInvoker<ShowAntiVirusSwitchResponse> ShowAntiVirusSwitchAsyncInvoker(ShowAntiVirusSwitchRequest showAntiVirusSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAntiVirusSwitchRequest);
            return new AsyncInvoker<ShowAntiVirusSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAntiVirusSwitchResponse>);
        }
        
        /// <summary>
        /// 查看域名组详情
        ///
        /// 查看域名组详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainSetDetailResponse> ShowDomainSetDetailAsync(ShowDomainSetDetailRequest showDomainSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_set_id", showDomainSetDetailRequest.DomainSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainSetDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainSetDetailResponse>(response);
        }

        public AsyncInvoker<ShowDomainSetDetailResponse> ShowDomainSetDetailAsyncInvoker(ShowDomainSetDetailRequest showDomainSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_set_id", showDomainSetDetailRequest.DomainSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainSetDetailRequest);
            return new AsyncInvoker<ShowDomainSetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainSetDetailResponse>);
        }
        
        /// <summary>
        /// 更新地址组信息
        ///
        /// 更新地址组信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAddressSetResponse> UpdateAddressSetAsync(UpdateAddressSetRequest updateAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateAddressSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddressSetResponse>(response);
        }

        public AsyncInvoker<UpdateAddressSetResponse> UpdateAddressSetAsyncInvoker(UpdateAddressSetRequest updateAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateAddressSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressSetRequest);
            return new AsyncInvoker<UpdateAddressSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddressSetResponse>);
        }
        
        /// <summary>
        /// 修改告警配置接口
        ///
        /// 修改告警配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmConfigResponse> UpdateAlarmConfigAsync(UpdateAlarmConfigRequest updateAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/alarm/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAlarmConfigResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmConfigResponse> UpdateAlarmConfigAsyncInvoker(UpdateAlarmConfigRequest updateAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/alarm/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            return new AsyncInvoker<UpdateAlarmConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAlarmConfigResponse>);
        }
        
        /// <summary>
        /// 修改反病毒规则
        ///
        /// 修改反病毒规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAntiVirusRuleResponse> UpdateAntiVirusRuleAsync(UpdateAntiVirusRuleRequest updateAntiVirusRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAntiVirusRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAntiVirusRuleResponse>(response);
        }

        public AsyncInvoker<UpdateAntiVirusRuleResponse> UpdateAntiVirusRuleAsyncInvoker(UpdateAntiVirusRuleRequest updateAntiVirusRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAntiVirusRuleRequest);
            return new AsyncInvoker<UpdateAntiVirusRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAntiVirusRuleResponse>);
        }
        
        /// <summary>
        /// 修改反病毒开关
        ///
        /// 修改反病毒开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAntiVirusSwitchResponse> UpdateAntiVirusSwitchAsync(UpdateAntiVirusSwitchRequest updateAntiVirusSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAntiVirusSwitchRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAntiVirusSwitchResponse>(response);
        }

        public AsyncInvoker<UpdateAntiVirusSwitchResponse> UpdateAntiVirusSwitchAsyncInvoker(UpdateAntiVirusSwitchRequest updateAntiVirusSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAntiVirusSwitchRequest);
            return new AsyncInvoker<UpdateAntiVirusSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAntiVirusSwitchResponse>);
        }
        
        /// <summary>
        /// 更新黑白名单列表
        ///
        /// 更新黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBlackWhiteListResponse> UpdateBlackWhiteListAsync(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id", updateBlackWhiteListRequest.ListId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }

        public AsyncInvoker<UpdateBlackWhiteListResponse> UpdateBlackWhiteListAsyncInvoker(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id", updateBlackWhiteListRequest.ListId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            return new AsyncInvoker<UpdateBlackWhiteListResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 更新dns服务器列表
        ///
        /// 更新dns服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDnsServersResponse> UpdateDnsServersAsync(UpdateDnsServersRequest updateDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsServersRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDnsServersResponse>(response);
        }

        public AsyncInvoker<UpdateDnsServersResponse> UpdateDnsServersAsyncInvoker(UpdateDnsServersRequest updateDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsServersRequest);
            return new AsyncInvoker<UpdateDnsServersResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDnsServersResponse>);
        }
        
        /// <summary>
        /// 更新域名组
        ///
        /// 更新域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainSetResponse> UpdateDomainSetAsync(UpdateDomainSetRequest updateDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateDomainSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainSetResponse>(response);
        }

        public AsyncInvoker<UpdateDomainSetResponse> UpdateDomainSetAsyncInvoker(UpdateDomainSetRequest updateDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateDomainSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainSetRequest);
            return new AsyncInvoker<UpdateDomainSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainSetResponse>);
        }
        
        /// <summary>
        /// 更新日志配置
        ///
        /// 更新日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLogConfigResponse> UpdateLogConfigAsync(UpdateLogConfigRequest updateLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogConfigResponse>(response);
        }

        public AsyncInvoker<UpdateLogConfigResponse> UpdateLogConfigAsyncInvoker(UpdateLogConfigRequest updateLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConfigRequest);
            return new AsyncInvoker<UpdateLogConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogConfigResponse>);
        }
        
        /// <summary>
        /// 编辑对象组内成员的描述信息
        ///
        /// 编辑对象组内成员的描述信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateObjectConfigDescResponse> UpdateObjectConfigDescAsync(UpdateObjectConfigDescRequest updateObjectConfigDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/config/object/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateObjectConfigDescRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateObjectConfigDescResponse>(response);
        }

        public AsyncInvoker<UpdateObjectConfigDescResponse> UpdateObjectConfigDescAsyncInvoker(UpdateObjectConfigDescRequest updateObjectConfigDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/config/object/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateObjectConfigDescRequest);
            return new AsyncInvoker<UpdateObjectConfigDescResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateObjectConfigDescResponse>);
        }
        
        /// <summary>
        /// 修改服务组
        ///
        /// 更新服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServiceSetResponse> UpdateServiceSetAsync(UpdateServiceSetRequest updateServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateServiceSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateServiceSetResponse>(response);
        }

        public AsyncInvoker<UpdateServiceSetResponse> UpdateServiceSetAsyncInvoker(UpdateServiceSetRequest updateServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateServiceSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceSetRequest);
            return new AsyncInvoker<UpdateServiceSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateServiceSetResponse>);
        }
        
        /// <summary>
        /// 创建ACL规则
        ///
        /// 创建ACL规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAclRuleResponse> AddAclRuleAsync(AddAclRuleRequest addAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAclRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAclRuleResponse>(response);
        }

        public AsyncInvoker<AddAclRuleResponse> AddAclRuleAsyncInvoker(AddAclRuleRequest addAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAclRuleRequest);
            return new AsyncInvoker<AddAclRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAclRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除Acl规则
        ///
        /// 批量删除Acl规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAclRulesResponse> BatchDeleteAclRulesAsync(BatchDeleteAclRulesRequest batchDeleteAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAclRulesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteAclRulesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAclRulesResponse> BatchDeleteAclRulesAsyncInvoker(BatchDeleteAclRulesRequest batchDeleteAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAclRulesRequest);
            return new AsyncInvoker<BatchDeleteAclRulesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteAclRulesResponse>);
        }
        
        /// <summary>
        /// 批量更新规则动作
        ///
        /// 批量更新规则动作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateAclRuleActionsResponse> BatchUpdateAclRuleActionsAsync(BatchUpdateAclRuleActionsRequest batchUpdateAclRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAclRuleActionsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateAclRuleActionsResponse>(response);
        }

        public AsyncInvoker<BatchUpdateAclRuleActionsResponse> BatchUpdateAclRuleActionsAsyncInvoker(BatchUpdateAclRuleActionsRequest batchUpdateAclRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAclRuleActionsRequest);
            return new AsyncInvoker<BatchUpdateAclRuleActionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateAclRuleActionsResponse>);
        }
        
        /// <summary>
        /// 删除ACL规则
        ///
        /// 删除ACL规则组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAclRuleResponse> DeleteAclRuleAsync(DeleteAclRuleRequest deleteAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", deleteAclRuleRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAclRuleResponse>(response);
        }

        public AsyncInvoker<DeleteAclRuleResponse> DeleteAclRuleAsyncInvoker(DeleteAclRuleRequest deleteAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", deleteAclRuleRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleRequest);
            return new AsyncInvoker<DeleteAclRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAclRuleResponse>);
        }
        
        /// <summary>
        /// 删除规则击中次数
        ///
        /// 清除规则击中次数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAclRuleHitCountResponse> DeleteAclRuleHitCountAsync(DeleteAclRuleHitCountRequest deleteAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleHitCountRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAclRuleHitCountResponse>(response);
        }

        public AsyncInvoker<DeleteAclRuleHitCountResponse> DeleteAclRuleHitCountAsyncInvoker(DeleteAclRuleHitCountRequest deleteAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleHitCountRequest);
            return new AsyncInvoker<DeleteAclRuleHitCountResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAclRuleHitCountResponse>);
        }
        
        /// <summary>
        /// 获取规则击中次数
        ///
        /// 获取规则击中次数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAclRuleHitCountResponse> ListAclRuleHitCountAsync(ListAclRuleHitCountRequest listAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitCountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAclRuleHitCountResponse>(response);
        }

        public AsyncInvoker<ListAclRuleHitCountResponse> ListAclRuleHitCountAsyncInvoker(ListAclRuleHitCountRequest listAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitCountRequest);
            return new AsyncInvoker<ListAclRuleHitCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAclRuleHitCountResponse>);
        }
        
        /// <summary>
        /// 查询防护规则
        ///
        /// 查询防护规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAclRulesResponse> ListAclRulesAsync(ListAclRulesRequest listAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAclRulesResponse>(response);
        }

        public AsyncInvoker<ListAclRulesResponse> ListAclRulesAsyncInvoker(ListAclRulesRequest listAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRulesRequest);
            return new AsyncInvoker<ListAclRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAclRulesResponse>);
        }
        
        /// <summary>
        /// 查看region列表
        ///
        /// 查看region列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRegionsResponse>(response);
        }

        public AsyncInvoker<ListRegionsResponse> ListRegionsAsyncInvoker(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            return new AsyncInvoker<ListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionsResponse>);
        }
        
        /// <summary>
        /// 查询规则标签
        ///
        /// 查询规则标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRuleAclTagsResponse> ListRuleAclTagsAsync(ListRuleAclTagsRequest listRuleAclTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-acl/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRuleAclTagsResponse>(response);
        }

        public AsyncInvoker<ListRuleAclTagsResponse> ListRuleAclTagsAsyncInvoker(ListRuleAclTagsRequest listRuleAclTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-acl/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclTagsRequest);
            return new AsyncInvoker<ListRuleAclTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleAclTagsResponse>);
        }
        
        /// <summary>
        /// 查看导入状态接口
        ///
        /// 查看导入状态接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImportStatusResponse> ShowImportStatusAsync(ShowImportStatusRequest showImportStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImportStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowImportStatusResponse>(response);
        }

        public AsyncInvoker<ShowImportStatusResponse> ShowImportStatusAsyncInvoker(ShowImportStatusRequest showImportStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImportStatusRequest);
            return new AsyncInvoker<ShowImportStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImportStatusResponse>);
        }
        
        /// <summary>
        /// 更新ACL规则
        ///
        /// 更新ACL规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAclRuleResponse> UpdateAclRuleAsync(UpdateAclRuleRequest updateAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", updateAclRuleRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclRuleResponse>(response);
        }

        public AsyncInvoker<UpdateAclRuleResponse> UpdateAclRuleAsyncInvoker(UpdateAclRuleRequest updateAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", updateAclRuleRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleRequest);
            return new AsyncInvoker<UpdateAclRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclRuleResponse>);
        }
        
        /// <summary>
        /// ACL防护规则优先级设置
        ///
        /// ACL防护规则优先级设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAclRuleOrderResponse> UpdateAclRuleOrderAsync(UpdateAclRuleOrderRequest updateAclRuleOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", updateAclRuleOrderRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/order/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleOrderRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclRuleOrderResponse>(response);
        }

        public AsyncInvoker<UpdateAclRuleOrderResponse> UpdateAclRuleOrderAsyncInvoker(UpdateAclRuleOrderRequest updateAclRuleOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", updateAclRuleOrderRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/order/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleOrderRequest);
            return new AsyncInvoker<UpdateAclRuleOrderResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclRuleOrderResponse>);
        }
        
        /// <summary>
        /// 弹性IP开启关闭
        ///
        /// 开启关闭EIP，客户购买EIP后首次开启EIP防护前需使用ListEips同步EIP资产，sync字段设置为1。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeEipStatusResponse> ChangeEipStatusAsync(ChangeEipStatusRequest changeEipStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEipStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeEipStatusResponse>(response);
        }

        public AsyncInvoker<ChangeEipStatusResponse> ChangeEipStatusAsyncInvoker(ChangeEipStatusRequest changeEipStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEipStatusRequest);
            return new AsyncInvoker<ChangeEipStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeEipStatusResponse>);
        }
        
        /// <summary>
        /// 查看eip告警白名单
        ///
        /// 查看eip告警白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmWhitelistResponse> ListAlarmWhitelistAsync(ListAlarmWhitelistRequest listAlarmWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", listAlarmWhitelistRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/alarm-whitelist/{fw_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmWhitelistRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmWhitelistResponse>(response);
        }

        public AsyncInvoker<ListAlarmWhitelistResponse> ListAlarmWhitelistAsyncInvoker(ListAlarmWhitelistRequest listAlarmWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", listAlarmWhitelistRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/alarm-whitelist/{fw_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmWhitelistRequest);
            return new AsyncInvoker<ListAlarmWhitelistResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmWhitelistResponse>);
        }
        
        /// <summary>
        /// 查询Eip个数
        ///
        /// 查询Eip个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEipCountResponse> ListEipCountAsync(ListEipCountRequest listEipCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("object_id", listEipCountRequest.ObjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip-count/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipCountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEipCountResponse>(response);
        }

        public AsyncInvoker<ListEipCountResponse> ListEipCountAsyncInvoker(ListEipCountRequest listEipCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("object_id", listEipCountRequest.ObjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip-count/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipCountRequest);
            return new AsyncInvoker<ListEipCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEipCountResponse>);
        }
        
        /// <summary>
        /// 弹性IP列表查询
        ///
        /// 弹性IP列表查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEipsResponse> ListEipsAsync(ListEipsRequest listEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEipsResponse>(response);
        }

        public AsyncInvoker<ListEipsResponse> ListEipsAsyncInvoker(ListEipsRequest listEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipsRequest);
            return new AsyncInvoker<ListEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEipsResponse>);
        }
        
        /// <summary>
        /// 获取eip自动防护状态信息
        ///
        /// 获取eip自动防护状态信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoProtectStatusResponse> ShowAutoProtectStatusAsync(ShowAutoProtectStatusRequest showAutoProtectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("object_id", showAutoProtectStatusRequest.ObjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/auto-protect-status/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoProtectStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoProtectStatusResponse>(response);
        }

        public AsyncInvoker<ShowAutoProtectStatusResponse> ShowAutoProtectStatusAsyncInvoker(ShowAutoProtectStatusRequest showAutoProtectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("object_id", showAutoProtectStatusRequest.ObjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/auto-protect-status/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoProtectStatusRequest);
            return new AsyncInvoker<ShowAutoProtectStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoProtectStatusResponse>);
        }
        
        /// <summary>
        /// 修改eip自动防护开关
        ///
        /// 修改eip自动防护开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchAutoProtectStatusResponse> SwitchAutoProtectStatusAsync(SwitchAutoProtectStatusRequest switchAutoProtectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/auto-protect-status/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchAutoProtectStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchAutoProtectStatusResponse>(response);
        }

        public AsyncInvoker<SwitchAutoProtectStatusResponse> SwitchAutoProtectStatusAsyncInvoker(SwitchAutoProtectStatusRequest switchAutoProtectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/auto-protect-status/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchAutoProtectStatusRequest);
            return new AsyncInvoker<SwitchAutoProtectStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAutoProtectStatusResponse>);
        }
        
        /// <summary>
        /// 查看自定义IPS规则列表
        ///
        /// 查看自定义IPS规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomerIpsResponse> ListCustomerIpsAsync(ListCustomerIpsRequest listCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerIpsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomerIpsResponse>(response);
        }

        public AsyncInvoker<ListCustomerIpsResponse> ListCustomerIpsAsyncInvoker(ListCustomerIpsRequest listCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerIpsRequest);
            return new AsyncInvoker<ListCustomerIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomerIpsResponse>);
        }
        
        /// <summary>
        /// 查询自定义IPS规则详情
        ///
        /// 功能说明：自定义IPS规则详情，特性:根据路径输入的IPS ID查看对应的自定义IPS详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCustomerIpsInfoResponse> ShowCustomerIpsInfoAsync(ShowCustomerIpsInfoRequest showCustomerIpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ips_cfw_id", showCustomerIpsInfoRequest.IpsCfwId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/{ips_cfw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerIpsInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCustomerIpsInfoResponse>(response);
        }

        public AsyncInvoker<ShowCustomerIpsInfoResponse> ShowCustomerIpsInfoAsyncInvoker(ShowCustomerIpsInfoRequest showCustomerIpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ips_cfw_id", showCustomerIpsInfoRequest.IpsCfwId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/{ips_cfw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerIpsInfoRequest);
            return new AsyncInvoker<ShowCustomerIpsInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCustomerIpsInfoResponse>);
        }
        
        /// <summary>
        /// 更新自定义IPS规则
        ///
        /// 更新自定义IPS规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCustomerIpsResponse> UpdateCustomerIpsAsync(UpdateCustomerIpsRequest updateCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ips_cfw_id", updateCustomerIpsRequest.IpsCfwId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/{ips_cfw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomerIpsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCustomerIpsResponse>(response);
        }

        public AsyncInvoker<UpdateCustomerIpsResponse> UpdateCustomerIpsAsyncInvoker(UpdateCustomerIpsRequest updateCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ips_cfw_id", updateCustomerIpsRequest.IpsCfwId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/{ips_cfw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomerIpsRequest);
            return new AsyncInvoker<UpdateCustomerIpsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCustomerIpsResponse>);
        }
        
        /// <summary>
        /// 切换防护模式
        ///
        /// 切换防护模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeIpsProtectModeResponse> ChangeIpsProtectModeAsync(ChangeIpsProtectModeRequest changeIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsProtectModeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeIpsProtectModeResponse>(response);
        }

        public AsyncInvoker<ChangeIpsProtectModeResponse> ChangeIpsProtectModeAsyncInvoker(ChangeIpsProtectModeRequest changeIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsProtectModeRequest);
            return new AsyncInvoker<ChangeIpsProtectModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeIpsProtectModeResponse>);
        }
        
        /// <summary>
        /// 改变ips规则模式
        ///
        /// 改变ips规则模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeIpsRuleModeResponse> ChangeIpsRuleModeAsync(ChangeIpsRuleModeRequest changeIpsRuleModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsRuleModeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeIpsRuleModeResponse>(response);
        }

        public AsyncInvoker<ChangeIpsRuleModeResponse> ChangeIpsRuleModeAsyncInvoker(ChangeIpsRuleModeRequest changeIpsRuleModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsRuleModeRequest);
            return new AsyncInvoker<ChangeIpsRuleModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeIpsRuleModeResponse>);
        }
        
        /// <summary>
        /// IPS特性开关操作
        ///
        /// 切换开关状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeIpsSwitchStatusResponse> ChangeIpsSwitchStatusAsync(ChangeIpsSwitchStatusRequest changeIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsSwitchStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeIpsSwitchStatusResponse>(response);
        }

        public AsyncInvoker<ChangeIpsSwitchStatusResponse> ChangeIpsSwitchStatusAsyncInvoker(ChangeIpsSwitchStatusRequest changeIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsSwitchStatusRequest);
            return new AsyncInvoker<ChangeIpsSwitchStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeIpsSwitchStatusResponse>);
        }
        
        /// <summary>
        /// 查询防护模式
        ///
        /// 查询防护模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpsProtectModeResponse> ListIpsProtectModeAsync(ListIpsProtectModeRequest listIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsProtectModeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpsProtectModeResponse>(response);
        }

        public AsyncInvoker<ListIpsProtectModeResponse> ListIpsProtectModeAsyncInvoker(ListIpsProtectModeRequest listIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsProtectModeRequest);
            return new AsyncInvoker<ListIpsProtectModeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsProtectModeResponse>);
        }
        
        /// <summary>
        /// 查询频率ips规则信息
        ///
        /// 查询频率ips规则信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpsRulesResponse> ListIpsRulesAsync(ListIpsRulesRequest listIpsRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/advanced-ips-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpsRulesResponse>(response);
        }

        public AsyncInvoker<ListIpsRulesResponse> ListIpsRulesAsyncInvoker(ListIpsRulesRequest listIpsRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/advanced-ips-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsRulesRequest);
            return new AsyncInvoker<ListIpsRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsRulesResponse>);
        }
        
        /// <summary>
        /// 获取ips规则列表
        ///
        /// 获取ips规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpsRules1Response> ListIpsRules1Async(ListIpsRules1Request listIpsRules1Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsRules1Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpsRules1Response>(response);
        }

        public AsyncInvoker<ListIpsRules1Response> ListIpsRules1AsyncInvoker(ListIpsRules1Request listIpsRules1Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsRules1Request);
            return new AsyncInvoker<ListIpsRules1Response>(this, "GET", request, JsonUtils.DeSerialize<ListIpsRules1Response>);
        }
        
        /// <summary>
        /// 查询IPS特性开关状态
        ///
        /// 查询IPS特性开关状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpsSwitchStatusResponse> ListIpsSwitchStatusAsync(ListIpsSwitchStatusRequest listIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsSwitchStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpsSwitchStatusResponse>(response);
        }

        public AsyncInvoker<ListIpsSwitchStatusResponse> ListIpsSwitchStatusAsyncInvoker(ListIpsSwitchStatusRequest listIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsSwitchStatusRequest);
            return new AsyncInvoker<ListIpsSwitchStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsSwitchStatusResponse>);
        }
        
        /// <summary>
        /// 获取ips规则细节
        ///
        /// 获取ips规则细节
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpsUpdateTimeResponse> ShowIpsUpdateTimeAsync(ShowIpsUpdateTimeRequest showIpsUpdateTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpsUpdateTimeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIpsUpdateTimeResponse>(response);
        }

        public AsyncInvoker<ShowIpsUpdateTimeResponse> ShowIpsUpdateTimeAsyncInvoker(ShowIpsUpdateTimeRequest showIpsUpdateTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpsUpdateTimeRequest);
            return new AsyncInvoker<ShowIpsUpdateTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpsUpdateTimeResponse>);
        }
        
        /// <summary>
        /// 创建频率ips规则
        ///
        /// 创建频率ips规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAdvancedIpsRuleResponse> UpdateAdvancedIpsRuleAsync(UpdateAdvancedIpsRuleRequest updateAdvancedIpsRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/advanced-ips-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAdvancedIpsRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAdvancedIpsRuleResponse>(response);
        }

        public AsyncInvoker<UpdateAdvancedIpsRuleResponse> UpdateAdvancedIpsRuleAsyncInvoker(UpdateAdvancedIpsRuleRequest updateAdvancedIpsRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/advanced-ips-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAdvancedIpsRuleRequest);
            return new AsyncInvoker<UpdateAdvancedIpsRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAdvancedIpsRuleResponse>);
        }
        
        /// <summary>
        /// 查询攻击统计
        ///
        /// 根据防火墙攻击日志，查询攻击统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAttackStatisticResponse> ListAttackStatisticAsync(ListAttackStatisticRequest listAttackStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackStatisticRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAttackStatisticResponse>(response);
        }

        public AsyncInvoker<ListAttackStatisticResponse> ListAttackStatisticAsyncInvoker(ListAttackStatisticRequest listAttackStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackStatisticRequest);
            return new AsyncInvoker<ListAttackStatisticResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAttackStatisticResponse>);
        }
        
        /// <summary>
        /// 查询流量日志统计
        ///
        /// 查询流量日志统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlowStatisticResponse> ListFlowStatisticAsync(ListFlowStatisticRequest listFlowStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowStatisticRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlowStatisticResponse>(response);
        }

        public AsyncInvoker<ListFlowStatisticResponse> ListFlowStatisticAsyncInvoker(ListFlowStatisticRequest listFlowStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowStatisticRequest);
            return new AsyncInvoker<ListFlowStatisticResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlowStatisticResponse>);
        }
        
        /// <summary>
        /// 查询访问控制统计详情
        ///
        /// 查询访问控制统计详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAccessDetailResponse> ShowAccessDetailAsync(ShowAccessDetailRequest showAccessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/top-access-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessDetailResponse>(response);
        }

        public AsyncInvoker<ShowAccessDetailResponse> ShowAccessDetailAsyncInvoker(ShowAccessDetailRequest showAccessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/top-access-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDetailRequest);
            return new AsyncInvoker<ShowAccessDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessDetailResponse>);
        }
        
        /// <summary>
        /// 查询访问日志统计信息
        ///
        /// 获取访问日志的TOP统计信息，如TOP命中规则等
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAccessTopResponse> ShowAccessTopAsync(ShowAccessTopRequest showAccessTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-top", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessTopRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessTopResponse>(response);
        }

        public AsyncInvoker<ShowAccessTopResponse> ShowAccessTopAsyncInvoker(ShowAccessTopRequest showAccessTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-top", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessTopRequest);
            return new AsyncInvoker<ShowAccessTopResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessTopResponse>);
        }
        
        /// <summary>
        /// 查询攻击日志统计详情
        ///
        /// 查询攻击日志统计详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAttackDetailResponse> ShowAttackDetailAsync(ShowAttackDetailRequest showAttackDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAttackDetailResponse>(response);
        }

        public AsyncInvoker<ShowAttackDetailResponse> ShowAttackDetailAsyncInvoker(ShowAttackDetailRequest showAttackDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackDetailRequest);
            return new AsyncInvoker<ShowAttackDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAttackDetailResponse>);
        }
        
        /// <summary>
        /// 查询攻击日志TOP统计
        ///
        /// 查询攻击日志TOP统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAttackTopResponse> ShowAttackTopAsync(ShowAttackTopRequest showAttackTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/top-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTopRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAttackTopResponse>(response);
        }

        public AsyncInvoker<ShowAttackTopResponse> ShowAttackTopAsyncInvoker(ShowAttackTopRequest showAttackTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/top-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTopRequest);
            return new AsyncInvoker<ShowAttackTopResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAttackTopResponse>);
        }
        
        /// <summary>
        /// 查询攻击概览
        ///
        /// 查询攻击概览
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAttackTotalResponse> ShowAttackTotalAsync(ShowAttackTotalRequest showAttackTotalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/total-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTotalRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAttackTotalResponse>(response);
        }

        public AsyncInvoker<ShowAttackTotalResponse> ShowAttackTotalAsyncInvoker(ShowAttackTotalRequest showAttackTotalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/total-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTotalRequest);
            return new AsyncInvoker<ShowAttackTotalResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAttackTotalResponse>);
        }
        
        /// <summary>
        /// 查询攻击趋势
        ///
        /// 查询攻击趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAttackTrendResponse> ShowAttackTrendAsync(ShowAttackTrendRequest showAttackTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/trend-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTrendRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAttackTrendResponse>(response);
        }

        public AsyncInvoker<ShowAttackTrendResponse> ShowAttackTrendAsyncInvoker(ShowAttackTrendRequest showAttackTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/trend-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTrendRequest);
            return new AsyncInvoker<ShowAttackTrendResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAttackTrendResponse>);
        }
        
        /// <summary>
        /// 查询流量日志统计详情
        ///
        /// 查询流量日志统计详情，如统计某个源IP访问详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlowDetailResponse> ShowFlowDetailAsync(ShowFlowDetailRequest showFlowDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowDetailResponse>(response);
        }

        public AsyncInvoker<ShowFlowDetailResponse> ShowFlowDetailAsyncInvoker(ShowFlowDetailRequest showFlowDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowDetailRequest);
            return new AsyncInvoker<ShowFlowDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowDetailResponse>);
        }
        
        /// <summary>
        /// 查询流量TOP统计
        ///
        /// 查询流量TOP统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlowTopResponse> ShowFlowTopAsync(ShowFlowTopRequest showFlowTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-top", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowTopRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowTopResponse>(response);
        }

        public AsyncInvoker<ShowFlowTopResponse> ShowFlowTopAsyncInvoker(ShowFlowTopRequest showFlowTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-top", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowTopRequest);
            return new AsyncInvoker<ShowFlowTopResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowTopResponse>);
        }
        
        /// <summary>
        /// 查询会话趋势
        ///
        /// 查询会话趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlowTrendResponse> ShowFlowTrendAsync(ShowFlowTrendRequest showFlowTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowTrendRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowTrendResponse>(response);
        }

        public AsyncInvoker<ShowFlowTrendResponse> ShowFlowTrendAsyncInvoker(ShowFlowTrendRequest showFlowTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowTrendRequest);
            return new AsyncInvoker<ShowFlowTrendResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowTrendResponse>);
        }
        
        /// <summary>
        /// 查询日志数量
        ///
        /// 统计日志数量，如统计风险IP的数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogsCountResponse> ShowLogsCountAsync(ShowLogsCountRequest showLogsCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsCountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLogsCountResponse>(response);
        }

        public AsyncInvoker<ShowLogsCountResponse> ShowLogsCountAsyncInvoker(ShowLogsCountRequest showLogsCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsCountRequest);
            return new AsyncInvoker<ShowLogsCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogsCountResponse>);
        }
        
        /// <summary>
        /// 查询流量趋势
        ///
        /// 查询流量趋势，包括南北向、EIP、东西向的流量趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrafficTrendResponse> ShowTrafficTrendAsync(ShowTrafficTrendRequest showTrafficTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/traffic-trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficTrendRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrafficTrendResponse>(response);
        }

        public AsyncInvoker<ShowTrafficTrendResponse> ShowTrafficTrendAsyncInvoker(ShowTrafficTrendRequest showTrafficTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/traffic-trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficTrendRequest);
            return new AsyncInvoker<ShowTrafficTrendResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrafficTrendResponse>);
        }
        
        /// <summary>
        /// 导出防火墙日志
        ///
        /// 导出防火墙日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportLogsResponse> ExportLogsAsync(ExportLogsRequest exportLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", exportLogsRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/logs/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExportLogsResponse>(response);
        }

        public AsyncInvoker<ExportLogsResponse> ExportLogsAsyncInvoker(ExportLogsRequest exportLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", exportLogsRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/logs/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportLogsRequest);
            return new AsyncInvoker<ExportLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportLogsResponse>);
        }
        
        /// <summary>
        /// 查询防火墙日志
        ///
        /// 查询防火墙日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogsResponse> ListLogsAsync(ListLogsRequest listLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", listLogsRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLogsResponse>(response);
        }

        public AsyncInvoker<ListLogsResponse> ListLogsAsyncInvoker(ListLogsRequest listLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", listLogsRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            return new AsyncInvoker<ListLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLogsResponse>);
        }
        
        /// <summary>
        /// 开启多账号管理
        ///
        /// 开启多账号管理
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableMultiAccountResponse> EnableMultiAccountAsync(EnableMultiAccountRequest enableMultiAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableMultiAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableMultiAccountResponse>(response);
        }

        public AsyncInvoker<EnableMultiAccountResponse> EnableMultiAccountAsyncInvoker(EnableMultiAccountRequest enableMultiAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableMultiAccountRequest);
            return new AsyncInvoker<EnableMultiAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableMultiAccountResponse>);
        }
        
        /// <summary>
        /// 查询账号列表
        ///
        /// 查询账号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountsResponse>(response);
        }

        public AsyncInvoker<ListAccountsResponse> ListAccountsAsyncInvoker(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            return new AsyncInvoker<ListAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountsResponse>);
        }
        
        /// <summary>
        /// 查询组织账号列表
        ///
        /// 查询组织账号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOrganizationAccountsResponse> ListOrganizationAccountsAsync(ListOrganizationAccountsRequest listOrganizationAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/organization-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationAccountsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationAccountsResponse>(response);
        }

        public AsyncInvoker<ListOrganizationAccountsResponse> ListOrganizationAccountsAsyncInvoker(ListOrganizationAccountsRequest listOrganizationAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/organization-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationAccountsRequest);
            return new AsyncInvoker<ListOrganizationAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationAccountsResponse>);
        }
        
        /// <summary>
        /// 查询组织结构
        ///
        /// 查询组织结构
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOrganizationTreeResponse> ListOrganizationTreeAsync(ListOrganizationTreeRequest listOrganizationTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/organization-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationTreeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationTreeResponse>(response);
        }

        public AsyncInvoker<ListOrganizationTreeResponse> ListOrganizationTreeAsyncInvoker(ListOrganizationTreeRequest listOrganizationTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/organization-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationTreeRequest);
            return new AsyncInvoker<ListOrganizationTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationTreeResponse>);
        }
        
        /// <summary>
        /// 创建安全报告模板
        ///
        /// 创建安全报告模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateReportProfileResponse> CreateReportProfileAsync(CreateReportProfileRequest createReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportProfileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateReportProfileResponse>(response);
        }

        public AsyncInvoker<CreateReportProfileResponse> CreateReportProfileAsyncInvoker(CreateReportProfileRequest createReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportProfileRequest);
            return new AsyncInvoker<CreateReportProfileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReportProfileResponse>);
        }
        
        /// <summary>
        /// 删除安全报告模板
        ///
        /// 删除安全报告模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteReportProfileResponse> DeleteReportProfileAsync(DeleteReportProfileRequest deleteReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_profile_id", deleteReportProfileRequest.ReportProfileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReportProfileRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteReportProfileResponse>(response);
        }

        public AsyncInvoker<DeleteReportProfileResponse> DeleteReportProfileAsyncInvoker(DeleteReportProfileRequest deleteReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_profile_id", deleteReportProfileRequest.ReportProfileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReportProfileRequest);
            return new AsyncInvoker<DeleteReportProfileResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteReportProfileResponse>);
        }
        
        /// <summary>
        /// 查询安全报告模板列表
        ///
        /// 查询安全报告模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListReportProfilesResponse> ListReportProfilesAsync(ListReportProfilesRequest listReportProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReportProfilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListReportProfilesResponse>(response);
        }

        public AsyncInvoker<ListReportProfilesResponse> ListReportProfilesAsyncInvoker(ListReportProfilesRequest listReportProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReportProfilesRequest);
            return new AsyncInvoker<ListReportProfilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReportProfilesResponse>);
        }
        
        /// <summary>
        /// 查询安全报告
        ///
        /// 查询安全报告
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFirewallReportResponse> ShowFirewallReportAsync(ShowFirewallReportRequest showFirewallReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_id", showFirewallReportRequest.ReportId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallReportRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFirewallReportResponse>(response);
        }

        public AsyncInvoker<ShowFirewallReportResponse> ShowFirewallReportAsyncInvoker(ShowFirewallReportRequest showFirewallReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_id", showFirewallReportRequest.ReportId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallReportRequest);
            return new AsyncInvoker<ShowFirewallReportResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFirewallReportResponse>);
        }
        
        /// <summary>
        /// 获取安全报告模板
        ///
        /// 获取安全报告模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReportProfileResponse> ShowReportProfileAsync(ShowReportProfileRequest showReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_profile_id", showReportProfileRequest.ReportProfileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportProfileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReportProfileResponse>(response);
        }

        public AsyncInvoker<ShowReportProfileResponse> ShowReportProfileAsyncInvoker(ShowReportProfileRequest showReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_profile_id", showReportProfileRequest.ReportProfileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportProfileRequest);
            return new AsyncInvoker<ShowReportProfileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReportProfileResponse>);
        }
        
        /// <summary>
        /// 更新安全报告模板
        ///
        /// 更新安全报告模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateReportProfileResponse> UpdateReportProfileAsync(UpdateReportProfileRequest updateReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_profile_id", updateReportProfileRequest.ReportProfileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReportProfileRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReportProfileResponse>(response);
        }

        public AsyncInvoker<UpdateReportProfileResponse> UpdateReportProfileAsyncInvoker(UpdateReportProfileRequest updateReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_profile_id", updateReportProfileRequest.ReportProfileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReportProfileRequest);
            return new AsyncInvoker<UpdateReportProfileResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReportProfileResponse>);
        }
        
        /// <summary>
        /// 更新VPC间防火墙防护状态
        ///
        /// 更新VPC间防火墙防护状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeEastWestFirewallStatusResponse> ChangeEastWestFirewallStatusAsync(ChangeEastWestFirewallStatusRequest changeEastWestFirewallStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEastWestFirewallStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeEastWestFirewallStatusResponse>(response);
        }

        public AsyncInvoker<ChangeEastWestFirewallStatusResponse> ChangeEastWestFirewallStatusAsyncInvoker(ChangeEastWestFirewallStatusRequest changeEastWestFirewallStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEastWestFirewallStatusRequest);
            return new AsyncInvoker<ChangeEastWestFirewallStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeEastWestFirewallStatusResponse>);
        }
        
        /// <summary>
        /// 查询VPC间防火墙使用的企业路由器信息
        ///
        /// 查询VPC间防火墙使用的企业路由器信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEwAssociatedErResponse> ShowEwAssociatedErAsync(ShowEwAssociatedErRequest showEwAssociatedErRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/enterprise-router", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEwAssociatedErRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEwAssociatedErResponse>(response);
        }

        public AsyncInvoker<ShowEwAssociatedErResponse> ShowEwAssociatedErAsyncInvoker(ShowEwAssociatedErRequest showEwAssociatedErRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/enterprise-router", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEwAssociatedErRequest);
            return new AsyncInvoker<ShowEwAssociatedErResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEwAssociatedErResponse>);
        }
        
        /// <summary>
        /// 查询VPC边界防火墙使用的引流VPC信息
        ///
        /// 查询VPC边界防火墙使用的引流VPC信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEwAssociatedVpcResponse> ShowEwAssociatedVpcAsync(ShowEwAssociatedVpcRequest showEwAssociatedVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/inspection-vpc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEwAssociatedVpcRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEwAssociatedVpcResponse>(response);
        }

        public AsyncInvoker<ShowEwAssociatedVpcResponse> ShowEwAssociatedVpcAsyncInvoker(ShowEwAssociatedVpcRequest showEwAssociatedVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/inspection-vpc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEwAssociatedVpcRequest);
            return new AsyncInvoker<ShowEwAssociatedVpcResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEwAssociatedVpcResponse>);
        }
        
    }
}