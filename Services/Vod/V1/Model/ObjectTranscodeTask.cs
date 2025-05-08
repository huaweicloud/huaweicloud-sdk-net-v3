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
    public class ObjectTranscodeTask 
    {

        /// <summary>
        /// 转码模板ID 
        /// </summary>
        [JsonProperty("trans_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransTemplateId { get; set; }

        /// <summary>
        /// 转码输出文件名 
        /// </summary>
        [JsonProperty("output_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo Output { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectTranscodeTask {\n");
            sb.Append("  transTemplateId: ").Append(TransTemplateId).Append("\n");
            sb.Append("  outputName: ").Append(OutputName).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectTranscodeTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectTranscodeTask input)
        {
            if (input == null) return false;
            if (this.TransTemplateId != input.TransTemplateId || (this.TransTemplateId != null && !this.TransTemplateId.Equals(input.TransTemplateId))) return false;
            if (this.OutputName != input.OutputName || (this.OutputName != null && !this.OutputName.Equals(input.OutputName))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;

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
                if (this.TransTemplateId != null) hashCode = hashCode * 59 + this.TransTemplateId.GetHashCode();
                if (this.OutputName != null) hashCode = hashCode * 59 + this.OutputName.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                return hashCode;
            }
        }
    }
}
