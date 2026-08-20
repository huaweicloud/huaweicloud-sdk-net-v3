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
    /// 给工作项关联外部链接的响应结果。
    /// </summary>
    public class IssuesAssociationRespResult 
    {

        /// <summary>
        /// 关联失败的工作项列表。
        /// </summary>
        [JsonProperty("fail", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateThirdPartyAssociateDTO> Fail { get; set; }

        /// <summary>
        /// 关联成功的工作项列表。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateThirdPartyAssociateDTO> Success { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssuesAssociationRespResult {\n");
            sb.Append("  fail: ").Append(Fail).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssuesAssociationRespResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssuesAssociationRespResult input)
        {
            if (input == null) return false;
            if (this.Fail != input.Fail || (this.Fail != null && input.Fail != null && !this.Fail.SequenceEqual(input.Fail))) return false;
            if (this.Success != input.Success || (this.Success != null && input.Success != null && !this.Success.SequenceEqual(input.Success))) return false;

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
                if (this.Fail != null) hashCode = hashCode * 59 + this.Fail.GetHashCode();
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                return hashCode;
            }
        }
    }
}
