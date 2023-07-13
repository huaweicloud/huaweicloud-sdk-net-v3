using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemSecurityPolicy 
    {

        /// <summary>
        /// 系统安全策略的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 系统安全策略的TLS协议列表。
        /// </summary>
        [JsonProperty("protocols", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocols { get; set; }

        /// <summary>
        /// 系统安全策略的加密套件列表。
        /// </summary>
        [JsonProperty("ciphers", NullValueHandling = NullValueHandling.Ignore)]
        public string Ciphers { get; set; }

        /// <summary>
        /// 项目id。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemSecurityPolicy {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  protocols: ").Append(Protocols).Append("\n");
            sb.Append("  ciphers: ").Append(Ciphers).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SystemSecurityPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SystemSecurityPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Protocols == input.Protocols ||
                    (this.Protocols != null &&
                    this.Protocols.Equals(input.Protocols))
                ) && 
                (
                    this.Ciphers == input.Ciphers ||
                    (this.Ciphers != null &&
                    this.Ciphers.Equals(input.Ciphers))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Protocols != null)
                    hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.Ciphers != null)
                    hashCode = hashCode * 59 + this.Ciphers.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
