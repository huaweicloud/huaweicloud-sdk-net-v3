using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRedisPitrInfoResponse : SdkResponse
    {

        /// <summary>
        /// 查询Redis实例指定时间点恢复所占用的存储空间。 单位：GB
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public string Storage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRedisPitrInfoResponse {\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRedisPitrInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRedisPitrInfoResponse input)
        {
            if (input == null) return false;
            if (this.Storage != input.Storage || (this.Storage != null && !this.Storage.Equals(input.Storage))) return false;

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
                if (this.Storage != null) hashCode = hashCode * 59 + this.Storage.GetHashCode();
                return hashCode;
            }
        }
    }
}
