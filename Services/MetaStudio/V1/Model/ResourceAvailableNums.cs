using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 所有类型的资源可用数量
    /// </summary>
    public class ResourceAvailableNums 
    {

        /// <summary>
        /// flexus版资源数。
        /// </summary>
        [JsonProperty("flexus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Flexus { get; set; }

        /// <summary>
        /// 基础版资源数。
        /// </summary>
        [JsonProperty("basic", NullValueHandling = NullValueHandling.Ignore)]
        public int? Basic { get; set; }

        /// <summary>
        /// 进阶版资源数。
        /// </summary>
        [JsonProperty("middle", NullValueHandling = NullValueHandling.Ignore)]
        public int? Middle { get; set; }

        /// <summary>
        /// 进阶测试版资源数。
        /// </summary>
        [JsonProperty("middle_on_demand", NullValueHandling = NullValueHandling.Ignore)]
        public int? MiddleOnDemand { get; set; }

        /// <summary>
        /// 高级版资源数。
        /// </summary>
        [JsonProperty("advance", NullValueHandling = NullValueHandling.Ignore)]
        public int? Advance { get; set; }

        /// <summary>
        /// 出门问问资源数。
        /// </summary>
        [JsonProperty("third_party_cmww", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThirdPartyCmww { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceAvailableNums {\n");
            sb.Append("  flexus: ").Append(Flexus).Append("\n");
            sb.Append("  basic: ").Append(Basic).Append("\n");
            sb.Append("  middle: ").Append(Middle).Append("\n");
            sb.Append("  middleOnDemand: ").Append(MiddleOnDemand).Append("\n");
            sb.Append("  advance: ").Append(Advance).Append("\n");
            sb.Append("  thirdPartyCmww: ").Append(ThirdPartyCmww).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceAvailableNums);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceAvailableNums input)
        {
            if (input == null) return false;
            if (this.Flexus != input.Flexus || (this.Flexus != null && !this.Flexus.Equals(input.Flexus))) return false;
            if (this.Basic != input.Basic || (this.Basic != null && !this.Basic.Equals(input.Basic))) return false;
            if (this.Middle != input.Middle || (this.Middle != null && !this.Middle.Equals(input.Middle))) return false;
            if (this.MiddleOnDemand != input.MiddleOnDemand || (this.MiddleOnDemand != null && !this.MiddleOnDemand.Equals(input.MiddleOnDemand))) return false;
            if (this.Advance != input.Advance || (this.Advance != null && !this.Advance.Equals(input.Advance))) return false;
            if (this.ThirdPartyCmww != input.ThirdPartyCmww || (this.ThirdPartyCmww != null && !this.ThirdPartyCmww.Equals(input.ThirdPartyCmww))) return false;

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
                if (this.Flexus != null) hashCode = hashCode * 59 + this.Flexus.GetHashCode();
                if (this.Basic != null) hashCode = hashCode * 59 + this.Basic.GetHashCode();
                if (this.Middle != null) hashCode = hashCode * 59 + this.Middle.GetHashCode();
                if (this.MiddleOnDemand != null) hashCode = hashCode * 59 + this.MiddleOnDemand.GetHashCode();
                if (this.Advance != null) hashCode = hashCode * 59 + this.Advance.GetHashCode();
                if (this.ThirdPartyCmww != null) hashCode = hashCode * 59 + this.ThirdPartyCmww.GetHashCode();
                return hashCode;
            }
        }
    }
}
