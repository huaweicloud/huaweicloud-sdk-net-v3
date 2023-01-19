using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DecryptDatakeyResponse : SdkResponse
    {

        /// <summary>
        /// DEK明文的16进制字符串。
        /// </summary>
        [JsonProperty("data_key", NullValueHandling = NullValueHandling.Ignore)]
        public string DataKey { get; set; }

        /// <summary>
        /// DEK明文字节长度。
        /// </summary>
        [JsonProperty("datakey_length", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyLength { get; set; }

        /// <summary>
        /// DEK明文的SHA256值对应的16进制字符串。
        /// </summary>
        [JsonProperty("datakey_dgst", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyDgst { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptDatakeyResponse {\n");
            sb.Append("  dataKey: ").Append(DataKey).Append("\n");
            sb.Append("  datakeyLength: ").Append(DatakeyLength).Append("\n");
            sb.Append("  datakeyDgst: ").Append(DatakeyDgst).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecryptDatakeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecryptDatakeyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataKey == input.DataKey ||
                    (this.DataKey != null &&
                    this.DataKey.Equals(input.DataKey))
                ) && 
                (
                    this.DatakeyLength == input.DatakeyLength ||
                    (this.DatakeyLength != null &&
                    this.DatakeyLength.Equals(input.DatakeyLength))
                ) && 
                (
                    this.DatakeyDgst == input.DatakeyDgst ||
                    (this.DatakeyDgst != null &&
                    this.DatakeyDgst.Equals(input.DatakeyDgst))
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
                if (this.DataKey != null)
                    hashCode = hashCode * 59 + this.DataKey.GetHashCode();
                if (this.DatakeyLength != null)
                    hashCode = hashCode * 59 + this.DatakeyLength.GetHashCode();
                if (this.DatakeyDgst != null)
                    hashCode = hashCode * 59 + this.DatakeyDgst.GetHashCode();
                return hashCode;
            }
        }
    }
}
