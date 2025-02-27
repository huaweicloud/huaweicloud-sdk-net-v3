using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListLogtanksRequest 
    {

        /// <summary>
        /// 参数解释：每页返回的个数。  取值范围：0-2000  默认取值：2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明： - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 是否反向查询。  取值： - true：查询上一页。 - false：查询下一页，默认。  使用说明： - 必须与limit一起使用。 - 当page_reverse&#x3D;true时，若要查询上一页，marker取值为当前页返回值的previous_marker
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 参数解释：所属的企业项目ID。 如果enterprise_project_id不传值，默认查询所有企业项目下的资源，鉴权按照细粒度权限鉴权，必须在用户组下分配elb:logtanks:list权限。 如果enterprise_project_id传值，鉴权按照企业项目权限鉴权，分为传入具体eps_id和all_granted_eps两种场景，前者查询指定eps_id的eps下的资源，后者查询的是所有有list权限的eps下的资源。  支持多值查询，查询条件格式： *enterprise_project_id&#x3D;xxx&amp;enterprise_project_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:dt,hcso_dt)
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 云日志记录ID。 支持多值查询，查询条件格式：id&#x3D;xxx&amp;id&#x3D;xxx。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 负载均衡器ID。 支持多值查询，查询条件格式：loadbalancer_id&#x3D;xxx&amp;loadbalancer_id&#x3D;xxx。
        /// </summary>
        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerId { get; set; }

        /// <summary>
        /// 云日志分组ID。 支持多值查询，查询条件格式：log_group_id&#x3D;xxx&amp;log_group_id&#x3D;xxx。
        /// </summary>
        [SDKProperty("log_group_id", IsQuery = true)]
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LogGroupId { get; set; }

        /// <summary>
        /// 云日志主题ID 支持多值查询，查询条件格式：log_topic_id&#x3D;xxx&amp;log_topic_id&#x3D;xxx。
        /// </summary>
        [SDKProperty("log_topic_id", IsQuery = true)]
        [JsonProperty("log_topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LogTopicId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogtanksRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logTopicId: ").Append(LogTopicId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogtanksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogtanksRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.PageReverse != input.PageReverse || (this.PageReverse != null && !this.PageReverse.Equals(input.PageReverse))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.LoadbalancerId != input.LoadbalancerId || (this.LoadbalancerId != null && input.LoadbalancerId != null && !this.LoadbalancerId.SequenceEqual(input.LoadbalancerId))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && input.LogGroupId != null && !this.LogGroupId.SequenceEqual(input.LogGroupId))) return false;
            if (this.LogTopicId != input.LogTopicId || (this.LogTopicId != null && input.LogTopicId != null && !this.LogTopicId.SequenceEqual(input.LogTopicId))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null) hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LoadbalancerId != null) hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogTopicId != null) hashCode = hashCode * 59 + this.LogTopicId.GetHashCode();
                return hashCode;
            }
        }
    }
}
