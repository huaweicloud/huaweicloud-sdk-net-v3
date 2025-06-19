using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowIteratorDetailRequest 
    {

        /// <summary>
        /// 用户Token。  通过调用IAM服务获取用户Token接口获取（响应消息头中X-Subject-Token的值）。
        /// </summary>
        [SDKProperty("X-Auth-Token", IsHeader = true)]
        [JsonProperty("X-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthToken { get; set; }

        /// <summary>
        /// 迭代uri
        /// </summary>
        [SDKProperty("iterator_id", IsPath = true)]
        [JsonProperty("iterator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [SDKProperty("project_uuid", IsQuery = true)]
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIteratorDetailRequest {\n");
            sb.Append("  xAuthToken: ").Append(XAuthToken).Append("\n");
            sb.Append("  iteratorId: ").Append(IteratorId).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIteratorDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIteratorDetailRequest input)
        {
            if (input == null) return false;
            if (this.XAuthToken != input.XAuthToken || (this.XAuthToken != null && !this.XAuthToken.Equals(input.XAuthToken))) return false;
            if (this.IteratorId != input.IteratorId || (this.IteratorId != null && !this.IteratorId.Equals(input.IteratorId))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;

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
                if (this.XAuthToken != null) hashCode = hashCode * 59 + this.XAuthToken.GetHashCode();
                if (this.IteratorId != null) hashCode = hashCode * 59 + this.IteratorId.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                return hashCode;
            }
        }
    }
}
