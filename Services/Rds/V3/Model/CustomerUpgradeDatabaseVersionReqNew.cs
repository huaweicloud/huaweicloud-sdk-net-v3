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
        /// 设置仅对RDS for MySQL数据库实例（主备）生效。主备实例升级过程中，备机升级成功后，会触发主备倒换继续升级主机，主机升级完成后，若主备可用区不同则触发第二次倒换，保证可用区不变。若主备可用区相同，该选项无效。 取值范围： - true：默认该方式。表示升级过程中会进行二次倒换保证主备实例可用区不变。 - false：升级过程中不进行第二次主备倒换，适合对主备所在可用区不敏感，对业务连续性敏感的客户。
        /// </summary>
        [JsonProperty("second_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecondSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerUpgradeDatabaseVersionReqNew {\n");
            sb.Append("  isDelayed: ").Append(IsDelayed).Append("\n");
            sb.Append("  secondSwitch: ").Append(SecondSwitch).Append("\n");
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
            if (input == null) return false;
            if (this.IsDelayed != input.IsDelayed || (this.IsDelayed != null && !this.IsDelayed.Equals(input.IsDelayed))) return false;
            if (this.SecondSwitch != input.SecondSwitch || (this.SecondSwitch != null && !this.SecondSwitch.Equals(input.SecondSwitch))) return false;

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
                if (this.IsDelayed != null) hashCode = hashCode * 59 + this.IsDelayed.GetHashCode();
                if (this.SecondSwitch != null) hashCode = hashCode * 59 + this.SecondSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
