using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteLtsConfigRequestBody 
    {

        /// <summary>
        /// 需要解除的LTS配置列表，一个实例解除多种日志配置需要填写多个item。
        /// </summary>
        [JsonProperty("lts_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteLtsConfigRequestBodyLtsConfigs> LtsConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteLtsConfigRequestBody {\n");
            sb.Append("  ltsConfigs: ").Append(LtsConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteLtsConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteLtsConfigRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LtsConfigs == input.LtsConfigs ||
                    this.LtsConfigs != null &&
                    input.LtsConfigs != null &&
                    this.LtsConfigs.SequenceEqual(input.LtsConfigs)
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
                if (this.LtsConfigs != null)
                    hashCode = hashCode * 59 + this.LtsConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
