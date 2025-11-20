using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MigrateDnInfoOpenResponse 
    {

        /// <summary>
        /// rds实例id。
        /// </summary>
        [JsonProperty("dn_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DnInstanceId { get; set; }

        /// <summary>
        /// rds实例名称。
        /// </summary>
        [JsonProperty("dn_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DnInstanceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateDnInfoOpenResponse {\n");
            sb.Append("  dnInstanceId: ").Append(DnInstanceId).Append("\n");
            sb.Append("  dnInstanceName: ").Append(DnInstanceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateDnInfoOpenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateDnInfoOpenResponse input)
        {
            if (input == null) return false;
            if (this.DnInstanceId != input.DnInstanceId || (this.DnInstanceId != null && !this.DnInstanceId.Equals(input.DnInstanceId))) return false;
            if (this.DnInstanceName != input.DnInstanceName || (this.DnInstanceName != null && !this.DnInstanceName.Equals(input.DnInstanceName))) return false;

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
                if (this.DnInstanceId != null) hashCode = hashCode * 59 + this.DnInstanceId.GetHashCode();
                if (this.DnInstanceName != null) hashCode = hashCode * 59 + this.DnInstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
