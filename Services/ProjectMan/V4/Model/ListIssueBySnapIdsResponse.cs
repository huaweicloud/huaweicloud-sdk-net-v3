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
    /// Response Object
    /// </summary>
    public class ListIssueBySnapIdsResponse : SdkResponse
    {

        /// <summary>
        /// 请求返回的结果信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 请求状态码。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 快照对应的工作项信息。
        /// </summary>
        [JsonProperty("issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueVO> Issues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIssueBySnapIdsResponse {\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  issues: ").Append(Issues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIssueBySnapIdsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIssueBySnapIdsResponse input)
        {
            if (input == null) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Issues != input.Issues || (this.Issues != null && input.Issues != null && !this.Issues.SequenceEqual(input.Issues))) return false;

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
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Issues != null) hashCode = hashCode * 59 + this.Issues.GetHashCode();
                return hashCode;
            }
        }
    }
}
