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
        /// 集群唤醒
        /// </summary>
        public async Task<AwakeClusterResponse> AwakeClusterAsync(AwakeClusterRequest awakeClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , awakeClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/awake",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", awakeClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AwakeClusterResponse>(response);
        }
        
        /// <summary>
        /// 创建AddonInstance
        /// </summary>
        public async Task<CreateAddonInstanceResponse> CreateAddonInstanceAsync(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAddonInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建PVC
        /// </summary>
        public async Task<CreateCloudPersistentVolumeClaimsResponse> CreateCloudPersistentVolumeClaimsAsync(CreateCloudPersistentVolumeClaimsRequest createCloudPersistentVolumeClaimsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudPersistentVolumeClaimsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCloudPersistentVolumeClaimsResponse>(response);
        }
        
        /// <summary>
        /// 创建集群
        /// </summary>
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest createClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateClusterResponse>(response);
        }
        
        /// <summary>
        /// 获取集群证书
        /// </summary>
        public async Task<CreateKubernetesClusterCertResponse> CreateKubernetesClusterCertAsync(CreateKubernetesClusterCertRequest createKubernetesClusterCertRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createKubernetesClusterCertRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKubernetesClusterCertRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateKubernetesClusterCertResponse>(response);
        }
        
        /// <summary>
        /// 创建节点
        /// </summary>
        public async Task<CreateNodeResponse> CreateNodeAsync(CreateNodeRequest createNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateNodeResponse>(response);
        }
        
        /// <summary>
        /// 创建节点池
        /// </summary>
        public async Task<CreateNodePoolResponse> CreateNodePoolAsync(CreateNodePoolRequest createNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createNodePoolRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateNodePoolResponse>(response);
        }
        
        /// <summary>
        /// 删除AddonInstance
        /// </summary>
        public async Task<DeleteAddonInstanceResponse> DeleteAddonInstanceAsync(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteAddonInstanceResponse deleteAddonInstanceResponse = JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>(response);
            return deleteAddonInstanceResponse;
        }
        
        /// <summary>
        /// 删除PVC
        /// </summary>
        public async Task<DeleteCloudPersistentVolumeClaimsResponse> DeleteCloudPersistentVolumeClaimsAsync(DeleteCloudPersistentVolumeClaimsRequest deleteCloudPersistentVolumeClaimsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("name" , deleteCloudPersistentVolumeClaimsRequest.Name.ToString());
            urlParam.Add("namespace" , deleteCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudPersistentVolumeClaimsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteCloudPersistentVolumeClaimsResponse>(response);
        }
        
        /// <summary>
        /// 删除集群
        /// </summary>
        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest deleteClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteClusterResponse>(response);
        }
        
        /// <summary>
        /// 删除节点
        /// </summary>
        public async Task<DeleteNodeResponse> DeleteNodeAsync(DeleteNodeRequest deleteNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , deleteNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteNodeResponse>(response);
        }
        
        /// <summary>
        /// 删除节点池
        /// </summary>
        public async Task<DeleteNodePoolResponse> DeleteNodePoolAsync(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , deleteNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteNodePoolResponse>(response);
        }
        
        /// <summary>
        /// 集群休眠
        /// </summary>
        public async Task<HibernateClusterResponse> HibernateClusterAsync(HibernateClusterRequest hibernateClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , hibernateClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/hibernate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", hibernateClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<HibernateClusterResponse>(response);
        }
        
        /// <summary>
        /// 获取AddonInstance列表
        /// </summary>
        public async Task<ListAddonInstancesResponse> ListAddonInstancesAsync(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddonInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询AddonTemplates列表
        /// </summary>
        public async Task<ListAddonTemplatesResponse> ListAddonTemplatesAsync(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addontemplates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddonTemplatesResponse>(response);
        }
        
        /// <summary>
        /// 获取指定项目下的集群
        /// </summary>
        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest listClustersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClustersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListClustersResponse>(response);
        }
        
        /// <summary>
        /// 获取集群下所有节点池
        /// </summary>
        public async Task<ListNodePoolsResponse> ListNodePoolsAsync(ListNodePoolsRequest listNodePoolsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listNodePoolsRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNodePoolsResponse>(response);
        }
        
        /// <summary>
        /// 获取集群下所有节点
        /// </summary>
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest listNodesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listNodesRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNodesResponse>(response);
        }
        
        /// <summary>
        /// 获取AddonInstance详情
        /// </summary>
        public async Task<ShowAddonInstanceResponse> ShowAddonInstanceAsync(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAddonInstanceResponse>(response);
        }
        
        /// <summary>
        /// 获取指定的集群
        /// </summary>
        public async Task<ShowClusterResponse> ShowClusterAsync(ShowClusterRequest showClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }
        
        /// <summary>
        /// 获取任务信息
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        /// <summary>
        /// 获取指定的节点
        /// </summary>
        public async Task<ShowNodeResponse> ShowNodeAsync(ShowNodeRequest showNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , showNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNodeResponse>(response);
        }
        
        /// <summary>
        /// 获取指定的节点池
        /// </summary>
        public async Task<ShowNodePoolResponse> ShowNodePoolAsync(ShowNodePoolRequest showNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , showNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNodePoolResponse>(response);
        }
        
        /// <summary>
        /// 更新AddonInstance
        /// </summary>
        public async Task<UpdateAddonInstanceResponse> UpdateAddonInstanceAsync(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddonInstanceResponse>(response);
        }
        
        /// <summary>
        /// 更新指定的集群
        /// </summary>
        public async Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest updateClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateClusterResponse>(response);
        }
        
        /// <summary>
        /// 更新指定的节点
        /// </summary>
        public async Task<UpdateNodeResponse> UpdateNodeAsync(UpdateNodeRequest updateNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , updateNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNodeResponse>(response);
        }
        
        /// <summary>
        /// 更新指定节点池
        /// </summary>
        public async Task<UpdateNodePoolResponse> UpdateNodePoolAsync(UpdateNodePoolRequest updateNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , updateNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNodePoolResponse>(response);
        }
        
    }
}