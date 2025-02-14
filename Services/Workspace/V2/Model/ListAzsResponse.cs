using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAzsResponse : SdkResponse
    {

        /// <summary>
        /// 支持类型。
        /// </summary>
        [JsonProperty("support_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportType { get; set; }

        /// <summary>
        /// 默认类型。
        /// </summary>
        [JsonProperty("default_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultType { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("azs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<AzInfo>> Azs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAzsResponse {\n");
            sb.Append("  supportType: ").Append(SupportType).Append("\n");
            sb.Append("  defaultType: ").Append(DefaultType).Append("\n");
            sb.Append("  azs: ").Append(Azs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAzsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAzsResponse input)
        {
            if (input == null) return false;
            if (this.SupportType != input.SupportType || (this.SupportType != null && input.SupportType != null && !this.SupportType.SequenceEqual(input.SupportType))) return false;
            if (this.DefaultType != input.DefaultType || (this.DefaultType != null && !this.DefaultType.Equals(input.DefaultType))) return false;
            if (this.Azs != input.Azs || (this.Azs != null && input.Azs != null && !this.Azs.SequenceEqual(input.Azs))) return false;

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
                if (this.SupportType != null) hashCode = hashCode * 59 + this.SupportType.GetHashCode();
                if (this.DefaultType != null) hashCode = hashCode * 59 + this.DefaultType.GetHashCode();
                if (this.Azs != null) hashCode = hashCode * 59 + this.Azs.GetHashCode();
                return hashCode;
            }
        }
    }
}
