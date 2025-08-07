using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EnterpriseProjectConfig 
    {

        /// <summary>
        /// 是否支持企业项目删除
        /// </summary>
        [JsonProperty("delete_ep_support", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteEpSupport { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterpriseProjectConfig {\n");
            sb.Append("  deleteEpSupport: ").Append(DeleteEpSupport).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterpriseProjectConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterpriseProjectConfig input)
        {
            if (input == null) return false;
            if (this.DeleteEpSupport != input.DeleteEpSupport || (this.DeleteEpSupport != null && !this.DeleteEpSupport.Equals(input.DeleteEpSupport))) return false;

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
                if (this.DeleteEpSupport != null) hashCode = hashCode * 59 + this.DeleteEpSupport.GetHashCode();
                return hashCode;
            }
        }
    }
}
