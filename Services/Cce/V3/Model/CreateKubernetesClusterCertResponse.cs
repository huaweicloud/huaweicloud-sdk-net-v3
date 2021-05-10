using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateKubernetesClusterCertResponse : SdkResponse
    {

        /// <summary>
        /// API类型，固定值“Config”，该值不可修改。 
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// API版本，固定值“v1”。
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 当前未使用该字段，当前默认为空。
        /// </summary>
        [JsonProperty("preferences", NullValueHandling = NullValueHandling.Ignore)]
        public Object Preferences { get; set; }

        /// <summary>
        /// 集群列表。
        /// </summary>
        [JsonProperty("clusters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Clusters> Clusters { get; set; }

        /// <summary>
        /// 存放了指定用户的一些证书信息和ClientKey信息。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<Users> Users { get; set; }

        /// <summary>
        /// 上下文列表。
        /// </summary>
        [JsonProperty("contexts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Contexts> Contexts { get; set; }

        /// <summary>
        /// 当前上下文，若存在publicIp（虚拟机弹性IP）时为 external; 若不存在publicIp为 internal。
        /// </summary>
        [JsonProperty("current-context", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentContext { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKubernetesClusterCertResponse {\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  preferences: ").Append(Preferences).Append("\n");
            sb.Append("  clusters: ").Append(Clusters).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("  contexts: ").Append(Contexts).Append("\n");
            sb.Append("  currentContext: ").Append(CurrentContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKubernetesClusterCertResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKubernetesClusterCertResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
                ) && 
                (
                    this.Clusters == input.Clusters ||
                    this.Clusters != null &&
                    input.Clusters != null &&
                    this.Clusters.SequenceEqual(input.Clusters)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.Contexts == input.Contexts ||
                    this.Contexts != null &&
                    input.Contexts != null &&
                    this.Contexts.SequenceEqual(input.Contexts)
                ) && 
                (
                    this.CurrentContext == input.CurrentContext ||
                    (this.CurrentContext != null &&
                    this.CurrentContext.Equals(input.CurrentContext))
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
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.Clusters != null)
                    hashCode = hashCode * 59 + this.Clusters.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Contexts != null)
                    hashCode = hashCode * 59 + this.Contexts.GetHashCode();
                if (this.CurrentContext != null)
                    hashCode = hashCode * 59 + this.CurrentContext.GetHashCode();
                return hashCode;
            }
        }
    }
}
