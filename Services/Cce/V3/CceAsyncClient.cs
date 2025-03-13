using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cce.V3.Model;

namespace HuaweiCloud.SDK.Cce.V3
{
    public partial class CceAsyncClient : Client
    {
        public static ClientBuilder<CceAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CceAsyncClient>();
        }

        
        /// <summary>
        /// 纳管节点
        ///
        /// 该API用于在指定集群下纳管节点。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddNodeResponse> AddNodeAsync(AddNodeRequest addNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", addNodeRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddNodeResponse>(response);
        }

        public AsyncInvoker<AddNodeResponse> AddNodeAsyncInvoker(AddNodeRequest addNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", addNodeRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodeRequest);
            return new AsyncInvoker<AddNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<AddNodeResponse>);
        }
        
        /// <summary>
        /// 自定义节点池纳管节点
        ///
        /// 该API用于在指定集群自定义节点池下纳管节点。竞价实例不支持纳管。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddNodesToNodePoolResponse> AddNodesToNodePoolAsync(AddNodesToNodePoolRequest addNodesToNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", addNodesToNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", addNodesToNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/nodes/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodesToNodePoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddNodesToNodePoolResponse>(response);
        }

        public AsyncInvoker<AddNodesToNodePoolResponse> AddNodesToNodePoolAsyncInvoker(AddNodesToNodePoolRequest addNodesToNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", addNodesToNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", addNodesToNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/nodes/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodesToNodePoolRequest);
            return new AsyncInvoker<AddNodesToNodePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<AddNodesToNodePoolResponse>);
        }
        
        /// <summary>
        /// 集群唤醒
        ///
        /// 集群唤醒用于唤醒已休眠的集群，唤醒后，将继续收取控制节点资源费用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AwakeClusterResponse> AwakeClusterAsync(AwakeClusterRequest awakeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", awakeClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/awake", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", awakeClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AwakeClusterResponse>(response);
        }

        public AsyncInvoker<AwakeClusterResponse> AwakeClusterAsyncInvoker(AwakeClusterRequest awakeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", awakeClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/awake", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", awakeClusterRequest);
            return new AsyncInvoker<AwakeClusterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AwakeClusterResponse>);
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
        public async Task<BatchCreateClusterTagsResponse> BatchCreateClusterTagsAsync(BatchCreateClusterTagsRequest batchCreateClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchCreateClusterTagsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateClusterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateClusterTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateClusterTagsResponse> BatchCreateClusterTagsAsyncInvoker(BatchCreateClusterTagsRequest batchCreateClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchCreateClusterTagsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateClusterTagsRequest);
            return new AsyncInvoker<BatchCreateClusterTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateClusterTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除指定集群的资源标签
        ///
        /// 该API用于批量删除指定集群的资源标签。
        /// &gt; - 此接口为幂等接口：删除时，如果删除的标签key不存在，默认处理成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteClusterTagsResponse> BatchDeleteClusterTagsAsync(BatchDeleteClusterTagsRequest batchDeleteClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchDeleteClusterTagsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteClusterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteClusterTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteClusterTagsResponse> BatchDeleteClusterTagsAsyncInvoker(BatchDeleteClusterTagsRequest batchDeleteClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchDeleteClusterTagsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteClusterTagsRequest);
            return new AsyncInvoker<BatchDeleteClusterTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteClusterTagsResponse>);
        }
        
        /// <summary>
        /// 批量同步节点
        ///
        /// 该API用于批量同步节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSyncNodesResponse> BatchSyncNodesAsync(BatchSyncNodesRequest batchSyncNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchSyncNodesRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSyncNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchSyncNodesResponse>(response);
        }

        public AsyncInvoker<BatchSyncNodesResponse> BatchSyncNodesAsyncInvoker(BatchSyncNodesRequest batchSyncNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchSyncNodesRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSyncNodesRequest);
            return new AsyncInvoker<BatchSyncNodesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchSyncNodesResponse>);
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
        public async Task<ContinueUpgradeClusterTaskResponse> ContinueUpgradeClusterTaskAsync(ContinueUpgradeClusterTaskRequest continueUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", continueUpgradeClusterTaskRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/continue", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueUpgradeClusterTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ContinueUpgradeClusterTaskResponse>(response);
        }

        public AsyncInvoker<ContinueUpgradeClusterTaskResponse> ContinueUpgradeClusterTaskAsyncInvoker(ContinueUpgradeClusterTaskRequest continueUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", continueUpgradeClusterTaskRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/continue", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueUpgradeClusterTaskRequest);
            return new AsyncInvoker<ContinueUpgradeClusterTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ContinueUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 创建AddonInstance
        ///
        /// 根据提供的插件模板，安装插件实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAddonInstanceResponse> CreateAddonInstanceAsync(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAddonInstanceResponse>(response);
        }

        public AsyncInvoker<CreateAddonInstanceResponse> CreateAddonInstanceAsyncInvoker(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            return new AsyncInvoker<CreateAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAddonInstanceResponse>);
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
        public async Task<CreateCloudPersistentVolumeClaimsResponse> CreateCloudPersistentVolumeClaimsAsync(CreateCloudPersistentVolumeClaimsRequest createCloudPersistentVolumeClaimsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudPersistentVolumeClaimsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCloudPersistentVolumeClaimsResponse>(response);
        }

        public AsyncInvoker<CreateCloudPersistentVolumeClaimsResponse> CreateCloudPersistentVolumeClaimsAsyncInvoker(CreateCloudPersistentVolumeClaimsRequest createCloudPersistentVolumeClaimsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudPersistentVolumeClaimsRequest);
            return new AsyncInvoker<CreateCloudPersistentVolumeClaimsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCloudPersistentVolumeClaimsResponse>);
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
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest createClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterResponse>(response);
        }

        public AsyncInvoker<CreateClusterResponse> CreateClusterAsyncInvoker(CreateClusterRequest createClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            return new AsyncInvoker<CreateClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterResponse>);
        }
        
        /// <summary>
        /// 集群备份
        ///
        /// 集群备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateClusterMasterSnapshotResponse> CreateClusterMasterSnapshotAsync(CreateClusterMasterSnapshotRequest createClusterMasterSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createClusterMasterSnapshotRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterMasterSnapshotRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterMasterSnapshotResponse>(response);
        }

        public AsyncInvoker<CreateClusterMasterSnapshotResponse> CreateClusterMasterSnapshotAsyncInvoker(CreateClusterMasterSnapshotRequest createClusterMasterSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createClusterMasterSnapshotRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterMasterSnapshotRequest);
            return new AsyncInvoker<CreateClusterMasterSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterMasterSnapshotResponse>);
        }
        
        /// <summary>
        /// 获取集群证书
        ///
        /// 该API用于获取指定集群的证书信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKubernetesClusterCertResponse> CreateKubernetesClusterCertAsync(CreateKubernetesClusterCertRequest createKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createKubernetesClusterCertRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKubernetesClusterCertRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKubernetesClusterCertResponse>(response);
        }

        public AsyncInvoker<CreateKubernetesClusterCertResponse> CreateKubernetesClusterCertAsyncInvoker(CreateKubernetesClusterCertRequest createKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createKubernetesClusterCertRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKubernetesClusterCertRequest);
            return new AsyncInvoker<CreateKubernetesClusterCertResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKubernetesClusterCertResponse>);
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
        public async Task<CreateNodeResponse> CreateNodeAsync(CreateNodeRequest createNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createNodeRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNodeResponse>(response);
        }

        public AsyncInvoker<CreateNodeResponse> CreateNodeAsyncInvoker(CreateNodeRequest createNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createNodeRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodeRequest);
            return new AsyncInvoker<CreateNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNodeResponse>);
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
        public async Task<CreateNodePoolResponse> CreateNodePoolAsync(CreateNodePoolRequest createNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createNodePoolRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodePoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNodePoolResponse>(response);
        }

        public AsyncInvoker<CreateNodePoolResponse> CreateNodePoolAsyncInvoker(CreateNodePoolRequest createNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createNodePoolRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodePoolRequest);
            return new AsyncInvoker<CreateNodePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNodePoolResponse>);
        }
        
        /// <summary>
        /// 创建分区
        ///
        /// 创建分区
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest createPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createPartitionRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePartitionResponse>(response);
        }

        public AsyncInvoker<CreatePartitionResponse> CreatePartitionAsyncInvoker(CreatePartitionRequest createPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createPartitionRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            return new AsyncInvoker<CreatePartitionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePartitionResponse>);
        }
        
        /// <summary>
        /// 集群升级后确认
        ///
        /// 集群升级后确认，该接口建议配合Console使用，主要用于升级步骤完成后，客户确认集群状态和业务正常后做反馈。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostCheckResponse> CreatePostCheckAsync(CreatePostCheckRequest createPostCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createPostCheckRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/postcheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostCheckRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePostCheckResponse>(response);
        }

        public AsyncInvoker<CreatePostCheckResponse> CreatePostCheckAsyncInvoker(CreatePostCheckRequest createPostCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createPostCheckRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/postcheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostCheckRequest);
            return new AsyncInvoker<CreatePostCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostCheckResponse>);
        }
        
        /// <summary>
        /// 集群升级前检查
        ///
        /// 集群升级前检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePreCheckResponse> CreatePreCheckAsync(CreatePreCheckRequest createPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createPreCheckRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreCheckRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePreCheckResponse>(response);
        }

        public AsyncInvoker<CreatePreCheckResponse> CreatePreCheckAsyncInvoker(CreatePreCheckRequest createPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createPreCheckRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreCheckRequest);
            return new AsyncInvoker<CreatePreCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePreCheckResponse>);
        }
        
        /// <summary>
        /// 创建模板实例
        ///
        /// 创建模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateReleaseResponse> CreateReleaseAsync(CreateReleaseRequest createReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReleaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateReleaseResponse>(response);
        }

        public AsyncInvoker<CreateReleaseResponse> CreateReleaseAsyncInvoker(CreateReleaseRequest createReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReleaseRequest);
            return new AsyncInvoker<CreateReleaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReleaseResponse>);
        }
        
        /// <summary>
        /// 开启集群升级流程引导任务
        ///
        /// 该API用于创建一个集群升级流程引导任务。请在调用本接口完成引导任务创建之后，通过集群升级前检查开始检查任务。
        /// 升级流程任务用于控制集群升级任务的执行流程，执行流程为 升级前检查 &#x3D;&gt; 集群升级 &#x3D;&gt; 升级后检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUpgradeWorkFlowResponse> CreateUpgradeWorkFlowAsync(CreateUpgradeWorkFlowRequest createUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createUpgradeWorkFlowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUpgradeWorkFlowRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUpgradeWorkFlowResponse>(response);
        }

        public AsyncInvoker<CreateUpgradeWorkFlowResponse> CreateUpgradeWorkFlowAsyncInvoker(CreateUpgradeWorkFlowRequest createUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createUpgradeWorkFlowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUpgradeWorkFlowRequest);
            return new AsyncInvoker<CreateUpgradeWorkFlowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUpgradeWorkFlowResponse>);
        }
        
        /// <summary>
        /// 删除AddonInstance
        ///
        /// 删除插件实例的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAddonInstanceResponse> DeleteAddonInstanceAsync(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteAddonInstanceResponse> DeleteAddonInstanceAsyncInvoker(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            return new AsyncInvoker<DeleteAddonInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 删除模板
        ///
        /// 删除模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteChartResponse> DeleteChartAsync(DeleteChartRequest deleteChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", deleteChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteChartRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteChartResponse>(response);
        }

        public AsyncInvoker<DeleteChartResponse> DeleteChartAsyncInvoker(DeleteChartRequest deleteChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", deleteChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteChartRequest);
            return new AsyncInvoker<DeleteChartResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteChartResponse>);
        }
        
        /// <summary>
        /// 删除PVC（待废弃）
        ///
        /// 该API用于删除指定Namespace下的PVC（PersistentVolumeClaim）对象，并可以选择保留后端的云存储。该API待废弃，请使用Kubernetes PVC相关接口。
        /// &gt;存储管理的URL格式为：https://{clusterid}.Endpoint/uri。其中{clusterid}为集群ID，uri为资源路径，也即API访问的路径。如果使用https://Endpoint/uri，则必须指定请求header中的X-Cluster-ID参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCloudPersistentVolumeClaimsResponse> DeleteCloudPersistentVolumeClaimsAsync(DeleteCloudPersistentVolumeClaimsRequest deleteCloudPersistentVolumeClaimsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", deleteCloudPersistentVolumeClaimsRequest.Name.ToString());
            urlParam.Add("namespace", deleteCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudPersistentVolumeClaimsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCloudPersistentVolumeClaimsResponse>(response);
        }

        public AsyncInvoker<DeleteCloudPersistentVolumeClaimsResponse> DeleteCloudPersistentVolumeClaimsAsyncInvoker(DeleteCloudPersistentVolumeClaimsRequest deleteCloudPersistentVolumeClaimsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", deleteCloudPersistentVolumeClaimsRequest.Name.ToString());
            urlParam.Add("namespace", deleteCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudPersistentVolumeClaimsRequest);
            return new AsyncInvoker<DeleteCloudPersistentVolumeClaimsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCloudPersistentVolumeClaimsResponse>);
        }
        
        /// <summary>
        /// 删除集群
        ///
        /// 该API用于删除一个指定的集群。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest deleteClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteClusterResponse>(response);
        }

        public AsyncInvoker<DeleteClusterResponse> DeleteClusterAsyncInvoker(DeleteClusterRequest deleteClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            return new AsyncInvoker<DeleteClusterResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteClusterResponse>);
        }
        
        /// <summary>
        /// 删除节点
        ///
        /// 该API用于删除指定的节点。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNodeResponse> DeleteNodeAsync(DeleteNodeRequest deleteNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id", deleteNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNodeResponse>(response);
        }

        public AsyncInvoker<DeleteNodeResponse> DeleteNodeAsyncInvoker(DeleteNodeRequest deleteNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id", deleteNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodeRequest);
            return new AsyncInvoker<DeleteNodeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNodeResponse>);
        }
        
        /// <summary>
        /// 删除节点池
        ///
        /// 该API用于删除指定的节点池。
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNodePoolResponse> DeleteNodePoolAsync(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", deleteNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNodePoolResponse>(response);
        }

        public AsyncInvoker<DeleteNodePoolResponse> DeleteNodePoolAsyncInvoker(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", deleteNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            return new AsyncInvoker<DeleteNodePoolResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNodePoolResponse>);
        }
        
        /// <summary>
        /// 删除指定模板实例
        ///
        /// 删除指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteReleaseResponse> DeleteReleaseAsync(DeleteReleaseRequest deleteReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", deleteReleaseRequest.Name.ToString());
            urlParam.Add("namespace", deleteReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", deleteReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReleaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteReleaseResponse>(response);
        }

        public AsyncInvoker<DeleteReleaseResponse> DeleteReleaseAsyncInvoker(DeleteReleaseRequest deleteReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", deleteReleaseRequest.Name.ToString());
            urlParam.Add("namespace", deleteReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", deleteReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReleaseRequest);
            return new AsyncInvoker<DeleteReleaseResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteReleaseResponse>);
        }
        
        /// <summary>
        /// 下载模板
        ///
        /// 下载模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadChartResponse> DownloadChartAsync(DownloadChartRequest downloadChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", downloadChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadChartRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadChartResponse>(response);
        }

        public AsyncInvoker<DownloadChartResponse> DownloadChartAsyncInvoker(DownloadChartRequest downloadChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", downloadChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadChartRequest);
            return new AsyncInvoker<DownloadChartResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadChartResponse>);
        }
        
        /// <summary>
        /// 集群休眠
        ///
        /// 集群休眠用于将运行中的集群置于休眠状态，休眠后，将不再收取控制节点资源费用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<HibernateClusterResponse> HibernateClusterAsync(HibernateClusterRequest hibernateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", hibernateClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/hibernate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", hibernateClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<HibernateClusterResponse>(response);
        }

        public AsyncInvoker<HibernateClusterResponse> HibernateClusterAsyncInvoker(HibernateClusterRequest hibernateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", hibernateClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/hibernate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", hibernateClusterRequest);
            return new AsyncInvoker<HibernateClusterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<HibernateClusterResponse>);
        }
        
        /// <summary>
        /// 获取AddonInstance列表
        ///
        /// 获取集群所有已安装插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddonInstancesResponse> ListAddonInstancesAsync(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAddonInstancesResponse>(response);
        }

        public AsyncInvoker<ListAddonInstancesResponse> ListAddonInstancesAsyncInvoker(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            return new AsyncInvoker<ListAddonInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonInstancesResponse>);
        }
        
        /// <summary>
        /// 查询AddonTemplates列表
        ///
        /// 插件模板查询接口，查询插件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddonTemplatesResponse> ListAddonTemplatesAsync(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAddonTemplatesResponse>(response);
        }

        public AsyncInvoker<ListAddonTemplatesResponse> ListAddonTemplatesAsyncInvoker(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            return new AsyncInvoker<ListAddonTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取模板列表
        ///
        /// 获取模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListChartsResponse> ListChartsAsync(ListChartsRequest listChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listChartsResponse = JsonUtils.DeSerializeNull<ListChartsResponse>(response);
            listChartsResponse.Body = JsonUtils.DeSerializeList<ChartResp>(response);
            return listChartsResponse;
        }

        public AsyncInvoker<ListChartsResponse> ListChartsAsyncInvoker(ListChartsRequest listChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            return new AsyncInvoker<ListChartsResponse>(this, "GET", request, response =>
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
        public async Task<ListClusterMasterSnapshotTasksResponse> ListClusterMasterSnapshotTasksAsync(ListClusterMasterSnapshotTasksRequest listClusterMasterSnapshotTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listClusterMasterSnapshotTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterMasterSnapshotTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClusterMasterSnapshotTasksResponse>(response);
        }

        public AsyncInvoker<ListClusterMasterSnapshotTasksResponse> ListClusterMasterSnapshotTasksAsyncInvoker(ListClusterMasterSnapshotTasksRequest listClusterMasterSnapshotTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listClusterMasterSnapshotTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterMasterSnapshotTasksRequest);
            return new AsyncInvoker<ListClusterMasterSnapshotTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterMasterSnapshotTasksResponse>);
        }
        
        /// <summary>
        /// 获取集群升级特性开关配置
        ///
        /// 获取集群升级特性开关配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClusterUpgradeFeatureGatesResponse> ListClusterUpgradeFeatureGatesAsync(ListClusterUpgradeFeatureGatesRequest listClusterUpgradeFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusterupgradefeaturegates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterUpgradeFeatureGatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClusterUpgradeFeatureGatesResponse>(response);
        }

        public AsyncInvoker<ListClusterUpgradeFeatureGatesResponse> ListClusterUpgradeFeatureGatesAsyncInvoker(ListClusterUpgradeFeatureGatesRequest listClusterUpgradeFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusterupgradefeaturegates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterUpgradeFeatureGatesRequest);
            return new AsyncInvoker<ListClusterUpgradeFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterUpgradeFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取集群升级路径
        ///
        /// 获取集群升级路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClusterUpgradePathsResponse> ListClusterUpgradePathsAsync(ListClusterUpgradePathsRequest listClusterUpgradePathsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusterupgradepaths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterUpgradePathsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClusterUpgradePathsResponse>(response);
        }

        public AsyncInvoker<ListClusterUpgradePathsResponse> ListClusterUpgradePathsAsyncInvoker(ListClusterUpgradePathsRequest listClusterUpgradePathsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusterupgradepaths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterUpgradePathsRequest);
            return new AsyncInvoker<ListClusterUpgradePathsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterUpgradePathsResponse>);
        }
        
        /// <summary>
        /// 获取指定项目下的集群
        ///
        /// 该API用于获取指定项目下所有集群的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest listClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClustersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClustersResponse>(response);
        }

        public AsyncInvoker<ListClustersResponse> ListClustersAsyncInvoker(ListClustersRequest listClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClustersRequest);
            return new AsyncInvoker<ListClustersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClustersResponse>);
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
        public async Task<ListNodePoolsResponse> ListNodePoolsAsync(ListNodePoolsRequest listNodePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listNodePoolsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNodePoolsResponse>(response);
        }

        public AsyncInvoker<ListNodePoolsResponse> ListNodePoolsAsyncInvoker(ListNodePoolsRequest listNodePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listNodePoolsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            return new AsyncInvoker<ListNodePoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodePoolsResponse>);
        }
        
        /// <summary>
        /// 获取集群下所有节点
        ///
        /// 该API用于通过集群ID获取指定集群下所有节点的详细信息。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest listNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listNodesRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNodesResponse>(response);
        }

        public AsyncInvoker<ListNodesResponse> ListNodesAsyncInvoker(ListNodesRequest listNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listNodesRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            return new AsyncInvoker<ListNodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodesResponse>);
        }
        
        /// <summary>
        /// 获取分区列表
        ///
        /// 获取分区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPartitionsResponse> ListPartitionsAsync(ListPartitionsRequest listPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listPartitionsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartitionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPartitionsResponse>(response);
        }

        public AsyncInvoker<ListPartitionsResponse> ListPartitionsAsyncInvoker(ListPartitionsRequest listPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listPartitionsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartitionsRequest);
            return new AsyncInvoker<ListPartitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPartitionsResponse>);
        }
        
        /// <summary>
        /// 获取集群升级前检查任务详情列表
        ///
        /// 获取集群升级前检查任务详情列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPreCheckTasksResponse> ListPreCheckTasksAsync(ListPreCheckTasksRequest listPreCheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listPreCheckTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPreCheckTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPreCheckTasksResponse>(response);
        }

        public AsyncInvoker<ListPreCheckTasksResponse> ListPreCheckTasksAsyncInvoker(ListPreCheckTasksRequest listPreCheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listPreCheckTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPreCheckTasksRequest);
            return new AsyncInvoker<ListPreCheckTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPreCheckTasksResponse>);
        }
        
        /// <summary>
        /// 获取模板实例列表
        ///
        /// 获取模板实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListReleasesResponse> ListReleasesAsync(ListReleasesRequest listReleasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listReleasesRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReleasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listReleasesResponse = JsonUtils.DeSerializeNull<ListReleasesResponse>(response);
            listReleasesResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
            return listReleasesResponse;
        }

        public AsyncInvoker<ListReleasesResponse> ListReleasesAsyncInvoker(ListReleasesRequest listReleasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listReleasesRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReleasesRequest);
            return new AsyncInvoker<ListReleasesResponse>(this, "GET", request, response =>
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
        public async Task<ListUpgradeClusterTasksResponse> ListUpgradeClusterTasksAsync(ListUpgradeClusterTasksRequest listUpgradeClusterTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listUpgradeClusterTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeClusterTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUpgradeClusterTasksResponse>(response);
        }

        public AsyncInvoker<ListUpgradeClusterTasksResponse> ListUpgradeClusterTasksAsyncInvoker(ListUpgradeClusterTasksRequest listUpgradeClusterTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listUpgradeClusterTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeClusterTasksRequest);
            return new AsyncInvoker<ListUpgradeClusterTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpgradeClusterTasksResponse>);
        }
        
        /// <summary>
        /// 获取UpgradeWorkFlows列表
        ///
        /// 获取历史集群升级引导任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUpgradeWorkFlowsResponse> ListUpgradeWorkFlowsAsync(ListUpgradeWorkFlowsRequest listUpgradeWorkFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listUpgradeWorkFlowsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeWorkFlowsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUpgradeWorkFlowsResponse>(response);
        }

        public AsyncInvoker<ListUpgradeWorkFlowsResponse> ListUpgradeWorkFlowsAsyncInvoker(ListUpgradeWorkFlowsRequest listUpgradeWorkFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listUpgradeWorkFlowsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeWorkFlowsRequest);
            return new AsyncInvoker<ListUpgradeWorkFlowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpgradeWorkFlowsResponse>);
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
        public async Task<MigrateNodeResponse> MigrateNodeAsync(MigrateNodeRequest migrateNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", migrateNodeRequest.ClusterId.ToString());
            urlParam.Add("target_cluster_id", migrateNodeRequest.TargetClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/migrateto/{target_cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateNodeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<MigrateNodeResponse>(response);
        }

        public AsyncInvoker<MigrateNodeResponse> MigrateNodeAsyncInvoker(MigrateNodeRequest migrateNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", migrateNodeRequest.ClusterId.ToString());
            urlParam.Add("target_cluster_id", migrateNodeRequest.TargetClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/migrateto/{target_cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateNodeRequest);
            return new AsyncInvoker<MigrateNodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<MigrateNodeResponse>);
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
        public async Task<PauseUpgradeClusterTaskResponse> PauseUpgradeClusterTaskAsync(PauseUpgradeClusterTaskRequest pauseUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", pauseUpgradeClusterTaskRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseUpgradeClusterTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<PauseUpgradeClusterTaskResponse>(response);
        }

        public AsyncInvoker<PauseUpgradeClusterTaskResponse> PauseUpgradeClusterTaskAsyncInvoker(PauseUpgradeClusterTaskRequest pauseUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", pauseUpgradeClusterTaskRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseUpgradeClusterTaskRequest);
            return new AsyncInvoker<PauseUpgradeClusterTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PauseUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 节点移除
        ///
        /// 该API用于在指定集群下移除节点。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveNodeResponse> RemoveNodeAsync(RemoveNodeRequest removeNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", removeNodeRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeNodeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RemoveNodeResponse>(response);
        }

        public AsyncInvoker<RemoveNodeResponse> RemoveNodeAsyncInvoker(RemoveNodeRequest removeNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", removeNodeRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeNodeRequest);
            return new AsyncInvoker<RemoveNodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveNodeResponse>);
        }
        
        /// <summary>
        /// 重置节点
        ///
        /// 该API用于在指定集群下重置节点。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetNodeResponse> ResetNodeAsync(ResetNodeRequest resetNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", resetNodeRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetNodeResponse>(response);
        }

        public AsyncInvoker<ResetNodeResponse> ResetNodeAsyncInvoker(ResetNodeRequest resetNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", resetNodeRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetNodeRequest);
            return new AsyncInvoker<ResetNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetNodeResponse>);
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
        public async Task<ResizeClusterResponse> ResizeClusterAsync(ResizeClusterRequest resizeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", resizeClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeClusterResponse>(response);
        }

        public AsyncInvoker<ResizeClusterResponse> ResizeClusterAsyncInvoker(ResizeClusterRequest resizeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", resizeClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeClusterRequest);
            return new AsyncInvoker<ResizeClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeClusterResponse>);
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
        public async Task<RetryUpgradeClusterTaskResponse> RetryUpgradeClusterTaskAsync(RetryUpgradeClusterTaskRequest retryUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", retryUpgradeClusterTaskRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryUpgradeClusterTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RetryUpgradeClusterTaskResponse>(response);
        }

        public AsyncInvoker<RetryUpgradeClusterTaskResponse> RetryUpgradeClusterTaskAsyncInvoker(RetryUpgradeClusterTaskRequest retryUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", retryUpgradeClusterTaskRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryUpgradeClusterTaskRequest);
            return new AsyncInvoker<RetryUpgradeClusterTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryUpgradeClusterTaskResponse>);
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
        public async Task<RevokeKubernetesClusterCertResponse> RevokeKubernetesClusterCertAsync(RevokeKubernetesClusterCertRequest revokeKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", revokeKubernetesClusterCertRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercertrevoke", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeKubernetesClusterCertRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RevokeKubernetesClusterCertResponse>(response);
        }

        public AsyncInvoker<RevokeKubernetesClusterCertResponse> RevokeKubernetesClusterCertAsyncInvoker(RevokeKubernetesClusterCertRequest revokeKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", revokeKubernetesClusterCertRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercertrevoke", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeKubernetesClusterCertRequest);
            return new AsyncInvoker<RevokeKubernetesClusterCertResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RevokeKubernetesClusterCertResponse>);
        }
        
        /// <summary>
        /// 回滚AddonInstance
        ///
        /// 将插件实例回滚到升级前的版本。只有在当前插件实例版本支持回滚到升级前的版本（status.isRollbackable为true），且插件实例状态为running（运行中）、available（可用）、abnormal（不可用）、upgradeFailed（升级失败）、rollbackFailed（回滚失败）时支持回滚。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RollbackAddonInstanceResponse> RollbackAddonInstanceAsync(RollbackAddonInstanceRequest rollbackAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", rollbackAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}/operation/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackAddonInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RollbackAddonInstanceResponse>(response);
        }

        public AsyncInvoker<RollbackAddonInstanceResponse> RollbackAddonInstanceAsyncInvoker(RollbackAddonInstanceRequest rollbackAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", rollbackAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}/operation/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackAddonInstanceRequest);
            return new AsyncInvoker<RollbackAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RollbackAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 伸缩节点池
        ///
        /// 该API用于伸缩指定的节点池
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ScaleNodePoolResponse> ScaleNodePoolAsync(ScaleNodePoolRequest scaleNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", scaleNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", scaleNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/operation/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", scaleNodePoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ScaleNodePoolResponse>(response);
        }

        public AsyncInvoker<ScaleNodePoolResponse> ScaleNodePoolAsyncInvoker(ScaleNodePoolRequest scaleNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", scaleNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", scaleNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/operation/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", scaleNodePoolRequest);
            return new AsyncInvoker<ScaleNodePoolResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ScaleNodePoolResponse>);
        }
        
        /// <summary>
        /// 获取AddonInstance详情
        ///
        /// 获取插件实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAddonInstanceResponse> ShowAddonInstanceAsync(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAddonInstanceResponse>(response);
        }

        public AsyncInvoker<ShowAddonInstanceResponse> ShowAddonInstanceAsyncInvoker(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            return new AsyncInvoker<ShowAddonInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 获取模板
        ///
        /// 获取模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowChartResponse> ShowChartAsync(ShowChartRequest showChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", showChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChartRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowChartResponse>(response);
        }

        public AsyncInvoker<ShowChartResponse> ShowChartAsyncInvoker(ShowChartRequest showChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", showChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChartRequest);
            return new AsyncInvoker<ShowChartResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowChartResponse>);
        }
        
        /// <summary>
        /// 获取模板Values
        ///
        /// 获取模板Values
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowChartValuesResponse> ShowChartValuesAsync(ShowChartValuesRequest showChartValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", showChartValuesRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChartValuesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowChartValuesResponse>(response);
        }

        public AsyncInvoker<ShowChartValuesResponse> ShowChartValuesAsyncInvoker(ShowChartValuesRequest showChartValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", showChartValuesRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChartValuesRequest);
            return new AsyncInvoker<ShowChartValuesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowChartValuesResponse>);
        }
        
        /// <summary>
        /// 获取指定的集群
        ///
        /// 该API用于获取指定集群的详细信息。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterResponse> ShowClusterAsync(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }

        public AsyncInvoker<ShowClusterResponse> ShowClusterAsyncInvoker(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            return new AsyncInvoker<ShowClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterResponse>);
        }
        
        /// <summary>
        /// 查询集群日志配置信息
        ///
        /// 获取集群组件上报的LTS的配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterConfigResponse> ShowClusterConfigAsync(ShowClusterConfigRequest showClusterConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterConfigRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterConfigResponse>(response);
        }

        public AsyncInvoker<ShowClusterConfigResponse> ShowClusterConfigAsyncInvoker(ShowClusterConfigRequest showClusterConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterConfigRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigRequest);
            return new AsyncInvoker<ShowClusterConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterConfigResponse>);
        }
        
        /// <summary>
        /// 查询指定集群支持配置的参数列表
        ///
        /// 该API用于查询CCE服务下指定集群支持配置的参数列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterConfigurationDetailsResponse> ShowClusterConfigurationDetailsAsync(ShowClusterConfigurationDetailsRequest showClusterConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterConfigurationDetailsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigurationDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showClusterConfigurationDetailsResponse = JsonUtils.DeSerializeNull<ShowClusterConfigurationDetailsResponse>(response);
            showClusterConfigurationDetailsResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
            return showClusterConfigurationDetailsResponse;
        }

        public AsyncInvoker<ShowClusterConfigurationDetailsResponse> ShowClusterConfigurationDetailsAsyncInvoker(ShowClusterConfigurationDetailsRequest showClusterConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterConfigurationDetailsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigurationDetailsRequest);
            return new AsyncInvoker<ShowClusterConfigurationDetailsResponse>(this, "GET", request, response =>
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
        public async Task<ShowClusterEndpointsResponse> ShowClusterEndpointsAsync(ShowClusterEndpointsRequest showClusterEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterEndpointsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/openapi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterEndpointsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterEndpointsResponse>(response);
        }

        public AsyncInvoker<ShowClusterEndpointsResponse> ShowClusterEndpointsAsyncInvoker(ShowClusterEndpointsRequest showClusterEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterEndpointsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/openapi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterEndpointsRequest);
            return new AsyncInvoker<ShowClusterEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterEndpointsResponse>);
        }
        
        /// <summary>
        /// 根据集群版本类型等查询集群支持的详细配置项，用于集群创建时指定
        ///
        /// 该API用于根据集群版本类型等查询集群支持的详细配置项，用于集群创建时指定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterSupportConfigurationResponse> ShowClusterSupportConfigurationAsync(ShowClusterSupportConfigurationRequest showClusterSupportConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusters/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterSupportConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showClusterSupportConfigurationResponse = JsonUtils.DeSerializeNull<ShowClusterSupportConfigurationResponse>(response);
            showClusterSupportConfigurationResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
            return showClusterSupportConfigurationResponse;
        }

        public AsyncInvoker<ShowClusterSupportConfigurationResponse> ShowClusterSupportConfigurationAsyncInvoker(ShowClusterSupportConfigurationRequest showClusterSupportConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/clusters/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterSupportConfigurationRequest);
            return new AsyncInvoker<ShowClusterSupportConfigurationResponse>(this, "GET", request, response =>
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
        public async Task<ShowClusterUpgradeInfoResponse> ShowClusterUpgradeInfoAsync(ShowClusterUpgradeInfoRequest showClusterUpgradeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterUpgradeInfoRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/upgradeinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterUpgradeInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterUpgradeInfoResponse>(response);
        }

        public AsyncInvoker<ShowClusterUpgradeInfoResponse> ShowClusterUpgradeInfoAsyncInvoker(ShowClusterUpgradeInfoRequest showClusterUpgradeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterUpgradeInfoRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/upgradeinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterUpgradeInfoRequest);
            return new AsyncInvoker<ShowClusterUpgradeInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterUpgradeInfoResponse>);
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
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public AsyncInvoker<ShowJobResponse> ShowJobAsyncInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new AsyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
        /// <summary>
        /// 获取指定的节点
        ///
        /// 该API用于通过节点ID获取指定节点的详细信息。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNodeResponse> ShowNodeAsync(ShowNodeRequest showNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id", showNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNodeResponse>(response);
        }

        public AsyncInvoker<ShowNodeResponse> ShowNodeAsyncInvoker(ShowNodeRequest showNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id", showNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            return new AsyncInvoker<ShowNodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodeResponse>);
        }
        
        /// <summary>
        /// 获取指定的节点池
        ///
        /// 该API用于获取指定节点池的详细信息。
        /// &gt; 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNodePoolResponse> ShowNodePoolAsync(ShowNodePoolRequest showNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", showNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNodePoolResponse>(response);
        }

        public AsyncInvoker<ShowNodePoolResponse> ShowNodePoolAsyncInvoker(ShowNodePoolRequest showNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", showNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            return new AsyncInvoker<ShowNodePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodePoolResponse>);
        }
        
        /// <summary>
        /// 查询指定节点池支持配置的参数列表
        ///
        /// 该API用于查询CCE服务下指定节点池支持配置的参数列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNodePoolConfigurationDetailsResponse> ShowNodePoolConfigurationDetailsAsync(ShowNodePoolConfigurationDetailsRequest showNodePoolConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showNodePoolConfigurationDetailsRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", showNodePoolConfigurationDetailsRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolConfigurationDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showNodePoolConfigurationDetailsResponse = JsonUtils.DeSerializeNull<ShowNodePoolConfigurationDetailsResponse>(response);
            showNodePoolConfigurationDetailsResponse.Body = JsonUtils.DeSerializeMap<string, List<PackageOptions>>(response);
            return showNodePoolConfigurationDetailsResponse;
        }

        public AsyncInvoker<ShowNodePoolConfigurationDetailsResponse> ShowNodePoolConfigurationDetailsAsyncInvoker(ShowNodePoolConfigurationDetailsRequest showNodePoolConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showNodePoolConfigurationDetailsRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", showNodePoolConfigurationDetailsRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolConfigurationDetailsRequest);
            return new AsyncInvoker<ShowNodePoolConfigurationDetailsResponse>(this, "GET", request, response =>
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
        public async Task<ShowNodePoolConfigurationsResponse> ShowNodePoolConfigurationsAsync(ShowNodePoolConfigurationsRequest showNodePoolConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showNodePoolConfigurationsRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", showNodePoolConfigurationsRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolConfigurationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNodePoolConfigurationsResponse>(response);
        }

        public AsyncInvoker<ShowNodePoolConfigurationsResponse> ShowNodePoolConfigurationsAsyncInvoker(ShowNodePoolConfigurationsRequest showNodePoolConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showNodePoolConfigurationsRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", showNodePoolConfigurationsRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolConfigurationsRequest);
            return new AsyncInvoker<ShowNodePoolConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodePoolConfigurationsResponse>);
        }
        
        /// <summary>
        /// 获取分区详情
        ///
        /// 获取分区详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPartitionResponse> ShowPartitionAsync(ShowPartitionRequest showPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showPartitionRequest.ClusterId.ToString());
            urlParam.Add("partition_name", showPartitionRequest.PartitionName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions/{partition_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionResponse>(response);
        }

        public AsyncInvoker<ShowPartitionResponse> ShowPartitionAsyncInvoker(ShowPartitionRequest showPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showPartitionRequest.ClusterId.ToString());
            urlParam.Add("partition_name", showPartitionRequest.PartitionName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions/{partition_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionRequest);
            return new AsyncInvoker<ShowPartitionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionResponse>);
        }
        
        /// <summary>
        /// 获取集群升级前检查任务详情
        ///
        /// 获取集群升级前检查任务详情，任务ID由调用集群检查API后从响应体中uid字段获取。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPreCheckResponse> ShowPreCheckAsync(ShowPreCheckRequest showPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showPreCheckRequest.ClusterId.ToString());
            urlParam.Add("task_id", showPreCheckRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreCheckRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPreCheckResponse>(response);
        }

        public AsyncInvoker<ShowPreCheckResponse> ShowPreCheckAsyncInvoker(ShowPreCheckRequest showPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showPreCheckRequest.ClusterId.ToString());
            urlParam.Add("task_id", showPreCheckRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreCheckRequest);
            return new AsyncInvoker<ShowPreCheckResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPreCheckResponse>);
        }
        
        /// <summary>
        /// 查询CCE服务下的资源配额
        ///
        /// 该API用于查询CCE服务下的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public AsyncInvoker<ShowQuotasResponse> ShowQuotasAsyncInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new AsyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 获取指定模板实例
        ///
        /// 获取指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReleaseResponse> ShowReleaseAsync(ShowReleaseRequest showReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", showReleaseRequest.Name.ToString());
            urlParam.Add("namespace", showReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", showReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReleaseResponse>(response);
        }

        public AsyncInvoker<ShowReleaseResponse> ShowReleaseAsyncInvoker(ShowReleaseRequest showReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", showReleaseRequest.Name.ToString());
            urlParam.Add("namespace", showReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", showReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseRequest);
            return new AsyncInvoker<ShowReleaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReleaseResponse>);
        }
        
        /// <summary>
        /// 查询指定模板实例历史记录
        ///
        /// 查询指定模板实例历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReleaseHistoryResponse> ShowReleaseHistoryAsync(ShowReleaseHistoryRequest showReleaseHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", showReleaseHistoryRequest.Name.ToString());
            urlParam.Add("namespace", showReleaseHistoryRequest.Namespace.ToString());
            urlParam.Add("cluster_id", showReleaseHistoryRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showReleaseHistoryResponse = JsonUtils.DeSerializeNull<ShowReleaseHistoryResponse>(response);
            showReleaseHistoryResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
            return showReleaseHistoryResponse;
        }

        public AsyncInvoker<ShowReleaseHistoryResponse> ShowReleaseHistoryAsyncInvoker(ShowReleaseHistoryRequest showReleaseHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", showReleaseHistoryRequest.Name.ToString());
            urlParam.Add("namespace", showReleaseHistoryRequest.Namespace.ToString());
            urlParam.Add("cluster_id", showReleaseHistoryRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseHistoryRequest);
            return new AsyncInvoker<ShowReleaseHistoryResponse>(this, "GET", request, response =>
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
        public async Task<ShowUpgradeClusterTaskResponse> ShowUpgradeClusterTaskAsync(ShowUpgradeClusterTaskRequest showUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showUpgradeClusterTaskRequest.ClusterId.ToString());
            urlParam.Add("task_id", showUpgradeClusterTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeClusterTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeClusterTaskResponse>(response);
        }

        public AsyncInvoker<ShowUpgradeClusterTaskResponse> ShowUpgradeClusterTaskAsyncInvoker(ShowUpgradeClusterTaskRequest showUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showUpgradeClusterTaskRequest.ClusterId.ToString());
            urlParam.Add("task_id", showUpgradeClusterTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeClusterTaskRequest);
            return new AsyncInvoker<ShowUpgradeClusterTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 获取指定集群升级引导任务详情
        ///
        /// 该API用于通过升级引导任务ID获取任务的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUpgradeWorkFlowResponse> ShowUpgradeWorkFlowAsync(ShowUpgradeWorkFlowRequest showUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showUpgradeWorkFlowRequest.ClusterId.ToString());
            urlParam.Add("upgrade_workflow_id", showUpgradeWorkFlowRequest.UpgradeWorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeWorkFlowRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeWorkFlowResponse>(response);
        }

        public AsyncInvoker<ShowUpgradeWorkFlowResponse> ShowUpgradeWorkFlowAsyncInvoker(ShowUpgradeWorkFlowRequest showUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showUpgradeWorkFlowRequest.ClusterId.ToString());
            urlParam.Add("upgrade_workflow_id", showUpgradeWorkFlowRequest.UpgradeWorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeWorkFlowRequest);
            return new AsyncInvoker<ShowUpgradeWorkFlowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeWorkFlowResponse>);
        }
        
        /// <summary>
        /// 获取用户模板配额
        ///
        /// 获取用户模板配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserChartsQuotasResponse> ShowUserChartsQuotasAsync(ShowUserChartsQuotasRequest showUserChartsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserChartsQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserChartsQuotasResponse>(response);
        }

        public AsyncInvoker<ShowUserChartsQuotasResponse> ShowUserChartsQuotasAsyncInvoker(ShowUserChartsQuotasRequest showUserChartsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserChartsQuotasRequest);
            return new AsyncInvoker<ShowUserChartsQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserChartsQuotasResponse>);
        }
        
        /// <summary>
        /// 同步节点
        ///
        /// 该API用于同步节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SyncNodeResponse> SyncNodeAsync(SyncNodeRequest syncNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", syncNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id", syncNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v2/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncNodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<SyncNodeResponse>(response);
        }

        public AsyncInvoker<SyncNodeResponse> SyncNodeAsyncInvoker(SyncNodeRequest syncNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", syncNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id", syncNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v2/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncNodeRequest);
            return new AsyncInvoker<SyncNodeResponse>(this, "GET", request, JsonUtils.DeSerializeNull<SyncNodeResponse>);
        }
        
        /// <summary>
        /// 更新AddonInstance
        ///
        /// 更新插件实例的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAddonInstanceResponse> UpdateAddonInstanceAsync(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddonInstanceResponse>(response);
        }

        public AsyncInvoker<UpdateAddonInstanceResponse> UpdateAddonInstanceAsyncInvoker(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            return new AsyncInvoker<UpdateAddonInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 更新模板
        ///
        /// 更新模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateChartResponse> UpdateChartAsync(UpdateChartRequest updateChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", updateChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateChartRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateChartResponse>(response);
        }

        public AsyncInvoker<UpdateChartResponse> UpdateChartAsyncInvoker(UpdateChartRequest updateChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", updateChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateChartRequest);
            return new AsyncInvoker<UpdateChartResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateChartResponse>);
        }
        
        /// <summary>
        /// 更新指定的集群
        ///
        /// 该API用于更新指定的集群。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest updateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClusterResponse>(response);
        }

        public AsyncInvoker<UpdateClusterResponse> UpdateClusterAsyncInvoker(UpdateClusterRequest updateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            return new AsyncInvoker<UpdateClusterResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClusterResponse>);
        }
        
        /// <summary>
        /// 绑定、解绑集群公网apiserver地址
        ///
        /// 该API用于通过集群ID绑定、解绑集群公网apiserver地址
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterEipResponse> UpdateClusterEipAsync(UpdateClusterEipRequest updateClusterEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateClusterEipRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/mastereip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterEipRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClusterEipResponse>(response);
        }

        public AsyncInvoker<UpdateClusterEipResponse> UpdateClusterEipAsyncInvoker(UpdateClusterEipRequest updateClusterEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateClusterEipRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/mastereip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterEipRequest);
            return new AsyncInvoker<UpdateClusterEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClusterEipResponse>);
        }
        
        /// <summary>
        /// 配置集群日志
        ///
        /// 用户可以选择集群管理节点上哪些组件的日志上报LTS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterLogConfigResponse> UpdateClusterLogConfigAsync(UpdateClusterLogConfigRequest updateClusterLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateClusterLogConfigRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterLogConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClusterLogConfigResponse>(response);
        }

        public AsyncInvoker<UpdateClusterLogConfigResponse> UpdateClusterLogConfigAsyncInvoker(UpdateClusterLogConfigRequest updateClusterLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateClusterLogConfigRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/cluster/{cluster_id}/log-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterLogConfigRequest);
            return new AsyncInvoker<UpdateClusterLogConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClusterLogConfigResponse>);
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
        public async Task<UpdateNodeResponse> UpdateNodeAsync(UpdateNodeRequest updateNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id", updateNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNodeResponse>(response);
        }

        public AsyncInvoker<UpdateNodeResponse> UpdateNodeAsyncInvoker(UpdateNodeRequest updateNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id", updateNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodeRequest);
            return new AsyncInvoker<UpdateNodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNodeResponse>);
        }
        
        /// <summary>
        /// 更新指定节点池
        ///
        /// 该API用于更新指定的节点池。仅支持集群在处于可用、扩容、缩容状态时调用。
        /// 
        /// 
        /// &gt; - 集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径
        /// 
        /// &gt; - 当前仅支持更新节点池名称，spec下的initialNodeCount，k8sTags，taints，login，userTags与节点池的扩缩容配置相关字段。若此次更新未设置相关值，默认更新为初始值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNodePoolResponse> UpdateNodePoolAsync(UpdateNodePoolRequest updateNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", updateNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNodePoolResponse>(response);
        }

        public AsyncInvoker<UpdateNodePoolResponse> UpdateNodePoolAsyncInvoker(UpdateNodePoolRequest updateNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", updateNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolRequest);
            return new AsyncInvoker<UpdateNodePoolResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNodePoolResponse>);
        }
        
        /// <summary>
        /// 修改指定节点池配置参数的值
        ///
        /// 该API用于修改CCE服务下指定节点池配置参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNodePoolConfigurationResponse> UpdateNodePoolConfigurationAsync(UpdateNodePoolConfigurationRequest updateNodePoolConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateNodePoolConfigurationRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", updateNodePoolConfigurationRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNodePoolConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateNodePoolConfigurationResponse> UpdateNodePoolConfigurationAsyncInvoker(UpdateNodePoolConfigurationRequest updateNodePoolConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateNodePoolConfigurationRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", updateNodePoolConfigurationRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolConfigurationRequest);
            return new AsyncInvoker<UpdateNodePoolConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNodePoolConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新分区
        ///
        /// 更新分区
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePartitionResponse> UpdatePartitionAsync(UpdatePartitionRequest updatePartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updatePartitionRequest.ClusterId.ToString());
            urlParam.Add("partition_name", updatePartitionRequest.PartitionName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions/{partition_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePartitionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePartitionResponse>(response);
        }

        public AsyncInvoker<UpdatePartitionResponse> UpdatePartitionAsyncInvoker(UpdatePartitionRequest updatePartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updatePartitionRequest.ClusterId.ToString());
            urlParam.Add("partition_name", updatePartitionRequest.PartitionName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/partitions/{partition_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePartitionRequest);
            return new AsyncInvoker<UpdatePartitionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePartitionResponse>);
        }
        
        /// <summary>
        /// 更新指定模板实例
        ///
        /// 更新指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateReleaseResponse> UpdateReleaseAsync(UpdateReleaseRequest updateReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", updateReleaseRequest.Name.ToString());
            urlParam.Add("namespace", updateReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", updateReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReleaseRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReleaseResponse>(response);
        }

        public AsyncInvoker<UpdateReleaseResponse> UpdateReleaseAsyncInvoker(UpdateReleaseRequest updateReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", updateReleaseRequest.Name.ToString());
            urlParam.Add("namespace", updateReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", updateReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/cce/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReleaseRequest);
            return new AsyncInvoker<UpdateReleaseResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReleaseResponse>);
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
        public async Task<UpgradeClusterResponse> UpgradeClusterAsync(UpgradeClusterRequest upgradeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeClusterResponse>(response);
        }

        public AsyncInvoker<UpgradeClusterResponse> UpgradeClusterAsyncInvoker(UpgradeClusterRequest upgradeClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeClusterRequest);
            return new AsyncInvoker<UpgradeClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeClusterResponse>);
        }
        
        /// <summary>
        /// 同步节点池
        ///
        /// 该API用于同步节点池中已有节点的配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeNodePoolResponse> UpgradeNodePoolAsync(UpgradeNodePoolRequest upgradeNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", upgradeNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeNodePoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeNodePoolResponse>(response);
        }

        public AsyncInvoker<UpgradeNodePoolResponse> UpgradeNodePoolAsyncInvoker(UpgradeNodePoolRequest upgradeNodePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id", upgradeNodePoolRequest.NodepoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeNodePoolRequest);
            return new AsyncInvoker<UpgradeNodePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeNodePoolResponse>);
        }
        
        /// <summary>
        /// 更新指定集群升级引导任务状态
        ///
        /// 该API用于更新指定集群升级引导任务状态，当前仅适用于取消升级流程
        /// 调用该API时升级流程引导任务状态不能为进行中(running) 已完成(success) 已取消(cancel),升级子任务状态不能为running(进行中) init(已初始化) pause(任务被暂停) queue(队列中)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeWorkFlowUpdateResponse> UpgradeWorkFlowUpdateAsync(UpgradeWorkFlowUpdateRequest upgradeWorkFlowUpdateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeWorkFlowUpdateRequest.ClusterId.ToString());
            urlParam.Add("upgrade_workflow_id", upgradeWorkFlowUpdateRequest.UpgradeWorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeWorkFlowUpdateRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpgradeWorkFlowUpdateResponse>(response);
        }

        public AsyncInvoker<UpgradeWorkFlowUpdateResponse> UpgradeWorkFlowUpdateAsyncInvoker(UpgradeWorkFlowUpdateRequest upgradeWorkFlowUpdateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeWorkFlowUpdateRequest.ClusterId.ToString());
            urlParam.Add("upgrade_workflow_id", upgradeWorkFlowUpdateRequest.UpgradeWorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeWorkFlowUpdateRequest);
            return new AsyncInvoker<UpgradeWorkFlowUpdateResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpgradeWorkFlowUpdateResponse>);
        }
        
        /// <summary>
        /// 上传模板
        ///
        /// 上传模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadChartResponse> UploadChartAsync(UploadChartRequest uploadChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadChartRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadChartResponse>(response);
        }

        public AsyncInvoker<UploadChartResponse> UploadChartAsyncInvoker(UploadChartRequest uploadChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadChartRequest);
            return new AsyncInvoker<UploadChartResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadChartResponse>);
        }
        
        /// <summary>
        /// 查询API版本信息列表
        ///
        /// 该API用于查询CCE服务当前支持的API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVersionResponse> ShowVersionAsync(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }

        public AsyncInvoker<ShowVersionResponse> ShowVersionAsyncInvoker(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            return new AsyncInvoker<ShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionResponse>);
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
        public async Task<BatchCreateAutopilotClusterTagsResponse> BatchCreateAutopilotClusterTagsAsync(BatchCreateAutopilotClusterTagsRequest batchCreateAutopilotClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchCreateAutopilotClusterTagsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAutopilotClusterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateAutopilotClusterTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateAutopilotClusterTagsResponse> BatchCreateAutopilotClusterTagsAsyncInvoker(BatchCreateAutopilotClusterTagsRequest batchCreateAutopilotClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchCreateAutopilotClusterTagsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAutopilotClusterTagsRequest);
            return new AsyncInvoker<BatchCreateAutopilotClusterTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateAutopilotClusterTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除指定集群的资源标签
        ///
        /// 该API用于批量删除指定集群的资源标签。
        /// &gt; - 此接口为幂等接口：删除时，如果删除的标签key不存在，默认处理成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAutopilotClusterTagsResponse> BatchDeleteAutopilotClusterTagsAsync(BatchDeleteAutopilotClusterTagsRequest batchDeleteAutopilotClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchDeleteAutopilotClusterTagsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAutopilotClusterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAutopilotClusterTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAutopilotClusterTagsResponse> BatchDeleteAutopilotClusterTagsAsyncInvoker(BatchDeleteAutopilotClusterTagsRequest batchDeleteAutopilotClusterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", batchDeleteAutopilotClusterTagsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAutopilotClusterTagsRequest);
            return new AsyncInvoker<BatchDeleteAutopilotClusterTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAutopilotClusterTagsResponse>);
        }
        
        /// <summary>
        /// 创建AddonInstance
        ///
        /// 根据提供的插件模板，安装插件实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutopilotAddonInstanceResponse> CreateAutopilotAddonInstanceAsync(CreateAutopilotAddonInstanceRequest createAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotAddonInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotAddonInstanceResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotAddonInstanceResponse> CreateAutopilotAddonInstanceAsyncInvoker(CreateAutopilotAddonInstanceRequest createAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotAddonInstanceRequest);
            return new AsyncInvoker<CreateAutopilotAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotAddonInstanceResponse>);
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
        public async Task<CreateAutopilotClusterResponse> CreateAutopilotClusterAsync(CreateAutopilotClusterRequest createAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotClusterResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotClusterResponse> CreateAutopilotClusterAsyncInvoker(CreateAutopilotClusterRequest createAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotClusterRequest);
            return new AsyncInvoker<CreateAutopilotClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 集群备份
        ///
        /// 集群备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutopilotClusterMasterSnapshotResponse> CreateAutopilotClusterMasterSnapshotAsync(CreateAutopilotClusterMasterSnapshotRequest createAutopilotClusterMasterSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotClusterMasterSnapshotRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotClusterMasterSnapshotRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotClusterMasterSnapshotResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotClusterMasterSnapshotResponse> CreateAutopilotClusterMasterSnapshotAsyncInvoker(CreateAutopilotClusterMasterSnapshotRequest createAutopilotClusterMasterSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotClusterMasterSnapshotRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotClusterMasterSnapshotRequest);
            return new AsyncInvoker<CreateAutopilotClusterMasterSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotClusterMasterSnapshotResponse>);
        }
        
        /// <summary>
        /// 获取集群证书
        ///
        /// 该API用于获取指定集群的证书信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutopilotKubernetesClusterCertResponse> CreateAutopilotKubernetesClusterCertAsync(CreateAutopilotKubernetesClusterCertRequest createAutopilotKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotKubernetesClusterCertRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/clustercert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotKubernetesClusterCertRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotKubernetesClusterCertResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotKubernetesClusterCertResponse> CreateAutopilotKubernetesClusterCertAsyncInvoker(CreateAutopilotKubernetesClusterCertRequest createAutopilotKubernetesClusterCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotKubernetesClusterCertRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/clustercert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotKubernetesClusterCertRequest);
            return new AsyncInvoker<CreateAutopilotKubernetesClusterCertResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotKubernetesClusterCertResponse>);
        }
        
        /// <summary>
        /// 创建集群维护窗口
        ///
        /// 该API用于创建集群维护窗口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutopilotMaintenanceWindowResponse> CreateAutopilotMaintenanceWindowAsync(CreateAutopilotMaintenanceWindowRequest createAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotMaintenanceWindowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotMaintenanceWindowRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotMaintenanceWindowResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotMaintenanceWindowResponse> CreateAutopilotMaintenanceWindowAsyncInvoker(CreateAutopilotMaintenanceWindowRequest createAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotMaintenanceWindowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotMaintenanceWindowRequest);
            return new AsyncInvoker<CreateAutopilotMaintenanceWindowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 集群升级后确认
        ///
        /// 集群升级后确认，该接口建议配合Console使用，主要用于升级步骤完成后，客户确认集群状态和业务正常后做反馈。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutopilotPostCheckResponse> CreateAutopilotPostCheckAsync(CreateAutopilotPostCheckRequest createAutopilotPostCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotPostCheckRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/postcheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotPostCheckRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotPostCheckResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotPostCheckResponse> CreateAutopilotPostCheckAsyncInvoker(CreateAutopilotPostCheckRequest createAutopilotPostCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotPostCheckRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/postcheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotPostCheckRequest);
            return new AsyncInvoker<CreateAutopilotPostCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotPostCheckResponse>);
        }
        
        /// <summary>
        /// 集群升级前检查
        ///
        /// 集群升级前检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutopilotPreCheckResponse> CreateAutopilotPreCheckAsync(CreateAutopilotPreCheckRequest createAutopilotPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotPreCheckRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotPreCheckRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotPreCheckResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotPreCheckResponse> CreateAutopilotPreCheckAsyncInvoker(CreateAutopilotPreCheckRequest createAutopilotPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotPreCheckRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotPreCheckRequest);
            return new AsyncInvoker<CreateAutopilotPreCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotPreCheckResponse>);
        }
        
        /// <summary>
        /// 创建模板实例
        ///
        /// 创建模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutopilotReleaseResponse> CreateAutopilotReleaseAsync(CreateAutopilotReleaseRequest createAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotReleaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotReleaseResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotReleaseResponse> CreateAutopilotReleaseAsyncInvoker(CreateAutopilotReleaseRequest createAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotReleaseRequest);
            return new AsyncInvoker<CreateAutopilotReleaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotReleaseResponse>);
        }
        
        /// <summary>
        /// 开启集群升级流程引导任务
        ///
        /// 该API用于创建一个集群升级流程引导任务。请在调用本接口完成引导任务创建之后，通过集群升级前检查开始检查任务。
        /// 升级流程任务用于控制集群升级任务的执行流程，执行流程为 升级前检查 &#x3D;&gt; 集群升级 &#x3D;&gt; 升级后检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutopilotUpgradeWorkFlowResponse> CreateAutopilotUpgradeWorkFlowAsync(CreateAutopilotUpgradeWorkFlowRequest createAutopilotUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotUpgradeWorkFlowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotUpgradeWorkFlowRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutopilotUpgradeWorkFlowResponse>(response);
        }

        public AsyncInvoker<CreateAutopilotUpgradeWorkFlowResponse> CreateAutopilotUpgradeWorkFlowAsyncInvoker(CreateAutopilotUpgradeWorkFlowRequest createAutopilotUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", createAutopilotUpgradeWorkFlowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutopilotUpgradeWorkFlowRequest);
            return new AsyncInvoker<CreateAutopilotUpgradeWorkFlowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutopilotUpgradeWorkFlowResponse>);
        }
        
        /// <summary>
        /// 删除AddonInstance
        ///
        /// 删除插件实例的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAutopilotAddonInstanceResponse> DeleteAutopilotAddonInstanceAsync(DeleteAutopilotAddonInstanceRequest deleteAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteAutopilotAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotAddonInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAutopilotAddonInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteAutopilotAddonInstanceResponse> DeleteAutopilotAddonInstanceAsyncInvoker(DeleteAutopilotAddonInstanceRequest deleteAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteAutopilotAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotAddonInstanceRequest);
            return new AsyncInvoker<DeleteAutopilotAddonInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 删除模板
        ///
        /// 删除模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAutopilotChartResponse> DeleteAutopilotChartAsync(DeleteAutopilotChartRequest deleteAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", deleteAutopilotChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotChartRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAutopilotChartResponse>(response);
        }

        public AsyncInvoker<DeleteAutopilotChartResponse> DeleteAutopilotChartAsyncInvoker(DeleteAutopilotChartRequest deleteAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", deleteAutopilotChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotChartRequest);
            return new AsyncInvoker<DeleteAutopilotChartResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 删除集群
        ///
        /// 该API用于删除一个指定的集群。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAutopilotClusterResponse> DeleteAutopilotClusterAsync(DeleteAutopilotClusterRequest deleteAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteAutopilotClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotClusterRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAutopilotClusterResponse>(response);
        }

        public AsyncInvoker<DeleteAutopilotClusterResponse> DeleteAutopilotClusterAsyncInvoker(DeleteAutopilotClusterRequest deleteAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteAutopilotClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotClusterRequest);
            return new AsyncInvoker<DeleteAutopilotClusterResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 删除集群维护窗口
        ///
        /// 该API用于删除集群维护窗口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAutopilotMaintenanceWindowResponse> DeleteAutopilotMaintenanceWindowAsync(DeleteAutopilotMaintenanceWindowRequest deleteAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteAutopilotMaintenanceWindowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotMaintenanceWindowRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAutopilotMaintenanceWindowResponse>(response);
        }

        public AsyncInvoker<DeleteAutopilotMaintenanceWindowResponse> DeleteAutopilotMaintenanceWindowAsyncInvoker(DeleteAutopilotMaintenanceWindowRequest deleteAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", deleteAutopilotMaintenanceWindowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotMaintenanceWindowRequest);
            return new AsyncInvoker<DeleteAutopilotMaintenanceWindowResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAutopilotMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 删除指定模板实例
        ///
        /// 删除指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAutopilotReleaseResponse> DeleteAutopilotReleaseAsync(DeleteAutopilotReleaseRequest deleteAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", deleteAutopilotReleaseRequest.Name.ToString());
            urlParam.Add("namespace", deleteAutopilotReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", deleteAutopilotReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotReleaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAutopilotReleaseResponse>(response);
        }

        public AsyncInvoker<DeleteAutopilotReleaseResponse> DeleteAutopilotReleaseAsyncInvoker(DeleteAutopilotReleaseRequest deleteAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", deleteAutopilotReleaseRequest.Name.ToString());
            urlParam.Add("namespace", deleteAutopilotReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", deleteAutopilotReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAutopilotReleaseRequest);
            return new AsyncInvoker<DeleteAutopilotReleaseResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAutopilotReleaseResponse>);
        }
        
        /// <summary>
        /// 下载模板
        ///
        /// 下载模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadAutopilotChartResponse> DownloadAutopilotChartAsync(DownloadAutopilotChartRequest downloadAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", downloadAutopilotChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAutopilotChartRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadAutopilotChartResponse>(response);
        }

        public AsyncInvoker<DownloadAutopilotChartResponse> DownloadAutopilotChartAsyncInvoker(DownloadAutopilotChartRequest downloadAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", downloadAutopilotChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAutopilotChartRequest);
            return new AsyncInvoker<DownloadAutopilotChartResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 获取AddonInstance列表
        ///
        /// 获取集群所有已安装插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotAddonInstancesResponse> ListAutopilotAddonInstancesAsync(ListAutopilotAddonInstancesRequest listAutopilotAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotAddonInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotAddonInstancesResponse>(response);
        }

        public AsyncInvoker<ListAutopilotAddonInstancesResponse> ListAutopilotAddonInstancesAsyncInvoker(ListAutopilotAddonInstancesRequest listAutopilotAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotAddonInstancesRequest);
            return new AsyncInvoker<ListAutopilotAddonInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotAddonInstancesResponse>);
        }
        
        /// <summary>
        /// 查询AddonTemplates列表
        ///
        /// 插件模板查询接口，查询插件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotAddonTemplatesResponse> ListAutopilotAddonTemplatesAsync(ListAutopilotAddonTemplatesRequest listAutopilotAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotAddonTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotAddonTemplatesResponse>(response);
        }

        public AsyncInvoker<ListAutopilotAddonTemplatesResponse> ListAutopilotAddonTemplatesAsyncInvoker(ListAutopilotAddonTemplatesRequest listAutopilotAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotAddonTemplatesRequest);
            return new AsyncInvoker<ListAutopilotAddonTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotAddonTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取模板列表
        ///
        /// 获取模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotChartsResponse> ListAutopilotChartsAsync(ListAutopilotChartsRequest listAutopilotChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotChartsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listAutopilotChartsResponse = JsonUtils.DeSerializeNull<ListAutopilotChartsResponse>(response);
            listAutopilotChartsResponse.Body = JsonUtils.DeSerializeList<ChartResp>(response);
            return listAutopilotChartsResponse;
        }

        public AsyncInvoker<ListAutopilotChartsResponse> ListAutopilotChartsAsyncInvoker(ListAutopilotChartsRequest listAutopilotChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotChartsRequest);
            return new AsyncInvoker<ListAutopilotChartsResponse>(this, "GET", request, response =>
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
        public async Task<ListAutopilotClusterMasterSnapshotTasksResponse> ListAutopilotClusterMasterSnapshotTasksAsync(ListAutopilotClusterMasterSnapshotTasksRequest listAutopilotClusterMasterSnapshotTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotClusterMasterSnapshotTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterMasterSnapshotTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotClusterMasterSnapshotTasksResponse>(response);
        }

        public AsyncInvoker<ListAutopilotClusterMasterSnapshotTasksResponse> ListAutopilotClusterMasterSnapshotTasksAsyncInvoker(ListAutopilotClusterMasterSnapshotTasksRequest listAutopilotClusterMasterSnapshotTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotClusterMasterSnapshotTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3.1/projects/{project_id}/clusters/{cluster_id}/operation/snapshot/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterMasterSnapshotTasksRequest);
            return new AsyncInvoker<ListAutopilotClusterMasterSnapshotTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotClusterMasterSnapshotTasksResponse>);
        }
        
        /// <summary>
        /// 获取集群升级特性开关配置
        ///
        /// 获取集群升级特性开关配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotClusterUpgradeFeatureGatesResponse> ListAutopilotClusterUpgradeFeatureGatesAsync(ListAutopilotClusterUpgradeFeatureGatesRequest listAutopilotClusterUpgradeFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/clusterupgradefeaturegates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterUpgradeFeatureGatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotClusterUpgradeFeatureGatesResponse>(response);
        }

        public AsyncInvoker<ListAutopilotClusterUpgradeFeatureGatesResponse> ListAutopilotClusterUpgradeFeatureGatesAsyncInvoker(ListAutopilotClusterUpgradeFeatureGatesRequest listAutopilotClusterUpgradeFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/clusterupgradefeaturegates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterUpgradeFeatureGatesRequest);
            return new AsyncInvoker<ListAutopilotClusterUpgradeFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotClusterUpgradeFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取集群升级路径
        ///
        /// 获取集群升级路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotClusterUpgradePathsResponse> ListAutopilotClusterUpgradePathsAsync(ListAutopilotClusterUpgradePathsRequest listAutopilotClusterUpgradePathsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/clusterupgradepaths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterUpgradePathsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotClusterUpgradePathsResponse>(response);
        }

        public AsyncInvoker<ListAutopilotClusterUpgradePathsResponse> ListAutopilotClusterUpgradePathsAsyncInvoker(ListAutopilotClusterUpgradePathsRequest listAutopilotClusterUpgradePathsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/clusterupgradepaths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClusterUpgradePathsRequest);
            return new AsyncInvoker<ListAutopilotClusterUpgradePathsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotClusterUpgradePathsResponse>);
        }
        
        /// <summary>
        /// 获取指定项目下的集群
        ///
        /// 该API用于获取指定项目下所有集群的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotClustersResponse> ListAutopilotClustersAsync(ListAutopilotClustersRequest listAutopilotClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClustersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotClustersResponse>(response);
        }

        public AsyncInvoker<ListAutopilotClustersResponse> ListAutopilotClustersAsyncInvoker(ListAutopilotClustersRequest listAutopilotClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotClustersRequest);
            return new AsyncInvoker<ListAutopilotClustersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotClustersResponse>);
        }
        
        /// <summary>
        /// 获取集群升级前检查任务详情列表
        ///
        /// 获取集群升级前检查任务详情列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotPreCheckTasksResponse> ListAutopilotPreCheckTasksAsync(ListAutopilotPreCheckTasksRequest listAutopilotPreCheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotPreCheckTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotPreCheckTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotPreCheckTasksResponse>(response);
        }

        public AsyncInvoker<ListAutopilotPreCheckTasksResponse> ListAutopilotPreCheckTasksAsyncInvoker(ListAutopilotPreCheckTasksRequest listAutopilotPreCheckTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotPreCheckTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotPreCheckTasksRequest);
            return new AsyncInvoker<ListAutopilotPreCheckTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotPreCheckTasksResponse>);
        }
        
        /// <summary>
        /// 获取模板实例列表
        ///
        /// 获取模板实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotReleasesResponse> ListAutopilotReleasesAsync(ListAutopilotReleasesRequest listAutopilotReleasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotReleasesRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotReleasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listAutopilotReleasesResponse = JsonUtils.DeSerializeNull<ListAutopilotReleasesResponse>(response);
            listAutopilotReleasesResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
            return listAutopilotReleasesResponse;
        }

        public AsyncInvoker<ListAutopilotReleasesResponse> ListAutopilotReleasesAsyncInvoker(ListAutopilotReleasesRequest listAutopilotReleasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotReleasesRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/releases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotReleasesRequest);
            return new AsyncInvoker<ListAutopilotReleasesResponse>(this, "GET", request, response =>
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
        public async Task<ListAutopilotUpgradeClusterTasksResponse> ListAutopilotUpgradeClusterTasksAsync(ListAutopilotUpgradeClusterTasksRequest listAutopilotUpgradeClusterTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotUpgradeClusterTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradeClusterTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotUpgradeClusterTasksResponse>(response);
        }

        public AsyncInvoker<ListAutopilotUpgradeClusterTasksResponse> ListAutopilotUpgradeClusterTasksAsyncInvoker(ListAutopilotUpgradeClusterTasksRequest listAutopilotUpgradeClusterTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotUpgradeClusterTasksRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradeClusterTasksRequest);
            return new AsyncInvoker<ListAutopilotUpgradeClusterTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotUpgradeClusterTasksResponse>);
        }
        
        /// <summary>
        /// 获取自动升级计划
        ///
        /// 该API用于获取集群自动升级计划。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotUpgradePlansResponse> ListAutopilotUpgradePlansAsync(ListAutopilotUpgradePlansRequest listAutopilotUpgradePlansRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotUpgradePlansRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeplans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradePlansRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotUpgradePlansResponse>(response);
        }

        public AsyncInvoker<ListAutopilotUpgradePlansResponse> ListAutopilotUpgradePlansAsyncInvoker(ListAutopilotUpgradePlansRequest listAutopilotUpgradePlansRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotUpgradePlansRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeplans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradePlansRequest);
            return new AsyncInvoker<ListAutopilotUpgradePlansResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotUpgradePlansResponse>);
        }
        
        /// <summary>
        /// 获取UpgradeWorkFlows列表
        ///
        /// 获取历史集群升级引导任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAutopilotUpgradeWorkFlowsResponse> ListAutopilotUpgradeWorkFlowsAsync(ListAutopilotUpgradeWorkFlowsRequest listAutopilotUpgradeWorkFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotUpgradeWorkFlowsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradeWorkFlowsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAutopilotUpgradeWorkFlowsResponse>(response);
        }

        public AsyncInvoker<ListAutopilotUpgradeWorkFlowsResponse> ListAutopilotUpgradeWorkFlowsAsyncInvoker(ListAutopilotUpgradeWorkFlowsRequest listAutopilotUpgradeWorkFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAutopilotUpgradeWorkFlowsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAutopilotUpgradeWorkFlowsRequest);
            return new AsyncInvoker<ListAutopilotUpgradeWorkFlowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAutopilotUpgradeWorkFlowsResponse>);
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
        public async Task<RetryAutopilotUpgradeClusterTaskResponse> RetryAutopilotUpgradeClusterTaskAsync(RetryAutopilotUpgradeClusterTaskRequest retryAutopilotUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", retryAutopilotUpgradeClusterTaskRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryAutopilotUpgradeClusterTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RetryAutopilotUpgradeClusterTaskResponse>(response);
        }

        public AsyncInvoker<RetryAutopilotUpgradeClusterTaskResponse> RetryAutopilotUpgradeClusterTaskAsyncInvoker(RetryAutopilotUpgradeClusterTaskRequest retryAutopilotUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", retryAutopilotUpgradeClusterTaskRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryAutopilotUpgradeClusterTaskRequest);
            return new AsyncInvoker<RetryAutopilotUpgradeClusterTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryAutopilotUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 回滚AddonInstance
        ///
        /// 将插件实例回滚到升级前的版本。只有在当前插件实例版本支持回滚到升级前的版本（status.isRollbackable为true），且插件实例状态为running（运行中）、available（可用）、abnormal（不可用）、upgradeFailed（升级失败）、rollbackFailed（回滚失败）时支持回滚。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RollbackAutopilotAddonInstanceResponse> RollbackAutopilotAddonInstanceAsync(RollbackAutopilotAddonInstanceRequest rollbackAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", rollbackAutopilotAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}/operation/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackAutopilotAddonInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RollbackAutopilotAddonInstanceResponse>(response);
        }

        public AsyncInvoker<RollbackAutopilotAddonInstanceResponse> RollbackAutopilotAddonInstanceAsyncInvoker(RollbackAutopilotAddonInstanceRequest rollbackAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", rollbackAutopilotAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}/operation/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackAutopilotAddonInstanceRequest);
            return new AsyncInvoker<RollbackAutopilotAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RollbackAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 获取AddonInstance详情
        ///
        /// 获取插件实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotAddonInstanceResponse> ShowAutopilotAddonInstanceAsync(ShowAutopilotAddonInstanceRequest showAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showAutopilotAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotAddonInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotAddonInstanceResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotAddonInstanceResponse> ShowAutopilotAddonInstanceAsyncInvoker(ShowAutopilotAddonInstanceRequest showAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showAutopilotAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotAddonInstanceRequest);
            return new AsyncInvoker<ShowAutopilotAddonInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 获取模板
        ///
        /// 获取模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotChartResponse> ShowAutopilotChartAsync(ShowAutopilotChartRequest showAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", showAutopilotChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotChartRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotChartResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotChartResponse> ShowAutopilotChartAsyncInvoker(ShowAutopilotChartRequest showAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", showAutopilotChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotChartRequest);
            return new AsyncInvoker<ShowAutopilotChartResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 获取模板Values
        ///
        /// 获取模板Values
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotChartValuesResponse> ShowAutopilotChartValuesAsync(ShowAutopilotChartValuesRequest showAutopilotChartValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", showAutopilotChartValuesRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotChartValuesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotChartValuesResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotChartValuesResponse> ShowAutopilotChartValuesAsyncInvoker(ShowAutopilotChartValuesRequest showAutopilotChartValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", showAutopilotChartValuesRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotChartValuesRequest);
            return new AsyncInvoker<ShowAutopilotChartValuesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotChartValuesResponse>);
        }
        
        /// <summary>
        /// 获取指定的集群
        ///
        /// 该API用于获取指定集群的详细信息。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotClusterResponse> ShowAutopilotClusterAsync(ShowAutopilotClusterRequest showAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotClusterResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotClusterResponse> ShowAutopilotClusterAsyncInvoker(ShowAutopilotClusterRequest showAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterRequest);
            return new AsyncInvoker<ShowAutopilotClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 获取集群访问的地址
        ///
        /// 该API用于通过集群ID获取集群访问的地址，包括PrivateIP(HA集群返回VIP)与PublicIP
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotClusterEndpointsResponse> ShowAutopilotClusterEndpointsAsync(ShowAutopilotClusterEndpointsRequest showAutopilotClusterEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotClusterEndpointsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/openapi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterEndpointsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotClusterEndpointsResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotClusterEndpointsResponse> ShowAutopilotClusterEndpointsAsyncInvoker(ShowAutopilotClusterEndpointsRequest showAutopilotClusterEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotClusterEndpointsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/openapi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterEndpointsRequest);
            return new AsyncInvoker<ShowAutopilotClusterEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotClusterEndpointsResponse>);
        }
        
        /// <summary>
        /// 获取集群升级相关信息
        ///
        /// 获取集群升级相关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotClusterUpgradeInfoResponse> ShowAutopilotClusterUpgradeInfoAsync(ShowAutopilotClusterUpgradeInfoRequest showAutopilotClusterUpgradeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotClusterUpgradeInfoRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterUpgradeInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotClusterUpgradeInfoResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotClusterUpgradeInfoResponse> ShowAutopilotClusterUpgradeInfoAsyncInvoker(ShowAutopilotClusterUpgradeInfoRequest showAutopilotClusterUpgradeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotClusterUpgradeInfoRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotClusterUpgradeInfoRequest);
            return new AsyncInvoker<ShowAutopilotClusterUpgradeInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotClusterUpgradeInfoResponse>);
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
        public async Task<ShowAutopilotJobResponse> ShowAutopilotJobAsync(ShowAutopilotJobRequest showAutopilotJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showAutopilotJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotJobResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotJobResponse> ShowAutopilotJobAsyncInvoker(ShowAutopilotJobRequest showAutopilotJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showAutopilotJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotJobRequest);
            return new AsyncInvoker<ShowAutopilotJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotJobResponse>);
        }
        
        /// <summary>
        /// 获取集群维护窗口
        ///
        /// 该API用于获取集群维护窗口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotMaintenanceWindowResponse> ShowAutopilotMaintenanceWindowAsync(ShowAutopilotMaintenanceWindowRequest showAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotMaintenanceWindowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotMaintenanceWindowRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotMaintenanceWindowResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotMaintenanceWindowResponse> ShowAutopilotMaintenanceWindowAsyncInvoker(ShowAutopilotMaintenanceWindowRequest showAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotMaintenanceWindowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotMaintenanceWindowRequest);
            return new AsyncInvoker<ShowAutopilotMaintenanceWindowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 获取集群升级前检查任务详情
        ///
        /// 获取集群升级前检查任务详情，任务ID由调用集群检查API后从响应体中uid字段获取。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotPreCheckResponse> ShowAutopilotPreCheckAsync(ShowAutopilotPreCheckRequest showAutopilotPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotPreCheckRequest.ClusterId.ToString());
            urlParam.Add("task_id", showAutopilotPreCheckRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotPreCheckRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotPreCheckResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotPreCheckResponse> ShowAutopilotPreCheckAsyncInvoker(ShowAutopilotPreCheckRequest showAutopilotPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotPreCheckRequest.ClusterId.ToString());
            urlParam.Add("task_id", showAutopilotPreCheckRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/precheck/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotPreCheckRequest);
            return new AsyncInvoker<ShowAutopilotPreCheckResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotPreCheckResponse>);
        }
        
        /// <summary>
        /// 查询CCE服务下的资源配额
        ///
        /// 该API用于查询CCE服务下的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotQuotasResponse> ShowAutopilotQuotasAsync(ShowAutopilotQuotasRequest showAutopilotQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotQuotasResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotQuotasResponse> ShowAutopilotQuotasAsyncInvoker(ShowAutopilotQuotasRequest showAutopilotQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotQuotasRequest);
            return new AsyncInvoker<ShowAutopilotQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotQuotasResponse>);
        }
        
        /// <summary>
        /// 获取指定模板实例
        ///
        /// 获取指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotReleaseResponse> ShowAutopilotReleaseAsync(ShowAutopilotReleaseRequest showAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", showAutopilotReleaseRequest.Name.ToString());
            urlParam.Add("namespace", showAutopilotReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", showAutopilotReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotReleaseRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotReleaseResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotReleaseResponse> ShowAutopilotReleaseAsyncInvoker(ShowAutopilotReleaseRequest showAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", showAutopilotReleaseRequest.Name.ToString());
            urlParam.Add("namespace", showAutopilotReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", showAutopilotReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotReleaseRequest);
            return new AsyncInvoker<ShowAutopilotReleaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotReleaseResponse>);
        }
        
        /// <summary>
        /// 查询指定模板实例历史记录
        ///
        /// 查询指定模板实例历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotReleaseHistoryResponse> ShowAutopilotReleaseHistoryAsync(ShowAutopilotReleaseHistoryRequest showAutopilotReleaseHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", showAutopilotReleaseHistoryRequest.Name.ToString());
            urlParam.Add("namespace", showAutopilotReleaseHistoryRequest.Namespace.ToString());
            urlParam.Add("cluster_id", showAutopilotReleaseHistoryRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotReleaseHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showAutopilotReleaseHistoryResponse = JsonUtils.DeSerializeNull<ShowAutopilotReleaseHistoryResponse>(response);
            showAutopilotReleaseHistoryResponse.Body = JsonUtils.DeSerializeList<ReleaseResp>(response);
            return showAutopilotReleaseHistoryResponse;
        }

        public AsyncInvoker<ShowAutopilotReleaseHistoryResponse> ShowAutopilotReleaseHistoryAsyncInvoker(ShowAutopilotReleaseHistoryRequest showAutopilotReleaseHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", showAutopilotReleaseHistoryRequest.Name.ToString());
            urlParam.Add("namespace", showAutopilotReleaseHistoryRequest.Namespace.ToString());
            urlParam.Add("cluster_id", showAutopilotReleaseHistoryRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotReleaseHistoryRequest);
            return new AsyncInvoker<ShowAutopilotReleaseHistoryResponse>(this, "GET", request, response =>
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
        public async Task<ShowAutopilotUpgradeClusterTaskResponse> ShowAutopilotUpgradeClusterTaskAsync(ShowAutopilotUpgradeClusterTaskRequest showAutopilotUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotUpgradeClusterTaskRequest.ClusterId.ToString());
            urlParam.Add("task_id", showAutopilotUpgradeClusterTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUpgradeClusterTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotUpgradeClusterTaskResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotUpgradeClusterTaskResponse> ShowAutopilotUpgradeClusterTaskAsyncInvoker(ShowAutopilotUpgradeClusterTaskRequest showAutopilotUpgradeClusterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotUpgradeClusterTaskRequest.ClusterId.ToString());
            urlParam.Add("task_id", showAutopilotUpgradeClusterTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUpgradeClusterTaskRequest);
            return new AsyncInvoker<ShowAutopilotUpgradeClusterTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotUpgradeClusterTaskResponse>);
        }
        
        /// <summary>
        /// 获取指定集群升级引导任务详情
        ///
        /// 该API用于通过升级引导任务ID获取任务的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotUpgradeWorkFlowResponse> ShowAutopilotUpgradeWorkFlowAsync(ShowAutopilotUpgradeWorkFlowRequest showAutopilotUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotUpgradeWorkFlowRequest.ClusterId.ToString());
            urlParam.Add("upgrade_workflow_id", showAutopilotUpgradeWorkFlowRequest.UpgradeWorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUpgradeWorkFlowRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotUpgradeWorkFlowResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotUpgradeWorkFlowResponse> ShowAutopilotUpgradeWorkFlowAsyncInvoker(ShowAutopilotUpgradeWorkFlowRequest showAutopilotUpgradeWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showAutopilotUpgradeWorkFlowRequest.ClusterId.ToString());
            urlParam.Add("upgrade_workflow_id", showAutopilotUpgradeWorkFlowRequest.UpgradeWorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUpgradeWorkFlowRequest);
            return new AsyncInvoker<ShowAutopilotUpgradeWorkFlowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotUpgradeWorkFlowResponse>);
        }
        
        /// <summary>
        /// 获取用户模板配额
        ///
        /// 获取用户模板配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutopilotUserChartsQuotasResponse> ShowAutopilotUserChartsQuotasAsync(ShowAutopilotUserChartsQuotasRequest showAutopilotUserChartsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUserChartsQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutopilotUserChartsQuotasResponse>(response);
        }

        public AsyncInvoker<ShowAutopilotUserChartsQuotasResponse> ShowAutopilotUserChartsQuotasAsyncInvoker(ShowAutopilotUserChartsQuotasRequest showAutopilotUserChartsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutopilotUserChartsQuotasRequest);
            return new AsyncInvoker<ShowAutopilotUserChartsQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutopilotUserChartsQuotasResponse>);
        }
        
        /// <summary>
        /// 更新AddonInstance
        ///
        /// 更新插件实例的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutopilotAddonInstanceResponse> UpdateAutopilotAddonInstanceAsync(UpdateAutopilotAddonInstanceRequest updateAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateAutopilotAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotAddonInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotAddonInstanceResponse>(response);
        }

        public AsyncInvoker<UpdateAutopilotAddonInstanceResponse> UpdateAutopilotAddonInstanceAsyncInvoker(UpdateAutopilotAddonInstanceRequest updateAutopilotAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateAutopilotAddonInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotAddonInstanceRequest);
            return new AsyncInvoker<UpdateAutopilotAddonInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 更新模板
        ///
        /// 更新模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutopilotChartResponse> UpdateAutopilotChartAsync(UpdateAutopilotChartRequest updateAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", updateAutopilotChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateAutopilotChartRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotChartResponse>(response);
        }

        public AsyncInvoker<UpdateAutopilotChartResponse> UpdateAutopilotChartAsyncInvoker(UpdateAutopilotChartRequest updateAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("chart_id", updateAutopilotChartRequest.ChartId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts/{chart_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateAutopilotChartRequest);
            return new AsyncInvoker<UpdateAutopilotChartResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotChartResponse>);
        }
        
        /// <summary>
        /// 更新指定的集群
        ///
        /// 该API用于更新指定的集群。
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutopilotClusterResponse> UpdateAutopilotClusterAsync(UpdateAutopilotClusterRequest updateAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateAutopilotClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotClusterRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotClusterResponse>(response);
        }

        public AsyncInvoker<UpdateAutopilotClusterResponse> UpdateAutopilotClusterAsyncInvoker(UpdateAutopilotClusterRequest updateAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateAutopilotClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotClusterRequest);
            return new AsyncInvoker<UpdateAutopilotClusterResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 绑定、解绑集群公网apiserver地址
        ///
        /// 该API用于通过集群ID绑定、解绑集群公网apiserver地址
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutopilotClusterEipResponse> UpdateAutopilotClusterEipAsync(UpdateAutopilotClusterEipRequest updateAutopilotClusterEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateAutopilotClusterEipRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/mastereip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotClusterEipRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotClusterEipResponse>(response);
        }

        public AsyncInvoker<UpdateAutopilotClusterEipResponse> UpdateAutopilotClusterEipAsyncInvoker(UpdateAutopilotClusterEipRequest updateAutopilotClusterEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateAutopilotClusterEipRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/mastereip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotClusterEipRequest);
            return new AsyncInvoker<UpdateAutopilotClusterEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotClusterEipResponse>);
        }
        
        /// <summary>
        /// 更新集群维护窗口
        ///
        /// 该API用于更新集群维护窗口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutopilotMaintenanceWindowResponse> UpdateAutopilotMaintenanceWindowAsync(UpdateAutopilotMaintenanceWindowRequest updateAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateAutopilotMaintenanceWindowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotMaintenanceWindowRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotMaintenanceWindowResponse>(response);
        }

        public AsyncInvoker<UpdateAutopilotMaintenanceWindowResponse> UpdateAutopilotMaintenanceWindowAsyncInvoker(UpdateAutopilotMaintenanceWindowRequest updateAutopilotMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateAutopilotMaintenanceWindowRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/maintenancewindows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotMaintenanceWindowRequest);
            return new AsyncInvoker<UpdateAutopilotMaintenanceWindowResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 更新指定模板实例
        ///
        /// 更新指定模板实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutopilotReleaseResponse> UpdateAutopilotReleaseAsync(UpdateAutopilotReleaseRequest updateAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", updateAutopilotReleaseRequest.Name.ToString());
            urlParam.Add("namespace", updateAutopilotReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", updateAutopilotReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotReleaseRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotReleaseResponse>(response);
        }

        public AsyncInvoker<UpdateAutopilotReleaseResponse> UpdateAutopilotReleaseAsyncInvoker(UpdateAutopilotReleaseRequest updateAutopilotReleaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("name", updateAutopilotReleaseRequest.Name.ToString());
            urlParam.Add("namespace", updateAutopilotReleaseRequest.Namespace.ToString());
            urlParam.Add("cluster_id", updateAutopilotReleaseRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/cam/v3/clusters/{cluster_id}/namespace/{namespace}/releases/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotReleaseRequest);
            return new AsyncInvoker<UpdateAutopilotReleaseResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotReleaseResponse>);
        }
        
        /// <summary>
        /// 延期自动升级计划
        ///
        /// 该API用于延期集群自动升级计划。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutopilotUpgradePlanResponse> UpdateAutopilotUpgradePlanAsync(UpdateAutopilotUpgradePlanRequest updateAutopilotUpgradePlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateAutopilotUpgradePlanRequest.ClusterId.ToString());
            urlParam.Add("upgrade_plan_id", updateAutopilotUpgradePlanRequest.UpgradePlanId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeplans/{upgrade_plan_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotUpgradePlanRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutopilotUpgradePlanResponse>(response);
        }

        public AsyncInvoker<UpdateAutopilotUpgradePlanResponse> UpdateAutopilotUpgradePlanAsyncInvoker(UpdateAutopilotUpgradePlanRequest updateAutopilotUpgradePlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", updateAutopilotUpgradePlanRequest.ClusterId.ToString());
            urlParam.Add("upgrade_plan_id", updateAutopilotUpgradePlanRequest.UpgradePlanId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/upgradeplans/{upgrade_plan_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAutopilotUpgradePlanRequest);
            return new AsyncInvoker<UpdateAutopilotUpgradePlanResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutopilotUpgradePlanResponse>);
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
        public async Task<UpgradeAutopilotClusterResponse> UpgradeAutopilotClusterAsync(UpgradeAutopilotClusterRequest upgradeAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeAutopilotClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeAutopilotClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeAutopilotClusterResponse>(response);
        }

        public AsyncInvoker<UpgradeAutopilotClusterResponse> UpgradeAutopilotClusterAsyncInvoker(UpgradeAutopilotClusterRequest upgradeAutopilotClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeAutopilotClusterRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeAutopilotClusterRequest);
            return new AsyncInvoker<UpgradeAutopilotClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeAutopilotClusterResponse>);
        }
        
        /// <summary>
        /// 更新指定集群升级引导任务状态
        ///
        /// 该API用于更新指定集群升级引导任务状态，当前仅适用于取消升级流程
        /// 调用该API时升级流程引导任务状态不能为进行中(running) 已完成(success) 已取消(cancel),升级子任务状态不能为running(进行中) init(已初始化) pause(任务被暂停) queue(队列中)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeAutopilotWorkFlowUpdateResponse> UpgradeAutopilotWorkFlowUpdateAsync(UpgradeAutopilotWorkFlowUpdateRequest upgradeAutopilotWorkFlowUpdateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeAutopilotWorkFlowUpdateRequest.ClusterId.ToString());
            urlParam.Add("upgrade_workflow_id", upgradeAutopilotWorkFlowUpdateRequest.UpgradeWorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeAutopilotWorkFlowUpdateRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpgradeAutopilotWorkFlowUpdateResponse>(response);
        }

        public AsyncInvoker<UpgradeAutopilotWorkFlowUpdateResponse> UpgradeAutopilotWorkFlowUpdateAsyncInvoker(UpgradeAutopilotWorkFlowUpdateRequest upgradeAutopilotWorkFlowUpdateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", upgradeAutopilotWorkFlowUpdateRequest.ClusterId.ToString());
            urlParam.Add("upgrade_workflow_id", upgradeAutopilotWorkFlowUpdateRequest.UpgradeWorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgradeworkflows/{upgrade_workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeAutopilotWorkFlowUpdateRequest);
            return new AsyncInvoker<UpgradeAutopilotWorkFlowUpdateResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpgradeAutopilotWorkFlowUpdateResponse>);
        }
        
        /// <summary>
        /// 上传模板
        ///
        /// 上传模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadAutopilotChartResponse> UploadAutopilotChartAsync(UploadAutopilotChartRequest uploadAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAutopilotChartRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadAutopilotChartResponse>(response);
        }

        public AsyncInvoker<UploadAutopilotChartResponse> UploadAutopilotChartAsyncInvoker(UploadAutopilotChartRequest uploadAutopilotChartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autopilot/v2/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAutopilotChartRequest);
            return new AsyncInvoker<UploadAutopilotChartResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAutopilotChartResponse>);
        }
        
    }
}