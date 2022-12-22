using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 原地升级配置
    /// </summary>
    public class InPlaceRollingUpdate 
    {

        /// <summary>
        /// 节点升级步长，取值范围为[1, 40]，建议取值20
        /// </summary>
        [JsonProperty("userDefinedStep", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserDefinedStep { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InPlaceRollingUpdate {\n");
            sb.Append("  userDefinedStep: ").Append(UserDefinedStep).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InPlaceRollingUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InPlaceRollingUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserDefinedStep == input.UserDefinedStep ||
                    (this.UserDefinedStep != null &&
                    this.UserDefinedStep.Equals(input.UserDefinedStep))
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
                if (this.UserDefinedStep != null)
                    hashCode = hashCode * 59 + this.UserDefinedStep.GetHashCode();
                return hashCode;
            }
        }
    }
}
