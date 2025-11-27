using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListMeta 
    {

        /// <summary>
        /// 服务器内部版本标识符
        /// </summary>
        [JsonProperty("resourceVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// 表示当前请求返回的结果是否还有下一页数据
        /// </summary>
        [JsonProperty("continue", NullValueHandling = NullValueHandling.Ignore)]
        public string Continue { get; set; }

        /// <summary>
        /// 表示在当前响应之后，列表中还有多少项未被包含进来
        /// </summary>
        [JsonProperty("remainingItemCount", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingItemCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMeta {\n");
            sb.Append("  resourceVersion: ").Append(ResourceVersion).Append("\n");
            sb.Append("  Continue: ").Append(Continue).Append("\n");
            sb.Append("  remainingItemCount: ").Append(RemainingItemCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMeta input)
        {
            if (input == null) return false;
            if (this.ResourceVersion != input.ResourceVersion || (this.ResourceVersion != null && !this.ResourceVersion.Equals(input.ResourceVersion))) return false;
            if (this.Continue != input.Continue || (this.Continue != null && !this.Continue.Equals(input.Continue))) return false;
            if (this.RemainingItemCount != input.RemainingItemCount || (this.RemainingItemCount != null && !this.RemainingItemCount.Equals(input.RemainingItemCount))) return false;

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
                if (this.ResourceVersion != null) hashCode = hashCode * 59 + this.ResourceVersion.GetHashCode();
                if (this.Continue != null) hashCode = hashCode * 59 + this.Continue.GetHashCode();
                if (this.RemainingItemCount != null) hashCode = hashCode * 59 + this.RemainingItemCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
