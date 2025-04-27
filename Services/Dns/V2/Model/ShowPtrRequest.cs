using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowPtrRequest 
    {

        /// <summary>
        /// 反向解析ID。
        /// </summary>
        [SDKProperty("ptr_id", IsPath = true)]
        [JsonProperty("ptr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PtrId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPtrRequest {\n");
            sb.Append("  ptrId: ").Append(PtrId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPtrRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPtrRequest input)
        {
            if (input == null) return false;
            if (this.PtrId != input.PtrId || (this.PtrId != null && !this.PtrId.Equals(input.PtrId))) return false;

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
                if (this.PtrId != null) hashCode = hashCode * 59 + this.PtrId.GetHashCode();
                return hashCode;
            }
        }
    }
}
