using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OnPremisesConfig 
    {

        /// <summary>
        /// 本地集群版本信息列表
        /// </summary>
        [JsonProperty("versionsInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<OnPremisesVersionInfo> VersionsInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnPremisesConfig {\n");
            sb.Append("  versionsInfo: ").Append(VersionsInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OnPremisesConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OnPremisesConfig input)
        {
            if (input == null) return false;
            if (this.VersionsInfo != input.VersionsInfo || (this.VersionsInfo != null && input.VersionsInfo != null && !this.VersionsInfo.SequenceEqual(input.VersionsInfo))) return false;

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
                if (this.VersionsInfo != null) hashCode = hashCode * 59 + this.VersionsInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
