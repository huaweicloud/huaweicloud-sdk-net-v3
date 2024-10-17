using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AzInfo 
    {

        /// <summary>
        /// 可用区名称
        /// </summary>
        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneName { get; set; }

        /// <summary>
        /// 可用区编号
        /// </summary>
        [JsonProperty("zone_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ZoneNumber { get; set; }

        /// <summary>
        /// 可用区类型
        /// </summary>
        [JsonProperty("az_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AzType { get; set; }

        /// <summary>
        /// 可用区中文别名
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// 可用区英文别名
        /// </summary>
        [JsonProperty("alias_us", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasUs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AzInfo {\n");
            sb.Append("  zoneName: ").Append(ZoneName).Append("\n");
            sb.Append("  zoneNumber: ").Append(ZoneNumber).Append("\n");
            sb.Append("  azType: ").Append(AzType).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  aliasUs: ").Append(AliasUs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AzInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AzInfo input)
        {
            if (input == null) return false;
            if (this.ZoneName != input.ZoneName || (this.ZoneName != null && !this.ZoneName.Equals(input.ZoneName))) return false;
            if (this.ZoneNumber != input.ZoneNumber || (this.ZoneNumber != null && !this.ZoneNumber.Equals(input.ZoneNumber))) return false;
            if (this.AzType != input.AzType || (this.AzType != null && !this.AzType.Equals(input.AzType))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;
            if (this.AliasUs != input.AliasUs || (this.AliasUs != null && !this.AliasUs.Equals(input.AliasUs))) return false;

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
                if (this.ZoneName != null) hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                if (this.ZoneNumber != null) hashCode = hashCode * 59 + this.ZoneNumber.GetHashCode();
                if (this.AzType != null) hashCode = hashCode * 59 + this.AzType.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.AliasUs != null) hashCode = hashCode * 59 + this.AliasUs.GetHashCode();
                return hashCode;
            }
        }
    }
}
