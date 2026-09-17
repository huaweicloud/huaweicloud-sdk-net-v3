using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 批量更新工作项参数，支持更新不同工作项的相同字段
    /// </summary>
    public class BatchUpdateIssuesParam 
    {

        /// <summary>
        /// **参数解释**： 需要更新的工作项ID数组，可通过[高级查询工作项](ListIssuesV4.xml)接口获取，响应消息体中的**id**字段的值就是工作项ID。 **约束限制**： 18~19位的数字字符串(工作项的**id**字段对应的字符串)。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attribute", NullValueHandling = NullValueHandling.Ignore)]
        public IssueUpdateAttribute Attribute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateIssuesParam {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  attribute: ").Append(Attribute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateIssuesParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateIssuesParam input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Attribute != input.Attribute || (this.Attribute != null && !this.Attribute.Equals(input.Attribute))) return false;

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
                if (this.Attribute != null) hashCode = hashCode * 59 + this.Attribute.GetHashCode();
                return hashCode;
            }
        }
    }
}
