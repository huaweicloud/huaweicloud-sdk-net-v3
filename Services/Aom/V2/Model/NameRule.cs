using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 服务发现规则命名部分。
    /// </summary>
    public class NameRule 
    {

        /// <summary>
        /// 服务命名部分，数组中有多个对象时表示将每个对象抽取到的字符串拼接作为服务的名称。 nameType取值cmdLine时args格式为[\&quot;start\&quot;,\&quot;end\&quot;]，表示抽取命令行中start、end之间的字符。 nameType取值cmdLine时args格式为[\&quot;aa\&quot;]，表示抽取环境变量名为aa对应的环境变量值。 nameType取值str时,args格式为[\&quot;fix\&quot;]，表示服务名称最后拼接固定文字fix。 nameType取值cmdLineHash时,args格式为[\&quot;0001\&quot;]，value格式为[\&quot;ser\&quot;]，表示当启动命令是0001时，服务名称为ser。
        /// </summary>
        [JsonProperty("appNameRule", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppNameRule> AppNameRule { get; set; }

        /// <summary>
        /// 应用命名部分。 nameType取值cmdLine时args格式为[\&quot;start\&quot;,\&quot;end\&quot;]，表示抽取命令行中start、end之间的字符。 nameType取值cmdLine时args格式为 [\&quot;aa\&quot;]，表示抽取环境变量名为aa对应的环境变量值。 nameType取值str时，args格式为[\&quot;fix\&quot;]，表示服务名称最后拼接固定文字fix。 nameType取值cmdLineHash时，args格式为[\&quot;0001\&quot;]，value格式为[\&quot;ser\&quot;]，表示当启动命令是0001时，应用名称为ser。
        /// </summary>
        [JsonProperty("applicationNameRule", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationNameRule> ApplicationNameRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NameRule {\n");
            sb.Append("  appNameRule: ").Append(AppNameRule).Append("\n");
            sb.Append("  applicationNameRule: ").Append(ApplicationNameRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NameRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NameRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppNameRule == input.AppNameRule ||
                    this.AppNameRule != null &&
                    input.AppNameRule != null &&
                    this.AppNameRule.SequenceEqual(input.AppNameRule)
                ) && 
                (
                    this.ApplicationNameRule == input.ApplicationNameRule ||
                    this.ApplicationNameRule != null &&
                    input.ApplicationNameRule != null &&
                    this.ApplicationNameRule.SequenceEqual(input.ApplicationNameRule)
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
                if (this.AppNameRule != null)
                    hashCode = hashCode * 59 + this.AppNameRule.GetHashCode();
                if (this.ApplicationNameRule != null)
                    hashCode = hashCode * 59 + this.ApplicationNameRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
