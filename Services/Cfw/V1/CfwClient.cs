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
        /// 取消抓包任务
        ///
        /// 取消抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelCaptureTaskResponse CancelCaptureTask(CancelCaptureTaskRequest cancelCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelCaptureTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CancelCaptureTaskResponse>(response);
        }

        public SyncInvoker<CancelCaptureTaskResponse> CancelCaptureTaskInvoker(CancelCaptureTaskRequest cancelCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelCaptureTaskRequest);
            return new SyncInvoker<CancelCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 创建抓包任务
        ///
        /// 创建抓包任务，每个任务只能执行一次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCaptureTaskResponse CreateCaptureTask(CreateCaptureTaskRequest createCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCaptureTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCaptureTaskResponse>(response);
        }

        public SyncInvoker<CreateCaptureTaskResponse> CreateCaptureTaskInvoker(CreateCaptureTaskRequest createCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCaptureTaskRequest);
            return new SyncInvoker<CreateCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 批量删除抓包任务
        ///
        /// 批量删除抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCaptureTaskResponse DeleteCaptureTask(DeleteCaptureTaskRequest deleteCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCaptureTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteCaptureTaskResponse>(response);
        }

        public SyncInvoker<DeleteCaptureTaskResponse> DeleteCaptureTaskInvoker(DeleteCaptureTaskRequest deleteCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCaptureTaskRequest);
            return new SyncInvoker<DeleteCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 删除已经导入的IP黑名单
        ///
        /// 删除流量过滤功能下已经导入的IP黑名单，指定生效范围进行删除。 标准版的墙只会存在生效范围为EIP的IP黑名单，专业版的墙会存在生效范围为EIP和NAT的IP黑名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteIpBlacklistResponse DeleteIpBlacklist(DeleteIpBlacklistRequest deleteIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpBlacklistRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteIpBlacklistResponse>(response);
        }

        public SyncInvoker<DeleteIpBlacklistResponse> DeleteIpBlacklistInvoker(DeleteIpBlacklistRequest deleteIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpBlacklistRequest);
            return new SyncInvoker<DeleteIpBlacklistResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 开启或者关闭流量过滤的IP黑名单功能
        ///
        /// 开启或者关闭流量过滤功能，当前流量过滤是通过导入IP黑名单实现的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableIpBlacklistResponse EnableIpBlacklist(EnableIpBlacklistRequest enableIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableIpBlacklistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableIpBlacklistResponse>(response);
        }

        public SyncInvoker<EnableIpBlacklistResponse> EnableIpBlacklistInvoker(EnableIpBlacklistRequest enableIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableIpBlacklistRequest);
            return new SyncInvoker<EnableIpBlacklistResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 导出用于流量过滤的IP黑名单
        ///
        /// 指定IP黑名单的名字进行导出，当前只有两种文件名，在EIP生效的文件名为ip-blacklist-eip.txt，在 NAT生效的文件名为ip-blacklist-nat.txt。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportIpBlacklistResponse ExportIpBlacklist(ExportIpBlacklistRequest exportIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportIpBlacklistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportIpBlacklistResponse>(response);
        }

        public SyncInvoker<ExportIpBlacklistResponse> ExportIpBlacklistInvoker(ExportIpBlacklistRequest exportIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportIpBlacklistRequest);
            return new SyncInvoker<ExportIpBlacklistResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportIpBlacklistResponse>);
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
        public ImportIpBlacklistResponse ImportIpBlacklist(ImportIpBlacklistRequest importIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importIpBlacklistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportIpBlacklistResponse>(response);
        }

        public SyncInvoker<ImportIpBlacklistResponse> ImportIpBlacklistInvoker(ImportIpBlacklistRequest importIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importIpBlacklistRequest);
            return new SyncInvoker<ImportIpBlacklistResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 获取抓包任务结果
        ///
        /// 获取抓包任务结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCaptureResultResponse ListCaptureResult(ListCaptureResultRequest listCaptureResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/capture-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCaptureResultResponse>(response);
        }

        public SyncInvoker<ListCaptureResultResponse> ListCaptureResultInvoker(ListCaptureResultRequest listCaptureResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/capture-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureResultRequest);
            return new SyncInvoker<ListCaptureResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCaptureResultResponse>);
        }
        
        /// <summary>
        /// 查询抓包任务
        ///
        /// 查询抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCaptureTaskResponse ListCaptureTask(ListCaptureTaskRequest listCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCaptureTaskResponse>(response);
        }

        public SyncInvoker<ListCaptureTaskResponse> ListCaptureTaskInvoker(ListCaptureTaskRequest listCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureTaskRequest);
            return new SyncInvoker<ListCaptureTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 获取导入的IP黑名单列表信息
        ///
        /// 获取防火墙实例中已经导入的IP黑名单信息，标准版防火墙只会显示一条EIP的记录，专业版防火墙可能显示EIP、NAT或EIP和NAT的记录，根据导入的情况确定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpBlacklistResponse ListIpBlacklist(ListIpBlacklistRequest listIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpBlacklistRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpBlacklistResponse>(response);
        }

        public SyncInvoker<ListIpBlacklistResponse> ListIpBlacklistInvoker(ListIpBlacklistRequest listIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpBlacklistRequest);
            return new SyncInvoker<ListIpBlacklistResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 获取流量过滤功能的开关信息
        ///
        /// 流量过滤功能可以打开或者关闭，通过此接口可以获取当前的开关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpBlacklistSwitchResponse ListIpBlacklistSwitch(ListIpBlacklistSwitchRequest listIpBlacklistSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpBlacklistSwitchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpBlacklistSwitchResponse>(response);
        }

        public SyncInvoker<ListIpBlacklistSwitchResponse> ListIpBlacklistSwitchInvoker(ListIpBlacklistSwitchRequest listIpBlacklistSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpBlacklistSwitchRequest);
            return new SyncInvoker<ListIpBlacklistSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpBlacklistSwitchResponse>);
        }
        
        /// <summary>
        /// 查询标签信息
        ///
        /// 查询标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectTagsResponse ListProjectTags(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public SyncInvoker<ListProjectTagsResponse> ListProjectTagsInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new SyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签信息
        ///
        /// 查询资源标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }

        public SyncInvoker<ListResourceTagsResponse> ListResourceTagsInvoker(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            return new SyncInvoker<ListResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTagsResponse>);
        }
        
        /// <summary>
        /// 用于流量过滤的IP黑名单导入失败后进行重新导入
        ///
        /// 用于流量过滤的IP黑名单导入失败后，调用此接口进行重试。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryIpBlacklistResponse RetryIpBlacklist(RetryIpBlacklistRequest retryIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryIpBlacklistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RetryIpBlacklistResponse>(response);
        }

        public SyncInvoker<RetryIpBlacklistResponse> RetryIpBlacklistInvoker(RetryIpBlacklistRequest retryIpBlacklistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ptf/ip-blacklist/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryIpBlacklistRequest);
            return new SyncInvoker<RetryIpBlacklistResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryIpBlacklistResponse>);
        }
        
        /// <summary>
        /// 保存资源标签接口
        ///
        /// 保存资源标签接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SaveTagsResponse SaveTags(SaveTagsRequest saveTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(saveTagsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/save", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTagsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SaveTagsResponse>(response);
        }

        public SyncInvoker<SaveTagsResponse> SaveTagsInvoker(SaveTagsRequest saveTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(saveTagsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/save", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTagsRequest);
            return new SyncInvoker<SaveTagsResponse>(this, "PUT", request, JsonUtils.DeSerialize<SaveTagsResponse>);
        }
        
        /// <summary>
        /// 获取告警配置信息
        ///
        /// 获取告警配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAlarmConfigResponse ShowAlarmConfig(ShowAlarmConfigRequest showAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/alarm/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmConfigResponse>(response);
        }

        public SyncInvoker<ShowAlarmConfigResponse> ShowAlarmConfigInvoker(ShowAlarmConfigRequest showAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/alarm/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            return new SyncInvoker<ShowAlarmConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmConfigResponse>);
        }
        
        /// <summary>
        /// 获取防火墙反病毒规则信息
        ///
        /// 获取防火墙反病毒规则信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAntiVirusRuleResponse ShowAntiVirusRule(ShowAntiVirusRuleRequest showAntiVirusRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAntiVirusRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAntiVirusRuleResponse>(response);
        }

        public SyncInvoker<ShowAntiVirusRuleResponse> ShowAntiVirusRuleInvoker(ShowAntiVirusRuleRequest showAntiVirusRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAntiVirusRuleRequest);
            return new SyncInvoker<ShowAntiVirusRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAntiVirusRuleResponse>);
        }
        
        /// <summary>
        /// 查看反病毒开关
        ///
        /// 查看反病毒开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAntiVirusSwitchResponse ShowAntiVirusSwitch(ShowAntiVirusSwitchRequest showAntiVirusSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAntiVirusSwitchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAntiVirusSwitchResponse>(response);
        }

        public SyncInvoker<ShowAntiVirusSwitchResponse> ShowAntiVirusSwitchInvoker(ShowAntiVirusSwitchRequest showAntiVirusSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAntiVirusSwitchRequest);
            return new SyncInvoker<ShowAntiVirusSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAntiVirusSwitchResponse>);
        }
        
        /// <summary>
        /// 修改告警配置接口
        ///
        /// 修改告警配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmConfigResponse UpdateAlarmConfig(UpdateAlarmConfigRequest updateAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/alarm/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAlarmConfigResponse>(response);
        }

        public SyncInvoker<UpdateAlarmConfigResponse> UpdateAlarmConfigInvoker(UpdateAlarmConfigRequest updateAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/alarm/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            return new SyncInvoker<UpdateAlarmConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAlarmConfigResponse>);
        }
        
        /// <summary>
        /// 修改反病毒规则
        ///
        /// 修改反病毒规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAntiVirusRuleResponse UpdateAntiVirusRule(UpdateAntiVirusRuleRequest updateAntiVirusRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAntiVirusRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAntiVirusRuleResponse>(response);
        }

        public SyncInvoker<UpdateAntiVirusRuleResponse> UpdateAntiVirusRuleInvoker(UpdateAntiVirusRuleRequest updateAntiVirusRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAntiVirusRuleRequest);
            return new SyncInvoker<UpdateAntiVirusRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAntiVirusRuleResponse>);
        }
        
        /// <summary>
        /// 修改反病毒开关
        ///
        /// 修改反病毒开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAntiVirusSwitchResponse UpdateAntiVirusSwitch(UpdateAntiVirusSwitchRequest updateAntiVirusSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAntiVirusSwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAntiVirusSwitchResponse>(response);
        }

        public SyncInvoker<UpdateAntiVirusSwitchResponse> UpdateAntiVirusSwitchInvoker(UpdateAntiVirusSwitchRequest updateAntiVirusSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/anti-virus/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAntiVirusSwitchRequest);
            return new SyncInvoker<UpdateAntiVirusSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAntiVirusSwitchResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAclRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAclRuleResponse>(response);
        }

        public SyncInvoker<AddAclRuleResponse> AddAclRuleInvoker(AddAclRuleRequest addAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAclRuleRequest);
            return new SyncInvoker<AddAclRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAclRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAclRulesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteAclRulesResponse>(response);
        }

        public SyncInvoker<BatchDeleteAclRulesResponse> BatchDeleteAclRulesInvoker(BatchDeleteAclRulesRequest batchDeleteAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAclRulesRequest);
            return new SyncInvoker<BatchDeleteAclRulesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteAclRulesResponse>);
        }
        
        /// <summary>
        /// 批量更新规则动作
        ///
        /// 批量更新规则动作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateAclRuleActionsResponse BatchUpdateAclRuleActions(BatchUpdateAclRuleActionsRequest batchUpdateAclRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAclRuleActionsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateAclRuleActionsResponse>(response);
        }

        public SyncInvoker<BatchUpdateAclRuleActionsResponse> BatchUpdateAclRuleActionsInvoker(BatchUpdateAclRuleActionsRequest batchUpdateAclRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAclRuleActionsRequest);
            return new SyncInvoker<BatchUpdateAclRuleActionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateAclRuleActionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAclRuleRequest.AclRuleId, out var valueOfAclRuleId)) urlParam.Add("acl_rule_id", valueOfAclRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAclRuleResponse>(response);
        }

        public SyncInvoker<DeleteAclRuleResponse> DeleteAclRuleInvoker(DeleteAclRuleRequest deleteAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAclRuleRequest.AclRuleId, out var valueOfAclRuleId)) urlParam.Add("acl_rule_id", valueOfAclRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleRequest);
            return new SyncInvoker<DeleteAclRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAclRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleHitCountRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAclRuleHitCountResponse>(response);
        }

        public SyncInvoker<DeleteAclRuleHitCountResponse> DeleteAclRuleHitCountInvoker(DeleteAclRuleHitCountRequest deleteAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleHitCountRequest);
            return new SyncInvoker<DeleteAclRuleHitCountResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAclRuleHitCountResponse>);
        }
        
        /// <summary>
        /// 下载导出结果
        ///
        /// 下载导出结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadExportResultResponse DownloadExportResult(DownloadExportResultRequest downloadExportResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/export-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadExportResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadExportResultResponse>(response);
        }

        public SyncInvoker<DownloadExportResultResponse> DownloadExportResultInvoker(DownloadExportResultRequest downloadExportResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/export-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadExportResultRequest);
            return new SyncInvoker<DownloadExportResultResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadExportResultResponse>);
        }
        
        /// <summary>
        /// 下载导入规则
        ///
        /// 下载导入规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadImportResultResponse DownloadImportResult(DownloadImportResultRequest downloadImportResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadImportResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadImportResultResponse>(response);
        }

        public SyncInvoker<DownloadImportResultResponse> DownloadImportResultInvoker(DownloadImportResultRequest downloadImportResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadImportResultRequest);
            return new SyncInvoker<DownloadImportResultResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadImportResultResponse>);
        }
        
        /// <summary>
        /// 下载导入模板
        ///
        /// 下载导入模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadImportTemplateResponse DownloadImportTemplate(DownloadImportTemplateRequest downloadImportTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadImportTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadImportTemplateResponse>(response);
        }

        public SyncInvoker<DownloadImportTemplateResponse> DownloadImportTemplateInvoker(DownloadImportTemplateRequest downloadImportTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadImportTemplateRequest);
            return new SyncInvoker<DownloadImportTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadImportTemplateResponse>);
        }
        
        /// <summary>
        /// 导出访问控制规则
        ///
        /// 导出访问控制规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportRuleAclResponse ExportRuleAcl(ExportRuleAclRequest exportRuleAclRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportRuleAclRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportRuleAclResponse>(response);
        }

        public SyncInvoker<ExportRuleAclResponse> ExportRuleAclInvoker(ExportRuleAclRequest exportRuleAclRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportRuleAclRequest);
            return new SyncInvoker<ExportRuleAclResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportRuleAclResponse>);
        }
        
        /// <summary>
        /// 导入访问控制规则
        ///
        /// 导入访问控制规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportRuleAclResponse ImportRuleAcl(ImportRuleAclRequest importRuleAclRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importRuleAclRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportRuleAclResponse>(response);
        }

        public SyncInvoker<ImportRuleAclResponse> ImportRuleAclInvoker(ImportRuleAclRequest importRuleAclRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importRuleAclRequest);
            return new SyncInvoker<ImportRuleAclResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportRuleAclResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitCountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAclRuleHitCountResponse>(response);
        }

        public SyncInvoker<ListAclRuleHitCountResponse> ListAclRuleHitCountInvoker(ListAclRuleHitCountRequest listAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitCountRequest);
            return new SyncInvoker<ListAclRuleHitCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAclRuleHitCountResponse>);
        }
        
        /// <summary>
        /// 获取规则的命中次数和最后一次命中时间
        ///
        /// 获取规则的命中次数和最后一次命中时间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAclRuleHitStatusResponse ListAclRuleHitStatus(ListAclRuleHitStatusRequest listAclRuleHitStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAclRuleHitStatusRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/acl-rule/hit-info/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAclRuleHitStatusResponse>(response);
        }

        public SyncInvoker<ListAclRuleHitStatusResponse> ListAclRuleHitStatusInvoker(ListAclRuleHitStatusRequest listAclRuleHitStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAclRuleHitStatusRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/acl-rule/hit-info/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitStatusRequest);
            return new SyncInvoker<ListAclRuleHitStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAclRuleHitStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAclRulesResponse>(response);
        }

        public SyncInvoker<ListAclRulesResponse> ListAclRulesInvoker(ListAclRulesRequest listAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRulesRequest);
            return new SyncInvoker<ListAclRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAclRulesResponse>);
        }
        
        /// <summary>
        /// 查看region列表
        ///
        /// 查看region列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRegionsResponse ListRegions(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRegionsResponse>(response);
        }

        public SyncInvoker<ListRegionsResponse> ListRegionsInvoker(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            return new SyncInvoker<ListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionsResponse>);
        }
        
        /// <summary>
        /// 查询规则标签
        ///
        /// 查询规则标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRuleAclTagsResponse ListRuleAclTags(ListRuleAclTagsRequest listRuleAclTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-acl/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRuleAclTagsResponse>(response);
        }

        public SyncInvoker<ListRuleAclTagsResponse> ListRuleAclTagsInvoker(ListRuleAclTagsRequest listRuleAclTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-acl/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclTagsRequest);
            return new SyncInvoker<ListRuleAclTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleAclTagsResponse>);
        }
        
        /// <summary>
        /// 查询导出结果
        ///
        /// 查询导出结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowExportStatusResponse ShowExportStatus(ShowExportStatusRequest showExportStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/export-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExportStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowExportStatusResponse>(response);
        }

        public SyncInvoker<ShowExportStatusResponse> ShowExportStatusInvoker(ShowExportStatusRequest showExportStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/export-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExportStatusRequest);
            return new SyncInvoker<ShowExportStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExportStatusResponse>);
        }
        
        /// <summary>
        /// 查看导入状态接口
        ///
        /// 查看导入状态接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImportStatusResponse ShowImportStatus(ShowImportStatusRequest showImportStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImportStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowImportStatusResponse>(response);
        }

        public SyncInvoker<ShowImportStatusResponse> ShowImportStatusInvoker(ShowImportStatusRequest showImportStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/import-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImportStatusRequest);
            return new SyncInvoker<ShowImportStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImportStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclRuleRequest.AclRuleId, out var valueOfAclRuleId)) urlParam.Add("acl_rule_id", valueOfAclRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclRuleResponse>(response);
        }

        public SyncInvoker<UpdateAclRuleResponse> UpdateAclRuleInvoker(UpdateAclRuleRequest updateAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclRuleRequest.AclRuleId, out var valueOfAclRuleId)) urlParam.Add("acl_rule_id", valueOfAclRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleRequest);
            return new SyncInvoker<UpdateAclRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclRuleOrderRequest.AclRuleId, out var valueOfAclRuleId)) urlParam.Add("acl_rule_id", valueOfAclRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/order/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleOrderRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclRuleOrderResponse>(response);
        }

        public SyncInvoker<UpdateAclRuleOrderResponse> UpdateAclRuleOrderInvoker(UpdateAclRuleOrderRequest updateAclRuleOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclRuleOrderRequest.AclRuleId, out var valueOfAclRuleId)) urlParam.Add("acl_rule_id", valueOfAclRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/order/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleOrderRequest);
            return new SyncInvoker<UpdateAclRuleOrderResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclRuleOrderResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressItemRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAddressItemResponse>(response);
        }

        public SyncInvoker<AddAddressItemResponse> AddAddressItemInvoker(AddAddressItemRequest addAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressItemRequest);
            return new SyncInvoker<AddAddressItemResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAddressItemResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAddressSetResponse>(response);
        }

        public SyncInvoker<AddAddressSetResponse> AddAddressSetInvoker(AddAddressSetRequest addAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressSetRequest);
            return new SyncInvoker<AddAddressSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAddressSetResponse>);
        }
        
        /// <summary>
        /// 批量删除地址组成员
        ///
        /// 批量删除地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAddressItemsResponse BatchDeleteAddressItems(BatchDeleteAddressItemsRequest batchDeleteAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressItemsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteAddressItemsResponse>(response);
        }

        public SyncInvoker<BatchDeleteAddressItemsResponse> BatchDeleteAddressItemsInvoker(BatchDeleteAddressItemsRequest batchDeleteAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressItemsRequest);
            return new SyncInvoker<BatchDeleteAddressItemsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteAddressItemsResponse>);
        }
        
        /// <summary>
        /// 批量删除地址组
        ///
        /// 批量删除地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAddressSetsResponse BatchDeleteAddressSets(BatchDeleteAddressSetsRequest batchDeleteAddressSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressSetsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAddressSetsResponse>(response);
        }

        public SyncInvoker<BatchDeleteAddressSetsResponse> BatchDeleteAddressSetsInvoker(BatchDeleteAddressSetsRequest batchDeleteAddressSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressSetsRequest);
            return new SyncInvoker<BatchDeleteAddressSetsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAddressSetsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddressItemRequest.ItemId, out var valueOfItemId)) urlParam.Add("item_id", valueOfItemId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressItemRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAddressItemResponse>(response);
        }

        public SyncInvoker<DeleteAddressItemResponse> DeleteAddressItemInvoker(DeleteAddressItemRequest deleteAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddressItemRequest.ItemId, out var valueOfItemId)) urlParam.Add("item_id", valueOfItemId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressItemRequest);
            return new SyncInvoker<DeleteAddressItemResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAddressItemResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddressSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAddressSetResponse>(response);
        }

        public SyncInvoker<DeleteAddressSetResponse> DeleteAddressSetInvoker(DeleteAddressSetRequest deleteAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddressSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressSetRequest);
            return new SyncInvoker<DeleteAddressSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAddressSetResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressItemsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddressItemsResponse>(response);
        }

        public SyncInvoker<ListAddressItemsResponse> ListAddressItemsInvoker(ListAddressItemsRequest listAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressItemsRequest);
            return new SyncInvoker<ListAddressItemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressItemsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAddressSetDetailRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddressSetDetailResponse>(response);
        }

        public SyncInvoker<ListAddressSetDetailResponse> ListAddressSetDetailInvoker(ListAddressSetDetailRequest listAddressSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAddressSetDetailRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetDetailRequest);
            return new SyncInvoker<ListAddressSetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressSetDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddressSetsResponse>(response);
        }

        public SyncInvoker<ListAddressSetsResponse> ListAddressSetsInvoker(ListAddressSetsRequest listAddressSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetsRequest);
            return new SyncInvoker<ListAddressSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressSetsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAddressSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddressSetResponse>(response);
        }

        public SyncInvoker<UpdateAddressSetResponse> UpdateAddressSetInvoker(UpdateAddressSetRequest updateAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAddressSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressSetRequest);
            return new SyncInvoker<UpdateAddressSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddressSetResponse>);
        }
        
        /// <summary>
        /// 更新对象配置描述
        ///
        /// 更新对象配置描述
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateObjectConfigDescResponse UpdateObjectConfigDesc(UpdateObjectConfigDescRequest updateObjectConfigDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/config/object/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateObjectConfigDescRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateObjectConfigDescResponse>(response);
        }

        public SyncInvoker<UpdateObjectConfigDescResponse> UpdateObjectConfigDescInvoker(UpdateObjectConfigDescRequest updateObjectConfigDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/config/object/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateObjectConfigDescRequest);
            return new SyncInvoker<UpdateObjectConfigDescResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateObjectConfigDescResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddBlackWhiteListResponse>(response);
        }

        public SyncInvoker<AddBlackWhiteListResponse> AddBlackWhiteListInvoker(AddBlackWhiteListRequest addBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteListRequest);
            return new SyncInvoker<AddBlackWhiteListResponse>(this, "POST", request, JsonUtils.DeSerialize<AddBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 批量添加黑白名单列表
        ///
        /// 批量添加黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateBlackWhiteListResponse BatchCreateBlackWhiteList(BatchCreateBlackWhiteListRequest batchCreateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateBlackWhiteListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateBlackWhiteListResponse>(response);
        }

        public SyncInvoker<BatchCreateBlackWhiteListResponse> BatchCreateBlackWhiteListInvoker(BatchCreateBlackWhiteListRequest batchCreateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateBlackWhiteListRequest);
            return new SyncInvoker<BatchCreateBlackWhiteListResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 批量删除黑白名单列表
        ///
        /// 批量删除黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteBlackWhiteListsResponse BatchDeleteBlackWhiteLists(BatchDeleteBlackWhiteListsRequest batchDeleteBlackWhiteListsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteBlackWhiteListsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteBlackWhiteListsResponse>(response);
        }

        public SyncInvoker<BatchDeleteBlackWhiteListsResponse> BatchDeleteBlackWhiteListsInvoker(BatchDeleteBlackWhiteListsRequest batchDeleteBlackWhiteListsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteBlackWhiteListsRequest);
            return new SyncInvoker<BatchDeleteBlackWhiteListsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteBlackWhiteListsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBlackWhiteListRequest.ListId, out var valueOfListId)) urlParam.Add("list_id", valueOfListId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteListRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBlackWhiteListResponse>(response);
        }

        public SyncInvoker<DeleteBlackWhiteListResponse> DeleteBlackWhiteListInvoker(DeleteBlackWhiteListRequest deleteBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBlackWhiteListRequest.ListId, out var valueOfListId)) urlParam.Add("list_id", valueOfListId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteListRequest);
            return new SyncInvoker<DeleteBlackWhiteListResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBlackWhiteListResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlackWhiteListsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBlackWhiteListsResponse>(response);
        }

        public SyncInvoker<ListBlackWhiteListsResponse> ListBlackWhiteListsInvoker(ListBlackWhiteListsRequest listBlackWhiteListsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlackWhiteListsRequest);
            return new SyncInvoker<ListBlackWhiteListsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBlackWhiteListsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBlackWhiteListRequest.ListId, out var valueOfListId)) urlParam.Add("list_id", valueOfListId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }

        public SyncInvoker<UpdateBlackWhiteListResponse> UpdateBlackWhiteListInvoker(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBlackWhiteListRequest.ListId, out var valueOfListId)) urlParam.Add("list_id", valueOfListId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            return new SyncInvoker<UpdateBlackWhiteListResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 添加指定DNS服务器
        ///
        /// 添加指定DNS服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddCustomDnsServerResponse AddCustomDnsServer(AddCustomDnsServerRequest addCustomDnsServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addCustomDnsServerRequest.ServerIp, out var valueOfServerIp)) urlParam.Add("server_ip", valueOfServerIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/server/{server_ip}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCustomDnsServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddCustomDnsServerResponse>(response);
        }

        public SyncInvoker<AddCustomDnsServerResponse> AddCustomDnsServerInvoker(AddCustomDnsServerRequest addCustomDnsServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addCustomDnsServerRequest.ServerIp, out var valueOfServerIp)) urlParam.Add("server_ip", valueOfServerIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/server/{server_ip}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCustomDnsServerRequest);
            return new SyncInvoker<AddCustomDnsServerResponse>(this, "POST", request, JsonUtils.DeSerialize<AddCustomDnsServerResponse>);
        }
        
        /// <summary>
        /// 添加域名组
        ///
        /// 添加域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDomainSetResponse AddDomainSet(AddDomainSetRequest addDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDomainSetResponse>(response);
        }

        public SyncInvoker<AddDomainSetResponse> AddDomainSetInvoker(AddDomainSetRequest addDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainSetRequest);
            return new SyncInvoker<AddDomainSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDomainSetResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDomainsRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDomainsResponse>(response);
        }

        public SyncInvoker<AddDomainsResponse> AddDomainsInvoker(AddDomainsRequest addDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDomainsRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainsRequest);
            return new SyncInvoker<AddDomainsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDomainsResponse>);
        }
        
        /// <summary>
        /// 批量删除域名组
        ///
        /// 批量删除域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteDomainSetResponse BatchDeleteDomainSet(BatchDeleteDomainSetRequest batchDeleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDomainSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteDomainSetResponse>(response);
        }

        public SyncInvoker<BatchDeleteDomainSetResponse> BatchDeleteDomainSetInvoker(BatchDeleteDomainSetRequest batchDeleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDomainSetRequest);
            return new SyncInvoker<BatchDeleteDomainSetResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteDomainSetResponse>);
        }
        
        /// <summary>
        /// 删除域名组
        ///
        /// 删除域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainSetResponse DeleteDomainSet(DeleteDomainSetRequest deleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainSetResponse>(response);
        }

        public SyncInvoker<DeleteDomainSetResponse> DeleteDomainSetInvoker(DeleteDomainSetRequest deleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainSetRequest);
            return new SyncInvoker<DeleteDomainSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainSetResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainsRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainsResponse>(response);
        }

        public SyncInvoker<DeleteDomainsResponse> DeleteDomainsInvoker(DeleteDomainsRequest deleteDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainsRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainsRequest);
            return new SyncInvoker<DeleteDomainsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainsResponse>);
        }
        
        /// <summary>
        /// 查询DNS服务器列表
        ///
        /// 查询DNS服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDnsServersResponse ListDnsServers(ListDnsServersRequest listDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDnsServersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDnsServersResponse>(response);
        }

        public SyncInvoker<ListDnsServersResponse> ListDnsServersInvoker(ListDnsServersRequest listDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDnsServersRequest);
            return new SyncInvoker<ListDnsServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDnsServersResponse>);
        }
        
        /// <summary>
        /// 查询域名解析IP地址
        ///
        /// 测试域名有效性
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainParseDetailResponse ListDomainParseDetail(ListDomainParseDetailRequest listDomainParseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainParseDetailRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainParseDetailResponse>(response);
        }

        public SyncInvoker<ListDomainParseDetailResponse> ListDomainParseDetailInvoker(ListDomainParseDetailRequest listDomainParseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainParseDetailRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseDetailRequest);
            return new SyncInvoker<ListDomainParseDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainParseDetailResponse>);
        }
        
        /// <summary>
        /// 获取域名地址解析结果
        ///
        /// 获取域名地址解析结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainParseIpResponse ListDomainParseIp(ListDomainParseIpRequest listDomainParseIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainParseIpRequest.DomainAddressId, out var valueOfDomainAddressId)) urlParam.Add("domain_address_id", valueOfDomainAddressId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse-ip-list/{domain_address_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainParseIpResponse>(response);
        }

        public SyncInvoker<ListDomainParseIpResponse> ListDomainParseIpInvoker(ListDomainParseIpRequest listDomainParseIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainParseIpRequest.DomainAddressId, out var valueOfDomainAddressId)) urlParam.Add("domain_address_id", valueOfDomainAddressId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse-ip-list/{domain_address_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseIpRequest);
            return new SyncInvoker<ListDomainParseIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainParseIpResponse>);
        }
        
        /// <summary>
        /// 获取域名解析结果
        ///
        /// 获取域名解析结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainResolveIpResponse ListDomainResolveIp(ListDomainResolveIpRequest listDomainResolveIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainResolveIpRequest.DomainAddressId, out var valueOfDomainAddressId)) urlParam.Add("domain_address_id", valueOfDomainAddressId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule/domain/resolve-ip-list/{domain_address_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainResolveIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainResolveIpResponse>(response);
        }

        public SyncInvoker<ListDomainResolveIpResponse> ListDomainResolveIpInvoker(ListDomainResolveIpRequest listDomainResolveIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainResolveIpRequest.DomainAddressId, out var valueOfDomainAddressId)) urlParam.Add("domain_address_id", valueOfDomainAddressId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule/domain/resolve-ip-list/{domain_address_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainResolveIpRequest);
            return new SyncInvoker<ListDomainResolveIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainResolveIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainSetsResponse>(response);
        }

        public SyncInvoker<ListDomainSetsResponse> ListDomainSetsInvoker(ListDomainSetsRequest listDomainSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainSetsRequest);
            return new SyncInvoker<ListDomainSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainSetsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainsRequest.DomainSetId, out var valueOfDomainSetId)) urlParam.Add("domain_set_id", valueOfDomainSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }

        public SyncInvoker<ListDomainsResponse> ListDomainsInvoker(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainsRequest.DomainSetId, out var valueOfDomainSetId)) urlParam.Add("domain_set_id", valueOfDomainSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            return new SyncInvoker<ListDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainsResponse>);
        }
        
        /// <summary>
        /// 查看域名组详情
        ///
        /// 查看域名组详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainSetDetailResponse ShowDomainSetDetail(ShowDomainSetDetailRequest showDomainSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainSetDetailRequest.DomainSetId, out var valueOfDomainSetId)) urlParam.Add("domain_set_id", valueOfDomainSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainSetDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainSetDetailResponse>(response);
        }

        public SyncInvoker<ShowDomainSetDetailResponse> ShowDomainSetDetailInvoker(ShowDomainSetDetailRequest showDomainSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainSetDetailRequest.DomainSetId, out var valueOfDomainSetId)) urlParam.Add("domain_set_id", valueOfDomainSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainSetDetailRequest);
            return new SyncInvoker<ShowDomainSetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainSetDetailResponse>);
        }
        
        /// <summary>
        /// 更新DNS服务器列表
        ///
        /// 更新DNS服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDnsServersResponse UpdateDnsServers(UpdateDnsServersRequest updateDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsServersRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDnsServersResponse>(response);
        }

        public SyncInvoker<UpdateDnsServersResponse> UpdateDnsServersInvoker(UpdateDnsServersRequest updateDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsServersRequest);
            return new SyncInvoker<UpdateDnsServersResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDnsServersResponse>);
        }
        
        /// <summary>
        /// 更新域名组
        ///
        /// 更新域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainSetResponse UpdateDomainSet(UpdateDomainSetRequest updateDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainSetResponse>(response);
        }

        public SyncInvoker<UpdateDomainSetResponse> UpdateDomainSetInvoker(UpdateDomainSetRequest updateDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainSetRequest);
            return new SyncInvoker<UpdateDomainSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainSetResponse>);
        }
        
        /// <summary>
        /// 添加EIP告警白名单
        ///
        /// 添加EIP告警白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddEipAlarmWhitelistResponse AddEipAlarmWhitelist(AddEipAlarmWhitelistRequest addEipAlarmWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/alarm-whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addEipAlarmWhitelistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddEipAlarmWhitelistResponse>(response);
        }

        public SyncInvoker<AddEipAlarmWhitelistResponse> AddEipAlarmWhitelistInvoker(AddEipAlarmWhitelistRequest addEipAlarmWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/alarm-whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addEipAlarmWhitelistRequest);
            return new SyncInvoker<AddEipAlarmWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<AddEipAlarmWhitelistResponse>);
        }
        
        /// <summary>
        /// 弹性IP开启关闭
        ///
        /// 开启关闭EIP，客户购买EIP后首次开启EIP防护前需使用ListEips同步EIP资产，sync字段设置为1。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeEipStatusResponse ChangeEipStatus(ChangeEipStatusRequest changeEipStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEipStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeEipStatusResponse>(response);
        }

        public SyncInvoker<ChangeEipStatusResponse> ChangeEipStatusInvoker(ChangeEipStatusRequest changeEipStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEipStatusRequest);
            return new SyncInvoker<ChangeEipStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeEipStatusResponse>);
        }
        
        /// <summary>
        /// 查看EIP告警白名单
        ///
        /// 查看EIP告警白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmWhitelistResponse ListAlarmWhitelist(ListAlarmWhitelistRequest listAlarmWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmWhitelistRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/alarm-whitelist/{fw_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmWhitelistRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmWhitelistResponse>(response);
        }

        public SyncInvoker<ListAlarmWhitelistResponse> ListAlarmWhitelistInvoker(ListAlarmWhitelistRequest listAlarmWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmWhitelistRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/alarm-whitelist/{fw_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmWhitelistRequest);
            return new SyncInvoker<ListAlarmWhitelistResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmWhitelistResponse>);
        }
        
        /// <summary>
        /// 查询EIP数量
        ///
        /// 查询EIP数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEipCountResponse ListEipCount(ListEipCountRequest listEipCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEipCountRequest.ObjectId, out var valueOfObjectId)) urlParam.Add("object_id", valueOfObjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip-count/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipCountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEipCountResponse>(response);
        }

        public SyncInvoker<ListEipCountResponse> ListEipCountInvoker(ListEipCountRequest listEipCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEipCountRequest.ObjectId, out var valueOfObjectId)) urlParam.Add("object_id", valueOfObjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip-count/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipCountRequest);
            return new SyncInvoker<ListEipCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEipCountResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEipsResponse>(response);
        }

        public SyncInvoker<ListEipsResponse> ListEipsInvoker(ListEipsRequest listEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipsRequest);
            return new SyncInvoker<ListEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEipsResponse>);
        }
        
        /// <summary>
        /// 获取EIP自动防护状态信息
        ///
        /// 获取EIP自动防护状态信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutoProtectStatusResponse ShowAutoProtectStatus(ShowAutoProtectStatusRequest showAutoProtectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoProtectStatusRequest.ObjectId, out var valueOfObjectId)) urlParam.Add("object_id", valueOfObjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/auto-protect-status/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoProtectStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoProtectStatusResponse>(response);
        }

        public SyncInvoker<ShowAutoProtectStatusResponse> ShowAutoProtectStatusInvoker(ShowAutoProtectStatusRequest showAutoProtectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoProtectStatusRequest.ObjectId, out var valueOfObjectId)) urlParam.Add("object_id", valueOfObjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/auto-protect-status/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoProtectStatusRequest);
            return new SyncInvoker<ShowAutoProtectStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoProtectStatusResponse>);
        }
        
        /// <summary>
        /// 修改EIP自动防护开关
        ///
        /// 修改EIP自动防护开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchAutoProtectStatusResponse SwitchAutoProtectStatus(SwitchAutoProtectStatusRequest switchAutoProtectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/auto-protect-status/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchAutoProtectStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchAutoProtectStatusResponse>(response);
        }

        public SyncInvoker<SwitchAutoProtectStatusResponse> SwitchAutoProtectStatusInvoker(SwitchAutoProtectStatusRequest switchAutoProtectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/auto-protect-status/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchAutoProtectStatusRequest);
            return new SyncInvoker<SwitchAutoProtectStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAutoProtectStatusResponse>);
        }
        
        /// <summary>
        /// 一键逃生/一键恢复开关
        ///
        /// 一键逃生/一键恢复开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchFirewallEipProtectionResponse SwitchFirewallEipProtection(SwitchFirewallEipProtectionRequest switchFirewallEipProtectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchFirewallEipProtectionRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect/all/{fw_instance_id}/operation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchFirewallEipProtectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchFirewallEipProtectionResponse>(response);
        }

        public SyncInvoker<SwitchFirewallEipProtectionResponse> SwitchFirewallEipProtectionInvoker(SwitchFirewallEipProtectionRequest switchFirewallEipProtectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchFirewallEipProtectionRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect/all/{fw_instance_id}/operation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchFirewallEipProtectionRequest);
            return new SyncInvoker<SwitchFirewallEipProtectionResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchFirewallEipProtectionResponse>);
        }
        
        /// <summary>
        /// 创建东西向防火墙
        ///
        /// 创建东西向防火墙
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEastWestFirewallResponse CreateEastWestFirewall(CreateEastWestFirewallRequest createEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEastWestFirewallRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEastWestFirewallResponse>(response);
        }

        public SyncInvoker<CreateEastWestFirewallResponse> CreateEastWestFirewallInvoker(CreateEastWestFirewallRequest createEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEastWestFirewallRequest);
            return new SyncInvoker<CreateEastWestFirewallResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEastWestFirewallResponse>);
        }
        
        /// <summary>
        /// 创建防火墙
        ///
        /// 创建防火墙
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFirewallResponse CreateFirewall(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFirewallResponse>(response);
        }

        public SyncInvoker<CreateFirewallResponse> CreateFirewallInvoker(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            return new SyncInvoker<CreateFirewallResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFirewallResponse>);
        }
        
        /// <summary>
        /// 标签创建接口
        ///
        /// 创建标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResponse CreateTag(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public SyncInvoker<CreateTagResponse> CreateTagInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new SyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除防火墙
        ///
        /// 删除防火墙，仅按需生效
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFirewallResponse DeleteFirewall(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFirewallRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFirewallResponse>(response);
        }

        public SyncInvoker<DeleteFirewallResponse> DeleteFirewallInvoker(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFirewallRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            return new SyncInvoker<DeleteFirewallResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFirewallResponse>);
        }
        
        /// <summary>
        /// 删除标签
        ///
        /// 删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public SyncInvoker<DeleteTagResponse> DeleteTagInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new SyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEastWestFirewallRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEastWestFirewallResponse>(response);
        }

        public SyncInvoker<ListEastWestFirewallResponse> ListEastWestFirewallInvoker(ListEastWestFirewallRequest listEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEastWestFirewallRequest);
            return new SyncInvoker<ListEastWestFirewallResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEastWestFirewallResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFirewallDetailResponse>(response);
        }

        public SyncInvoker<ListFirewallDetailResponse> ListFirewallDetailInvoker(ListFirewallDetailRequest listFirewallDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallDetailRequest);
            return new SyncInvoker<ListFirewallDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFirewallDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewalls/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListFirewallListResponse>(response);
        }

        public SyncInvoker<ListFirewallListResponse> ListFirewallListInvoker(ListFirewallListRequest listFirewallListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewalls/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallListRequest);
            return new SyncInvoker<ListFirewallListResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFirewallListResponse>);
        }
        
        /// <summary>
        /// 获取CFW任务执行状态
        ///
        /// 获取CFW任务执行状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobResponse ListJob(ListJobRequest listJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobResponse>(response);
        }

        public SyncInvoker<ListJobResponse> ListJobInvoker(ListJobRequest listJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobRequest);
            return new SyncInvoker<ListJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/protection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedVpcsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProtectedVpcsResponse>(response);
        }

        public SyncInvoker<ListProtectedVpcsResponse> ListProtectedVpcsInvoker(ListProtectedVpcsRequest listProtectedVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/protection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedVpcsRequest);
            return new SyncInvoker<ListProtectedVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProtectedVpcsResponse>);
        }
        
        /// <summary>
        /// 查询防火墙配额信息
        ///
        /// 查询防火墙配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigQuotaResponse ShowConfigQuota(ShowConfigQuotaRequest showConfigQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigQuotaRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw/{fw_instance_id}/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigQuotaResponse>(response);
        }

        public SyncInvoker<ShowConfigQuotaResponse> ShowConfigQuotaInvoker(ShowConfigQuotaRequest showConfigQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigQuotaRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw/{fw_instance_id}/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigQuotaRequest);
            return new SyncInvoker<ShowConfigQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigQuotaResponse>);
        }
        
        /// <summary>
        /// 查询南北向防火墙防护状态
        ///
        /// 查询南北向防火墙防护状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSnFirewallProtectionStatusResponse ShowSnFirewallProtectionStatus(ShowSnFirewallProtectionStatusRequest showSnFirewallProtectionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSnFirewallProtectionStatusRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protection-status/{fw_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnFirewallProtectionStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSnFirewallProtectionStatusResponse>(response);
        }

        public SyncInvoker<ShowSnFirewallProtectionStatusResponse> ShowSnFirewallProtectionStatusInvoker(ShowSnFirewallProtectionStatusRequest showSnFirewallProtectionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSnFirewallProtectionStatusRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protection-status/{fw_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnFirewallProtectionStatusRequest);
            return new SyncInvoker<ShowSnFirewallProtectionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSnFirewallProtectionStatusResponse>);
        }
        
        /// <summary>
        /// 更改防火墙名称
        ///
        /// 更改防火墙名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFirewallNameResponse UpdateFirewallName(UpdateFirewallNameRequest updateFirewallNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFirewallNameResponse>(response);
        }

        public SyncInvoker<UpdateFirewallNameResponse> UpdateFirewallNameInvoker(UpdateFirewallNameRequest updateFirewallNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallNameRequest);
            return new SyncInvoker<UpdateFirewallNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFirewallNameResponse>);
        }
        
        /// <summary>
        /// 批量删除自定义IPS规则
        ///
        /// 批量删除自定义IPS规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteCustomerIpsResponse BatchDeleteCustomerIps(BatchDeleteCustomerIpsRequest batchDeleteCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteCustomerIpsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteCustomerIpsResponse>(response);
        }

        public SyncInvoker<BatchDeleteCustomerIpsResponse> BatchDeleteCustomerIpsInvoker(BatchDeleteCustomerIpsRequest batchDeleteCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteCustomerIpsRequest);
            return new SyncInvoker<BatchDeleteCustomerIpsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteCustomerIpsResponse>);
        }
        
        /// <summary>
        /// 批量更新自定义IPS规则的动作
        ///
        /// 批量更新自定义IPS规则的动作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateCustomerIpsActionResponse BatchUpdateCustomerIpsAction(BatchUpdateCustomerIpsActionRequest batchUpdateCustomerIpsActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateCustomerIpsActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdateCustomerIpsActionResponse>(response);
        }

        public SyncInvoker<BatchUpdateCustomerIpsActionResponse> BatchUpdateCustomerIpsActionInvoker(BatchUpdateCustomerIpsActionRequest batchUpdateCustomerIpsActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateCustomerIpsActionRequest);
            return new SyncInvoker<BatchUpdateCustomerIpsActionResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdateCustomerIpsActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsProtectModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeIpsProtectModeResponse>(response);
        }

        public SyncInvoker<ChangeIpsProtectModeResponse> ChangeIpsProtectModeInvoker(ChangeIpsProtectModeRequest changeIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsProtectModeRequest);
            return new SyncInvoker<ChangeIpsProtectModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeIpsProtectModeResponse>);
        }
        
        /// <summary>
        /// 改变IPS规则模式
        ///
        /// 改变IPS规则模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeIpsRuleModeResponse ChangeIpsRuleMode(ChangeIpsRuleModeRequest changeIpsRuleModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsRuleModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeIpsRuleModeResponse>(response);
        }

        public SyncInvoker<ChangeIpsRuleModeResponse> ChangeIpsRuleModeInvoker(ChangeIpsRuleModeRequest changeIpsRuleModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsRuleModeRequest);
            return new SyncInvoker<ChangeIpsRuleModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeIpsRuleModeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsSwitchStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeIpsSwitchStatusResponse>(response);
        }

        public SyncInvoker<ChangeIpsSwitchStatusResponse> ChangeIpsSwitchStatusInvoker(ChangeIpsSwitchStatusRequest changeIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsSwitchStatusRequest);
            return new SyncInvoker<ChangeIpsSwitchStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeIpsSwitchStatusResponse>);
        }
        
        /// <summary>
        /// 创建自定义IPS规则
        ///
        /// 创建自定义IPS规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCustomerIpsResponse CreateCustomerIps(CreateCustomerIpsRequest createCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomerIpsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCustomerIpsResponse>(response);
        }

        public SyncInvoker<CreateCustomerIpsResponse> CreateCustomerIpsInvoker(CreateCustomerIpsRequest createCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomerIpsRequest);
            return new SyncInvoker<CreateCustomerIpsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCustomerIpsResponse>);
        }
        
        /// <summary>
        /// 查询频率IPS规则信息
        ///
        /// 查询频率IPS规则信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAdvancedIpsRulesResponse ListAdvancedIpsRules(ListAdvancedIpsRulesRequest listAdvancedIpsRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/advanced-ips-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdvancedIpsRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAdvancedIpsRulesResponse>(response);
        }

        public SyncInvoker<ListAdvancedIpsRulesResponse> ListAdvancedIpsRulesInvoker(ListAdvancedIpsRulesRequest listAdvancedIpsRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/advanced-ips-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdvancedIpsRulesRequest);
            return new SyncInvoker<ListAdvancedIpsRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAdvancedIpsRulesResponse>);
        }
        
        /// <summary>
        /// 查看自定义IPS规则列表
        ///
        /// 查看自定义IPS规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCustomerIpsResponse ListCustomerIps(ListCustomerIpsRequest listCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerIpsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCustomerIpsResponse>(response);
        }

        public SyncInvoker<ListCustomerIpsResponse> ListCustomerIpsInvoker(ListCustomerIpsRequest listCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerIpsRequest);
            return new SyncInvoker<ListCustomerIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomerIpsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsProtectModeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpsProtectModeResponse>(response);
        }

        public SyncInvoker<ListIpsProtectModeResponse> ListIpsProtectModeInvoker(ListIpsProtectModeRequest listIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsProtectModeRequest);
            return new SyncInvoker<ListIpsProtectModeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsProtectModeResponse>);
        }
        
        /// <summary>
        /// 获取IPS规则列表
        ///
        /// 获取IPS规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpsRulesResponse ListIpsRules(ListIpsRulesRequest listIpsRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpsRulesResponse>(response);
        }

        public SyncInvoker<ListIpsRulesResponse> ListIpsRulesInvoker(ListIpsRulesRequest listIpsRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsRulesRequest);
            return new SyncInvoker<ListIpsRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsSwitchStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpsSwitchStatusResponse>(response);
        }

        public SyncInvoker<ListIpsSwitchStatusResponse> ListIpsSwitchStatusInvoker(ListIpsSwitchStatusRequest listIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsSwitchStatusRequest);
            return new SyncInvoker<ListIpsSwitchStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsSwitchStatusResponse>);
        }
        
        /// <summary>
        /// 查询自定义IPS规则详情
        ///
        /// 功能说明：自定义IPS规则详情，特性:根据路径输入的IPS ID查看对应的自定义IPS详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCustomerIpsInfoResponse ShowCustomerIpsInfo(ShowCustomerIpsInfoRequest showCustomerIpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCustomerIpsInfoRequest.IpsCfwId, out var valueOfIpsCfwId)) urlParam.Add("ips_cfw_id", valueOfIpsCfwId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/{ips_cfw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerIpsInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCustomerIpsInfoResponse>(response);
        }

        public SyncInvoker<ShowCustomerIpsInfoResponse> ShowCustomerIpsInfoInvoker(ShowCustomerIpsInfoRequest showCustomerIpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCustomerIpsInfoRequest.IpsCfwId, out var valueOfIpsCfwId)) urlParam.Add("ips_cfw_id", valueOfIpsCfwId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/{ips_cfw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerIpsInfoRequest);
            return new SyncInvoker<ShowCustomerIpsInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCustomerIpsInfoResponse>);
        }
        
        /// <summary>
        /// 获取IPS规则细节
        ///
        /// 获取IPS规则细节
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpsUpdateTimeResponse ShowIpsUpdateTime(ShowIpsUpdateTimeRequest showIpsUpdateTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpsUpdateTimeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpsUpdateTimeResponse>(response);
        }

        public SyncInvoker<ShowIpsUpdateTimeResponse> ShowIpsUpdateTimeInvoker(ShowIpsUpdateTimeRequest showIpsUpdateTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips-rule/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpsUpdateTimeRequest);
            return new SyncInvoker<ShowIpsUpdateTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpsUpdateTimeResponse>);
        }
        
        /// <summary>
        /// 创建频率IPS规则
        ///
        /// 创建频率IPS规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAdvancedIpsRuleResponse UpdateAdvancedIpsRule(UpdateAdvancedIpsRuleRequest updateAdvancedIpsRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/advanced-ips-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAdvancedIpsRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAdvancedIpsRuleResponse>(response);
        }

        public SyncInvoker<UpdateAdvancedIpsRuleResponse> UpdateAdvancedIpsRuleInvoker(UpdateAdvancedIpsRuleRequest updateAdvancedIpsRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/advanced-ips-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAdvancedIpsRuleRequest);
            return new SyncInvoker<UpdateAdvancedIpsRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAdvancedIpsRuleResponse>);
        }
        
        /// <summary>
        /// 更新自定义IPS规则
        ///
        /// 更新自定义IPS规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCustomerIpsResponse UpdateCustomerIps(UpdateCustomerIpsRequest updateCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCustomerIpsRequest.IpsCfwId, out var valueOfIpsCfwId)) urlParam.Add("ips_cfw_id", valueOfIpsCfwId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/{ips_cfw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomerIpsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCustomerIpsResponse>(response);
        }

        public SyncInvoker<UpdateCustomerIpsResponse> UpdateCustomerIpsInvoker(UpdateCustomerIpsRequest updateCustomerIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCustomerIpsRequest.IpsCfwId, out var valueOfIpsCfwId)) urlParam.Add("ips_cfw_id", valueOfIpsCfwId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/custom-rule/{ips_cfw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomerIpsRequest);
            return new SyncInvoker<UpdateCustomerIpsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCustomerIpsResponse>);
        }
        
        /// <summary>
        /// 批量添加IPS白名单
        ///
        /// 批量添加IPS白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateIpsWhitelistResponse BatchCreateIpsWhitelist(BatchCreateIpsWhitelistRequest batchCreateIpsWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateIpsWhitelistRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/ips/whitelist/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateIpsWhitelistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateIpsWhitelistResponse>(response);
        }

        public SyncInvoker<BatchCreateIpsWhitelistResponse> BatchCreateIpsWhitelistInvoker(BatchCreateIpsWhitelistRequest batchCreateIpsWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateIpsWhitelistRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/ips/whitelist/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateIpsWhitelistRequest);
            return new SyncInvoker<BatchCreateIpsWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateIpsWhitelistResponse>);
        }
        
        /// <summary>
        /// 批量删除IPS白名单
        ///
        /// 批量删除IPS白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteIpsWhitelistResponse BatchDeleteIpsWhitelist(BatchDeleteIpsWhitelistRequest batchDeleteIpsWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteIpsWhitelistRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/ips/whitelist/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteIpsWhitelistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteIpsWhitelistResponse>(response);
        }

        public SyncInvoker<BatchDeleteIpsWhitelistResponse> BatchDeleteIpsWhitelistInvoker(BatchDeleteIpsWhitelistRequest batchDeleteIpsWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteIpsWhitelistRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/ips/whitelist/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteIpsWhitelistRequest);
            return new SyncInvoker<BatchDeleteIpsWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteIpsWhitelistResponse>);
        }
        
        /// <summary>
        /// 查询IPS白名单列表详情
        ///
        /// 查询IPS白名单列表详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpsWhitelistsResponse ListIpsWhitelists(ListIpsWhitelistsRequest listIpsWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listIpsWhitelistsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/ips/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsWhitelistsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpsWhitelistsResponse>(response);
        }

        public SyncInvoker<ListIpsWhitelistsResponse> ListIpsWhitelistsInvoker(ListIpsWhitelistsRequest listIpsWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listIpsWhitelistsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/ips/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsWhitelistsRequest);
            return new SyncInvoker<ListIpsWhitelistsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsWhitelistsResponse>);
        }
        
        /// <summary>
        /// 更新IPS白名单
        ///
        /// 更新IPS白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIpsWhitelistResponse UpdateIpsWhitelist(UpdateIpsWhitelistRequest updateIpsWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpsWhitelistRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateIpsWhitelistRequest.ListId, out var valueOfListId)) urlParam.Add("list_id", valueOfListId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/ips/whitelist/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIpsWhitelistRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIpsWhitelistResponse>(response);
        }

        public SyncInvoker<UpdateIpsWhitelistResponse> UpdateIpsWhitelistInvoker(UpdateIpsWhitelistRequest updateIpsWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpsWhitelistRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateIpsWhitelistRequest.ListId, out var valueOfListId)) urlParam.Add("list_id", valueOfListId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/ips/whitelist/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIpsWhitelistRequest);
            return new SyncInvoker<UpdateIpsWhitelistResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIpsWhitelistResponse>);
        }
        
        /// <summary>
        /// 查询攻击统计
        ///
        /// 根据防火墙攻击日志，查询攻击统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAttackStatisticResponse ListAttackStatistic(ListAttackStatisticRequest listAttackStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackStatisticRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAttackStatisticResponse>(response);
        }

        public SyncInvoker<ListAttackStatisticResponse> ListAttackStatisticInvoker(ListAttackStatisticRequest listAttackStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackStatisticRequest);
            return new SyncInvoker<ListAttackStatisticResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAttackStatisticResponse>);
        }
        
        /// <summary>
        /// 查询流量日志统计
        ///
        /// 查询流量日志统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlowStatisticResponse ListFlowStatistic(ListFlowStatisticRequest listFlowStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowStatisticRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlowStatisticResponse>(response);
        }

        public SyncInvoker<ListFlowStatisticResponse> ListFlowStatisticInvoker(ListFlowStatisticRequest listFlowStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowStatisticRequest);
            return new SyncInvoker<ListFlowStatisticResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlowStatisticResponse>);
        }
        
        /// <summary>
        /// 查询访问控制统计详情
        ///
        /// 查询访问控制统计详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAccessDetailResponse ShowAccessDetail(ShowAccessDetailRequest showAccessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/top-access-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessDetailResponse>(response);
        }

        public SyncInvoker<ShowAccessDetailResponse> ShowAccessDetailInvoker(ShowAccessDetailRequest showAccessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/top-access-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDetailRequest);
            return new SyncInvoker<ShowAccessDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessDetailResponse>);
        }
        
        /// <summary>
        /// 查询访问日志统计信息
        ///
        /// 获取访问日志的TOP统计信息，如TOP命中规则等
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAccessTopResponse ShowAccessTop(ShowAccessTopRequest showAccessTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-top", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessTopRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessTopResponse>(response);
        }

        public SyncInvoker<ShowAccessTopResponse> ShowAccessTopInvoker(ShowAccessTopRequest showAccessTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-top", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessTopRequest);
            return new SyncInvoker<ShowAccessTopResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessTopResponse>);
        }
        
        /// <summary>
        /// 查询攻击日志统计详情
        ///
        /// 查询攻击日志统计详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAttackDetailResponse ShowAttackDetail(ShowAttackDetailRequest showAttackDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAttackDetailResponse>(response);
        }

        public SyncInvoker<ShowAttackDetailResponse> ShowAttackDetailInvoker(ShowAttackDetailRequest showAttackDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackDetailRequest);
            return new SyncInvoker<ShowAttackDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAttackDetailResponse>);
        }
        
        /// <summary>
        /// 查询攻击日志TOP统计
        ///
        /// 查询攻击日志TOP统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAttackTopResponse ShowAttackTop(ShowAttackTopRequest showAttackTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/top-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTopRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAttackTopResponse>(response);
        }

        public SyncInvoker<ShowAttackTopResponse> ShowAttackTopInvoker(ShowAttackTopRequest showAttackTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/top-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTopRequest);
            return new SyncInvoker<ShowAttackTopResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAttackTopResponse>);
        }
        
        /// <summary>
        /// 查询攻击概览
        ///
        /// 查询攻击概览
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAttackTotalResponse ShowAttackTotal(ShowAttackTotalRequest showAttackTotalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/total-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTotalRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAttackTotalResponse>(response);
        }

        public SyncInvoker<ShowAttackTotalResponse> ShowAttackTotalInvoker(ShowAttackTotalRequest showAttackTotalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/total-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTotalRequest);
            return new SyncInvoker<ShowAttackTotalResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAttackTotalResponse>);
        }
        
        /// <summary>
        /// 查询攻击趋势
        ///
        /// 查询攻击趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAttackTrendResponse ShowAttackTrend(ShowAttackTrendRequest showAttackTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/trend-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTrendRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAttackTrendResponse>(response);
        }

        public SyncInvoker<ShowAttackTrendResponse> ShowAttackTrendInvoker(ShowAttackTrendRequest showAttackTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/trend-attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAttackTrendRequest);
            return new SyncInvoker<ShowAttackTrendResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAttackTrendResponse>);
        }
        
        /// <summary>
        /// 查询流量日志统计详情
        ///
        /// 查询流量日志统计详情，如统计某个源IP访问详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFlowDetailResponse ShowFlowDetail(ShowFlowDetailRequest showFlowDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowDetailResponse>(response);
        }

        public SyncInvoker<ShowFlowDetailResponse> ShowFlowDetailInvoker(ShowFlowDetailRequest showFlowDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowDetailRequest);
            return new SyncInvoker<ShowFlowDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowDetailResponse>);
        }
        
        /// <summary>
        /// 查询流量TOP统计
        ///
        /// 查询流量TOP统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFlowTopResponse ShowFlowTop(ShowFlowTopRequest showFlowTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-top", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowTopRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowTopResponse>(response);
        }

        public SyncInvoker<ShowFlowTopResponse> ShowFlowTopInvoker(ShowFlowTopRequest showFlowTopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-top", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowTopRequest);
            return new SyncInvoker<ShowFlowTopResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowTopResponse>);
        }
        
        /// <summary>
        /// 查询会话趋势
        ///
        /// 查询会话趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFlowTrendResponse ShowFlowTrend(ShowFlowTrendRequest showFlowTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowTrendRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowTrendResponse>(response);
        }

        public SyncInvoker<ShowFlowTrendResponse> ShowFlowTrendInvoker(ShowFlowTrendRequest showFlowTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow-trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowTrendRequest);
            return new SyncInvoker<ShowFlowTrendResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowTrendResponse>);
        }
        
        /// <summary>
        /// 查询日志数量
        ///
        /// 统计日志数量，如统计风险IP的数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogsCountResponse ShowLogsCount(ShowLogsCountRequest showLogsCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsCountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogsCountResponse>(response);
        }

        public SyncInvoker<ShowLogsCountResponse> ShowLogsCountInvoker(ShowLogsCountRequest showLogsCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsCountRequest);
            return new SyncInvoker<ShowLogsCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogsCountResponse>);
        }
        
        /// <summary>
        /// 查询流量趋势
        ///
        /// 查询流量趋势，包括南北向、EIP、东西向的流量趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTrafficTrendResponse ShowTrafficTrend(ShowTrafficTrendRequest showTrafficTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/traffic-trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficTrendRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTrafficTrendResponse>(response);
        }

        public SyncInvoker<ShowTrafficTrendResponse> ShowTrafficTrendInvoker(ShowTrafficTrendRequest showTrafficTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/traffic-trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficTrendRequest);
            return new SyncInvoker<ShowTrafficTrendResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrafficTrendResponse>);
        }
        
        /// <summary>
        /// 创建日志配置
        ///
        /// 创建日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddLogConfigResponse AddLogConfig(AddLogConfigRequest addLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addLogConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddLogConfigResponse>(response);
        }

        public SyncInvoker<AddLogConfigResponse> AddLogConfigInvoker(AddLogConfigRequest addLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addLogConfigRequest);
            return new SyncInvoker<AddLogConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<AddLogConfigResponse>);
        }
        
        /// <summary>
        /// 导出防火墙日志
        ///
        /// 导出防火墙日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportLogsResponse ExportLogs(ExportLogsRequest exportLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exportLogsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/logs/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportLogsResponse>(response);
        }

        public SyncInvoker<ExportLogsResponse> ExportLogsInvoker(ExportLogsRequest exportLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exportLogsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/logs/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportLogsRequest);
            return new SyncInvoker<ExportLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessControlLogsResponse>(response);
        }

        public SyncInvoker<ListAccessControlLogsResponse> ListAccessControlLogsInvoker(ListAccessControlLogsRequest listAccessControlLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlLogsRequest);
            return new SyncInvoker<ListAccessControlLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessControlLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAttackLogsResponse>(response);
        }

        public SyncInvoker<ListAttackLogsResponse> ListAttackLogsInvoker(ListAttackLogsRequest listAttackLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackLogsRequest);
            return new SyncInvoker<ListAttackLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAttackLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlowLogsResponse>(response);
        }

        public SyncInvoker<ListFlowLogsResponse> ListFlowLogsInvoker(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            return new SyncInvoker<ListFlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取日志配置
        ///
        /// 获取日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogConfigResponse ListLogConfig(ListLogConfigRequest listLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogConfigResponse>(response);
        }

        public SyncInvoker<ListLogConfigResponse> ListLogConfigInvoker(ListLogConfigRequest listLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogConfigRequest);
            return new SyncInvoker<ListLogConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogConfigResponse>);
        }
        
        /// <summary>
        /// 查询防火墙日志
        ///
        /// 查询防火墙日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogsResponse ListLogs(ListLogsRequest listLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLogsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLogsResponse>(response);
        }

        public SyncInvoker<ListLogsResponse> ListLogsInvoker(ListLogsRequest listLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLogsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/{fw_instance_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            return new SyncInvoker<ListLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLogsResponse>);
        }
        
        /// <summary>
        /// 更新日志配置
        ///
        /// 更新日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogConfigResponse UpdateLogConfig(UpdateLogConfigRequest updateLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogConfigResponse>(response);
        }

        public SyncInvoker<UpdateLogConfigResponse> UpdateLogConfigInvoker(UpdateLogConfigRequest updateLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConfigRequest);
            return new SyncInvoker<UpdateLogConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogConfigResponse>);
        }
        
        /// <summary>
        /// 批量添加账号
        ///
        /// 批量添加账号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddAccountsResponse BatchAddAccounts(BatchAddAccountsRequest batchAddAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddAccountsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddAccountsResponse>(response);
        }

        public SyncInvoker<BatchAddAccountsResponse> BatchAddAccountsInvoker(BatchAddAccountsRequest batchAddAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddAccountsRequest);
            return new SyncInvoker<BatchAddAccountsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddAccountsResponse>);
        }
        
        /// <summary>
        /// 批量移除账号
        ///
        /// 批量移除账号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRemoveAccountsResponse BatchRemoveAccounts(BatchRemoveAccountsRequest batchRemoveAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRemoveAccountsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRemoveAccountsResponse>(response);
        }

        public SyncInvoker<BatchRemoveAccountsResponse> BatchRemoveAccountsInvoker(BatchRemoveAccountsRequest batchRemoveAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRemoveAccountsRequest);
            return new SyncInvoker<BatchRemoveAccountsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRemoveAccountsResponse>);
        }
        
        /// <summary>
        /// 开启多账号管理
        ///
        /// 开启多账号管理
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableMultiAccountResponse EnableMultiAccount(EnableMultiAccountRequest enableMultiAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableMultiAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableMultiAccountResponse>(response);
        }

        public SyncInvoker<EnableMultiAccountResponse> EnableMultiAccountInvoker(EnableMultiAccountRequest enableMultiAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableMultiAccountRequest);
            return new SyncInvoker<EnableMultiAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableMultiAccountResponse>);
        }
        
        /// <summary>
        /// 查询账号列表
        ///
        /// 查询账号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountsResponse ListAccounts(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountsResponse>(response);
        }

        public SyncInvoker<ListAccountsResponse> ListAccountsInvoker(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            return new SyncInvoker<ListAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountsResponse>);
        }
        
        /// <summary>
        /// 查询组织账号列表
        ///
        /// 查询组织账号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOrganizationAccountsResponse ListOrganizationAccounts(ListOrganizationAccountsRequest listOrganizationAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/organization-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationAccountsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationAccountsResponse>(response);
        }

        public SyncInvoker<ListOrganizationAccountsResponse> ListOrganizationAccountsInvoker(ListOrganizationAccountsRequest listOrganizationAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/organization-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationAccountsRequest);
            return new SyncInvoker<ListOrganizationAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationAccountsResponse>);
        }
        
        /// <summary>
        /// 查询组织结构
        ///
        /// 查询组织结构
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOrganizationTreeResponse ListOrganizationTree(ListOrganizationTreeRequest listOrganizationTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/organization-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationTreeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationTreeResponse>(response);
        }

        public SyncInvoker<ListOrganizationTreeResponse> ListOrganizationTreeInvoker(ListOrganizationTreeRequest listOrganizationTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system/multi-account/organization-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationTreeRequest);
            return new SyncInvoker<ListOrganizationTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationTreeResponse>);
        }
        
        /// <summary>
        /// 批量删除时间表
        ///
        /// 批量删除时间表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteSchedulesResponse BatchDeleteSchedules(BatchDeleteSchedulesRequest batchDeleteSchedulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSchedulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteSchedulesResponse>(response);
        }

        public SyncInvoker<BatchDeleteSchedulesResponse> BatchDeleteSchedulesInvoker(BatchDeleteSchedulesRequest batchDeleteSchedulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSchedulesRequest);
            return new SyncInvoker<BatchDeleteSchedulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteSchedulesResponse>);
        }
        
        /// <summary>
        /// 创建时间表
        ///
        /// 创建时间表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateScheduleResponse CreateSchedule(CreateScheduleRequest createScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateScheduleResponse>(response);
        }

        public SyncInvoker<CreateScheduleResponse> CreateScheduleInvoker(CreateScheduleRequest createScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduleRequest);
            return new SyncInvoker<CreateScheduleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScheduleResponse>);
        }
        
        /// <summary>
        /// 删除时间表
        ///
        /// 删除时间表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest deleteScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduleRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteScheduleResponse>(response);
        }

        public SyncInvoker<DeleteScheduleResponse> DeleteScheduleInvoker(DeleteScheduleRequest deleteScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduleRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleRequest);
            return new SyncInvoker<DeleteScheduleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteScheduleResponse>);
        }
        
        /// <summary>
        /// 查询时间表列表
        ///
        /// 查询时间表列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSchedulesResponse ListSchedules(ListSchedulesRequest listSchedulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchedulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSchedulesResponse>(response);
        }

        public SyncInvoker<ListSchedulesResponse> ListSchedulesInvoker(ListSchedulesRequest listSchedulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchedulesRequest);
            return new SyncInvoker<ListSchedulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSchedulesResponse>);
        }
        
        /// <summary>
        /// 更新时间表
        ///
        /// 更新时间表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest updateScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduleRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateScheduleResponse>(response);
        }

        public SyncInvoker<UpdateScheduleResponse> UpdateScheduleInvoker(UpdateScheduleRequest updateScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduleRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduleRequest);
            return new SyncInvoker<UpdateScheduleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateScheduleResponse>);
        }
        
        /// <summary>
        /// 创建安全报告模板
        ///
        /// 创建安全报告模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateReportProfileResponse CreateReportProfile(CreateReportProfileRequest createReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportProfileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateReportProfileResponse>(response);
        }

        public SyncInvoker<CreateReportProfileResponse> CreateReportProfileInvoker(CreateReportProfileRequest createReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportProfileRequest);
            return new SyncInvoker<CreateReportProfileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReportProfileResponse>);
        }
        
        /// <summary>
        /// 删除安全报告模板
        ///
        /// 删除安全报告模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteReportProfileResponse DeleteReportProfile(DeleteReportProfileRequest deleteReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteReportProfileRequest.ReportProfileId, out var valueOfReportProfileId)) urlParam.Add("report_profile_id", valueOfReportProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReportProfileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteReportProfileResponse>(response);
        }

        public SyncInvoker<DeleteReportProfileResponse> DeleteReportProfileInvoker(DeleteReportProfileRequest deleteReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteReportProfileRequest.ReportProfileId, out var valueOfReportProfileId)) urlParam.Add("report_profile_id", valueOfReportProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReportProfileRequest);
            return new SyncInvoker<DeleteReportProfileResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteReportProfileResponse>);
        }
        
        /// <summary>
        /// 查询安全报告发送历史
        ///
        /// 查询安全报告发送历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReportHistoryResponse ListReportHistory(ListReportHistoryRequest listReportHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReportHistoryRequest.ReportProfileId, out var valueOfReportProfileId)) urlParam.Add("report_profile_id", valueOfReportProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report/history/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReportHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReportHistoryResponse>(response);
        }

        public SyncInvoker<ListReportHistoryResponse> ListReportHistoryInvoker(ListReportHistoryRequest listReportHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReportHistoryRequest.ReportProfileId, out var valueOfReportProfileId)) urlParam.Add("report_profile_id", valueOfReportProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report/history/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReportHistoryRequest);
            return new SyncInvoker<ListReportHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReportHistoryResponse>);
        }
        
        /// <summary>
        /// 查询安全报告模板列表
        ///
        /// 查询安全报告模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReportProfilesResponse ListReportProfiles(ListReportProfilesRequest listReportProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReportProfilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReportProfilesResponse>(response);
        }

        public SyncInvoker<ListReportProfilesResponse> ListReportProfilesInvoker(ListReportProfilesRequest listReportProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReportProfilesRequest);
            return new SyncInvoker<ListReportProfilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReportProfilesResponse>);
        }
        
        /// <summary>
        /// 查询安全报告
        ///
        /// 查询安全报告
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFirewallReportResponse ShowFirewallReport(ShowFirewallReportRequest showFirewallReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFirewallReportRequest.ReportId, out var valueOfReportId)) urlParam.Add("report_id", valueOfReportId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallReportRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFirewallReportResponse>(response);
        }

        public SyncInvoker<ShowFirewallReportResponse> ShowFirewallReportInvoker(ShowFirewallReportRequest showFirewallReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFirewallReportRequest.ReportId, out var valueOfReportId)) urlParam.Add("report_id", valueOfReportId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallReportRequest);
            return new SyncInvoker<ShowFirewallReportResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFirewallReportResponse>);
        }
        
        /// <summary>
        /// 获取安全报告模板
        ///
        /// 获取安全报告模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReportProfileResponse ShowReportProfile(ShowReportProfileRequest showReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReportProfileRequest.ReportProfileId, out var valueOfReportProfileId)) urlParam.Add("report_profile_id", valueOfReportProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportProfileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReportProfileResponse>(response);
        }

        public SyncInvoker<ShowReportProfileResponse> ShowReportProfileInvoker(ShowReportProfileRequest showReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReportProfileRequest.ReportProfileId, out var valueOfReportProfileId)) urlParam.Add("report_profile_id", valueOfReportProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportProfileRequest);
            return new SyncInvoker<ShowReportProfileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReportProfileResponse>);
        }
        
        /// <summary>
        /// 更新安全报告模板
        ///
        /// 更新安全报告模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateReportProfileResponse UpdateReportProfile(UpdateReportProfileRequest updateReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateReportProfileRequest.ReportProfileId, out var valueOfReportProfileId)) urlParam.Add("report_profile_id", valueOfReportProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReportProfileRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReportProfileResponse>(response);
        }

        public SyncInvoker<UpdateReportProfileResponse> UpdateReportProfileInvoker(UpdateReportProfileRequest updateReportProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateReportProfileRequest.ReportProfileId, out var valueOfReportProfileId)) urlParam.Add("report_profile_id", valueOfReportProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/report-profile/{report_profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReportProfileRequest);
            return new SyncInvoker<UpdateReportProfileResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReportProfileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceItemsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddServiceItemsResponse>(response);
        }

        public SyncInvoker<AddServiceItemsResponse> AddServiceItemsInvoker(AddServiceItemsRequest addServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceItemsRequest);
            return new SyncInvoker<AddServiceItemsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddServiceItemsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddServiceSetResponse>(response);
        }

        public SyncInvoker<AddServiceSetResponse> AddServiceSetInvoker(AddServiceSetRequest addServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceSetRequest);
            return new SyncInvoker<AddServiceSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddServiceSetResponse>);
        }
        
        /// <summary>
        /// 批量删除服务组成员信息
        ///
        /// 批量删除服务组成员信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteServiceItemsResponse BatchDeleteServiceItems(BatchDeleteServiceItemsRequest batchDeleteServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceItemsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteServiceItemsResponse>(response);
        }

        public SyncInvoker<BatchDeleteServiceItemsResponse> BatchDeleteServiceItemsInvoker(BatchDeleteServiceItemsRequest batchDeleteServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceItemsRequest);
            return new SyncInvoker<BatchDeleteServiceItemsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteServiceItemsResponse>);
        }
        
        /// <summary>
        /// 批量删除服务组
        ///
        /// 批量删除服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteServiceSetsResponse BatchDeleteServiceSets(BatchDeleteServiceSetsRequest batchDeleteServiceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceSetsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteServiceSetsResponse>(response);
        }

        public SyncInvoker<BatchDeleteServiceSetsResponse> BatchDeleteServiceSetsInvoker(BatchDeleteServiceSetsRequest batchDeleteServiceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceSetsRequest);
            return new SyncInvoker<BatchDeleteServiceSetsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteServiceSetsResponse>);
        }
        
        /// <summary>
        /// 删除服务组成员
        ///
        /// 删除服务组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServiceItemResponse DeleteServiceItem(DeleteServiceItemRequest deleteServiceItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceItemRequest.ItemId, out var valueOfItemId)) urlParam.Add("item_id", valueOfItemId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceItemRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceItemResponse>(response);
        }

        public SyncInvoker<DeleteServiceItemResponse> DeleteServiceItemInvoker(DeleteServiceItemRequest deleteServiceItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceItemRequest.ItemId, out var valueOfItemId)) urlParam.Add("item_id", valueOfItemId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceItemRequest);
            return new SyncInvoker<DeleteServiceItemResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceItemResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceSetResponse>(response);
        }

        public SyncInvoker<DeleteServiceSetResponse> DeleteServiceSetInvoker(DeleteServiceSetRequest deleteServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceSetRequest);
            return new SyncInvoker<DeleteServiceSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceSetResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceItemsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceItemsResponse>(response);
        }

        public SyncInvoker<ListServiceItemsResponse> ListServiceItemsInvoker(ListServiceItemsRequest listServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceItemsRequest);
            return new SyncInvoker<ListServiceItemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceItemsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServiceSetDetailRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceSetDetailResponse>(response);
        }

        public SyncInvoker<ListServiceSetDetailResponse> ListServiceSetDetailInvoker(ListServiceSetDetailRequest listServiceSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServiceSetDetailRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetDetailRequest);
            return new SyncInvoker<ListServiceSetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceSetDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceSetsResponse>(response);
        }

        public SyncInvoker<ListServiceSetsResponse> ListServiceSetsInvoker(ListServiceSetsRequest listServiceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetsRequest);
            return new SyncInvoker<ListServiceSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceSetsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServiceSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateServiceSetResponse>(response);
        }

        public SyncInvoker<UpdateServiceSetResponse> UpdateServiceSetInvoker(UpdateServiceSetRequest updateServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServiceSetRequest.SetId, out var valueOfSetId)) urlParam.Add("set_id", valueOfSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceSetRequest);
            return new SyncInvoker<UpdateServiceSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateServiceSetResponse>);
        }
        
        /// <summary>
        /// 创建私网网段
        ///
        /// 添加私网网段的接口，添加私网网段后该网段的流量将引流到VPC防火墙防护
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreatePrivateNetworkSegmentsResponse BatchCreatePrivateNetworkSegments(BatchCreatePrivateNetworkSegmentsRequest batchCreatePrivateNetworkSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreatePrivateNetworkSegmentsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{fw_instance_id}/east-west/private-network-segments/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreatePrivateNetworkSegmentsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreatePrivateNetworkSegmentsResponse>(response);
        }

        public SyncInvoker<BatchCreatePrivateNetworkSegmentsResponse> BatchCreatePrivateNetworkSegmentsInvoker(BatchCreatePrivateNetworkSegmentsRequest batchCreatePrivateNetworkSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreatePrivateNetworkSegmentsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{fw_instance_id}/east-west/private-network-segments/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreatePrivateNetworkSegmentsRequest);
            return new SyncInvoker<BatchCreatePrivateNetworkSegmentsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreatePrivateNetworkSegmentsResponse>);
        }
        
        /// <summary>
        /// 删除私网网段信息
        ///
        /// 删除私网网段的接口，根据用户输入的私网网段conf_id，删除对应ID的私网网段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeletePrivateNetworkSegmentsResponse BatchDeletePrivateNetworkSegments(BatchDeletePrivateNetworkSegmentsRequest batchDeletePrivateNetworkSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeletePrivateNetworkSegmentsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{fw_instance_id}/east-west/private-network-segments/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePrivateNetworkSegmentsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeletePrivateNetworkSegmentsResponse>(response);
        }

        public SyncInvoker<BatchDeletePrivateNetworkSegmentsResponse> BatchDeletePrivateNetworkSegmentsInvoker(BatchDeletePrivateNetworkSegmentsRequest batchDeletePrivateNetworkSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeletePrivateNetworkSegmentsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{fw_instance_id}/east-west/private-network-segments/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePrivateNetworkSegmentsRequest);
            return new SyncInvoker<BatchDeletePrivateNetworkSegmentsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeletePrivateNetworkSegmentsResponse>);
        }
        
        /// <summary>
        /// 更新VPC间防火墙防护状态
        ///
        /// 更新VPC间防火墙防护状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeEastWestFirewallStatusResponse ChangeEastWestFirewallStatus(ChangeEastWestFirewallStatusRequest changeEastWestFirewallStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEastWestFirewallStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeEastWestFirewallStatusResponse>(response);
        }

        public SyncInvoker<ChangeEastWestFirewallStatusResponse> ChangeEastWestFirewallStatusInvoker(ChangeEastWestFirewallStatusRequest changeEastWestFirewallStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEastWestFirewallStatusRequest);
            return new SyncInvoker<ChangeEastWestFirewallStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeEastWestFirewallStatusResponse>);
        }
        
        /// <summary>
        /// 获取私网网段的信息
        ///
        /// 东西向私网网段查询接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateNetworkSegmentsResponse ListPrivateNetworkSegments(ListPrivateNetworkSegmentsRequest listPrivateNetworkSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPrivateNetworkSegmentsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{fw_instance_id}/east-west/private-network-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNetworkSegmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateNetworkSegmentsResponse>(response);
        }

        public SyncInvoker<ListPrivateNetworkSegmentsResponse> ListPrivateNetworkSegmentsInvoker(ListPrivateNetworkSegmentsRequest listPrivateNetworkSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPrivateNetworkSegmentsRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{fw_instance_id}/east-west/private-network-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNetworkSegmentsRequest);
            return new SyncInvoker<ListPrivateNetworkSegmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateNetworkSegmentsResponse>);
        }
        
        /// <summary>
        /// 查询VPC间防火墙使用的企业路由器信息
        ///
        /// 查询VPC间防火墙使用的企业路由器信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEwAssociatedErResponse ShowEwAssociatedEr(ShowEwAssociatedErRequest showEwAssociatedErRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/enterprise-router", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEwAssociatedErRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEwAssociatedErResponse>(response);
        }

        public SyncInvoker<ShowEwAssociatedErResponse> ShowEwAssociatedErInvoker(ShowEwAssociatedErRequest showEwAssociatedErRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/enterprise-router", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEwAssociatedErRequest);
            return new SyncInvoker<ShowEwAssociatedErResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEwAssociatedErResponse>);
        }
        
        /// <summary>
        /// 查询VPC边界防火墙使用的引流VPC信息
        ///
        /// 查询VPC边界防火墙使用的引流VPC信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEwAssociatedVpcResponse ShowEwAssociatedVpc(ShowEwAssociatedVpcRequest showEwAssociatedVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/inspection-vpc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEwAssociatedVpcRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEwAssociatedVpcResponse>(response);
        }

        public SyncInvoker<ShowEwAssociatedVpcResponse> ShowEwAssociatedVpcInvoker(ShowEwAssociatedVpcRequest showEwAssociatedVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/inspection-vpc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEwAssociatedVpcRequest);
            return new SyncInvoker<ShowEwAssociatedVpcResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEwAssociatedVpcResponse>);
        }
        
        /// <summary>
        /// 更新私网网段
        ///
        /// 更新私网网段的REST接口，主要特性：
        ///  * 根据私网网段ID，更新对应的私网网段信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateNetworkSegmentResponse UpdatePrivateNetworkSegment(UpdatePrivateNetworkSegmentRequest updatePrivateNetworkSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateNetworkSegmentRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{fw_instance_id}/east-west/private-network-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateNetworkSegmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateNetworkSegmentResponse>(response);
        }

        public SyncInvoker<UpdatePrivateNetworkSegmentResponse> UpdatePrivateNetworkSegmentInvoker(UpdatePrivateNetworkSegmentRequest updatePrivateNetworkSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateNetworkSegmentRequest.FwInstanceId, out var valueOfFwInstanceId)) urlParam.Add("fw_instance_id", valueOfFwInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{fw_instance_id}/east-west/private-network-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateNetworkSegmentRequest);
            return new SyncInvoker<UpdatePrivateNetworkSegmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateNetworkSegmentResponse>);
        }
        
    }
}