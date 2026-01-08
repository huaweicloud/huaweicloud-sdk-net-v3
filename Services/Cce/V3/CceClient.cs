using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cce.V3.Model;

namespace HuaweiCloud.SDK.Cce.V3
{
    public partial class CceClient : Client
    {
        public static ClientBuilder<CceClient> NewBuilder()
        {
            return new ClientBuilder<CceClient>().WithExceptionHandler(new CceExceptionHandler());
        }

        
        /// <summary>
        /// 纳管节点
        ///
        /// 该API用于在指定集群下纳管节点。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddNodeResponse AddNode(AddNodeRequest addNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddNodeResponse>(response);
        }

        public SyncInvoker<AddNodeResponse> AddNodeInvoker(AddNodeRequest addNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodeRequest);
            return new SyncInvoker<AddNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<AddNodeResponse>);
        }
        
        /// <summary>
        /// 自定义节点池纳管节点
        ///
        /// 该API用于在指定集群自定义节点池下纳管节点。竞价实例不支持纳管。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddNodesToNodePoolResponse AddNodesToNodePool(AddNodesToNodePoolRequest addNodesToNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addNodesToNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(addNodesToNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/nodes/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodesToNodePoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddNodesToNodePoolResponse>(response);
        }

        public SyncInvoker<AddNodesToNodePoolResponse> AddNodesToNodePoolInvoker(AddNodesToNodePoolRequest addNodesToNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addNodesToNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(addNodesToNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/nodes/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodesToNodePoolRequest);
            return new SyncInvoker<AddNodesToNodePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<AddNodesToNodePoolResponse>);
        }
        
        /// <summary>
        /// 集群唤醒
        ///
        /// 集群唤醒用于唤醒已休眠的集群，唤醒后，将继续收取控制节点资源费用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AwakeClusterResponse AwakeCluster(AwakeClusterRequest awakeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(awakeClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/awake", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", awakeClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AwakeClusterResponse>(response);
        }

        public SyncInvoker<AwakeClusterResponse> AwakeClusterInvoker(AwakeClusterRequest awakeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(awakeClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/awake", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", awakeClusterRequest);
            return new SyncInvoker<AwakeClusterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AwakeClusterResponse>);
        }
        
        /// <summary>
        /// 批量创建插件检查任务
        ///
        /// 该API用于在指定集群下批量创建插件检查任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateAddonPrecheckResponse BatchCreateAddonPrecheck(BatchCreateAddonPrecheckRequest batchCreateAddonPrecheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateAddonPrecheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/addons/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAddonPrecheckRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateAddonPrecheckResponse>(response);
        }

        public SyncInvoker<BatchCreateAddonPrecheckResponse> BatchCreateAddonPrecheckInvoker(BatchCreateAddonPrecheckRequest batchCreateAddonPrecheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateAddonPrecheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/addons/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAddonPrecheckRequest);
            return new SyncInvoker<BatchCreateAddonPrecheckResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateAddonPrecheckResponse>);
        }
        
        /// <summary>
        /// 批量添加指定集群的资源标签
        ///
        /// 该API用于批量添加指定集群的资源标签。
        /// &gt; - 每个集群支持最多20个资源标签。
        /// &gt; - 此接口为幂等接口：创建时，如果创建的标签已经存在（key/value均相同视为重复），默认处理成功；key相同，value不同时会覆盖原有标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateClusterTagsResponse BatchCreateClusterTags(BatchCreateClusterTagsRequest batchCreateClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateClusterTagsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateClusterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateClusterTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateClusterTagsResponse> BatchCreateClusterTagsInvoker(BatchCreateClusterTagsRequest batchCreateClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateClusterTagsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateClusterTagsRequest);
            return new SyncInvoker<BatchCreateClusterTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateClusterTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除指定集群的资源标签
        ///
        /// 该API用于批量删除指定集群的资源标签。
        /// &gt; - 此接口为幂等接口：删除时，如果删除的标签key不存在，默认处理成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteClusterTagsResponse BatchDeleteClusterTags(BatchDeleteClusterTagsRequest batchDeleteClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteClusterTagsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteClusterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteClusterTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteClusterTagsResponse> BatchDeleteClusterTagsInvoker(BatchDeleteClusterTagsRequest batchDeleteClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteClusterTagsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteClusterTagsRequest);
            return new SyncInvoker<BatchDeleteClusterTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteClusterTagsResponse>);
        }
        
        /// <summary>
        /// 批量同步节点
        ///
        /// 该API用于批量同步节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSyncNodesResponse BatchSyncNodes(BatchSyncNodesRequest batchSyncNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchSyncNodesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSyncNodesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchSyncNodesResponse>(response);
        }

        public SyncInvoker<BatchSyncNodesResponse> BatchSyncNodesInvoker(BatchSyncNodesRequest batchSyncNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchSyncNodesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSyncNodesRequest);
            return new SyncInvoker<BatchSyncNodesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchSyncNodesResponse>);
        }
        
        /// <summary>
        /// 继续执行集群升级任务
        ///
        /// 继续执行被暂停的集群升级任务。
        /// &gt; - 集群升级涉及多维度的组件升级操作，强烈建议统一通过CCE控制台执行交互式升级，降低集群升级过程的业务意外受损风险；
        /// &gt; - 当前集群升级相关接口受限开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ContinueUpgradeClusterTaskResponse ContinueUpgradeClusterTask(ContinueUpgradeClusterTaskRequest continueUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(continueUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/continue", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueUpgradeClusterTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ContinueUpgradeClusterTaskResponse>(response);
        }

        public SyncInvoker<ContinueUpgradeClusterTaskResponse> ContinueUpgradeClusterTaskInvoker(ContinueUpgradeClusterTaskRequest continueUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(continueUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/continue", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueUpgradeClusterTaskRequest);
            return new SyncInvoker<ContinueUpgradeClusterTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ContinueUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 创建访问策略
        ///
        /// 该API用于创建访问策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccessPolicyResponse CreateAccessPolicy(CreateAccessPolicyRequest createAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessPolicyResponse>(response);
        }

        public SyncInvoker<CreateAccessPolicyResponse> CreateAccessPolicyInvoker(CreateAccessPolicyRequest createAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessPolicyRequest);
            return new SyncInvoker<CreateAccessPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 创建AddonInstance
        ///
        /// 根据提供的插件模板，安装插件实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAddonInstanceResponse CreateAddonInstance(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAddonInstanceResponse>(response);
        }

        public SyncInvoker<CreateAddonInstanceResponse> CreateAddonInstanceInvoker(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            return new SyncInvoker<CreateAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 创建PVC（待废弃）
        ///
        /// 该API用于在指定的Namespace下通过云存储服务中的云存储（EVS、SFS、OBS）去创建PVC（PersistentVolumeClaim）。该API待废弃，请使用Kubernetes PVC相关接口。
        /// 
        /// 
        /// &gt;存储管理的URL格式为：https://{clusterid}.Endpoint/uri。其中{clusterid}为集群ID，uri为资源路径，也即API访问的路径。如果使用https://Endpoint/uri，则必须指定请求header中的X-Cluster-ID参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCloudPersistentVolumeClaimsResponse CreateCloudPersistentVolumeClaims(CreateCloudPersistentVolumeClaimsRequest createCloudPersistentVolumeClaimsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCloudPersistentVolumeClaimsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudPersistentVolumeClaimsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCloudPersistentVolumeClaimsResponse>(response);
        }

        public SyncInvoker<CreateCloudPersistentVolumeClaimsResponse> CreateCloudPersistentVolumeClaimsInvoker(CreateCloudPersistentVolumeClaimsRequest createCloudPersistentVolumeClaimsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCloudPersistentVolumeClaimsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudPersistentVolumeClaimsRequest);
            return new SyncInvoker<CreateCloudPersistentVolumeClaimsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCloudPersistentVolumeClaimsResponse>);
        }
        
        /// <summary>
        /// 创建集群
        ///
        /// 该API用于创建一个空集群（即只有控制节点Master，没有工作节点Node）。请在调用本接口完成集群创建之后，通过[创建节点](cce_02_0242.xml)添加节点。
        /// 
        /// 
        /// &gt;   - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// &gt;   - 调用该接口创建集群时，默认不安装ICAgent，若需安装ICAgent，可在请求Body参数的annotations中加入\&quot;cluster.install.addons.external/install\&quot;:\&quot;[{\&quot;addonTemplateName\&quot;:\&quot;icagent\&quot;}]\&quot;的集群注解，将在创建集群时自动安装ICAgent。ICAgent是应用性能管理APM的采集代理，运行在应用所在的服务器上，用于实时采集探针所获取的数据，安装ICAgent是使用应用性能管理APM的前提。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateClusterResponse CreateCluster(CreateClusterRequest createClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterResponse>(response);
        }

        public SyncInvoker<CreateClusterResponse> CreateClusterInvoker(CreateClusterRequest createClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            return new SyncInvoker<CreateClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterResponse>);
        }
        
        /// <summary>
        /// 集群备份
        ///
        /// 集群备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateClusterMasterSnapshotResponse CreateClusterMasterSnapshot(CreateClusterMasterSnapshotRequest createClusterMasterSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterMasterSnapshotRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterMasterSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterMasterSnapshotResponse>(response);
        }

        public SyncInvoker<CreateClusterMasterSnapshotResponse> CreateClusterMasterSnapshotInvoker(CreateClusterMasterSnapshotRequest createClusterMasterSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterMasterSnapshotRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterMasterSnapshotRequest);
            return new SyncInvoker<CreateClusterMasterSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterMasterSnapshotResponse>);
        }
        
        /// <summary>
        /// 获取集群证书
        ///
        /// 该API用于获取指定集群的证书信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKubernetesClusterCertResponse CreateKubernetesClusterCert(CreateKubernetesClusterCertRequest createKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKubernetesClusterCertRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKubernetesClusterCertRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKubernetesClusterCertResponse>(response);
        }

        public SyncInvoker<CreateKubernetesClusterCertResponse> CreateKubernetesClusterCertInvoker(CreateKubernetesClusterCertRequest createKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKubernetesClusterCertRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKubernetesClusterCertRequest);
            return new SyncInvoker<CreateKubernetesClusterCertResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKubernetesClusterCertResponse>);
        }
        
        /// <summary>
        /// 创建节点
        ///
        /// 该API用于在指定集群下创建节点。
        /// &gt; - 若无集群，请先[创建集群](cce_02_0236.xml)。
        /// &gt; - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNodeResponse CreateNode(CreateNodeRequest createNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNodeResponse>(response);
        }

        public SyncInvoker<CreateNodeResponse> CreateNodeInvoker(CreateNodeRequest createNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodeRequest);
            return new SyncInvoker<CreateNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNodeResponse>);
        }
        
        /// <summary>
        /// 创建节点池
        ///
        /// 该API用于在指定集群下创建节点池。仅支持集群在处于可用、扩容、缩容状态时调用。
        /// 
        /// 1.21版本的集群创建节点池时支持绑定安全组，每个节点池最多绑定五个安全组。
        /// 
        /// 更新节点池的安全组后，只针对新创的pod生效，建议驱逐节点上原有的pod。
        /// 
        /// &gt; 若无集群，请先[创建集群](cce_02_0236.xml)。
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNodePoolResponse CreateNodePool(CreateNodePoolRequest createNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodePoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNodePoolResponse>(response);
        }

        public SyncInvoker<CreateNodePoolResponse> CreateNodePoolInvoker(CreateNodePoolRequest createNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodePoolRequest);
            return new SyncInvoker<CreateNodePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNodePoolResponse>);
        }
        
        /// <summary>
        /// 创建分区
        ///
        /// 创建分区
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePartitionResponse CreatePartition(CreatePartitionRequest createPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPartitionRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePartitionResponse>(response);
        }

        public SyncInvoker<CreatePartitionResponse> CreatePartitionInvoker(CreatePartitionRequest createPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPartitionRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            return new SyncInvoker<CreatePartitionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePartitionResponse>);
        }
        
        /// <summary>
        /// 集群升级后确认
        ///
        /// 集群升级后确认，该接口建议配合Console使用，主要用于升级步骤完成后，客户确认集群状态和业务正常后做反馈。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostCheckResponse CreatePostCheck(CreatePostCheckRequest createPostCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/postcheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostCheckRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostCheckResponse>(response);
        }

        public SyncInvoker<CreatePostCheckResponse> CreatePostCheckInvoker(CreatePostCheckRequest createPostCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/postcheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostCheckRequest);
            return new SyncInvoker<CreatePostCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostCheckResponse>);
        }
        
        /// <summary>
        /// 集群升级前检查
        ///
        /// 集群升级前检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePreCheckResponse CreatePreCheck(CreatePreCheckRequest createPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPreCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreCheckRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePreCheckResponse>(response);
        }

        public SyncInvoker<CreatePreCheckResponse> CreatePreCheckInvoker(CreatePreCheckRequest createPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPreCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreCheckRequest);
            return new SyncInvoker<CreatePreCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePreCheckResponse>);
        }
        
        /// <summary>
        /// 创建模板实例
        ///
        /// 创建模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateReleaseResponse CreateRelease(CreateReleaseRequest createReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReleaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateReleaseResponse>(response);
        }

        public SyncInvoker<CreateReleaseResponse> CreateReleaseInvoker(CreateReleaseRequest createReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReleaseRequest);
            return new SyncInvoker<CreateReleaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReleaseResponse>);
        }
        
        /// <summary>
        /// 开启集群升级流程引导任务
        ///
        /// 该API用于创建一个集群升级流程引导任务。请在调用本接口完成引导任务创建之后，通过集群升级前检查开始检查任务。
        /// 升级流程任务用于控制集群升级任务的执行流程，执行流程为 升级前检查 &#x3D;&gt; 集群升级 &#x3D;&gt; 升级后检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUpgradeWorkFlowResponse CreateUpgradeWorkFlow(CreateUpgradeWorkFlowRequest createUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUpgradeWorkFlowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUpgradeWorkFlowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUpgradeWorkFlowResponse>(response);
        }

        public SyncInvoker<CreateUpgradeWorkFlowResponse> CreateUpgradeWorkFlowInvoker(CreateUpgradeWorkFlowRequest createUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUpgradeWorkFlowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUpgradeWorkFlowRequest);
            return new SyncInvoker<CreateUpgradeWorkFlowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUpgradeWorkFlowResponse>);
        }
        
        /// <summary>
        /// 删除访问策略
        ///
        /// 该API用于删除单个访问策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAccessPolicyResponse DeleteAccessPolicy(DeleteAccessPolicyRequest deleteAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAccessPolicyResponse>(response);
        }

        public SyncInvoker<DeleteAccessPolicyResponse> DeleteAccessPolicyInvoker(DeleteAccessPolicyRequest deleteAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessPolicyRequest);
            return new SyncInvoker<DeleteAccessPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 删除AddonInstance
        ///
        /// 删除插件实例的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAddonInstanceResponse DeleteAddonInstance(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAddonInstanceResponse>(response);
        }

        public SyncInvoker<DeleteAddonInstanceResponse> DeleteAddonInstanceInvoker(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            return new SyncInvoker<DeleteAddonInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 删除模板
        ///
        /// 删除模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteChartResponse DeleteChart(DeleteChartRequest deleteChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteChartRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteChartResponse>(response);
        }

        public SyncInvoker<DeleteChartResponse> DeleteChartInvoker(DeleteChartRequest deleteChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteChartRequest);
            return new SyncInvoker<DeleteChartResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteChartResponse>);
        }
        
        /// <summary>
        /// 删除PVC（待废弃）
        ///
        /// 该API用于删除指定Namespace下的PVC（PersistentVolumeClaim）对象，并可以选择保留后端的云存储。该API待废弃，请使用Kubernetes PVC相关接口。
        /// &gt;存储管理的URL格式为：https://{clusterid}.Endpoint/uri。其中{clusterid}为集群ID，uri为资源路径，也即API访问的路径。如果使用https://Endpoint/uri，则必须指定请求header中的X-Cluster-ID参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCloudPersistentVolumeClaimsResponse DeleteCloudPersistentVolumeClaims(DeleteCloudPersistentVolumeClaimsRequest deleteCloudPersistentVolumeClaimsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCloudPersistentVolumeClaimsRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(deleteCloudPersistentVolumeClaimsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudPersistentVolumeClaimsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCloudPersistentVolumeClaimsResponse>(response);
        }

        public SyncInvoker<DeleteCloudPersistentVolumeClaimsResponse> DeleteCloudPersistentVolumeClaimsInvoker(DeleteCloudPersistentVolumeClaimsRequest deleteCloudPersistentVolumeClaimsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCloudPersistentVolumeClaimsRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(deleteCloudPersistentVolumeClaimsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudPersistentVolumeClaimsRequest);
            return new SyncInvoker<DeleteCloudPersistentVolumeClaimsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCloudPersistentVolumeClaimsResponse>);
        }
        
        /// <summary>
        /// 删除集群
        ///
        /// 该API用于删除一个指定的集群。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest deleteClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteClusterResponse>(response);
        }

        public SyncInvoker<DeleteClusterResponse> DeleteClusterInvoker(DeleteClusterRequest deleteClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            return new SyncInvoker<DeleteClusterResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteClusterResponse>);
        }
        
        /// <summary>
        /// 删除节点
        ///
        /// 该API用于删除指定的节点。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNodeResponse DeleteNode(DeleteNodeRequest deleteNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNodeResponse>(response);
        }

        public SyncInvoker<DeleteNodeResponse> DeleteNodeInvoker(DeleteNodeRequest deleteNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodeRequest);
            return new SyncInvoker<DeleteNodeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNodeResponse>);
        }
        
        /// <summary>
        /// 删除节点池
        ///
        /// 该API用于删除指定的节点池。
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNodePoolResponse DeleteNodePool(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNodePoolResponse>(response);
        }

        public SyncInvoker<DeleteNodePoolResponse> DeleteNodePoolInvoker(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            return new SyncInvoker<DeleteNodePoolResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNodePoolResponse>);
        }
        
        /// <summary>
        /// 删除指定模板实例
        ///
        /// 删除指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteReleaseResponse DeleteRelease(DeleteReleaseRequest deleteReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(deleteReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReleaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteReleaseResponse>(response);
        }

        public SyncInvoker<DeleteReleaseResponse> DeleteReleaseInvoker(DeleteReleaseRequest deleteReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(deleteReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReleaseRequest);
            return new SyncInvoker<DeleteReleaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteReleaseResponse>);
        }
        
        /// <summary>
        /// 下载模板
        ///
        /// 下载模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadChartResponse DownloadChart(DownloadChartRequest downloadChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadChartRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadChartResponse>(response);
        }

        public SyncInvoker<DownloadChartResponse> DownloadChartInvoker(DownloadChartRequest downloadChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadChartRequest);
            return new SyncInvoker<DownloadChartResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadChartResponse>);
        }
        
        /// <summary>
        /// 获取访问策略详情
        ///
        /// 该API用于获取单个访问策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetAccessPolicyResponse GetAccessPolicy(GetAccessPolicyRequest getAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAccessPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAccessPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetAccessPolicyResponse>(response);
        }

        public SyncInvoker<GetAccessPolicyResponse> GetAccessPolicyInvoker(GetAccessPolicyRequest getAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAccessPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAccessPolicyRequest);
            return new SyncInvoker<GetAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<GetAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 查询可用区列表
        ///
        /// 该API用于查询可用区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetAvaliableZoneResponse GetAvaliableZone(GetAvaliableZoneRequest getAvaliableZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v2/availabilityZones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAvaliableZoneRequest);
            var response = DoHttpRequestSync("GET", request);
            var getAvaliableZoneResponse = JsonUtils.DeSerializeNull<GetAvaliableZoneResponse>(response);
            getAvaliableZoneResponse.Body = JsonUtils.DeSerializeList<GetAvailableZoneResponseBody>(response);
            return getAvaliableZoneResponse;
        }

        public SyncInvoker<GetAvaliableZoneResponse> GetAvaliableZoneInvoker(GetAvaliableZoneRequest getAvaliableZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v2/availabilityZones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAvaliableZoneRequest);
            return new SyncInvoker<GetAvaliableZoneResponse>(this, "GET", request, response =>
            {
                var getAvaliableZoneResponse = JsonUtils.DeSerializeNull<GetAvaliableZoneResponse>(response);
                getAvaliableZoneResponse.Body = JsonUtils.DeSerializeList<GetAvailableZoneResponseBody>(response);
                return getAvaliableZoneResponse;
            });
        }
        
        /// <summary>
        /// 查询集群可售卖规格
        ///
        /// 该API用于查询集群可售卖规格
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetClusterFlavorSpecsResponse GetClusterFlavorSpecs(GetClusterFlavorSpecsRequest getClusterFlavorSpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v2/flavor/specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getClusterFlavorSpecsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetClusterFlavorSpecsResponse>(response);
        }

        public SyncInvoker<GetClusterFlavorSpecsResponse> GetClusterFlavorSpecsInvoker(GetClusterFlavorSpecsRequest getClusterFlavorSpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v2/flavor/specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getClusterFlavorSpecsRequest);
            return new SyncInvoker<GetClusterFlavorSpecsResponse>(this, "GET", request, JsonUtils.DeSerialize<GetClusterFlavorSpecsResponse>);
        }
        
        /// <summary>
        /// 获取集群LongAKSK配置
        ///
        /// 该API用于获取集群longaksk的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetClusterLongAkskConfigResponse GetClusterLongAkskConfig(GetClusterLongAkskConfigRequest getClusterLongAkskConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getClusterLongAkskConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/longaksk/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getClusterLongAkskConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetClusterLongAkskConfigResponse>(response);
        }

        public SyncInvoker<GetClusterLongAkskConfigResponse> GetClusterLongAkskConfigInvoker(GetClusterLongAkskConfigRequest getClusterLongAkskConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getClusterLongAkskConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/longaksk/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getClusterLongAkskConfigRequest);
            return new SyncInvoker<GetClusterLongAkskConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<GetClusterLongAkskConfigResponse>);
        }
        
        /// <summary>
        /// 获取集群配额
        ///
        /// 该API用于获取集群配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetClusterQuotaResponse GetClusterQuota(GetClusterQuotaRequest getClusterQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cce/v1/projects/{project_id}/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getClusterQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetClusterQuotaResponse>(response);
        }

        public SyncInvoker<GetClusterQuotaResponse> GetClusterQuotaInvoker(GetClusterQuotaRequest getClusterQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cce/v1/projects/{project_id}/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getClusterQuotaRequest);
            return new SyncInvoker<GetClusterQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<GetClusterQuotaResponse>);
        }
        
        /// <summary>
        /// 查询自定义标签
        ///
        /// 该API用于查询自定义标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetCustomizeTagsResponse GetCustomizeTags(GetCustomizeTagsRequest getCustomizeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getCustomizeTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/cce/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomizeTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetCustomizeTagsResponse>(response);
        }

        public SyncInvoker<GetCustomizeTagsResponse> GetCustomizeTagsInvoker(GetCustomizeTagsRequest getCustomizeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getCustomizeTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/cce/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomizeTagsRequest);
            return new SyncInvoker<GetCustomizeTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCustomizeTagsResponse>);
        }
        
        /// <summary>
        /// 获取节点标签
        ///
        /// 该API用于获取集群所有节点的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetLabelsResponse GetLabels(GetLabelsRequest getLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getLabelsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getLabelsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetLabelsResponse>(response);
        }

        public SyncInvoker<GetLabelsResponse> GetLabelsInvoker(GetLabelsRequest getLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getLabelsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getLabelsRequest);
            return new SyncInvoker<GetLabelsResponse>(this, "GET", request, JsonUtils.DeSerialize<GetLabelsResponse>);
        }
        
        /// <summary>
        /// 获取项目LongAKSK配置
        ///
        /// 该API用于获取项目LongAKSK的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetLongAkskConfigResponse GetLongAkskConfig(GetLongAkskConfigRequest getLongAkskConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/longaksk/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getLongAkskConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetLongAkskConfigResponse>(response);
        }

        public SyncInvoker<GetLongAkskConfigResponse> GetLongAkskConfigInvoker(GetLongAkskConfigRequest getLongAkskConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/longaksk/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getLongAkskConfigRequest);
            return new SyncInvoker<GetLongAkskConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<GetLongAkskConfigResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 该API用于查询资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetResourceTagsResponse GetResourceTags(GetResourceTagsRequest getResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(getResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/cce/v1/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetResourceTagsResponse>(response);
        }

        public SyncInvoker<GetResourceTagsResponse> GetResourceTagsInvoker(GetResourceTagsRequest getResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(getResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/cce/v1/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getResourceTagsRequest);
            return new SyncInvoker<GetResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<GetResourceTagsResponse>);
        }
        
        /// <summary>
        /// 集群休眠
        ///
        /// 集群休眠用于将运行中的集群置于休眠状态，休眠后，将不再收取控制节点资源费用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public HibernateClusterResponse HibernateCluster(HibernateClusterRequest hibernateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(hibernateClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/hibernate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", hibernateClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<HibernateClusterResponse>(response);
        }

        public SyncInvoker<HibernateClusterResponse> HibernateClusterInvoker(HibernateClusterRequest hibernateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(hibernateClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/hibernate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", hibernateClusterRequest);
            return new SyncInvoker<HibernateClusterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<HibernateClusterResponse>);
        }
        
        /// <summary>
        /// 获取访问策略列表
        ///
        /// 该API用于获取访问策略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessPolicyResponse ListAccessPolicy(ListAccessPolicyRequest listAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessPolicyResponse>(response);
        }

        public SyncInvoker<ListAccessPolicyResponse> ListAccessPolicyInvoker(ListAccessPolicyRequest listAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPolicyRequest);
            return new SyncInvoker<ListAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 获取AddonInstance列表
        ///
        /// 获取集群所有已安装插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddonInstancesResponse ListAddonInstances(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddonInstancesResponse>(response);
        }

        public SyncInvoker<ListAddonInstancesResponse> ListAddonInstancesInvoker(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            return new SyncInvoker<ListAddonInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonInstancesResponse>);
        }
        
        /// <summary>
        /// 获取插件检查任务结果列表
        ///
        /// 获取集群下插件检查任务结果列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddonPrecheckTasksResponse ListAddonPrecheckTasks(ListAddonPrecheckTasksRequest listAddonPrecheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAddonPrecheckTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/addons/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonPrecheckTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddonPrecheckTasksResponse>(response);
        }

        public SyncInvoker<ListAddonPrecheckTasksResponse> ListAddonPrecheckTasksInvoker(ListAddonPrecheckTasksRequest listAddonPrecheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAddonPrecheckTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/addons/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonPrecheckTasksRequest);
            return new SyncInvoker<ListAddonPrecheckTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonPrecheckTasksResponse>);
        }
        
        /// <summary>
        /// 查询AddonTemplates列表
        ///
        /// 插件模板查询接口，查询插件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddonTemplatesResponse ListAddonTemplates(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddonTemplatesResponse>(response);
        }

        public SyncInvoker<ListAddonTemplatesResponse> ListAddonTemplatesInvoker(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            return new SyncInvoker<ListAddonTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取模板列表
        ///
        /// 获取模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListChartsResponse ListCharts(ListChartsRequest listChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listChartsResponse = JsonUtils.DeSerializeNull<ListChartsResponse>(response);
            listChartsResponse.Body = JsonUtils.DeSerializeList<ChartResp>(response);
            return listChartsResponse;
        }

        public SyncInvoker<ListChartsResponse> ListChartsInvoker(ListChartsRequest listChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            return new SyncInvoker<ListChartsResponse>(this, "GET", request, response =>
            {
                var listChartsResponse = JsonUtils.DeSerializeNull<ListChartsResponse>(response);
                listChartsResponse.Body = JsonUtils.DeSerializeList<ChartResp>(response);
                return listChartsResponse;
            });
        }
        
        /// <summary>
        /// 获取集群备份任务详情列表
        ///
        /// 获取集群备份任务详情列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClusterMasterSnapshotTasksResponse ListClusterMasterSnapshotTasks(ListClusterMasterSnapshotTasksRequest listClusterMasterSnapshotTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClusterMasterSnapshotTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterMasterSnapshotTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClusterMasterSnapshotTasksResponse>(response);
        }

        public SyncInvoker<ListClusterMasterSnapshotTasksResponse> ListClusterMasterSnapshotTasksInvoker(ListClusterMasterSnapshotTasksRequest listClusterMasterSnapshotTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClusterMasterSnapshotTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterMasterSnapshotTasksRequest);
            return new SyncInvoker<ListClusterMasterSnapshotTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterMasterSnapshotTasksResponse>);
        }
        
        /// <summary>
        /// 获取集群升级特性开关配置
        ///
        /// 获取集群升级特性开关配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClusterUpgradeFeatureGatesResponse ListClusterUpgradeFeatureGates(ListClusterUpgradeFeatureGatesRequest listClusterUpgradeFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusterupgradefeaturegates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterUpgradeFeatureGatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClusterUpgradeFeatureGatesResponse>(response);
        }

        public SyncInvoker<ListClusterUpgradeFeatureGatesResponse> ListClusterUpgradeFeatureGatesInvoker(ListClusterUpgradeFeatureGatesRequest listClusterUpgradeFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusterupgradefeaturegates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterUpgradeFeatureGatesRequest);
            return new SyncInvoker<ListClusterUpgradeFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterUpgradeFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取集群升级路径
        ///
        /// 获取集群升级路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClusterUpgradePathsResponse ListClusterUpgradePaths(ListClusterUpgradePathsRequest listClusterUpgradePathsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusterupgradepaths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterUpgradePathsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClusterUpgradePathsResponse>(response);
        }

        public SyncInvoker<ListClusterUpgradePathsResponse> ListClusterUpgradePathsInvoker(ListClusterUpgradePathsRequest listClusterUpgradePathsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusterupgradepaths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterUpgradePathsRequest);
            return new SyncInvoker<ListClusterUpgradePathsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterUpgradePathsResponse>);
        }
        
        /// <summary>
        /// 获取指定项目下的集群
        ///
        /// 该API用于获取指定项目下所有集群的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClustersResponse ListClusters(ListClustersRequest listClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClustersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClustersResponse>(response);
        }

        public SyncInvoker<ListClustersResponse> ListClustersInvoker(ListClustersRequest listClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClustersRequest);
            return new SyncInvoker<ListClustersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClustersResponse>);
        }
        
        /// <summary>
        /// 查询集群中超节点列表
        ///
        /// 该API用于获取指定集群下所有超节点的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHyperNodesResponse ListHyperNodes(ListHyperNodesRequest listHyperNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHyperNodesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/hypernodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHyperNodesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHyperNodesResponse>(response);
        }

        public SyncInvoker<ListHyperNodesResponse> ListHyperNodesInvoker(ListHyperNodesRequest listHyperNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHyperNodesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/hypernodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHyperNodesRequest);
            return new SyncInvoker<ListHyperNodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHyperNodesResponse>);
        }
        
        /// <summary>
        /// 获取集群下所有节点池
        ///
        /// 该API用于获取集群下所有节点池。
        /// &gt; - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// &gt; - nodepool是集群中具有相同配置的节点实例的子集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNodePoolsResponse ListNodePools(ListNodePoolsRequest listNodePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodePoolsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNodePoolsResponse>(response);
        }

        public SyncInvoker<ListNodePoolsResponse> ListNodePoolsInvoker(ListNodePoolsRequest listNodePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodePoolsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            return new SyncInvoker<ListNodePoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodePoolsResponse>);
        }
        
        /// <summary>
        /// 获取集群下所有节点
        ///
        /// 该API用于通过集群ID获取指定集群下所有节点的详细信息。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNodesResponse ListNodes(ListNodesRequest listNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNodesResponse>(response);
        }

        public SyncInvoker<ListNodesResponse> ListNodesInvoker(ListNodesRequest listNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            return new SyncInvoker<ListNodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodesResponse>);
        }
        
        /// <summary>
        /// 获取分区列表
        ///
        /// 获取分区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPartitionsResponse ListPartitions(ListPartitionsRequest listPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPartitionsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartitionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPartitionsResponse>(response);
        }

        public SyncInvoker<ListPartitionsResponse> ListPartitionsInvoker(ListPartitionsRequest listPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPartitionsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartitionsRequest);
            return new SyncInvoker<ListPartitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPartitionsResponse>);
        }
        
        /// <summary>
        /// 获取集群升级前检查任务详情列表
        ///
        /// 获取集群升级前检查任务详情列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPreCheckTasksResponse ListPreCheckTasks(ListPreCheckTasksRequest listPreCheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPreCheckTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPreCheckTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPreCheckTasksResponse>(response);
        }

        public SyncInvoker<ListPreCheckTasksResponse> ListPreCheckTasksInvoker(ListPreCheckTasksRequest listPreCheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPreCheckTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPreCheckTasksRequest);
            return new SyncInvoker<ListPreCheckTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPreCheckTasksResponse>);
        }
        
        /// <summary>
        /// 获取模板实例列表
        ///
        /// 获取模板实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReleasesResponse ListReleases(ListReleasesRequest listReleasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReleasesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReleasesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listReleasesResponse = JsonUtils.DeSerializeNull<ListReleasesResponse>(response);
            listReleasesResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
            return listReleasesResponse;
        }

        public SyncInvoker<ListReleasesResponse> ListReleasesInvoker(ListReleasesRequest listReleasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReleasesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReleasesRequest);
            return new SyncInvoker<ListReleasesResponse>(this, "GET", request, response =>
            {
                var listReleasesResponse = JsonUtils.DeSerializeNull<ListReleasesResponse>(response);
                listReleasesResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
                return listReleasesResponse;
            });
        }
        
        /// <summary>
        /// 获取集群升级任务详情列表
        ///
        /// 获取集群升级任务详情列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUpgradeClusterTasksResponse ListUpgradeClusterTasks(ListUpgradeClusterTasksRequest listUpgradeClusterTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUpgradeClusterTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeClusterTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUpgradeClusterTasksResponse>(response);
        }

        public SyncInvoker<ListUpgradeClusterTasksResponse> ListUpgradeClusterTasksInvoker(ListUpgradeClusterTasksRequest listUpgradeClusterTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUpgradeClusterTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeClusterTasksRequest);
            return new SyncInvoker<ListUpgradeClusterTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpgradeClusterTasksResponse>);
        }
        
        /// <summary>
        /// 获取UpgradeWorkFlows列表
        ///
        /// 获取历史集群升级引导任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUpgradeWorkFlowsResponse ListUpgradeWorkFlows(ListUpgradeWorkFlowsRequest listUpgradeWorkFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUpgradeWorkFlowsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeWorkFlowsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUpgradeWorkFlowsResponse>(response);
        }

        public SyncInvoker<ListUpgradeWorkFlowsResponse> ListUpgradeWorkFlowsInvoker(ListUpgradeWorkFlowsRequest listUpgradeWorkFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUpgradeWorkFlowsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeWorkFlowsRequest);
            return new SyncInvoker<ListUpgradeWorkFlowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpgradeWorkFlowsResponse>);
        }
        
        /// <summary>
        /// 节点开启缩容保护。
        ///
        /// 该API用于节点开启缩容保护，开启缩容保护的节点无法通过修改节点池个数的方式被缩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LockNodepoolNodeScaleDownResponse LockNodepoolNodeScaleDown(LockNodepoolNodeScaleDownRequest lockNodepoolNodeScaleDownRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(lockNodepoolNodeScaleDownRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/locknodescaledown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockNodepoolNodeScaleDownRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<LockNodepoolNodeScaleDownResponse>(response);
        }

        public SyncInvoker<LockNodepoolNodeScaleDownResponse> LockNodepoolNodeScaleDownInvoker(LockNodepoolNodeScaleDownRequest lockNodepoolNodeScaleDownRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(lockNodepoolNodeScaleDownRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/locknodescaledown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockNodepoolNodeScaleDownRequest);
            return new SyncInvoker<LockNodepoolNodeScaleDownResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LockNodepoolNodeScaleDownResponse>);
        }
        
        /// <summary>
        /// 节点迁移
        ///
        /// 该API用于在指定集群下迁移节点到另一集群。
        /// 
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateNodeResponse MigrateNode(MigrateNodeRequest migrateNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(migrateNodeRequest.TargetClusterId, out var valueOfTargetClusterId)) urlParam.Add("target_cluster_id", valueOfTargetClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/migrateto/{target_cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateNodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<MigrateNodeResponse>(response);
        }

        public SyncInvoker<MigrateNodeResponse> MigrateNodeInvoker(MigrateNodeRequest migrateNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(migrateNodeRequest.TargetClusterId, out var valueOfTargetClusterId)) urlParam.Add("target_cluster_id", valueOfTargetClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/migrateto/{target_cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateNodeRequest);
            return new SyncInvoker<MigrateNodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<MigrateNodeResponse>);
        }
        
        /// <summary>
        /// 节点迁移到自定义节点池。
        ///
        /// 该API用于将节点迁移到自定义节点池，仅default节点池下节点支持迁移。迁移过程节点无重置无重启，原节点密码将保留。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateToNodePoolResponse MigrateToNodePool(MigrateToNodePoolRequest migrateToNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateToNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(migrateToNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/nodes/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateToNodePoolRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<MigrateToNodePoolResponse>(response);
        }

        public SyncInvoker<MigrateToNodePoolResponse> MigrateToNodePoolInvoker(MigrateToNodePoolRequest migrateToNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateToNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(migrateToNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/nodes/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateToNodePoolRequest);
            return new SyncInvoker<MigrateToNodePoolResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MigrateToNodePoolResponse>);
        }
        
        /// <summary>
        /// 暂停集群升级任务
        ///
        /// 暂停集群升级任务。
        /// &gt; - 集群升级涉及多维度的组件升级操作，强烈建议统一通过CCE控制台执行交互式升级，降低集群升级过程的业务意外受损风险；
        /// &gt; - 当前集群升级相关接口受限开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PauseUpgradeClusterTaskResponse PauseUpgradeClusterTask(PauseUpgradeClusterTaskRequest pauseUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(pauseUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseUpgradeClusterTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<PauseUpgradeClusterTaskResponse>(response);
        }

        public SyncInvoker<PauseUpgradeClusterTaskResponse> PauseUpgradeClusterTaskInvoker(PauseUpgradeClusterTaskRequest pauseUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(pauseUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseUpgradeClusterTaskRequest);
            return new SyncInvoker<PauseUpgradeClusterTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PauseUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 节点移除
        ///
        /// 该API用于在指定集群下移除节点。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveNodeResponse RemoveNode(RemoveNodeRequest removeNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeNodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RemoveNodeResponse>(response);
        }

        public SyncInvoker<RemoveNodeResponse> RemoveNodeInvoker(RemoveNodeRequest removeNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeNodeRequest);
            return new SyncInvoker<RemoveNodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveNodeResponse>);
        }
        
        /// <summary>
        /// 重置节点
        ///
        /// 该API用于在指定集群下重置节点。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetNodeResponse ResetNode(ResetNodeRequest resetNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetNodeResponse>(response);
        }

        public SyncInvoker<ResetNodeResponse> ResetNodeInvoker(ResetNodeRequest resetNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetNodeRequest);
            return new SyncInvoker<ResetNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetNodeResponse>);
        }
        
        /// <summary>
        /// 变更集群规格
        ///
        /// 该API用于变更一个指定集群的规格。
        /// 
        /// &gt;   - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// &gt;   [- 使用限制请参考[变更集群规格](https://support.huaweicloud.com/usermanual-cce/cce_10_0403.html)。](tag:hws)
        /// &gt;   [- 使用限制请参考[变更集群规格](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_0403.html)](tag:hws_hk)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeClusterResponse ResizeCluster(ResizeClusterRequest resizeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeClusterResponse>(response);
        }

        public SyncInvoker<ResizeClusterResponse> ResizeClusterInvoker(ResizeClusterRequest resizeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeClusterRequest);
            return new SyncInvoker<ResizeClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeClusterResponse>);
        }
        
        /// <summary>
        /// 重试集群升级任务
        ///
        /// 重新执行失败的集群升级任务。
        /// &gt; - 集群升级涉及多维度的组件升级操作，强烈建议统一通过CCE控制台执行交互式升级，降低集群升级过程的业务意外受损风险；
        /// &gt; - 当前集群升级相关接口受限开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryUpgradeClusterTaskResponse RetryUpgradeClusterTask(RetryUpgradeClusterTaskRequest retryUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryUpgradeClusterTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RetryUpgradeClusterTaskResponse>(response);
        }

        public SyncInvoker<RetryUpgradeClusterTaskResponse> RetryUpgradeClusterTaskInvoker(RetryUpgradeClusterTaskRequest retryUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryUpgradeClusterTaskRequest);
            return new SyncInvoker<RetryUpgradeClusterTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 吊销用户的集群证书
        ///
        /// 该API用于吊销指定集群的用户证书
        /// 
        /// &gt; 吊销操作完成后，此证书申请人之前下载的证书和 kubectl 配置文件无法再用于连接集群。此证书申请人可以重新下载证书或 kubectl 配置文件，并使用新下载的文件连接集群
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RevokeKubernetesClusterCertResponse RevokeKubernetesClusterCert(RevokeKubernetesClusterCertRequest revokeKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeKubernetesClusterCertRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercertrevoke", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeKubernetesClusterCertRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RevokeKubernetesClusterCertResponse>(response);
        }

        public SyncInvoker<RevokeKubernetesClusterCertResponse> RevokeKubernetesClusterCertInvoker(RevokeKubernetesClusterCertRequest revokeKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeKubernetesClusterCertRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercertrevoke", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeKubernetesClusterCertRequest);
            return new SyncInvoker<RevokeKubernetesClusterCertResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RevokeKubernetesClusterCertResponse>);
        }
        
        /// <summary>
        /// 回滚AddonInstance
        ///
        /// 将插件实例回滚到升级前的版本。只有在当前插件实例版本支持回滚到升级前的版本（status.isRollbackable为true），且插件实例状态为running（运行中）、available（可用）、abnormal（不可用）、upgradeFailed（升级失败）、rollbackFailed（回滚失败）时支持回滚。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RollbackAddonInstanceResponse RollbackAddonInstance(RollbackAddonInstanceRequest rollbackAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollbackAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}/operation/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackAddonInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RollbackAddonInstanceResponse>(response);
        }

        public SyncInvoker<RollbackAddonInstanceResponse> RollbackAddonInstanceInvoker(RollbackAddonInstanceRequest rollbackAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollbackAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}/operation/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackAddonInstanceRequest);
            return new SyncInvoker<RollbackAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RollbackAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 伸缩节点池
        ///
        /// 该API用于伸缩指定的节点池
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ScaleNodePoolResponse ScaleNodePool(ScaleNodePoolRequest scaleNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scaleNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(scaleNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/operation/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", scaleNodePoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ScaleNodePoolResponse>(response);
        }

        public SyncInvoker<ScaleNodePoolResponse> ScaleNodePoolInvoker(ScaleNodePoolRequest scaleNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scaleNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(scaleNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/operation/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", scaleNodePoolRequest);
            return new SyncInvoker<ScaleNodePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<ScaleNodePoolResponse>);
        }
        
        /// <summary>
        /// 获取AddonInstance详情
        ///
        /// 获取插件实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAddonInstanceResponse ShowAddonInstance(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAddonInstanceResponse>(response);
        }

        public SyncInvoker<ShowAddonInstanceResponse> ShowAddonInstanceInvoker(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            return new SyncInvoker<ShowAddonInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 获取模板
        ///
        /// 获取模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowChartResponse ShowChart(ShowChartRequest showChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChartRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowChartResponse>(response);
        }

        public SyncInvoker<ShowChartResponse> ShowChartInvoker(ShowChartRequest showChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChartRequest);
            return new SyncInvoker<ShowChartResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowChartResponse>);
        }
        
        /// <summary>
        /// 获取模板Values
        ///
        /// 获取模板Values
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowChartValuesResponse ShowChartValues(ShowChartValuesRequest showChartValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showChartValuesRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChartValuesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowChartValuesResponse>(response);
        }

        public SyncInvoker<ShowChartValuesResponse> ShowChartValuesInvoker(ShowChartValuesRequest showChartValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showChartValuesRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChartValuesRequest);
            return new SyncInvoker<ShowChartValuesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowChartValuesResponse>);
        }
        
        /// <summary>
        /// 获取指定的集群
        ///
        /// 该API用于获取指定集群的详细信息。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterResponse ShowCluster(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }

        public SyncInvoker<ShowClusterResponse> ShowClusterInvoker(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            return new SyncInvoker<ShowClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterResponse>);
        }
        
        /// <summary>
        /// 查询集群日志配置信息
        ///
        /// 获取集群组件上报的LTS的配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterConfigResponse ShowClusterConfig(ShowClusterConfigRequest showClusterConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterConfigResponse>(response);
        }

        public SyncInvoker<ShowClusterConfigResponse> ShowClusterConfigInvoker(ShowClusterConfigRequest showClusterConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigRequest);
            return new SyncInvoker<ShowClusterConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterConfigResponse>);
        }
        
        /// <summary>
        /// 查询指定集群支持配置的参数列表
        ///
        /// 该API用于查询CCE服务下指定集群支持配置的参数列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterConfigurationDetailsResponse ShowClusterConfigurationDetails(ShowClusterConfigurationDetailsRequest showClusterConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterConfigurationDetailsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigurationDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            var showClusterConfigurationDetailsResponse = JsonUtils.DeSerializeNull<ShowClusterConfigurationDetailsResponse>(response);
            showClusterConfigurationDetailsResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
            return showClusterConfigurationDetailsResponse;
        }

        public SyncInvoker<ShowClusterConfigurationDetailsResponse> ShowClusterConfigurationDetailsInvoker(ShowClusterConfigurationDetailsRequest showClusterConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterConfigurationDetailsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigurationDetailsRequest);
            return new SyncInvoker<ShowClusterConfigurationDetailsResponse>(this, "GET", request, response =>
            {
                var showClusterConfigurationDetailsResponse = JsonUtils.DeSerializeNull<ShowClusterConfigurationDetailsResponse>(response);
                showClusterConfigurationDetailsResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
                return showClusterConfigurationDetailsResponse;
            });
        }
        
        /// <summary>
        /// 获取集群访问的地址
        ///
        /// 该API用于通过集群ID获取集群访问的地址，包括PrivateIP(HA集群返回VIP)与PublicIP
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterEndpointsResponse ShowClusterEndpoints(ShowClusterEndpointsRequest showClusterEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterEndpointsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/openapi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterEndpointsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterEndpointsResponse>(response);
        }

        public SyncInvoker<ShowClusterEndpointsResponse> ShowClusterEndpointsInvoker(ShowClusterEndpointsRequest showClusterEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterEndpointsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/openapi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterEndpointsRequest);
            return new SyncInvoker<ShowClusterEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterEndpointsResponse>);
        }
        
        /// <summary>
        /// 获取集群支持的可配置参数列表
        ///
        /// 该API用于根据集群版本类型等查询集群支持的详细配置项，用于集群创建时指定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterSupportConfigurationResponse ShowClusterSupportConfiguration(ShowClusterSupportConfigurationRequest showClusterSupportConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusters/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterSupportConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            var showClusterSupportConfigurationResponse = JsonUtils.DeSerializeNull<ShowClusterSupportConfigurationResponse>(response);
            showClusterSupportConfigurationResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
            return showClusterSupportConfigurationResponse;
        }

        public SyncInvoker<ShowClusterSupportConfigurationResponse> ShowClusterSupportConfigurationInvoker(ShowClusterSupportConfigurationRequest showClusterSupportConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusters/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterSupportConfigurationRequest);
            return new SyncInvoker<ShowClusterSupportConfigurationResponse>(this, "GET", request, response =>
            {
                var showClusterSupportConfigurationResponse = JsonUtils.DeSerializeNull<ShowClusterSupportConfigurationResponse>(response);
                showClusterSupportConfigurationResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
                return showClusterSupportConfigurationResponse;
            });
        }
        
        /// <summary>
        /// 获取集群升级相关信息
        ///
        /// 获取集群升级相关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterUpgradeInfoResponse ShowClusterUpgradeInfo(ShowClusterUpgradeInfoRequest showClusterUpgradeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterUpgradeInfoRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/upgradeinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterUpgradeInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterUpgradeInfoResponse>(response);
        }

        public SyncInvoker<ShowClusterUpgradeInfoResponse> ShowClusterUpgradeInfoInvoker(ShowClusterUpgradeInfoRequest showClusterUpgradeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterUpgradeInfoRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/upgradeinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterUpgradeInfoRequest);
            return new SyncInvoker<ShowClusterUpgradeInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterUpgradeInfoResponse>);
        }
        
        /// <summary>
        /// 查询特性开关状态
        ///
        /// 该API用于查询特性开关状态
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFeatureGatesResponse ShowFeatureGates(ShowFeatureGatesRequest showFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFeatureGatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFeatureGatesResponse>(response);
        }

        public SyncInvoker<ShowFeatureGatesResponse> ShowFeatureGatesInvoker(ShowFeatureGatesRequest showFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFeatureGatesRequest);
            return new SyncInvoker<ShowFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取任务信息
        ///
        /// 该API用于获取任务信息。通过某一任务请求下发后返回的jobID来查询指定任务的进度。
        /// &gt; - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// &gt; - 该接口通常使用场景为：
        /// &gt;   - 创建、删除集群时，查询相应任务的进度。
        /// &gt;   - 创建、删除节点时，查询相应任务的进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public SyncInvoker<ShowJobResponse> ShowJobInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new SyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
        /// <summary>
        /// 获取指定的节点
        ///
        /// 该API用于通过节点ID获取指定节点的详细信息。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNodeResponse ShowNode(ShowNodeRequest showNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNodeResponse>(response);
        }

        public SyncInvoker<ShowNodeResponse> ShowNodeInvoker(ShowNodeRequest showNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            return new SyncInvoker<ShowNodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodeResponse>);
        }
        
        /// <summary>
        /// 获取指定的节点池
        ///
        /// 该API用于获取指定节点池的详细信息。
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNodePoolResponse ShowNodePool(ShowNodePoolRequest showNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNodePoolResponse>(response);
        }

        public SyncInvoker<ShowNodePoolResponse> ShowNodePoolInvoker(ShowNodePoolRequest showNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            return new SyncInvoker<ShowNodePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodePoolResponse>);
        }
        
        /// <summary>
        /// 查询指定节点池支持配置的参数列表
        ///
        /// 该API用于查询CCE服务下指定节点池支持配置的参数列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNodePoolConfigurationDetailsResponse ShowNodePoolConfigurationDetails(ShowNodePoolConfigurationDetailsRequest showNodePoolConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolConfigurationDetailsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolConfigurationDetailsRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolConfigurationDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            var showNodePoolConfigurationDetailsResponse = JsonUtils.DeSerializeNull<ShowNodePoolConfigurationDetailsResponse>(response);
            showNodePoolConfigurationDetailsResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
            return showNodePoolConfigurationDetailsResponse;
        }

        public SyncInvoker<ShowNodePoolConfigurationDetailsResponse> ShowNodePoolConfigurationDetailsInvoker(ShowNodePoolConfigurationDetailsRequest showNodePoolConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolConfigurationDetailsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolConfigurationDetailsRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolConfigurationDetailsRequest);
            return new SyncInvoker<ShowNodePoolConfigurationDetailsResponse>(this, "GET", request, response =>
            {
                var showNodePoolConfigurationDetailsResponse = JsonUtils.DeSerializeNull<ShowNodePoolConfigurationDetailsResponse>(response);
                showNodePoolConfigurationDetailsResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
                return showNodePoolConfigurationDetailsResponse;
            });
        }
        
        /// <summary>
        /// 查询指定节点池支持配置的参数内容
        ///
        /// 该API用于查询指定节点池支持配置的参数内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNodePoolConfigurationsResponse ShowNodePoolConfigurations(ShowNodePoolConfigurationsRequest showNodePoolConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolConfigurationsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolConfigurationsRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNodePoolConfigurationsResponse>(response);
        }

        public SyncInvoker<ShowNodePoolConfigurationsResponse> ShowNodePoolConfigurationsInvoker(ShowNodePoolConfigurationsRequest showNodePoolConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolConfigurationsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showNodePoolConfigurationsRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolConfigurationsRequest);
            return new SyncInvoker<ShowNodePoolConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodePoolConfigurationsResponse>);
        }
        
        /// <summary>
        /// 获取分区详情
        ///
        /// 获取分区详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPartitionResponse ShowPartition(ShowPartitionRequest showPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPartitionRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionRequest.PartitionName, out var valueOfPartitionName)) urlParam.Add("partition_name", valueOfPartitionName);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions/{partition_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionResponse>(response);
        }

        public SyncInvoker<ShowPartitionResponse> ShowPartitionInvoker(ShowPartitionRequest showPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPartitionRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionRequest.PartitionName, out var valueOfPartitionName)) urlParam.Add("partition_name", valueOfPartitionName);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions/{partition_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionRequest);
            return new SyncInvoker<ShowPartitionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionResponse>);
        }
        
        /// <summary>
        /// 获取集群升级前检查任务详情
        ///
        /// 获取集群升级前检查任务详情，任务ID由调用集群检查API后从响应体中uid字段获取。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPreCheckResponse ShowPreCheck(ShowPreCheckRequest showPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPreCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showPreCheckRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreCheckRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPreCheckResponse>(response);
        }

        public SyncInvoker<ShowPreCheckResponse> ShowPreCheckInvoker(ShowPreCheckRequest showPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPreCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showPreCheckRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreCheckRequest);
            return new SyncInvoker<ShowPreCheckResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPreCheckResponse>);
        }
        
        /// <summary>
        /// 查询CCE服务下的资源配额
        ///
        /// 该API用于查询CCE服务下的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public SyncInvoker<ShowQuotasResponse> ShowQuotasInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new SyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 获取指定模板实例
        ///
        /// 获取指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReleaseResponse ShowRelease(ShowReleaseRequest showReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(showReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReleaseResponse>(response);
        }

        public SyncInvoker<ShowReleaseResponse> ShowReleaseInvoker(ShowReleaseRequest showReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(showReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseRequest);
            return new SyncInvoker<ShowReleaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReleaseResponse>);
        }
        
        /// <summary>
        /// 查询指定模板实例历史记录
        ///
        /// 查询指定模板实例历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReleaseHistoryResponse ShowReleaseHistory(ShowReleaseHistoryRequest showReleaseHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReleaseHistoryRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(showReleaseHistoryRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showReleaseHistoryRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            var showReleaseHistoryResponse = JsonUtils.DeSerializeNull<ShowReleaseHistoryResponse>(response);
            showReleaseHistoryResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
            return showReleaseHistoryResponse;
        }

        public SyncInvoker<ShowReleaseHistoryResponse> ShowReleaseHistoryInvoker(ShowReleaseHistoryRequest showReleaseHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReleaseHistoryRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(showReleaseHistoryRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showReleaseHistoryRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseHistoryRequest);
            return new SyncInvoker<ShowReleaseHistoryResponse>(this, "GET", request, response =>
            {
                var showReleaseHistoryResponse = JsonUtils.DeSerializeNull<ShowReleaseHistoryResponse>(response);
                showReleaseHistoryResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
                return showReleaseHistoryResponse;
            });
        }
        
        /// <summary>
        /// 获取集群升级任务详情
        ///
        /// 获取集群升级任务详情，任务ID由调用集群升级API后从响应体中uid字段获取。
        /// &gt; - 集群升级涉及多维度的组件升级操作，强烈建议统一通过CCE控制台执行交互式升级，降低集群升级过程的业务意外受损风险；
        /// &gt; - 当前集群升级相关接口受限开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpgradeClusterTaskResponse ShowUpgradeClusterTask(ShowUpgradeClusterTaskRequest showUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeClusterTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeClusterTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeClusterTaskResponse>(response);
        }

        public SyncInvoker<ShowUpgradeClusterTaskResponse> ShowUpgradeClusterTaskInvoker(ShowUpgradeClusterTaskRequest showUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeClusterTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeClusterTaskRequest);
            return new SyncInvoker<ShowUpgradeClusterTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 获取指定集群升级引导任务详情
        ///
        /// 该API用于通过升级引导任务ID获取任务的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpgradeWorkFlowResponse ShowUpgradeWorkFlow(ShowUpgradeWorkFlowRequest showUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeWorkFlowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeWorkFlowRequest.UpgradeWorkflowId, out var valueOfUpgradeWorkflowId)) urlParam.Add("upgrade_workflow_id", valueOfUpgradeWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeWorkFlowRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeWorkFlowResponse>(response);
        }

        public SyncInvoker<ShowUpgradeWorkFlowResponse> ShowUpgradeWorkFlowInvoker(ShowUpgradeWorkFlowRequest showUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeWorkFlowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeWorkFlowRequest.UpgradeWorkflowId, out var valueOfUpgradeWorkflowId)) urlParam.Add("upgrade_workflow_id", valueOfUpgradeWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeWorkFlowRequest);
            return new SyncInvoker<ShowUpgradeWorkFlowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeWorkFlowResponse>);
        }
        
        /// <summary>
        /// 获取用户模板配额
        ///
        /// 获取用户模板配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserChartsQuotasResponse ShowUserChartsQuotas(ShowUserChartsQuotasRequest showUserChartsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserChartsQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserChartsQuotasResponse>(response);
        }

        public SyncInvoker<ShowUserChartsQuotasResponse> ShowUserChartsQuotasInvoker(ShowUserChartsQuotasRequest showUserChartsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserChartsQuotasRequest);
            return new SyncInvoker<ShowUserChartsQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserChartsQuotasResponse>);
        }
        
        /// <summary>
        /// 同步节点
        ///
        /// 该API用于同步节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SyncNodeResponse SyncNode(SyncNodeRequest syncNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(syncNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/api/v2/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncNodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<SyncNodeResponse>(response);
        }

        public SyncInvoker<SyncNodeResponse> SyncNodeInvoker(SyncNodeRequest syncNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(syncNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/api/v2/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncNodeRequest);
            return new SyncInvoker<SyncNodeResponse>(this, "GET", request, JsonUtils.DeSerializeNull<SyncNodeResponse>);
        }
        
        /// <summary>
        /// 节点关闭缩容保护。
        ///
        /// 该API用于节点关闭缩容保护，关闭缩容保护的节点可以通过修改节点池个数的方式被缩容，只允许按需节点关闭缩容保护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnlockNodepoolNodeScaleDownResponse UnlockNodepoolNodeScaleDown(UnlockNodepoolNodeScaleDownRequest unlockNodepoolNodeScaleDownRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unlockNodepoolNodeScaleDownRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/unlocknodescaledown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockNodepoolNodeScaleDownRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UnlockNodepoolNodeScaleDownResponse>(response);
        }

        public SyncInvoker<UnlockNodepoolNodeScaleDownResponse> UnlockNodepoolNodeScaleDownInvoker(UnlockNodepoolNodeScaleDownRequest unlockNodepoolNodeScaleDownRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unlockNodepoolNodeScaleDownRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/unlocknodescaledown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockNodepoolNodeScaleDownRequest);
            return new SyncInvoker<UnlockNodepoolNodeScaleDownResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UnlockNodepoolNodeScaleDownResponse>);
        }
        
        /// <summary>
        /// 更新访问策略
        ///
        /// 该API用于更新单个访问策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAccessPolicyResponse UpdateAccessPolicy(UpdateAccessPolicyRequest updateAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAccessPolicyResponse>(response);
        }

        public SyncInvoker<UpdateAccessPolicyResponse> UpdateAccessPolicyInvoker(UpdateAccessPolicyRequest updateAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/access-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyRequest);
            return new SyncInvoker<UpdateAccessPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 更新AddonInstance
        ///
        /// 更新插件实例的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAddonInstanceResponse UpdateAddonInstance(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddonInstanceResponse>(response);
        }

        public SyncInvoker<UpdateAddonInstanceResponse> UpdateAddonInstanceInvoker(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            return new SyncInvoker<UpdateAddonInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 更新模板
        ///
        /// 更新模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateChartResponse UpdateChart(UpdateChartRequest updateChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateChartRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateChartResponse>(response);
        }

        public SyncInvoker<UpdateChartResponse> UpdateChartInvoker(UpdateChartRequest updateChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateChartRequest);
            return new SyncInvoker<UpdateChartResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateChartResponse>);
        }
        
        /// <summary>
        /// 更新指定的集群
        ///
        /// 该API用于更新指定的集群。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterResponse UpdateCluster(UpdateClusterRequest updateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClusterResponse>(response);
        }

        public SyncInvoker<UpdateClusterResponse> UpdateClusterInvoker(UpdateClusterRequest updateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            return new SyncInvoker<UpdateClusterResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClusterResponse>);
        }
        
        /// <summary>
        /// 绑定、解绑集群公网apiserver地址
        ///
        /// 该API用于通过集群ID绑定、解绑集群公网apiserver地址
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterEipResponse UpdateClusterEip(UpdateClusterEipRequest updateClusterEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterEipRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/mastereip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterEipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClusterEipResponse>(response);
        }

        public SyncInvoker<UpdateClusterEipResponse> UpdateClusterEipInvoker(UpdateClusterEipRequest updateClusterEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterEipRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/mastereip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterEipRequest);
            return new SyncInvoker<UpdateClusterEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClusterEipResponse>);
        }
        
        /// <summary>
        /// 配置集群日志
        ///
        /// 用户可以选择集群管理节点上哪些组件的日志上报LTS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterLogConfigResponse UpdateClusterLogConfig(UpdateClusterLogConfigRequest updateClusterLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterLogConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterLogConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClusterLogConfigResponse>(response);
        }

        public SyncInvoker<UpdateClusterLogConfigResponse> UpdateClusterLogConfigInvoker(UpdateClusterLogConfigRequest updateClusterLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterLogConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterLogConfigRequest);
            return new SyncInvoker<UpdateClusterLogConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClusterLogConfigResponse>);
        }
        
        /// <summary>
        /// 更新集群LongAKSK配置
        ///
        /// 该API用于更新集群LongAKSK的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterLongAkskConfigResponse UpdateClusterLongAkskConfig(UpdateClusterLongAkskConfigRequest updateClusterLongAkskConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterLongAkskConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/longaksk/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterLongAkskConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterLongAkskConfigResponse>(response);
        }

        public SyncInvoker<UpdateClusterLongAkskConfigResponse> UpdateClusterLongAkskConfigInvoker(UpdateClusterLongAkskConfigRequest updateClusterLongAkskConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterLongAkskConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/longaksk/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterLongAkskConfigRequest);
            return new SyncInvoker<UpdateClusterLongAkskConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterLongAkskConfigResponse>);
        }
        
        /// <summary>
        /// 更新项目LongAKSK配置
        ///
        /// 该API用于更新项目longaksk的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLongAkskConfigResponse UpdateLongAkskConfig(UpdateLongAkskConfigRequest updateLongAkskConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/longaksk/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLongAkskConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateLongAkskConfigResponse>(response);
        }

        public SyncInvoker<UpdateLongAkskConfigResponse> UpdateLongAkskConfigInvoker(UpdateLongAkskConfigRequest updateLongAkskConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/longaksk/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLongAkskConfigRequest);
            return new SyncInvoker<UpdateLongAkskConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateLongAkskConfigResponse>);
        }
        
        /// <summary>
        /// 更新指定的节点
        ///
        /// 该API用于更新指定的节点。
        /// &gt; - 当前仅支持更新metadata下的name字段，即节点的名字。
        /// &gt; - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNodeResponse UpdateNode(UpdateNodeRequest updateNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updateNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNodeResponse>(response);
        }

        public SyncInvoker<UpdateNodeResponse> UpdateNodeInvoker(UpdateNodeRequest updateNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNodeRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updateNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodeRequest);
            return new SyncInvoker<UpdateNodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNodeResponse>);
        }
        
        /// <summary>
        /// 更新指定节点池
        ///
        /// 该API用于更新指定的节点池。仅支持集群在处于可用、扩容、缩容状态时调用。
        /// 
        /// 
        /// &gt; - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// &gt; - 当前仅支持更新节点池名称，spec下的initialNodeCount，k8sTags，taints，login，userTags与节点池的扩缩容配置相关字段。
        /// &gt; - 若此次更新节点池未设置initialNodeCount的相关值，节点池期望节点个数将默认更新为初始值0，如果此时节点池节点个数大于0将导致节点池缩容。若用户期望不填该参数，请在此次更新设置spec下的ignoreInitialNodeCount为true，用于忽略spec.initialNodeCount参数。特殊场景说明：若节点池当前节点数等于0时，可忽略initialNodeCount和ignoreInitialNodeCount参数配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNodePoolResponse UpdateNodePool(UpdateNodePoolRequest updateNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updateNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNodePoolResponse>(response);
        }

        public SyncInvoker<UpdateNodePoolResponse> UpdateNodePoolInvoker(UpdateNodePoolRequest updateNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updateNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolRequest);
            return new SyncInvoker<UpdateNodePoolResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNodePoolResponse>);
        }
        
        /// <summary>
        /// 修改指定节点池配置参数的值
        ///
        /// 该API用于修改CCE服务下指定节点池配置参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNodePoolConfigurationResponse UpdateNodePoolConfiguration(UpdateNodePoolConfigurationRequest updateNodePoolConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNodePoolConfigurationRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updateNodePoolConfigurationRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNodePoolConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateNodePoolConfigurationResponse> UpdateNodePoolConfigurationInvoker(UpdateNodePoolConfigurationRequest updateNodePoolConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNodePoolConfigurationRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updateNodePoolConfigurationRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolConfigurationRequest);
            return new SyncInvoker<UpdateNodePoolConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNodePoolConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新分区
        ///
        /// 更新分区
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePartitionResponse UpdatePartition(UpdatePartitionRequest updatePartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePartitionRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updatePartitionRequest.PartitionName, out var valueOfPartitionName)) urlParam.Add("partition_name", valueOfPartitionName);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions/{partition_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePartitionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePartitionResponse>(response);
        }

        public SyncInvoker<UpdatePartitionResponse> UpdatePartitionInvoker(UpdatePartitionRequest updatePartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePartitionRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updatePartitionRequest.PartitionName, out var valueOfPartitionName)) urlParam.Add("partition_name", valueOfPartitionName);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions/{partition_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePartitionRequest);
            return new SyncInvoker<UpdatePartitionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePartitionResponse>);
        }
        
        /// <summary>
        /// 更新指定模板实例
        ///
        /// 更新指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateReleaseResponse UpdateRelease(UpdateReleaseRequest updateReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(updateReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReleaseRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReleaseResponse>(response);
        }

        public SyncInvoker<UpdateReleaseResponse> UpdateReleaseInvoker(UpdateReleaseRequest updateReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(updateReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReleaseRequest);
            return new SyncInvoker<UpdateReleaseResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReleaseResponse>);
        }
        
        /// <summary>
        /// 集群升级
        ///
        /// 集群升级。
        /// &gt; - 集群升级涉及多维度的组件升级操作，强烈建议统一通过CCE控制台执行交互式升级，降低集群升级过程的业务意外受损风险；
        /// &gt; - 当前集群升级相关接口受限开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeClusterResponse UpgradeCluster(UpgradeClusterRequest upgradeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeClusterResponse>(response);
        }

        public SyncInvoker<UpgradeClusterResponse> UpgradeClusterInvoker(UpgradeClusterRequest upgradeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeClusterRequest);
            return new SyncInvoker<UpgradeClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeClusterResponse>);
        }
        
        /// <summary>
        /// 同步节点池
        ///
        /// 该API用于同步节点池中已有节点的配置
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeNodePoolResponse UpgradeNodePool(UpgradeNodePoolRequest upgradeNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(upgradeNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeNodePoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeNodePoolResponse>(response);
        }

        public SyncInvoker<UpgradeNodePoolResponse> UpgradeNodePoolInvoker(UpgradeNodePoolRequest upgradeNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeNodePoolRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(upgradeNodePoolRequest.NodepoolId, out var valueOfNodepoolId)) urlParam.Add("nodepool_id", valueOfNodepoolId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeNodePoolRequest);
            return new SyncInvoker<UpgradeNodePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeNodePoolResponse>);
        }
        
        /// <summary>
        /// 更新指定集群升级引导任务状态
        ///
        /// 该API用于更新指定集群升级引导任务状态，当前仅适用于取消升级流程
        /// 调用该API时升级流程引导任务状态不能为进行中(running) 已完成(success) 已取消(cancel),升级子任务状态不能为running(进行中) init(已初始化) pause(任务被暂停) queue(队列中)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeWorkFlowUpdateResponse UpgradeWorkFlowUpdate(UpgradeWorkFlowUpdateRequest upgradeWorkFlowUpdateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeWorkFlowUpdateRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(upgradeWorkFlowUpdateRequest.UpgradeWorkflowId, out var valueOfUpgradeWorkflowId)) urlParam.Add("upgrade_workflow_id", valueOfUpgradeWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeWorkFlowUpdateRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpgradeWorkFlowUpdateResponse>(response);
        }

        public SyncInvoker<UpgradeWorkFlowUpdateResponse> UpgradeWorkFlowUpdateInvoker(UpgradeWorkFlowUpdateRequest upgradeWorkFlowUpdateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeWorkFlowUpdateRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(upgradeWorkFlowUpdateRequest.UpgradeWorkflowId, out var valueOfUpgradeWorkflowId)) urlParam.Add("upgrade_workflow_id", valueOfUpgradeWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeWorkFlowUpdateRequest);
            return new SyncInvoker<UpgradeWorkFlowUpdateResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpgradeWorkFlowUpdateResponse>);
        }
        
        /// <summary>
        /// 上传模板
        ///
        /// 上传模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadChartResponse UploadChart(UploadChartRequest uploadChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadChartRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadChartResponse>(response);
        }

        public SyncInvoker<UploadChartResponse> UploadChartInvoker(UploadChartRequest uploadChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadChartRequest);
            return new SyncInvoker<UploadChartResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadChartResponse>);
        }
        
        /// <summary>
        /// 查询API版本信息列表
        ///
        /// 该API用于查询CCE服务当前支持的API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVersionResponse ShowVersion(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }

        public SyncInvoker<ShowVersionResponse> ShowVersionInvoker(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            return new SyncInvoker<ShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionResponse>);
        }
        
        /// <summary>
        /// 批量添加指定集群的资源标签
        ///
        /// 该API用于批量添加指定集群的资源标签。
        /// &gt; - 每个集群支持最多20个资源标签。
        /// &gt; - 此接口为幂等接口：创建时，如果创建的标签已经存在（key/value均相同视为重复），默认处理成功；key相同，value不同时会覆盖原有标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateAutopilotClusterTagsResponse BatchCreateAutopilotClusterTags(BatchCreateAutopilotClusterTagsRequest batchCreateAutopilotClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateAutopilotClusterTagsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAutopilotClusterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateAutopilotClusterTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateAutopilotClusterTagsResponse> BatchCreateAutopilotClusterTagsInvoker(BatchCreateAutopilotClusterTagsRequest batchCreateAutopilotClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateAutopilotClusterTagsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAutopilotClusterTagsRequest);
            return new SyncInvoker<BatchCreateAutopilotClusterTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateAutopilotClusterTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除指定集群的资源标签
        ///
        /// 该API用于批量删除指定集群的资源标签。
        /// &gt; - 此接口为幂等接口：删除时，如果删除的标签key不存在，默认处理成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAutopilotClusterTagsResponse BatchDeleteAutopilotClusterTags(BatchDeleteAutopilotClusterTagsRequest batchDeleteAutopilotClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteAutopilotClusterTagsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAutopilotClusterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAutopilotClusterTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteAutopilotClusterTagsResponse> BatchDeleteAutopilotClusterTagsInvoker(BatchDeleteAutopilotClusterTagsRequest batchDeleteAutopilotClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteAutopilotClusterTagsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAutopilotClusterTagsRequest);
            return new SyncInvoker<BatchDeleteAutopilotClusterTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAutopilotClusterTagsResponse>);
        }
        
        /// <summary>
        /// 创建AddonInstance
        ///
        /// 根据提供的插件模板，安装插件实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotAddonInstanceResponse CreateAutopilotAddonInstance(CreateAutopilotAddonInstanceRequest createAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotAddonInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotAddonInstanceResponse>(response);
        }

        public SyncInvoker<CreateAutopilotAddonInstanceResponse> CreateAutopilotAddonInstanceInvoker(CreateAutopilotAddonInstanceRequest createAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotAddonInstanceRequest);
            return new SyncInvoker<CreateAutopilotAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 创建集群
        ///
        /// 该API用于创建一个空集群（即只有控制节点Master，没有工作节点Node）。
        /// 
        /// 
        /// &gt;   - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// &gt;   - 调用该接口创建集群时，默认不安装ICAgent，若需安装ICAgent，可在请求Body参数的annotations中加入\&quot;cluster.install.addons.external/install\&quot;:\&quot;[{\&quot;addonTemplateName\&quot;:\&quot;icagent\&quot;}]\&quot;的集群注解，将在创建集群时自动安装ICAgent。ICAgent是应用性能管理APM的采集代理，运行在应用所在的服务器上，用于实时采集探针所获取的数据，安装ICAgent是使用应用性能管理APM的前提。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotClusterResponse CreateAutopilotCluster(CreateAutopilotClusterRequest createAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotClusterResponse>(response);
        }

        public SyncInvoker<CreateAutopilotClusterResponse> CreateAutopilotClusterInvoker(CreateAutopilotClusterRequest createAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotClusterRequest);
            return new SyncInvoker<CreateAutopilotClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 集群备份
        ///
        /// 集群备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotClusterMasterSnapshotResponse CreateAutopilotClusterMasterSnapshot(CreateAutopilotClusterMasterSnapshotRequest createAutopilotClusterMasterSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotClusterMasterSnapshotRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotClusterMasterSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotClusterMasterSnapshotResponse>(response);
        }

        public SyncInvoker<CreateAutopilotClusterMasterSnapshotResponse> CreateAutopilotClusterMasterSnapshotInvoker(CreateAutopilotClusterMasterSnapshotRequest createAutopilotClusterMasterSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotClusterMasterSnapshotRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotClusterMasterSnapshotRequest);
            return new SyncInvoker<CreateAutopilotClusterMasterSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotClusterMasterSnapshotResponse>);
        }
        
        /// <summary>
        /// 获取集群证书
        ///
        /// 该API用于获取指定集群的证书信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotKubernetesClusterCertResponse CreateAutopilotKubernetesClusterCert(CreateAutopilotKubernetesClusterCertRequest createAutopilotKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotKubernetesClusterCertRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/clustercert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotKubernetesClusterCertRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotKubernetesClusterCertResponse>(response);
        }

        public SyncInvoker<CreateAutopilotKubernetesClusterCertResponse> CreateAutopilotKubernetesClusterCertInvoker(CreateAutopilotKubernetesClusterCertRequest createAutopilotKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotKubernetesClusterCertRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/clustercert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotKubernetesClusterCertRequest);
            return new SyncInvoker<CreateAutopilotKubernetesClusterCertResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotKubernetesClusterCertResponse>);
        }
        
        /// <summary>
        /// 创建集群维护窗口
        ///
        /// 该API用于创建集群维护窗口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotMaintenanceWindowResponse CreateAutopilotMaintenanceWindow(CreateAutopilotMaintenanceWindowRequest createAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotMaintenanceWindowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotMaintenanceWindowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotMaintenanceWindowResponse>(response);
        }

        public SyncInvoker<CreateAutopilotMaintenanceWindowResponse> CreateAutopilotMaintenanceWindowInvoker(CreateAutopilotMaintenanceWindowRequest createAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotMaintenanceWindowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotMaintenanceWindowRequest);
            return new SyncInvoker<CreateAutopilotMaintenanceWindowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 集群升级后确认
        ///
        /// 集群升级后确认，该接口建议配合Console使用，主要用于升级步骤完成后，客户确认集群状态和业务正常后做反馈。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotPostCheckResponse CreateAutopilotPostCheck(CreateAutopilotPostCheckRequest createAutopilotPostCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotPostCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/postcheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotPostCheckRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotPostCheckResponse>(response);
        }

        public SyncInvoker<CreateAutopilotPostCheckResponse> CreateAutopilotPostCheckInvoker(CreateAutopilotPostCheckRequest createAutopilotPostCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotPostCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/postcheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotPostCheckRequest);
            return new SyncInvoker<CreateAutopilotPostCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotPostCheckResponse>);
        }
        
        /// <summary>
        /// 集群升级前检查
        ///
        /// 集群升级前检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotPreCheckResponse CreateAutopilotPreCheck(CreateAutopilotPreCheckRequest createAutopilotPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotPreCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotPreCheckRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotPreCheckResponse>(response);
        }

        public SyncInvoker<CreateAutopilotPreCheckResponse> CreateAutopilotPreCheckInvoker(CreateAutopilotPreCheckRequest createAutopilotPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotPreCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotPreCheckRequest);
            return new SyncInvoker<CreateAutopilotPreCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotPreCheckResponse>);
        }
        
        /// <summary>
        /// 创建模板实例
        ///
        /// 创建模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotReleaseResponse CreateAutopilotRelease(CreateAutopilotReleaseRequest createAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotReleaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotReleaseResponse>(response);
        }

        public SyncInvoker<CreateAutopilotReleaseResponse> CreateAutopilotReleaseInvoker(CreateAutopilotReleaseRequest createAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotReleaseRequest);
            return new SyncInvoker<CreateAutopilotReleaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotReleaseResponse>);
        }
        
        /// <summary>
        /// 开启集群升级流程引导任务
        ///
        /// 该API用于创建一个集群升级流程引导任务。请在调用本接口完成引导任务创建之后，通过集群升级前检查开始检查任务。
        /// 升级流程任务用于控制集群升级任务的执行流程，执行流程为 升级前检查 &#x3D;&gt; 集群升级 &#x3D;&gt; 升级后检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAutopilotUpgradeWorkFlowResponse CreateAutopilotUpgradeWorkFlow(CreateAutopilotUpgradeWorkFlowRequest createAutopilotUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotUpgradeWorkFlowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotUpgradeWorkFlowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotUpgradeWorkFlowResponse>(response);
        }

        public SyncInvoker<CreateAutopilotUpgradeWorkFlowResponse> CreateAutopilotUpgradeWorkFlowInvoker(CreateAutopilotUpgradeWorkFlowRequest createAutopilotUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutopilotUpgradeWorkFlowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotUpgradeWorkFlowRequest);
            return new SyncInvoker<CreateAutopilotUpgradeWorkFlowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotUpgradeWorkFlowResponse>);
        }
        
        /// <summary>
        /// 删除AddonInstance
        ///
        /// 删除插件实例的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAutopilotAddonInstanceResponse DeleteAutopilotAddonInstance(DeleteAutopilotAddonInstanceRequest deleteAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotAddonInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAutopilotAddonInstanceResponse>(response);
        }

        public SyncInvoker<DeleteAutopilotAddonInstanceResponse> DeleteAutopilotAddonInstanceInvoker(DeleteAutopilotAddonInstanceRequest deleteAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotAddonInstanceRequest);
            return new SyncInvoker<DeleteAutopilotAddonInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 删除模板
        ///
        /// 删除模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAutopilotChartResponse DeleteAutopilotChart(DeleteAutopilotChartRequest deleteAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotChartRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAutopilotChartResponse>(response);
        }

        public SyncInvoker<DeleteAutopilotChartResponse> DeleteAutopilotChartInvoker(DeleteAutopilotChartRequest deleteAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotChartRequest);
            return new SyncInvoker<DeleteAutopilotChartResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 删除集群
        ///
        /// 该API用于删除一个指定的集群。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAutopilotClusterResponse DeleteAutopilotCluster(DeleteAutopilotClusterRequest deleteAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotClusterRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAutopilotClusterResponse>(response);
        }

        public SyncInvoker<DeleteAutopilotClusterResponse> DeleteAutopilotClusterInvoker(DeleteAutopilotClusterRequest deleteAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotClusterRequest);
            return new SyncInvoker<DeleteAutopilotClusterResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 删除集群维护窗口
        ///
        /// 该API用于删除集群维护窗口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAutopilotMaintenanceWindowResponse DeleteAutopilotMaintenanceWindow(DeleteAutopilotMaintenanceWindowRequest deleteAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotMaintenanceWindowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotMaintenanceWindowRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAutopilotMaintenanceWindowResponse>(response);
        }

        public SyncInvoker<DeleteAutopilotMaintenanceWindowResponse> DeleteAutopilotMaintenanceWindowInvoker(DeleteAutopilotMaintenanceWindowRequest deleteAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotMaintenanceWindowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotMaintenanceWindowRequest);
            return new SyncInvoker<DeleteAutopilotMaintenanceWindowResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAutopilotMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 删除指定模板实例
        ///
        /// 删除指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAutopilotReleaseResponse DeleteAutopilotRelease(DeleteAutopilotReleaseRequest deleteAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotReleaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAutopilotReleaseResponse>(response);
        }

        public SyncInvoker<DeleteAutopilotReleaseResponse> DeleteAutopilotReleaseInvoker(DeleteAutopilotReleaseRequest deleteAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotReleaseRequest);
            return new SyncInvoker<DeleteAutopilotReleaseResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAutopilotReleaseResponse>);
        }
        
        /// <summary>
        /// 下载模板
        ///
        /// 下载模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadAutopilotChartResponse DownloadAutopilotChart(DownloadAutopilotChartRequest downloadAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAutopilotChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAutopilotChartRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadAutopilotChartResponse>(response);
        }

        public SyncInvoker<DownloadAutopilotChartResponse> DownloadAutopilotChartInvoker(DownloadAutopilotChartRequest downloadAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAutopilotChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAutopilotChartRequest);
            return new SyncInvoker<DownloadAutopilotChartResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 获取AddonInstance列表
        ///
        /// 获取集群所有已安装插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotAddonInstancesResponse ListAutopilotAddonInstances(ListAutopilotAddonInstancesRequest listAutopilotAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotAddonInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotAddonInstancesResponse>(response);
        }

        public SyncInvoker<ListAutopilotAddonInstancesResponse> ListAutopilotAddonInstancesInvoker(ListAutopilotAddonInstancesRequest listAutopilotAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotAddonInstancesRequest);
            return new SyncInvoker<ListAutopilotAddonInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotAddonInstancesResponse>);
        }
        
        /// <summary>
        /// 查询AddonTemplates列表
        ///
        /// 插件模板查询接口，查询插件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotAddonTemplatesResponse ListAutopilotAddonTemplates(ListAutopilotAddonTemplatesRequest listAutopilotAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotAddonTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotAddonTemplatesResponse>(response);
        }

        public SyncInvoker<ListAutopilotAddonTemplatesResponse> ListAutopilotAddonTemplatesInvoker(ListAutopilotAddonTemplatesRequest listAutopilotAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotAddonTemplatesRequest);
            return new SyncInvoker<ListAutopilotAddonTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotAddonTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取模板列表
        ///
        /// 获取模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotChartsResponse ListAutopilotCharts(ListAutopilotChartsRequest listAutopilotChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotChartsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listAutopilotChartsResponse = JsonUtils.DeSerializeNull<ListAutopilotChartsResponse>(response);
            listAutopilotChartsResponse.Body = JsonUtils.DeSerializeList<ChartResp>(response);
            return listAutopilotChartsResponse;
        }

        public SyncInvoker<ListAutopilotChartsResponse> ListAutopilotChartsInvoker(ListAutopilotChartsRequest listAutopilotChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotChartsRequest);
            return new SyncInvoker<ListAutopilotChartsResponse>(this, "GET", request, response =>
            {
                var listAutopilotChartsResponse = JsonUtils.DeSerializeNull<ListAutopilotChartsResponse>(response);
                listAutopilotChartsResponse.Body = JsonUtils.DeSerializeList<ChartResp>(response);
                return listAutopilotChartsResponse;
            });
        }
        
        /// <summary>
        /// 获取集群备份任务详情列表
        ///
        /// 获取集群备份任务详情列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotClusterMasterSnapshotTasksResponse ListAutopilotClusterMasterSnapshotTasks(ListAutopilotClusterMasterSnapshotTasksRequest listAutopilotClusterMasterSnapshotTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotClusterMasterSnapshotTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterMasterSnapshotTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotClusterMasterSnapshotTasksResponse>(response);
        }

        public SyncInvoker<ListAutopilotClusterMasterSnapshotTasksResponse> ListAutopilotClusterMasterSnapshotTasksInvoker(ListAutopilotClusterMasterSnapshotTasksRequest listAutopilotClusterMasterSnapshotTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotClusterMasterSnapshotTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterMasterSnapshotTasksRequest);
            return new SyncInvoker<ListAutopilotClusterMasterSnapshotTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotClusterMasterSnapshotTasksResponse>);
        }
        
        /// <summary>
        /// 获取集群升级特性开关配置
        ///
        /// 获取集群升级特性开关配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotClusterUpgradeFeatureGatesResponse ListAutopilotClusterUpgradeFeatureGates(ListAutopilotClusterUpgradeFeatureGatesRequest listAutopilotClusterUpgradeFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/clusterupgradefeaturegates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterUpgradeFeatureGatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotClusterUpgradeFeatureGatesResponse>(response);
        }

        public SyncInvoker<ListAutopilotClusterUpgradeFeatureGatesResponse> ListAutopilotClusterUpgradeFeatureGatesInvoker(ListAutopilotClusterUpgradeFeatureGatesRequest listAutopilotClusterUpgradeFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/clusterupgradefeaturegates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterUpgradeFeatureGatesRequest);
            return new SyncInvoker<ListAutopilotClusterUpgradeFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotClusterUpgradeFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取集群升级路径
        ///
        /// 获取集群升级路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotClusterUpgradePathsResponse ListAutopilotClusterUpgradePaths(ListAutopilotClusterUpgradePathsRequest listAutopilotClusterUpgradePathsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/clusterupgradepaths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterUpgradePathsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotClusterUpgradePathsResponse>(response);
        }

        public SyncInvoker<ListAutopilotClusterUpgradePathsResponse> ListAutopilotClusterUpgradePathsInvoker(ListAutopilotClusterUpgradePathsRequest listAutopilotClusterUpgradePathsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/clusterupgradepaths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterUpgradePathsRequest);
            return new SyncInvoker<ListAutopilotClusterUpgradePathsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotClusterUpgradePathsResponse>);
        }
        
        /// <summary>
        /// 获取指定项目下的集群
        ///
        /// 该API用于获取指定项目下所有集群的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotClustersResponse ListAutopilotClusters(ListAutopilotClustersRequest listAutopilotClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClustersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotClustersResponse>(response);
        }

        public SyncInvoker<ListAutopilotClustersResponse> ListAutopilotClustersInvoker(ListAutopilotClustersRequest listAutopilotClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClustersRequest);
            return new SyncInvoker<ListAutopilotClustersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotClustersResponse>);
        }
        
        /// <summary>
        /// 获取集群升级前检查任务详情列表
        ///
        /// 获取集群升级前检查任务详情列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotPreCheckTasksResponse ListAutopilotPreCheckTasks(ListAutopilotPreCheckTasksRequest listAutopilotPreCheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotPreCheckTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotPreCheckTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotPreCheckTasksResponse>(response);
        }

        public SyncInvoker<ListAutopilotPreCheckTasksResponse> ListAutopilotPreCheckTasksInvoker(ListAutopilotPreCheckTasksRequest listAutopilotPreCheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotPreCheckTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotPreCheckTasksRequest);
            return new SyncInvoker<ListAutopilotPreCheckTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotPreCheckTasksResponse>);
        }
        
        /// <summary>
        /// 获取模板实例列表
        ///
        /// 获取模板实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotReleasesResponse ListAutopilotReleases(ListAutopilotReleasesRequest listAutopilotReleasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotReleasesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotReleasesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listAutopilotReleasesResponse = JsonUtils.DeSerializeNull<ListAutopilotReleasesResponse>(response);
            listAutopilotReleasesResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
            return listAutopilotReleasesResponse;
        }

        public SyncInvoker<ListAutopilotReleasesResponse> ListAutopilotReleasesInvoker(ListAutopilotReleasesRequest listAutopilotReleasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotReleasesRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotReleasesRequest);
            return new SyncInvoker<ListAutopilotReleasesResponse>(this, "GET", request, response =>
            {
                var listAutopilotReleasesResponse = JsonUtils.DeSerializeNull<ListAutopilotReleasesResponse>(response);
                listAutopilotReleasesResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
                return listAutopilotReleasesResponse;
            });
        }
        
        /// <summary>
        /// 获取集群升级任务详情列表
        ///
        /// 获取集群升级任务详情列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotUpgradeClusterTasksResponse ListAutopilotUpgradeClusterTasks(ListAutopilotUpgradeClusterTasksRequest listAutopilotUpgradeClusterTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotUpgradeClusterTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradeClusterTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotUpgradeClusterTasksResponse>(response);
        }

        public SyncInvoker<ListAutopilotUpgradeClusterTasksResponse> ListAutopilotUpgradeClusterTasksInvoker(ListAutopilotUpgradeClusterTasksRequest listAutopilotUpgradeClusterTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotUpgradeClusterTasksRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradeClusterTasksRequest);
            return new SyncInvoker<ListAutopilotUpgradeClusterTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotUpgradeClusterTasksResponse>);
        }
        
        /// <summary>
        /// 获取自动升级计划
        ///
        /// 该API用于获取集群自动升级计划。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotUpgradePlansResponse ListAutopilotUpgradePlans(ListAutopilotUpgradePlansRequest listAutopilotUpgradePlansRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotUpgradePlansRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeplans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradePlansRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotUpgradePlansResponse>(response);
        }

        public SyncInvoker<ListAutopilotUpgradePlansResponse> ListAutopilotUpgradePlansInvoker(ListAutopilotUpgradePlansRequest listAutopilotUpgradePlansRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotUpgradePlansRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeplans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradePlansRequest);
            return new SyncInvoker<ListAutopilotUpgradePlansResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotUpgradePlansResponse>);
        }
        
        /// <summary>
        /// 获取UpgradeWorkFlows列表
        ///
        /// 获取历史集群升级引导任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotUpgradeWorkFlowsResponse ListAutopilotUpgradeWorkFlows(ListAutopilotUpgradeWorkFlowsRequest listAutopilotUpgradeWorkFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotUpgradeWorkFlowsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradeWorkFlowsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotUpgradeWorkFlowsResponse>(response);
        }

        public SyncInvoker<ListAutopilotUpgradeWorkFlowsResponse> ListAutopilotUpgradeWorkFlowsInvoker(ListAutopilotUpgradeWorkFlowsRequest listAutopilotUpgradeWorkFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAutopilotUpgradeWorkFlowsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradeWorkFlowsRequest);
            return new SyncInvoker<ListAutopilotUpgradeWorkFlowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotUpgradeWorkFlowsResponse>);
        }
        
        /// <summary>
        /// 重试集群升级任务
        ///
        /// 重新执行失败的集群升级任务。
        /// &gt; - 集群升级涉及多维度的组件升级操作，强烈建议统一通过CCE控制台执行交互式升级，降低集群升级过程的业务意外受损风险；
        /// &gt; - 当前集群升级相关接口受限开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryAutopilotUpgradeClusterTaskResponse RetryAutopilotUpgradeClusterTask(RetryAutopilotUpgradeClusterTaskRequest retryAutopilotUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryAutopilotUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryAutopilotUpgradeClusterTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RetryAutopilotUpgradeClusterTaskResponse>(response);
        }

        public SyncInvoker<RetryAutopilotUpgradeClusterTaskResponse> RetryAutopilotUpgradeClusterTaskInvoker(RetryAutopilotUpgradeClusterTaskRequest retryAutopilotUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryAutopilotUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryAutopilotUpgradeClusterTaskRequest);
            return new SyncInvoker<RetryAutopilotUpgradeClusterTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryAutopilotUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 回滚AddonInstance
        ///
        /// 将插件实例回滚到升级前的版本。只有在当前插件实例版本支持回滚到升级前的版本（status.isRollbackable为true），且插件实例状态为running（运行中）、available（可用）、abnormal（不可用）、upgradeFailed（升级失败）、rollbackFailed（回滚失败）时支持回滚。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RollbackAutopilotAddonInstanceResponse RollbackAutopilotAddonInstance(RollbackAutopilotAddonInstanceRequest rollbackAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollbackAutopilotAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}/operation/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackAutopilotAddonInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RollbackAutopilotAddonInstanceResponse>(response);
        }

        public SyncInvoker<RollbackAutopilotAddonInstanceResponse> RollbackAutopilotAddonInstanceInvoker(RollbackAutopilotAddonInstanceRequest rollbackAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollbackAutopilotAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}/operation/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackAutopilotAddonInstanceRequest);
            return new SyncInvoker<RollbackAutopilotAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RollbackAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 获取AddonInstance详情
        ///
        /// 获取插件实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotAddonInstanceResponse ShowAutopilotAddonInstance(ShowAutopilotAddonInstanceRequest showAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotAddonInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotAddonInstanceResponse>(response);
        }

        public SyncInvoker<ShowAutopilotAddonInstanceResponse> ShowAutopilotAddonInstanceInvoker(ShowAutopilotAddonInstanceRequest showAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotAddonInstanceRequest);
            return new SyncInvoker<ShowAutopilotAddonInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 获取模板
        ///
        /// 获取模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotChartResponse ShowAutopilotChart(ShowAutopilotChartRequest showAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotChartRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotChartResponse>(response);
        }

        public SyncInvoker<ShowAutopilotChartResponse> ShowAutopilotChartInvoker(ShowAutopilotChartRequest showAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotChartRequest);
            return new SyncInvoker<ShowAutopilotChartResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 获取模板Values
        ///
        /// 获取模板Values
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotChartValuesResponse ShowAutopilotChartValues(ShowAutopilotChartValuesRequest showAutopilotChartValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotChartValuesRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotChartValuesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotChartValuesResponse>(response);
        }

        public SyncInvoker<ShowAutopilotChartValuesResponse> ShowAutopilotChartValuesInvoker(ShowAutopilotChartValuesRequest showAutopilotChartValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotChartValuesRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotChartValuesRequest);
            return new SyncInvoker<ShowAutopilotChartValuesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotChartValuesResponse>);
        }
        
        /// <summary>
        /// 获取指定的集群
        ///
        /// 该API用于获取指定集群的详细信息。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotClusterResponse ShowAutopilotCluster(ShowAutopilotClusterRequest showAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotClusterResponse>(response);
        }

        public SyncInvoker<ShowAutopilotClusterResponse> ShowAutopilotClusterInvoker(ShowAutopilotClusterRequest showAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterRequest);
            return new SyncInvoker<ShowAutopilotClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 查询集群日志配置信息
        ///
        /// 获取集群组件上报的LTS的配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotClusterConfigResponse ShowAutopilotClusterConfig(ShowAutopilotClusterConfigRequest showAutopilotClusterConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotClusterConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotClusterConfigResponse>(response);
        }

        public SyncInvoker<ShowAutopilotClusterConfigResponse> ShowAutopilotClusterConfigInvoker(ShowAutopilotClusterConfigRequest showAutopilotClusterConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotClusterConfigRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterConfigRequest);
            return new SyncInvoker<ShowAutopilotClusterConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotClusterConfigResponse>);
        }
        
        /// <summary>
        /// 获取集群访问的地址
        ///
        /// 该API用于通过集群ID获取集群访问的地址，包括PrivateIP(HA集群返回VIP)与PublicIP
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotClusterEndpointsResponse ShowAutopilotClusterEndpoints(ShowAutopilotClusterEndpointsRequest showAutopilotClusterEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotClusterEndpointsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/openapi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterEndpointsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotClusterEndpointsResponse>(response);
        }

        public SyncInvoker<ShowAutopilotClusterEndpointsResponse> ShowAutopilotClusterEndpointsInvoker(ShowAutopilotClusterEndpointsRequest showAutopilotClusterEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotClusterEndpointsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/openapi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterEndpointsRequest);
            return new SyncInvoker<ShowAutopilotClusterEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotClusterEndpointsResponse>);
        }
        
        /// <summary>
        /// 获取集群升级相关信息
        ///
        /// 获取集群升级相关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotClusterUpgradeInfoResponse ShowAutopilotClusterUpgradeInfo(ShowAutopilotClusterUpgradeInfoRequest showAutopilotClusterUpgradeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotClusterUpgradeInfoRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterUpgradeInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotClusterUpgradeInfoResponse>(response);
        }

        public SyncInvoker<ShowAutopilotClusterUpgradeInfoResponse> ShowAutopilotClusterUpgradeInfoInvoker(ShowAutopilotClusterUpgradeInfoRequest showAutopilotClusterUpgradeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotClusterUpgradeInfoRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterUpgradeInfoRequest);
            return new SyncInvoker<ShowAutopilotClusterUpgradeInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotClusterUpgradeInfoResponse>);
        }
        
        /// <summary>
        /// 查询特性开关状态
        ///
        /// 该API用于查询特性开关状态
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotFeatureGatesResponse ShowAutopilotFeatureGates(ShowAutopilotFeatureGatesRequest showAutopilotFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotFeatureGatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotFeatureGatesResponse>(response);
        }

        public SyncInvoker<ShowAutopilotFeatureGatesResponse> ShowAutopilotFeatureGatesInvoker(ShowAutopilotFeatureGatesRequest showAutopilotFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotFeatureGatesRequest);
            return new SyncInvoker<ShowAutopilotFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取任务信息
        ///
        /// 该API用于获取任务信息。通过某一任务请求下发后返回的jobID来查询指定任务的进度。
        /// &gt; - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// &gt; - 该接口通常使用场景为：
        /// &gt;   - 创建、删除集群时，查询相应任务的进度。
        /// &gt;   - 创建、删除节点时，查询相应任务的进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotJobResponse ShowAutopilotJob(ShowAutopilotJobRequest showAutopilotJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotJobResponse>(response);
        }

        public SyncInvoker<ShowAutopilotJobResponse> ShowAutopilotJobInvoker(ShowAutopilotJobRequest showAutopilotJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotJobRequest);
            return new SyncInvoker<ShowAutopilotJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotJobResponse>);
        }
        
        /// <summary>
        /// 获取集群维护窗口
        ///
        /// 该API用于获取集群维护窗口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotMaintenanceWindowResponse ShowAutopilotMaintenanceWindow(ShowAutopilotMaintenanceWindowRequest showAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotMaintenanceWindowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotMaintenanceWindowRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotMaintenanceWindowResponse>(response);
        }

        public SyncInvoker<ShowAutopilotMaintenanceWindowResponse> ShowAutopilotMaintenanceWindowInvoker(ShowAutopilotMaintenanceWindowRequest showAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotMaintenanceWindowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotMaintenanceWindowRequest);
            return new SyncInvoker<ShowAutopilotMaintenanceWindowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 获取集群升级前检查任务详情
        ///
        /// 获取集群升级前检查任务详情，任务ID由调用集群检查API后从响应体中uid字段获取。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotPreCheckResponse ShowAutopilotPreCheck(ShowAutopilotPreCheckRequest showAutopilotPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotPreCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotPreCheckRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotPreCheckRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotPreCheckResponse>(response);
        }

        public SyncInvoker<ShowAutopilotPreCheckResponse> ShowAutopilotPreCheckInvoker(ShowAutopilotPreCheckRequest showAutopilotPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotPreCheckRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotPreCheckRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotPreCheckRequest);
            return new SyncInvoker<ShowAutopilotPreCheckResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotPreCheckResponse>);
        }
        
        /// <summary>
        /// 查询CCE服务下的资源配额
        ///
        /// 该API用于查询CCE服务下的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotQuotasResponse ShowAutopilotQuotas(ShowAutopilotQuotasRequest showAutopilotQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotQuotasResponse>(response);
        }

        public SyncInvoker<ShowAutopilotQuotasResponse> ShowAutopilotQuotasInvoker(ShowAutopilotQuotasRequest showAutopilotQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotQuotasRequest);
            return new SyncInvoker<ShowAutopilotQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotQuotasResponse>);
        }
        
        /// <summary>
        /// 获取指定模板实例
        ///
        /// 获取指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotReleaseResponse ShowAutopilotRelease(ShowAutopilotReleaseRequest showAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotReleaseRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotReleaseResponse>(response);
        }

        public SyncInvoker<ShowAutopilotReleaseResponse> ShowAutopilotReleaseInvoker(ShowAutopilotReleaseRequest showAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotReleaseRequest);
            return new SyncInvoker<ShowAutopilotReleaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotReleaseResponse>);
        }
        
        /// <summary>
        /// 查询指定模板实例历史记录
        ///
        /// 查询指定模板实例历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotReleaseHistoryResponse ShowAutopilotReleaseHistory(ShowAutopilotReleaseHistoryRequest showAutopilotReleaseHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseHistoryRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseHistoryRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseHistoryRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotReleaseHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            var showAutopilotReleaseHistoryResponse = JsonUtils.DeSerializeNull<ShowAutopilotReleaseHistoryResponse>(response);
            showAutopilotReleaseHistoryResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
            return showAutopilotReleaseHistoryResponse;
        }

        public SyncInvoker<ShowAutopilotReleaseHistoryResponse> ShowAutopilotReleaseHistoryInvoker(ShowAutopilotReleaseHistoryRequest showAutopilotReleaseHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseHistoryRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseHistoryRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotReleaseHistoryRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotReleaseHistoryRequest);
            return new SyncInvoker<ShowAutopilotReleaseHistoryResponse>(this, "GET", request, response =>
            {
                var showAutopilotReleaseHistoryResponse = JsonUtils.DeSerializeNull<ShowAutopilotReleaseHistoryResponse>(response);
                showAutopilotReleaseHistoryResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
                return showAutopilotReleaseHistoryResponse;
            });
        }
        
        /// <summary>
        /// 获取集群升级任务详情
        ///
        /// 获取集群升级任务详情，任务ID由调用集群升级API后从响应体中uid字段获取。
        /// &gt; - 集群升级涉及多维度的组件升级操作，强烈建议统一通过CCE控制台执行交互式升级，降低集群升级过程的业务意外受损风险；
        /// &gt; - 当前集群升级相关接口受限开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotUpgradeClusterTaskResponse ShowAutopilotUpgradeClusterTask(ShowAutopilotUpgradeClusterTaskRequest showAutopilotUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotUpgradeClusterTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUpgradeClusterTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotUpgradeClusterTaskResponse>(response);
        }

        public SyncInvoker<ShowAutopilotUpgradeClusterTaskResponse> ShowAutopilotUpgradeClusterTaskInvoker(ShowAutopilotUpgradeClusterTaskRequest showAutopilotUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotUpgradeClusterTaskRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotUpgradeClusterTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUpgradeClusterTaskRequest);
            return new SyncInvoker<ShowAutopilotUpgradeClusterTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 获取指定集群升级引导任务详情
        ///
        /// 该API用于通过升级引导任务ID获取任务的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotUpgradeWorkFlowResponse ShowAutopilotUpgradeWorkFlow(ShowAutopilotUpgradeWorkFlowRequest showAutopilotUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotUpgradeWorkFlowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotUpgradeWorkFlowRequest.UpgradeWorkflowId, out var valueOfUpgradeWorkflowId)) urlParam.Add("upgrade_workflow_id", valueOfUpgradeWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUpgradeWorkFlowRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotUpgradeWorkFlowResponse>(response);
        }

        public SyncInvoker<ShowAutopilotUpgradeWorkFlowResponse> ShowAutopilotUpgradeWorkFlowInvoker(ShowAutopilotUpgradeWorkFlowRequest showAutopilotUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotUpgradeWorkFlowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(showAutopilotUpgradeWorkFlowRequest.UpgradeWorkflowId, out var valueOfUpgradeWorkflowId)) urlParam.Add("upgrade_workflow_id", valueOfUpgradeWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUpgradeWorkFlowRequest);
            return new SyncInvoker<ShowAutopilotUpgradeWorkFlowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotUpgradeWorkFlowResponse>);
        }
        
        /// <summary>
        /// 获取用户模板配额
        ///
        /// 获取用户模板配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutopilotUserChartsQuotasResponse ShowAutopilotUserChartsQuotas(ShowAutopilotUserChartsQuotasRequest showAutopilotUserChartsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUserChartsQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotUserChartsQuotasResponse>(response);
        }

        public SyncInvoker<ShowAutopilotUserChartsQuotasResponse> ShowAutopilotUserChartsQuotasInvoker(ShowAutopilotUserChartsQuotasRequest showAutopilotUserChartsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUserChartsQuotasRequest);
            return new SyncInvoker<ShowAutopilotUserChartsQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotUserChartsQuotasResponse>);
        }
        
        /// <summary>
        /// 更新AddonInstance
        ///
        /// 更新插件实例的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutopilotAddonInstanceResponse UpdateAutopilotAddonInstance(UpdateAutopilotAddonInstanceRequest updateAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotAddonInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotAddonInstanceResponse>(response);
        }

        public SyncInvoker<UpdateAutopilotAddonInstanceResponse> UpdateAutopilotAddonInstanceInvoker(UpdateAutopilotAddonInstanceRequest updateAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotAddonInstanceRequest);
            return new SyncInvoker<UpdateAutopilotAddonInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 更新模板
        ///
        /// 更新模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutopilotChartResponse UpdateAutopilotChart(UpdateAutopilotChartRequest updateAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateAutopilotChartRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotChartResponse>(response);
        }

        public SyncInvoker<UpdateAutopilotChartResponse> UpdateAutopilotChartInvoker(UpdateAutopilotChartRequest updateAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotChartRequest.ChartId, out var valueOfChartId)) urlParam.Add("chart_id", valueOfChartId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateAutopilotChartRequest);
            return new SyncInvoker<UpdateAutopilotChartResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 更新指定的集群
        ///
        /// 该API用于更新指定的集群。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutopilotClusterResponse UpdateAutopilotCluster(UpdateAutopilotClusterRequest updateAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotClusterRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotClusterResponse>(response);
        }

        public SyncInvoker<UpdateAutopilotClusterResponse> UpdateAutopilotClusterInvoker(UpdateAutopilotClusterRequest updateAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotClusterRequest);
            return new SyncInvoker<UpdateAutopilotClusterResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 绑定、解绑集群公网apiserver地址
        ///
        /// 该API用于通过集群ID绑定、解绑集群公网apiserver地址
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutopilotClusterEipResponse UpdateAutopilotClusterEip(UpdateAutopilotClusterEipRequest updateAutopilotClusterEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotClusterEipRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/mastereip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotClusterEipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotClusterEipResponse>(response);
        }

        public SyncInvoker<UpdateAutopilotClusterEipResponse> UpdateAutopilotClusterEipInvoker(UpdateAutopilotClusterEipRequest updateAutopilotClusterEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotClusterEipRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/mastereip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotClusterEipRequest);
            return new SyncInvoker<UpdateAutopilotClusterEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotClusterEipResponse>);
        }
        
        /// <summary>
        /// 更新集群维护窗口
        ///
        /// 该API用于更新集群维护窗口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutopilotMaintenanceWindowResponse UpdateAutopilotMaintenanceWindow(UpdateAutopilotMaintenanceWindowRequest updateAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotMaintenanceWindowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotMaintenanceWindowRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotMaintenanceWindowResponse>(response);
        }

        public SyncInvoker<UpdateAutopilotMaintenanceWindowResponse> UpdateAutopilotMaintenanceWindowInvoker(UpdateAutopilotMaintenanceWindowRequest updateAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotMaintenanceWindowRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotMaintenanceWindowRequest);
            return new SyncInvoker<UpdateAutopilotMaintenanceWindowResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 更新指定模板实例
        ///
        /// 更新指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutopilotReleaseResponse UpdateAutopilotRelease(UpdateAutopilotReleaseRequest updateAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotReleaseRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotReleaseResponse>(response);
        }

        public SyncInvoker<UpdateAutopilotReleaseResponse> UpdateAutopilotReleaseInvoker(UpdateAutopilotReleaseRequest updateAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotReleaseRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotReleaseRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotReleaseRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotReleaseRequest);
            return new SyncInvoker<UpdateAutopilotReleaseResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotReleaseResponse>);
        }
        
        /// <summary>
        /// 延期自动升级计划
        ///
        /// 该API用于延期集群自动升级计划。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutopilotUpgradePlanResponse UpdateAutopilotUpgradePlan(UpdateAutopilotUpgradePlanRequest updateAutopilotUpgradePlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotUpgradePlanRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotUpgradePlanRequest.UpgradePlanId, out var valueOfUpgradePlanId)) urlParam.Add("upgrade_plan_id", valueOfUpgradePlanId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeplans/{upgrade_plan_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotUpgradePlanRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotUpgradePlanResponse>(response);
        }

        public SyncInvoker<UpdateAutopilotUpgradePlanResponse> UpdateAutopilotUpgradePlanInvoker(UpdateAutopilotUpgradePlanRequest updateAutopilotUpgradePlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotUpgradePlanRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(updateAutopilotUpgradePlanRequest.UpgradePlanId, out var valueOfUpgradePlanId)) urlParam.Add("upgrade_plan_id", valueOfUpgradePlanId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeplans/{upgrade_plan_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotUpgradePlanRequest);
            return new SyncInvoker<UpdateAutopilotUpgradePlanResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotUpgradePlanResponse>);
        }
        
        /// <summary>
        /// 集群升级
        ///
        /// 集群升级。
        /// &gt; - 集群升级涉及多维度的组件升级操作，强烈建议统一通过CCE控制台执行交互式升级，降低集群升级过程的业务意外受损风险；
        /// &gt; - 当前集群升级相关接口受限开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeAutopilotClusterResponse UpgradeAutopilotCluster(UpgradeAutopilotClusterRequest upgradeAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeAutopilotClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeAutopilotClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeAutopilotClusterResponse>(response);
        }

        public SyncInvoker<UpgradeAutopilotClusterResponse> UpgradeAutopilotClusterInvoker(UpgradeAutopilotClusterRequest upgradeAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeAutopilotClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeAutopilotClusterRequest);
            return new SyncInvoker<UpgradeAutopilotClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 更新指定集群升级引导任务状态
        ///
        /// 该API用于更新指定集群升级引导任务状态，当前仅适用于取消升级流程
        /// 调用该API时升级流程引导任务状态不能为进行中(running) 已完成(success) 已取消(cancel),升级子任务状态不能为running(进行中) init(已初始化) pause(任务被暂停) queue(队列中)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeAutopilotWorkFlowUpdateResponse UpgradeAutopilotWorkFlowUpdate(UpgradeAutopilotWorkFlowUpdateRequest upgradeAutopilotWorkFlowUpdateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeAutopilotWorkFlowUpdateRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(upgradeAutopilotWorkFlowUpdateRequest.UpgradeWorkflowId, out var valueOfUpgradeWorkflowId)) urlParam.Add("upgrade_workflow_id", valueOfUpgradeWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeAutopilotWorkFlowUpdateRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpgradeAutopilotWorkFlowUpdateResponse>(response);
        }

        public SyncInvoker<UpgradeAutopilotWorkFlowUpdateResponse> UpgradeAutopilotWorkFlowUpdateInvoker(UpgradeAutopilotWorkFlowUpdateRequest upgradeAutopilotWorkFlowUpdateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeAutopilotWorkFlowUpdateRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(upgradeAutopilotWorkFlowUpdateRequest.UpgradeWorkflowId, out var valueOfUpgradeWorkflowId)) urlParam.Add("upgrade_workflow_id", valueOfUpgradeWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeAutopilotWorkFlowUpdateRequest);
            return new SyncInvoker<UpgradeAutopilotWorkFlowUpdateResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpgradeAutopilotWorkFlowUpdateResponse>);
        }
        
        /// <summary>
        /// 上传模板
        ///
        /// 上传模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadAutopilotChartResponse UploadAutopilotChart(UploadAutopilotChartRequest uploadAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAutopilotChartRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadAutopilotChartResponse>(response);
        }

        public SyncInvoker<UploadAutopilotChartResponse> UploadAutopilotChartInvoker(UploadAutopilotChartRequest uploadAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAutopilotChartRequest);
            return new SyncInvoker<UploadAutopilotChartResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 删除Job
        ///
        /// 该API用于删除指定项目下的Job。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAutopilotJobResponse DeleteAutopilotJob(DeleteAutopilotJobRequest deleteAutopilotJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAutopilotJobResponse>(response);
        }

        public SyncInvoker<DeleteAutopilotJobResponse> DeleteAutopilotJobInvoker(DeleteAutopilotJobRequest deleteAutopilotJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAutopilotJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotJobRequest);
            return new SyncInvoker<DeleteAutopilotJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAutopilotJobResponse>);
        }
        
        /// <summary>
        /// 获取Job详情
        ///
        /// 该API用于获取指定项目下的Job详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetAutopilotOneJobResponse GetAutopilotOneJob(GetAutopilotOneJobRequest getAutopilotOneJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAutopilotOneJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAutopilotOneJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetAutopilotOneJobResponse>(response);
        }

        public SyncInvoker<GetAutopilotOneJobResponse> GetAutopilotOneJobInvoker(GetAutopilotOneJobRequest getAutopilotOneJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAutopilotOneJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAutopilotOneJobRequest);
            return new SyncInvoker<GetAutopilotOneJobResponse>(this, "GET", request, JsonUtils.DeSerialize<GetAutopilotOneJobResponse>);
        }
        
        /// <summary>
        /// 获取Job列表
        ///
        /// 该API用于获取指定项目下的所有jobs。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAutopilotJobsResponse ListAutopilotJobs(ListAutopilotJobsRequest listAutopilotJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/projects/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listAutopilotJobsResponse = JsonUtils.DeSerializeNull<ListAutopilotJobsResponse>(response);
            listAutopilotJobsResponse.Body = JsonUtils.DeSerializeList<V2Job>(response);
            return listAutopilotJobsResponse;
        }

        public SyncInvoker<ListAutopilotJobsResponse> ListAutopilotJobsInvoker(ListAutopilotJobsRequest listAutopilotJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/projects/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotJobsRequest);
            return new SyncInvoker<ListAutopilotJobsResponse>(this, "GET", request, response =>
            {
                var listAutopilotJobsResponse = JsonUtils.DeSerializeNull<ListAutopilotJobsResponse>(response);
                listAutopilotJobsResponse.Body = JsonUtils.DeSerializeList<V2Job>(response);
                return listAutopilotJobsResponse;
            });
        }
        
    }
}