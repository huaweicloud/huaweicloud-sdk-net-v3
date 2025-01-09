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
    public class ListInstancesStatusResponse : SdkResponse
    {

        /// <summary>
        /// 统计信息。
        /// </summary>
        [JsonProperty("statics", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceStatusStatistics> Statics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesStatusResponse {\n");
            sb.Append("  statics: ").Append(Statics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesStatusResponse input)
        {
            if (input == null) return false;
            if (this.Statics != input.Statics || (this.Statics != null && input.Statics != null && !this.Statics.SequenceEqual(input.Statics))) return false;

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
                if (this.Statics != null) hashCode = hashCode * 59 + this.Statics.GetHashCode();
                return hashCode;
            }
        }
    }
}
