using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 远程接入训练作业时需要的相关配置。
    /// </summary>
    public class JobEndpointsReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ssh", NullValueHandling = NullValueHandling.Ignore)]
        public SSHReq Ssh { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobEndpointsReq {\n");
            sb.Append("  ssh: ").Append(Ssh).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobEndpointsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobEndpointsReq input)
        {
            if (input == null) return false;
            if (this.Ssh != input.Ssh || (this.Ssh != null && !this.Ssh.Equals(input.Ssh))) return false;

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
                if (this.Ssh != null) hashCode = hashCode * 59 + this.Ssh.GetHashCode();
                return hashCode;
            }
        }
    }
}
