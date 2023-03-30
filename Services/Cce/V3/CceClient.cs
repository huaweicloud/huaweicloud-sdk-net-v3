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
            return new ClientBuilder<CceClient>();
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , addNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/add",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , awakeClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/awake",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", awakeClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AwakeClusterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , continueUpgradeClusterTaskRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/continue",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueUpgradeClusterTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ContinueUpgradeClusterTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAddonInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudPersistentVolumeClaimsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateCloudPersistentVolumeClaimsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateClusterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createKubernetesClusterCertRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKubernetesClusterCertRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKubernetesClusterCertResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createNodePoolRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateNodePoolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteAddonInstanceResponse deleteAddonInstanceResponse = JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>(response);
            return deleteAddonInstanceResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("name" , deleteCloudPersistentVolumeClaimsRequest.Name.ToString());
            urlParam.Add("namespace" , deleteCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudPersistentVolumeClaimsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteCloudPersistentVolumeClaimsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteClusterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , deleteNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , deleteNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteNodePoolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , hibernateClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/hibernate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", hibernateClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<HibernateClusterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAddonInstancesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addontemplates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAddonTemplatesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClustersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListClustersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listNodePoolsRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNodePoolsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listNodesRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNodesResponse>(response);
        }
        
        /// <summary>
        /// 节点迁移
        ///
        /// 该API用于在指定集群下迁移节点到另一集群（仅支持在同一VPC、同一项目下的不同集群之间进行迁移，且迁移前后的集群类型需相同）。
        /// [CCE Turbo集群下弹性云服务-物理机类型节点不支持迁移。](tag:hws,hws_hk,dt)
        /// 
        /// &gt;集群管理的URL格式为：https://Endpoint/uri。其中uri为资源路径，也即API访问的路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateNodeResponse MigrateNode(MigrateNodeRequest migrateNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , migrateNodeRequest.ClusterId.ToString());
            urlParam.Add("target_cluster_id" , migrateNodeRequest.TargetClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/migrateto/{target_cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<MigrateNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , pauseUpgradeClusterTaskRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/pause",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseUpgradeClusterTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<PauseUpgradeClusterTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , removeNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/remove",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<RemoveNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , resetNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/reset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResetNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , retryUpgradeClusterTaskRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/retry",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryUpgradeClusterTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<RetryUpgradeClusterTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAddonInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showClusterEndpointsRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/openapi",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterEndpointsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowClusterEndpointsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , showNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , showNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNodePoolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showUpgradeClusterTaskRequest.ClusterId.ToString());
            urlParam.Add("task_id" , showUpgradeClusterTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeClusterTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUpgradeClusterTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddonInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateClusterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateClusterEipRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/mastereip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterEipRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateClusterEipResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , updateNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNodeResponse>(response);
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
        public UpdateNodePoolResponse UpdateNodePool(UpdateNodePoolRequest updateNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , updateNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNodePoolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , upgradeClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/upgrade",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpgradeClusterResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本信息列表。
        ///
        /// 该API用于查询CCE服务当前支持的API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVersionResponse ShowVersion(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
    }
}