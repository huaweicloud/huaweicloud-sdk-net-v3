using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RedisConfig 
    {

        /// <summary>
        /// 实例配置项的值。
        /// </summary>
        [JsonProperty("param_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamValue { get; set; }

        /// <summary>
        /// 实例配置项名。
        /// </summary>
        [JsonProperty("param_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamName { get; set; }

        /// <summary>
        /// 实例配置项ID。
        /// </summary>
        [JsonProperty("param_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedisConfig {\n");
            sb.Append("  paramValue: ").Append(ParamValue).Append("\n");
            sb.Append("  paramName: ").Append(ParamName).Append("\n");
            sb.Append("  paramId: ").Append(ParamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RedisConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RedisConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParamValue == input.ParamValue ||
                    (this.ParamValue != null &&
                    this.ParamValue.Equals(input.ParamValue))
                ) && 
                (
                    this.ParamName == input.ParamName ||
                    (this.ParamName != null &&
                    this.ParamName.Equals(input.ParamName))
                ) && 
                (
                    this.ParamId == input.ParamId ||
                    (this.ParamId != null &&
                    this.ParamId.Equals(input.ParamId))
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
                if (this.ParamValue != null)
                    hashCode = hashCode * 59 + this.ParamValue.GetHashCode();
                if (this.ParamName != null)
                    hashCode = hashCode * 59 + this.ParamName.GetHashCode();
                if (this.ParamId != null)
                    hashCode = hashCode * 59 + this.ParamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
