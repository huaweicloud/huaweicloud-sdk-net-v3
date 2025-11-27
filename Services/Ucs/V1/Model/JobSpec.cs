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
    public class JobSpec 
    {

        /// <summary>
        /// Job类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 联邦uid
        /// </summary>
        [JsonProperty("federationUID", NullValueHandling = NullValueHandling.Ignore)]
        public string FederationUID { get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("resourceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceID { get; set; }

        /// <summary>
        /// 资源名字
        /// </summary>
        [JsonProperty("resourceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("extendparam", NullValueHandling = NullValueHandling.Ignore)]
        public string Extendparam { get; set; }

        /// <summary>
        /// 子Job
        /// </summary>
        [JsonProperty("subJobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Job> SubJobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSpec {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  federationUID: ").Append(FederationUID).Append("\n");
            sb.Append("  resourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  extendparam: ").Append(Extendparam).Append("\n");
            sb.Append("  subJobs: ").Append(SubJobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobSpec input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.FederationUID != input.FederationUID || (this.FederationUID != null && !this.FederationUID.Equals(input.FederationUID))) return false;
            if (this.ResourceID != input.ResourceID || (this.ResourceID != null && !this.ResourceID.Equals(input.ResourceID))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.Extendparam != input.Extendparam || (this.Extendparam != null && !this.Extendparam.Equals(input.Extendparam))) return false;
            if (this.SubJobs != input.SubJobs || (this.SubJobs != null && input.SubJobs != null && !this.SubJobs.SequenceEqual(input.SubJobs))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FederationUID != null) hashCode = hashCode * 59 + this.FederationUID.GetHashCode();
                if (this.ResourceID != null) hashCode = hashCode * 59 + this.ResourceID.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.Extendparam != null) hashCode = hashCode * 59 + this.Extendparam.GetHashCode();
                if (this.SubJobs != null) hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
