using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteInstanceRequestBody 
    {

        /// <summary>
        /// 是否删除obs桶
        /// </summary>
        [JsonProperty("delete_obs", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteObs { get; set; }

        /// <summary>
        /// 是否删除DNS域名信息
        /// </summary>
        [JsonProperty("delete_dns", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteDns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInstanceRequestBody {\n");
            sb.Append("  deleteObs: ").Append(DeleteObs).Append("\n");
            sb.Append("  deleteDns: ").Append(DeleteDns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteInstanceRequestBody input)
        {
            if (input == null) return false;
            if (this.DeleteObs != input.DeleteObs || (this.DeleteObs != null && !this.DeleteObs.Equals(input.DeleteObs))) return false;
            if (this.DeleteDns != input.DeleteDns || (this.DeleteDns != null && !this.DeleteDns.Equals(input.DeleteDns))) return false;

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
                if (this.DeleteObs != null) hashCode = hashCode * 59 + this.DeleteObs.GetHashCode();
                if (this.DeleteDns != null) hashCode = hashCode * 59 + this.DeleteDns.GetHashCode();
                return hashCode;
            }
        }
    }
}
