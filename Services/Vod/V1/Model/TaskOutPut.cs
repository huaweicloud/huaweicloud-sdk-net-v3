using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskOutPut 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_info", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo ObsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectMetaData MetaData { get; set; }

        /// <summary>
        /// 输出文件播放地址
        /// </summary>
        [JsonProperty("file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FileUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskOutPut {\n");
            sb.Append("  obsInfo: ").Append(ObsInfo).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("  fileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskOutPut);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskOutPut input)
        {
            if (input == null) return false;
            if (this.ObsInfo != input.ObsInfo || (this.ObsInfo != null && !this.ObsInfo.Equals(input.ObsInfo))) return false;
            if (this.MetaData != input.MetaData || (this.MetaData != null && !this.MetaData.Equals(input.MetaData))) return false;
            if (this.FileUrl != input.FileUrl || (this.FileUrl != null && !this.FileUrl.Equals(input.FileUrl))) return false;

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
                if (this.ObsInfo != null) hashCode = hashCode * 59 + this.ObsInfo.GetHashCode();
                if (this.MetaData != null) hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.FileUrl != null) hashCode = hashCode * 59 + this.FileUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
