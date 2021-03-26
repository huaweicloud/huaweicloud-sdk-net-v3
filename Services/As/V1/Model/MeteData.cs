using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 用户自定义键值对
    /// </summary>
    public class MeteData 
    {

        /// <summary>
        /// metadata键、值。
        /// </summary>
        [JsonProperty("User-defined_key-value_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDefinedKeyValuePairs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeteData {\n");
            sb.Append("  userDefinedKeyValuePairs: ").Append(UserDefinedKeyValuePairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MeteData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MeteData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserDefinedKeyValuePairs == input.UserDefinedKeyValuePairs ||
                    (this.UserDefinedKeyValuePairs != null &&
                    this.UserDefinedKeyValuePairs.Equals(input.UserDefinedKeyValuePairs))
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
                if (this.UserDefinedKeyValuePairs != null)
                    hashCode = hashCode * 59 + this.UserDefinedKeyValuePairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
