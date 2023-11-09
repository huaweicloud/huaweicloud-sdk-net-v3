using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cfw.V1.Model;

namespace HuaweiCloud.SDK.Cfw.V1
{
    public partial class CfwClient : Client
    {
        public static ClientBuilder<CfwClient> NewBuilder()
        {
            return new ClientBuilder<CfwClient>();
        }

        
        /// <summary>
        /// 添加地址组成员
        ///
        /// 添加地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAddressItemResponse AddAddressItem(AddAddressItemRequest addAddressItemRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressItemRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddAddressItemResponse>(response);
        }
        
        /// <summary>
        /// 添加地址组
        ///
        /// 添加地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAddressSetResponse AddAddressSet(AddAddressSetRequest addAddressSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-set",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddAddressSetResponse>(response);
        }
        
        /// <summary>
        /// 创建黑白名单规则
        ///
        /// 创建黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddBlackWhiteListResponse AddBlackWhiteList(AddBlackWhiteListRequest addBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteListRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddBlackWhiteListResponse>(response);
        }
        
        /// <summary>
        /// 添加域名组
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDomainSetResponse AddDomainSet(AddDomainSetRequest addDomainSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddDomainSetResponse>(response);
        }
        
        /// <summary>
        /// 添加域名列表
        ///
        /// 添加域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDomainsResponse AddDomains(AddDomainsRequest addDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , addDomainsRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddDomainsResponse>(response);
        }
        
        /// <summary>
        /// 新建服务成员
        ///
        /// 批量添加服务组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddServiceItemsResponse AddServiceItems(AddServiceItemsRequest addServiceItemsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceItemsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddServiceItemsResponse>(response);
        }
        
        /// <summary>
        /// 新建服务组
        ///
        /// 创建服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddServiceSetResponse AddServiceSet(AddServiceSetRequest addServiceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-set",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddServiceSetResponse>(response);
        }
        
        /// <summary>
        /// 批量删除地址组成员
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAddressItemsResponse BatchDeleteAddressItems(BatchDeleteAddressItemsRequest batchDeleteAddressItemsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressItemsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteAddressItemsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除服务组成员信息
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteServiceItemsResponse BatchDeleteServiceItems(BatchDeleteServiceItemsRequest batchDeleteServiceItemsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceItemsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteServiceItemsResponse>(response);
        }
        
        /// <summary>
        /// 修改东西向防火墙防护状态
        ///
        /// 东西向防护资源防护开启/关闭
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeEastWestFirewallStatusResponse ChangeEastWestFirewallStatus(ChangeEastWestFirewallStatusRequest changeEastWestFirewallStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEastWestFirewallStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangeEastWestFirewallStatusResponse>(response);
        }
        
        /// <summary>
        /// 删除地址组成员
        ///
        /// 删除地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAddressItemResponse DeleteAddressItem(DeleteAddressItemRequest deleteAddressItemRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id" , deleteAddressItemRequest.ItemId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items/{item_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressItemRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAddressItemResponse>(response);
        }
        
        /// <summary>
        /// 删除地址组
        ///
        /// 删除地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAddressSetResponse DeleteAddressSet(DeleteAddressSetRequest deleteAddressSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , deleteAddressSetRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAddressSetResponse>(response);
        }
        
        /// <summary>
        /// 删除黑白名单规则
        ///
        /// 删除黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBlackWhiteListResponse DeleteBlackWhiteList(DeleteBlackWhiteListRequest deleteBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id" , deleteBlackWhiteListRequest.ListId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteListRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteBlackWhiteListResponse>(response);
        }
        
        /// <summary>
        /// 删除域名组
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainSetResponse DeleteDomainSet(DeleteDomainSetRequest deleteDomainSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , deleteDomainSetRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDomainSetResponse>(response);
        }
        
        /// <summary>
        /// 删除域名列表
        ///
        /// 删除域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainsResponse DeleteDomains(DeleteDomainsRequest deleteDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , deleteDomainsRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDomainsResponse>(response);
        }
        
        /// <summary>
        /// 删除服务成员
        ///
        /// 删除服务组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServiceItemResponse DeleteServiceItem(DeleteServiceItemRequest deleteServiceItemRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id" , deleteServiceItemRequest.ItemId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items/{item_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceItemRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteServiceItemResponse>(response);
        }
        
        /// <summary>
        /// 删除服务组
        ///
        /// 删除服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServiceSetResponse DeleteServiceSet(DeleteServiceSetRequest deleteServiceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , deleteServiceSetRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteServiceSetResponse>(response);
        }
        
        /// <summary>
        /// 查询访问控制日志
        ///
        /// 查询访问控制日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessControlLogsResponse ListAccessControlLogs(ListAccessControlLogsRequest listAccessControlLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-control",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAccessControlLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询地址组成员
        ///
        /// 查询地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddressItemsResponse ListAddressItems(ListAddressItemsRequest listAddressItemsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressItemsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAddressItemsResponse>(response);
        }
        
        /// <summary>
        /// 查询地址组详细信息
        ///
        /// 查询地址组详细
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddressSetDetailResponse ListAddressSetDetail(ListAddressSetDetailRequest listAddressSetDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , listAddressSetDetailRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAddressSetDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询地址组列表
        ///
        /// 查询地址组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddressSetsResponse ListAddressSets(ListAddressSetsRequest listAddressSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAddressSetsResponse>(response);
        }
        
        /// <summary>
        /// 查询攻击日志
        ///
        /// 查询攻击日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAttackLogsResponse ListAttackLogs(ListAttackLogsRequest listAttackLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAttackLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询黑白名单列表
        ///
        /// 查询黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBlackWhiteListsResponse ListBlackWhiteLists(ListBlackWhiteListsRequest listBlackWhiteListsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlackWhiteListsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBlackWhiteListsResponse>(response);
        }
        
        /// <summary>
        /// 查询dns服务器列表
        ///
        /// 查询dns服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDnsServersResponse ListDnsServers(ListDnsServersRequest listDnsServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDnsServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDnsServersResponse>(response);
        }
        
        /// <summary>
        /// 查询域名解析ip地址
        ///
        /// 测试域名有效性
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainParseDetailResponse ListDomainParseDetail(ListDomainParseDetailRequest listDomainParseDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , listDomainParseDetailRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse/{domain_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainParseDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询域名组列表
        ///
        /// 查询域名组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainSetsResponse ListDomainSets(ListDomainSetsRequest listDomainSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainSetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainSetsResponse>(response);
        }
        
        /// <summary>
        /// 获取域名组下域名列表
        ///
        /// 获取域名组下域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainsResponse ListDomains(ListDomainsRequest listDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_set_id" , listDomainsRequest.DomainSetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{domain_set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }
        
        /// <summary>
        /// 获取东西向防火墙信息
        ///
        /// 获取东西向防火墙信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEastWestFirewallResponse ListEastWestFirewall(ListEastWestFirewallRequest listEastWestFirewallRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEastWestFirewallRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEastWestFirewallResponse>(response);
        }
        
        /// <summary>
        /// 查询防火墙详细信息
        ///
        /// 查询防火墙实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFirewallDetailResponse ListFirewallDetail(ListFirewallDetailRequest listFirewallDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/exist",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFirewallDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询防火墙列表
        ///
        /// 查询防火墙列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFirewallListResponse ListFirewallList(ListFirewallListRequest listFirewallListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewalls/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallListRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListFirewallListResponse>(response);
        }
        
        /// <summary>
        /// 查询流日志
        ///
        /// 查询流日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlowLogsResponse ListFlowLogs(ListFlowLogsRequest listFlowLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFlowLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询防护VPC数
        ///
        /// 查询防护vpc信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProtectedVpcsResponse ListProtectedVpcs(ListProtectedVpcsRequest listProtectedVpcsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/protection",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedVpcsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProtectedVpcsResponse>(response);
        }
        
        /// <summary>
        /// 查询服务成员列表
        ///
        /// 查询服务组成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceItemsResponse ListServiceItems(ListServiceItemsRequest listServiceItemsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceItemsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListServiceItemsResponse>(response);
        }
        
        /// <summary>
        /// 查询服务组详情
        ///
        /// 查询服务组细节
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceSetDetailResponse ListServiceSetDetail(ListServiceSetDetailRequest listServiceSetDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , listServiceSetDetailRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListServiceSetDetailResponse>(response);
        }
        
        /// <summary>
        /// 获取服务组列表
        ///
        /// 获取服务组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceSetsResponse ListServiceSets(ListServiceSetsRequest listServiceSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListServiceSetsResponse>(response);
        }
        
        /// <summary>
        /// 更新地址组信息
        ///
        /// 更新地址组信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAddressSetResponse UpdateAddressSet(UpdateAddressSetRequest updateAddressSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , updateAddressSetRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddressSetResponse>(response);
        }
        
        /// <summary>
        /// 更新黑白名单列表
        ///
        /// 更新黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBlackWhiteListResponse UpdateBlackWhiteList(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id" , updateBlackWhiteListRequest.ListId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }
        
        /// <summary>
        /// 更新dns服务器列表
        ///
        /// 更新dns服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDnsServersResponse UpdateDnsServers(UpdateDnsServersRequest updateDnsServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDnsServersResponse>(response);
        }
        
        /// <summary>
        /// 更新域名组
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainSetResponse UpdateDomainSet(UpdateDomainSetRequest updateDomainSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , updateDomainSetRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainSetResponse>(response);
        }
        
        /// <summary>
        /// 修改服务组
        ///
        /// 更新服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateServiceSetResponse UpdateServiceSet(UpdateServiceSetRequest updateServiceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , updateServiceSetRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateServiceSetResponse>(response);
        }
        
        /// <summary>
        /// 创建ACL规则
        ///
        /// 创建ACL规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAclRuleResponse AddAclRule(AddAclRuleRequest addAclRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAclRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddAclRuleResponse>(response);
        }
        
        /// <summary>
        /// 批量删除Acl规则
        ///
        /// 批量删除Acl规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAclRulesResponse BatchDeleteAclRules(BatchDeleteAclRulesRequest batchDeleteAclRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAclRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteAclRulesResponse>(response);
        }
        
        /// <summary>
        /// 批量更新规则动作
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateAclRuleActionsResponse BatchUpdateAclRuleActions(BatchUpdateAclRuleActionsRequest batchUpdateAclRuleActionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAclRuleActionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateAclRuleActionsResponse>(response);
        }
        
        /// <summary>
        /// 删除ACL规则
        ///
        /// 删除ACL规则组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAclRuleResponse DeleteAclRule(DeleteAclRuleRequest deleteAclRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id" , deleteAclRuleRequest.AclRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAclRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除规则击中次数
        ///
        /// 清除规则击中次数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAclRuleHitCountResponse DeleteAclRuleHitCount(DeleteAclRuleHitCountRequest deleteAclRuleHitCountRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleHitCountRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteAclRuleHitCountResponse deleteAclRuleHitCountResponse = JsonUtils.DeSerializeNull<DeleteAclRuleHitCountResponse>(response);
            return deleteAclRuleHitCountResponse;
        }
        
        /// <summary>
        /// 获取规则击中次数
        ///
        /// 获取规则击中次数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAclRuleHitCountResponse ListAclRuleHitCount(ListAclRuleHitCountRequest listAclRuleHitCountRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitCountRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListAclRuleHitCountResponse>(response);
        }
        
        /// <summary>
        /// 查询防护规则
        ///
        /// 查询防护规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAclRulesResponse ListAclRules(ListAclRulesRequest listAclRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAclRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询规则标签
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRuleAclTagsResponse ListRuleAclTags(ListRuleAclTagsRequest listRuleAclTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-acl/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRuleAclTagsResponse>(response);
        }
        
        /// <summary>
        /// 更新ACL规则
        ///
        /// 更新ACL规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAclRuleResponse UpdateAclRule(UpdateAclRuleRequest updateAclRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id" , updateAclRuleRequest.AclRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAclRuleResponse>(response);
        }
        
        /// <summary>
        /// ACL防护规则优先级设置
        ///
        /// ACL防护规则优先级设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAclRuleOrderResponse UpdateAclRuleOrder(UpdateAclRuleOrderRequest updateAclRuleOrderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id" , updateAclRuleOrderRequest.AclRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/order/{acl_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleOrderRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAclRuleOrderResponse>(response);
        }
        
        /// <summary>
        /// 弹性IP开启关闭
        ///
        /// 开启关闭EIP,客户购买EIP后首次开启EIP防护前需使用ListEips同步EIP资产，sync字段设置为1。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeEipStatusResponse ChangeEipStatus(ChangeEipStatusRequest changeEipStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEipStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangeEipStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询Eip个数
        ///
        /// 查询Eip个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEipCountResponse ListEipCount(ListEipCountRequest listEipCountRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("object_id" , listEipCountRequest.ObjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip-count/{object_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipCountRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEipCountResponse>(response);
        }
        
        /// <summary>
        /// 弹性IP列表查询
        ///
        /// 弹性IP列表查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEipsResponse ListEips(ListEipsRequest listEipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eips/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEipsResponse>(response);
        }
        
        /// <summary>
        /// 切换防护模式
        ///
        /// 切换防护模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeIpsProtectModeResponse ChangeIpsProtectMode(ChangeIpsProtectModeRequest changeIpsProtectModeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsProtectModeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangeIpsProtectModeResponse>(response);
        }
        
        /// <summary>
        /// IPS特性开关操作
        ///
        /// 切换开关状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeIpsSwitchStatusResponse ChangeIpsSwitchStatus(ChangeIpsSwitchStatusRequest changeIpsSwitchStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsSwitchStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangeIpsSwitchStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询防护模式
        ///
        /// 查询防护模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpsProtectModeResponse ListIpsProtectMode(ListIpsProtectModeRequest listIpsProtectModeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsProtectModeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListIpsProtectModeResponse>(response);
        }
        
        /// <summary>
        /// 查询IPS特性开关状态
        ///
        /// 查询IPS特性开关状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpsSwitchStatusResponse ListIpsSwitchStatus(ListIpsSwitchStatusRequest listIpsSwitchStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsSwitchStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListIpsSwitchStatusResponse>(response);
        }
        
    }
}