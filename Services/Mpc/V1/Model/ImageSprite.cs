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
    public class ImageSprite 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public ImageSpritePara Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        /// <summary>
        /// 截取雪碧图后，雪碧图图片文件的输出文件名，如果不填，则默认为：{inputName}_imageSprite_{雪碧图id}_{number}.{format}.{雪碧图id}和{number}从0开始递增 
        /// </summary>
        [JsonProperty("output_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputObjectName { get; set; }

        /// <summary>
        /// 截取雪碧图后，Web VTT 文件的输出路径，只能为相对路径。如果不填，则默认为相对路径：{inputName}_imageSprite_{雪碧图_id}.vtt 
        /// </summary>
        [JsonProperty("webvtt_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WebvttObjectName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSprite {\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  outputObjectName: ").Append(OutputObjectName).Append("\n");
            sb.Append("  webvttObjectName: ").Append(WebvttObjectName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageSprite);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageSprite input)
        {
            if (input == null) return false;
            if (this.Params != input.Params || (this.Params != null && !this.Params.Equals(input.Params))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.OutputObjectName != input.OutputObjectName || (this.OutputObjectName != null && !this.OutputObjectName.Equals(input.OutputObjectName))) return false;
            if (this.WebvttObjectName != input.WebvttObjectName || (this.WebvttObjectName != null && !this.WebvttObjectName.Equals(input.WebvttObjectName))) return false;

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
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.OutputObjectName != null) hashCode = hashCode * 59 + this.OutputObjectName.GetHashCode();
                if (this.WebvttObjectName != null) hashCode = hashCode * 59 + this.WebvttObjectName.GetHashCode();
                return hashCode;
            }
        }
    }
}
