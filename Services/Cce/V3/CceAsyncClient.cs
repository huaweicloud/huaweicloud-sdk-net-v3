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
            return JsonUtils.DeSerialize<ShowClusterConfigurationDetailsResponse>(response);
        }

        public AsyncInvoker<ShowClusterConfigurationDetailsResponse> ShowClusterConfigurationDetailsAsyncInvoker(ShowClusterConfigurationDetailsRequest showClusterConfigurationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", showClusterConfigurationDetailsRequest.ClusterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/configuration/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterConfigurationDetailsRequest);
            return new AsyncInvoker<ShowClusterConfigurationDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterConfigurationDetailsResponse>);
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
        
    }
}