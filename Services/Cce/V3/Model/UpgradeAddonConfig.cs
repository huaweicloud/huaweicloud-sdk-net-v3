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
    /// **参数解释：** 升级时插件操作配置。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class UpgradeAddonConfig 
    {

        /// <summary>
        /// **参数解释：** CCE插件名称 **约束限制：** 不涉及 **取值范围：** 集群中已安装的插件名称。[集群中已安装插件详情见[获取AddonInstance列表](https://support.huaweicloud.com/api-cce/cce_02_0326.html)](tag:hws) **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("addonTemplateName", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// **参数解释：** 升级插件的执行动作 **约束限制：** 不涉及 **取值范围：** - patch：表示升级插件版本  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// **参数解释：** 目标插件版本号 **约束限制：** 目标插件版本必须与目标集群版本配套。[集群版本配套关系见[查询AddonTemplates列表](https://support.huaweicloud.com/api-cce/cce_02_0321.html)](tag:hws) **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 插件参数列表，Key:Value格式。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Object Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeAddonConfig {\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeAddonConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeAddonConfig input)
        {
            if (input == null) return false;
            if (this.AddonTemplateName != input.AddonTemplateName || (this.AddonTemplateName != null && !this.AddonTemplateName.Equals(input.AddonTemplateName))) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Values != input.Values || (this.Values != null && !this.Values.Equals(input.Values))) return false;

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
                if (this.AddonTemplateName != null) hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
