using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// OBS文件中的列和流转数据的对应关系。
    /// </summary>
    public class FileMapping 
    {

        /// <summary>
        /// **参数说明**：csv文件格式转换列表。当file_type为csv时，必填。
        /// </summary>
        [JsonProperty("csv_mappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<CsvMappings> CsvMappings { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileMapping {\n");
            sb.Append("  csvMappings: ").Append(CsvMappings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileMapping);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FileMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CsvMappings == input.CsvMappings ||
                    this.CsvMappings != null &&
                    input.CsvMappings != null &&
                    this.CsvMappings.SequenceEqual(input.CsvMappings)
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
                if (this.CsvMappings != null)
                    hashCode = hashCode * 59 + this.CsvMappings.GetHashCode();
                return hashCode;
            }
        }
    }
}
