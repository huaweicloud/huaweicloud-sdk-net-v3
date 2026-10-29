using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskCheckSettingsItem 
    {

        /// <summary>
        /// **参数解释:** 规则集对应的编译配置条件键。 **约束限制:** 不涉及。 **取值范围:** - compileTool：编译工具。 - buildToolVersion：编译工具版本。 - compileScriptCmd：编译命令。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("cfg_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CfgKey { get; set; }

        /// <summary>
        /// **参数解释:** 当前检查参数key对应的开启状态，填写\&quot;on\&quot;即可。 **约束限制:** 不涉及。 **取值范围:** \&quot;on\&quot;。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释:** 规则集对应的编译配置值。 **约束限制:** cfg_key为compileTool、buildToolVersion时，cfg_value的值必填。 **取值范围:** - ant1.10.1-jdk1.8: ant镜像。 - ant1.10.13-jdk1.8: ant镜像。 - ant1.10.3-jdk1.8: ant镜像。 - ant1.9.4-jdk1.8: ant镜像。 - cmake2.8.12-gcc4.8.5: C++镜像。 - cmake2.8.12-gcc5.5.0: C++镜像。 - cmake2.8.12-gcc6.4.0: C++镜像。 - cmake2.8.12-gcc7.3.0: C++镜像。 - cmake3.10.1-gcc4.8.5: C++镜像。 - cmake3.10.1-gcc5.5.0: C++镜像。 - cmake3.10.1-gcc6.4.0: C++镜像。 - cmake3.10.1-gcc7.3.0: C++镜像。 - cmake3.15.5-gcc7.5.0: C++镜像。 - cmake3.15.5-gcc8.3.0: C++镜像。 - cmake3.16.0-gcc9.2.0: C++镜像。 - dotnetcore2.2: C#镜像。 - dotnetcore3.0: C#镜像。 - dotnetcore3.1: C#镜像。 - dotnetcore5.0: C#镜像。 - dotnetcore6.0: C#镜像。 - dotnetcore7.0: C#镜像。 - dotnetcore8.0: C#镜像。 - dotnetcore9.0: C#镜像。 - go-1.10.3: go镜像。 - go-1.11.6: go镜像。 - go-1.12.1: go镜像。 - go-1.23: go镜像。 - gradle2.13-jdk1.8: gradle镜像。 - gradle2.14.1-jdk1.8: gradle镜像。 - gradle3.3-jdk1.8: gradle镜像。 - gradle4.1-jdk1.8: gradle镜像。 - gradle4.2-jdk1.8: gradle镜像。 - gradle4.3-jdk1.8: gradle镜像。 - gradle4.4-jdk1.8: gradle镜像。 - gradle4.5-jdk1.8: gradle镜像。 - gradle4.6-jdk1.8: gradle镜像。 - gradle4.7-jdk1.8: gradle镜像。 - gradle4.8-jdk1.8: gradle镜像。 - gradle4.8-jdk1.9: gradle镜像。 - gradle4.9-jdk1.8: gradle镜像。 - gradle4.9-jdk1.9: gradle镜像。 - gradlew: gradle镜像。 - maven3.3.1-jdk7: maven镜像。 - maven3.5.3-jdk1.10: maven镜像。 - maven3.5.3-jdk1.11: maven镜像。 - maven3.5.3-jdk1.7: maven镜像。 - maven3.5.3-jdk1.8: maven镜像。 - maven3.5.3-jdk1.9: maven镜像。 - maven3.5.3-jdk7: maven镜像。 - maven3.5.3-jdk8-open: maven镜像。 - maven3.6.1-jdk10: maven镜像。 - maven3.6.1-jdk9: maven镜像。 - maven3.6.3-jdk11: maven镜像。 - maven3.8.5-jdk1.17: maven镜像。 - maven3.8.5-jdk17: maven镜像。 - maven3.9.5-jdk21: maven镜像。 - mono6-msbuild16-dotnetcoresdk2.1: C#镜像。 - mono6-msbuild16-dotnetcoresdk2.2: C#镜像。 - mono6-msbuild16-dotnetcoresdk3.0: C#镜像。 - mono6-msbuild16-dotnetcoresdk3.1: C#镜像。 - mono6-msbuild16-dotnetcoresdk5.0: C#镜像。 - mono6-msbuild16-dotnetcoresdk6.0: C#镜像。 - msbuild15-dotnetframework3.5: C#镜像。 - msbuild15-dotnetframework4.7.2: C#镜像。 - msbuild16-dotnetframework4.8: C#镜像。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("cfg_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CfgValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskCheckSettingsItem {\n");
            sb.Append("  cfgKey: ").Append(CfgKey).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  cfgValue: ").Append(CfgValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskCheckSettingsItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskCheckSettingsItem input)
        {
            if (input == null) return false;
            if (this.CfgKey != input.CfgKey || (this.CfgKey != null && !this.CfgKey.Equals(input.CfgKey))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CfgValue != input.CfgValue || (this.CfgValue != null && !this.CfgValue.Equals(input.CfgValue))) return false;

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
                if (this.CfgKey != null) hashCode = hashCode * 59 + this.CfgKey.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CfgValue != null) hashCode = hashCode * 59 + this.CfgValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
