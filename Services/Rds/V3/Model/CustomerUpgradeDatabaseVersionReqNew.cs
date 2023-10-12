using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerUpgradeDatabaseVersionReqNew 
    {

        /// <summary>
        /// 是否延迟至可维护时间段内升级。 取值范围： - true：延迟升级。表示实例将在设置的可维护时间段内升级。 - false：立即升级，默认该方式。
        /// </summary>
        [JsonProperty("is_delayed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDelayed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerUpgradeDatabaseVersionReqNew {\n");
            sb.Append("  isDelayed: ").Append(IsDelayed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerUpgradeDatabaseVersionReqNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerUpgradeDatabaseVersionReqNew input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsDelayed == input.IsDelayed ||
                    (this.IsDelayed != null &&
                    this.IsDelayed.Equals(input.IsDelayed))
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
                if (this.IsDelayed != null)
                    hashCode = hashCode * 59 + this.IsDelayed.GetHashCode();
                return hashCode;
            }
        }
    }
}
