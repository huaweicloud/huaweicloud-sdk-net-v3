using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Detail 
    {

        /// <summary>
        /// 自定义时间key字段名称
        /// </summary>
        [JsonProperty("source_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceKey { get; set; }

        /// <summary>
        /// 正则解析正则表达式 单行完全正则，多行完全正则需填此字段
        /// </summary>
        [JsonProperty("regex", NullValueHandling = NullValueHandling.Ignore)]
        public string Regex { get; set; }

        /// <summary>
        /// 字段名称列表 与field_name字段保持一致
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keys { get; set; }

        /// <summary>
        /// 首行正则表达式
        /// </summary>
        [JsonProperty("multi_line_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string MultiLineRegex { get; set; }

        /// <summary>
        /// 是否上传原始日志
        /// </summary>
        [JsonProperty("keep_source", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KeepSource { get; set; }

        /// <summary>
        /// 是否上传解析失败日志
        /// </summary>
        [JsonProperty("keep_source_if_parse_error", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KeepSourceIfParseError { get; set; }

        /// <summary>
        /// 分隔符 自定义字符最大长度10，自定义字符串最大长度30
        /// </summary>
        [JsonProperty("split_sep", NullValueHandling = NullValueHandling.Ignore)]
        public string SplitSep { get; set; }

        /// <summary>
        /// 分隔符类型：char-自定义字符；special_char-不可见字符；string-自定义字符串
        /// </summary>
        [JsonProperty("split_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SplitType { get; set; }

        /// <summary>
        /// 添加的字段列表：&lt;字段名称 : 字段内容&gt;
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Fields { get; set; }

        /// <summary>
        /// 删除的字段列表
        /// </summary>
        [JsonProperty("drop_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DropKeys { get; set; }

        /// <summary>
        /// 字段重命名源字段名称列表
        /// </summary>
        [JsonProperty("source_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourceKeys { get; set; }

        /// <summary>
        /// 字段重命名替换的字段名称列表
        /// </summary>
        [JsonProperty("dest_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DestKeys { get; set; }

        /// <summary>
        /// json解析深度，默认为1层最大4层
        /// </summary>
        [JsonProperty("expand_depth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpandDepth { get; set; }

        /// <summary>
        /// json解析字段名称连接符
        /// </summary>
        [JsonProperty("expand_connector", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpandConnector { get; set; }

        /// <summary>
        /// 自定义时间时间格式
        /// </summary>
        [JsonProperty("source_format", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceFormat { get; set; }

        /// <summary>
        /// 自定义时间字段value
        /// </summary>
        [JsonProperty("source_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceValue { get; set; }

        /// <summary>
        /// 是否开启自定义时间的开关
        /// </summary>
        [JsonProperty("set_time", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SetTime { get; set; }

        /// <summary>
        /// 日志过滤白名单规则 key长度最大为256，value最大长度为128，key不可以重复
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Include { get; set; }

        /// <summary>
        /// 日志过滤白名单规则 key长度最大为256，value最大长度为128，key不可以重复
        /// </summary>
        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Exclude { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Detail {\n");
            sb.Append("  sourceKey: ").Append(SourceKey).Append("\n");
            sb.Append("  regex: ").Append(Regex).Append("\n");
            sb.Append("  keys: ").Append(Keys).Append("\n");
            sb.Append("  multiLineRegex: ").Append(MultiLineRegex).Append("\n");
            sb.Append("  keepSource: ").Append(KeepSource).Append("\n");
            sb.Append("  keepSourceIfParseError: ").Append(KeepSourceIfParseError).Append("\n");
            sb.Append("  splitSep: ").Append(SplitSep).Append("\n");
            sb.Append("  splitType: ").Append(SplitType).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  dropKeys: ").Append(DropKeys).Append("\n");
            sb.Append("  sourceKeys: ").Append(SourceKeys).Append("\n");
            sb.Append("  destKeys: ").Append(DestKeys).Append("\n");
            sb.Append("  expandDepth: ").Append(ExpandDepth).Append("\n");
            sb.Append("  expandConnector: ").Append(ExpandConnector).Append("\n");
            sb.Append("  sourceFormat: ").Append(SourceFormat).Append("\n");
            sb.Append("  sourceValue: ").Append(SourceValue).Append("\n");
            sb.Append("  setTime: ").Append(SetTime).Append("\n");
            sb.Append("  include: ").Append(Include).Append("\n");
            sb.Append("  exclude: ").Append(Exclude).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Detail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Detail input)
        {
            if (input == null) return false;
            if (this.SourceKey != input.SourceKey || (this.SourceKey != null && !this.SourceKey.Equals(input.SourceKey))) return false;
            if (this.Regex != input.Regex || (this.Regex != null && !this.Regex.Equals(input.Regex))) return false;
            if (this.Keys != input.Keys || (this.Keys != null && input.Keys != null && !this.Keys.SequenceEqual(input.Keys))) return false;
            if (this.MultiLineRegex != input.MultiLineRegex || (this.MultiLineRegex != null && !this.MultiLineRegex.Equals(input.MultiLineRegex))) return false;
            if (this.KeepSource != input.KeepSource || (this.KeepSource != null && !this.KeepSource.Equals(input.KeepSource))) return false;
            if (this.KeepSourceIfParseError != input.KeepSourceIfParseError || (this.KeepSourceIfParseError != null && !this.KeepSourceIfParseError.Equals(input.KeepSourceIfParseError))) return false;
            if (this.SplitSep != input.SplitSep || (this.SplitSep != null && !this.SplitSep.Equals(input.SplitSep))) return false;
            if (this.SplitType != input.SplitType || (this.SplitType != null && !this.SplitType.Equals(input.SplitType))) return false;
            if (this.Fields != input.Fields || (this.Fields != null && input.Fields != null && !this.Fields.SequenceEqual(input.Fields))) return false;
            if (this.DropKeys != input.DropKeys || (this.DropKeys != null && input.DropKeys != null && !this.DropKeys.SequenceEqual(input.DropKeys))) return false;
            if (this.SourceKeys != input.SourceKeys || (this.SourceKeys != null && input.SourceKeys != null && !this.SourceKeys.SequenceEqual(input.SourceKeys))) return false;
            if (this.DestKeys != input.DestKeys || (this.DestKeys != null && input.DestKeys != null && !this.DestKeys.SequenceEqual(input.DestKeys))) return false;
            if (this.ExpandDepth != input.ExpandDepth || (this.ExpandDepth != null && !this.ExpandDepth.Equals(input.ExpandDepth))) return false;
            if (this.ExpandConnector != input.ExpandConnector || (this.ExpandConnector != null && !this.ExpandConnector.Equals(input.ExpandConnector))) return false;
            if (this.SourceFormat != input.SourceFormat || (this.SourceFormat != null && !this.SourceFormat.Equals(input.SourceFormat))) return false;
            if (this.SourceValue != input.SourceValue || (this.SourceValue != null && !this.SourceValue.Equals(input.SourceValue))) return false;
            if (this.SetTime != input.SetTime || (this.SetTime != null && !this.SetTime.Equals(input.SetTime))) return false;
            if (this.Include != input.Include || (this.Include != null && input.Include != null && !this.Include.SequenceEqual(input.Include))) return false;
            if (this.Exclude != input.Exclude || (this.Exclude != null && input.Exclude != null && !this.Exclude.SequenceEqual(input.Exclude))) return false;

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
                if (this.SourceKey != null) hashCode = hashCode * 59 + this.SourceKey.GetHashCode();
                if (this.Regex != null) hashCode = hashCode * 59 + this.Regex.GetHashCode();
                if (this.Keys != null) hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.MultiLineRegex != null) hashCode = hashCode * 59 + this.MultiLineRegex.GetHashCode();
                if (this.KeepSource != null) hashCode = hashCode * 59 + this.KeepSource.GetHashCode();
                if (this.KeepSourceIfParseError != null) hashCode = hashCode * 59 + this.KeepSourceIfParseError.GetHashCode();
                if (this.SplitSep != null) hashCode = hashCode * 59 + this.SplitSep.GetHashCode();
                if (this.SplitType != null) hashCode = hashCode * 59 + this.SplitType.GetHashCode();
                if (this.Fields != null) hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.DropKeys != null) hashCode = hashCode * 59 + this.DropKeys.GetHashCode();
                if (this.SourceKeys != null) hashCode = hashCode * 59 + this.SourceKeys.GetHashCode();
                if (this.DestKeys != null) hashCode = hashCode * 59 + this.DestKeys.GetHashCode();
                if (this.ExpandDepth != null) hashCode = hashCode * 59 + this.ExpandDepth.GetHashCode();
                if (this.ExpandConnector != null) hashCode = hashCode * 59 + this.ExpandConnector.GetHashCode();
                if (this.SourceFormat != null) hashCode = hashCode * 59 + this.SourceFormat.GetHashCode();
                if (this.SourceValue != null) hashCode = hashCode * 59 + this.SourceValue.GetHashCode();
                if (this.SetTime != null) hashCode = hashCode * 59 + this.SetTime.GetHashCode();
                if (this.Include != null) hashCode = hashCode * 59 + this.Include.GetHashCode();
                if (this.Exclude != null) hashCode = hashCode * 59 + this.Exclude.GetHashCode();
                return hashCode;
            }
        }
    }
}
