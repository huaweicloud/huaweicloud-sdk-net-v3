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
    /// Response Object
    /// </summary>
    public class RestoreInstanceResponse : SdkResponse
    {

        /// <summary>
        /// 恢复记录ID。
        /// </summary>
        [JsonProperty("restore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreInstanceResponse {\n");
            sb.Append("  restoreId: ").Append(RestoreId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreInstanceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreId == input.RestoreId ||
                    (this.RestoreId != null &&
                    this.RestoreId.Equals(input.RestoreId))
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
                if (this.RestoreId != null)
                    hashCode = hashCode * 59 + this.RestoreId.GetHashCode();
                return hashCode;
            }
        }
    }
}
