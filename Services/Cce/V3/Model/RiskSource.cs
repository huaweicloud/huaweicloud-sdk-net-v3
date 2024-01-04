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
    /// 风险项来源
    /// </summary>
    public class RiskSource 
    {

        /// <summary>
        /// 配置风险项
        /// </summary>
        [JsonProperty("configurationRisks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigurationRisks> ConfigurationRisks { get; set; }

        /// <summary>
        /// 废弃API风险
        /// </summary>
        [JsonProperty("deprecatedAPIRisks", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeprecatedAPIRisks> DeprecatedAPIRisks { get; set; }

        /// <summary>
        /// 节点风险
        /// </summary>
        [JsonProperty("nodeRisks", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeRisks> NodeRisks { get; set; }

        /// <summary>
        /// 插件风险
        /// </summary>
        [JsonProperty("addonRisks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddonRisks> AddonRisks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskSource {\n");
            sb.Append("  configurationRisks: ").Append(ConfigurationRisks).Append("\n");
            sb.Append("  deprecatedAPIRisks: ").Append(DeprecatedAPIRisks).Append("\n");
            sb.Append("  nodeRisks: ").Append(NodeRisks).Append("\n");
            sb.Append("  addonRisks: ").Append(AddonRisks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RiskSource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RiskSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigurationRisks == input.ConfigurationRisks ||
                    this.ConfigurationRisks != null &&
                    input.ConfigurationRisks != null &&
                    this.ConfigurationRisks.SequenceEqual(input.ConfigurationRisks)
                ) && 
                (
                    this.DeprecatedAPIRisks == input.DeprecatedAPIRisks ||
                    this.DeprecatedAPIRisks != null &&
                    input.DeprecatedAPIRisks != null &&
                    this.DeprecatedAPIRisks.SequenceEqual(input.DeprecatedAPIRisks)
                ) && 
                (
                    this.NodeRisks == input.NodeRisks ||
                    this.NodeRisks != null &&
                    input.NodeRisks != null &&
                    this.NodeRisks.SequenceEqual(input.NodeRisks)
                ) && 
                (
                    this.AddonRisks == input.AddonRisks ||
                    this.AddonRisks != null &&
                    input.AddonRisks != null &&
                    this.AddonRisks.SequenceEqual(input.AddonRisks)
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
                if (this.ConfigurationRisks != null)
                    hashCode = hashCode * 59 + this.ConfigurationRisks.GetHashCode();
                if (this.DeprecatedAPIRisks != null)
                    hashCode = hashCode * 59 + this.DeprecatedAPIRisks.GetHashCode();
                if (this.NodeRisks != null)
                    hashCode = hashCode * 59 + this.NodeRisks.GetHashCode();
                if (this.AddonRisks != null)
                    hashCode = hashCode * 59 + this.AddonRisks.GetHashCode();
                return hashCode;
            }
        }
    }
}
