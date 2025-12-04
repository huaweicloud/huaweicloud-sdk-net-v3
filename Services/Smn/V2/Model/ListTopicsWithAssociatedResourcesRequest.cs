using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTopicsWithAssociatedResourcesRequest 
    {

        /// <summary>
        /// 偏移量。  偏移量为一个大于0小于资源总个数的整数，表示查询该偏移量后面的所有的资源，默认值为0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的数量限制。  取值范围：1~100，取值一般为10，20，50。功能说明：每页返回的资源个数。默认值为100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 检索的主题ID，完全匹配。
        /// </summary>
        [SDKProperty("topic_id", IsQuery = true)]
        [JsonProperty("topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicId { get; set; }

        /// <summary>
        /// 企业项目id。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 检索的主题名称，完全匹配。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 检索的主题名称，模糊匹配。
        /// </summary>
        [SDKProperty("fuzzy_name", IsQuery = true)]
        [JsonProperty("fuzzy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FuzzyName { get; set; }

        /// <summary>
        /// 检索的主题显示名。模糊匹配。参数字节长度不能大于192字节。
        /// </summary>
        [SDKProperty("fuzzy_display_name", IsQuery = true)]
        [JsonProperty("fuzzy_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FuzzyDisplayName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopicsWithAssociatedResourcesRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  topicId: ").Append(TopicId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  fuzzyName: ").Append(FuzzyName).Append("\n");
            sb.Append("  fuzzyDisplayName: ").Append(FuzzyDisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopicsWithAssociatedResourcesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopicsWithAssociatedResourcesRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.TopicId != input.TopicId || (this.TopicId != null && !this.TopicId.Equals(input.TopicId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.FuzzyName != input.FuzzyName || (this.FuzzyName != null && !this.FuzzyName.Equals(input.FuzzyName))) return false;
            if (this.FuzzyDisplayName != input.FuzzyDisplayName || (this.FuzzyDisplayName != null && !this.FuzzyDisplayName.Equals(input.FuzzyDisplayName))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.TopicId != null) hashCode = hashCode * 59 + this.TopicId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FuzzyName != null) hashCode = hashCode * 59 + this.FuzzyName.GetHashCode();
                if (this.FuzzyDisplayName != null) hashCode = hashCode * 59 + this.FuzzyDisplayName.GetHashCode();
                return hashCode;
            }
        }
    }
}
