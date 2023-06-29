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
    public class OutputFileInfo 
    {

        /// <summary>
        /// 输出文件名。 
        /// </summary>
        [JsonProperty("output_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFileName { get; set; }

        /// <summary>
        /// 处理信息。 
        /// </summary>
        [JsonProperty("exec_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public SourceInfo MetaData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputFileInfo {\n");
            sb.Append("  outputFileName: ").Append(OutputFileName).Append("\n");
            sb.Append("  execDescription: ").Append(ExecDescription).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputFileInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputFileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputFileName == input.OutputFileName ||
                    (this.OutputFileName != null &&
                    this.OutputFileName.Equals(input.OutputFileName))
                ) && 
                (
                    this.ExecDescription == input.ExecDescription ||
                    (this.ExecDescription != null &&
                    this.ExecDescription.Equals(input.ExecDescription))
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
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
                if (this.OutputFileName != null)
                    hashCode = hashCode * 59 + this.OutputFileName.GetHashCode();
                if (this.ExecDescription != null)
                    hashCode = hashCode * 59 + this.ExecDescription.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
