using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Common 
    {

        /// <summary>
        /// 是否开启高清低码功能。  取值如下： - false：关闭。 - true：开启。 
        /// </summary>
        [JsonProperty("PVC", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pvc { get; set; }

        /// <summary>
        /// HLS分片间隔，仅封装类型“pack_type”取值为1或3时，该参数生效。  取值范围：[2，10]。  单位：秒。 
        /// </summary>
        [JsonProperty("hls_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInterval { get; set; }

        /// <summary>
        /// DASH间隔，仅封装类型“pack_type”取值为2或3时，该参数生效。  取值范围：[2，10]。  单位：秒。 
        /// </summary>
        [JsonProperty("dash_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DashInterval { get; set; }

        /// <summary>
        /// 封装类型。  取值如下： - 1：HLS - 2：DASH - 3：HLS+DASH - 4：MP4 - 5：MP3 - 6：ADTS  &gt; pack_type设置为5和6时，不能设置视频参数。 
        /// </summary>
        [JsonProperty("pack_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PackType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Common {\n");
            sb.Append("  pvc: ").Append(Pvc).Append("\n");
            sb.Append("  hlsInterval: ").Append(HlsInterval).Append("\n");
            sb.Append("  dashInterval: ").Append(DashInterval).Append("\n");
            sb.Append("  packType: ").Append(PackType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Common);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Common input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pvc == input.Pvc ||
                    (this.Pvc != null &&
                    this.Pvc.Equals(input.Pvc))
                ) && 
                (
                    this.HlsInterval == input.HlsInterval ||
                    (this.HlsInterval != null &&
                    this.HlsInterval.Equals(input.HlsInterval))
                ) && 
                (
                    this.DashInterval == input.DashInterval ||
                    (this.DashInterval != null &&
                    this.DashInterval.Equals(input.DashInterval))
                ) && 
                (
                    this.PackType == input.PackType ||
                    (this.PackType != null &&
                    this.PackType.Equals(input.PackType))
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
                if (this.Pvc != null)
                    hashCode = hashCode * 59 + this.Pvc.GetHashCode();
                if (this.HlsInterval != null)
                    hashCode = hashCode * 59 + this.HlsInterval.GetHashCode();
                if (this.DashInterval != null)
                    hashCode = hashCode * 59 + this.DashInterval.GetHashCode();
                if (this.PackType != null)
                    hashCode = hashCode * 59 + this.PackType.GetHashCode();
                return hashCode;
            }
        }
    }
}
