using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.ModelArts.V1.Model;

namespace HuaweiCloud.SDK.ModelArts.V1
{
    public partial class ModelArtsAsyncClient : Client
    {
        public static ClientBuilder<ModelArtsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ModelArtsAsyncClient>();
        }

        
        /// <summary>
        /// 计划事件授权
        ///
        /// 计划事件授权接口用于为指定的计划事件分配或调整权限。该接口适用于以下场景：当创建新的计划事件、调整现有计划事件的权限设置或变更权限分配时，用户可通过此接口为指定的计划事件授予或修改权限。使用该接口的前提条件是计划事件已存在且用户具有管理员权限。授权操作完成后，计划事件的权限设置将被更新，相关变更将被记录以便审计。若计划事件不存在、用户无权限操作或授权信息格式不正确，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AcceptScheduledEventResponse> AcceptScheduledEventAsync(AcceptScheduledEventRequest acceptScheduledEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptScheduledEventRequest.EventId, out var valueOfEventId)) urlParam.Add("event_id", valueOfEventId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scheduled-events/{event_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptScheduledEventRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AcceptScheduledEventResponse>(response);
        }

        public AsyncInvoker<AcceptScheduledEventResponse> AcceptScheduledEventAsyncInvoker(AcceptScheduledEventRequest acceptScheduledEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptScheduledEventRequest.EventId, out var valueOfEventId)) urlParam.Add("event_id", valueOfEventId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scheduled-events/{event_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptScheduledEventRequest);
            return new AsyncInvoker<AcceptScheduledEventResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptScheduledEventResponse>);
        }
        
        /// <summary>
        /// 动态挂载Notebook存储
        ///
        /// 动态挂载Notebook存储接口支持将存储动态挂载到运行中的Notebook实例的指定文件目录。调用该接口后，系统将在Notebook实例中**异步**挂载指定的存储实例，挂载完成后用户可在容器中以文件系统方式读写存储实例中的文件。若用户无权限访问指定实例或Notebook实例未运行，接口将返回相应的错误信息。
        /// 
        /// 支持的存储类型：
        /// - **对象存储 OBS**：适合直接使用OBS桶作为持久化存储进行AI开发和探索场景，但小文件频繁读写性能较差，**模型训练，大文件解压等场景慎用，此类场景可能会导致Notebook文件操作卡顿**。
        /// - **并行文件系统 PFS**：高性能对象存储文件系统，存储成本低，吞吐量大，能够快速处理高性能计算（HPC）工作负载，**但小文件频繁读写较弱。小文件频繁读写场景可能会导致Notebook文件操作卡顿**
        /// - **高性能弹性文件服务SFS Turbo**：仅支持专属资源池实例挂载，**挂载前需要在资源池网络管理界面中进行网络关联**，支持多个环境使用，可以在多个开发环境、开发环境和训练之间共享。适合探索、实验等非正式生产场景，但不适合重IO读写模型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachDynamicStorageResponse> AttachDynamicStorageAsync(AttachDynamicStorageRequest attachDynamicStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachDynamicStorageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{instance_id}/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachDynamicStorageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachDynamicStorageResponse>(response);
        }

        public AsyncInvoker<AttachDynamicStorageResponse> AttachDynamicStorageAsyncInvoker(AttachDynamicStorageRequest attachDynamicStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachDynamicStorageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{instance_id}/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachDynamicStorageRequest);
            return new AsyncInvoker<AttachDynamicStorageResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachDynamicStorageResponse>);
        }
        
        /// <summary>
        /// 批量绑定应用密钥
        ///
        /// 本接口用于将生成的多个apikey与指定服务进行批量绑定，用于访问特定服务。调用此接口前，确保已成功创建服务实例，并获取到有效的apikey。绑定成功后，apikey将作为服务调用时的身份验证凭证，确保仅授权用户能够访问该服务。如果尝试绑定已失效或已绑定当前服务的apikey将返回相应的异常信息，提示用户检查apikey的有效性和绑定状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchBindInferApiKeysResponse> BatchBindInferApiKeysAsync(BatchBindInferApiKeysRequest batchBindInferApiKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchBindInferApiKeysRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/api-keys/batch-bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", batchBindInferApiKeysRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchBindInferApiKeysResponse>(response);
        }

        public AsyncInvoker<BatchBindInferApiKeysResponse> BatchBindInferApiKeysAsyncInvoker(BatchBindInferApiKeysRequest batchBindInferApiKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchBindInferApiKeysRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/api-keys/batch-bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", batchBindInferApiKeysRequest);
            return new AsyncInvoker<BatchBindInferApiKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchBindInferApiKeysResponse>);
        }
        
        /// <summary>
        /// 批量为节点绑定逻辑子池
        ///
        /// 批量为节点绑定逻辑子池接口用于在物理专属池开启节点绑定功能时，对逻辑子池中的节点进行逻辑子池的换绑操作。该接口适用于以下场景：当需要重新分配资源、调整业务负载或优化资源使用效率时，用户可通过此接口将指定节点从当前逻辑子池迁移到另一个逻辑子池。使用该接口的前提条件是物理专属池已开启节点绑定功能，且目标逻辑子池已存在并具备足够的资源容量。绑定操作完成后，节点将从原逻辑子池解绑并绑定到目标逻辑子池，原逻辑子池的节点数减少，目标逻辑子池的节点数增加。若节点未绑定到任何逻辑子池、目标逻辑子池不存在或资源不足，或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchBindPoolNodesResponse> BatchBindPoolNodesAsync(BatchBindPoolNodesRequest batchBindPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchBindPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchBindPoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchBindPoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchBindPoolNodesResponse> BatchBindPoolNodesAsyncInvoker(BatchBindPoolNodesRequest batchBindPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchBindPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchBindPoolNodesRequest);
            return new AsyncInvoker<BatchBindPoolNodesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchBindPoolNodesResponse>);
        }
        
        /// <summary>
        /// 批量创建资源池标签
        ///
        /// 批量创建资源池标签接口用于为指定资源池添加或更新多个标签信息。该接口适用于以下场景：当需要对资源池进行统一分类管理（如成本归属、环境标识）、批量配置元数据（如项目归属、负责人信息）或更新已有标签值时，管理员可通过此接口一次性操作多个标签。使用该接口的前提条件是目标资源池必须已存在且处于可管理状态，调用者需具备资源池标签管理权限，且提交的标签数据需符合格式规范（如key非空、value长度限制）。操作完成后，系统将为资源池添加新标签或覆盖同名标签的值，且不会影响资源池的其他配置属性。若资源池不存在、用户权限不足、标签格式错误或系统服务异常，接口将返回对应的错误信息（如\&quot;404 Not Found\&quot;、\&quot;403 Forbidden\&quot;、\&quot;400 Bad Request\&quot;或\&quot;503 Service Unavailable\&quot;）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreatePoolTagsResponse> BatchCreatePoolTagsAsync(BatchCreatePoolTagsRequest batchCreatePoolTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreatePoolTagsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/pools/{pool_name}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreatePoolTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreatePoolTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreatePoolTagsResponse> BatchCreatePoolTagsAsyncInvoker(BatchCreatePoolTagsRequest batchCreatePoolTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreatePoolTagsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/pools/{pool_name}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreatePoolTagsRequest);
            return new AsyncInvoker<BatchCreatePoolTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreatePoolTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除内网接入
        ///
        /// 本接口用于批量删除指定的内网接入点，适用于需要清理多个不再使用的内网接入点的场景。调用此接口前，确保已具备相应的删除权限，并提供一个有效的内网接入点ID列表。删除成功后，所指定的内网接入点将被彻底移除，不再对任何服务生效。如果提供的内网接入点ID列表中包含无效或已删除的ID，将返回相应的异常信息，提示用户检查ID的有效性。此外，如果调用时出现权限不足或其他系统异常，也将返回相应的异常信息，提示用户检查权限或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteInferIntranetConnectionsResponse> BatchDeleteInferIntranetConnectionsAsync(BatchDeleteInferIntranetConnectionsRequest batchDeleteInferIntranetConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInferIntranetConnectionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteInferIntranetConnectionsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteInferIntranetConnectionsResponse> BatchDeleteInferIntranetConnectionsAsyncInvoker(BatchDeleteInferIntranetConnectionsRequest batchDeleteInferIntranetConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInferIntranetConnectionsRequest);
            return new AsyncInvoker<BatchDeleteInferIntranetConnectionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteInferIntranetConnectionsResponse>);
        }
        
        /// <summary>
        /// 删除指定服务列表
        ///
        /// 删除指定服务列表功能允许用户批量删除多个服务，适用于需要清理资源、释放计算能力或管理多个服务的场景。使用此功能前，请确保您具备删除服务的权限，并提供有效的服务ID列表。成功执行后，指定的服务将被终止运行并释放相关资源。若服务ID无效、权限不足或服务状态不允许删除，将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteInferServicesResponse> BatchDeleteInferServicesAsync(BatchDeleteInferServicesRequest batchDeleteInferServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInferServicesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteInferServicesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteInferServicesResponse> BatchDeleteInferServicesAsyncInvoker(BatchDeleteInferServicesRequest batchDeleteInferServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInferServicesRequest);
            return new AsyncInvoker<BatchDeleteInferServicesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteInferServicesResponse>);
        }
        
        /// <summary>
        /// 批量删除节点
        ///
        /// 批量删除节点接口用于批量删除指定资源池中的节点。该接口适用于以下场景：当需要清理资源池中的冗余节点、重新分配资源或移除故障节点时，用户可通过此接口批量删除指定的节点。使用该接口的前提条件是资源池已创建且处于可用状态，用户具有删除节点的权限，且资源池中至少保留一个节点。删除操作完成后，指定的节点将被永久移除，资源池中剩余的节点将继续提供服务。若资源池不存在、节点不存在、用户无权限操作或资源池中节点不足，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePoolNodesResponse> BatchDeletePoolNodesAsync(BatchDeletePoolNodesRequest batchDeletePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeletePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeletePoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchDeletePoolNodesResponse> BatchDeletePoolNodesAsyncInvoker(BatchDeletePoolNodesRequest batchDeletePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeletePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePoolNodesRequest);
            return new AsyncInvoker<BatchDeletePoolNodesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePoolNodesResponse>);
        }
        
        /// <summary>
        /// 批量删除资源池标签
        ///
        /// 批量删除资源标签接口用于移除指定资源上的多个标签信息。该接口适用于以下场景：当需要清理冗余标签（如过期分类、无效元数据）、统一调整资源分类策略或因权限变更需批量移除标签时，管理员可通过此接口一次性删除多个标签。使用该接口的前提条件是目标资源必须已存在且处于可管理状态，调用者需具备资源标签管理权限，且待删除的标签必须已关联至该资源，系统标签管理服务需正常运行。操作完成后，指定标签将从资源中彻底移除，且不会影响资源的其他配置属性。若资源不存在、用户权限不足、标签未关联或系统服务异常，接口将返回对应的错误信息（如\&quot;404 Not Found\&quot;、\&quot;403 Forbidden\&quot;、\&quot;400 Bad Request\&quot;或\&quot;503 Service Unavailable\&quot;）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePoolTagsResponse> BatchDeletePoolTagsAsync(BatchDeletePoolTagsRequest batchDeletePoolTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeletePoolTagsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/pools/{pool_name}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePoolTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeletePoolTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeletePoolTagsResponse> BatchDeletePoolTagsAsyncInvoker(BatchDeletePoolTagsRequest batchDeletePoolTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeletePoolTagsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/pools/{pool_name}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePoolTagsRequest);
            return new AsyncInvoker<BatchDeletePoolTagsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeletePoolTagsResponse>);
        }
        
        /// <summary>
        /// 批量对节点功能上锁
        ///
        /// 批量对节点功能上锁接口用于批量对指定节点的功能进行上锁操作，被上锁的功能在控制台将无法正常使用。该接口适用于以下场景：当需要临时禁用某些节点的功能以防止误操作、进行系统维护或测试时，用户可通过此接口批量对节点功能进行上锁。使用该接口的前提条件是节点功能已存在且用户具有管理员权限。上锁操作完成后，指定节点的功能将在控制台被禁用，无法进行相关操作。若节点功能不存在、用户无权限操作或请求参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchLockPoolNodesResponse> BatchLockPoolNodesAsync(BatchLockPoolNodesRequest batchLockPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchLockPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchLockPoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchLockPoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchLockPoolNodesResponse> BatchLockPoolNodesAsyncInvoker(BatchLockPoolNodesRequest batchLockPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchLockPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchLockPoolNodesRequest);
            return new AsyncInvoker<BatchLockPoolNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchLockPoolNodesResponse>);
        }
        
        /// <summary>
        /// 批量迁移节点
        ///
        /// 批量迁移节点接口用于在资源池之间批量迁移节点，将节点从一个资源池迁移到另一个资源池。该接口适用于以下场景：当资源池的节点分布不均衡、需要进行集群维护或业务扩展时，用户可通过此接口将指定节点从一个资源池迁移到另一个资源池。使用该接口的前提条件是资源池中至少包含两个节点，且目标资源池具备足够的资源容量（如IP地址等）以接收迁移节点。若资源池只有一个节点、目标集群资源不足、节点状态不支持迁移或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchMigratePoolNodesResponse> BatchMigratePoolNodesAsync(BatchMigratePoolNodesRequest batchMigratePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchMigratePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMigratePoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchMigratePoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchMigratePoolNodesResponse> BatchMigratePoolNodesAsyncInvoker(BatchMigratePoolNodesRequest batchMigratePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchMigratePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMigratePoolNodesRequest);
            return new AsyncInvoker<BatchMigratePoolNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchMigratePoolNodesResponse>);
        }
        
        /// <summary>
        /// 批量重启节点
        ///
        /// 批量重启节点接口用于批量重启指定资源池中的节点。该接口适用于以下场景：当需要对资源池中的节点进行系统更新、配置变更、故障恢复或维护操作时，用户可通过此接口批量重启指定的节点。使用该接口的前提条件是资源池已创建且处于可用状态，节点属于该资源池且处于运行状态，且用户具有重启节点的权限。重启操作完成后，指定的节点将被重新启动，资源池中的其他节点将继续正常运行。若资源池不存在、节点不在资源池中、节点未处于运行状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRebootPoolNodesResponse> BatchRebootPoolNodesAsync(BatchRebootPoolNodesRequest batchRebootPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchRebootPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebootPoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRebootPoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchRebootPoolNodesResponse> BatchRebootPoolNodesAsyncInvoker(BatchRebootPoolNodesRequest batchRebootPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchRebootPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebootPoolNodesRequest);
            return new AsyncInvoker<BatchRebootPoolNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRebootPoolNodesResponse>);
        }
        
        /// <summary>
        /// 重置节点
        ///
        /// 重置节点接口用于将指定节点恢复到初始状态，清除节点上的数据和配置。该接口适用于以下场景：当节点出现故障、配置错误、需要重新部署或进行系统恢复时，用户可通过此接口重置节点，使其恢复到出厂或初始状态。使用该接口的前提条件是节点已存在且用户具有管理员权限。重置操作完成后，节点上的所有数据和配置将被清除，节点将被重新启动并恢复到初始状态。若节点不存在、用户无权限操作或节点处于不可重置状态（如正在运行任务），接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchResetPoolNodesResponse> BatchResetPoolNodesAsync(BatchResetPoolNodesRequest batchResetPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchResetPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResetPoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchResetPoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchResetPoolNodesResponse> BatchResetPoolNodesAsyncInvoker(BatchResetPoolNodesRequest batchResetPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchResetPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResetPoolNodesRequest);
            return new AsyncInvoker<BatchResetPoolNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchResetPoolNodesResponse>);
        }
        
        /// <summary>
        /// 节点规格变更
        ///
        /// 节点规格变更接口用于调整指定节点的规格（如步长），例如将节点从8节点超节点扩容到16节点超节点。该接口适用于以下场景：当需要根据业务需求调整节点的资源容量、优化资源利用率或进行系统升级时，用户可通过此接口变更节点的规格。使用该接口的前提条件是节点已创建且处于可变更状态，目标规格在支持范围内，且用户具有管理员权限。规格变更完成后，节点的资源容量将按新规格调整，相关服务和配置将重新加载以适应新的规格。若节点不存在、节点状态不允许变更、目标规格不支持或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchResizePoolNodesResponse> BatchResizePoolNodesAsync(BatchResizePoolNodesRequest batchResizePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchResizePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResizePoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchResizePoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchResizePoolNodesResponse> BatchResizePoolNodesAsyncInvoker(BatchResizePoolNodesRequest batchResizePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchResizePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResizePoolNodesRequest);
            return new AsyncInvoker<BatchResizePoolNodesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchResizePoolNodesResponse>);
        }
        
        /// <summary>
        /// 批量解绑应用密钥
        ///
        /// 本接口用于将已绑定的apikey从指定服务中批量解绑，适用于需要撤销多个apikey对特定服务的访问权限的场景。调用此接口前，确保已获取到需要解绑的多个apikey，并确认这些apikey当前绑定在指定服务上。解绑成功后，这些apikey将不再对指定服务生效，但仍可继续用于其他服务。如果尝试解绑不存在或未绑定到指定服务的apikey，将返回相应的异常信息，提示用户检查apikey的有效性和绑定状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUnbindInferApiKeysResponse> BatchUnbindInferApiKeysAsync(BatchUnbindInferApiKeysRequest batchUnbindInferApiKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUnbindInferApiKeysRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/api-keys/batch-unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", batchUnbindInferApiKeysRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUnbindInferApiKeysResponse>(response);
        }

        public AsyncInvoker<BatchUnbindInferApiKeysResponse> BatchUnbindInferApiKeysAsyncInvoker(BatchUnbindInferApiKeysRequest batchUnbindInferApiKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUnbindInferApiKeysRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/api-keys/batch-unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", batchUnbindInferApiKeysRequest);
            return new AsyncInvoker<BatchUnbindInferApiKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUnbindInferApiKeysResponse>);
        }
        
        /// <summary>
        /// 批量对节点功能解锁
        ///
        /// 批量对节点功能解锁接口用于批量解除指定节点功能的锁定状态，使被上锁的功能在控制台恢复正常可用状态。该接口适用于以下场景：当需要恢复被锁定的节点功能以正常使用、完成系统维护或测试后，用户可通过此接口批量对节点功能进行解锁。使用该接口的前提条件是节点功能已被上锁且用户具有管理员权限。解锁操作完成后，指定节点的功能将在控制台恢复正常，用户可以正常使用相关功能。若节点功能未被锁定、用户无权限操作或请求参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUnlockPoolNodesResponse> BatchUnlockPoolNodesAsync(BatchUnlockPoolNodesRequest batchUnlockPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUnlockPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-unlock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUnlockPoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUnlockPoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchUnlockPoolNodesResponse> BatchUnlockPoolNodesAsyncInvoker(BatchUnlockPoolNodesRequest batchUnlockPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUnlockPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-unlock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUnlockPoolNodesRequest);
            return new AsyncInvoker<BatchUnlockPoolNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUnlockPoolNodesResponse>);
        }
        
        /// <summary>
        /// 批量更新节点
        ///
        /// 批量更新节点接口用于同时修改多个节点的配置或属性，支持批量操作时各节点独立执行更新流程。该接口适用于以下场景：当用户需统一升级节点软件版本、批量处理选中节点的资源标签、调整资源分配策略、应用安全补丁或同步配置变更时，可通过此接口批量更新目标节点，确保每个节点的更新过程互不影响。使用该接口的前提条件包括：目标节点已存在且用户具备管理员权限，节点需处于可操作状态（如非锁定或维护中），批量操作时需提供有效的节点列表及更新参数（如配置项、版本号等）作为输入。操作完成后，指定节点将应用新配置并更新状态为可用，原有配置将被覆盖。若节点不存在、用户权限不足、节点状态异常（如正在维护）、更新参数不合规或输入参数缺失，接口将返回对应错误信息（如404未找到节点、403权限拒绝、400参数校验失败等）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdatePoolNodesResponse> BatchUpdatePoolNodesAsync(BatchUpdatePoolNodesRequest batchUpdatePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdatePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdatePoolNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdatePoolNodesResponse>(response);
        }

        public AsyncInvoker<BatchUpdatePoolNodesResponse> BatchUpdatePoolNodesAsyncInvoker(BatchUpdatePoolNodesRequest batchUpdatePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdatePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdatePoolNodesRequest);
            return new AsyncInvoker<BatchUpdatePoolNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdatePoolNodesResponse>);
        }
        
        /// <summary>
        /// 绑定应用密钥
        ///
        /// 本接口用于将生成的apikey与指定服务进行绑定，适用于应用程序需要调用特定服务的场景。调用此接口前，确保已成功创建服务实例，并获取到有效的apikey。绑定成功后，apikey将作为服务调用时的身份验证凭证，确保仅授权用户能够访问该服务。如果尝试绑定已失效的apikey，将返回相应的异常信息，提示用户检查apikey的有效性和绑定状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BindInferApiKeyResponse> BindInferApiKeyAsync(BindInferApiKeyRequest bindInferApiKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindInferApiKeyRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(bindInferApiKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/api-keys/{key_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindInferApiKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BindInferApiKeyResponse>(response);
        }

        public AsyncInvoker<BindInferApiKeyResponse> BindInferApiKeyAsyncInvoker(BindInferApiKeyRequest bindInferApiKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindInferApiKeyRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(bindInferApiKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/api-keys/{key_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindInferApiKeyRequest);
            return new AsyncInvoker<BindInferApiKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<BindInferApiKeyResponse>);
        }
        
        /// <summary>
        /// 中断服务部署
        ///
        /// 中断服务部署接口用于中断处于“升级中”或“部署中”状态的部署，使其快速停止。该接口适用于以下场景：当部署出现严重故障需要立即修复、资源需要快速释放以部署更高优先级的部署，或在测试环境中需要快速迭代时，用户可通过此接口中断指定部署。使用该接口的前提条件是部署当前状态为“升级中”或“部署中”，且用户具有中断部署的权限。若部署为“部署中”状态，执行中断操作，部署状态将变成“停止”，相关资源将被释放，且终端操作将被记录；若部署为“升级中”状态，执行中断操作，部署状态将变成“运行中”。若部署当前状态不是“升级中”或“部署中”，若用户无权限操作，接口将返回相应的错误信息。若部署ID无效、版本号不存在或用户无权限，则返回400 Bad Request或403 Forbidden；
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelInferDeploymentResponse> CancelInferDeploymentAsync(CancelInferDeploymentRequest cancelInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(cancelInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/interrupt", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelInferDeploymentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CancelInferDeploymentResponse>(response);
        }

        public AsyncInvoker<CancelInferDeploymentResponse> CancelInferDeploymentAsyncInvoker(CancelInferDeploymentRequest cancelInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(cancelInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/interrupt", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelInferDeploymentRequest);
            return new AsyncInvoker<CancelInferDeploymentResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelInferDeploymentResponse>);
        }
        
        /// <summary>
        /// 更新算法
        ///
        /// 更新算法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeAlgorithmResponse> ChangeAlgorithmAsync(ChangeAlgorithmRequest changeAlgorithmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeAlgorithmRequest.AlgorithmId, out var valueOfAlgorithmId)) urlParam.Add("algorithm_id", valueOfAlgorithmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms/{algorithm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeAlgorithmRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeAlgorithmResponse>(response);
        }

        public AsyncInvoker<ChangeAlgorithmResponse> ChangeAlgorithmAsyncInvoker(ChangeAlgorithmRequest changeAlgorithmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeAlgorithmRequest.AlgorithmId, out var valueOfAlgorithmId)) urlParam.Add("algorithm_id", valueOfAlgorithmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms/{algorithm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeAlgorithmRequest);
            return new AsyncInvoker<ChangeAlgorithmResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeAlgorithmResponse>);
        }
        
        /// <summary>
        /// 更新训练实验信息
        ///
        /// 通过实验ID更新训练实验信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeTrainingExperimentResponse> ChangeTrainingExperimentAsync(ChangeTrainingExperimentRequest changeTrainingExperimentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeTrainingExperimentRequest.ExperimentId, out var valueOfExperimentId)) urlParam.Add("experiment_id", valueOfExperimentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments/{experiment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeTrainingExperimentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeTrainingExperimentResponse>(response);
        }

        public AsyncInvoker<ChangeTrainingExperimentResponse> ChangeTrainingExperimentAsyncInvoker(ChangeTrainingExperimentRequest changeTrainingExperimentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeTrainingExperimentRequest.ExperimentId, out var valueOfExperimentId)) urlParam.Add("experiment_id", valueOfExperimentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments/{experiment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeTrainingExperimentRequest);
            return new AsyncInvoker<ChangeTrainingExperimentResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeTrainingExperimentResponse>);
        }
        
        /// <summary>
        /// 更新训练作业描述
        ///
        /// 更新训练作业描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeTrainingJobDescriptionResponse> ChangeTrainingJobDescriptionAsync(ChangeTrainingJobDescriptionRequest changeTrainingJobDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeTrainingJobDescriptionRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeTrainingJobDescriptionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeTrainingJobDescriptionResponse>(response);
        }

        public AsyncInvoker<ChangeTrainingJobDescriptionResponse> ChangeTrainingJobDescriptionAsyncInvoker(ChangeTrainingJobDescriptionRequest changeTrainingJobDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeTrainingJobDescriptionRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeTrainingJobDescriptionRequest);
            return new AsyncInvoker<ChangeTrainingJobDescriptionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeTrainingJobDescriptionResponse>);
        }
        
        /// <summary>
        /// 校验训练实验名称
        ///
        /// 校验训练实验名称接口用于新增训练实验前校验训练实验名称是否重复。
        /// 该接口适用于以下场景：当用户需要创建新的训练实验时，可以通过此接口校验定义的实验名称是否已存在。使用该接口的前提条件是用户具有创建实验的权限。查询操作完成后，将返回实验名称是否重复的结果。若用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckTrainingExperimentResponse> CheckTrainingExperimentAsync(CheckTrainingExperimentRequest checkTrainingExperimentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiment-names", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkTrainingExperimentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckTrainingExperimentResponse>(response);
        }

        public AsyncInvoker<CheckTrainingExperimentResponse> CheckTrainingExperimentAsyncInvoker(CheckTrainingExperimentRequest checkTrainingExperimentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiment-names", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkTrainingExperimentRequest);
            return new AsyncInvoker<CheckTrainingExperimentResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckTrainingExperimentResponse>);
        }
        
        /// <summary>
        /// 通过标签查询资源数量
        ///
        /// 该接口适用于需要统计和获取符合特定标签或资源名称条件的资源数量的场景，例如在资源管理和监控中，用户可以通过指定标签或资源名称进行精确或模糊查询来统计资源数量。通过调用此接口，用户可以基于多个标签或资源名称进行查询，若不传标签则返回所有资源的总数。用户必须具有足够的权限，且目标资源需存在。查询成功后，返回符合条件的资源总数；若失败，返回具体的错误信息。常见异常包括权限验证错误、资源不存在错误和参数验证错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountInferServicesByTagsResponse> CountInferServicesByTagsAsync(CountInferServicesByTagsRequest countInferServicesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInferServicesByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountInferServicesByTagsResponse>(response);
        }

        public AsyncInvoker<CountInferServicesByTagsResponse> CountInferServicesByTagsAsyncInvoker(CountInferServicesByTagsRequest countInferServicesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInferServicesByTagsRequest);
            return new AsyncInvoker<CountInferServicesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountInferServicesByTagsResponse>);
        }
        
        /// <summary>
        /// 创建算法
        ///
        /// 创建一个算法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAlgorithmResponse> CreateAlgorithmAsync(CreateAlgorithmRequest createAlgorithmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAlgorithmRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAlgorithmResponse>(response);
        }

        public AsyncInvoker<CreateAlgorithmResponse> CreateAlgorithmAsyncInvoker(CreateAlgorithmRequest createAlgorithmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAlgorithmRequest);
            return new AsyncInvoker<CreateAlgorithmResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlgorithmResponse>);
        }
        
        /// <summary>
        /// 创建发布算法资产
        ///
        /// 创建发布算法资产接口用于在算法管理中创建并发布新的算法资产。
        /// 该接口适用于以下场景：当用户开发完成新的算法并希望将其发布为可复用的算法资产时，可以通过此接口创建并发布算法资产。使用该接口的前提条件是用户已登录且具有创建和发布算法资产的权限。创建发布操作完成后，系统将生成新的算法资产，并将其添加到算法资产列表中，用户可以通过算法ID进行管理和调用。若用户无权限操作、算法资产信息不完整或已存在相同名称的算法资产，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAlgorithmVersionToGalleryResponse> CreateAlgorithmVersionToGalleryAsync(CreateAlgorithmVersionToGalleryRequest createAlgorithmVersionToGalleryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/gallery-algorithm-publication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAlgorithmVersionToGalleryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAlgorithmVersionToGalleryResponse>(response);
        }

        public AsyncInvoker<CreateAlgorithmVersionToGalleryResponse> CreateAlgorithmVersionToGalleryAsyncInvoker(CreateAlgorithmVersionToGalleryRequest createAlgorithmVersionToGalleryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/gallery-algorithm-publication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAlgorithmVersionToGalleryRequest);
            return new AsyncInvoker<CreateAlgorithmVersionToGalleryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlgorithmVersionToGalleryResponse>);
        }
        
        /// <summary>
        /// 配置授权
        ///
        /// 配置授权接口用于配置ModelArts的授权。该接口适用于以下场景：当需要为IAM子用户设置访问ModelArts的权限时，管理员可通过此接口配置授权。使用该接口的前提条件是管理员具备IAM系统的Security Administrator权限，并且需要为子用户设置访问密钥。配置完成后，子用户将被授予访问ModelArts资源的权限，从而能够正常使用训练管理、开发环境、数据管理、在线服务等功能。若管理员无权限操作或子用户不存在，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAuthorizationResponse> CreateAuthorizationAsync(CreateAuthorizationRequest createAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAuthorizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAuthorizationResponse>(response);
        }

        public AsyncInvoker<CreateAuthorizationResponse> CreateAuthorizationAsyncInvoker(CreateAuthorizationRequest createAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAuthorizationRequest);
            return new AsyncInvoker<CreateAuthorizationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuthorizationResponse>);
        }
        
        /// <summary>
        /// 创建应用密钥
        ///
        /// 本接口用于在系统中创建一个新的API_KEY，适用于需要为用户或应用程序生成访问凭证的场景。调用此接口前，确保已具备相应的创建权限，并提供必要的参数，如用户ID或应用程序ID。创建成功后，系统将生成一个唯一的API_KEY，并返回该API_KEY的详细信息，包括API_KEY值、创建时间等。如果提供的参数无效或系统中已存在相同的API_KEY，将返回相应的异常信息，提示用户检查输入数据的有效性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInferApiKeyResponse> CreateInferApiKeyAsync(CreateInferApiKeyRequest createInferApiKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/api-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInferApiKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInferApiKeyResponse>(response);
        }

        public AsyncInvoker<CreateInferApiKeyResponse> CreateInferApiKeyAsyncInvoker(CreateInferApiKeyRequest createInferApiKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/api-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInferApiKeyRequest);
            return new AsyncInvoker<CreateInferApiKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInferApiKeyResponse>);
        }
        
        /// <summary>
        /// 添加部署
        ///
        /// 将模型部署为在线服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInferDeploymentResponse> CreateInferDeploymentAsync(CreateInferDeploymentRequest createInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInferDeploymentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInferDeploymentResponse>(response);
        }

        public AsyncInvoker<CreateInferDeploymentResponse> CreateInferDeploymentAsyncInvoker(CreateInferDeploymentRequest createInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInferDeploymentRequest);
            return new AsyncInvoker<CreateInferDeploymentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInferDeploymentResponse>);
        }
        
        /// <summary>
        /// 创建内网接入
        ///
        /// 本接口用于在指定Region中创建内网接入点，适用于需要为应用程序或服务配置内网连接的场景。调用此接口前，确保已具备相应的创建权限，并提供必要的参数，如Region ID、内网接入点名称和网络配置信息。创建成功后，系统将生成一个内网接入点，并返回该接入点的详细信息，包括接入点ID、创建时间、状态等。如果提供的参数无效或内网接入配置冲突，将返回相应的异常信息，提示用户检查输入数据的有效性和配置冲突情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInferIntranetConnectionResponse> CreateInferIntranetConnectionAsync(CreateInferIntranetConnectionRequest createInferIntranetConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInferIntranetConnectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInferIntranetConnectionResponse>(response);
        }

        public AsyncInvoker<CreateInferIntranetConnectionResponse> CreateInferIntranetConnectionAsyncInvoker(CreateInferIntranetConnectionRequest createInferIntranetConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInferIntranetConnectionRequest);
            return new AsyncInvoker<CreateInferIntranetConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInferIntranetConnectionResponse>);
        }
        
        /// <summary>
        /// 创建服务
        ///
        /// 将模型部署为在线服务，适用于用户在开发或运维过程中需要将训练好的模型部署为在线服务，以便通过API或HTTP接口提供预测或处理能力的场景。调用此接口前，用户必须具有创建服务的权限，并提供合法的模型镜像路径和完整的服务配置信息（如服务名称、模型镜像路径、资源配置、升级配置等）。调用成功后，系统将成功创建并部署服务，服务状态变为“部署中”，并生成服务的唯一ID返回给用户。服务的详细信息（如状态、创建时间、更新时间等）也会记录在系统中。如果用户没有创建服务的权限，或提供的模型镜像路径不合法，或服务配置信息不完整，调用将返回相应的错误信息。如果系统在部署过程中遇到资源不足或其他内部错误，也将返回错误信息并记录日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInferServiceResponse> CreateInferServiceAsync(CreateInferServiceRequest createInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInferServiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInferServiceResponse>(response);
        }

        public AsyncInvoker<CreateInferServiceResponse> CreateInferServiceAsyncInvoker(CreateInferServiceRequest createInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInferServiceRequest);
            return new AsyncInvoker<CreateInferServiceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInferServiceResponse>);
        }
        
        /// <summary>
        /// 添加标签
        ///
        /// 该接口适用于需要为资源（如模型、数据集、服务等）添加元数据标签的场景，例如在资源管理或分类中，用户可以通过添加标签来标注资源的用途、状态或其他属性。通过调用此接口，用户可以批量添加标签，如果标签key已存在，则更新其value。用户必须具有足够的权限，且目标资源需存在。添加成功后，资源将包含新的标签信息；若失败，返回具体的错误信息。常见异常包括权限验证错误、资源不存在错误和参数验证错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInferServiceTagResponse> CreateInferServiceTagAsync(CreateInferServiceTagRequest createInferServiceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInferServiceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInferServiceTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInferServiceTagResponse>(response);
        }

        public AsyncInvoker<CreateInferServiceTagResponse> CreateInferServiceTagAsyncInvoker(CreateInferServiceTagRequest createInferServiceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInferServiceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInferServiceTagRequest);
            return new AsyncInvoker<CreateInferServiceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInferServiceTagResponse>);
        }
        
        /// <summary>
        /// 创建ModelArts委托
        ///
        /// 创建ModelArts委托接口用于创建包含OBS、SWR、IEF等依赖服务的ModelArts委托。该接口适用于以下场景：当需要配置ModelArts访问OBS、SWR、IEF等服务的权限时，用户可通过此接口创建委托。使用该接口的前提条件是用户具备创建委托的权限，并且需要在IAM系统中具备相应的权限。创建完成后，ModelArts将被授权访问OBS、SWR、IEF等服务，从而能够正常执行数据存储、镜像拉取、模型部署等功能。若用户无权限创建委托或依赖服务未配置，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateModelArtsAgencyResponse> CreateModelArtsAgencyAsync(CreateModelArtsAgencyRequest createModelArtsAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createModelArtsAgencyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateModelArtsAgencyResponse>(response);
        }

        public AsyncInvoker<CreateModelArtsAgencyResponse> CreateModelArtsAgencyAsyncInvoker(CreateModelArtsAgencyRequest createModelArtsAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createModelArtsAgencyRequest);
            return new AsyncInvoker<CreateModelArtsAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateModelArtsAgencyResponse>);
        }
        
        /// <summary>
        /// 创建网络资源
        ///
        /// 创建网络资源接口用于在系统中创建新的网络资源。该接口适用于以下场景：当需要为业务扩展、资源规划或网络架构调整时，用户可通过此接口创建新的网络资源，如虚拟网络、子网或路由等。使用该接口的前提条件是用户具有管理员权限，并且系统中具备足够的资源支持新网络资源的创建。创建操作完成后，新的网络资源将被成功添加到系统中，并可用于后续的业务配置。若用户无权限、资源不足或输入参数有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNetworkResponse> CreateNetworkAsync(CreateNetworkRequest createNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNetworkResponse>(response);
        }

        public AsyncInvoker<CreateNetworkResponse> CreateNetworkAsyncInvoker(CreateNetworkRequest createNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNetworkRequest);
            return new AsyncInvoker<CreateNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNetworkResponse>);
        }
        
        /// <summary>
        /// 创建节点池
        ///
        /// 创建节点池接口用于创建新的节点池。该接口适用于以下场景：当需要扩展计算资源、优化资源分配或部署新的服务时，用户可通过此接口创建指定配置的节点池。使用该接口的前提条件是用户具有管理员权限且节点池的配置参数（如节点数量、规格、网络配置等）已正确设置。创建操作完成后，节点池将被成功创建并处于可用状态，相关节点信息将被记录。若用户无权限操作、配置参数错误或系统资源不足，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNodePoolResponse> CreateNodePoolAsync(CreateNodePoolRequest createNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNodePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNodePoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNodePoolResponse>(response);
        }

        public AsyncInvoker<CreateNodePoolResponse> CreateNodePoolAsyncInvoker(CreateNodePoolRequest createNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNodePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNodePoolRequest);
            return new AsyncInvoker<CreateNodePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNodePoolResponse>);
        }
        
        /// <summary>
        /// 创建资源池的订单id
        ///
        /// 创建资源池订单ID接口用于生成资源池申请的订单标识。该接口适用于以下场景：当用户需要申请新资源池时（如业务扩展、资源不足或临时资源需求），可通过此接口提交按需转包周期订单的创建请求。使用该接口的前提条件是用户需具备资源申请权限，提交的资源池配置参数（如资源类型、容量、周期等）需符合系统校验规则，且当前仅支持按需转包周期订单类型。订单创建成功后，系统将生成唯一订单ID并触发后续资源分配流程，同时记录操作日志。若用户权限不足、配置参数缺失/冲突（如容量超出配额）、订单类型不支持或系统资源不足，接口将返回对应错误码及提示信息，且不会生成订单ID或占用资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrderIdResponse> CreateOrderIdAsync(CreateOrderIdRequest createOrderIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrderIdRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{name}/orderid", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOrderIdResponse>(response);
        }

        public AsyncInvoker<CreateOrderIdResponse> CreateOrderIdAsyncInvoker(CreateOrderIdRequest createOrderIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrderIdRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{name}/orderid", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderIdRequest);
            return new AsyncInvoker<CreateOrderIdResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrderIdResponse>);
        }
        
        /// <summary>
        /// 创建资源池
        ///
        /// 创建资源池接口用于在系统中创建新的资源池。该接口适用于以下场景：当需要为新业务分配资源、优化资源管理或进行资源隔离时，用户可通过此接口创建新的资源池，用于管理计算、存储、网络等资源。使用该接口的前提条件是用户具有管理员权限，并且系统中具备足够的资源支持新资源池的创建。创建操作完成后，新的资源池将被成功添加到系统中，并处于可用状态，可支持后续的资源分配和管理。若用户无权限、系统资源不足或输入参数有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePoolResponse> CreatePoolAsync(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }

        public AsyncInvoker<CreatePoolResponse> CreatePoolAsyncInvoker(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPoolRequest);
            return new AsyncInvoker<CreatePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePoolResponse>);
        }
        
        /// <summary>
        /// 创建插件
        ///
        /// 创建插件实例接口用于在系统中创建一个新的插件实例。该接口适用于以下场景：当需要扩展系统功能、部署新的插件、更新现有插件配置或测试插件时，用户可通过此接口创建指定插件的实例。使用该接口的前提条件是插件已存在且用户具有管理员权限或插件管理权限。创建操作完成后，插件实例将被成功创建并处于可用状态，相关配置信息将被记录。若插件不存在、用户无权限操作、配置参数错误或系统资源不足，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePoolPluginResponse> CreatePoolPluginAsync(CreatePoolPluginRequest createPoolPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPoolPluginRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolPluginRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePoolPluginResponse>(response);
        }

        public AsyncInvoker<CreatePoolPluginResponse> CreatePoolPluginAsyncInvoker(CreatePoolPluginRequest createPoolPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPoolPluginRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolPluginRequest);
            return new AsyncInvoker<CreatePoolPluginResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePoolPluginResponse>);
        }
        
        /// <summary>
        /// 创建训练作业镜像保存任务
        ///
        /// 创建训练作业镜像保存任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSaveImageJobResponse> CreateSaveImageJobAsync(CreateSaveImageJobRequest createSaveImageJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSaveImageJobRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(createSaveImageJobRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/save-image-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSaveImageJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSaveImageJobResponse>(response);
        }

        public AsyncInvoker<CreateSaveImageJobResponse> CreateSaveImageJobAsyncInvoker(CreateSaveImageJobRequest createSaveImageJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSaveImageJobRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(createSaveImageJobRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/save-image-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSaveImageJobRequest);
            return new AsyncInvoker<CreateSaveImageJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSaveImageJobResponse>);
        }
        
        /// <summary>
        /// 创建训练作业标签
        ///
        /// 创建训练作业标签，支持批量添加，当添加的标签key已存在，则覆盖该标签的value。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrainJobTagsResponse> CreateTrainJobTagsAsync(CreateTrainJobTagsRequest createTrainJobTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTrainJobTagsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-training-job/{training_job_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrainJobTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainJobTagsResponse>(response);
        }

        public AsyncInvoker<CreateTrainJobTagsResponse> CreateTrainJobTagsAsyncInvoker(CreateTrainJobTagsRequest createTrainJobTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTrainJobTagsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-training-job/{training_job_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrainJobTagsRequest);
            return new AsyncInvoker<CreateTrainJobTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainJobTagsResponse>);
        }
        
        /// <summary>
        /// 创建训练实验
        ///
        /// 创建训练实验接口用于在ModelArts平台上创建新的实验分类。
        /// 该接口适用于以下场景：当用户需要将训练作业放入实验中分类，有序地进行管理，可以通过此接口创建训练实验，常用于多任务的版本管理等场景。使用该接口的前提条件是用户已登录ModelArts平台并具有创建训练实验的权限。创建操作完成后，系统将返回训练实验的详细信息，包括实验ID、当前实验下的训练作业总个数等。若用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrainingExperimentResponse> CreateTrainingExperimentAsync(CreateTrainingExperimentRequest createTrainingExperimentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrainingExperimentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainingExperimentResponse>(response);
        }

        public AsyncInvoker<CreateTrainingExperimentResponse> CreateTrainingExperimentAsyncInvoker(CreateTrainingExperimentRequest createTrainingExperimentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrainingExperimentRequest);
            return new AsyncInvoker<CreateTrainingExperimentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainingExperimentResponse>);
        }
        
        /// <summary>
        /// 创建训练作业
        ///
        /// 创建训练作业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrainingJobResponse> CreateTrainingJobAsync(CreateTrainingJobRequest createTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrainingJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainingJobResponse>(response);
        }

        public AsyncInvoker<CreateTrainingJobResponse> CreateTrainingJobAsyncInvoker(CreateTrainingJobRequest createTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrainingJobRequest);
            return new AsyncInvoker<CreateTrainingJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainingJobResponse>);
        }
        
        /// <summary>
        /// 创建工作空间
        ///
        /// 创建工作空间（\&quot;default\&quot;为系统预留的默认工作空间名称，不能使用）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest createWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkspaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkspaceResponse>(response);
        }

        public AsyncInvoker<CreateWorkspaceResponse> CreateWorkspaceAsyncInvoker(CreateWorkspaceRequest createWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkspaceRequest);
            return new AsyncInvoker<CreateWorkspaceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkspaceResponse>);
        }
        
        /// <summary>
        /// 删除算法
        ///
        /// 删除算法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAlgorithmResponse> DeleteAlgorithmAsync(DeleteAlgorithmRequest deleteAlgorithmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlgorithmRequest.AlgorithmId, out var valueOfAlgorithmId)) urlParam.Add("algorithm_id", valueOfAlgorithmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms/{algorithm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlgorithmRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAlgorithmResponse>(response);
        }

        public AsyncInvoker<DeleteAlgorithmResponse> DeleteAlgorithmAsyncInvoker(DeleteAlgorithmRequest deleteAlgorithmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlgorithmRequest.AlgorithmId, out var valueOfAlgorithmId)) urlParam.Add("algorithm_id", valueOfAlgorithmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms/{algorithm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlgorithmRequest);
            return new AsyncInvoker<DeleteAlgorithmResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAlgorithmResponse>);
        }
        
        /// <summary>
        /// 删除授权
        ///
        /// 删除授权接口用于删除指定用户的授权或删除全量用户的授权。该接口适用于以下场景：当需要撤销特定用户的访问权限或在系统维护时清理所有用户的授权时，管理员可通过此接口删除指定用户的授权或全量用户的授权。使用该接口的前提条件是管理员具备删除授权的权限，并且需要指定要删除授权的用户或选择删除全量用户的授权。删除操作完成后，指定用户的授权将被移除，或所有用户的授权将被清空，用户将无法再访问相关功能。若用户不存在、管理员无权限操作或删除全量授权时系统检测到无管理员权限，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuthorizationsResponse> DeleteAuthorizationsAsync(DeleteAuthorizationsRequest deleteAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuthorizationsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuthorizationsResponse>(response);
        }

        public AsyncInvoker<DeleteAuthorizationsResponse> DeleteAuthorizationsAsyncInvoker(DeleteAuthorizationsRequest deleteAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuthorizationsRequest);
            return new AsyncInvoker<DeleteAuthorizationsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 删除镜像
        ///
        /// 删除镜像接口用于删除镜像对象，对于个人私有镜像可以通过参数一并删除SWR镜像内容。该接口适用于以下场景：当镜像不再需要、配置错误或需要清理资源时，用户可通过此接口删除指定的镜像对象。使用该接口的前提条件是镜像已存在且用户具有删除权限。删除操作完成后，镜像对象将被永久移除，相关资源和配置也将被清理。若镜像不存在、用户无权限操作或镜像正在被使用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest deleteImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImageRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteImageResponse>(response);
        }

        public AsyncInvoker<DeleteImageResponse> DeleteImageAsyncInvoker(DeleteImageRequest deleteImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImageRequest);
            return new AsyncInvoker<DeleteImageResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteImageResponse>);
        }
        
        /// <summary>
        /// 删除镜像组
        ///
        /// 删除镜像组接口用于删除镜像组内所有的版本对象，对于个人私有镜像可以通过参数一并删除SWR镜像内容。该接口适用于以下场景：当镜像不再需要、配置错误或需要清理资源时，用户可通过此接口删除指定的镜像组对象内所有版本。使用该接口的前提条件是镜像组已存在且用户具有删除权限。删除操作完成后，镜像组内所有版本对象将被永久移除，相关资源和配置也将被清理。若镜像组不存在、用户无权限操作或镜像正在被使用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteImageGroupResponse> DeleteImageGroupAsync(DeleteImageGroupRequest deleteImageGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageGroupRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/group/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImageGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteImageGroupResponse>(response);
        }

        public AsyncInvoker<DeleteImageGroupResponse> DeleteImageGroupAsyncInvoker(DeleteImageGroupRequest deleteImageGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageGroupRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/group/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImageGroupRequest);
            return new AsyncInvoker<DeleteImageGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteImageGroupResponse>);
        }
        
        /// <summary>
        /// 删除应用密钥
        ///
        /// 本接口用于删除指定的apikey，适用于管理员需要撤销对某个应用程序或用户的访问权限的场景。调用此接口前，确保已获取到需要删除的apikey，并确认apikey未在其他服务中使用。删除成功后，该apikey将无法再用于访问任何相关服务。如果尝试删除不存在或已删除的apikey，将返回相应的异常信息，提示用户检查apikey的有效性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInferApiKeyResponse> DeleteInferApiKeyAsync(DeleteInferApiKeyRequest deleteInferApiKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferApiKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/api-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferApiKeyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInferApiKeyResponse>(response);
        }

        public AsyncInvoker<DeleteInferApiKeyResponse> DeleteInferApiKeyAsyncInvoker(DeleteInferApiKeyRequest deleteInferApiKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferApiKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/api-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferApiKeyRequest);
            return new AsyncInvoker<DeleteInferApiKeyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInferApiKeyResponse>);
        }
        
        /// <summary>
        /// 删除服务部署
        ///
        /// 该接口适用于删除服务的某个部署。若服务ID、部署ID无效、版本号不存在或用户无权限，则返回400 Bad Request或403 Forbidden
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInferDeploymentResponse> DeleteInferDeploymentAsync(DeleteInferDeploymentRequest deleteInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInferDeploymentResponse>(response);
        }

        public AsyncInvoker<DeleteInferDeploymentResponse> DeleteInferDeploymentAsyncInvoker(DeleteInferDeploymentRequest deleteInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentRequest);
            return new AsyncInvoker<DeleteInferDeploymentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInferDeploymentResponse>);
        }
        
        /// <summary>
        /// 删除服务部署的实例
        ///
        /// 本接口用于删除指定的单个部署的实例，适用于需要清理或释放不再使用的部署实例资源的场景。调用此接口前，确保已具备相应的删除权限，并提供有效的服务实例ID、部署ID。删除成功后，指定的服务部署实例将被彻底移除，不再对任何请求生效。如果提供的服务实例ID、部署ID无效、服务实例已删除或权限不足，将返回相应的异常信息，提示用户检查输入数据的有效性和权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInferDeploymentInstanceResponse> DeleteInferDeploymentInstanceAsync(DeleteInferDeploymentInstanceRequest deleteInferDeploymentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentInstanceRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentInstanceRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{deployment_name}/instances/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInferDeploymentInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteInferDeploymentInstanceResponse> DeleteInferDeploymentInstanceAsyncInvoker(DeleteInferDeploymentInstanceRequest deleteInferDeploymentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentInstanceRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentInstanceRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{deployment_name}/instances/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentInstanceRequest);
            return new AsyncInvoker<DeleteInferDeploymentInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInferDeploymentInstanceResponse>);
        }
        
        /// <summary>
        /// 删除Pod
        ///
        /// 本接口用于删除指定的单个Pod，适用于需要清理或释放不再使用的Pod资源的场景。调用此接口前，确保已具备相应的删除权限，并提供有效的Pod ID。删除成功后，指定的Pod将被彻底移除，不再对任何服务请求生效。如果提供的Pod ID无效、Pod已删除或权限不足，将返回相应的异常信息，提示用户检查输入数据的有效性和权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInferDeploymentPodResponse> DeleteInferDeploymentPodAsync(DeleteInferDeploymentPodRequest deleteInferDeploymentPodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentPodRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentPodRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentPodRequest.InstanceName, out var valueOfInstanceName)) urlParam.Add("instance_name", valueOfInstanceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentPodRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{deployment_name}/instances/{instance_name}/pods/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentPodRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInferDeploymentPodResponse>(response);
        }

        public AsyncInvoker<DeleteInferDeploymentPodResponse> DeleteInferDeploymentPodAsyncInvoker(DeleteInferDeploymentPodRequest deleteInferDeploymentPodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentPodRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentPodRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentPodRequest.InstanceName, out var valueOfInstanceName)) urlParam.Add("instance_name", valueOfInstanceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentPodRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{deployment_name}/instances/{instance_name}/pods/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentPodRequest);
            return new AsyncInvoker<DeleteInferDeploymentPodResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInferDeploymentPodResponse>);
        }
        
        /// <summary>
        /// 删除在线服务部署版本
        ///
        /// 此接口用于删除指定服务部署的某个在线版本，适用于需要清理不再使用的版本或优化资源管理的场景。
        /// 请求需包含有效的服务ID、部署ID及版本号。用户必须具有对目标服务部署的管理权限，并且该版本当前未处于活跃状态。
        /// 删除成功后，指定版本将从在线服务部署中移除，相关资源将被释放。
        /// 若服务ID、部署ID无效、版本号不存在或用户无权限，则返回400 Bad Request或403 Forbidden；若版本处于活跃状态或有其他依赖，则返回400 Bad Request。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInferDeploymentVersionResponse> DeleteInferDeploymentVersionAsync(DeleteInferDeploymentVersionRequest deleteInferDeploymentVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentVersionRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentVersionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/versions/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentVersionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInferDeploymentVersionResponse>(response);
        }

        public AsyncInvoker<DeleteInferDeploymentVersionResponse> DeleteInferDeploymentVersionAsyncInvoker(DeleteInferDeploymentVersionRequest deleteInferDeploymentVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentVersionRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentVersionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/versions/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentVersionRequest);
            return new AsyncInvoker<DeleteInferDeploymentVersionResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInferDeploymentVersionResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 该接口适用于需要从资源（如模型、数据集、服务等）中移除特定标签的场景，例如在资源管理或分类中，用户可以通过删除标签来调整或清理资源的元数据。通过调用此接口，用户可以批量删除指定的标签。用户必须具有足够的权限，且目标资源需存在。删除成功后，资源将不再包含指定的标签信息；若失败，返回具体的错误信息。常见异常包括权限验证错误、资源不存在错误和参数验证错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInferServiceTagResponse> DeleteInferServiceTagAsync(DeleteInferServiceTagRequest deleteInferServiceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferServiceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferServiceTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInferServiceTagResponse>(response);
        }

        public AsyncInvoker<DeleteInferServiceTagResponse> DeleteInferServiceTagAsyncInvoker(DeleteInferServiceTagRequest deleteInferServiceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferServiceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferServiceTagRequest);
            return new AsyncInvoker<DeleteInferServiceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInferServiceTagResponse>);
        }
        
        /// <summary>
        /// 删除网络资源
        ///
        /// 删除网络资源接口用于移除指定的网络资源。该接口适用于以下场景：当网络资源不再需要、配置错误或需要清理资源时，用户可通过此接口删除指定的网络资源。使用该接口的前提条件是网络资源已存在且用户具有管理员权限。删除操作完成后，指定的网络资源将被永久移除，相关配置和关联关系也将被清理。若指定的网络资源不存在、用户无权限操作或资源被其他资源依赖，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNetworkResponse> DeleteNetworkAsync(DeleteNetworkRequest deleteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNetworkRequest.NetworkName, out var valueOfNetworkName)) urlParam.Add("network_name", valueOfNetworkName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks/{network_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNetworkRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNetworkResponse>(response);
        }

        public AsyncInvoker<DeleteNetworkResponse> DeleteNetworkAsyncInvoker(DeleteNetworkRequest deleteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNetworkRequest.NetworkName, out var valueOfNetworkName)) urlParam.Add("network_name", valueOfNetworkName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks/{network_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNetworkRequest);
            return new AsyncInvoker<DeleteNetworkResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNetworkResponse>);
        }
        
        /// <summary>
        /// 删除节点池
        ///
        /// 删除节点池接口用于移除已创建的节点池，包周期资源池不支持。该接口适用于以下场景：当节点池完成任务、配置错误或需要清理资源时，用户可通过此接口删除指定的节点池。使用该接口的前提条件是节点池已存在且用户具有管理员权限。删除操作完成后，节点池将被永久移除，相关资源和配置也将被清理。若节点池不存在、用户无权限操作或节点池处于不可删除状态（如包周期资源池或节点池正在使用中），接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNodePoolResponse> DeleteNodePoolAsync(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNodePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(deleteNodePoolRequest.NodepoolName, out var valueOfNodepoolName)) urlParam.Add("nodepool_name", valueOfNodepoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools/{nodepool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNodePoolResponse>(response);
        }

        public AsyncInvoker<DeleteNodePoolResponse> DeleteNodePoolAsyncInvoker(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNodePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(deleteNodePoolRequest.NodepoolName, out var valueOfNodepoolName)) urlParam.Add("nodepool_name", valueOfNodepoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools/{nodepool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            return new AsyncInvoker<DeleteNodePoolResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNodePoolResponse>);
        }
        
        /// <summary>
        /// 删除资源池
        ///
        /// 删除资源池接口用于移除指定的资源池。该接口适用于以下场景：当资源池不再需要、配置错误或需要清理资源时，用户可通过此接口删除指定的资源池。使用该接口的前提条件是资源池已存在且用户具有管理员权限。删除操作完成后，指定的资源池将被永久移除，相关资源和配置也将被清理。若资源池不存在、用户无权限操作或资源池被其他资源依赖，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePoolResponse> DeletePoolAsync(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePoolResponse>(response);
        }

        public AsyncInvoker<DeletePoolResponse> DeletePoolAsyncInvoker(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            return new AsyncInvoker<DeletePoolResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePoolResponse>);
        }
        
        /// <summary>
        /// 删除训练作业标签
        ///
        /// 删除训练作业标签，支持批量删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrainJobTagsResponse> DeleteTrainJobTagsAsync(DeleteTrainJobTagsRequest deleteTrainJobTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrainJobTagsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-training-job/{training_job_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteTrainJobTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrainJobTagsResponse>(response);
        }

        public AsyncInvoker<DeleteTrainJobTagsResponse> DeleteTrainJobTagsAsyncInvoker(DeleteTrainJobTagsRequest deleteTrainJobTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrainJobTagsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-training-job/{training_job_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteTrainJobTagsRequest);
            return new AsyncInvoker<DeleteTrainJobTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrainJobTagsResponse>);
        }
        
        /// <summary>
        /// 删除训练实验
        ///
        /// 删除训练实验接口用于移除已创建的训练实验。
        /// 该接口适用于以下场景：当训练实验完成、配置错误或需要清理资源时，用户可以通过此接口删除指定的训练实验。使用该接口的前提条件是训练实验已存在且用户具有删除该实验的权限。删除操作完成后，训练实验将被永久移除，相关的配置和资源也将被清理。若训练实验不存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrainingExperimentResponse> DeleteTrainingExperimentAsync(DeleteTrainingExperimentRequest deleteTrainingExperimentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrainingExperimentRequest.ExperimentId, out var valueOfExperimentId)) urlParam.Add("experiment_id", valueOfExperimentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments/{experiment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrainingExperimentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrainingExperimentResponse>(response);
        }

        public AsyncInvoker<DeleteTrainingExperimentResponse> DeleteTrainingExperimentAsyncInvoker(DeleteTrainingExperimentRequest deleteTrainingExperimentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrainingExperimentRequest.ExperimentId, out var valueOfExperimentId)) urlParam.Add("experiment_id", valueOfExperimentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments/{experiment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrainingExperimentRequest);
            return new AsyncInvoker<DeleteTrainingExperimentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrainingExperimentResponse>);
        }
        
        /// <summary>
        /// 删除训练作业
        ///
        /// 删除训练作业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrainingJobResponse> DeleteTrainingJobAsync(DeleteTrainingJobRequest deleteTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrainingJobRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrainingJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrainingJobResponse>(response);
        }

        public AsyncInvoker<DeleteTrainingJobResponse> DeleteTrainingJobAsyncInvoker(DeleteTrainingJobRequest deleteTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrainingJobRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrainingJobRequest);
            return new AsyncInvoker<DeleteTrainingJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrainingJobResponse>);
        }
        
        /// <summary>
        /// 删除工作空间
        ///
        /// 删除工作空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest deleteWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkspaceRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkspaceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteWorkspaceResponse>(response);
        }

        public AsyncInvoker<DeleteWorkspaceResponse> DeleteWorkspaceAsyncInvoker(DeleteWorkspaceRequest deleteWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkspaceRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkspaceRequest);
            return new AsyncInvoker<DeleteWorkspaceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteWorkspaceResponse>);
        }
        
        /// <summary>
        /// 动态卸载Notebook存储
        ///
        /// 动态卸载Notebook存储接口用于从运行中的Notebook实例中卸载已挂载的动态存储实例。
        /// 
        /// 适用场景：用户需要清理或重新组织Notebook实例的挂载资源时，可通过此接口卸载指定的存储实例。使用该接口的前提条件是用户已登录系统并具有访问目标Notebook实例的权限，同时Notebook实例必须处于运行状态且存储实例处于MOUNTED / UNMOUNT_FAILED / MOUNT_FAILED状态。调用该接口后，系统将卸载指定的存储实例，Notebook容器将无法再操作存储中的文件或对象，但存储中的文件或对象保持不变。若用户无权限访问指定实例或Notebook实例未运行，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachDynamicStorageResponse> DetachDynamicStorageAsync(DetachDynamicStorageRequest detachDynamicStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachDynamicStorageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(detachDynamicStorageRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{instance_id}/storage/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachDynamicStorageRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DetachDynamicStorageResponse>(response);
        }

        public AsyncInvoker<DetachDynamicStorageResponse> DetachDynamicStorageAsyncInvoker(DetachDynamicStorageRequest detachDynamicStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachDynamicStorageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(detachDynamicStorageRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{instance_id}/storage/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachDynamicStorageRequest);
            return new AsyncInvoker<DetachDynamicStorageResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DetachDynamicStorageResponse>);
        }
        
        /// <summary>
        /// 查看授权列表
        ///
        /// 查看授权列表接口用于查看授权信息。该接口适用于以下场景：当用户需要了解当前的授权情况、审核权限分配或管理权限时，可通过此接口查看授权列表。使用该接口的前提条件是用户具备查看授权的权限。查看操作完成后，将返回授权列表，包括被授权的资源、授权类型以及授权内容等信息。若用户无权限查看或授权列表不存在，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetAuthorizationsResponse> GetAuthorizationsAsync(GetAuthorizationsRequest getAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAuthorizationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetAuthorizationsResponse>(response);
        }

        public AsyncInvoker<GetAuthorizationsResponse> GetAuthorizationsAsyncInvoker(GetAuthorizationsRequest getAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAuthorizationsRequest);
            return new AsyncInvoker<GetAuthorizationsResponse>(this, "GET", request, JsonUtils.DeSerialize<GetAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 查询超节点Operation详情
        ///
        /// 查询Operation详情接口用于获取指定Operation的详细信息。该接口适用于以下场景：当用户需要了解某个Operation的具体执行情况和状态，以便进行故障排查或操作审计时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询Operation详情的权限，且指定的Operation已存在。查询操作完成后，接口将返回指定Operation的详细信息，包括Operation ID、操作类型、执行状态、开始时间、结束时间、操作结果等。若用户无权限操作、指定的Operation不存在或Operation ID无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetHyperinstanceOperationResponse> GetHyperinstanceOperationAsync(GetHyperinstanceOperationRequest getHyperinstanceOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getHyperinstanceOperationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(getHyperinstanceOperationRequest.OperationId, out var valueOfOperationId)) urlParam.Add("operation_id", valueOfOperationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/operation/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHyperinstanceOperationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetHyperinstanceOperationResponse>(response);
        }

        public AsyncInvoker<GetHyperinstanceOperationResponse> GetHyperinstanceOperationAsyncInvoker(GetHyperinstanceOperationRequest getHyperinstanceOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getHyperinstanceOperationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(getHyperinstanceOperationRequest.OperationId, out var valueOfOperationId)) urlParam.Add("operation_id", valueOfOperationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/operation/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHyperinstanceOperationRequest);
            return new AsyncInvoker<GetHyperinstanceOperationResponse>(this, "GET", request, JsonUtils.DeSerialize<GetHyperinstanceOperationResponse>);
        }
        
        /// <summary>
        /// 查询算法列表
        ///
        /// 查询算法列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlgorithmsResponse> ListAlgorithmsAsync(ListAlgorithmsRequest listAlgorithmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlgorithmsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlgorithmsResponse>(response);
        }

        public AsyncInvoker<ListAlgorithmsResponse> ListAlgorithmsAsyncInvoker(ListAlgorithmsRequest listAlgorithmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlgorithmsRequest);
            return new AsyncInvoker<ListAlgorithmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlgorithmsResponse>);
        }
        
        /// <summary>
        /// 获取动态挂载存储信息列表
        ///
        /// 此接口用于获取指定Notebook实例下挂载的动态存储信息列表。
        /// 适用场景：用户需要获取指定Notebook实例下挂载的动态存储的存储id、存储类型、挂载路径、挂载状态等信息的场景。若挂载失败，会返回相应错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDynamicStoragesResponse> ListDynamicStoragesAsync(ListDynamicStoragesRequest listDynamicStoragesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDynamicStoragesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{instance_id}/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDynamicStoragesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDynamicStoragesResponse>(response);
        }

        public AsyncInvoker<ListDynamicStoragesResponse> ListDynamicStoragesAsyncInvoker(ListDynamicStoragesRequest listDynamicStoragesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDynamicStoragesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{instance_id}/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDynamicStoragesRequest);
            return new AsyncInvoker<ListDynamicStoragesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDynamicStoragesResponse>);
        }
        
        /// <summary>
        /// 获取事件类型列表
        ///
        /// 获取事件类型列表接口用于获取训练管理中支持的事件类型列表。
        /// 该接口适用于以下场景：当用户需要了解训练管理中支持的事件类型，以便在创建或管理训练任务时进行相关配置时，可以通过此接口获取事件类型列表。使用该接口的前提条件是用户已登录且具有访问训练管理的权限。获取操作完成后，响应消息体中将包含所有支持的事件类型及其描述。若用户无权限访问或系统中无事件类型信息，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEventCategoriesResponse> ListEventCategoriesAsync(ListEventCategoriesRequest listEventCategoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-event-categories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventCategoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEventCategoriesResponse>(response);
        }

        public AsyncInvoker<ListEventCategoriesResponse> ListEventCategoriesAsyncInvoker(ListEventCategoriesRequest listEventCategoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-event-categories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventCategoriesRequest);
            return new AsyncInvoker<ListEventCategoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEventCategoriesResponse>);
        }
        
        /// <summary>
        /// 查询事件列表
        ///
        /// 查询事件列表接口用于获取系统中记录的事件信息。该接口适用于以下场景：当用户需要监控系统状态、排查问题或进行审计时，可通过此接口查询系统中发生的事件记录。使用该接口的前提条件是用户具有相应的权限，并且系统中已存在事件记录。查询操作完成后，接口将返回事件列表，包含事件ID、类型、时间、描述等信息。若用户无权限、事件记录不存在或查询参数有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEventsResponse> ListEventsAsync(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }

        public AsyncInvoker<ListEventsResponse> ListEventsAsyncInvoker(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            return new AsyncInvoker<ListEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEventsResponse>);
        }
        
        /// <summary>
        /// 查询支持的镜像列表
        ///
        /// 查询支持的镜像列表接口用于根据指定条件分页查询满足条件的所有镜像。该接口适用于以下场景：当用户需要查找特定镜像、管理镜像仓库或选择合适的镜像版本进行部署时，可通过此接口获取符合条件的镜像列表。使用该接口的前提条件是镜像仓库已存在且用户具有访问权限。查询操作完成后，将返回满足条件的镜像列表，包括镜像ID、名称、版本、类型、状态、大小和创建时间等详细信息。若镜像仓库不存在、用户无权限访问或查询条件有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageResponse> ListImageAsync(ListImageRequest listImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImageResponse>(response);
        }

        public AsyncInvoker<ListImageResponse> ListImageAsyncInvoker(ListImageRequest listImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageRequest);
            return new AsyncInvoker<ListImageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageResponse>);
        }
        
        /// <summary>
        /// 查询用户镜像列表
        ///
        /// 查询用户镜像列表接口用于查询用户镜像信息概览，以镜像名称作为聚合的信息。该接口适用于以下场景：当用户需要管理多个镜像或了解各镜像的基本信息时，可通过此接口获取镜像列表及其概览信息。使用该接口的前提条件是用户具备镜像管理权限，并且镜像已存在。查询操作完成后，将返回用户所有镜像的列表，包括镜像名称、版本、状态等信息。若镜像不存在或用户无权限访问，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageGroupResponse> ListImageGroupAsync(ListImageGroupRequest listImageGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImageGroupResponse>(response);
        }

        public AsyncInvoker<ListImageGroupResponse> ListImageGroupAsyncInvoker(ListImageGroupRequest listImageGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageGroupRequest);
            return new AsyncInvoker<ListImageGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageGroupResponse>);
        }
        
        /// <summary>
        /// 查询应用密钥
        ///
        /// 本接口用于查询当前系统中的apikey列表，适用于管理员或用户需要查看和管理apikey的场景。调用此接口前，确保已具备相应的查询权限。返回的列表将包含每个apikey的基本信息，如apikey值、创建时间、绑定的服务等。如果当前系统中没有apikey，将返回空列表或相应的异常信息，提示用户检查查询条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferApiKeysResponse> ListInferApiKeysAsync(ListInferApiKeysRequest listInferApiKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/api-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferApiKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferApiKeysResponse>(response);
        }

        public AsyncInvoker<ListInferApiKeysResponse> ListInferApiKeysAsyncInvoker(ListInferApiKeysRequest listInferApiKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/api-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferApiKeysRequest);
            return new AsyncInvoker<ListInferApiKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferApiKeysResponse>);
        }
        
        /// <summary>
        /// 查询支持可切换规格列表
        ///
        /// 该接口允许用户查询当前资源实例支持的可切换规格列表，适用于需要调整实例资源配置的场景。使用该接口前，用户需确保已登录并拥有查询权限。执行成功后，用户将获得一个包含各种可切换规格的详细列表，包括规格ID、名称、资源配额等信息，可用于后续的实例规格变更操作。如果用户没有相应的查询权限或资源实例ID无效，接口将返回错误信息，如401 Unauthorized或404 Not Found。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferClusterFlavorsResponse> ListInferClusterFlavorsAsync(ListInferClusterFlavorsRequest listInferClusterFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferClusterFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferClusterFlavorsResponse>(response);
        }

        public AsyncInvoker<ListInferClusterFlavorsResponse> ListInferClusterFlavorsAsyncInvoker(ListInferClusterFlavorsRequest listInferClusterFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferClusterFlavorsRequest);
            return new AsyncInvoker<ListInferClusterFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferClusterFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询服务部署实例列表
        ///
        /// 本接口用于查询当前[租户](tag:hws,hws_hk,fcs,fcs_super)[资源空间](tag:hcs,hcs_sm)的服务部署实例列表，并支持根据服务部署实例的状态进行筛选，包括运行中和已删除状态，同时支持分页和关键词筛选。适用于需要管理和监控服务实例状态的场景。调用此接口前，确保已具备相应的查询权限，并提供可选的筛选条件和分页参数。返回的列表将包含每个服务部署实例的基本信息，如部署名字、最新更新时间、状态等。如果当前租户没有符合条件的服务实例或提供的参数无效，将返回空列表或相应的异常信息，提示用户检查输入数据的有效性和权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferDeploymentInstancesResponse> ListInferDeploymentInstancesAsync(ListInferDeploymentInstancesRequest listInferDeploymentInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentInstancesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentInstancesRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{name}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferDeploymentInstancesResponse>(response);
        }

        public AsyncInvoker<ListInferDeploymentInstancesResponse> ListInferDeploymentInstancesAsyncInvoker(ListInferDeploymentInstancesRequest listInferDeploymentInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentInstancesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentInstancesRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{name}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentInstancesRequest);
            return new AsyncInvoker<ListInferDeploymentInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferDeploymentInstancesResponse>);
        }
        
        /// <summary>
        /// 查询Pod事件
        ///
        /// 本接口用于查询指定Pod的Kubernetes事件，适用于需要监控和排查Pod运行状态的场景。调用此接口前，确保已具备相应的查询权限，并提供有效的Pod ID。返回的事件列表将包含每个事件的详细信息，如事件类型、发生次数、事件名称、事件信息、发生时间等。如果提供的Pod ID无效、Pod不存在或权限不足，将返回相应的异常信息，提示用户检查输入数据的有效性和权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferDeploymentPodEventsResponse> ListInferDeploymentPodEventsAsync(ListInferDeploymentPodEventsRequest listInferDeploymentPodEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodEventsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodEventsRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodEventsRequest.InstanceName, out var valueOfInstanceName)) urlParam.Add("instance_name", valueOfInstanceName);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodEventsRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{deployment_name}/instances/{instance_name}/pods/{name}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentPodEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listInferDeploymentPodEventsResponse = JsonUtils.DeSerializeNull<ListInferDeploymentPodEventsResponse>(response);
            listInferDeploymentPodEventsResponse.Body = JsonUtils.DeSerializeList<ServicePodEventResponse>(response);
            return listInferDeploymentPodEventsResponse;
        }

        public AsyncInvoker<ListInferDeploymentPodEventsResponse> ListInferDeploymentPodEventsAsyncInvoker(ListInferDeploymentPodEventsRequest listInferDeploymentPodEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodEventsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodEventsRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodEventsRequest.InstanceName, out var valueOfInstanceName)) urlParam.Add("instance_name", valueOfInstanceName);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodEventsRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{deployment_name}/instances/{instance_name}/pods/{name}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentPodEventsRequest);
            return new AsyncInvoker<ListInferDeploymentPodEventsResponse>(this, "GET", request, response =>
            {
                var listInferDeploymentPodEventsResponse = JsonUtils.DeSerializeNull<ListInferDeploymentPodEventsResponse>(response);
                listInferDeploymentPodEventsResponse.Body = JsonUtils.DeSerializeList<ServicePodEventResponse>(response);
                return listInferDeploymentPodEventsResponse;
            });
        }
        
        /// <summary>
        /// 查询服务部署的pod的列表
        ///
        /// 本接口用于查询指定服务部署的pod列表，并支持选择是否只获取当前运行中的pod。适用于需要管理和监控服务部署pod状态的场景。调用此接口前，确保已具备相应的查询权限，并提供有效的服务ID、部署ID和可选的筛选参数pod status（如是否只获取当前运行中的pod）。返回的列表将包含每个pod的基本信息，如pod名称、pod所在node的IP、pod所在node名字、pod角色、状态、最近更新时间等。如果指定的服务ID无效或当前服务没有pod，将返回空列表或相应的异常信息，提示用户检查输入数据的有效性和权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferDeploymentPodsResponse> ListInferDeploymentPodsAsync(ListInferDeploymentPodsRequest listInferDeploymentPodsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodsRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodsRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{deployment_name}/instances/{name}/pods", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentPodsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferDeploymentPodsResponse>(response);
        }

        public AsyncInvoker<ListInferDeploymentPodsResponse> ListInferDeploymentPodsAsyncInvoker(ListInferDeploymentPodsRequest listInferDeploymentPodsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodsRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentPodsRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{id}/deployments/{deployment_name}/instances/{name}/pods", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentPodsRequest);
            return new AsyncInvoker<ListInferDeploymentPodsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferDeploymentPodsResponse>);
        }
        
        /// <summary>
        /// 查询在线服务部署版本列表
        ///
        /// 此接口用于获取指定服务部署的版本列表，适用于需要了解当前服务部署可用版本的场景，例如进行版本选择或确认当前版本信息。请求需包含有效的服务ID、部署ID，也可通过排序参数对列表进行排序。用户必须具有对目标服务部署的查看权限。请求成功后，返回该服务部署的所有在线版本信息，包括版本号、发布时间和状态。若服务ID/部署ID无效或用户无权限，则返回400 Bad Request或403 Forbidden；若服务部署无在线版本，则返回空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferDeploymentVersionsResponse> ListInferDeploymentVersionsAsync(ListInferDeploymentVersionsRequest listInferDeploymentVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentVersionsRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentVersionsRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferDeploymentVersionsResponse>(response);
        }

        public AsyncInvoker<ListInferDeploymentVersionsResponse> ListInferDeploymentVersionsAsyncInvoker(ListInferDeploymentVersionsRequest listInferDeploymentVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentVersionsRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentVersionsRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentVersionsRequest);
            return new AsyncInvoker<ListInferDeploymentVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferDeploymentVersionsResponse>);
        }
        
        /// <summary>
        /// 查询服务部署列表
        ///
        /// 支持分页和筛选，适用于用户在管理控制台或通过API需要查看特定条件下（如服务状态、名称等）的部署列表的情况。调用此接口前，用户必须具有查询部署列表的权限，并提供合法的分页参数（如页码、每页条数）和筛选条件（如部署状态、名称等）。调用成功后，系统将返回符合筛选条件的部署列表，包含指定页码的数据，并返回总页数和总记录数。如果用户没有查询部署列表的权限，或提供的分页参数和筛选条件不合法，调用将返回相应的错误信息。如果系统在查询过程中遇到内部错误，也将返回错误信息并记录日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferDeploymentsResponse> ListInferDeploymentsAsync(ListInferDeploymentsRequest listInferDeploymentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentsRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferDeploymentsResponse>(response);
        }

        public AsyncInvoker<ListInferDeploymentsResponse> ListInferDeploymentsAsyncInvoker(ListInferDeploymentsRequest listInferDeploymentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentsRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentsRequest);
            return new AsyncInvoker<ListInferDeploymentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferDeploymentsResponse>);
        }
        
        /// <summary>
        /// 查询当前的内网接入申请列表
        ///
        /// 本接口用于查询当前所有的内网接入申请记录，适用于需要管理和监控内网接入申请状态的场景。调用此接口前，确保已具备相应的查询权限。返回的列表将包含每个内网接入申请的基本信息，如申请ID、创建时间、状态、Region ID等。如果当前租户没有内网接入申请记录，将返回空列表。如果调用时出现权限不足或其他系统异常，将返回相应的异常信息，提示用户检查权限或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferIntranetConnectionApplicationsResponse> ListInferIntranetConnectionApplicationsAsync(ListInferIntranetConnectionApplicationsRequest listInferIntranetConnectionApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferIntranetConnectionApplicationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferIntranetConnectionApplicationsResponse>(response);
        }

        public AsyncInvoker<ListInferIntranetConnectionApplicationsResponse> ListInferIntranetConnectionApplicationsAsyncInvoker(ListInferIntranetConnectionApplicationsRequest listInferIntranetConnectionApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferIntranetConnectionApplicationsRequest);
            return new AsyncInvoker<ListInferIntranetConnectionApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferIntranetConnectionApplicationsResponse>);
        }
        
        /// <summary>
        /// 查询当前的内网接入审批列表
        ///
        /// 本接口用于查询当前所有的内网接入审批记录，适用于需要管理和监控内网接入审批状态的场景。调用此接口前，确保已具备相应的查询权限。返回的列表将包含每个内网接入审批的基本信息，如审批ID、申请时间、状态（如待审批、已批准、已拒绝）、申请者信息、Region ID等。如果当前租户没有内网接入审批记录，将返回空列表。如果调用时出现权限不足或其他系统异常，将返回相应的异常信息，提示用户检查权限或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferIntranetConnectionReviewsResponse> ListInferIntranetConnectionReviewsAsync(ListInferIntranetConnectionReviewsRequest listInferIntranetConnectionReviewsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/reviews", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferIntranetConnectionReviewsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferIntranetConnectionReviewsResponse>(response);
        }

        public AsyncInvoker<ListInferIntranetConnectionReviewsResponse> ListInferIntranetConnectionReviewsAsyncInvoker(ListInferIntranetConnectionReviewsRequest listInferIntranetConnectionReviewsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/reviews", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferIntranetConnectionReviewsRequest);
            return new AsyncInvoker<ListInferIntranetConnectionReviewsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferIntranetConnectionReviewsResponse>);
        }
        
        /// <summary>
        /// 获取在线服务事件列表
        ///
        /// 该接口适用于需要监控和管理在线服务事件的场景，例如用户或运维人员需要定期检查服务的日志事件，以及时发现和处理问题。通过调用此接口，用户可以获取当前在线服务的所有事件记录，包括事件类型、事件信息、时间、发生次数等信息。用户必须具有查询服务事件列表的权限，才能成功访问该接口。获取成功后，返回事件列表；若失败，返回具体的错误信息。常见异常包括权限验证错误、服务状态错误和参数验证错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferServiceEventsResponse> ListInferServiceEventsAsync(ListInferServiceEventsRequest listInferServiceEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferServiceEventsRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferServiceEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferServiceEventsResponse>(response);
        }

        public AsyncInvoker<ListInferServiceEventsResponse> ListInferServiceEventsAsyncInvoker(ListInferServiceEventsRequest listInferServiceEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferServiceEventsRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferServiceEventsRequest);
            return new AsyncInvoker<ListInferServiceEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferServiceEventsResponse>);
        }
        
        /// <summary>
        /// 查询某一类资源下的标签
        ///
        /// 该接口适用于需要获取用户当前项目中某一类资源（如指定的Service）的标签信息的场景，例如在资源管理和监控中，用户可以通过查询标签来了解各类资源的分类和属性。通过调用此接口，用户可以获取指定Service在所有工作空间中的标签列表，但无权限的工作空间标签数据将被过滤不返回。用户必须具有足够的权限，且目标资源需存在。查询成功后，返回指定Service的标签列表；若失败，返回具体的错误信息。常见异常包括权限验证错误、资源不存在错误和参数验证错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferServiceTagsResponse> ListInferServiceTagsAsync(ListInferServiceTagsRequest listInferServiceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferServiceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferServiceTagsResponse>(response);
        }

        public AsyncInvoker<ListInferServiceTagsResponse> ListInferServiceTagsAsyncInvoker(ListInferServiceTagsRequest listInferServiceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferServiceTagsRequest);
            return new AsyncInvoker<ListInferServiceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferServiceTagsResponse>);
        }
        
        /// <summary>
        /// 查询服务列表
        ///
        /// 支持分页和筛选
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferServicesResponse> ListInferServicesAsync(ListInferServicesRequest listInferServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferServicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferServicesResponse>(response);
        }

        public AsyncInvoker<ListInferServicesResponse> ListInferServicesAsyncInvoker(ListInferServicesRequest listInferServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferServicesRequest);
            return new AsyncInvoker<ListInferServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferServicesResponse>);
        }
        
        /// <summary>
        /// 通过标签反查资源列表
        ///
        /// 该接口适用于需要根据标签或资源名称查找相关资源的场景，例如在资源管理和搜索中，用户可以通过指定标签或进行模糊查询来查找符合特定条件的资源。通过调用此接口，用户可以基于多个标签或资源名称进行精确或模糊查询，若不传标签则返回所有资源。用户必须具有足够的权限，且目标资源需存在。查询成功后，返回符合条件的资源列表；若失败，返回具体的错误信息。常见异常包括权限验证错误、资源不存在错误和参数验证错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferServicesByTagsResponse> ListInferServicesByTagsAsync(ListInferServicesByTagsRequest listInferServicesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferServicesByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInferServicesByTagsResponse>(response);
        }

        public AsyncInvoker<ListInferServicesByTagsResponse> ListInferServicesByTagsAsyncInvoker(ListInferServicesByTagsRequest listInferServicesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferServicesByTagsRequest);
            return new AsyncInvoker<ListInferServicesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInferServicesByTagsResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 查询任务列表接口用于获取当前用户下的任务列表。该接口适用于以下场景：当需要查看任务状态、管理任务进度或统计任务数量时，用户可通过此接口获取当前用户下所有任务的详细信息。使用该接口的前提条件是用户已登录系统且具有查看任务的权限。调用接口成功后，系统将返回当前用户下的任务列表，包括任务ID、名称、状态、创建时间等信息。若用户未登录、无权限访问或系统中未配置任务，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public AsyncInvoker<ListJobsResponse> ListJobsAsyncInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new AsyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 查询网络资源列表
        ///
        /// 查询网络资源列表接口用于获取系统中已创建的网络资源信息。该接口适用于以下场景：当用户需要监控网络状态、进行资源规划、排查网络问题或进行审计时，可通过此接口查询系统中现有的网络资源列表。使用该接口的前提条件是用户具有相应的权限，并且系统中已存在网络资源。查询操作完成后，接口将返回网络资源列表，包含资源ID、类型、状态、创建时间等详细信息。若用户无权限、系统中无网络资源或查询参数有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest listNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNetworksResponse>(response);
        }

        public AsyncInvoker<ListNetworksResponse> ListNetworksAsyncInvoker(ListNetworksRequest listNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworksRequest);
            return new AsyncInvoker<ListNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetworksResponse>);
        }
        
        /// <summary>
        /// 查询节点池的节点列表
        ///
        /// 查询节点池的节点列表接口用于获取指定节点池中所有节点的详细信息。该接口适用于以下场景：当需要查看节点池的节点状态、资源使用情况或管理节点资源时，用户可通过此接口获取节点池中节点的详细信息。使用该接口的前提条件是节点池已存在且用户具有访问该节点池的权限。调用接口成功后，系统将返回节点池中所有节点的列表，包括节点ID、名称、状态、IP地址、资源使用情况等详细信息。若节点池不存在、用户无权限访问或节点池当前不可用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNodePoolNodesResponse> ListNodePoolNodesAsync(ListNodePoolNodesRequest listNodePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(listNodePoolNodesRequest.NodepoolName, out var valueOfNodepoolName)) urlParam.Add("nodepool_name", valueOfNodepoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools/{nodepool_name}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolNodesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNodePoolNodesResponse>(response);
        }

        public AsyncInvoker<ListNodePoolNodesResponse> ListNodePoolNodesAsyncInvoker(ListNodePoolNodesRequest listNodePoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodePoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(listNodePoolNodesRequest.NodepoolName, out var valueOfNodepoolName)) urlParam.Add("nodepool_name", valueOfNodepoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools/{nodepool_name}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolNodesRequest);
            return new AsyncInvoker<ListNodePoolNodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodePoolNodesResponse>);
        }
        
        /// <summary>
        /// 查询节点池列表
        ///
        /// 查询节点池列表接口用于获取指定节点池的列表信息。该接口适用于以下场景：当需要查看节点池的配置、状态或管理节点池资源时，用户可通过此接口获取节点池的详细信息。使用该接口的前提条件是节点池已存在且用户具有管理员权限。调用接口成功后，系统将返回节点池的列表，包括节点池ID、名称、节点数量、状态等详细信息。若节点池不存在、用户无权限操作或节点池当前不可用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNodePoolsResponse> ListNodePoolsAsync(ListNodePoolsRequest listNodePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodePoolsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNodePoolsResponse>(response);
        }

        public AsyncInvoker<ListNodePoolsResponse> ListNodePoolsAsyncInvoker(ListNodePoolsRequest listNodePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodePoolsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            return new AsyncInvoker<ListNodePoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodePoolsResponse>);
        }
        
        /// <summary>
        /// 查询插件模板列表
        ///
        /// 查询插件模板列表接口用于获取插件模板的基本信息列表。该接口适用于以下场景：当需要浏览或管理插件模板时，用户可通过此接口查询所有可用的插件模板信息，以便选择或进一步操作。使用该接口的前提条件是用户具有访问插件模板的权限，且插件模板服务处于正常运行状态。查询操作完成后，用户将获得插件模板的列表信息，包括模板名称、类型、版本等，便于后续的插件开发或管理。若用户无权限访问、插件模板服务不可用或请求参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPluginTemplatesResponse> ListPluginTemplatesAsync(ListPluginTemplatesRequest listPluginTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/plugintemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPluginTemplatesResponse>(response);
        }

        public AsyncInvoker<ListPluginTemplatesResponse> ListPluginTemplatesAsyncInvoker(ListPluginTemplatesRequest listPluginTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/plugintemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginTemplatesRequest);
            return new AsyncInvoker<ListPluginTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPluginTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询资源池节点列表
        ///
        /// 查询资源池节点列表接口用于获取指定资源池中的节点信息列表。该接口适用于以下场景：当需要了解资源池中节点的分布、状态或资源使用情况时，用户可通过此接口查询资源池中的节点列表，以便进行资源监控、分配或管理。使用该接口的前提条件是资源池已创建且处于可用状态，且用户具有访问资源池的权限。查询操作完成后，用户将获得资源池中节点的详细信息，包括节点ID、状态、资源使用情况等，便于后续的资源管理和优化。若资源池不存在、用户无权限访问或请求参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoolNodesResponse> ListPoolNodesAsync(ListPoolNodesRequest listPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolNodesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoolNodesResponse>(response);
        }

        public AsyncInvoker<ListPoolNodesResponse> ListPoolNodesAsyncInvoker(ListPoolNodesRequest listPoolNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPoolNodesRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolNodesRequest);
            return new AsyncInvoker<ListPoolNodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolNodesResponse>);
        }
        
        /// <summary>
        /// 查询插件列表
        ///
        /// 查询插件实例列表接口用于获取系统中已部署的插件实例信息。该接口适用于以下场景：当用户需要查看系统中已部署的插件实例、监控插件运行状态、管理插件配置或进行故障排查时，可通过此接口获取插件实例的详细信息。使用该接口的前提条件是用户具有查询权限且系统中已部署至少一个插件实例。调用该接口后，系统将返回所有插件实例的列表，包括插件名称、类型、状态、版本及部署环境等信息。若用户无权限访问或系统中未部署任何插件实例，接口将返回相应的错误信息或空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoolPluginsResponse> ListPoolPluginsAsync(ListPoolPluginsRequest listPoolPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPoolPluginsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolPluginsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoolPluginsResponse>(response);
        }

        public AsyncInvoker<ListPoolPluginsResponse> ListPoolPluginsAsyncInvoker(ListPoolPluginsRequest listPoolPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPoolPluginsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolPluginsRequest);
            return new AsyncInvoker<ListPoolPluginsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolPluginsResponse>);
        }
        
        /// <summary>
        /// 查询资源池的所有标签
        ///
        /// 查询资源池所有标签接口用于获取用户当前项目下资源池的所有标签信息，默认查询所有工作空间，但无权限的工作空间不会返回标签数据。该接口适用于以下场景：当需要管理、分类或统计资源池的标签信息时，用户可通过此接口获取资源池的标签数据。使用该接口的前提条件是用户具有访问资源池的权限且资源池已存在。调用接口成功后，系统将返回用户当前项目下所有可访问工作空间的资源池标签信息。若用户无权限访问资源池、资源池不存在或项目未创建，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoolTagsResponse> ListPoolTagsAsync(ListPoolTagsRequest listPoolTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/pools/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoolTagsResponse>(response);
        }

        public AsyncInvoker<ListPoolTagsResponse> ListPoolTagsAsyncInvoker(ListPoolTagsRequest listPoolTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/pools/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolTagsRequest);
            return new AsyncInvoker<ListPoolTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源池列表
        ///
        /// 查询资源池列表接口用于获取系统中已创建的资源池信息。该接口适用于以下场景：当用户需要监控资源池状态、进行资源规划、管理资源分配或进行审计时，可通过此接口查询系统中现有的资源池列表。使用该接口的前提条件是用户具有相应的权限，并且系统中已存在资源池。查询操作完成后，接口将返回资源池列表，包含资源池ID、名称、类型、状态、资源配额等详细信息。若用户无权限、系统中无资源池或查询参数有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoolsResponse> ListPoolsAsync(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }

        public AsyncInvoker<ListPoolsResponse> ListPoolsAsyncInvoker(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            return new AsyncInvoker<ListPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolsResponse>);
        }
        
        /// <summary>
        /// 查询资源规格列表
        ///
        /// 查询资源规格列表接口用于获取可用的资源规格信息。该接口适用于以下场景：当需要查看或选择资源规格以创建资源池、分配资源或了解可用资源规格时，用户可通过此接口获取资源规格的详细信息。使用该接口的前提条件是用户具有相应的权限（如管理员权限或资源管理权限）。调用接口成功后，系统将返回资源规格的列表，包括规格ID、名称、CPU核数、内存大小、存储容量等详细信息。若用户无权限访问该接口或系统中未配置资源规格，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceFlavorsResponse> ListResourceFlavorsAsync(ListResourceFlavorsRequest listResourceFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/resourceflavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceFlavorsResponse>(response);
        }

        public AsyncInvoker<ListResourceFlavorsResponse> ListResourceFlavorsAsyncInvoker(ListResourceFlavorsRequest listResourceFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/resourceflavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceFlavorsRequest);
            return new AsyncInvoker<ListResourceFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询计划事件列表
        ///
        /// 查询计划事件列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduledEventsResponse> ListScheduledEventsAsync(ListScheduledEventsRequest listScheduledEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scheduled-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledEventsResponse>(response);
        }

        public AsyncInvoker<ListScheduledEventsResponse> ListScheduledEventsAsyncInvoker(ListScheduledEventsRequest listScheduledEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scheduled-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledEventsRequest);
            return new AsyncInvoker<ListScheduledEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledEventsResponse>);
        }
        
        /// <summary>
        /// 查询训练实验列表
        ///
        /// 查询训练实验列表接口用于获取ModelArts平台上用户已创建的训练实验的列表。
        /// 该接口适用于以下场景：当用户需要查看所有或部分训练实验的概要信息，如实验名称、描述、创建时间等时，可以通过此接口查询训练实验列表。使用该接口的前提条件是用户已登录ModelArts平台并具有查看训练实验的权限。查询操作完成后，系统将返回符合条件的训练实验列表。若用户无权限操作或查询条件不合法，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrainingExperimentsResponse> ListTrainingExperimentsAsync(ListTrainingExperimentsRequest listTrainingExperimentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrainingExperimentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrainingExperimentsResponse>(response);
        }

        public AsyncInvoker<ListTrainingExperimentsResponse> ListTrainingExperimentsAsyncInvoker(ListTrainingExperimentsRequest listTrainingExperimentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrainingExperimentsRequest);
            return new AsyncInvoker<ListTrainingExperimentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrainingExperimentsResponse>);
        }
        
        /// <summary>
        /// 获取训练作业事件列表
        ///
        /// 获取训练作业事件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrainingJobEventsResponse> ListTrainingJobEventsAsync(ListTrainingJobEventsRequest listTrainingJobEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrainingJobEventsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrainingJobEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrainingJobEventsResponse>(response);
        }

        public AsyncInvoker<ListTrainingJobEventsResponse> ListTrainingJobEventsAsyncInvoker(ListTrainingJobEventsRequest listTrainingJobEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrainingJobEventsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrainingJobEventsRequest);
            return new AsyncInvoker<ListTrainingJobEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrainingJobEventsResponse>);
        }
        
        /// <summary>
        /// 获取训练作业流程阶段信息列表
        ///
        /// 获取训练作业流程阶段信息列表接口用于获取ModelArts平台上指定训练作业的流程阶段信息列表。
        /// 该接口适用于以下场景：当用户需要查看特定训练作业的流程阶段记录时，可以通过此接口获取阶段信息列表。使用该接口的前提条件是用户已知训练作业ID，并具有查看阶段信息列表的权限。查询操作完成后，平台将返回包含训练作业的阶段信息记录。若训练作业ID不存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrainingJobStagesResponse> ListTrainingJobStagesAsync(ListTrainingJobStagesRequest listTrainingJobStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrainingJobStagesRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrainingJobStagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrainingJobStagesResponse>(response);
        }

        public AsyncInvoker<ListTrainingJobStagesResponse> ListTrainingJobStagesAsyncInvoker(ListTrainingJobStagesRequest listTrainingJobStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrainingJobStagesRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrainingJobStagesRequest);
            return new AsyncInvoker<ListTrainingJobStagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrainingJobStagesResponse>);
        }
        
        /// <summary>
        /// 查询训练作业的实例历史调度信息
        ///
        /// 查询训练作业调度的实例IP、节点IP等信息，可通过schedule_count参数查询具体的某一次调度的实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrainingJobTasksResponse> ListTrainingJobTasksAsync(ListTrainingJobTasksRequest listTrainingJobTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrainingJobTasksRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrainingJobTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listTrainingJobTasksResponse = JsonUtils.DeSerializeNull<ListTrainingJobTasksResponse>(response);
            listTrainingJobTasksResponse.Body = JsonUtils.DeSerializeList<TaskHistory>(response);
            return listTrainingJobTasksResponse;
        }

        public AsyncInvoker<ListTrainingJobTasksResponse> ListTrainingJobTasksAsyncInvoker(ListTrainingJobTasksRequest listTrainingJobTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrainingJobTasksRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrainingJobTasksRequest);
            return new AsyncInvoker<ListTrainingJobTasksResponse>(this, "GET", request, response =>
            {
                var listTrainingJobTasksResponse = JsonUtils.DeSerializeNull<ListTrainingJobTasksResponse>(response);
                listTrainingJobTasksResponse.Body = JsonUtils.DeSerializeList<TaskHistory>(response);
                return listTrainingJobTasksResponse;
            });
        }
        
        /// <summary>
        /// 查询训练作业列表
        ///
        /// 根据指定查询条件查询用户创建的训练作业列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrainingJobsResponse> ListTrainingJobsAsync(ListTrainingJobsRequest listTrainingJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-job-searches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTrainingJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListTrainingJobsResponse>(response);
        }

        public AsyncInvoker<ListTrainingJobsResponse> ListTrainingJobsAsyncInvoker(ListTrainingJobsRequest listTrainingJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-job-searches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTrainingJobsRequest);
            return new AsyncInvoker<ListTrainingJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTrainingJobsResponse>);
        }
        
        /// <summary>
        /// 查询资源池作业列表
        ///
        /// 查询专属资源池作业列表接口用于获取指定专属资源池中的作业信息列表。该接口适用于以下场景：当需要监控专属资源池的资源使用情况、查看作业状态或管理资源分配时，用户可通过此接口获取专属资源池中作业的详细信息。使用该接口的前提条件是专属资源池已存在且用户具有相应的权限（如管理员权限或资源管理权限）。调用接口成功后，系统将返回专属资源池中作业的列表，包括作业ID、名称、状态、资源使用情况等详细信息。若专属资源池不存在、用户无权限操作或资源池当前不可用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkloadsResponse> ListWorkloadsAsync(ListWorkloadsRequest listWorkloadsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWorkloadsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/workloads", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkloadsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWorkloadsResponse>(response);
        }

        public AsyncInvoker<ListWorkloadsResponse> ListWorkloadsAsyncInvoker(ListWorkloadsRequest listWorkloadsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWorkloadsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/workloads", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkloadsRequest);
            return new AsyncInvoker<ListWorkloadsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkloadsResponse>);
        }
        
        /// <summary>
        /// 查询工作空间列表
        ///
        /// 查询工作空间列表，响应消息体中包含详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkspaceResponse> ListWorkspaceAsync(ListWorkspaceRequest listWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkspaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWorkspaceResponse>(response);
        }

        public AsyncInvoker<ListWorkspaceResponse> ListWorkspaceAsyncInvoker(ListWorkspaceRequest listWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkspaceRequest);
            return new AsyncInvoker<ListWorkspaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkspaceResponse>);
        }
        
        /// <summary>
        /// 修改添加自定义URL申请
        ///
        /// 本接口用于修改添加内网自定义URL请求，适用于需要同时更新或者添加多个内网接入点的场景。调用此接口前，确保调用者具备相应的更新权限，提供需要更新的参数，如IP地址、VPC ID、子网ID等。指定的内网接入点将添加新的配置，新的配置将对相关服务生效。如果提供的内网接入点ID列表中包含无效或不存在的ID，接口将返回相应的异常信息，提示用户检查ID的有效性，如果提供的更新参数不符合格式要求（如IP地址格式不正确），接口将返回相应的异常信息，提示用户检查参数的有效性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyInferIntranetConnectionsResponse> ModifyInferIntranetConnectionsAsync(ModifyInferIntranetConnectionsRequest modifyInferIntranetConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyInferIntranetConnectionsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/{id}/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyInferIntranetConnectionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ModifyInferIntranetConnectionsResponse>(response);
        }

        public AsyncInvoker<ModifyInferIntranetConnectionsResponse> ModifyInferIntranetConnectionsAsyncInvoker(ModifyInferIntranetConnectionsRequest modifyInferIntranetConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyInferIntranetConnectionsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/{id}/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyInferIntranetConnectionsRequest);
            return new AsyncInvoker<ModifyInferIntranetConnectionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ModifyInferIntranetConnectionsResponse>);
        }
        
        /// <summary>
        /// 训练作业事件上报接口
        ///
        /// 训练事件上报给业务面
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NotifyTrainingJobInformationResponse> NotifyTrainingJobInformationAsync(NotifyTrainingJobInformationRequest notifyTrainingJobInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(notifyTrainingJobInformationRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(notifyTrainingJobInformationRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(notifyTrainingJobInformationRequest.ReportType, out var valueOfReportType)) urlParam.Add("report_type", valueOfReportType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/reports/{report_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", notifyTrainingJobInformationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<NotifyTrainingJobInformationResponse>(response);
        }

        public AsyncInvoker<NotifyTrainingJobInformationResponse> NotifyTrainingJobInformationAsyncInvoker(NotifyTrainingJobInformationRequest notifyTrainingJobInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(notifyTrainingJobInformationRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(notifyTrainingJobInformationRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(notifyTrainingJobInformationRequest.ReportType, out var valueOfReportType)) urlParam.Add("report_type", valueOfReportType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/reports/{report_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", notifyTrainingJobInformationRequest);
            return new AsyncInvoker<NotifyTrainingJobInformationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<NotifyTrainingJobInformationResponse>);
        }
        
        /// <summary>
        /// 更新网络资源
        ///
        /// 更新网络资源接口用于修改指定网络资源的配置信息。该接口适用于以下场景：当需要调整网络资源的属性、修复配置错误或优化资源设置时，用户可通过此接口更新指定网络资源的详细信息。使用该接口的前提条件是网络资源已存在且用户具有管理员权限。更新操作完成后，指定网络资源的配置信息将被成功修改，系统将反映最新的资源状态和属性。若指定的网络资源不存在、用户无权限操作或输入参数有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PatchNetworkResponse> PatchNetworkAsync(PatchNetworkRequest patchNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchNetworkRequest.NetworkName, out var valueOfNetworkName)) urlParam.Add("network_name", valueOfNetworkName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks/{network_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", patchNetworkRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<PatchNetworkResponse>(response);
        }

        public AsyncInvoker<PatchNetworkResponse> PatchNetworkAsyncInvoker(PatchNetworkRequest patchNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchNetworkRequest.NetworkName, out var valueOfNetworkName)) urlParam.Add("network_name", valueOfNetworkName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks/{network_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", patchNetworkRequest);
            return new AsyncInvoker<PatchNetworkResponse>(this, "PATCH", request, JsonUtils.DeSerialize<PatchNetworkResponse>);
        }
        
        /// <summary>
        /// 更新节点池
        ///
        /// 更新节点池接口用于修改指定节点池的配置信息。该接口适用于以下场景：当需要扩展节点池容量、调整节点规格、优化资源分配或修复节点池配置时，用户可通过此接口更新节点池的相关信息。使用该接口的前提条件是节点池已存在且用户具有管理员权限。更新操作完成后，节点池的配置将被更新，包括节点数量、规格、网络配置等参数。若节点池不存在、用户无权限操作或配置参数错误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PatchNodePoolResponse> PatchNodePoolAsync(PatchNodePoolRequest patchNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchNodePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(patchNodePoolRequest.NodepoolName, out var valueOfNodepoolName)) urlParam.Add("nodepool_name", valueOfNodepoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools/{nodepool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", patchNodePoolRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<PatchNodePoolResponse>(response);
        }

        public AsyncInvoker<PatchNodePoolResponse> PatchNodePoolAsyncInvoker(PatchNodePoolRequest patchNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchNodePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(patchNodePoolRequest.NodepoolName, out var valueOfNodepoolName)) urlParam.Add("nodepool_name", valueOfNodepoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools/{nodepool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", patchNodePoolRequest);
            return new AsyncInvoker<PatchNodePoolResponse>(this, "PATCH", request, JsonUtils.DeSerialize<PatchNodePoolResponse>);
        }
        
        /// <summary>
        /// 更新资源池
        ///
        /// 更新资源池接口用于修改指定资源池的配置和容量。该接口适用于以下场景：当资源池需要扩展容量、调整配置或优化性能时，用户可通过此接口更新资源池的相关信息。使用该接口的前提条件是资源池已存在且用户具有管理员权限。更新操作完成后，资源池的配置和容量将被更新，相关资源和配置也将被调整。若资源池不存在、用户无权限操作或资源池处于不可更新状态，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PatchPoolResponse> PatchPoolAsync(PatchPoolRequest patchPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchPoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", patchPoolRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<PatchPoolResponse>(response);
        }

        public AsyncInvoker<PatchPoolResponse> PatchPoolAsyncInvoker(PatchPoolRequest patchPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchPoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", patchPoolRequest);
            return new AsyncInvoker<PatchPoolResponse>(this, "PATCH", request, JsonUtils.DeSerialize<PatchPoolResponse>);
        }
        
        /// <summary>
        /// 注册自定义镜像
        ///
        /// 注册自定义镜像接口用于将用户自定义的镜像注册到ModelArts镜像管理。该接口适用于以下场景：当用户需要将自己的自定义镜像（如特定算法环境、工具链或配置）集成到ModelArts平台时，可通过此接口将镜像注册到镜像管理中以便后续使用。使用该接口的前提条件是用户具备ModelArts镜像管理权限，并且需要提供有效的镜像地址和符合要求的镜像格式。注册操作完成后，自定义镜像将被成功添加到ModelArts镜像列表中，用户可以在后续任务中选择使用该镜像。若镜像地址无效、镜像格式不符合要求或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest registerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RegisterImageResponse>(response);
        }

        public AsyncInvoker<RegisterImageResponse> RegisterImageAsyncInvoker(RegisterImageRequest registerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerImageRequest);
            return new AsyncInvoker<RegisterImageResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterImageResponse>);
        }
        
        /// <summary>
        /// 查询算法详情
        ///
        /// 根据算法id查询指定算法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAlgorithmByUuidResponse> ShowAlgorithmByUuidAsync(ShowAlgorithmByUuidRequest showAlgorithmByUuidRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlgorithmByUuidRequest.AlgorithmId, out var valueOfAlgorithmId)) urlParam.Add("algorithm_id", valueOfAlgorithmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms/{algorithm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlgorithmByUuidRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAlgorithmByUuidResponse>(response);
        }

        public AsyncInvoker<ShowAlgorithmByUuidResponse> ShowAlgorithmByUuidAsyncInvoker(ShowAlgorithmByUuidRequest showAlgorithmByUuidRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlgorithmByUuidRequest.AlgorithmId, out var valueOfAlgorithmId)) urlParam.Add("algorithm_id", valueOfAlgorithmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/algorithms/{algorithm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlgorithmByUuidRequest);
            return new AsyncInvoker<ShowAlgorithmByUuidResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlgorithmByUuidResponse>);
        }
        
        /// <summary>
        /// 查询授权模式
        ///
        /// 查询授权模式接口用于获取指定资源或功能的授权方式和权限配置信息。该接口适用于以下场景：当系统管理员需要查看资源的访问权限设置、开发者需要验证授权策略配置是否正确，或安全审计人员需要检查授权配置是否符合安全规范时，可通过此接口查询授权模式的详细信息。使用该接口的前提条件是用户具有查询权限且目标资源或功能的授权模式已配置。调用成功后，接口将返回授权模式的类型、规则及权限范围等详细信息。若用户无权限访问该接口，或目标资源的授权模式未配置，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuthmodeDetailResponse> ShowAuthmodeDetailAsync(ShowAuthmodeDetailRequest showAuthmodeDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/auth-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuthmodeDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuthmodeDetailResponse>(response);
        }

        public AsyncInvoker<ShowAuthmodeDetailResponse> ShowAuthmodeDetailAsyncInvoker(ShowAuthmodeDetailRequest showAuthmodeDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/auth-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuthmodeDetailRequest);
            return new AsyncInvoker<ShowAuthmodeDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuthmodeDetailResponse>);
        }
        
        /// <summary>
        /// 获取某个超参敏感度分析图像的路径
        ///
        /// 获取某个超参敏感度分析图像的保存路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoSearchParamAnalysisResultPathResponse> ShowAutoSearchParamAnalysisResultPathAsync(ShowAutoSearchParamAnalysisResultPathRequest showAutoSearchParamAnalysisResultPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchParamAnalysisResultPathRequest.ParameterName, out var valueOfParameterName)) urlParam.Add("parameter_name", valueOfParameterName);
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchParamAnalysisResultPathRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-parameter-analysis/{parameter_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchParamAnalysisResultPathRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoSearchParamAnalysisResultPathResponse>(response);
        }

        public AsyncInvoker<ShowAutoSearchParamAnalysisResultPathResponse> ShowAutoSearchParamAnalysisResultPathAsyncInvoker(ShowAutoSearchParamAnalysisResultPathRequest showAutoSearchParamAnalysisResultPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchParamAnalysisResultPathRequest.ParameterName, out var valueOfParameterName)) urlParam.Add("parameter_name", valueOfParameterName);
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchParamAnalysisResultPathRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-parameter-analysis/{parameter_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchParamAnalysisResultPathRequest);
            return new AsyncInvoker<ShowAutoSearchParamAnalysisResultPathResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoSearchParamAnalysisResultPathResponse>);
        }
        
        /// <summary>
        /// 获取超参敏感度分析结果
        ///
        /// 获取超参敏感度分析结果的汇总表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoSearchParamsAnalysisResponse> ShowAutoSearchParamsAnalysisAsync(ShowAutoSearchParamsAnalysisRequest showAutoSearchParamsAnalysisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchParamsAnalysisRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-parameter-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchParamsAnalysisRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoSearchParamsAnalysisResponse>(response);
        }

        public AsyncInvoker<ShowAutoSearchParamsAnalysisResponse> ShowAutoSearchParamsAnalysisAsyncInvoker(ShowAutoSearchParamsAnalysisRequest showAutoSearchParamsAnalysisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchParamsAnalysisRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-parameter-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchParamsAnalysisRequest);
            return new AsyncInvoker<ShowAutoSearchParamsAnalysisResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoSearchParamsAnalysisResponse>);
        }
        
        /// <summary>
        /// 查询超参搜索某个trial的结果
        ///
        /// 根据传入的trial_id，查询指定trial的搜索结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoSearchPerTrialResponse> ShowAutoSearchPerTrialAsync(ShowAutoSearchPerTrialRequest showAutoSearchPerTrialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchPerTrialRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchPerTrialRequest.TrialId, out var valueOfTrialId)) urlParam.Add("trial_id", valueOfTrialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-trials/{trial_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchPerTrialRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoSearchPerTrialResponse>(response);
        }

        public AsyncInvoker<ShowAutoSearchPerTrialResponse> ShowAutoSearchPerTrialAsyncInvoker(ShowAutoSearchPerTrialRequest showAutoSearchPerTrialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchPerTrialRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchPerTrialRequest.TrialId, out var valueOfTrialId)) urlParam.Add("trial_id", valueOfTrialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-trials/{trial_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchPerTrialRequest);
            return new AsyncInvoker<ShowAutoSearchPerTrialResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoSearchPerTrialResponse>);
        }
        
        /// <summary>
        /// 提前终止自动化搜索作业的某个trial
        ///
        /// 提前终止自动化搜索作业的某个trial。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoSearchTrialEarlyStopResponse> ShowAutoSearchTrialEarlyStopAsync(ShowAutoSearchTrialEarlyStopRequest showAutoSearchTrialEarlyStopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchTrialEarlyStopRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchTrialEarlyStopRequest.TrialId, out var valueOfTrialId)) urlParam.Add("trial_id", valueOfTrialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-trial-earlystop/{trial_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchTrialEarlyStopRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAutoSearchTrialEarlyStopResponse>(response);
        }

        public AsyncInvoker<ShowAutoSearchTrialEarlyStopResponse> ShowAutoSearchTrialEarlyStopAsyncInvoker(ShowAutoSearchTrialEarlyStopRequest showAutoSearchTrialEarlyStopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchTrialEarlyStopRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchTrialEarlyStopRequest.TrialId, out var valueOfTrialId)) urlParam.Add("trial_id", valueOfTrialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-trial-earlystop/{trial_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchTrialEarlyStopRequest);
            return new AsyncInvoker<ShowAutoSearchTrialEarlyStopResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAutoSearchTrialEarlyStopResponse>);
        }
        
        /// <summary>
        /// 查询超参搜索所有trial的结果
        ///
        /// 查询超参搜索所有trial的结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoSearchTrialsResponse> ShowAutoSearchTrialsAsync(ShowAutoSearchTrialsRequest showAutoSearchTrialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchTrialsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-trials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchTrialsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoSearchTrialsResponse>(response);
        }

        public AsyncInvoker<ShowAutoSearchTrialsResponse> ShowAutoSearchTrialsAsyncInvoker(ShowAutoSearchTrialsRequest showAutoSearchTrialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchTrialsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/autosearch-trials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchTrialsRequest);
            return new AsyncInvoker<ShowAutoSearchTrialsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoSearchTrialsResponse>);
        }
        
        /// <summary>
        /// 获取自动化搜索作业yaml模板的内容
        ///
        /// 获取自动化搜索作业yaml模板的内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoSearchYamlTemplateContentResponse> ShowAutoSearchYamlTemplateContentAsync(ShowAutoSearchYamlTemplateContentRequest showAutoSearchYamlTemplateContentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchYamlTemplateContentRequest.AlgorithmType, out var valueOfAlgorithmType)) urlParam.Add("algorithm_type", valueOfAlgorithmType);
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchYamlTemplateContentRequest.AlgorithmName, out var valueOfAlgorithmName)) urlParam.Add("algorithm_name", valueOfAlgorithmName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/autosearch/yaml-templates/{algorithm_type}/{algorithm_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchYamlTemplateContentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoSearchYamlTemplateContentResponse>(response);
        }

        public AsyncInvoker<ShowAutoSearchYamlTemplateContentResponse> ShowAutoSearchYamlTemplateContentAsyncInvoker(ShowAutoSearchYamlTemplateContentRequest showAutoSearchYamlTemplateContentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchYamlTemplateContentRequest.AlgorithmType, out var valueOfAlgorithmType)) urlParam.Add("algorithm_type", valueOfAlgorithmType);
            if (StringUtils.TryConvertToNonEmptyString(showAutoSearchYamlTemplateContentRequest.AlgorithmName, out var valueOfAlgorithmName)) urlParam.Add("algorithm_name", valueOfAlgorithmName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/autosearch/yaml-templates/{algorithm_type}/{algorithm_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchYamlTemplateContentRequest);
            return new AsyncInvoker<ShowAutoSearchYamlTemplateContentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoSearchYamlTemplateContentResponse>);
        }
        
        /// <summary>
        /// 获取自动化搜索作业yaml模板的信息
        ///
        /// 获取自动化搜索作业yaml模板的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoSearchYamlTemplatesInfoResponse> ShowAutoSearchYamlTemplatesInfoAsync(ShowAutoSearchYamlTemplatesInfoRequest showAutoSearchYamlTemplatesInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/autosearch/yaml-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchYamlTemplatesInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoSearchYamlTemplatesInfoResponse>(response);
        }

        public AsyncInvoker<ShowAutoSearchYamlTemplatesInfoResponse> ShowAutoSearchYamlTemplatesInfoAsyncInvoker(ShowAutoSearchYamlTemplatesInfoRequest showAutoSearchYamlTemplatesInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/autosearch/yaml-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoSearchYamlTemplatesInfoRequest);
            return new AsyncInvoker<ShowAutoSearchYamlTemplatesInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoSearchYamlTemplatesInfoResponse>);
        }
        
        /// <summary>
        /// 获取动态挂载存储实例详情
        ///
        /// 获取动态挂载OBS实例详情接口用于获取已挂载到运行中Notebook实例中的存储实例的详细信息。
        /// 
        /// 适用场景：用户需要查看Notebook实例中已挂载的存储实例的详细信息时，可通过此接口获取。使用该接口的前提条件是用户已登录系统并具有访问目标Notebook实例的权限。调用该接口后，系统将返回指定Notebook实例中挂载的存储实例的详细信息。若用户无权限访问指定实例，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDynamicStorageResponse> ShowDynamicStorageAsync(ShowDynamicStorageRequest showDynamicStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDynamicStorageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showDynamicStorageRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{instance_id}/storage/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDynamicStorageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDynamicStorageResponse>(response);
        }

        public AsyncInvoker<ShowDynamicStorageResponse> ShowDynamicStorageAsyncInvoker(ShowDynamicStorageRequest showDynamicStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDynamicStorageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showDynamicStorageRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{instance_id}/storage/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDynamicStorageRequest);
            return new AsyncInvoker<ShowDynamicStorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDynamicStorageResponse>);
        }
        
        /// <summary>
        /// 查询镜像详情
        ///
        /// 查询镜像详情接口用于查询镜像的详细信息。该接口适用于以下场景：当用户需要了解特定镜像的详细信息（如镜像名称、版本、创建时间、大小、状态等）或对镜像执行一些操作时，可通过此接口获取镜像的详细信息。使用该接口的前提条件是用户具备镜像管理权限，并且待查询镜像有效且存在。查询操作完成后，将返回镜像的详细信息，包括镜像ID、名称、版本、创建时间、大小以及状态等。若镜像不存在或用户无权限访问，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImageResponse> ShowImageAsync(ShowImageRequest showImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowImageResponse>(response);
        }

        public AsyncInvoker<ShowImageResponse> ShowImageAsyncInvoker(ShowImageRequest showImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageRequest);
            return new AsyncInvoker<ShowImageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageResponse>);
        }
        
        /// <summary>
        /// 查询服务部署详情
        ///
        /// 通过服务ID、部署ID查询对应的部署详情，调用者可以通过有效的服务ID、部署ID获取部署的名称、状态、服务实例、配置参数等详细信息。调用者需具有足够的权限，且输入的服务ID、部署ID必须有效。查询成功时返回部署详细信息，查询失败时返回特定的错误码和错误信息。若服务ID或者部署ID无效、版本号不存在或用户无权限，则返回400 Bad Request或403 Forbidden；
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInferDeploymentResponse> ShowInferDeploymentAsync(ShowInferDeploymentRequest showInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferDeploymentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInferDeploymentResponse>(response);
        }

        public AsyncInvoker<ShowInferDeploymentResponse> ShowInferDeploymentAsyncInvoker(ShowInferDeploymentRequest showInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferDeploymentRequest);
            return new AsyncInvoker<ShowInferDeploymentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInferDeploymentResponse>);
        }
        
        /// <summary>
        /// 查询在线服务部署版本详情
        ///
        /// 此接口用于获取指定服务部署版本的详细信息，适用于需要查看特定版本的详细配置和状态的场景，例如确认版本的功能、性能参数或发布历史。请求需包含有效的服务ID、部署ID及版本号。用户必须具有对目标服务部署的查看权限。请求成功后，返回该版本的详细信息，包括版本号、发布时间、配置参数和状态。若服务ID、部署ID无效、版本号不存在或用户无权限，则返回400 Bad Request或403 Forbidden；若服务部署无该版本信息，则返回404 Not Found。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInferDeploymentVersionResponse> ShowInferDeploymentVersionAsync(ShowInferDeploymentVersionRequest showInferDeploymentVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentVersionRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentVersionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/versions/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferDeploymentVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInferDeploymentVersionResponse>(response);
        }

        public AsyncInvoker<ShowInferDeploymentVersionResponse> ShowInferDeploymentVersionAsyncInvoker(ShowInferDeploymentVersionRequest showInferDeploymentVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentVersionRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentVersionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/versions/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferDeploymentVersionRequest);
            return new AsyncInvoker<ShowInferDeploymentVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInferDeploymentVersionResponse>);
        }
        
        /// <summary>
        /// 查询服务详情
        ///
        /// 通过服务ID查询对应的服务详情，调用者可以通过有效的服务ID获取服务的名称、状态、服务实例、配置参数等详细信息。调用者需具有足够的权限，且输入的服务ID必须有效。查询成功时返回服务详细信息，查询失败时返回特定的错误码和错误信息。若服务ID无效、版本号不存在或用户无权限，则返回400 Bad Request或403 Forbidden。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInferServiceResponse> ShowInferServiceAsync(ShowInferServiceRequest showInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferServiceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInferServiceResponse>(response);
        }

        public AsyncInvoker<ShowInferServiceResponse> ShowInferServiceAsyncInvoker(ShowInferServiceRequest showInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferServiceRequest);
            return new AsyncInvoker<ShowInferServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInferServiceResponse>);
        }
        
        /// <summary>
        /// 查询纳管资源池详情
        ///
        /// 该接口允许用户通过指定资源池的ID来查询纳管资源池的详细信息，包括实例ID、名称、Flavor规格、实例状态和实例可访问的URL。此功能适用于需要监控或管理云资源的用户，使用该接口前，用户需确保已拥有访问权限及正确的资源池ID。执行成功后，用户将获得所需的实例详情，可用于进一步的资源管理和配置。如果资源池ID无效或用户没有相应的访问权限，接口将返回错误信息，如404 Not Found或401 Unauthorized。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInferServiceClusterResponse> ShowInferServiceClusterAsync(ShowInferServiceClusterRequest showInferServiceClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferServiceClusterRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/clusters/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferServiceClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInferServiceClusterResponse>(response);
        }

        public AsyncInvoker<ShowInferServiceClusterResponse> ShowInferServiceClusterAsyncInvoker(ShowInferServiceClusterRequest showInferServiceClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferServiceClusterRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/clusters/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferServiceClusterRequest);
            return new AsyncInvoker<ShowInferServiceClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInferServiceClusterResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 该接口适用于需要获取资源（如模型、数据集、服务等）的标签信息的场景，例如在资源管理或分类中，用户可以通过查询标签来了解资源的用途、状态或其他属性。通过调用此接口，用户可以通过资源ID获取指定资源的所有标签列表。用户必须具有足够的权限，且目标资源需存在。查询成功后，返回资源的标签列表；若失败，返回具体的错误信息。常见异常包括权限验证错误、资源不存在错误和参数验证错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInferServiceTagsResponse> ShowInferServiceTagsAsync(ShowInferServiceTagsRequest showInferServiceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferServiceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferServiceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInferServiceTagsResponse>(response);
        }

        public AsyncInvoker<ShowInferServiceTagsResponse> ShowInferServiceTagsAsyncInvoker(ShowInferServiceTagsRequest showInferServiceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferServiceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-service-v2/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferServiceTagsRequest);
            return new AsyncInvoker<ShowInferServiceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInferServiceTagsResponse>);
        }
        
        /// <summary>
        /// 查询网络资源
        ///
        /// 查询网络资源接口用于获取指定网络资源的详情信息。该接口适用于以下场景：当用户需要查看特定网络资源的详细配置、状态或属性时，可通过此接口查询指定网络资源的详细信息。使用该接口的前提条件是用户具有相应的权限，并且指定的网络资源已存在于系统中。查询操作完成后，接口将返回指定网络资源的详细信息，包括资源ID、类型、状态、配置参数等。若指定的网络资源不存在、用户无权限操作或输入参数有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNetworkResponse> ShowNetworkAsync(ShowNetworkRequest showNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkRequest.NetworkName, out var valueOfNetworkName)) urlParam.Add("network_name", valueOfNetworkName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks/{network_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNetworkResponse>(response);
        }

        public AsyncInvoker<ShowNetworkResponse> ShowNetworkAsyncInvoker(ShowNetworkRequest showNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkRequest.NetworkName, out var valueOfNetworkName)) urlParam.Add("network_name", valueOfNetworkName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks/{network_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkRequest);
            return new AsyncInvoker<ShowNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNetworkResponse>);
        }
        
        /// <summary>
        /// 查询网络可用的IP
        ///
        /// 查询网络可用的IP接口用于查找指定网络中未被占用的IP地址。该接口适用于以下场景：在网络规划、资源分配或故障排查时，用户需要快速获取可用的IP地址信息。使用该接口的前提条件是用户具有访问目标网络的权限，并且需要提供有效的网络范围（如子网掩码或IP段）。查询完成后，接口将返回指定网络中未被占用的IP地址列表，用户可以根据结果进行IP地址的分配或进一步操作。若网络不可达、权限不足或网络范围有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNetworkAvailableIpResponse> ShowNetworkAvailableIpAsync(ShowNetworkAvailableIpRequest showNetworkAvailableIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkAvailableIpRequest.NetworkName, out var valueOfNetworkName)) urlParam.Add("network_name", valueOfNetworkName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks/{network_name}/network-ip-availabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkAvailableIpRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNetworkAvailableIpResponse>(response);
        }

        public AsyncInvoker<ShowNetworkAvailableIpResponse> ShowNetworkAvailableIpAsyncInvoker(ShowNetworkAvailableIpRequest showNetworkAvailableIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkAvailableIpRequest.NetworkName, out var valueOfNetworkName)) urlParam.Add("network_name", valueOfNetworkName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/networks/{network_name}/network-ip-availabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkAvailableIpRequest);
            return new AsyncInvoker<ShowNetworkAvailableIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNetworkAvailableIpResponse>);
        }
        
        /// <summary>
        /// 查询节点配置模板
        ///
        /// 查询节点配置模板接口用于获取指定节点配置模板的详细信息。该接口适用于以下场景：当用户需要查看节点配置模板的内容、管理节点配置或进行相关操作时，可通过此接口获取指定节点配置模板的详细信息。使用该接口的前提条件是节点配置模板已存在且用户具有相应的访问权限。调用该接口后，系统将返回指定节点配置模板的详细信息，包括模板名称、版本、配置参数及描述等。若节点配置模板不存在或用户无权限访问，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNodeConfigTemplateResponse> ShowNodeConfigTemplateAsync(ShowNodeConfigTemplateRequest showNodeConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodeConfigTemplateRequest.NodeconfigtemplateName, out var valueOfNodeconfigtemplateName)) urlParam.Add("nodeconfigtemplate_name", valueOfNodeconfigtemplateName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/nodeconfigtemplates/{nodeconfigtemplate_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeConfigTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNodeConfigTemplateResponse>(response);
        }

        public AsyncInvoker<ShowNodeConfigTemplateResponse> ShowNodeConfigTemplateAsyncInvoker(ShowNodeConfigTemplateRequest showNodeConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodeConfigTemplateRequest.NodeconfigtemplateName, out var valueOfNodeconfigtemplateName)) urlParam.Add("nodeconfigtemplate_name", valueOfNodeconfigtemplateName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/nodeconfigtemplates/{nodeconfigtemplate_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeConfigTemplateRequest);
            return new AsyncInvoker<ShowNodeConfigTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodeConfigTemplateResponse>);
        }
        
        /// <summary>
        /// 查询指定节点池详情
        ///
        /// 查询指定节点池详情接口用于获取指定节点池的详细信息。该接口适用于以下场景：当需要查看节点池的配置、状态、资源使用情况或管理节点池时，用户可通过此接口获取节点池的详细信息。使用该接口的前提条件是节点池已存在且用户具有访问该节点池的权限。调用接口成功后，系统将返回节点池的详细信息，包括节点池ID、名称、节点数量、状态、创建时间、配置参数等。若节点池不存在、用户无权限访问或节点池当前不可用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNodePoolResponse> ShowNodePoolAsync(ShowNodePoolRequest showNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolRequest.NodepoolName, out var valueOfNodepoolName)) urlParam.Add("nodepool_name", valueOfNodepoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools/{nodepool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNodePoolResponse>(response);
        }

        public AsyncInvoker<ShowNodePoolResponse> ShowNodePoolAsyncInvoker(ShowNodePoolRequest showNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolRequest.NodepoolName, out var valueOfNodepoolName)) urlParam.Add("nodepool_name", valueOfNodepoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodepools/{nodepool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            return new AsyncInvoker<ShowNodePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodePoolResponse>);
        }
        
        /// <summary>
        /// 查询训练作业指定任务的日志（OBS链接）
        ///
        /// 查询训练作业指定任务的日志（OBS临时链接，有效期5分钟），可全量查看或直接下载。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowObsUrlOfTrainingJobLogsResponse> ShowObsUrlOfTrainingJobLogsAsync(ShowObsUrlOfTrainingJobLogsRequest showObsUrlOfTrainingJobLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showObsUrlOfTrainingJobLogsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showObsUrlOfTrainingJobLogsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/logs/url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showObsUrlOfTrainingJobLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowObsUrlOfTrainingJobLogsResponse>(response);
        }

        public AsyncInvoker<ShowObsUrlOfTrainingJobLogsResponse> ShowObsUrlOfTrainingJobLogsAsyncInvoker(ShowObsUrlOfTrainingJobLogsRequest showObsUrlOfTrainingJobLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showObsUrlOfTrainingJobLogsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showObsUrlOfTrainingJobLogsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/logs/url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showObsUrlOfTrainingJobLogsRequest);
            return new AsyncInvoker<ShowObsUrlOfTrainingJobLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowObsUrlOfTrainingJobLogsResponse>);
        }
        
        /// <summary>
        /// 查询订单详情
        ///
        /// 查询订单详情接口用于获取指定订单的详细信息。该接口适用于以下场景：当需要查看订单的状态、金额、商品信息或处理订单相关问题时，用户可通过此接口获取订单的详细数据。使用该接口的前提条件是订单已存在且用户具有访问该订单的权限。调用接口成功后，系统将返回订单的详细信息，包括订单号、商品列表、金额、支付状态、下单时间等。若订单不存在、用户无权限访问或订单信息未正确配置，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrderResponse> ShowOrderAsync(ShowOrderRequest showOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrderRequest.OrderName, out var valueOfOrderName)) urlParam.Add("order_name", valueOfOrderName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/orders/{order_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrderRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrderResponse>(response);
        }

        public AsyncInvoker<ShowOrderResponse> ShowOrderAsyncInvoker(ShowOrderRequest showOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrderRequest.OrderName, out var valueOfOrderName)) urlParam.Add("order_name", valueOfOrderName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/orders/{order_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrderRequest);
            return new AsyncInvoker<ShowOrderResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrderResponse>);
        }
        
        /// <summary>
        /// 查询OS的配置参数
        ///
        /// 查询OS的配置参数接口用于获取ModelArts OS服务的配置参数，如网络网段、用户资源配额等。该接口适用于以下场景：当需要了解当前ModelArts OS服务的网络配置、资源分配情况或进行系统管理时，用户可通过此接口查询相关的配置参数。使用该接口的前提条件是用户具有访问ModelArts OS服务的权限，且服务处于正常运行状态。查询操作完成后，用户将获得指定的配置参数信息，便于进行后续的资源规划或系统优化。若用户无权限访问、服务不可用或请求参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOsConfigResponse> ShowOsConfigAsync(ShowOsConfigRequest showOsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/os-user-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOsConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOsConfigResponse>(response);
        }

        public AsyncInvoker<ShowOsConfigResponse> ShowOsConfigAsyncInvoker(ShowOsConfigRequest showOsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/os-user-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOsConfigRequest);
            return new AsyncInvoker<ShowOsConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOsConfigResponse>);
        }
        
        /// <summary>
        /// 查询OS的配额
        ///
        /// 查询OS配额接口用于获取ModelArts OS服务中部分资源的配额信息，如资源池配额、网络配额等。该接口适用于以下场景：当需要了解资源池或网络资源的使用限制、规划资源分配或监控资源使用情况时，用户可通过此接口获取相关配额信息。使用该接口的前提条件是ModelArts OS服务已部署且用户具有相应的权限（如管理员权限或资源管理权限）。调用接口成功后，系统将返回资源池配额、网络配额等详细信息，帮助用户更好地进行资源规划和管理。若用户无权限访问该接口、服务不可用或配额信息未配置，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOsQuotaResponse> ShowOsQuotaAsync(ShowOsQuotaRequest showOsQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOsQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOsQuotaResponse>(response);
        }

        public AsyncInvoker<ShowOsQuotaResponse> ShowOsQuotaAsyncInvoker(ShowOsQuotaRequest showOsQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOsQuotaRequest);
            return new AsyncInvoker<ShowOsQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOsQuotaResponse>);
        }
        
        /// <summary>
        /// 查询插件模板
        ///
        /// 查询插件模板接口用于获取指定插件模板的详细信息。该接口适用于以下场景：当需要了解特定插件模板的配置、功能或使用方式时，用户可通过此接口查询插件模板的详细信息。使用该接口的前提条件是插件模板已存在且用户具有访问权限。查询操作完成后，用户将获得指定插件模板的详细信息，包括模板的配置参数、功能描述等，便于后续的插件开发或配置管理。若插件模板不存在或用户无权限访问，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPluginTemplateResponse> ShowPluginTemplateAsync(ShowPluginTemplateRequest showPluginTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginTemplateRequest.PlugintemplateName, out var valueOfPlugintemplateName)) urlParam.Add("plugintemplate_name", valueOfPlugintemplateName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/plugintemplates/{plugintemplate_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPluginTemplateResponse>(response);
        }

        public AsyncInvoker<ShowPluginTemplateResponse> ShowPluginTemplateAsyncInvoker(ShowPluginTemplateRequest showPluginTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginTemplateRequest.PlugintemplateName, out var valueOfPlugintemplateName)) urlParam.Add("plugintemplate_name", valueOfPlugintemplateName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/plugintemplates/{plugintemplate_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginTemplateRequest);
            return new AsyncInvoker<ShowPluginTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPluginTemplateResponse>);
        }
        
        /// <summary>
        /// 查询资源池
        ///
        /// 查询资源池信息接口用于获取指定资源池的详细信息。该接口适用于以下场景：当用户需要查看特定资源池的详细配置、状态、资源使用情况或进行资源管理时，可通过此接口查询指定资源池的详细信息。使用该接口的前提条件是用户具有相应的权限，并且指定的资源池已存在于系统中。查询操作完成后，接口将返回资源池的详细信息，包括资源池ID、名称、类型、状态、资源配额、利用率等。若指定的资源池不存在、用户无权限操作或输入参数有误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolResponse> ShowPoolAsync(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }

        public AsyncInvoker<ShowPoolResponse> ShowPoolAsyncInvoker(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            return new AsyncInvoker<ShowPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolResponse>);
        }
        
        /// <summary>
        /// 资源池监控
        ///
        /// 资源池监控接口用于获取指定资源池的实时或历史监控信息。该接口适用于以下场景：当需要实时查看资源池的资源使用情况、性能状态或历史数据时，用户可通过此接口获取资源池的监控数据。使用该接口的前提条件是资源池已存在且用户具有管理员权限。调用接口成功后，系统将返回资源池的监控信息，包括资源使用率、性能指标及历史趋势等数据。若资源池不存在、用户无权限操作或资源池当前不可用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolMonitorResponse> ShowPoolMonitorAsync(ShowPoolMonitorRequest showPoolMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolMonitorRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolMonitorRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolMonitorResponse>(response);
        }

        public AsyncInvoker<ShowPoolMonitorResponse> ShowPoolMonitorAsyncInvoker(ShowPoolMonitorRequest showPoolMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolMonitorRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolMonitorRequest);
            return new AsyncInvoker<ShowPoolMonitorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolMonitorResponse>);
        }
        
        /// <summary>
        /// 查询资源池单个节点详情
        ///
        /// 查询资源池中的单个节点接口用于获取指定资源池内单个节点的详细信息。该接口适用于以下场景：当用户需要了解节点资源分配、详细信息时，可通过此接口获取节点的类型、状态、配置参数及关联服务等信息。使用该接口的前提条件是目标资源池已存在且用户具备查看权限，同时需提供有效的资源池标识符作为输入参数。接口调用后，系统将返回资源池中单个节点数据；若资源池不存在、用户权限不足或输入参数无效，接口将返回对应的错误信息（如404未找到资源池或403权限拒绝）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolNodeResponse> ShowPoolNodeAsync(ShowPoolNodeRequest showPoolNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolNodeRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(showPoolNodeRequest.NodeName, out var valueOfNodeName)) urlParam.Add("node_name", valueOfNodeName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/{node_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolNodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolNodeResponse>(response);
        }

        public AsyncInvoker<ShowPoolNodeResponse> ShowPoolNodeAsyncInvoker(ShowPoolNodeRequest showPoolNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolNodeRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            if (StringUtils.TryConvertToNonEmptyString(showPoolNodeRequest.NodeName, out var valueOfNodeName)) urlParam.Add("node_name", valueOfNodeName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/nodes/{node_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolNodeRequest);
            return new AsyncInvoker<ShowPoolNodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolNodeResponse>);
        }
        
        /// <summary>
        /// 查询资源池节点自定义配置
        ///
        /// 查询资源池节点自定义配置接口用于获取指定资源池节点的自定义配置信息。该接口适用于以下场景：当需要查看资源池节点的详细配置、优化资源分配或管理节点资源时，用户可通过此接口获取节点的自定义配置数据。使用该接口的前提条件是资源池节点已存在且用户具有访问该节点的权限。调用接口成功后，系统将返回资源池节点的自定义配置信息，包括硬件规格、软件环境、网络设置等详细参数。若资源池节点不存在、用户无权限访问或节点配置信息未正确配置，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolNodeConfigResponse> ShowPoolNodeConfigAsync(ShowPoolNodeConfigRequest showPoolNodeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolNodeConfigRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/node-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolNodeConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolNodeConfigResponse>(response);
        }

        public AsyncInvoker<ShowPoolNodeConfigResponse> ShowPoolNodeConfigAsyncInvoker(ShowPoolNodeConfigRequest showPoolNodeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolNodeConfigRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/node-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolNodeConfigRequest);
            return new AsyncInvoker<ShowPoolNodeConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolNodeConfigResponse>);
        }
        
        /// <summary>
        /// 查询资源池节点自定义配置模板
        ///
        /// 查询资源池节点自定义配置模板接口用于获取节点配置模板的结构定义与参数规范。该接口适用于以下场景：当需要了解节点自定义配置的模板结构（如参数字段、校验规则、示例值）、验证配置模板是否符合规范或进行配置模板选型时，用户可通过此接口获取模板的元数据（如参数说明、类型限制、依赖关系等）。使用该接口的前提条件是目标配置模板必须已注册至系统且处于可访问状态，调用者需具备模板查看权限，且系统配置管理服务正常运行。查询操作完成后，系统将返回模板的完整定义信息（如参数列表、版本号、更新时间等），且不会对模板内容或节点配置产生影响。若模板未注册、用户权限不足或系统服务异常，接口将返回对应的错误信息（如\&quot;404 Not Found\&quot;、\&quot;403 Forbidden\&quot;或\&quot;503 Service Unavailable\&quot;）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolNodeConfigTemplateResponse> ShowPoolNodeConfigTemplateAsync(ShowPoolNodeConfigTemplateRequest showPoolNodeConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolNodeConfigTemplateRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/node-config-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolNodeConfigTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolNodeConfigTemplateResponse>(response);
        }

        public AsyncInvoker<ShowPoolNodeConfigTemplateResponse> ShowPoolNodeConfigTemplateAsyncInvoker(ShowPoolNodeConfigTemplateRequest showPoolNodeConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolNodeConfigTemplateRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/pools/{pool_name}/node-config-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolNodeConfigTemplateRequest);
            return new AsyncInvoker<ShowPoolNodeConfigTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolNodeConfigTemplateResponse>);
        }
        
        /// <summary>
        /// 查询资源实时利用率
        ///
        /// 查询资源实时利用率接口用于获取当前项目下所有资源池的实时利用率信息。该接口适用于以下场景：当用户需要监控资源使用情况、进行资源优化、容量规划或故障排查时，可通过此接口查询资源池的实时利用率，包括CPU、内存、存储等资源的使用情况。使用该接口的前提条件是用户具有访问该项目的权限，并且资源池已存在且处于运行状态。查询操作完成后，接口将返回资源池的实时利用率数据，包含利用率百分比、资源类型、时间戳等详细信息。若用户无权限、资源池不存在或系统无法获取实时数据，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolRuntimeMetricsResponse> ShowPoolRuntimeMetricsAsync(ShowPoolRuntimeMetricsRequest showPoolRuntimeMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/runtime/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRuntimeMetricsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolRuntimeMetricsResponse>(response);
        }

        public AsyncInvoker<ShowPoolRuntimeMetricsResponse> ShowPoolRuntimeMetricsAsyncInvoker(ShowPoolRuntimeMetricsRequest showPoolRuntimeMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/runtime/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRuntimeMetricsRequest);
            return new AsyncInvoker<ShowPoolRuntimeMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolRuntimeMetricsResponse>);
        }
        
        /// <summary>
        /// 资源池统计
        ///
        /// 资源池统计接口用于获取指定资源池的统计信息。该接口适用于以下场景：当需要了解资源池的资源使用情况、分配情况或利用率时，用户可通过此接口获取资源池的统计数据。使用该接口的前提条件是资源池已存在且用户具有管理员权限。调用接口成功后，系统将返回资源池的统计信息，包括资源使用总量、已分配量、利用率及资源分配趋势等数据。若资源池不存在、用户无权限操作或资源池当前不可用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolStatisticsResponse> ShowPoolStatisticsAsync(ShowPoolStatisticsRequest showPoolStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowPoolStatisticsResponse> ShowPoolStatisticsAsyncInvoker(ShowPoolStatisticsRequest showPoolStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolStatisticsRequest);
            return new AsyncInvoker<ShowPoolStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询资源池上的标签
        ///
        /// 查询资源池的标签接口用于获取指定资源池的标签信息。该接口适用于以下场景：当需要查看、管理或统计特定资源池的标签信息时，用户可通过此接口获取资源池的标签数据。使用该接口的前提条件是资源池已存在且用户具有访问该资源池的权限。调用接口成功后，系统将返回指定资源池的标签信息，包括标签键和标签值。若资源池不存在、用户无权限访问或资源池未配置标签，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolTagsResponse> ShowPoolTagsAsync(ShowPoolTagsRequest showPoolTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolTagsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/pools/{pool_name}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolTagsResponse>(response);
        }

        public AsyncInvoker<ShowPoolTagsResponse> ShowPoolTagsAsyncInvoker(ShowPoolTagsRequest showPoolTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolTagsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/pools/{pool_name}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolTagsRequest);
            return new AsyncInvoker<ShowPoolTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolTagsResponse>);
        }
        
        /// <summary>
        /// 查询训练作业镜像保存任务
        ///
        /// 查询训练作业镜像保存任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSaveImageJobResponse> ShowSaveImageJobAsync(ShowSaveImageJobRequest showSaveImageJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSaveImageJobRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showSaveImageJobRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/save-image-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSaveImageJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSaveImageJobResponse>(response);
        }

        public AsyncInvoker<ShowSaveImageJobResponse> ShowSaveImageJobAsyncInvoker(ShowSaveImageJobRequest showSaveImageJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSaveImageJobRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showSaveImageJobRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/save-image-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSaveImageJobRequest);
            return new AsyncInvoker<ShowSaveImageJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSaveImageJobResponse>);
        }
        
        /// <summary>
        /// 获取支持的超参搜索算法
        ///
        /// 获取支持的超参搜索算法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSearchAlgorithmsResponse> ShowSearchAlgorithmsAsync(ShowSearchAlgorithmsRequest showSearchAlgorithmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/search-algorithms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSearchAlgorithmsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSearchAlgorithmsResponse>(response);
        }

        public AsyncInvoker<ShowSearchAlgorithmsResponse> ShowSearchAlgorithmsAsyncInvoker(ShowSearchAlgorithmsRequest showSearchAlgorithmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/search-algorithms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSearchAlgorithmsRequest);
            return new AsyncInvoker<ShowSearchAlgorithmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSearchAlgorithmsResponse>);
        }
        
        /// <summary>
        /// 查询训练作业标签
        ///
        /// 查询训练作业标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainJobTagsResponse> ShowTrainJobTagsAsync(ShowTrainJobTagsRequest showTrainJobTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainJobTagsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-training-job/{training_job_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainJobTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainJobTagsResponse>(response);
        }

        public AsyncInvoker<ShowTrainJobTagsResponse> ShowTrainJobTagsAsyncInvoker(ShowTrainJobTagsRequest showTrainJobTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainJobTagsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/modelarts-training-job/{training_job_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainJobTagsRequest);
            return new AsyncInvoker<ShowTrainJobTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainJobTagsResponse>);
        }
        
        /// <summary>
        /// 查询训练实验详情
        ///
        /// 查询训练实验详情接口用于获取指定训练实验的详细信息。
        /// 该接口适用于以下场景：当用户需要查看训练实验的实验名称、描述、创建时间等详细信息时，可以通过此接口获取。使用该接口的前提条件是训练实验已存在且用户具有查看该实验的权限。查询操作完成后，将返回训练实验的详细信息，包括但不限于实验ID、名称、描述、创建时间等。若训练实验不存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainingExperimentDetailsResponse> ShowTrainingExperimentDetailsAsync(ShowTrainingExperimentDetailsRequest showTrainingExperimentDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainingExperimentDetailsRequest.ExperimentId, out var valueOfExperimentId)) urlParam.Add("experiment_id", valueOfExperimentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments/{experiment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingExperimentDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingExperimentDetailsResponse>(response);
        }

        public AsyncInvoker<ShowTrainingExperimentDetailsResponse> ShowTrainingExperimentDetailsAsyncInvoker(ShowTrainingExperimentDetailsRequest showTrainingExperimentDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainingExperimentDetailsRequest.ExperimentId, out var valueOfExperimentId)) urlParam.Add("experiment_id", valueOfExperimentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-experiments/{experiment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingExperimentDetailsRequest);
            return new AsyncInvoker<ShowTrainingExperimentDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingExperimentDetailsResponse>);
        }
        
        /// <summary>
        /// 查询训练作业详情
        ///
        /// 查询训练作业详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainingJobDetailsResponse> ShowTrainingJobDetailsAsync(ShowTrainingJobDetailsRequest showTrainingJobDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobDetailsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingJobDetailsResponse>(response);
        }

        public AsyncInvoker<ShowTrainingJobDetailsResponse> ShowTrainingJobDetailsAsyncInvoker(ShowTrainingJobDetailsRequest showTrainingJobDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobDetailsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobDetailsRequest);
            return new AsyncInvoker<ShowTrainingJobDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingJobDetailsResponse>);
        }
        
        /// <summary>
        /// 获取训练作业支持的AI预置框架
        ///
        /// 获取训练作业支持的AI预置框架。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainingJobEnginesResponse> ShowTrainingJobEnginesAsync(ShowTrainingJobEnginesRequest showTrainingJobEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-job-engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobEnginesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingJobEnginesResponse>(response);
        }

        public AsyncInvoker<ShowTrainingJobEnginesResponse> ShowTrainingJobEnginesAsyncInvoker(ShowTrainingJobEnginesRequest showTrainingJobEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-job-engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobEnginesRequest);
            return new AsyncInvoker<ShowTrainingJobEnginesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingJobEnginesResponse>);
        }
        
        /// <summary>
        /// 获取训练作业支持的公共规格
        ///
        /// 获取训练作业支持的公共规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainingJobFlavorsResponse> ShowTrainingJobFlavorsAsync(ShowTrainingJobFlavorsRequest showTrainingJobFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-job-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingJobFlavorsResponse>(response);
        }

        public AsyncInvoker<ShowTrainingJobFlavorsResponse> ShowTrainingJobFlavorsAsyncInvoker(ShowTrainingJobFlavorsRequest showTrainingJobFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-job-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobFlavorsRequest);
            return new AsyncInvoker<ShowTrainingJobFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingJobFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询训练作业指定任务的日志（预览）
        ///
        /// 查询训练作业指定任务的日志（预览）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainingJobLogsPreviewResponse> ShowTrainingJobLogsPreviewAsync(ShowTrainingJobLogsPreviewRequest showTrainingJobLogsPreviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobLogsPreviewRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobLogsPreviewRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/logs/preview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobLogsPreviewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingJobLogsPreviewResponse>(response);
        }

        public AsyncInvoker<ShowTrainingJobLogsPreviewResponse> ShowTrainingJobLogsPreviewAsyncInvoker(ShowTrainingJobLogsPreviewRequest showTrainingJobLogsPreviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobLogsPreviewRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobLogsPreviewRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/tasks/{task_id}/logs/preview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobLogsPreviewRequest);
            return new AsyncInvoker<ShowTrainingJobLogsPreviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingJobLogsPreviewResponse>);
        }
        
        /// <summary>
        /// 查询训练作业指定任务的运行指标
        ///
        /// 查询训练作业指定任务的运行指标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainingJobMetricsResponse> ShowTrainingJobMetricsAsync(ShowTrainingJobMetricsRequest showTrainingJobMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobMetricsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobMetricsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/metrics/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobMetricsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingJobMetricsResponse>(response);
        }

        public AsyncInvoker<ShowTrainingJobMetricsResponse> ShowTrainingJobMetricsAsyncInvoker(ShowTrainingJobMetricsRequest showTrainingJobMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobMetricsRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            if (StringUtils.TryConvertToNonEmptyString(showTrainingJobMetricsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/metrics/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingJobMetricsRequest);
            return new AsyncInvoker<ShowTrainingJobMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingJobMetricsResponse>);
        }
        
        /// <summary>
        /// 获取训练配额
        ///
        /// 获取训练配额接口用于查询用户在ModelArts服务中的训练资源配额信息。
        /// 该接口适用于以下场景：当用户需要了解当前可用的训练资源配额，以便合理规划和管理训练任务时，可以通过此接口获取配额详情。使用该接口的前提条件是用户已登录并具有查看配额的权限。响应消息体中包含用户已创建的训练作业个数、剩余可创建个数等。若用户无权限或配额信息为空，接口将返回相应的错误信息或空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainingQuotasResponse> ShowTrainingQuotasAsync(ShowTrainingQuotasRequest showTrainingQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingQuotasResponse>(response);
        }

        public AsyncInvoker<ShowTrainingQuotasResponse> ShowTrainingQuotasAsyncInvoker(ShowTrainingQuotasRequest showTrainingQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingQuotasRequest);
            return new AsyncInvoker<ShowTrainingQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingQuotasResponse>);
        }
        
        /// <summary>
        /// 查询专属资源池作业统计信息
        ///
        /// 查询专属资源池作业统计信息接口用于获取指定专属资源池中作业的统计信息。该接口适用于以下场景：当需要了解专属资源池中作业的整体运行情况、资源使用效率或作业状态分布时，用户可通过此接口获取统计信息。使用该接口的前提条件是专属资源池已存在且用户具有相应的权限（如管理员权限或资源管理权限）。调用接口成功后，系统将返回专属资源池中作业的统计信息，包括作业总数、运行中作业数、完成作业数、资源使用率等数据。若专属资源池不存在、用户无权限操作或资源池当前不可用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkloadStatisticsResponse> ShowWorkloadStatisticsAsync(ShowWorkloadStatisticsRequest showWorkloadStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkloadStatisticsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/pools/{pool_name}/workloads", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkloadStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkloadStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowWorkloadStatisticsResponse> ShowWorkloadStatisticsAsyncInvoker(ShowWorkloadStatisticsRequest showWorkloadStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkloadStatisticsRequest.PoolName, out var valueOfPoolName)) urlParam.Add("pool_name", valueOfPoolName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/pools/{pool_name}/workloads", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkloadStatisticsRequest);
            return new AsyncInvoker<ShowWorkloadStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkloadStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询工作空间详情
        ///
        /// 查询工作空间详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkspaceResponse> ShowWorkspaceAsync(ShowWorkspaceRequest showWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkspaceRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkspaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkspaceResponse>(response);
        }

        public AsyncInvoker<ShowWorkspaceResponse> ShowWorkspaceAsyncInvoker(ShowWorkspaceRequest showWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkspaceRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkspaceRequest);
            return new AsyncInvoker<ShowWorkspaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkspaceResponse>);
        }
        
        /// <summary>
        /// 查询工作空间配额
        ///
        /// 查询工作空间配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkspaceQuotasResponse> ShowWorkspaceQuotasAsync(ShowWorkspaceQuotasRequest showWorkspaceQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkspaceQuotasRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkspaceQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkspaceQuotasResponse>(response);
        }

        public AsyncInvoker<ShowWorkspaceQuotasResponse> ShowWorkspaceQuotasAsyncInvoker(ShowWorkspaceQuotasRequest showWorkspaceQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkspaceQuotasRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkspaceQuotasRequest);
            return new AsyncInvoker<ShowWorkspaceQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkspaceQuotasResponse>);
        }
        
        /// <summary>
        /// 启动服务部署
        ///
        /// 使部署从“停止”或“失败”状态进入“部署中”状态，适用于用户需要重新启动已停止或启动失败的部署的情况。调用此接口前，部署状态必须为“停止”或“失败”，且用户需具有启动部署的权限。调用成功后，部署状态将变为“部署中”，系统将开始执行部署流程，包括资源准备、配置加载等。如果部署当前状态不是“停止”或“失败”，或用户没有启动部署的权限，调用将返回错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartInferDeploymentResponse> StartInferDeploymentAsync(StartInferDeploymentRequest startInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(startInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInferDeploymentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartInferDeploymentResponse>(response);
        }

        public AsyncInvoker<StartInferDeploymentResponse> StartInferDeploymentAsyncInvoker(StartInferDeploymentRequest startInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(startInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInferDeploymentRequest);
            return new AsyncInvoker<StartInferDeploymentResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInferDeploymentResponse>);
        }
        
        /// <summary>
        /// 启动服务
        ///
        /// 使服务从\&quot;停止\&quot;或\&quot;失败\&quot;状态进入\&quot;部署中\&quot;状态，适用于用户需要重新启动已停止或启动失败的服务的情况。调用此接口前，服务状态必须为\&quot;停止\&quot;或\&quot;失败\&quot;，且用户需具有启动服务的权限。调用成功后，服务状态将变为\&quot;部署中\&quot;，系统将开始执行部署流程，包括资源准备、配置加载等。如果服务当前状态不是\&quot;停止\&quot;或\&quot;失败\&quot;，或用户没有启动服务的权限，调用将返回错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartInferServiceResponse> StartInferServiceAsync(StartInferServiceRequest startInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInferServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInferServiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartInferServiceResponse>(response);
        }

        public AsyncInvoker<StartInferServiceResponse> StartInferServiceAsyncInvoker(StartInferServiceRequest startInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInferServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInferServiceRequest);
            return new AsyncInvoker<StartInferServiceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInferServiceResponse>);
        }
        
        /// <summary>
        /// 停止在线服务部署
        ///
        /// 停止在线部署功能允许用户在特定状态下主动终止正在运行或处于其他可操作状态的部署实例。该功能适用于需要维护、升级或检测到异常的服务场景，支持在服务处于\&quot;运行中\&quot;、\&quot;部署中\&quot;、\&quot;失败\&quot;或\&quot;告警\&quot;状态时执行停止操作。使用此功能前，请确保部署实例处于可停止状态，并具备相应的API调用权限。成功执行后，部署将进入停止状态，释放相关资源并停止处理新的请求。若部署不在允许停止的状态、调用权限不足或系统内部出现错误，将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopInferDeploymentResponse> StopInferDeploymentAsync(StopInferDeploymentRequest stopInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(stopInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInferDeploymentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopInferDeploymentResponse>(response);
        }

        public AsyncInvoker<StopInferDeploymentResponse> StopInferDeploymentAsyncInvoker(StopInferDeploymentRequest stopInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(stopInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInferDeploymentRequest);
            return new AsyncInvoker<StopInferDeploymentResponse>(this, "POST", request, JsonUtils.DeSerialize<StopInferDeploymentResponse>);
        }
        
        /// <summary>
        /// 停止服务
        ///
        /// 使服务从\&quot;运行中\&quot;状态进入\&quot;停止中\&quot;最终变为\&quot;停止\&quot;状态，适用于用户需要停止正在运行的服务以节省资源成本的场景。用户需具有停止服务的权限。调用成功后，服务状态将变为\&quot;停止中\&quot;，系统将开始执行停止流程，包括释放资源、保存状态等。如果用户没有停止服务的权限，调用将返回错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopInferServiceResponse> StopInferServiceAsync(StopInferServiceRequest stopInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInferServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInferServiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopInferServiceResponse>(response);
        }

        public AsyncInvoker<StopInferServiceResponse> StopInferServiceAsyncInvoker(StopInferServiceRequest stopInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInferServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInferServiceRequest);
            return new AsyncInvoker<StopInferServiceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopInferServiceResponse>);
        }
        
        /// <summary>
        /// 终止训练作业
        ///
        /// 终止训练作业，只可终止创建中、等待中、运行中的作业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopTrainingJobResponse> StopTrainingJobAsync(StopTrainingJobRequest stopTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopTrainingJobRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopTrainingJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopTrainingJobResponse>(response);
        }

        public AsyncInvoker<StopTrainingJobResponse> StopTrainingJobAsyncInvoker(StopTrainingJobRequest stopTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopTrainingJobRequest.TrainingJobId, out var valueOfTrainingJobId)) urlParam.Add("training_job_id", valueOfTrainingJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/training-jobs/{training_job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopTrainingJobRequest);
            return new AsyncInvoker<StopTrainingJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StopTrainingJobResponse>);
        }
        
        /// <summary>
        /// 切换部署到指定版本
        ///
        /// 此接口用于将部署切换到指定版本，适用于需要在不同版本间进行切换以测试或回滚的场景。请求需包含有效的服务ID、部署ID及目标版本号，版本号必须是已发布的有效版本。用户必须具有对目标服务部署的管理权限，并且部署处于运行状态。切换成功后，部署将立即使用新的版本。若服务ID无效、部署ID无效、版本号不存在或用户无权限，则返回400 Bad Request或403 Forbidden；若部署状态不允许切换，则返回400 Bad Request。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchInferDeploymentVersionResponse> SwitchInferDeploymentVersionAsync(SwitchInferDeploymentVersionRequest switchInferDeploymentVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchInferDeploymentVersionRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(switchInferDeploymentVersionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            if (StringUtils.TryConvertToNonEmptyString(switchInferDeploymentVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/versions/{version}/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchInferDeploymentVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchInferDeploymentVersionResponse>(response);
        }

        public AsyncInvoker<SwitchInferDeploymentVersionResponse> SwitchInferDeploymentVersionAsyncInvoker(SwitchInferDeploymentVersionRequest switchInferDeploymentVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchInferDeploymentVersionRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(switchInferDeploymentVersionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            if (StringUtils.TryConvertToNonEmptyString(switchInferDeploymentVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/versions/{version}/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchInferDeploymentVersionRequest);
            return new AsyncInvoker<SwitchInferDeploymentVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchInferDeploymentVersionResponse>);
        }
        
        /// <summary>
        /// 同步镜像状态
        ///
        /// 同步镜像状态接口用于修正镜像状态的异常情况。该接口适用于以下场景：当镜像状态因误操作、网络问题或系统故障等原因出现异常时，用户可通过此接口同步镜像的最新状态。使用该接口的前提条件是镜像已存在且用户具有相应的操作权限。同步操作完成后，镜像的状态将被更新为最新的正确状态，相关资源和配置也将被同步。若镜像不存在、用户无权限操作或同步过程中出现错误，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SyncImageResponse> SyncImageAsync(SyncImageRequest syncImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncImageRequest.ImageId, out var valueOfImageId)) urlParam.Add("image_id", valueOfImageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/{image_id}/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SyncImageResponse>(response);
        }

        public AsyncInvoker<SyncImageResponse> SyncImageAsyncInvoker(SyncImageRequest syncImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncImageRequest.ImageId, out var valueOfImageId)) urlParam.Add("image_id", valueOfImageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/{image_id}/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncImageRequest);
            return new AsyncInvoker<SyncImageResponse>(this, "POST", request, JsonUtils.DeSerialize<SyncImageResponse>);
        }
        
        /// <summary>
        /// 解绑应用密钥
        ///
        /// 本接口用于将已绑定的apikey从指定服务中解绑，适用于需要撤销某个apikey对特定服务的访问权限的场景。调用此接口前，确保已获取到需要解绑的apikey，并确认该apikey当前绑定在指定服务上。解绑成功后，该apikey将不再对指定服务生效，但仍可继续用于其他服务。如果尝试解绑不存在或未绑定到指定服务的apikey，将返回相应的异常信息，提示用户检查apikey的有效性和绑定状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnbindInferApiKeyResponse> UnbindInferApiKeyAsync(UnbindInferApiKeyRequest unbindInferApiKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindInferApiKeyRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(unbindInferApiKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/api-keys/{key_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindInferApiKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UnbindInferApiKeyResponse>(response);
        }

        public AsyncInvoker<UnbindInferApiKeyResponse> UnbindInferApiKeyAsyncInvoker(UnbindInferApiKeyRequest unbindInferApiKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindInferApiKeyRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(unbindInferApiKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/api-keys/{key_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindInferApiKeyRequest);
            return new AsyncInvoker<UnbindInferApiKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<UnbindInferApiKeyResponse>);
        }
        
        /// <summary>
        /// 更新授权模式
        ///
        /// 更新授权模式接口用于修改指定资源或功能的授权方式和权限配置信息。该接口适用于以下场景：当系统管理员需要调整资源的访问权限、开发者需要更新授权策略以适应新的业务需求，或安全审计人员需要修改授权配置以符合新的安全规范时，可通过此接口更新授权模式的详细信息。使用该接口的前提条件是用户具有更新权限且目标资源或功能的授权模式已存在。调用成功后，接口将更新目标资源的授权模式，并返回更新后的授权模式信息。若用户无权限访问该接口，或目标资源的授权模式不存在，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuthModeResponse> UpdateAuthModeAsync(UpdateAuthModeRequest updateAuthModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/auth-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuthModeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuthModeResponse>(response);
        }

        public AsyncInvoker<UpdateAuthModeResponse> UpdateAuthModeAsyncInvoker(UpdateAuthModeRequest updateAuthModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/auth-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuthModeRequest);
            return new AsyncInvoker<UpdateAuthModeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuthModeResponse>);
        }
        
        /// <summary>
        /// 更新镜像组
        ///
        /// 更新镜像组接口用于更新镜像组的标签及说明信息。该接口适用于以下场景：当镜像说明需要修改，或者镜像的标签需要修改时，用户可通过此接口修改。使用该接口的前提条件是镜像组已存在且用户具有更新权限。更新操作完成后，镜像组对应的配置文件会。若镜像组不存在、用户无权限操作或镜像正在被使用，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateImageGroupResponse> UpdateImageGroupAsync(UpdateImageGroupRequest updateImageGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateImageGroupRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/group/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateImageGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateImageGroupResponse>(response);
        }

        public AsyncInvoker<UpdateImageGroupResponse> UpdateImageGroupAsyncInvoker(UpdateImageGroupRequest updateImageGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateImageGroupRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/images/group/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateImageGroupRequest);
            return new AsyncInvoker<UpdateImageGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateImageGroupResponse>);
        }
        
        /// <summary>
        /// 更新服务部署配置
        ///
        /// 该接口适用于需要动态调整模型服务部署配置的场景
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInferDeploymentResponse> UpdateInferDeploymentAsync(UpdateInferDeploymentRequest updateInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInferDeploymentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInferDeploymentResponse>(response);
        }

        public AsyncInvoker<UpdateInferDeploymentResponse> UpdateInferDeploymentAsyncInvoker(UpdateInferDeploymentRequest updateInferDeploymentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInferDeploymentRequest);
            return new AsyncInvoker<UpdateInferDeploymentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInferDeploymentResponse>);
        }
        
        /// <summary>
        /// 手动服务扩缩容
        ///
        /// 该接口适用于模型服务实例扩缩容。通过调用此接口，用户可以在原有服务的情况下，对服务进行扩缩容，且不会增加新的版本；包括权限验证错误、服务状态错误和参数验证错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInferDeploymentScaleResponse> UpdateInferDeploymentScaleAsync(UpdateInferDeploymentScaleRequest updateInferDeploymentScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentScaleRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentScaleRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_name}/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInferDeploymentScaleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInferDeploymentScaleResponse>(response);
        }

        public AsyncInvoker<UpdateInferDeploymentScaleResponse> UpdateInferDeploymentScaleAsyncInvoker(UpdateInferDeploymentScaleRequest updateInferDeploymentScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentScaleRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentScaleRequest.DeploymentName, out var valueOfDeploymentName)) urlParam.Add("deployment_name", valueOfDeploymentName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_name}/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInferDeploymentScaleRequest);
            return new AsyncInvoker<UpdateInferDeploymentScaleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInferDeploymentScaleResponse>);
        }
        
        /// <summary>
        /// 变更内网申请
        ///
        /// 本接口用于对当前租户的内网接入申请进行状态变更操作，支持通过（APPROVE）、拒绝（REJECT）、取消（CANCEL）和重试（RETRY）等操作。适用于需要管理内网接入申请审批流程的场景。调用此接口前，确保已具备相应的变更权限，并提供有效的内网申请ID和所需的操作类型。变更成功后，内网申请的状态将更新为指定的操作结果，并记录相关日志。如果提供的内网申请ID无效、操作类型不支持或权限不足，将返回相应的异常信息，提示用户检查输入数据的有效性和权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInferIntranetConnectionResponse> UpdateInferIntranetConnectionAsync(UpdateInferIntranetConnectionRequest updateInferIntranetConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferIntranetConnectionRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInferIntranetConnectionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInferIntranetConnectionResponse>(response);
        }

        public AsyncInvoker<UpdateInferIntranetConnectionResponse> UpdateInferIntranetConnectionAsyncInvoker(UpdateInferIntranetConnectionRequest updateInferIntranetConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferIntranetConnectionRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/intranet-connection/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInferIntranetConnectionRequest);
            return new AsyncInvoker<UpdateInferIntranetConnectionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInferIntranetConnectionResponse>);
        }
        
        /// <summary>
        /// 更新服务配置
        ///
        /// 该接口适用于需要动态调整模型服务配置的场景，对模型的性能参数、资源池配置、服务调用配置等进行更新升级。通过调用此接口，用户可以在原有服务的情况下，升级成一个新的服务版本。调用此接口前，服务状态必须为“停止”、“失败”或“运行中”，且用户需具有修改服务的权限。更新成功后，新配置立即生效；若失败，服务保持原有配置并返回错误信息。常见异常包括参数验证错误、权限验证错误和服务状态错误。若服务ID无效、版本号不存在或用户无权限，则返回400 Bad Request或403 Forbidden；若服务状态不允许切换，则返回400 Bad Request。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInferServiceResponse> UpdateInferServiceAsync(UpdateInferServiceRequest updateInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInferServiceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInferServiceResponse>(response);
        }

        public AsyncInvoker<UpdateInferServiceResponse> UpdateInferServiceAsyncInvoker(UpdateInferServiceRequest updateInferServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInferServiceRequest);
            return new AsyncInvoker<UpdateInferServiceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInferServiceResponse>);
        }
        
        /// <summary>
        /// 修改工作空间
        ///
        /// 修改工作空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest updateWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkspaceRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkspaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkspaceResponse>(response);
        }

        public AsyncInvoker<UpdateWorkspaceResponse> UpdateWorkspaceAsyncInvoker(UpdateWorkspaceRequest updateWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkspaceRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkspaceRequest);
            return new AsyncInvoker<UpdateWorkspaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkspaceResponse>);
        }
        
        /// <summary>
        /// 修改工作空间配额
        ///
        /// 修改工作空间配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWorkspaceQuotasResponse> UpdateWorkspaceQuotasAsync(UpdateWorkspaceQuotasRequest updateWorkspaceQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkspaceQuotasRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkspaceQuotasRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkspaceQuotasResponse>(response);
        }

        public AsyncInvoker<UpdateWorkspaceQuotasResponse> UpdateWorkspaceQuotasAsyncInvoker(UpdateWorkspaceQuotasRequest updateWorkspaceQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkspaceQuotasRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkspaceQuotasRequest);
            return new AsyncInvoker<UpdateWorkspaceQuotasResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkspaceQuotasResponse>);
        }
        
        /// <summary>
        /// 鉴权能否使用当前工作空间资源
        ///
        /// 鉴权能否使用当前工作空间资源接口用于验证用户是否有权限访问和使用当前工作空间中的资源。该接口适用于以下场景：当用户尝试访问或操作工作空间中的资源时，系统需要确认用户是否具有相应的权限。使用该接口的前提条件是用户已登录且工作空间已存在。鉴权成功后，用户可以正常访问和使用工作空间资源；若鉴权失败，接口将返回相应的错误信息，如用户无权限或工作空间不存在等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateAuthorizationResponse> ValidateAuthorizationAsync(ValidateAuthorizationRequest validateAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateAuthorizationRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateAuthorizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ValidateAuthorizationResponse>(response);
        }

        public AsyncInvoker<ValidateAuthorizationResponse> ValidateAuthorizationAsyncInvoker(ValidateAuthorizationRequest validateAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateAuthorizationRequest.WorkspaceId, out var valueOfWorkspaceId)) urlParam.Add("workspace_id", valueOfWorkspaceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workspaces/{workspace_id}/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateAuthorizationRequest);
            return new AsyncInvoker<ValidateAuthorizationResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateAuthorizationResponse>);
        }
        
        /// <summary>
        /// 创建自动扩缩容策略
        ///
        /// 本接口用于在已部署的服务上创建定时扩缩容策略，适用于需要根据业务负载或特定时间自动调整服务实例个数的场景。调用此接口前，确保服务已成功部署并获取了有效的服务ID，并提供详细的扩缩容策略参数，如扩缩容时间、实例个数范围、条件触发器等。创建成功后，系统将根据设定的策略自动调整服务实例个数，确保服务在指定时间内的性能和可用性。如果提供的服务ID无效、参数配置错误或系统资源不足，将返回相应的异常信息，提示用户检查输入数据的有效性或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInferDeploymentHpaResponse> CreateInferDeploymentHpaAsync(CreateInferDeploymentHpaRequest createInferDeploymentHpaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInferDeploymentHpaRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(createInferDeploymentHpaRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInferDeploymentHpaRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInferDeploymentHpaResponse>(response);
        }

        public AsyncInvoker<CreateInferDeploymentHpaResponse> CreateInferDeploymentHpaAsyncInvoker(CreateInferDeploymentHpaRequest createInferDeploymentHpaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInferDeploymentHpaRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(createInferDeploymentHpaRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInferDeploymentHpaRequest);
            return new AsyncInvoker<CreateInferDeploymentHpaResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInferDeploymentHpaResponse>);
        }
        
        /// <summary>
        /// 删除自动扩缩容策略
        ///
        /// 本接口用于在已部署的服务上删除定时扩缩容策略，适用于需要根据业务负载或特定时间自动删除服务的场景。调用此接口前，确保服务已成功部署并获取了有效的服务ID，部署ID。如果提供的服务ID无效、参数配置错误或系统资源不足，将返回相应的异常信息，提示用户检查输入数据的有效性或联系技术支持。暂时为非开放接口，后端清理服务下的自动扩缩容策略规则使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInferDeploymentHpaResponse> DeleteInferDeploymentHpaAsync(DeleteInferDeploymentHpaRequest deleteInferDeploymentHpaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentHpaRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentHpaRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentHpaRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInferDeploymentHpaResponse>(response);
        }

        public AsyncInvoker<DeleteInferDeploymentHpaResponse> DeleteInferDeploymentHpaAsyncInvoker(DeleteInferDeploymentHpaRequest deleteInferDeploymentHpaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentHpaRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInferDeploymentHpaRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInferDeploymentHpaRequest);
            return new AsyncInvoker<DeleteInferDeploymentHpaResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInferDeploymentHpaResponse>);
        }
        
        /// <summary>
        /// 查看自动扩缩容策略事件
        ///
        /// 本接口用于在已部署的服务上查看自动扩缩容策略事件，适用于查看自动扩缩容策略变动历史记录。调用此接口前，确保获取了有效的用户项目ID，服务ID，部署ID。调用成功后，会返回策略事件ID，事件状态，规则执行信息，扩缩容前实例数，扩缩容后实例数，预设目标实例数，执行记录时间。如果提供的服务ID无效、参数配置错误或系统资源不足，将返回相应的异常信息，提示用户检查输入数据的有效性或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInferDeploymentHpaEventsResponse> ListInferDeploymentHpaEventsAsync(ListInferDeploymentHpaEventsRequest listInferDeploymentHpaEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentHpaEventsRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentHpaEventsRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentHpaEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInferDeploymentHpaEventsResponse>(response);
        }

        public AsyncInvoker<ListInferDeploymentHpaEventsResponse> ListInferDeploymentHpaEventsAsyncInvoker(ListInferDeploymentHpaEventsRequest listInferDeploymentHpaEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentHpaEventsRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(listInferDeploymentHpaEventsRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInferDeploymentHpaEventsRequest);
            return new AsyncInvoker<ListInferDeploymentHpaEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInferDeploymentHpaEventsResponse>);
        }
        
        /// <summary>
        /// 查看自动扩缩容策略
        ///
        /// 本接口用于在已部署的服务上查看自动扩缩容策略。调用此接口前，确保服务已成功部署并获取了有效的服务ID。查询成功后，返回服务对应的策略信息，如规则ID，规则名称，扩缩容类型，扩缩容状态，扩缩容cron表达式，目标实例数等。如果提供的服务ID无效、参数配置错误或系统资源不足，将返回相应的异常信息，提示用户检查输入数据的有效性或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInferDeploymentHpaResponse> ShowInferDeploymentHpaAsync(ShowInferDeploymentHpaRequest showInferDeploymentHpaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentHpaRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentHpaRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferDeploymentHpaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInferDeploymentHpaResponse>(response);
        }

        public AsyncInvoker<ShowInferDeploymentHpaResponse> ShowInferDeploymentHpaAsyncInvoker(ShowInferDeploymentHpaRequest showInferDeploymentHpaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentHpaRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(showInferDeploymentHpaRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferDeploymentHpaRequest);
            return new AsyncInvoker<ShowInferDeploymentHpaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInferDeploymentHpaResponse>);
        }
        
        /// <summary>
        /// 修改自动扩缩容策略
        ///
        /// 本接口用于在已部署的服务上修改定时扩缩容策略，适用于需要根据业务负载或特定时间自动调整服务实例个数的场景。调用此接口前，确保服务已成功部署并获取了有效的服务ID，部署ID，并提供详细的扩缩容策略参数，如扩缩容时间、实例个数范围、条件触发器等。修改成功后，系统将根据设定的策略自动调整服务实例个数，确保服务在指定时间内的性能和可用性。如果提供的服务ID无效、参数配置错误或系统资源不足，将返回相应的异常信息，提示用户检查输入数据的有效性或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInferDeploymentHpaResponse> UpdateInferDeploymentHpaAsync(UpdateInferDeploymentHpaRequest updateInferDeploymentHpaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentHpaRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentHpaRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInferDeploymentHpaRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInferDeploymentHpaResponse>(response);
        }

        public AsyncInvoker<UpdateInferDeploymentHpaResponse> UpdateInferDeploymentHpaAsyncInvoker(UpdateInferDeploymentHpaRequest updateInferDeploymentHpaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentHpaRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInferDeploymentHpaRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hpa", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInferDeploymentHpaRequest);
            return new AsyncInvoker<UpdateInferDeploymentHpaResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInferDeploymentHpaResponse>);
        }
        
        /// <summary>
        /// 创建HRA策略
        ///
        /// 本接口用于在已部署且支持HRA策略的服务上创建HRA策略，适用于需要根据业务负载或特定时间自动调整服务实例个数的场景。调用此接口前，确保服务已成功部署并获取了有效的服务ID，并提供详细的hra策略参数，如hra时间、实例个数范围、条件触发器等。创建成功后，系统将根据设定的策略自动调整服务实例个数，确保服务在指定时间内的性能和可用性。如果提供的服务ID无效、参数配置错误或系统资源不足，将返回相应的异常信息，提示用户检查输入数据的有效性或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInferHraResponse> CreateInferHraAsync(CreateInferHraRequest createInferHraRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInferHraRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(createInferHraRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hra", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInferHraRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInferHraResponse>(response);
        }

        public AsyncInvoker<CreateInferHraResponse> CreateInferHraAsyncInvoker(CreateInferHraRequest createInferHraRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInferHraRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(createInferHraRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hra", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInferHraRequest);
            return new AsyncInvoker<CreateInferHraResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInferHraResponse>);
        }
        
        /// <summary>
        /// 获取推理单元配比检测信息
        ///
        /// 本接口用于在已部署的服务上查看推理单元配比检测信息。调用此接口前，确保服务已成功部署并获取了有效的服务ID。查询成功后，返回服务对应的策略信息，如规则ID，规则名称，策略状态，HRA结果状态等。如果提供的服务ID无效、参数配置错误或系统资源不足，将返回相应的异常信息，提示用户检查输入数据的有效性或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInferHraResponse> ShowInferHraAsync(ShowInferHraRequest showInferHraRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferHraRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(showInferHraRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hra", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferHraRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInferHraResponse>(response);
        }

        public AsyncInvoker<ShowInferHraResponse> ShowInferHraAsyncInvoker(ShowInferHraRequest showInferHraRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInferHraRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(showInferHraRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hra", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInferHraRequest);
            return new AsyncInvoker<ShowInferHraResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInferHraResponse>);
        }
        
        /// <summary>
        /// 修改指定部署的HRA策略配置
        ///
        /// 本接口用于在已创建HRA策略的服务上修改指定部署的HRA策略配置，适用于需要根据业务负载或特定时间自动调整服务实例个数的场景。调用此接口前，确保服务已成功部署并获取了有效的服务ID，部署ID，并提供详细的hra策略参数，如HRA规则列表、HRA结果状态、策略状态等。修改成功后，系统将根据设定的策略自动调整服务实例个数，确保服务在指定时间内的性能和可用性。如果提供的服务ID无效、参数配置错误或系统资源不足，将返回相应的异常信息，提示用户检查输入数据的有效性或联系技术支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInferHraResponse> UpdateInferHraAsync(UpdateInferHraRequest updateInferHraRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferHraRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInferHraRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hra", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInferHraRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInferHraResponse>(response);
        }

        public AsyncInvoker<UpdateInferHraResponse> UpdateInferHraAsyncInvoker(UpdateInferHraRequest updateInferHraRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInferHraRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInferHraRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/services/{service_id}/deployments/{deployment_id}/hra", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInferHraRequest);
            return new AsyncInvoker<UpdateInferHraResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInferHraResponse>);
        }
        
        /// <summary>
        /// Lite Server服务器挂载磁盘
        ///
        /// Lite Server服务器挂载磁盘接口用于将额外的磁盘挂载到Lite Server服务器上。该接口适用于以下场景：当用户需要扩展Lite Server服务器的存储空间以满足更大的数据存储需求时，可以通过此接口将指定的磁盘挂载到服务器上。使用该接口的前提条件是Lite Server服务器已创建且处于运行状态、或者停止状态，用户具有挂载磁盘的权限，且指定的磁盘已存在且未被其他服务器使用。挂载操作完成后，磁盘将成功挂载到Lite Server服务器上，用户可以访问和使用新增的存储空间。若Lite Server服务器不存在、指定的磁盘不存在或已被使用，或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachDevServerVolumeResponse> AttachDevServerVolumeAsync(AttachDevServerVolumeRequest attachDevServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachDevServerVolumeRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/attachvolume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachDevServerVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachDevServerVolumeResponse>(response);
        }

        public AsyncInvoker<AttachDevServerVolumeResponse> AttachDevServerVolumeAsyncInvoker(AttachDevServerVolumeRequest attachDevServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachDevServerVolumeRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/attachvolume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachDevServerVolumeRequest);
            return new AsyncInvoker<AttachDevServerVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachDevServerVolumeResponse>);
        }
        
        /// <summary>
        /// 批量操作Lite Server实例
        ///
        /// 批量操作Lite Server实例接口用于对多个Lite Server实例进行统一操作，如启动、停止、重启或删除等。该接口适用于以下场景：当需要对多个Lite Server实例进行相同的操作，例如在维护期间批量停止实例、更新配置后批量重启实例或清理不再需要的实例时，用户可通过此接口高效地完成批量操作。使用该接口的前提条件是目标Lite Server实例已存在且用户具有相应的操作权限。操作完成后，所有指定的Lite Server实例将根据请求完成相应的状态变更或被移除，相关资源和配置也将被相应调整或清理。若目标Lite Server实例不存在、用户无权限操作或请求参数不正确，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDevServersActionResponse> BatchDevServersActionAsync(BatchDevServersActionRequest batchDevServersActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDevServersActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDevServersActionResponse>(response);
        }

        public AsyncInvoker<BatchDevServersActionResponse> BatchDevServersActionAsyncInvoker(BatchDevServersActionRequest batchDevServersActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDevServersActionRequest);
            return new AsyncInvoker<BatchDevServersActionResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDevServersActionResponse>);
        }
        
        /// <summary>
        /// Lite Server服务器绑定EIP
        ///
        /// Lite Server服务器绑定的EIP接口用于将弹性公网IP（EIP）绑定到Lite Server服务器上。该接口适用于以下场景：当用户需要为Lite Server服务器分配一个固定的公网IP地址，以便从外部网络访问服务器时，可以通过此接口将指定的EIP绑定到服务器上。使用该接口的前提条件是Lite Server服务器已创建且处于运行状态，用户具有绑定EIP的权限，且指定的EIP已存在且未被其他资源使用。绑定操作完成后，EIP将成功绑定到Lite Server服务器上，服务器可以通过该EIP从外部网络访问。若Lite Server服务器不存在、已处于停止状态、指定的EIP不存在或已被使用，或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BindDevServerPublicIPResponse> BindDevServerPublicIPAsync(BindDevServerPublicIPRequest bindDevServerPublicIPRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDevServerPublicIPRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", bindDevServerPublicIPRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BindDevServerPublicIPResponse>(response);
        }

        public AsyncInvoker<BindDevServerPublicIPResponse> BindDevServerPublicIPAsyncInvoker(BindDevServerPublicIPRequest bindDevServerPublicIPRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDevServerPublicIPRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", bindDevServerPublicIPRequest);
            return new AsyncInvoker<BindDevServerPublicIPResponse>(this, "POST", request, JsonUtils.DeSerialize<BindDevServerPublicIPResponse>);
        }
        
        /// <summary>
        /// 切换Lite Server服务器操作系统镜像
        ///
        /// 切换Lite Server服务器操作系统镜像接口用于更换Lite Server服务器当前使用的操作系统镜像。该接口适用于以下场景：当用户需要更换操作系统以适应不同的开发或测试需求时，可以通过此接口切换指定的Lite Server服务器操作系统镜像。使用该接口的前提条件是Lite Server服务器已存在且处于停止状态，用户具有切换操作系统的权限。切换操作完成后，Lite Server服务器将安装新的操作系统镜像，并重新进入运行状态，若Lite Server服务器不存在、已处于运行状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeDevServerOSResponse> ChangeDevServerOSAsync(ChangeDevServerOSRequest changeDevServerOSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDevServerOSRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeDevServerOSRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeDevServerOSResponse>(response);
        }

        public AsyncInvoker<ChangeDevServerOSResponse> ChangeDevServerOSAsyncInvoker(ChangeDevServerOSRequest changeDevServerOSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDevServerOSRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeDevServerOSRequest);
            return new AsyncInvoker<ChangeDevServerOSResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeDevServerOSResponse>);
        }
        
        /// <summary>
        /// 切换Lite Server超节点服务器操作系统镜像
        ///
        /// 切换Lite Server超节点服务器操作系统镜像接口用于更换Lite Server超节点服务器当前使用的操作系统镜像。该接口适用于以下场景：当用户需要更换操作系统以适应不同的开发或测试需求时，可以通过此接口切换指定的Lite Server超节点服务器操作系统镜像。使用该接口的前提条件是Lite Server超节点服务器已存在且处于停止状态，用户具有切换操作系统的权限。切换操作完成后，Lite Server超节点服务器将安装新的操作系统镜像，并重新进入运行状态，若Lite Server超节点服务器不存在、已处于运行状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeHyperinstanceOSResponse> ChangeHyperinstanceOSAsync(ChangeHyperinstanceOSRequest changeHyperinstanceOSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeHyperinstanceOSRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeHyperinstanceOSRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeHyperinstanceOSResponse>(response);
        }

        public AsyncInvoker<ChangeHyperinstanceOSResponse> ChangeHyperinstanceOSAsyncInvoker(ChangeHyperinstanceOSRequest changeHyperinstanceOSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeHyperinstanceOSRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeHyperinstanceOSRequest);
            return new AsyncInvoker<ChangeHyperinstanceOSResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeHyperinstanceOSResponse>);
        }
        
        /// <summary>
        /// 创建Lite Server
        ///
        /// 创建Lite Server接口用于创建LiteServer弹性云服务器、裸金属服务器及超节点服务器。该接口适用于以下场景：用户需要根据业务需求快速部署和配置不同类型的服务器资源。使用该接口的前提条件是用户已登录且具有创建Lite Server的权限，并且需要提供服务器类型、规格、网络配置等必要参数。创建操作完成后，系统将返回新创建的Lite Server实例信息，包括实例ID、状态等。若用户无权限、参数配置错误或资源不足，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDevServerResponse> CreateDevServerAsync(CreateDevServerRequest createDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDevServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDevServerResponse>(response);
        }

        public AsyncInvoker<CreateDevServerResponse> CreateDevServerAsyncInvoker(CreateDevServerRequest createDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDevServerRequest);
            return new AsyncInvoker<CreateDevServerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDevServerResponse>);
        }
        
        /// <summary>
        /// 创建Lite Server任务
        ///
        /// 创建Lite Server任务接口用于在Lite Server上创建新的任务。该接口适用于以下场景：当用户需要在Lite Server上启动新的开发、测试或部署任务时，可以通过此接口创建并配置任务。使用该接口的前提条件是用户具有创建任务的权限，并且提供的任务配置参数符合要求。创建操作完成后，新的Lite Server任务将被成功创建，并返回任务ID和其他相关信息。若用户无权限操作、提供的参数不正确或系统资源不足，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDevServerJobResponse> CreateDevServerJobAsync(CreateDevServerJobRequest createDevServerJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDevServerJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDevServerJobResponse>(response);
        }

        public AsyncInvoker<CreateDevServerJobResponse> CreateDevServerJobAsyncInvoker(CreateDevServerJobRequest createDevServerJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDevServerJobRequest);
            return new AsyncInvoker<CreateDevServerJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDevServerJobResponse>);
        }
        
        /// <summary>
        /// 创建Hyper Cluster
        ///
        /// 创建Hyper Cluster接口用于在系统中创建一个新的Hyper Cluster。该接口适用于以下场景：当用户需要使用超节点网络时，可以通过此接口创建Hyper Cluster。使用该接口的前提条件是用户已登录并具有创建Hyper Cluster的权限，且系统中已配置了必要的资源。创建操作完成后，将生成一个新的超节点网络，并返回超节点网络的详细信息，包括ID、名称、子网信息等。若用户无权限操作、系统中缺少必要的资源或配置参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHyperClusterResponse> CreateHyperClusterAsync(CreateHyperClusterRequest createHyperClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyper-clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHyperClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHyperClusterResponse>(response);
        }

        public AsyncInvoker<CreateHyperClusterResponse> CreateHyperClusterAsyncInvoker(CreateHyperClusterRequest createHyperClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyper-clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHyperClusterRequest);
            return new AsyncInvoker<CreateHyperClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHyperClusterResponse>);
        }
        
        /// <summary>
        /// 创建Lite Server超节点标签
        ///
        /// 创建Lite Server超节点标签接口用于为Lite Server超节点添加自定义标签。该接口适用于以下场景：当用户需要对Lite Server超节点进行分类管理或标记特定信息时，可以通过此接口为指定的超节点创建标签。使用该接口的前提条件是Lite Server超节点已存在，用户具有创建标签的权限。创建操作完成后，标签将被成功添加到指定的超节点上，用户可以通过标签进行快速查找和管理。若Lite Server超节点不存在、标签已存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHyperinstanceTagsResponse> CreateHyperinstanceTagsAsync(CreateHyperinstanceTagsRequest createHyperinstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createHyperinstanceTagsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHyperinstanceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHyperinstanceTagsResponse>(response);
        }

        public AsyncInvoker<CreateHyperinstanceTagsResponse> CreateHyperinstanceTagsAsyncInvoker(CreateHyperinstanceTagsRequest createHyperinstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createHyperinstanceTagsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHyperinstanceTagsRequest);
            return new AsyncInvoker<CreateHyperinstanceTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHyperinstanceTagsResponse>);
        }
        
        /// <summary>
        /// 创建RoCE网络
        ///
        /// 创建RoCE网络接口用于在系统中创建一个新的RoCE网络。该接口适用于以下场景：当用户需要为高性能计算或低延迟应用创建专用的RoCE网络时，可以通过此接口创建并配置RoCE网络。使用该接口的前提条件是用户已登录并具有创建RoCE网络的权限，且系统中已配置了必要的网络资源。创建操作完成后，将生成一个新的RoCE网络，并返回网络的详细信息，包括网络ID、子网信息、配置参数等。若用户无权限操作、系统中缺少必要的网络资源或网络配置参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRoceNetworkResponse> CreateRoceNetworkAsync(CreateRoceNetworkRequest createRoceNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRoceNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRoceNetworkResponse>(response);
        }

        public AsyncInvoker<CreateRoceNetworkResponse> CreateRoceNetworkAsyncInvoker(CreateRoceNetworkRequest createRoceNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRoceNetworkRequest);
            return new AsyncInvoker<CreateRoceNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRoceNetworkResponse>);
        }
        
        /// <summary>
        /// 删除Lite Server实例
        ///
        /// 删除Lite Server实例接口用于移除已创建的Lite Server实例。该接口适用于以下场景：当Lite Server按需实例不再需要使用时或者创建失败的实例以及处于ERROR状态时，用户可通过此接口删除指定的Lite Server实例。使用该接口的前提条件是Lite Server实例已存在且用户具有管理员权限。删除操作完成后，Lite Server实例将被永久移除，相关资源也将被清理。若Lite Server实例不存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDevServerResponse> DeleteDevServerAsync(DeleteDevServerRequest deleteDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDevServerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDevServerResponse>(response);
        }

        public AsyncInvoker<DeleteDevServerResponse> DeleteDevServerAsyncInvoker(DeleteDevServerRequest deleteDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDevServerRequest);
            return new AsyncInvoker<DeleteDevServerResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDevServerResponse>);
        }
        
        /// <summary>
        /// 批量删除Lite Server Job
        ///
        /// 批量删除Lite Server Job接口用于批量移除已创建的Lite Server Job。该接口适用于以下场景：当多个Lite Server Job已完成、配置错误或需要清理资源时，用户可以通过此接口批量删除指定的Lite Server Job。使用该接口的前提条件是目标Lite Server Job已存在且用户具有管理员权限。删除操作完成后，指定的Lite Server Job将被永久移除，相关资源和配置也将被清理。若目标Lite Server Job不存在、用户无权限操作或请求参数不正确，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDevServerJobsResponse> DeleteDevServerJobsAsync(DeleteDevServerJobsRequest deleteDevServerJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDevServerJobsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDevServerJobsResponse>(response);
        }

        public AsyncInvoker<DeleteDevServerJobsResponse> DeleteDevServerJobsAsyncInvoker(DeleteDevServerJobsRequest deleteDevServerJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDevServerJobsRequest);
            return new AsyncInvoker<DeleteDevServerJobsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDevServerJobsResponse>);
        }
        
        /// <summary>
        /// 删除Hyper Cluster实例
        ///
        /// 删除Hyper Cluster实例接口用于移除已创建的Hyper Cluster。该接口适用于以下场景：当超节点网络配置错误或需要清理资源时，用户可通过此接口删除指定的超节点网络。使用该接口的前提条件是Hyper Cluster实例已存在且用户具有管理员权限。删除操作完成后，超节点网络将被永久移除，相关资源和配置也将被清理。若Hyper Cluster实例不存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHyperClusterResponse> DeleteHyperClusterAsync(DeleteHyperClusterRequest deleteHyperClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHyperClusterRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyper-clusters/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHyperClusterRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHyperClusterResponse>(response);
        }

        public AsyncInvoker<DeleteHyperClusterResponse> DeleteHyperClusterAsyncInvoker(DeleteHyperClusterRequest deleteHyperClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHyperClusterRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyper-clusters/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHyperClusterRequest);
            return new AsyncInvoker<DeleteHyperClusterResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHyperClusterResponse>);
        }
        
        /// <summary>
        /// 删除Lite Server超节点实例
        ///
        /// 删除Lite Server超节点实例接口用于删除按需超节点实例同时移除处于ERROR状态的Lite Server超节点实例。该接口适用于以下场景：当超节点实例因创建失败、或其他原因进入ERROR状态；按需超节点实例，用户可以通过此接口删除指定的超节点实例。使用该接口的前提条件是用户已登录并具有删除超节点实例的权限，且指定的超节点实例是按需且处于运行状态、或者处于ERROR状态。删除操作完成后，指定的超节点实例将被永久移除，相关资源也将被清理。若指定的超节点实例不存在、未处于ERROR状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHyperinstanceResponse> DeleteHyperinstanceAsync(DeleteHyperinstanceRequest deleteHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHyperinstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHyperinstanceResponse>(response);
        }

        public AsyncInvoker<DeleteHyperinstanceResponse> DeleteHyperinstanceAsyncInvoker(DeleteHyperinstanceRequest deleteHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHyperinstanceRequest);
            return new AsyncInvoker<DeleteHyperinstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHyperinstanceResponse>);
        }
        
        /// <summary>
        /// 删除Lite Server超节点标签
        ///
        /// 删除Lite Server超节点标签接口用于移除已创建的Lite Server超节点标签。该接口适用于以下场景：当用户需要清理不再需要的标签或修正标签错误时，可以通过此接口删除指定的超节点标签。使用该接口的前提条件是Lite Server超节点已存在，且该超节点上已存在要删除的标签，用户具有删除标签的权限。删除操作完成后，指定的标签将从超节点上移除，超节点的其他配置和数据保持不变。若Lite Server超节点不存在、标签不存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHyperinstanceTagsResponse> DeleteHyperinstanceTagsAsync(DeleteHyperinstanceTagsRequest deleteHyperinstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHyperinstanceTagsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHyperinstanceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteHyperinstanceTagsResponse>(response);
        }

        public AsyncInvoker<DeleteHyperinstanceTagsResponse> DeleteHyperinstanceTagsAsyncInvoker(DeleteHyperinstanceTagsRequest deleteHyperinstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHyperinstanceTagsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHyperinstanceTagsRequest);
            return new AsyncInvoker<DeleteHyperinstanceTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteHyperinstanceTagsResponse>);
        }
        
        /// <summary>
        /// Lite Server服务器卸载磁盘
        ///
        /// Lite Server服务器卸载磁盘接口用于从Lite Server服务器上卸载已挂载的磁盘。该接口适用于以下场景：当用户需要释放存储资源或重新分配磁盘时，可以通过此接口卸载指定的磁盘。使用该接口的前提条件是Lite Server服务器已创建且处于运行状态、或者停止状态，用户具有卸载磁盘的权限，且指定的磁盘已挂载到服务器上。卸载操作完成后，磁盘将从Lite Server服务器上成功卸载，用户可以将其挂载到其他服务器或进行其他操作。若Lite Server服务器不存在、指定的磁盘未挂载到服务器上，或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachDevServerVolumeResponse> DetachDevServerVolumeAsync(DetachDevServerVolumeRequest detachDevServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachDevServerVolumeRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(detachDevServerVolumeRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/detachvolume/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachDevServerVolumeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DetachDevServerVolumeResponse>(response);
        }

        public AsyncInvoker<DetachDevServerVolumeResponse> DetachDevServerVolumeAsyncInvoker(DetachDevServerVolumeRequest detachDevServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachDevServerVolumeRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(detachDevServerVolumeRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/detachvolume/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachDevServerVolumeRequest);
            return new AsyncInvoker<DetachDevServerVolumeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DetachDevServerVolumeResponse>);
        }
        
        /// <summary>
        /// 查询Lite Server镜像详情
        ///
        /// 查询Lite Server镜像详情接口用于获取指定Lite Server镜像的详细信息。该接口适用于以下场景：当用户需要了解某个Lite Server镜像的具体配置和属性，以便在创建或调整Lite Server实例时选择合适的镜像时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询镜像详情的权限，且指定的镜像已存在。查询操作完成后，接口将返回指定Lite Server镜像的详细信息，包括镜像ID、名称、操作系统、版本、创建时间等。若用户无权限操作、指定的镜像不存在或镜像ID无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetDevServerImageResponse> GetDevServerImageAsync(GetDevServerImageRequest getDevServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerImageRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/images/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerImageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetDevServerImageResponse>(response);
        }

        public AsyncInvoker<GetDevServerImageResponse> GetDevServerImageAsyncInvoker(GetDevServerImageRequest getDevServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerImageRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/images/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerImageRequest);
            return new AsyncInvoker<GetDevServerImageResponse>(this, "GET", request, JsonUtils.DeSerialize<GetDevServerImageResponse>);
        }
        
        /// <summary>
        /// 查询Lite Server Job详情
        ///
        /// 查询Lite Server Job详情接口用于获取指定Lite Server Job的详细信息。该接口适用于以下场景：当用户需要查看某个Lite Server Job的执行状态、配置参数、日志信息等详细数据时，可以通过此接口获取相关信息。使用该接口的前提条件是目标Lite Server Job已存在且用户具有查看权限。查询操作完成后，接口将返回指定Lite Server Job的详细信息，包括但不限于Job ID、状态、创建时间、执行时间、配置参数和日志等。若目标Lite Server Job不存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetDevServerJobResponse> GetDevServerJobAsync(GetDevServerJobRequest getDevServerJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerJobRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetDevServerJobResponse>(response);
        }

        public AsyncInvoker<GetDevServerJobResponse> GetDevServerJobAsyncInvoker(GetDevServerJobRequest getDevServerJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerJobRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerJobRequest);
            return new AsyncInvoker<GetDevServerJobResponse>(this, "GET", request, JsonUtils.DeSerialize<GetDevServerJobResponse>);
        }
        
        /// <summary>
        /// 获取Lite Server 部署服务详情
        ///
        /// 根据服务id获取Lite Server部署服务详情。该接口适用于以下场景：当用户需要查看部署服务详情，以便查看已部署服务的状态、api等信息时，可以通过此接口获取服务详情。使用该接口的前提条件是用户具有查看服务的权限。查询操作完成后，接口将返回此部署服务的详细信息，包括名称、状态、描述、所用模型、实例详情等信息。若用户无权限操作或无相应id，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetDevServerJobServiceResponse> GetDevServerJobServiceAsync(GetDevServerJobServiceRequest getDevServerJobServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerJobServiceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs/services/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerJobServiceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetDevServerJobServiceResponse>(response);
        }

        public AsyncInvoker<GetDevServerJobServiceResponse> GetDevServerJobServiceAsyncInvoker(GetDevServerJobServiceRequest getDevServerJobServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerJobServiceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs/services/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerJobServiceRequest);
            return new AsyncInvoker<GetDevServerJobServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<GetDevServerJobServiceResponse>);
        }
        
        /// <summary>
        /// 获取Lite Server Job模板详情
        ///
        /// 获取Lite Server Job模板详情接口用于获取指定Lite Server Job模板的详细信息。该接口适用于以下场景：当用户需要查看某个特定Job模板的详细配置，以便了解其参数设置、使用说明等信息时，可以通过此接口获取模板详情。查询操作完成后，接口将返回指定模板的详细信息，包括模板ID、名称、描述、配置参数等。若目标模板不存在，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetDevServerJobTemplateResponse> GetDevServerJobTemplateAsync(GetDevServerJobTemplateRequest getDevServerJobTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerJobTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerJobTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetDevServerJobTemplateResponse>(response);
        }

        public AsyncInvoker<GetDevServerJobTemplateResponse> GetDevServerJobTemplateAsyncInvoker(GetDevServerJobTemplateRequest getDevServerJobTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerJobTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerJobTemplateRequest);
            return new AsyncInvoker<GetDevServerJobTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<GetDevServerJobTemplateResponse>);
        }
        
        /// <summary>
        /// 查询Operation详情
        ///
        /// 查询Operation详情接口用于获取指定Operation的详细信息。该接口适用于以下场景：当用户需要了解某个Operation的具体执行情况和状态，以便进行故障排查或操作审计时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询Operation详情的权限，且指定的Operation已存在。查询操作完成后，接口将返回指定Operation的详细信息，包括Operation ID、操作类型、执行状态、开始时间、结束时间、操作结果等。若用户无权限操作、指定的Operation不存在或Operation ID无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetDevServerOperationResponse> GetDevServerOperationAsync(GetDevServerOperationRequest getDevServerOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerOperationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(getDevServerOperationRequest.OperationId, out var valueOfOperationId)) urlParam.Add("operation_id", valueOfOperationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/operation/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerOperationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetDevServerOperationResponse>(response);
        }

        public AsyncInvoker<GetDevServerOperationResponse> GetDevServerOperationAsyncInvoker(GetDevServerOperationRequest getDevServerOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getDevServerOperationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(getDevServerOperationRequest.OperationId, out var valueOfOperationId)) urlParam.Add("operation_id", valueOfOperationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/operation/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getDevServerOperationRequest);
            return new AsyncInvoker<GetDevServerOperationResponse>(this, "GET", request, JsonUtils.DeSerialize<GetDevServerOperationResponse>);
        }
        
        /// <summary>
        /// 查询Hyper Cluster实例详情
        ///
        /// 查询Hyper Cluster实例详情接口用于获取指定Hyper Cluster实例的详细信息。该接口适用于以下场景：当用户需要了解某个超节点网络的具体配置和状态，以便进行管理和监控时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询Hyper Cluster详情的权限，且指定的超节点网络已存在。查询操作完成后，接口将返回指定超节点网络的详细信息，包括ID、名称、子网信息等。若用户无权限操作、指定的超节点网络不存在或ID无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetHyperClusterResponse> GetHyperClusterAsync(GetHyperClusterRequest getHyperClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getHyperClusterRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyper-clusters/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHyperClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetHyperClusterResponse>(response);
        }

        public AsyncInvoker<GetHyperClusterResponse> GetHyperClusterAsyncInvoker(GetHyperClusterRequest getHyperClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getHyperClusterRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyper-clusters/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHyperClusterRequest);
            return new AsyncInvoker<GetHyperClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<GetHyperClusterResponse>);
        }
        
        /// <summary>
        /// 查询指定超节点实例详情
        ///
        /// 查询指定超节点实例详情接口用于获取特定Lite Server超节点实例的详细信息。该接口适用于以下场景：当用户需要查看某个具体超节点实例的配置、状态和使用情况时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询超节点实例的权限，且指定的超节点实例已存在。查询操作完成后，接口将返回指定超节点实例的详细信息，包括实例ID、操作系统、运行状态、资源使用情况等。若用户无权限操作、指定的超节点实例不存在或实例ID无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetHyperinstanceResponse> GetHyperinstanceAsync(GetHyperinstanceRequest getHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHyperinstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetHyperinstanceResponse>(response);
        }

        public AsyncInvoker<GetHyperinstanceResponse> GetHyperinstanceAsyncInvoker(GetHyperinstanceRequest getHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHyperinstanceRequest);
            return new AsyncInvoker<GetHyperinstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<GetHyperinstanceResponse>);
        }
        
        /// <summary>
        /// 查询Lite Server超节点扩缩容支持规格列表及容量测算
        ///
        /// 查询Lite Server超节点扩缩容支持规格列表及容量测算接口用于获取Lite Server超节点支持的扩缩容规格列表，并进行容量测算。该接口适用于以下场景：当用户需要了解Lite Server超节点支持的扩缩容选项，以便在调整超节点资源时选择合适的规格，并评估扩缩容后的资源需求时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询超节点扩缩容规格的权限，且指定的超节点已存在。查询操作完成后，接口将返回支持的扩缩容规格列表及容量测算结果，包括规格ID、CPU、内存、存储等详细配置和扩缩容后的资源使用情况。若用户无权限操作、指定的超节点不存在或系统中没有可用的扩缩容规格，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetScaleEvaluationsDevServerResponse> GetScaleEvaluationsDevServerAsync(GetScaleEvaluationsDevServerRequest getScaleEvaluationsDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getScaleEvaluationsDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/scale-evaluations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getScaleEvaluationsDevServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetScaleEvaluationsDevServerResponse>(response);
        }

        public AsyncInvoker<GetScaleEvaluationsDevServerResponse> GetScaleEvaluationsDevServerAsyncInvoker(GetScaleEvaluationsDevServerRequest getScaleEvaluationsDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getScaleEvaluationsDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/scale-evaluations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getScaleEvaluationsDevServerRequest);
            return new AsyncInvoker<GetScaleEvaluationsDevServerResponse>(this, "GET", request, JsonUtils.DeSerialize<GetScaleEvaluationsDevServerResponse>);
        }
        
        /// <summary>
        /// 查询实例的Tor信息
        ///
        /// 查询实例的Tor信息接口用于获取指定实例的Top-of-Rack（Tor）交换机相关信息。该接口适用于以下场景：当用户需要了解实例连接的Tor交换机的详细信息，以便进行网络配置时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询实例Tor信息的权限，且指定的实例已存在。查询操作完成后，接口将返回指定实例的Tor信息。若用户无权限操作、指定的实例不存在或实例未连接到Tor交换机，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetTopologiesResponse> GetTopologiesAsync(GetTopologiesRequest getTopologiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/instance-physical-topologies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getTopologiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetTopologiesResponse>(response);
        }

        public AsyncInvoker<GetTopologiesResponse> GetTopologiesAsyncInvoker(GetTopologiesRequest getTopologiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/instance-physical-topologies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getTopologiesRequest);
            return new AsyncInvoker<GetTopologiesResponse>(this, "GET", request, JsonUtils.DeSerialize<GetTopologiesResponse>);
        }
        
        /// <summary>
        /// 查询租户Lite Server列表
        ///
        /// 查询租户Lite Server列表接口用于获取指定租户的所有Lite Server实例信息。该接口适用于以下场景：当用户需要查看其租户下所有Lite Server实例的详细信息，以便进行管理和监控时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询租户Lite Server列表的权限。查询操作完成后，接口将返回租户下所有Lite Server实例的详细信息，包括实例ID、名称、状态、资源配置等。若用户无权限操作或租户下没有Lite Server实例，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllDevServersResponse> ListAllDevServersAsync(ListAllDevServersRequest listAllDevServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllDevServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllDevServersResponse>(response);
        }

        public AsyncInvoker<ListAllDevServersResponse> ListAllDevServersAsyncInvoker(ListAllDevServersRequest listAllDevServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllDevServersRequest);
            return new AsyncInvoker<ListAllDevServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllDevServersResponse>);
        }
        
        /// <summary>
        /// 查询租户Hyperinstance列表
        ///
        /// 查询租户Hyperinstance列表接口用于获取指定租户的所有Hyperinstance实例信息。该接口适用于以下场景：当用户需要查看其租户下所有Hyperinstance实例的详细信息，以便进行管理和监控时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询租户Hyperinstance列表的权限。查询操作完成后，接口将返回租户下所有Hyperinstance实例的详细信息，包括实例ID、名称、状态、资源配置等。若用户无权限操作或租户下没有Hyperinstance实例，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllHyperinstancesResponse> ListAllHyperinstancesAsync(ListAllHyperinstancesRequest listAllHyperinstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllHyperinstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllHyperinstancesResponse>(response);
        }

        public AsyncInvoker<ListAllHyperinstancesResponse> ListAllHyperinstancesAsyncInvoker(ListAllHyperinstancesRequest listAllHyperinstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllHyperinstancesRequest);
            return new AsyncInvoker<ListAllHyperinstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllHyperinstancesResponse>);
        }
        
        /// <summary>
        /// 查询规格列表
        ///
        /// 查询规格列表接口用于获取系统中所有可用的资源规格信息。该接口适用于以下场景：当用户需要了解可用的资源规格，以便在创建或调整Lite Server实例时选择合适的配置时，可以通过此接口获取规格列表。使用该接口的前提条件是用户已登录并具有查询规格的权限。查询操作完成后，接口将返回所有可用的资源规格信息，包括规格ID、CPU、内存、存储等详细配置。若用户无权限操作或系统中没有可用的资源规格，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDevServerFlavorsResponse> ListDevServerFlavorsAsync(ListDevServerFlavorsRequest listDevServerFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDevServerFlavorsResponse>(response);
        }

        public AsyncInvoker<ListDevServerFlavorsResponse> ListDevServerFlavorsAsyncInvoker(ListDevServerFlavorsRequest listDevServerFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerFlavorsRequest);
            return new AsyncInvoker<ListDevServerFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevServerFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询Lite Server镜像列表
        ///
        /// 查询Lite Server镜像列表接口用于获取系统中所有可用的Lite Server镜像信息。该接口适用于以下场景：当用户需要了解可用的Lite Server镜像，以便在创建或调整Lite Server实例时选择合适的镜像时，可以通过此接口获取镜像列表。使用该接口的前提条件是用户已登录并具有查询镜像列表的权限。查询操作完成后，接口将返回所有可用的Lite Server镜像信息，包括镜像ID、名称、架构类型等。若用户无权限操作或系统中没有可用的镜像，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDevServerImagesResponse> ListDevServerImagesAsync(ListDevServerImagesRequest listDevServerImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerImagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDevServerImagesResponse>(response);
        }

        public AsyncInvoker<ListDevServerImagesResponse> ListDevServerImagesAsyncInvoker(ListDevServerImagesRequest listDevServerImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerImagesRequest);
            return new AsyncInvoker<ListDevServerImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevServerImagesResponse>);
        }
        
        /// <summary>
        /// 获取Lite Server Job模板列表
        ///
        /// 获取Lite Server Job模板列表接口用于获取可用的Lite Server Job模板列表。该接口适用于以下场景：当用户需要查看可用的Job模板，以便选择合适的模板来创建新的Lite Server任务时，可以通过此接口获取模板列表。查询操作完成后，接口将返回所有可用的Lite Server Job模板列表，包括模板ID、名称、描述等信息。若系统中无可用模板，接口将返回相应的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDevServerJobTemplatesResponse> ListDevServerJobTemplatesAsync(ListDevServerJobTemplatesRequest listDevServerJobTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerJobTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDevServerJobTemplatesResponse>(response);
        }

        public AsyncInvoker<ListDevServerJobTemplatesResponse> ListDevServerJobTemplatesAsyncInvoker(ListDevServerJobTemplatesRequest listDevServerJobTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerJobTemplatesRequest);
            return new AsyncInvoker<ListDevServerJobTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevServerJobTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询Lite Server Job列表
        ///
        /// 查询Lite Server Job列表接口用于获取Lite Server Job的列表信息，并支持按照状态、ID等相关字段进行过滤。该接口适用于以下场景：当用户需要查看多个Lite Server Job的概要信息，例如在监控作业状态、排查问题或进行日常管理时，可以通过此接口获取符合过滤条件的Job列表。使用该接口的前提条件是用户具有查看权限。查询操作完成后，接口将返回符合条件的Lite Server Job列表，包括每个Job的ID、状态、创建时间等基本信息。若用户无权限操作或请求参数不正确，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDevServerJobsResponse> ListDevServerJobsAsync(ListDevServerJobsRequest listDevServerJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDevServerJobsResponse>(response);
        }

        public AsyncInvoker<ListDevServerJobsResponse> ListDevServerJobsAsyncInvoker(ListDevServerJobsRequest listDevServerJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerJobsRequest);
            return new AsyncInvoker<ListDevServerJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevServerJobsResponse>);
        }
        
        /// <summary>
        /// 查询已绑定的EIP
        ///
        /// 查询已绑定的EIP接口用于获取已绑定到Lite Server服务器上的弹性公网IP（EIP）信息。该接口适用于以下场景：当用户需要查看Lite Server服务器上已绑定的EIP及其详细信息时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询EIP的权限，且指定的Lite Server服务器已存在。查询操作完成后，接口将返回已绑定到Lite Server服务器上的EIP的详细信息，包括EIP地址、绑定时间、状态等。若Lite Server服务器不存在、未绑定EIP或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDevServerPublicIPResponse> ListDevServerPublicIPAsync(ListDevServerPublicIPRequest listDevServerPublicIPRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDevServerPublicIPRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerPublicIPRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDevServerPublicIPResponse>(response);
        }

        public AsyncInvoker<ListDevServerPublicIPResponse> ListDevServerPublicIPAsyncInvoker(ListDevServerPublicIPRequest listDevServerPublicIPRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDevServerPublicIPRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServerPublicIPRequest);
            return new AsyncInvoker<ListDevServerPublicIPResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevServerPublicIPResponse>);
        }
        
        /// <summary>
        /// 查询用户所有Lite Server实例列表
        ///
        /// 查询用户所有Lite Server实例列表接口用于获取用户名下所有Lite Server实例的详细信息。该接口适用于以下场景：用户需要查看其所有Lite Server实例的状态、配置等信息，以便进行资源管理和监控。使用该接口的前提条件是用户已登录且具有查看Lite Server实例的权限。调用此接口后，系统将返回用户名下所有Lite Server实例的列表，包括实例ID、名称、状态、创建时间等信息。若用户无权限或未登录，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDevServersResponse> ListDevServersAsync(ListDevServersRequest listDevServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDevServersResponse>(response);
        }

        public AsyncInvoker<ListDevServersResponse> ListDevServersAsyncInvoker(ListDevServersRequest listDevServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevServersRequest);
            return new AsyncInvoker<ListDevServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevServersResponse>);
        }
        
        /// <summary>
        /// 查询Hyper Cluster详情列表
        ///
        /// 查询Hyper Cluster详情列表接口用于获取所有Hyper Cluster的详细信息。该接口适用于以下场景：当用户需要了解系统中所有超节点网络的配置和状态时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询Hyper Cluster详情的权限。查询操作完成后，接口将返回所有超节点网络的详细信息，包括ID、名称、子网信息等。若用户无权限操作或系统中没有Hyper Cluster，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHyperClusterResponse> ListHyperClusterAsync(ListHyperClusterRequest listHyperClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyper-clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHyperClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHyperClusterResponse>(response);
        }

        public AsyncInvoker<ListHyperClusterResponse> ListHyperClusterAsyncInvoker(ListHyperClusterRequest listHyperClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyper-clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHyperClusterRequest);
            return new AsyncInvoker<ListHyperClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHyperClusterResponse>);
        }
        
        /// <summary>
        /// 查询超节点hyperinstance-clusters逻辑容量测算结果
        ///
        /// 查询超节点hyperinstance-clusters逻辑容量测算结果接口用于获取指定超节点集群的逻辑容量测算结果。该接口适用于以下场景：当用户需要了解超节点集群的资源使用情况和容量规划，以便进行资源管理和优化时，可以通过此接口获取逻辑容量测算结果。使用该接口的前提条件是用户已登录并具有查询超节点集群逻辑容量的权限，且指定的超节点集群已存在。查询操作完成后，接口将返回指定超节点集群的逻辑容量测算结果，包括可用容量信息。若用户无权限操作、指定的超节点集群不存在或集群ID无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHyperinstanceClustersCapacityResponse> ListHyperinstanceClustersCapacityAsync(ListHyperinstanceClustersCapacityRequest listHyperinstanceClustersCapacityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/cluster-capacity-evaluations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHyperinstanceClustersCapacityRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListHyperinstanceClustersCapacityResponse>(response);
        }

        public AsyncInvoker<ListHyperinstanceClustersCapacityResponse> ListHyperinstanceClustersCapacityAsyncInvoker(ListHyperinstanceClustersCapacityRequest listHyperinstanceClustersCapacityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/cluster-capacity-evaluations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHyperinstanceClustersCapacityRequest);
            return new AsyncInvoker<ListHyperinstanceClustersCapacityResponse>(this, "POST", request, JsonUtils.DeSerialize<ListHyperinstanceClustersCapacityResponse>);
        }
        
        /// <summary>
        /// 查询用户所有超节点实例详情
        ///
        /// 查询用户所有超节点实例详情接口用于获取用户所有Lite Server超节点实例的详细信息。该接口适用于以下场景：当用户需要查看其所有超节点实例的配置、状态和使用情况时，可以通过此接口获取相关信息。使用该接口的前提条件是用户已登录并具有查询超节点实例的权限。查询操作完成后，接口将返回所有超节点实例的详细信息，包括实例ID、操作系统、运行状态、资源使用情况等。若用户无权限操作或没有超节点实例，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHyperinstancesResponse> ListHyperinstancesAsync(ListHyperinstancesRequest listHyperinstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHyperinstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHyperinstancesResponse>(response);
        }

        public AsyncInvoker<ListHyperinstancesResponse> ListHyperinstancesAsyncInvoker(ListHyperinstancesRequest listHyperinstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHyperinstancesRequest);
            return new AsyncInvoker<ListHyperinstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHyperinstancesResponse>);
        }
        
        /// <summary>
        /// 查询Lite Server超节点标签
        ///
        /// 查询Lite Server超节点标签接口用于获取Lite Server超节点上的所有标签信息。该接口适用于以下场景：当用户需要查看或管理Lite Server超节点的标签时，可以通过此接口查询指定超节点上的所有标签。使用该接口的前提条件是Lite Server超节点已存在，用户具有查询标签的权限。查询操作完成后，接口将返回超节点上的所有标签信息，包括标签名称和相关属性。若Lite Server超节点不存在或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<QueryHyperinstanceTagsResponse> QueryHyperinstanceTagsAsync(QueryHyperinstanceTagsRequest queryHyperinstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(queryHyperinstanceTagsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", queryHyperinstanceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<QueryHyperinstanceTagsResponse>(response);
        }

        public AsyncInvoker<QueryHyperinstanceTagsResponse> QueryHyperinstanceTagsAsyncInvoker(QueryHyperinstanceTagsRequest queryHyperinstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(queryHyperinstanceTagsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", queryHyperinstanceTagsRequest);
            return new AsyncInvoker<QueryHyperinstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<QueryHyperinstanceTagsResponse>);
        }
        
        /// <summary>
        /// 重启Lite Server实例
        ///
        /// 重启Lite Server实例接口用于重启正在运行的Lite Server实例。该接口适用于以下场景：当用户需要重启实例以应用配置更改、解决运行问题或进行系统维护时，可以通过此接口重启指定的Lite Server实例。使用该接口的前提条件是Lite Server实例已创建且处于运行状态，用户具有重启实例的权限。重启操作完成后，Lite Server实例将重新启动并进入运行状态，用户可以继续使用实例提供的服务。若Lite Server实例不存在、已处于停止状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RebootDevServerResponse> RebootDevServerAsync(RebootDevServerRequest rebootDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDevServerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RebootDevServerResponse>(response);
        }

        public AsyncInvoker<RebootDevServerResponse> RebootDevServerAsyncInvoker(RebootDevServerRequest rebootDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDevServerRequest);
            return new AsyncInvoker<RebootDevServerResponse>(this, "PUT", request, JsonUtils.DeSerialize<RebootDevServerResponse>);
        }
        
        /// <summary>
        /// 重装Lite Server服务器操作系统镜像
        ///
        /// 重装Lite Server服务器操作系统镜像接口用于重新安装Lite Server服务器的操作系统镜像。该接口适用于以下场景：当用户需要更新操作系统版本、修复系统故障或重新配置系统环境时，可以通过此接口重装指定的Lite Server服务器操作系统镜像。使用该接口的前提条件是Lite Server服务器已存在且处于停止状态，用户具有重装操作系统的权限。重装操作完成后，Lite Server服务器将安装新的操作系统镜像，并重新进入运行状态，若Lite Server服务器不存在、已处于运行状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReinstallDevServerOSResponse> ReinstallDevServerOSAsync(ReinstallDevServerOSRequest reinstallDevServerOSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reinstallDevServerOSRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallDevServerOSRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReinstallDevServerOSResponse>(response);
        }

        public AsyncInvoker<ReinstallDevServerOSResponse> ReinstallDevServerOSAsyncInvoker(ReinstallDevServerOSRequest reinstallDevServerOSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reinstallDevServerOSRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallDevServerOSRequest);
            return new AsyncInvoker<ReinstallDevServerOSResponse>(this, "POST", request, JsonUtils.DeSerialize<ReinstallDevServerOSResponse>);
        }
        
        /// <summary>
        /// 缩容Lite Server超节点
        ///
        /// 缩容Lite Server超节点接口用于减少Lite Server超节点的资源容量。该接口适用于以下场景：当用户需要降低Lite Server超节点的资源使用，以节省成本或优化资源分配时，可以通过此接口进行缩容。使用该接口的前提条件是用户已登录并具有缩容超节点的权限，且指定的超节点已存在且处于运行状态。缩容操作完成后，超节点的资源容量将根据指定的规格进行调整，用户可以立即使用减少后的资源。若用户无权限操作、指定的超节点不存在、超节点已处于最小容量或指定的缩容规格无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ScaleDownHyperinstanceResponse> ScaleDownHyperinstanceAsync(ScaleDownHyperinstanceRequest scaleDownHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scaleDownHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/live-scale-down", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", scaleDownHyperinstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ScaleDownHyperinstanceResponse>(response);
        }

        public AsyncInvoker<ScaleDownHyperinstanceResponse> ScaleDownHyperinstanceAsyncInvoker(ScaleDownHyperinstanceRequest scaleDownHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scaleDownHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/live-scale-down", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", scaleDownHyperinstanceRequest);
            return new AsyncInvoker<ScaleDownHyperinstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ScaleDownHyperinstanceResponse>);
        }
        
        /// <summary>
        /// 扩容Lite Server超节点
        ///
        /// 扩容Lite Server超节点接口用于增加Lite Server超节点的资源容量。该接口适用于以下场景：当用户需要提升Lite Server超节点的性能，以支持更多的负载或更大的数据处理需求时，可以通过此接口进行扩容。使用该接口的前提条件是用户已登录并具有扩容超节点的权限，且指定的超节点已存在且处于运行状态。扩容操作完成后，超节点的资源容量将根据指定的规格进行调整，用户可以立即使用增加的资源。若用户无权限操作、指定的超节点不存在、超节点已处于最大容量或指定的扩容规格无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ScaleUpHyperinstanceResponse> ScaleUpHyperinstanceAsync(ScaleUpHyperinstanceRequest scaleUpHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scaleUpHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/live-scale-up", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", scaleUpHyperinstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ScaleUpHyperinstanceResponse>(response);
        }

        public AsyncInvoker<ScaleUpHyperinstanceResponse> ScaleUpHyperinstanceAsyncInvoker(ScaleUpHyperinstanceRequest scaleUpHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scaleUpHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/live-scale-up", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", scaleUpHyperinstanceRequest);
            return new AsyncInvoker<ScaleUpHyperinstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ScaleUpHyperinstanceResponse>);
        }
        
        /// <summary>
        /// 查询Lite Server实例详情
        ///
        /// 查询Lite Server实例详情接口用于获取指定Lite Server实例的详细信息。该接口适用于以下场景：用户需要查看特定Lite Server实例的配置、状态、网络信息等详细数据，以便进行故障排查、资源管理和监控。使用该接口的前提条件是用户已登录且具有查看Lite Server实例的权限，并且需要提供有效的实例ID。查询操作完成后，系统将返回指定Lite Server实例的详细信息，包括实例ID、名称、状态、配置、网络配置等。若用户无权限、实例ID无效或实例不存在，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDevServerResponse> ShowDevServerAsync(ShowDevServerRequest showDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDevServerResponse>(response);
        }

        public AsyncInvoker<ShowDevServerResponse> ShowDevServerAsyncInvoker(ShowDevServerRequest showDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevServerRequest);
            return new AsyncInvoker<ShowDevServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDevServerResponse>);
        }
        
        /// <summary>
        /// 启动Lite Server实例
        ///
        /// 启动Lite Server实例接口用于启动已创建但未运行的Lite Server实例。该接口适用于以下场景：当用户需要开始使用Lite Server实例进行开发或测试时，可以通过此接口启动指定的Lite Server实例。使用该接口的前提条件是Lite Server实例已创建且处于停止状态，用户具有启动实例的权限。若Lite Server实例不存在、已处于运行状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartDevServerResponse> StartDevServerAsync(StartDevServerRequest startDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startDevServerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<StartDevServerResponse>(response);
        }

        public AsyncInvoker<StartDevServerResponse> StartDevServerAsyncInvoker(StartDevServerRequest startDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startDevServerRequest);
            return new AsyncInvoker<StartDevServerResponse>(this, "PUT", request, JsonUtils.DeSerialize<StartDevServerResponse>);
        }
        
        /// <summary>
        /// 启动Lite Server超节点服务器
        ///
        /// 启动Lite Server超节点服务器接口用于启动已创建但未运行的Lite Server超节点服务器。该接口适用于以下场景：当用户需要开始使用Lite Server超节点服务器进行开发或测试时，可以通过此接口启动指定的超节点服务器。使用该接口的前提条件是Lite Server超节点服务器已创建且处于停止状态，用户具有启动超节点服务器的权限。启动操作完成后，超节点服务器将进入运行状态，用户可以访问和使用服务器提供的服务。若Lite Server超节点服务器不存在、已处于运行状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartHyperinstanceResponse> StartHyperinstanceAsync(StartHyperinstanceRequest startHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startHyperinstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<StartHyperinstanceResponse>(response);
        }

        public AsyncInvoker<StartHyperinstanceResponse> StartHyperinstanceAsyncInvoker(StartHyperinstanceRequest startHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startHyperinstanceRequest);
            return new AsyncInvoker<StartHyperinstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<StartHyperinstanceResponse>);
        }
        
        /// <summary>
        /// 停止Lite Server实例
        ///
        /// 停止Lite Server实例接口用于停止正在运行的Lite Server实例。该接口适用于以下场景：当用户需要停止Lite Server实例，以节省资源或进行维护时，可以通过此接口停止指定的Lite Server实例。使用该接口的前提条件是Lite Server实例已创建且处于运行状态，用户具有停止实例的权限。若Lite Server实例不存在、已处于停止状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopDevServerResponse> StopDevServerAsync(StopDevServerRequest stopDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDevServerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<StopDevServerResponse>(response);
        }

        public AsyncInvoker<StopDevServerResponse> StopDevServerAsyncInvoker(StopDevServerRequest stopDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDevServerRequest);
            return new AsyncInvoker<StopDevServerResponse>(this, "PUT", request, JsonUtils.DeSerialize<StopDevServerResponse>);
        }
        
        /// <summary>
        /// 停止Lite Server超节点服务器
        ///
        /// 停止Lite Server超节点服务器接口用于停止正在运行的Lite Server超节点服务器。该接口适用于以下场景：当用户需要暂停使用Lite Server超节点服务器，以节省资源或进行维护时，可以通过此接口停止指定的超节点服务器。使用该接口的前提条件是Lite Server超节点服务器已创建且处于运行状态或者停止失败状态，用户具有停止超节点服务器的权限。停止操作完成后，超节点服务器将进入停止状态，不再提供服务。若Lite Server超节点服务器不存在、已处于停止状态或用户无权限操作，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopHyperinstanceResponse> StopHyperinstanceAsync(StopHyperinstanceRequest stopHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopHyperinstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<StopHyperinstanceResponse>(response);
        }

        public AsyncInvoker<StopHyperinstanceResponse> StopHyperinstanceAsyncInvoker(StopHyperinstanceRequest stopHyperinstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopHyperinstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/hyperinstance/{id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopHyperinstanceRequest);
            return new AsyncInvoker<StopHyperinstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<StopHyperinstanceResponse>);
        }
        
        /// <summary>
        /// 实时同步用户指定Lite Server实例状态
        ///
        /// 实时同步用户Lite Server实例状态接口用于实时获取并同步用户Lite Server实例的当前状态。该接口适用于以下场景：用户需要实时监控其Lite Server实例的运行状态，确保实例正常运行或及时发现并处理异常情况。使用该接口的前提条件是用户已登录并具有相应的权限，且Lite Server实例已创建并处于运行状态。接口调用成功后，将返回Lite Server实例的最新状态信息，包括但不限于实例ID、运行状态、资源使用情况等。若用户无权限操作或Lite Server实例不存在，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SyncDevServersResponse> SyncDevServersAsync(SyncDevServersRequest syncDevServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncDevServersRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SyncDevServersResponse>(response);
        }

        public AsyncInvoker<SyncDevServersResponse> SyncDevServersAsyncInvoker(SyncDevServersRequest syncDevServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncDevServersRequest);
            return new AsyncInvoker<SyncDevServersResponse>(this, "PUT", request, JsonUtils.DeSerialize<SyncDevServersResponse>);
        }
        
        /// <summary>
        /// 修改Lite Server实例名称
        ///
        /// 修改DevServer实例名称接口用于更改已创建的DevServer实例的名称。该接口适用于以下场景：当用户需要对DevServer实例进行重命名以更好地反映实例的功能或用途时，或者在实例名称不再符合当前项目命名规范时进行更新。使用该接口的前提条件是DevServer实例已存在且用户具有对该实例的管理权限。修改操作完成后，实例的新名称将立即生效，并在所有相关视图和记录中更新。若DevServer实例不存在、用户无权限操作或新名称不符合命名规则，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDevServerResponse> UpdateDevServerAsync(UpdateDevServerRequest updateDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDevServerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDevServerResponse>(response);
        }

        public AsyncInvoker<UpdateDevServerResponse> UpdateDevServerAsyncInvoker(UpdateDevServerRequest updateDevServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDevServerRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dev-servers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDevServerRequest);
            return new AsyncInvoker<UpdateDevServerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDevServerResponse>);
        }
        
        /// <summary>
        /// 通过运行的实例保存成容器镜像
        ///
        /// 通过运行的实例保存成容器镜像接口用于将正在运行的实例保存为容器镜像。该接口适用于以下场景：用户需要保存当前运行环境以便后续使用或开发时，可通过此接口将实例保存为镜像。使用该接口的前提条件是用户已登录系统并具有访问目标实例的权限，同时实例必须处于运行状态。调用该接口后，系统将保存实例的当前状态为容器镜像，包括安装的依赖包和插件。若用户无权限访问指定实例或实例未运行，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest createImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImageRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/create-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateImageResponse>(response);
        }

        public AsyncInvoker<CreateImageResponse> CreateImageAsyncInvoker(CreateImageRequest createImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImageRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/create-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageRequest);
            return new AsyncInvoker<CreateImageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateImageResponse>);
        }
        
        /// <summary>
        /// 创建Notebook实例
        ///
        /// 创建Notebook实例接口用于根据指定的参数创建一个新的Notebook实例。该接口适用于以下场景：用户需要为特定任务或项目创建Notebook实例时，可通过此接口指定实例规格、AI引擎镜像和存储配置。使用该接口的前提条件是用户已登录系统并具有创建Notebook实例的权限，同时需提供有效的创建参数。调用该接口后，系统将异步创建Notebook实例，用户可通过查询接口获取实例状态。创建完成后，用户可通过网页或SSH客户端访问Notebook实例。若用户无权限创建实例或参数无效，接口将返回相应的错误信息。异常情况包括：若系统资源不足，或创建操作失败，接口将返回相应的错误提示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNotebookResponse> CreateNotebookAsync(CreateNotebookRequest createNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotebookRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNotebookResponse>(response);
        }

        public AsyncInvoker<CreateNotebookResponse> CreateNotebookAsyncInvoker(CreateNotebookRequest createNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotebookRequest);
            return new AsyncInvoker<CreateNotebookResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNotebookResponse>);
        }
        
        /// <summary>
        /// 添加资源标签
        ///
        /// 添加资源标签接口用于为指定的Notebook实例添加标签信息。该接口适用于以下场景：用户需要为Notebook实例添加标签信息，可通过此接口添加一个或多个标签。使用该接口的前提条件是用户已登录系统并具有操作目标Notebook实例的权限。调用该接口后，系统将为指定的Notebook实例添加标签，若标签的key已存在，则覆盖原有的value值。若用户无权限操作指定Notebook实例或输入的参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNotebookTagsResponse> CreateNotebookTagsAsync(CreateNotebookTagsRequest createNotebookTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNotebookTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotebookTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNotebookTagsResponse>(response);
        }

        public AsyncInvoker<CreateNotebookTagsResponse> CreateNotebookTagsAsyncInvoker(CreateNotebookTagsRequest createNotebookTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNotebookTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotebookTagsRequest);
            return new AsyncInvoker<CreateNotebookTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateNotebookTagsResponse>);
        }
        
        /// <summary>
        /// 删除Notebook实例
        ///
        /// 删除Notebook实例接口用于移除已创建的Notebook实例及其相关资源。该接口适用于以下场景：用户需要清理不再使用的Notebook实例时，可通过此接口删除指定的Notebook实例，包括其容器和所有存储资源。使用该接口的前提条件是用户已登录系统并具有操作目标Notebook实例的权限。调用该接口后，系统将删除指定的Notebook实例及其相关资源。若用户无权限操作指定实例或Notebook实例未停止，接口将返回相应的错误信息。异常情况包括：若指定的Notebook实例不存在，或删除操作失败，接口将返回相应的错误提示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNotebookResponse> DeleteNotebookAsync(DeleteNotebookRequest deleteNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotebookRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNotebookResponse>(response);
        }

        public AsyncInvoker<DeleteNotebookResponse> DeleteNotebookAsyncInvoker(DeleteNotebookRequest deleteNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotebookRequest);
            return new AsyncInvoker<DeleteNotebookResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNotebookResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签接口用于移除指定Notebook实例的标签信息。该接口适用于以下场景：用户需要清理或重新组织Notebook实例的标签时，可通过此接口删除单个或多个标签。使用该接口的前提条件是用户已登录系统并具有操作目标Notebook实例的权限。调用该接口后，系统将删除指定的标签，若标签不存在则不进行操作。若用户无权限操作指定Notebook实例或输入的参数无效，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNotebookTagsResponse> DeleteNotebookTagsAsync(DeleteNotebookTagsRequest deleteNotebookTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNotebookTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotebookTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNotebookTagsResponse>(response);
        }

        public AsyncInvoker<DeleteNotebookTagsResponse> DeleteNotebookTagsAsyncInvoker(DeleteNotebookTagsRequest deleteNotebookTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNotebookTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotebookTagsRequest);
            return new AsyncInvoker<DeleteNotebookTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNotebookTagsResponse>);
        }
        
        /// <summary>
        /// 查询所有Notebook实例列表
        ///
        /// 查询所有Notebook实例列表接口用于获取所有已创建的Notebook实例信息。该接口适用于以下场景：用户需要全面了解当前系统中所有Notebook实例的状态、资源使用情况或管理多个Notebook实例时，可通过此接口获取相关信息。使用该接口的前提条件是用户已创建Notebook实例，并且具有相应的查询权限。调用成功后，系统将返回所有Notebook实例的列表，包含实例ID、状态、创建时间等详细信息。若用户无权限访问，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllNotebooksResponse> ListAllNotebooksAsync(ListAllNotebooksRequest listAllNotebooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllNotebooksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllNotebooksResponse>(response);
        }

        public AsyncInvoker<ListAllNotebooksResponse> ListAllNotebooksAsyncInvoker(ListAllNotebooksRequest listAllNotebooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllNotebooksRequest);
            return new AsyncInvoker<ListAllNotebooksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllNotebooksResponse>);
        }
        
        /// <summary>
        /// 查询用户所有Notebook资源池实例详情
        ///
        /// 查询用户所有Notebook资源池实例详情接口用于获取用户关联的所有Notebook资源池实例的详细信息。该接口适用于以下场景：当用户创建Notebook示例需要选择资源池时，可通过此接口获取所有资源池实例列表信息。使用该接口的前提条件是用户已注册并登录系统，且具有查看资源池实例的权限。调用成功后，接口将返回包含所有资源池实例的详细信息列表，包括实例名称、状态、节点规格等。若用户未登录、无权限访问或系统内部出现错误，接口将返回相应的错误信息，如未认证、无权限或服务不可用等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuthoringClustersResponse> ListAuthoringClustersAsync(ListAuthoringClustersRequest listAuthoringClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authoring/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthoringClustersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuthoringClustersResponse>(response);
        }

        public AsyncInvoker<ListAuthoringClustersResponse> ListAuthoringClustersAsyncInvoker(ListAuthoringClustersRequest listAuthoringClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authoring/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthoringClustersRequest);
            return new AsyncInvoker<ListAuthoringClustersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthoringClustersResponse>);
        }
        
        /// <summary>
        /// 查询当前用户指定特性的开关及配额
        ///
        /// 查询当前用户指定特性的开关及配额接口用于获取指定特性在当前用户下的开关状态及配额信息。该接口适用于以下场景：当用户需要了解特定特性是否已开启、查看配额限制或监控已使用的资源情况时，可通过此接口查询相关信息。使用该接口的前提条件是用户已登录且具有查询权限，同时指定的特性必须存在。调用该接口后，系统将返回该特性是否已开启、配额总量及已使用的资源情况等详细信息。若用户无权限查询、特性不存在或系统出现异常，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFeaturesResponse> ListFeaturesAsync(ListFeaturesRequest listFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFeaturesRequest.Feature, out var valueOfFeature)) urlParam.Add("feature", valueOfFeature);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authoring/features/{feature}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeaturesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFeaturesResponse>(response);
        }

        public AsyncInvoker<ListFeaturesResponse> ListFeaturesAsyncInvoker(ListFeaturesRequest listFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFeaturesRequest.Feature, out var valueOfFeature)) urlParam.Add("feature", valueOfFeature);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authoring/features/{feature}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeaturesRequest);
            return new AsyncInvoker<ListFeaturesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFeaturesResponse>);
        }
        
        /// <summary>
        /// 查询Notebook支持的有效规格列表
        ///
        /// 查询Notebook支持的有效规格列表接口用于获取运行Notebook实例时可使用的规格选项。该接口适用于以下场景：用户需要了解Notebook实例支持的配置选项时，可通过此接口查询可用的规格列表。使用该接口的前提条件是用户已登录系统并具有访问目标Notebook实例的权限。调用该接口后，系统将返回Notebook实例支持的有效规格列表，包括内存、CPU等配置信息。若用户无权限访问指定实例或Notebook实例未运行，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public AsyncInvoker<ListFlavorsResponse> ListFlavorsAsyncInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new AsyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询Notebook实例列表
        ///
        /// 查询Notebook实例列表接口用于获取满足特定条件的Notebook实例信息。该接口适用于以下场景：用户管理多个Notebook实例或查看特定状态的Notebook实例时，可通过此接口获取相关信息。使用该接口的前提条件是用户已创建Notebook实例，并且具有相应的查询权限。调用成功后，系统将返回符合条件的Notebook实例列表，包含实例ID、状态、创建时间等详细信息。若用户无权限访问或查询条件不明确，接口将返回相应的错误信息或空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotebooksResponse> ListNotebooksAsync(ListNotebooksRequest listNotebooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotebooksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNotebooksResponse>(response);
        }

        public AsyncInvoker<ListNotebooksResponse> ListNotebooksAsyncInvoker(ListNotebooksRequest listNotebooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotebooksRequest);
            return new AsyncInvoker<ListNotebooksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotebooksResponse>);
        }
        
        /// <summary>
        /// Notebook时长续约
        ///
        /// Notebook时长续约接口用于延长运行中的Notebook实例的运行时间。该接口适用于以下场景：用户需要延长Notebook实例的使用时间以完成长时间任务时，可通过此接口延长指定实例的运行时间。使用该接口的前提条件是用户已登录系统并具有操作目标Notebook实例的权限，同时Notebook实例必须处于运行状态。调用该接口后，系统将延长指定Notebook实例的运行时间，用户可继续使用。若用户无权限操作指定实例或Notebook实例未运行，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RenewLeaseResponse> RenewLeaseAsync(RenewLeaseRequest renewLeaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(renewLeaseRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/lease", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renewLeaseRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<RenewLeaseResponse>(response);
        }

        public AsyncInvoker<RenewLeaseResponse> RenewLeaseAsyncInvoker(RenewLeaseRequest renewLeaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(renewLeaseRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/lease", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renewLeaseRequest);
            return new AsyncInvoker<RenewLeaseResponse>(this, "PATCH", request, JsonUtils.DeSerialize<RenewLeaseResponse>);
        }
        
        /// <summary>
        /// 查询Notebook资源池详情
        ///
        /// 查询Notebook资源池详情接口用于获取资源池的详细信息。该接口适用于以下场景：当用户需要创建Notebook实例作业时，可通过此接口查询指定集群的详细信息。使用该接口的前提条件是集群已成功纳管且用户具有相应的访问权限。调用该接口后，系统将返回集群的实例ID、名称、Flavor规格、实例状态以及实例可打开的URL等详细信息。若集群不存在、未被纳管或用户无权限访问，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterResponse> ShowClusterAsync(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authoring/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }

        public AsyncInvoker<ShowClusterResponse> ShowClusterAsyncInvoker(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authoring/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            return new AsyncInvoker<ShowClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterResponse>);
        }
        
        /// <summary>
        /// 查询运行中的Notebook可用时长
        ///
        /// 查询运行中的Notebook可用时长接口用于获取正在运行的Notebook实例的剩余可用时间。该接口适用于以下场景：用户需要了解Notebook实例的剩余运行时间以合理安排任务时，可通过此接口查询指定实例的可用时长。使用该接口的前提条件是用户已登录系统并具有访问目标Notebook实例的权限，同时Notebook实例必须处于运行状态。调用该接口后，系统将返回指定Notebook实例的可用时长信息。若用户无权限访问指定实例或Notebook实例未运行，接口将返回相应的错误信息。异常情况包括：若指定的Notebook实例不存在，或查询操作失败，接口将返回相应的错误提示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLeaseResponse> ShowLeaseAsync(ShowLeaseRequest showLeaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLeaseRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/lease", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLeaseRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLeaseResponse>(response);
        }

        public AsyncInvoker<ShowLeaseResponse> ShowLeaseAsyncInvoker(ShowLeaseRequest showLeaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLeaseRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/lease", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLeaseRequest);
            return new AsyncInvoker<ShowLeaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLeaseResponse>);
        }
        
        /// <summary>
        /// 查询Notebook实例详情
        ///
        /// 查询Notebook实例详情接口用于获取指定Notebook实例的详细信息。该接口适用于以下场景：用户需要查看特定Notebook实例的详细配置、运行状态或获取访问链接时，可通过此接口获取相关信息。使用该接口的前提条件是Notebook实例已存在且用户具有相应的查询权限。调用成功后，系统将返回实例ID、名称、规格、镜像、实例状态和实例可打开的URL等详细信息。若实例不存在或用户无权限访问，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNotebookResponse> ShowNotebookAsync(ShowNotebookRequest showNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotebookRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNotebookResponse>(response);
        }

        public AsyncInvoker<ShowNotebookResponse> ShowNotebookAsyncInvoker(ShowNotebookRequest showNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotebookRequest);
            return new AsyncInvoker<ShowNotebookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotebookResponse>);
        }
        
        /// <summary>
        /// 查询Notebook资源类型下的标签
        ///
        /// 查询Notebook资源类型下的标签接口用于获取用户当前project下Notebook实例的标签信息。该接口适用于以下场景：用户需要管理或统计Notebook资源时，可通过此接口查询特定标签或所有标签的Notebook实例。使用该接口的前提条件是用户已登录系统并具有访问权限，同时可指定工作空间或默认查询所有工作空间。调用该接口后，系统将返回指定Notebook实例的标签列表，包括标签名称、标签值等信息。若用户无权限，则返回相应的异常信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNotebookTagsResponse> ShowNotebookTagsAsync(ShowNotebookTagsRequest showNotebookTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotebookTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNotebookTagsResponse>(response);
        }

        public AsyncInvoker<ShowNotebookTagsResponse> ShowNotebookTagsAsyncInvoker(ShowNotebookTagsRequest showNotebookTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotebookTagsRequest);
            return new AsyncInvoker<ShowNotebookTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotebookTagsResponse>);
        }
        
        /// <summary>
        /// 查询Notebook支持的可切换规格列表
        ///
        /// 查询Notebook支持的可切换规格列表接口用于获取创建Notebook实例时可选择的规格选项。该接口适用于以下场景：用户需要了解Notebook实例支持的配置选项时，可通过此接口查询可用的规格列表。使用该接口的前提条件是用户已登录系统并具有创建Notebook实例的权限。调用该接口后，系统将返回Notebook实例支持的可切换规格列表，包括内存、CPU等配置信息。若用户无权限创建Notebook实例，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSwitchableFlavorsResponse> ShowSwitchableFlavorsAsync(ShowSwitchableFlavorsRequest showSwitchableFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSwitchableFlavorsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSwitchableFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSwitchableFlavorsResponse>(response);
        }

        public AsyncInvoker<ShowSwitchableFlavorsResponse> ShowSwitchableFlavorsAsyncInvoker(ShowSwitchableFlavorsRequest showSwitchableFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSwitchableFlavorsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSwitchableFlavorsRequest);
            return new AsyncInvoker<ShowSwitchableFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSwitchableFlavorsResponse>);
        }
        
        /// <summary>
        /// 启动Notebook实例
        ///
        /// 启动Notebook实例接口用于启动已创建的Notebook实例。该接口适用于以下场景：用户需要开始运行Notebook实例以进行数据处理、模型训练或开发时，可通过此接口启动指定的Notebook实例。使用该接口的前提条件是用户已登录系统并具有操作目标Notebook实例的权限，同时Notebook实例必须处于停止状态且配置正确。调用该接口后，系统将启动指定的Notebook实例，用户可开始使用。若用户无权限操作指定实例或Notebook实例未停止，接口将返回相应的错误信息。异常情况包括：若指定的Notebook实例不存在，或启动操作失败，接口将返回相应的错误提示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartNotebookResponse> StartNotebookAsync(StartNotebookRequest startNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startNotebookRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartNotebookResponse>(response);
        }

        public AsyncInvoker<StartNotebookResponse> StartNotebookAsyncInvoker(StartNotebookRequest startNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startNotebookRequest);
            return new AsyncInvoker<StartNotebookResponse>(this, "POST", request, JsonUtils.DeSerialize<StartNotebookResponse>);
        }
        
        /// <summary>
        /// 停止Notebook实例
        ///
        /// 停止Notebook实例接口用于停止正在运行的Notebook实例。该接口适用于以下场景：用户需要释放Notebook实例占用的资源或结束当前运行的任务时，可通过此接口停止指定的Notebook实例。使用该接口的前提条件是用户已登录系统并具有操作目标Notebook实例的权限，同时Notebook实例必须处于运行状态。调用该接口后，系统将停止指定的Notebook实例，释放相关资源。若用户无权限操作指定实例或Notebook实例未运行，接口将返回相应的错误信息。异常情况包括：若指定的Notebook实例不存在，或停止操作失败，接口将返回相应的错误提示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopNotebookResponse> StopNotebookAsync(StopNotebookRequest stopNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopNotebookRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopNotebookResponse>(response);
        }

        public AsyncInvoker<StopNotebookResponse> StopNotebookAsyncInvoker(StopNotebookRequest stopNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopNotebookRequest);
            return new AsyncInvoker<StopNotebookResponse>(this, "POST", request, JsonUtils.DeSerialize<StopNotebookResponse>);
        }
        
        /// <summary>
        /// 更新Notebook实例
        ///
        /// 更新Notebook实例接口用于修改Notebook实例的配置信息，包括名称、描述、规格和镜像等。该接口适用于以下场景：用户需要调整Notebook实例的配置以适应新的需求时，可通过此接口更新实例的详细信息。使用该接口的前提条件是用户已登录系统并具有操作目标Notebook实例的权限，同时Notebook实例必须处于停止状态。调用该接口后，系统将更新指定Notebook实例的配置信息。若用户无权限操作指定实例或Notebook实例未停止，接口将返回相应的错误信息。异常情况包括：若指定的Notebook实例不存在，或更新参数无效，接口将返回相应的错误提示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNotebookResponse> UpdateNotebookAsync(UpdateNotebookRequest updateNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotebookRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNotebookResponse>(response);
        }

        public AsyncInvoker<UpdateNotebookResponse> UpdateNotebookAsyncInvoker(UpdateNotebookRequest updateNotebookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotebookRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notebooks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotebookRequest);
            return new AsyncInvoker<UpdateNotebookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNotebookResponse>);
        }
        
        /// <summary>
        /// 新建Workflow工作流
        ///
        /// 创建Workflow工作流。[可参考[如何开发Workflow](https://support.huaweicloud.com/usermanual-standard-modelarts/modelarts_workflow_0292.html)，创建工作流。](tag:hc)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest createWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowResponse> CreateWorkflowAsyncInvoker(CreateWorkflowRequest createWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowRequest);
            return new AsyncInvoker<CreateWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowResponse>);
        }
        
        /// <summary>
        /// 创建在线服务包
        ///
        /// 计费工作流购买资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowPurchasePoolResponse> CreateWorkflowPurchasePoolAsync(CreateWorkflowPurchasePoolRequest createWorkflowPurchasePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowPurchasePoolRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/service/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowPurchasePoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowPurchasePoolResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowPurchasePoolResponse> CreateWorkflowPurchasePoolAsyncInvoker(CreateWorkflowPurchasePoolRequest createWorkflowPurchasePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowPurchasePoolRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/service/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowPurchasePoolRequest);
            return new AsyncInvoker<CreateWorkflowPurchasePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowPurchasePoolResponse>);
        }
        
        /// <summary>
        /// 在线服务鉴权
        ///
        /// 计费工作流在线服务鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowServiceAuthResponse> CreateWorkflowServiceAuthAsync(CreateWorkflowServiceAuthRequest createWorkflowServiceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/service/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowServiceAuthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowServiceAuthResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowServiceAuthResponse> CreateWorkflowServiceAuthAsyncInvoker(CreateWorkflowServiceAuthRequest createWorkflowServiceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/service/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowServiceAuthRequest);
            return new AsyncInvoker<CreateWorkflowServiceAuthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowServiceAuthResponse>);
        }
        
        /// <summary>
        /// 删除Workflow工作流
        ///
        /// 通过ID删除Workflow工作流。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest deleteWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkflowRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWorkflowResponse>(response);
        }

        public AsyncInvoker<DeleteWorkflowResponse> DeleteWorkflowAsyncInvoker(DeleteWorkflowRequest deleteWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkflowRequest);
            return new AsyncInvoker<DeleteWorkflowResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWorkflowResponse>);
        }
        
        /// <summary>
        /// 获取Workflow工作流列表
        ///
        /// 展示Workflow工作流列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest listWorkflowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWorkflowsResponse>(response);
        }

        public AsyncInvoker<ListWorkflowsResponse> ListWorkflowsAsyncInvoker(ListWorkflowsRequest listWorkflowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowsRequest);
            return new AsyncInvoker<ListWorkflowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkflowsResponse>);
        }
        
        /// <summary>
        /// 查询Workflow工作流
        ///
        /// 通过ID查询Workflow工作流详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowResponse> ShowWorkflowAsync(ShowWorkflowRequest showWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowResponse> ShowWorkflowAsyncInvoker(ShowWorkflowRequest showWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowRequest);
            return new AsyncInvoker<ShowWorkflowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowResponse>);
        }
        
        /// <summary>
        /// Workflow列表所有标签
        ///
        /// Workflow列表所有标签接口用于获取指定项目下所有工作流的标签信息。
        /// 该接口适用于以下场景：当用户需要了解项目中所有工作流的标签配置，以便进行资源管理和筛选时，可以通过此接口获取标签列表。使用该接口的前提条件是用户已登录并具有查看工作流标签的权限。响应消息体中包含每个工作流的标签信息，如标签键和值。若用户无权限或项目下无工作流，接口将返回相应的错误信息或空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowLabelsResponse> ShowWorkflowLabelsAsync(ShowWorkflowLabelsRequest showWorkflowLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowLabelsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showWorkflowLabelsResponse = JsonUtils.DeSerializeNull<ShowWorkflowLabelsResponse>(response);
            showWorkflowLabelsResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return showWorkflowLabelsResponse;
        }

        public AsyncInvoker<ShowWorkflowLabelsResponse> ShowWorkflowLabelsAsyncInvoker(ShowWorkflowLabelsRequest showWorkflowLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowLabelsRequest);
            return new AsyncInvoker<ShowWorkflowLabelsResponse>(this, "GET", request, response =>
            {
                var showWorkflowLabelsResponse = JsonUtils.DeSerializeNull<ShowWorkflowLabelsResponse>(response);
                showWorkflowLabelsResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return showWorkflowLabelsResponse;
            });
        }
        
        /// <summary>
        /// 总览Workflow工作流
        ///
        /// 获取Workflow工作流统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowsOverviewResponse> ShowWorkflowsOverviewAsync(ShowWorkflowsOverviewRequest showWorkflowsOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowsOverviewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowsOverviewResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowsOverviewResponse> ShowWorkflowsOverviewAsyncInvoker(ShowWorkflowsOverviewRequest showWorkflowsOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowsOverviewRequest);
            return new AsyncInvoker<ShowWorkflowsOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowsOverviewResponse>);
        }
        
        /// <summary>
        /// 查询Workflow待办事项
        ///
        /// 获取Workflow待办列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowsTodolistResponse> ShowWorkflowsTodolistAsync(ShowWorkflowsTodolistRequest showWorkflowsTodolistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/todolist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowsTodolistRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowsTodolistResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowsTodolistResponse> ShowWorkflowsTodolistAsyncInvoker(ShowWorkflowsTodolistRequest showWorkflowsTodolistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/todolist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowsTodolistRequest);
            return new AsyncInvoker<ShowWorkflowsTodolistResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowsTodolistResponse>);
        }
        
        /// <summary>
        /// 修改Workflow工作流
        ///
        /// 更新Workflow工作流信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest updateWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkflowRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkflowResponse>(response);
        }

        public AsyncInvoker<UpdateWorkflowResponse> UpdateWorkflowAsyncInvoker(UpdateWorkflowRequest updateWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkflowRequest);
            return new AsyncInvoker<UpdateWorkflowResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkflowResponse>);
        }
        
        /// <summary>
        /// 新建Workflow Execution
        ///
        /// 创建Workflow Execution。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowExecutionResponse> CreateWorkflowExecutionAsync(CreateWorkflowExecutionRequest createWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowExecutionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowExecutionResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowExecutionResponse> CreateWorkflowExecutionAsyncInvoker(CreateWorkflowExecutionRequest createWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowExecutionRequest);
            return new AsyncInvoker<CreateWorkflowExecutionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 管理Workflow Execution
        ///
        /// 本接口支持对Workflow Execution进行停止或重跑操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowExecutionsActionsResponse> CreateWorkflowExecutionsActionsAsync(CreateWorkflowExecutionsActionsRequest createWorkflowExecutionsActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowExecutionsActionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowExecutionsActionsRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowExecutionsActionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowExecutionsActionsResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowExecutionsActionsResponse> CreateWorkflowExecutionsActionsAsyncInvoker(CreateWorkflowExecutionsActionsRequest createWorkflowExecutionsActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowExecutionsActionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowExecutionsActionsRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowExecutionsActionsRequest);
            return new AsyncInvoker<CreateWorkflowExecutionsActionsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowExecutionsActionsResponse>);
        }
        
        /// <summary>
        /// 管理Workflow StepExecution
        ///
        /// 本接口支持对Workflow StepExecution进行重试、停止和继续操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowStepExecutionsActionsResponse> CreateWorkflowStepExecutionsActionsAsync(CreateWorkflowStepExecutionsActionsRequest createWorkflowStepExecutionsActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowStepExecutionsActionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowStepExecutionsActionsRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowStepExecutionsActionsRequest.StepExecutionId, out var valueOfStepExecutionId)) urlParam.Add("step_execution_id", valueOfStepExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}/step-executions/{step_execution_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowStepExecutionsActionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowStepExecutionsActionsResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowStepExecutionsActionsResponse> CreateWorkflowStepExecutionsActionsAsyncInvoker(CreateWorkflowStepExecutionsActionsRequest createWorkflowStepExecutionsActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowStepExecutionsActionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowStepExecutionsActionsRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowStepExecutionsActionsRequest.StepExecutionId, out var valueOfStepExecutionId)) urlParam.Add("step_execution_id", valueOfStepExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}/step-executions/{step_execution_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowStepExecutionsActionsRequest);
            return new AsyncInvoker<CreateWorkflowStepExecutionsActionsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowStepExecutionsActionsResponse>);
        }
        
        /// <summary>
        /// 删除Workflow Execution
        ///
        /// 通过ID删除Workflow Execution。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWorkflowExecutionResponse> DeleteWorkflowExecutionAsync(DeleteWorkflowExecutionRequest deleteWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkflowExecutionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWorkflowExecutionResponse>(response);
        }

        public AsyncInvoker<DeleteWorkflowExecutionResponse> DeleteWorkflowExecutionAsyncInvoker(DeleteWorkflowExecutionRequest deleteWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkflowExecutionRequest);
            return new AsyncInvoker<DeleteWorkflowExecutionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 获取Workflow Execution列表的所有标签
        ///
        /// 获取Workflow Execution列表的所有标签接口用于查询指定工作流执行记录中的所有标签。
        /// 该接口适用于以下场景：当用户需要查看工作流执行记录的标签信息，以便进行分类、筛选或统计时，可以通过此接口获取所有标签的列表。使用该接口的前提条件是用户已登录且具有查看工作流执行记录的权限。接口响应消息体中包含每个标签的详细信息，如标签键和标签值。若用户无权限操作或指定的工作流执行记录不存在，接口将返回相应的错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExecutionLabelsResponse> ListExecutionLabelsAsync(ListExecutionLabelsRequest listExecutionLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExecutionLabelsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExecutionLabelsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listExecutionLabelsResponse = JsonUtils.DeSerializeNull<ListExecutionLabelsResponse>(response);
            listExecutionLabelsResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listExecutionLabelsResponse;
        }

        public AsyncInvoker<ListExecutionLabelsResponse> ListExecutionLabelsAsyncInvoker(ListExecutionLabelsRequest listExecutionLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExecutionLabelsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExecutionLabelsRequest);
            return new AsyncInvoker<ListExecutionLabelsResponse>(this, "GET", request, response =>
            {
                var listExecutionLabelsResponse = JsonUtils.DeSerializeNull<ListExecutionLabelsResponse>(response);
                listExecutionLabelsResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listExecutionLabelsResponse;
            });
        }
        
        /// <summary>
        /// 获取Execution列表
        ///
        /// 查询Workflow下的执行记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkflowExecutionsResponse> ListWorkflowExecutionsAsync(ListWorkflowExecutionsRequest listWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWorkflowExecutionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWorkflowExecutionsResponse>(response);
        }

        public AsyncInvoker<ListWorkflowExecutionsResponse> ListWorkflowExecutionsAsyncInvoker(ListWorkflowExecutionsRequest listWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWorkflowExecutionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            return new AsyncInvoker<ListWorkflowExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkflowExecutionsResponse>);
        }
        
        /// <summary>
        /// 获取StepExecution列表
        ///
        /// 查询指定工作流中各步骤的执行情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkflowStepExecutionResponse> ListWorkflowStepExecutionAsync(ListWorkflowStepExecutionRequest listWorkflowStepExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWorkflowStepExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/step-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowStepExecutionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWorkflowStepExecutionResponse>(response);
        }

        public AsyncInvoker<ListWorkflowStepExecutionResponse> ListWorkflowStepExecutionAsyncInvoker(ListWorkflowStepExecutionRequest listWorkflowStepExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWorkflowStepExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/step-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowStepExecutionRequest);
            return new AsyncInvoker<ListWorkflowStepExecutionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkflowStepExecutionResponse>);
        }
        
        /// <summary>
        /// 查询Workflow Execution
        ///
        /// 通过ID查询Workflow Execution详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowExecutionResponse> ShowWorkflowExecutionAsync(ShowWorkflowExecutionRequest showWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowExecutionResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowExecutionResponse> ShowWorkflowExecutionAsyncInvoker(ShowWorkflowExecutionRequest showWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionRequest);
            return new AsyncInvoker<ShowWorkflowExecutionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 获取Workflow工作流节点度量信息
        ///
        /// 获取Workflow工作流节点的度量信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowStepExecutionMetricsResponse> ShowWorkflowStepExecutionMetricsAsync(ShowWorkflowStepExecutionMetricsRequest showWorkflowStepExecutionMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowStepExecutionMetricsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowStepExecutionMetricsRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowStepExecutionMetricsRequest.StepExecutionId, out var valueOfStepExecutionId)) urlParam.Add("step_execution_id", valueOfStepExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}/step-executions/{step_execution_id}/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowStepExecutionMetricsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showWorkflowStepExecutionMetricsResponse = JsonUtils.DeSerializeNull<ShowWorkflowStepExecutionMetricsResponse>(response);
            showWorkflowStepExecutionMetricsResponse.Body = JsonUtils.DeSerializeList<WorkflowStepMetric>(response);
            return showWorkflowStepExecutionMetricsResponse;
        }

        public AsyncInvoker<ShowWorkflowStepExecutionMetricsResponse> ShowWorkflowStepExecutionMetricsAsyncInvoker(ShowWorkflowStepExecutionMetricsRequest showWorkflowStepExecutionMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowStepExecutionMetricsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowStepExecutionMetricsRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowStepExecutionMetricsRequest.StepExecutionId, out var valueOfStepExecutionId)) urlParam.Add("step_execution_id", valueOfStepExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}/step-executions/{step_execution_id}/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowStepExecutionMetricsRequest);
            return new AsyncInvoker<ShowWorkflowStepExecutionMetricsResponse>(this, "GET", request, response =>
            {
                var showWorkflowStepExecutionMetricsResponse = JsonUtils.DeSerializeNull<ShowWorkflowStepExecutionMetricsResponse>(response);
                showWorkflowStepExecutionMetricsResponse.Body = JsonUtils.DeSerializeList<WorkflowStepMetric>(response);
                return showWorkflowStepExecutionMetricsResponse;
            });
        }
        
        /// <summary>
        /// 更新Workflow Execution
        ///
        /// 通过ID更新Workflow Exectuion。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWorkflowExecutionResponse> UpdateWorkflowExecutionAsync(UpdateWorkflowExecutionRequest updateWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkflowExecutionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkflowExecutionResponse>(response);
        }

        public AsyncInvoker<UpdateWorkflowExecutionResponse> UpdateWorkflowExecutionAsyncInvoker(UpdateWorkflowExecutionRequest updateWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkflowExecutionRequest);
            return new AsyncInvoker<UpdateWorkflowExecutionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 创建工作流定时调度
        ///
        /// 创建Workflow定时调度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowScheduleResponse> CreateWorkflowScheduleAsync(CreateWorkflowScheduleRequest createWorkflowScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowScheduleRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowScheduleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowScheduleResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowScheduleResponse> CreateWorkflowScheduleAsyncInvoker(CreateWorkflowScheduleRequest createWorkflowScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowScheduleRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowScheduleRequest);
            return new AsyncInvoker<CreateWorkflowScheduleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowScheduleResponse>);
        }
        
        /// <summary>
        /// 删除工作流定时调度信息
        ///
        /// 删除工作流调度信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWorkflowScheduleIdResponse> DeleteWorkflowScheduleIdAsync(DeleteWorkflowScheduleIdRequest deleteWorkflowScheduleIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowScheduleIdRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowScheduleIdRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkflowScheduleIdRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWorkflowScheduleIdResponse>(response);
        }

        public AsyncInvoker<DeleteWorkflowScheduleIdResponse> DeleteWorkflowScheduleIdAsyncInvoker(DeleteWorkflowScheduleIdRequest deleteWorkflowScheduleIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowScheduleIdRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowScheduleIdRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkflowScheduleIdRequest);
            return new AsyncInvoker<DeleteWorkflowScheduleIdResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWorkflowScheduleIdResponse>);
        }
        
        /// <summary>
        /// 查询工作流定时调度详情
        ///
        /// 查询工作流调度详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowScheduleResponse> ShowWorkflowScheduleAsync(ShowWorkflowScheduleRequest showWorkflowScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowScheduleRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowScheduleRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowScheduleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowScheduleResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowScheduleResponse> ShowWorkflowScheduleAsyncInvoker(ShowWorkflowScheduleRequest showWorkflowScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowScheduleRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowScheduleRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowScheduleRequest);
            return new AsyncInvoker<ShowWorkflowScheduleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowScheduleResponse>);
        }
        
        /// <summary>
        /// 查询工作流定时调度列表
        ///
        /// 查询工作流定时调度列表接口用于获取指定项目下所有工作流的定时调度信息。
        /// 该接口适用于以下场景：当用户需要查看项目中所有工作流的定时调度配置，以便进行任务管理和调度优化时，可以通过此接口获取定时调度列表。使用该接口的前提条件是用户已登录并具有查看工作流定时调度的权限。响应消息体中包含每个工作流的定时调度信息，如调度ID、调度时间、状态等。若用户无权限或项目下无工作流定时调度，接口将返回相应的错误信息或空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowScheduleListResponse> ShowWorkflowScheduleListAsync(ShowWorkflowScheduleListRequest showWorkflowScheduleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowScheduleListRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowScheduleListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowScheduleListResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowScheduleListResponse> ShowWorkflowScheduleListAsyncInvoker(ShowWorkflowScheduleListRequest showWorkflowScheduleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowScheduleListRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowScheduleListRequest);
            return new AsyncInvoker<ShowWorkflowScheduleListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowScheduleListResponse>);
        }
        
        /// <summary>
        /// 更新工作流定时调度信息
        ///
        /// 更新WorkflowSchedule信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWorkflowScheduleResponse> UpdateWorkflowScheduleAsync(UpdateWorkflowScheduleRequest updateWorkflowScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowScheduleRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowScheduleRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkflowScheduleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkflowScheduleResponse>(response);
        }

        public AsyncInvoker<UpdateWorkflowScheduleResponse> UpdateWorkflowScheduleAsyncInvoker(UpdateWorkflowScheduleRequest updateWorkflowScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowScheduleRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowScheduleRequest.ScheduleId, out var valueOfScheduleId)) urlParam.Add("schedule_id", valueOfScheduleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/schedules/{schedule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkflowScheduleRequest);
            return new AsyncInvoker<UpdateWorkflowScheduleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkflowScheduleResponse>);
        }
        
        /// <summary>
        /// 新建消息订阅Subscription
        ///
        /// 为Workflow工作流添加消息订阅功能。工作流已订阅的事件发生时，会产生消息提醒。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowSubscriptionsResponse> CreateWorkflowSubscriptionsAsync(CreateWorkflowSubscriptionsRequest createWorkflowSubscriptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowSubscriptionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowSubscriptionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowSubscriptionsResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowSubscriptionsResponse> CreateWorkflowSubscriptionsAsyncInvoker(CreateWorkflowSubscriptionsRequest createWorkflowSubscriptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWorkflowSubscriptionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWorkflowSubscriptionsRequest);
            return new AsyncInvoker<CreateWorkflowSubscriptionsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowSubscriptionsResponse>);
        }
        
        /// <summary>
        /// 删除消息订阅Subscription
        ///
        /// 删除已订阅的消息订阅Subscription。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWorkflowSubscriptionResponse> DeleteWorkflowSubscriptionAsync(DeleteWorkflowSubscriptionRequest deleteWorkflowSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowSubscriptionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowSubscriptionRequest.SubscriptionId, out var valueOfSubscriptionId)) urlParam.Add("subscription_id", valueOfSubscriptionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/subscriptions/{subscription_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkflowSubscriptionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWorkflowSubscriptionResponse>(response);
        }

        public AsyncInvoker<DeleteWorkflowSubscriptionResponse> DeleteWorkflowSubscriptionAsyncInvoker(DeleteWorkflowSubscriptionRequest deleteWorkflowSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowSubscriptionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(deleteWorkflowSubscriptionRequest.SubscriptionId, out var valueOfSubscriptionId)) urlParam.Add("subscription_id", valueOfSubscriptionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/subscriptions/{subscription_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWorkflowSubscriptionRequest);
            return new AsyncInvoker<DeleteWorkflowSubscriptionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWorkflowSubscriptionResponse>);
        }
        
        /// <summary>
        /// 查询消息订阅Subscription详情
        ///
        /// 查询Workflow工作流已订阅的订阅信息详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowSubscriptionResponse> ShowWorkflowSubscriptionAsync(ShowWorkflowSubscriptionRequest showWorkflowSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowSubscriptionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowSubscriptionRequest.SubscriptionId, out var valueOfSubscriptionId)) urlParam.Add("subscription_id", valueOfSubscriptionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/subscriptions/{subscription_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowSubscriptionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowSubscriptionResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowSubscriptionResponse> ShowWorkflowSubscriptionAsyncInvoker(ShowWorkflowSubscriptionRequest showWorkflowSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowSubscriptionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowSubscriptionRequest.SubscriptionId, out var valueOfSubscriptionId)) urlParam.Add("subscription_id", valueOfSubscriptionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/subscriptions/{subscription_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowSubscriptionRequest);
            return new AsyncInvoker<ShowWorkflowSubscriptionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowSubscriptionResponse>);
        }
        
        /// <summary>
        /// 更新消息订阅Subscription
        ///
        /// 更新Workflow工作流已订阅的订阅信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWorkflowSubscriptionResponse> UpdateWorkflowSubscriptionAsync(UpdateWorkflowSubscriptionRequest updateWorkflowSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowSubscriptionRequest.SubscriptionId, out var valueOfSubscriptionId)) urlParam.Add("subscription_id", valueOfSubscriptionId);
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowSubscriptionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/subscriptions/{subscription_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkflowSubscriptionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkflowSubscriptionResponse>(response);
        }

        public AsyncInvoker<UpdateWorkflowSubscriptionResponse> UpdateWorkflowSubscriptionAsyncInvoker(UpdateWorkflowSubscriptionRequest updateWorkflowSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowSubscriptionRequest.SubscriptionId, out var valueOfSubscriptionId)) urlParam.Add("subscription_id", valueOfSubscriptionId);
            if (StringUtils.TryConvertToNonEmptyString(updateWorkflowSubscriptionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workflows/{workflow_id}/subscriptions/{subscription_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateWorkflowSubscriptionRequest);
            return new AsyncInvoker<UpdateWorkflowSubscriptionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkflowSubscriptionResponse>);
        }
        
    }
}