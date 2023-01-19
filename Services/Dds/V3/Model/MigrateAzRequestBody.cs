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
    public class MigrateAzRequestBody 
    {

        /// <summary>
        /// 迁移到的目标单az或者多az，请参见[地区和终端节点](https://developer.huaweicloud.com/endpoint)。
        /// </summary>
        [JsonProperty("target_azs", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetAzs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateAzRequestBody {\n");
            sb.Append("  targetAzs: ").Append(TargetAzs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateAzRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateAzRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetAzs == input.TargetAzs ||
                    (this.TargetAzs != null &&
                    this.TargetAzs.Equals(input.TargetAzs))
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
                if (this.TargetAzs != null)
                    hashCode = hashCode * 59 + this.TargetAzs.GetHashCode();
                return hashCode;
            }
        }
    }
}
