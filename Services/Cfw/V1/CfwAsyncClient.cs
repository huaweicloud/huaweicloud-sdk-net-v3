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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<AddAddressItemsUsingPostResponse> AddAddressItemsUsingPostAsync(AddAddressItemsUsingPostRequest addAddressItemsUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressItemsUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddAddressItemsUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 添加地址组
        ///
        /// 添加地址组
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<AddAddressSetInfoUsingPostResponse> AddAddressSetInfoUsingPostAsync(AddAddressSetInfoUsingPostRequest addAddressSetInfoUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-set",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressSetInfoUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddAddressSetInfoUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 创建黑白名单规则
        ///
        /// 创建黑白名单规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<AddBlackWhiteListUsingPostResponse> AddBlackWhiteListUsingPostAsync(AddBlackWhiteListUsingPostRequest addBlackWhiteListUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteListUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddBlackWhiteListUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 新建服务成员
        ///
        /// 批量添加服务组成员
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<AddServiceItemsUsingPostResponse> AddServiceItemsUsingPostAsync(AddServiceItemsUsingPostRequest addServiceItemsUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceItemsUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddServiceItemsUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 新建服务组
        ///
        /// 创建服务组
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<AddServiceSetUsingPostResponse> AddServiceSetUsingPostAsync(AddServiceSetUsingPostRequest addServiceSetUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-set",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceSetUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddServiceSetUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 修改东西向防火墙防护状态
        ///
        /// 东西向防护资源防护开启/关闭
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeEwProtectStatusResponse> ChangeEwProtectStatusAsync(ChangeEwProtectStatusRequest changeEwProtectStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEwProtectStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeEwProtectStatusResponse>(response);
        }
        
        /// <summary>
        /// 切换防护模式
        ///
        /// 切换防护模式
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeIpsProtectModeUsingPostResponse> ChangeIpsProtectModeUsingPostAsync(ChangeIpsProtectModeUsingPostRequest changeIpsProtectModeUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsProtectModeUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeIpsProtectModeUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 删除规则击中次数
        ///
        /// 清除规则击中次数
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAclRuleCountResponse> DeleteAclRuleCountAsync(DeleteAclRuleCountRequest deleteAclRuleCountRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleCountRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteAclRuleCountResponse deleteAclRuleCountResponse = JsonUtils.DeSerializeNull<DeleteAclRuleCountResponse>(response);
            return deleteAclRuleCountResponse;
        }
        
        /// <summary>
        /// 删除地址组成员
        ///
        /// 删除地址组成员
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAddressItemUsingDeleteResponse> DeleteAddressItemUsingDeleteAsync(DeleteAddressItemUsingDeleteRequest deleteAddressItemUsingDeleteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id" , deleteAddressItemUsingDeleteRequest.ItemId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items/{item_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressItemUsingDeleteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAddressItemUsingDeleteResponse>(response);
        }
        
        /// <summary>
        /// 删除地址组
        ///
        /// 删除地址组
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAddressSetInfoUsingDeleteResponse> DeleteAddressSetInfoUsingDeleteAsync(DeleteAddressSetInfoUsingDeleteRequest deleteAddressSetInfoUsingDeleteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , deleteAddressSetInfoUsingDeleteRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressSetInfoUsingDeleteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAddressSetInfoUsingDeleteResponse>(response);
        }
        
        /// <summary>
        /// 删除黑白名单规则
        ///
        /// 删除黑白名单规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBlackWhiteListUsingDeleteResponse> DeleteBlackWhiteListUsingDeleteAsync(DeleteBlackWhiteListUsingDeleteRequest deleteBlackWhiteListUsingDeleteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id" , deleteBlackWhiteListUsingDeleteRequest.ListId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteListUsingDeleteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteBlackWhiteListUsingDeleteResponse>(response);
        }
        
        /// <summary>
        /// 删除服务成员
        ///
        /// 删除服务组成员
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServiceItemUsingDeleteResponse> DeleteServiceItemUsingDeleteAsync(DeleteServiceItemUsingDeleteRequest deleteServiceItemUsingDeleteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id" , deleteServiceItemUsingDeleteRequest.ItemId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items/{item_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceItemUsingDeleteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteServiceItemUsingDeleteResponse>(response);
        }
        
        /// <summary>
        /// 删除服务组
        ///
        /// 删除服务组
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServiceSetUsingDeleteResponse> DeleteServiceSetUsingDeleteAsync(DeleteServiceSetUsingDeleteRequest deleteServiceSetUsingDeleteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , deleteServiceSetUsingDeleteRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceSetUsingDeleteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteServiceSetUsingDeleteResponse>(response);
        }
        
        /// <summary>
        /// 查询访问控制日志
        ///
        /// 查询访问控制日志
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessControlLogsResponse> ListAccessControlLogsAsync(ListAccessControlLogsRequest listAccessControlLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-control",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAccessControlLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询地址组成员
        ///
        /// 查询地址组成员
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddressItemsUsingGetResponse> ListAddressItemsUsingGetAsync(ListAddressItemsUsingGetRequest listAddressItemsUsingGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressItemsUsingGetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddressItemsUsingGetResponse>(response);
        }
        
        /// <summary>
        /// 查询地址组详细信息
        ///
        /// 查询地址组详细
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddressSetDetailUsingGetResponse> ListAddressSetDetailUsingGetAsync(ListAddressSetDetailUsingGetRequest listAddressSetDetailUsingGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , listAddressSetDetailUsingGetRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetDetailUsingGetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddressSetDetailUsingGetResponse>(response);
        }
        
        /// <summary>
        /// 查询地址组列表
        ///
        /// 查询地址组列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddressSetListUsingGetResponse> ListAddressSetListUsingGetAsync(ListAddressSetListUsingGetRequest listAddressSetListUsingGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetListUsingGetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddressSetListUsingGetResponse>(response);
        }
        
        /// <summary>
        /// 查询攻击日志
        ///
        /// 查询攻击日志
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListAttackLogsResponse> ListAttackLogsAsync(ListAttackLogsRequest listAttackLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAttackLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询黑白名单列表
        ///
        /// 查询黑白名单列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListBlackWhiteListsUsingGetResponse> ListBlackWhiteListsUsingGetAsync(ListBlackWhiteListsUsingGetRequest listBlackWhiteListsUsingGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlackWhiteListsUsingGetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBlackWhiteListsUsingGetResponse>(response);
        }
        
        /// <summary>
        /// 查询dns服务器列表
        ///
        /// 查询dns服务器列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListDnsServersResponse> ListDnsServersAsync(ListDnsServersRequest listDnsServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDnsServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDnsServersResponse>(response);
        }
        
        /// <summary>
        /// 获取东西向防火墙信息
        ///
        /// 查询东西向防火墙信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListEastWestFirewallResponse> ListEastWestFirewallAsync(ListEastWestFirewallRequest listEastWestFirewallRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEastWestFirewallRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEastWestFirewallResponse>(response);
        }
        
        /// <summary>
        /// 查询防火墙实例
        ///
        /// 查询防火墙实例
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListFirewallUsingGetResponse> ListFirewallUsingGetAsync(ListFirewallUsingGetRequest listFirewallUsingGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/exist",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallUsingGetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFirewallUsingGetResponse>(response);
        }
        
        /// <summary>
        /// 查询流日志
        ///
        /// 查询流日志
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlowLogsResponse> ListFlowLogsAsync(ListFlowLogsRequest listFlowLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlowLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询防护模式
        ///
        /// 查询防护模式
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpsProtectModeUsingPostResponse> ListIpsProtectModeUsingPostAsync(ListIpsProtectModeUsingPostRequest listIpsProtectModeUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsProtectModeUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIpsProtectModeUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 查询域名解析ip地址
        ///
        /// 测试域名有效性
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListParseDomainDetailsResponse> ListParseDomainDetailsAsync(ListParseDomainDetailsRequest listParseDomainDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , listParseDomainDetailsRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse/{domain_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParseDomainDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListParseDomainDetailsResponse>(response);
        }
        
        /// <summary>
        /// 获取规则击中次数
        ///
        /// 获取规则击中次数
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListRuleHitCountResponse> ListRuleHitCountAsync(ListRuleHitCountRequest listRuleHitCountRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleHitCountRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListRuleHitCountResponse>(response);
        }
        
        /// <summary>
        /// 查询服务成员列表
        ///
        /// 查询服务组成员列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceItemsDetailsResponse> ListServiceItemsDetailsAsync(ListServiceItemsDetailsRequest listServiceItemsDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceItemsDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceItemsDetailsResponse>(response);
        }
        
        /// <summary>
        /// 获取服务组列表
        ///
        /// 获取服务组列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceSetResponse> ListServiceSetAsync(ListServiceSetRequest listServiceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceSetResponse>(response);
        }
        
        /// <summary>
        /// 查询服务组详情
        ///
        /// 查询服务组细节
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceSetDetailsResponse> ListServiceSetDetailsAsync(ListServiceSetDetailsRequest listServiceSetDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , listServiceSetDetailsRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceSetDetailsResponse>(response);
        }
        
        /// <summary>
        /// 更新地址组信息
        ///
        /// 更新地址组信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAddressSetInfoUsingPutResponse> UpdateAddressSetInfoUsingPutAsync(UpdateAddressSetInfoUsingPutRequest updateAddressSetInfoUsingPutRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , updateAddressSetInfoUsingPutRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressSetInfoUsingPutRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddressSetInfoUsingPutResponse>(response);
        }
        
        /// <summary>
        /// 更新黑白名单列表
        ///
        /// 更新黑白名单列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBlackWhiteListUsingPutResponse> UpdateBlackWhiteListUsingPutAsync(UpdateBlackWhiteListUsingPutRequest updateBlackWhiteListUsingPutRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id" , updateBlackWhiteListUsingPutRequest.ListId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListUsingPutRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListUsingPutResponse>(response);
        }
        
        /// <summary>
        /// 更新dns服务器列表
        ///
        /// 更新dns服务器列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDnsServersResponse> UpdateDnsServersAsync(UpdateDnsServersRequest updateDnsServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDnsServersResponse>(response);
        }
        
        /// <summary>
        /// 修改服务组
        ///
        /// 更新服务组
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServiceSetUsingPutResponse> UpdateServiceSetUsingPutAsync(UpdateServiceSetUsingPutRequest updateServiceSetUsingPutRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id" , updateServiceSetUsingPutRequest.SetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceSetUsingPutRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateServiceSetUsingPutResponse>(response);
        }
        
        /// <summary>
        /// 创建ACL规则
        ///
        /// 创建ACL规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<AddRuleAclUsingPostResponse> AddRuleAclUsingPostAsync(AddRuleAclUsingPostRequest addRuleAclUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRuleAclUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddRuleAclUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 删除ACL规则组
        ///
        /// 删除ACL规则组
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRuleAclUsingDeleteResponse> DeleteRuleAclUsingDeleteAsync(DeleteRuleAclUsingDeleteRequest deleteRuleAclUsingDeleteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id" , deleteRuleAclUsingDeleteRequest.AclRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleAclUsingDeleteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteRuleAclUsingDeleteResponse>(response);
        }
        
        /// <summary>
        /// ACL防护规则优先级设置
        ///
        /// ACL防护规则优先级设置
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListRuleAclUsingPutResponse> ListRuleAclUsingPutAsync(ListRuleAclUsingPutRequest listRuleAclUsingPutRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id" , listRuleAclUsingPutRequest.AclRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/order/{acl_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclUsingPutRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ListRuleAclUsingPutResponse>(response);
        }
        
        /// <summary>
        /// 查询防护规则
        ///
        /// 查询防护规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListRuleAclsUsingGetResponse> ListRuleAclsUsingGetAsync(ListRuleAclsUsingGetRequest listRuleAclsUsingGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclsUsingGetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRuleAclsUsingGetResponse>(response);
        }
        
        /// <summary>
        /// 更新ACL规则
        ///
        /// 更新ACL规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRuleAclUsingPutResponse> UpdateRuleAclUsingPutAsync(UpdateRuleAclUsingPutRequest updateRuleAclUsingPutRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id" , updateRuleAclUsingPutRequest.AclRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleAclUsingPutRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRuleAclUsingPutResponse>(response);
        }
        
        /// <summary>
        /// 弹性IP开启关闭
        ///
        /// 开启关闭EIP
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeProtectEipResponse> ChangeProtectEipAsync(ChangeProtectEipRequest changeProtectEipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeProtectEipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeProtectEipResponse>(response);
        }
        
        /// <summary>
        /// 查询Eip个数
        ///
        /// 查询Eip个数
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<CountEipsResponse> CountEipsAsync(CountEipsRequest countEipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("object_id" , countEipsRequest.ObjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip-count/{object_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", countEipsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CountEipsResponse>(response);
        }
        
        /// <summary>
        /// 弹性IP列表查询
        ///
        /// 弹性IP列表查询
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListEipResourcesResponse> ListEipResourcesAsync(ListEipResourcesRequest listEipResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eips/protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEipResourcesResponse>(response);
        }
        
        /// <summary>
        /// IPS特性开关操作
        ///
        /// 切换开关状态
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeIpsSwitchUsingPostResponse> ChangeIpsSwitchUsingPostAsync(ChangeIpsSwitchUsingPostRequest changeIpsSwitchUsingPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsSwitchUsingPostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeIpsSwitchUsingPostResponse>(response);
        }
        
        /// <summary>
        /// 查询IPS特性开关状态
        ///
        /// 查询IPS特性开关状态
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpsSwitchStatusUsingGetResponse> ListIpsSwitchStatusUsingGetAsync(ListIpsSwitchStatusUsingGetRequest listIpsSwitchStatusUsingGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsSwitchStatusUsingGetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIpsSwitchStatusUsingGetResponse>(response);
        }
        
        /// <summary>
        /// 查询防护VPC数
        ///
        /// 查询防护vpc信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListVpcProtectsResponse> ListVpcProtectsAsync(ListVpcProtectsRequest listVpcProtectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/protection",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcProtectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVpcProtectsResponse>(response);
        }
        
    }
}