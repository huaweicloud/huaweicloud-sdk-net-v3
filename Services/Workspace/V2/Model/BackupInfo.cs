using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 备份信息。
    /// </summary>
    public class BackupInfo 
    {

        /// <summary>
        /// 优先级，数字越小，优先级越高，取值1-255。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 接入备份地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 租户自定义接入备份地址。
        /// </summary>
        [JsonProperty("address_custom", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressCustom { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupInfo {\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  addressCustom: ").Append(AddressCustom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupInfo input)
        {
            if (input == null) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.AddressCustom != input.AddressCustom || (this.AddressCustom != null && !this.AddressCustom.Equals(input.AddressCustom))) return false;

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
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressCustom != null) hashCode = hashCode * 59 + this.AddressCustom.GetHashCode();
                return hashCode;
            }
        }
    }
}
