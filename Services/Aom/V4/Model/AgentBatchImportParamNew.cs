using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentBatchImportParamNew 
    {

        /// <summary>
        /// 导入待安装UniAgent的机器参数列表。
        /// </summary>
        [JsonProperty("agent_import_param_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgentImportParamNew> AgentImportParamList { get; set; }

        /// <summary>
        /// 代理区域ID： - 直连接入填0。 - 代理接入填实际代理区域ID。
        /// </summary>
        [JsonProperty("proxy_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProxyRegionId { get; set; }

        /// <summary>
        /// 安装机（代理机）的agent ID。
        /// </summary>
        [JsonProperty("installer_agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallerAgentId { get; set; }

        /// <summary>
        /// 是否需要安装ICAgent插件： - true：安装ICAgent插件。默认安装最新版本的ICAgent插件。 - false：不安装ICAgent插件。
        /// </summary>
        [JsonProperty("icagent_install_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IcagentInstallFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plugin_install_base_param", NullValueHandling = NullValueHandling.Ignore)]
        public PluginInstallBasicParam PluginInstallBaseParam { get; set; }

        /// <summary>
        /// 待安装的UniAgent版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 是否公网接入： - true：公网接入设置。 - false：代理接入设置。
        /// </summary>
        [JsonProperty("public_net_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicNetFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentBatchImportParamNew {\n");
            sb.Append("  agentImportParamList: ").Append(AgentImportParamList).Append("\n");
            sb.Append("  proxyRegionId: ").Append(ProxyRegionId).Append("\n");
            sb.Append("  installerAgentId: ").Append(InstallerAgentId).Append("\n");
            sb.Append("  icagentInstallFlag: ").Append(IcagentInstallFlag).Append("\n");
            sb.Append("  pluginInstallBaseParam: ").Append(PluginInstallBaseParam).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  publicNetFlag: ").Append(PublicNetFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentBatchImportParamNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentBatchImportParamNew input)
        {
            if (input == null) return false;
            if (this.AgentImportParamList != input.AgentImportParamList || (this.AgentImportParamList != null && input.AgentImportParamList != null && !this.AgentImportParamList.SequenceEqual(input.AgentImportParamList))) return false;
            if (this.ProxyRegionId != input.ProxyRegionId || (this.ProxyRegionId != null && !this.ProxyRegionId.Equals(input.ProxyRegionId))) return false;
            if (this.InstallerAgentId != input.InstallerAgentId || (this.InstallerAgentId != null && !this.InstallerAgentId.Equals(input.InstallerAgentId))) return false;
            if (this.IcagentInstallFlag != input.IcagentInstallFlag || (this.IcagentInstallFlag != null && !this.IcagentInstallFlag.Equals(input.IcagentInstallFlag))) return false;
            if (this.PluginInstallBaseParam != input.PluginInstallBaseParam || (this.PluginInstallBaseParam != null && !this.PluginInstallBaseParam.Equals(input.PluginInstallBaseParam))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PublicNetFlag != input.PublicNetFlag || (this.PublicNetFlag != null && !this.PublicNetFlag.Equals(input.PublicNetFlag))) return false;

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
                if (this.AgentImportParamList != null) hashCode = hashCode * 59 + this.AgentImportParamList.GetHashCode();
                if (this.ProxyRegionId != null) hashCode = hashCode * 59 + this.ProxyRegionId.GetHashCode();
                if (this.InstallerAgentId != null) hashCode = hashCode * 59 + this.InstallerAgentId.GetHashCode();
                if (this.IcagentInstallFlag != null) hashCode = hashCode * 59 + this.IcagentInstallFlag.GetHashCode();
                if (this.PluginInstallBaseParam != null) hashCode = hashCode * 59 + this.PluginInstallBaseParam.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PublicNetFlag != null) hashCode = hashCode * 59 + this.PublicNetFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
