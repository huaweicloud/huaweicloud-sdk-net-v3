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
    /// 删除工作项下外部链接的响应结果。
    /// </summary>
    public class DeleteThirdPartyAssociateResponseResult 
    {

        /// <summary>
        /// 删除失败的外部链接ID列表。
        /// </summary>
        [JsonProperty("fail", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fail { get; set; }

        /// <summary>
        /// 成功删除的外部链接ID列表。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Success { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteThirdPartyAssociateResponseResult {\n");
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
            return this.Equals(input as DeleteThirdPartyAssociateResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteThirdPartyAssociateResponseResult input)
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
