using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 拉流打包信息
    /// </summary>
    public class EndpointItem 
    {

        /// <summary>
        /// HLS打包信息
        /// </summary>
        [JsonProperty("hls_package", NullValueHandling = NullValueHandling.Ignore)]
        public List<HlsPackageItem> HlsPackage { get; set; }

        /// <summary>
        /// DASH打包信息
        /// </summary>
        [JsonProperty("dash_package", NullValueHandling = NullValueHandling.Ignore)]
        public List<DashPackageItem> DashPackage { get; set; }

        /// <summary>
        /// MSS打包信息
        /// </summary>
        [JsonProperty("mss_package", NullValueHandling = NullValueHandling.Ignore)]
        public List<MssPackageItem> MssPackage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointItem {\n");
            sb.Append("  hlsPackage: ").Append(HlsPackage).Append("\n");
            sb.Append("  dashPackage: ").Append(DashPackage).Append("\n");
            sb.Append("  mssPackage: ").Append(MssPackage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HlsPackage == input.HlsPackage ||
                    this.HlsPackage != null &&
                    input.HlsPackage != null &&
                    this.HlsPackage.SequenceEqual(input.HlsPackage)
                ) && 
                (
                    this.DashPackage == input.DashPackage ||
                    this.DashPackage != null &&
                    input.DashPackage != null &&
                    this.DashPackage.SequenceEqual(input.DashPackage)
                ) && 
                (
                    this.MssPackage == input.MssPackage ||
                    this.MssPackage != null &&
                    input.MssPackage != null &&
                    this.MssPackage.SequenceEqual(input.MssPackage)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.HlsPackage != null)
                    hashCode = hashCode * 59 + this.HlsPackage.GetHashCode();
                if (this.DashPackage != null)
                    hashCode = hashCode * 59 + this.DashPackage.GetHashCode();
                if (this.MssPackage != null)
                    hashCode = hashCode * 59 + this.MssPackage.GetHashCode();
                return hashCode;
            }
        }
    }
}
