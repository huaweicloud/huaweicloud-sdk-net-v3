using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInferDeploymentPodsRequest 
    {

        /// <summary>
        /// **参数解释：** 服务ID，在[创建服务](CreateInferService.xml)时即可在返回体中获取，也可通过[查询服务列表](ListInferServices.xml)获取当前用户拥有的服务，其中service_id字段即为服务ID。 **约束限制：** 不涉及。 **取值范围：** 服务ID。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("id", IsPath = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 部署名称，在创建部署时即可在返回体中获取，也可通过[查询服务部署列表](ListInferDeployments.xml)获取当前用户拥有的部署，其name字段即为部署名称。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("deployment_name", IsPath = true)]
        [JsonProperty("deployment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例名字，可以为all，为all时去查询所有的服务实例。 **约束限制：** 不涉及。 **取值范围：** 服务实例名字。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("name", IsPath = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** pod状态，一次支持多种状态筛选，多种状态以\&quot;,\&quot;连接，不能存在空格。默认不过滤。取值范围有7种RUNNING（运行中）、PENDING（未就绪）、SUCCEEDED（成功）、FAILED（失败）、ABNORMAL（异常）、UNKNOWN（未知）、DELETED（已删除）。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Status { get; set; }

        /// <summary>
        /// **参数解释：** 指定每一页返回的最大条目数。 **约束限制：** 不涉及。 **取值范围：** [1,500] **默认取值：** 10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释：** 分页列表的起始页。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// **参数解释：** pod名字。 **取值范围：** 不涉及。
        /// </summary>
        [SDKProperty("pod_name", IsQuery = true)]
        [JsonProperty("pod_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PodName { get; set; }

        /// <summary>
        /// **参数解释：** pod ID。 **取值范围：** 不涉及。
        /// </summary>
        [SDKProperty("pod_id", IsQuery = true)]
        [JsonProperty("pod_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PodId { get; set; }

        /// <summary>
        /// **参数解释：** pod节点IP地址。 **取值范围：** 不涉及。
        /// </summary>
        [SDKProperty("pod_node_ip", IsQuery = true)]
        [JsonProperty("pod_node_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PodNodeIp { get; set; }

        /// <summary>
        /// **参数解释：** pod节点名称。 **取值范围：** 不涉及。
        /// </summary>
        [SDKProperty("pod_node_name", IsQuery = true)]
        [JsonProperty("pod_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PodNodeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInferDeploymentPodsRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  deploymentName: ").Append(DeploymentName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  podName: ").Append(PodName).Append("\n");
            sb.Append("  podId: ").Append(PodId).Append("\n");
            sb.Append("  podNodeIp: ").Append(PodNodeIp).Append("\n");
            sb.Append("  podNodeName: ").Append(PodNodeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInferDeploymentPodsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInferDeploymentPodsRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DeploymentName != input.DeploymentName || (this.DeploymentName != null && !this.DeploymentName.Equals(input.DeploymentName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.PodName != input.PodName || (this.PodName != null && !this.PodName.Equals(input.PodName))) return false;
            if (this.PodId != input.PodId || (this.PodId != null && !this.PodId.Equals(input.PodId))) return false;
            if (this.PodNodeIp != input.PodNodeIp || (this.PodNodeIp != null && !this.PodNodeIp.Equals(input.PodNodeIp))) return false;
            if (this.PodNodeName != input.PodNodeName || (this.PodNodeName != null && !this.PodNodeName.Equals(input.PodNodeName))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeploymentName != null) hashCode = hashCode * 59 + this.DeploymentName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.PodName != null) hashCode = hashCode * 59 + this.PodName.GetHashCode();
                if (this.PodId != null) hashCode = hashCode * 59 + this.PodId.GetHashCode();
                if (this.PodNodeIp != null) hashCode = hashCode * 59 + this.PodNodeIp.GetHashCode();
                if (this.PodNodeName != null) hashCode = hashCode * 59 + this.PodNodeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
