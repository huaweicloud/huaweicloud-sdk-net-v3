using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DedicatedStorageInfo 
    {

        /// <summary>
        /// 专属资源池存储资源规格码。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 专属资源池存储主机数量。
        /// </summary>
        [JsonProperty("host_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? HostNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DedicatedStorageInfo {\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  hostNum: ").Append(HostNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DedicatedStorageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DedicatedStorageInfo input)
        {
            if (input == null) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;
            if (this.HostNum != input.HostNum || (this.HostNum != null && !this.HostNum.Equals(input.HostNum))) return false;

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
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.HostNum != null) hashCode = hashCode * 59 + this.HostNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
