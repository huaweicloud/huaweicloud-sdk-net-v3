using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 企业注册信息
    /// </summary>
    public class ModCorpBasicInfoDTO 
    {

        /// <summary>
        /// 企业所在地，最大长度为255个字符。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 企业自动开户开关。
        /// </summary>
        [JsonProperty("autoUserCreate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUserCreate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModCorpBasicInfoDTO {\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  autoUserCreate: ").Append(AutoUserCreate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModCorpBasicInfoDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModCorpBasicInfoDTO input)
        {
            if (input == null) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.AutoUserCreate != input.AutoUserCreate || (this.AutoUserCreate != null && !this.AutoUserCreate.Equals(input.AutoUserCreate))) return false;

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
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AutoUserCreate != null) hashCode = hashCode * 59 + this.AutoUserCreate.GetHashCode();
                return hashCode;
            }
        }
    }
}
