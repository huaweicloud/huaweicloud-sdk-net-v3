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
    public class DefaultRecordConfig 
    {

        /// <summary>
        /// 录制格式，当前支持：FLV，HLS，MP4三种格式，设置格式时必须使用大写字母
        /// </summary>
        [JsonProperty("record_format", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoFormatVar> RecordFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_addr", NullValueHandling = NullValueHandling.Ignore)]
        public RecordObsFileAddr ObsAddr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hls_config", NullValueHandling = NullValueHandling.Ignore)]
        public HLSRecordConfig HlsConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flv_config", NullValueHandling = NullValueHandling.Ignore)]
        public FLVRecordConfig FlvConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mp4_config", NullValueHandling = NullValueHandling.Ignore)]
        public MP4RecordConfig Mp4Config { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultRecordConfig {\n");
            sb.Append("  recordFormat: ").Append(RecordFormat).Append("\n");
            sb.Append("  obsAddr: ").Append(ObsAddr).Append("\n");
            sb.Append("  hlsConfig: ").Append(HlsConfig).Append("\n");
            sb.Append("  flvConfig: ").Append(FlvConfig).Append("\n");
            sb.Append("  mp4Config: ").Append(Mp4Config).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DefaultRecordConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DefaultRecordConfig input)
        {
            if (input == null) return false;
            if (this.RecordFormat != input.RecordFormat || (this.RecordFormat != null && input.RecordFormat != null && !this.RecordFormat.SequenceEqual(input.RecordFormat))) return false;
            if (this.ObsAddr != input.ObsAddr || (this.ObsAddr != null && !this.ObsAddr.Equals(input.ObsAddr))) return false;
            if (this.HlsConfig != input.HlsConfig || (this.HlsConfig != null && !this.HlsConfig.Equals(input.HlsConfig))) return false;
            if (this.FlvConfig != input.FlvConfig || (this.FlvConfig != null && !this.FlvConfig.Equals(input.FlvConfig))) return false;
            if (this.Mp4Config != input.Mp4Config || (this.Mp4Config != null && !this.Mp4Config.Equals(input.Mp4Config))) return false;

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
                if (this.RecordFormat != null) hashCode = hashCode * 59 + this.RecordFormat.GetHashCode();
                if (this.ObsAddr != null) hashCode = hashCode * 59 + this.ObsAddr.GetHashCode();
                if (this.HlsConfig != null) hashCode = hashCode * 59 + this.HlsConfig.GetHashCode();
                if (this.FlvConfig != null) hashCode = hashCode * 59 + this.FlvConfig.GetHashCode();
                if (this.Mp4Config != null) hashCode = hashCode * 59 + this.Mp4Config.GetHashCode();
                return hashCode;
            }
        }
    }
}
