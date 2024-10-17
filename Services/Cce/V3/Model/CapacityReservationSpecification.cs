using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 扩展伸缩组容量预留配置
    /// </summary>
    public class CapacityReservationSpecification 
    {

        /// <summary>
        /// 私有池id，preference为none时忽略该值
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 私有池容量选项，为 none 时表示不指定容量预留，为 targeted 时表示指定容量预留，此时 id 不能为空
        /// </summary>
        [JsonProperty("preference", NullValueHandling = NullValueHandling.Ignore)]
        public string Preference { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityReservationSpecification {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  preference: ").Append(Preference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CapacityReservationSpecification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CapacityReservationSpecification input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Preference != input.Preference || (this.Preference != null && !this.Preference.Equals(input.Preference))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Preference != null) hashCode = hashCode * 59 + this.Preference.GetHashCode();
                return hashCode;
            }
        }
    }
}
