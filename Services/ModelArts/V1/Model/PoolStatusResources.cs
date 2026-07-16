using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释**：资源池中不同状态的资源信息。
    /// </summary>
    public class PoolStatusResources 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creating", NullValueHandling = NullValueHandling.Ignore)]
        public PoolResourceFlavorCount Creating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public PoolResourceFlavorCount Available { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("abnormal", NullValueHandling = NullValueHandling.Ignore)]
        public PoolResourceFlavorCount Abnormal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deleting", NullValueHandling = NullValueHandling.Ignore)]
        public PoolResourceFlavorCount Deleting { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolStatusResources {\n");
            sb.Append("  creating: ").Append(Creating).Append("\n");
            sb.Append("  available: ").Append(Available).Append("\n");
            sb.Append("  abnormal: ").Append(Abnormal).Append("\n");
            sb.Append("  deleting: ").Append(Deleting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolStatusResources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolStatusResources input)
        {
            if (input == null) return false;
            if (this.Creating != input.Creating || (this.Creating != null && !this.Creating.Equals(input.Creating))) return false;
            if (this.Available != input.Available || (this.Available != null && !this.Available.Equals(input.Available))) return false;
            if (this.Abnormal != input.Abnormal || (this.Abnormal != null && !this.Abnormal.Equals(input.Abnormal))) return false;
            if (this.Deleting != input.Deleting || (this.Deleting != null && !this.Deleting.Equals(input.Deleting))) return false;

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
                if (this.Creating != null) hashCode = hashCode * 59 + this.Creating.GetHashCode();
                if (this.Available != null) hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Abnormal != null) hashCode = hashCode * 59 + this.Abnormal.GetHashCode();
                if (this.Deleting != null) hashCode = hashCode * 59 + this.Deleting.GetHashCode();
                return hashCode;
            }
        }
    }
}
