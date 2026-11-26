using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Platform 
    {

        /// <summary>
        /// 制品适用的CPU架构。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// 制品适用的操作系统。
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 制品适用的操作系统版本。
        /// </summary>
        [JsonProperty("os.version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// 制品适用的操作系统特性。
        /// </summary>
        [JsonProperty("os.features", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OsFeatures { get; set; }

        /// <summary>
        /// 同一系列 CPU 下的细分型号，例如 Intel i5-13400、i5-13600 属于同代不同 variant。
        /// </summary>
        [JsonProperty("variant", NullValueHandling = NullValueHandling.Ignore)]
        public string Variant { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Platform {\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  osFeatures: ").Append(OsFeatures).Append("\n");
            sb.Append("  variant: ").Append(Variant).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Platform);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Platform input)
        {
            if (input == null) return false;
            if (this.Architecture != input.Architecture || (this.Architecture != null && !this.Architecture.Equals(input.Architecture))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.OsVersion != input.OsVersion || (this.OsVersion != null && !this.OsVersion.Equals(input.OsVersion))) return false;
            if (this.OsFeatures != input.OsFeatures || (this.OsFeatures != null && input.OsFeatures != null && !this.OsFeatures.SequenceEqual(input.OsFeatures))) return false;
            if (this.Variant != input.Variant || (this.Variant != null && !this.Variant.Equals(input.Variant))) return false;

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
                if (this.Architecture != null) hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.OsVersion != null) hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.OsFeatures != null) hashCode = hashCode * 59 + this.OsFeatures.GetHashCode();
                if (this.Variant != null) hashCode = hashCode * 59 + this.Variant.GetHashCode();
                return hashCode;
            }
        }
    }
}
