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
    /// 
    /// </summary>
    public class CreateSiteInformationPair 
    {

        /// <summary>
        /// 端到端（P2P）类型分支网络连接的两个端点定义，长度固定为2的数组。
        /// </summary>
        [JsonProperty("sites", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateSiteInformation> Sites { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSiteInformationPair {\n");
            sb.Append("  sites: ").Append(Sites).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSiteInformationPair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSiteInformationPair input)
        {
            if (input == null) return false;
            if (this.Sites != input.Sites || (this.Sites != null && input.Sites != null && !this.Sites.SequenceEqual(input.Sites))) return false;

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
                if (this.Sites != null) hashCode = hashCode * 59 + this.Sites.GetHashCode();
                return hashCode;
            }
        }
    }
}
