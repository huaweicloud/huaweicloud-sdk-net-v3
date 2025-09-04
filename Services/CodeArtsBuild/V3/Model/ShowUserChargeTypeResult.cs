using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 当前租户（计费）类型
    /// </summary>
    public class ShowUserChargeTypeResult 
    {

        /// <summary>
        /// 套餐类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 计费类型
        /// </summary>
        [JsonProperty("charge_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeType { get; set; }

        /// <summary>
        /// 计费类型
        /// </summary>
        [JsonProperty("main_resource_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowUserChargeTypeResultMainResourceList> MainResourceList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserChargeTypeResult {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  chargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  mainResourceList: ").Append(MainResourceList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserChargeTypeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserChargeTypeResult input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ChargeType != input.ChargeType || (this.ChargeType != null && !this.ChargeType.Equals(input.ChargeType))) return false;
            if (this.MainResourceList != input.MainResourceList || (this.MainResourceList != null && input.MainResourceList != null && !this.MainResourceList.SequenceEqual(input.MainResourceList))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ChargeType != null) hashCode = hashCode * 59 + this.ChargeType.GetHashCode();
                if (this.MainResourceList != null) hashCode = hashCode * 59 + this.MainResourceList.GetHashCode();
                return hashCode;
            }
        }
    }
}
