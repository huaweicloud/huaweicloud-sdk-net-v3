using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 本端大区ID。
    /// </summary>
    public class BillingMode 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_mode", NullValueHandling = NullValueHandling.Ignore)]
        public BillingModeEnum _BillingMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingMode {\n");
            sb.Append("  _billingMode: ").Append(_BillingMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillingMode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BillingMode input)
        {
            if (input == null) return false;
            if (this._BillingMode != input._BillingMode) return false;

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
                hashCode = hashCode * 59 + this._BillingMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
