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
    public class MultiTaskInfo 
    {

        /// <summary>
        /// 转码模板ID。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_file", NullValueHandling = NullValueHandling.Ignore)]
        public SourceInfo OutputFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiTaskInfo {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("  outputFile: ").Append(OutputFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultiTaskInfo input)
        {
            if (input == null) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.Error != input.Error || (this.Error != null && !this.Error.Equals(input.Error))) return false;
            if (this.OutputFile != input.OutputFile || (this.OutputFile != null && !this.OutputFile.Equals(input.OutputFile))) return false;

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
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Error != null) hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.OutputFile != null) hashCode = hashCode * 59 + this.OutputFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
