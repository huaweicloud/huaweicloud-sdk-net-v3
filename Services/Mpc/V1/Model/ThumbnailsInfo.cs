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
    public class ThumbnailsInfo 
    {

        /// <summary>
        /// 截图文件信息。 
        /// </summary>
        [JsonProperty("pic_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PicInfo> PicInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        /// <summary>
        /// 截图压缩包名。 
        /// </summary>
        [JsonProperty("output_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailsInfo {\n");
            sb.Append("  picInfo: ").Append(PicInfo).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  outputName: ").Append(OutputName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThumbnailsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThumbnailsInfo input)
        {
            if (input == null) return false;
            if (this.PicInfo != input.PicInfo || (this.PicInfo != null && input.PicInfo != null && !this.PicInfo.SequenceEqual(input.PicInfo))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.OutputName != input.OutputName || (this.OutputName != null && !this.OutputName.Equals(input.OutputName))) return false;

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
                if (this.PicInfo != null) hashCode = hashCode * 59 + this.PicInfo.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.OutputName != null) hashCode = hashCode * 59 + this.OutputName.GetHashCode();
                return hashCode;
            }
        }
    }
}
