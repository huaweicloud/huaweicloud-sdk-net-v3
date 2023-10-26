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
    /// 规则详情。
    /// </summary>
    public class AppRulesSpec 
    {

        /// <summary>
        /// 服务类型,用于标记服务的分类,仅用于规则分类和界面展示。可以填写任意字段,如按技术栈分类可填写Java,Python。按作用分类可填写collector(采集),database(数据库)等。
        /// </summary>
        [JsonProperty("appType", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        /// <summary>
        /// 属性列表(暂不使用,可不传)。 cmdLine、env
        /// </summary>
        [JsonProperty("attrList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttrList { get; set; }

        /// <summary>
        /// 是否开启日志采集。 true、false
        /// </summary>
        [JsonProperty("detectLog", NullValueHandling = NullValueHandling.Ignore)]
        public string DetectLog { get; set; }

        /// <summary>
        /// 规则发现部分,数组中有多个对象时表示需要同时满足所有条件的进程才会被匹配到。 checkType为cmdLine时checkMode填contain,checkContent格式为[“xxx”]表示进程命令行参数中需要包含xxx。checkType为env时checkMode填contain,checkContent格式为 [\&quot;k1\&quot;,\&quot;v1\&quot;]表示进程环境变量中需要包含名为k1值为v1的环境变量。checkType为scope时checkMode填equals,checkContent格式为节点ID数组[\&quot;hostId1”,”hostId2”],表示规则仅会在这些节点上生效(如果不指定节点范围,规则将下发到该项目所有的节点)。
        /// </summary>
        [JsonProperty("discoveryRule", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiscoveryRule> DiscoveryRule { get; set; }

        /// <summary>
        /// 是否为默认规则。 true、false
        /// </summary>
        [JsonProperty("isDefaultRule", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDefaultRule { get; set; }

        /// <summary>
        /// 是否为规则预探测场景(预探测场景不会保存规则,仅用于规则下发之前验证该规则能否有效发现节点上的进程)。 true、false
        /// </summary>
        [JsonProperty("isDetect", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDetect { get; set; }

        /// <summary>
        /// 日志文件的后缀。 log、trace、out
        /// </summary>
        [JsonProperty("logFileFix", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LogFileFix { get; set; }

        /// <summary>
        /// 日志路径配置规则。 当cmdLineHash为固定字符串时,指定日志路径或者日志文件。否则只采集进程当前打开的以.log和.trace结尾的文件。nameType取值cmdLineHash时,args格式为[\&quot;00001\&quot;],value格式为[\&quot;/xxx/xx.log\&quot;],表示当启动命令是00001时,日志路径为/xxx/xx.log。
        /// </summary>
        [JsonProperty("logPathRule", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogPathRule> LogPathRule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nameRule", NullValueHandling = NullValueHandling.Ignore)]
        public NameRule NameRule { get; set; }

        /// <summary>
        /// 规则优先级。 1~9999的整数字符串,默认取值为9999
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppRulesSpec {\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  attrList: ").Append(AttrList).Append("\n");
            sb.Append("  detectLog: ").Append(DetectLog).Append("\n");
            sb.Append("  discoveryRule: ").Append(DiscoveryRule).Append("\n");
            sb.Append("  isDefaultRule: ").Append(IsDefaultRule).Append("\n");
            sb.Append("  isDetect: ").Append(IsDetect).Append("\n");
            sb.Append("  logFileFix: ").Append(LogFileFix).Append("\n");
            sb.Append("  logPathRule: ").Append(LogPathRule).Append("\n");
            sb.Append("  nameRule: ").Append(NameRule).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppRulesSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppRulesSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppType == input.AppType ||
                    (this.AppType != null &&
                    this.AppType.Equals(input.AppType))
                ) && 
                (
                    this.AttrList == input.AttrList ||
                    this.AttrList != null &&
                    input.AttrList != null &&
                    this.AttrList.SequenceEqual(input.AttrList)
                ) && 
                (
                    this.DetectLog == input.DetectLog ||
                    (this.DetectLog != null &&
                    this.DetectLog.Equals(input.DetectLog))
                ) && 
                (
                    this.DiscoveryRule == input.DiscoveryRule ||
                    this.DiscoveryRule != null &&
                    input.DiscoveryRule != null &&
                    this.DiscoveryRule.SequenceEqual(input.DiscoveryRule)
                ) && 
                (
                    this.IsDefaultRule == input.IsDefaultRule ||
                    (this.IsDefaultRule != null &&
                    this.IsDefaultRule.Equals(input.IsDefaultRule))
                ) && 
                (
                    this.IsDetect == input.IsDetect ||
                    (this.IsDetect != null &&
                    this.IsDetect.Equals(input.IsDetect))
                ) && 
                (
                    this.LogFileFix == input.LogFileFix ||
                    this.LogFileFix != null &&
                    input.LogFileFix != null &&
                    this.LogFileFix.SequenceEqual(input.LogFileFix)
                ) && 
                (
                    this.LogPathRule == input.LogPathRule ||
                    this.LogPathRule != null &&
                    input.LogPathRule != null &&
                    this.LogPathRule.SequenceEqual(input.LogPathRule)
                ) && 
                (
                    this.NameRule == input.NameRule ||
                    (this.NameRule != null &&
                    this.NameRule.Equals(input.NameRule))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.AppType != null)
                    hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.AttrList != null)
                    hashCode = hashCode * 59 + this.AttrList.GetHashCode();
                if (this.DetectLog != null)
                    hashCode = hashCode * 59 + this.DetectLog.GetHashCode();
                if (this.DiscoveryRule != null)
                    hashCode = hashCode * 59 + this.DiscoveryRule.GetHashCode();
                if (this.IsDefaultRule != null)
                    hashCode = hashCode * 59 + this.IsDefaultRule.GetHashCode();
                if (this.IsDetect != null)
                    hashCode = hashCode * 59 + this.IsDetect.GetHashCode();
                if (this.LogFileFix != null)
                    hashCode = hashCode * 59 + this.LogFileFix.GetHashCode();
                if (this.LogPathRule != null)
                    hashCode = hashCode * 59 + this.LogPathRule.GetHashCode();
                if (this.NameRule != null)
                    hashCode = hashCode * 59 + this.NameRule.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
