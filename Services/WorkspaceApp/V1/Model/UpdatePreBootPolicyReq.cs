using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 批量设置应用预启动请求体。
    /// </summary>
    public class UpdatePreBootPolicyReq 
    {

        /// <summary>
        /// 应用ID,最多同时操作5个。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 是否设置应用预启动。
        /// </summary>
        [JsonProperty("is_pre_boot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPreBoot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePreBootPolicyReq {\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  isPreBoot: ").Append(IsPreBoot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePreBootPolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePreBootPolicyReq input)
        {
            if (input == null) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.IsPreBoot != input.IsPreBoot || (this.IsPreBoot != null && !this.IsPreBoot.Equals(input.IsPreBoot))) return false;

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
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.IsPreBoot != null) hashCode = hashCode * 59 + this.IsPreBoot.GetHashCode();
                return hashCode;
            }
        }
    }
}
