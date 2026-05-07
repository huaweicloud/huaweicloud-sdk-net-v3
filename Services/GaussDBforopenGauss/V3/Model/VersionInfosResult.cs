using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VersionInfosResult 
    {

        /// <summary>
        /// **参数解释**: 引擎版本号。 **取值范围**: 不涉及 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**: 内核引擎版本号。 **取值范围**: 不涉及 
        /// </summary>
        [JsonProperty("kernel_version", NullValueHandling = NullValueHandling.Ignore)]
        public string KernelVersion { get; set; }

        /// <summary>
        /// **参数解释**: 是否为推荐版本。 **取值范围**: - true：推荐版本 - flase: 非推荐版本 
        /// </summary>
        [JsonProperty("recommend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recommend { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionInfosResult {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  kernelVersion: ").Append(KernelVersion).Append("\n");
            sb.Append("  recommend: ").Append(Recommend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionInfosResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionInfosResult input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.KernelVersion != input.KernelVersion || (this.KernelVersion != null && !this.KernelVersion.Equals(input.KernelVersion))) return false;
            if (this.Recommend != input.Recommend || (this.Recommend != null && !this.Recommend.Equals(input.Recommend))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.KernelVersion != null) hashCode = hashCode * 59 + this.KernelVersion.GetHashCode();
                if (this.Recommend != null) hashCode = hashCode * 59 + this.Recommend.GetHashCode();
                return hashCode;
            }
        }
    }
}
