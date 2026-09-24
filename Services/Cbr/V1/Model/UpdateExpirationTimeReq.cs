using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateExpirationTimeReq 
    {

        /// <summary>
        /// 预期过期日期，格式：YYYY-MM-DD。
        /// </summary>
        [JsonProperty("expect_expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectExpirationDate { get; set; }

        /// <summary>
        /// 用户所在时区，格式形如 UTC+08:00
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateExpirationTimeReq {\n");
            sb.Append("  expectExpirationDate: ").Append(ExpectExpirationDate).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateExpirationTimeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateExpirationTimeReq input)
        {
            if (input == null) return false;
            if (this.ExpectExpirationDate != input.ExpectExpirationDate || (this.ExpectExpirationDate != null && !this.ExpectExpirationDate.Equals(input.ExpectExpirationDate))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;

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
                if (this.ExpectExpirationDate != null) hashCode = hashCode * 59 + this.ExpectExpirationDate.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
