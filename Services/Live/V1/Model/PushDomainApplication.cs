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
    /// 
    /// </summary>
    public class PushDomainApplication 
    {

        /// <summary>
        /// 应用名，默认为live
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// HLS切片时长，单位：s。
        /// </summary>
        [JsonProperty("hls_fragment", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsFragment { get; set; }

        /// <summary>
        /// 每个M3U8文件内ts切片个数
        /// </summary>
        [JsonProperty("hls_ts_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsTsCount { get; set; }

        /// <summary>
        /// 每个M3U8文件内最小ts分片数
        /// </summary>
        [JsonProperty("hls_min_frags", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsMinFrags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushDomainApplication {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  hlsFragment: ").Append(HlsFragment).Append("\n");
            sb.Append("  hlsTsCount: ").Append(HlsTsCount).Append("\n");
            sb.Append("  hlsMinFrags: ").Append(HlsMinFrags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PushDomainApplication);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PushDomainApplication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.HlsFragment == input.HlsFragment ||
                    (this.HlsFragment != null &&
                    this.HlsFragment.Equals(input.HlsFragment))
                ) && 
                (
                    this.HlsTsCount == input.HlsTsCount ||
                    (this.HlsTsCount != null &&
                    this.HlsTsCount.Equals(input.HlsTsCount))
                ) && 
                (
                    this.HlsMinFrags == input.HlsMinFrags ||
                    (this.HlsMinFrags != null &&
                    this.HlsMinFrags.Equals(input.HlsMinFrags))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HlsFragment != null)
                    hashCode = hashCode * 59 + this.HlsFragment.GetHashCode();
                if (this.HlsTsCount != null)
                    hashCode = hashCode * 59 + this.HlsTsCount.GetHashCode();
                if (this.HlsMinFrags != null)
                    hashCode = hashCode * 59 + this.HlsMinFrags.GetHashCode();
                return hashCode;
            }
        }
    }
}
